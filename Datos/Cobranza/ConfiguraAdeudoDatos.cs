using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Cobranza
{
    public class ConfiguraAdeudoDatos
    {
        SCPSAPEntities SCPSAPEntities = new SCPSAPEntities();

        /// <summary>
        /// Obtiene los adeudos configurados (tabla Adeudo).
        /// </summary>
        public List<Adeudo> ObtenerAdeudosConfigurados()
        {
            try
            {
                // Orden descendente por fecha de generación para mostrar los más recientes primero
                return SCPSAPEntities.Adeudos.OrderByDescending(a => a.FechaGeneracion).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Obtiene un adeudo por Id.
        /// </summary>
        public Adeudo ObtenerAdeudoPorId(int id)
        {
            try
            {
                return SCPSAPEntities.Adeudos.FirstOrDefault(a => a.IdAdeudo == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Inserta o actualiza un adeudo (tabla Adeudo).
        /// Si IdAdeudo == 0 lo inserta; en otro caso actualiza los campos Periodo, Concepto y FechaGeneracion.
        /// Al insertar, genera un registro en AdeudoContribuyente para cada contribuyente.
        /// Operación realizada dentro de una transacción.
        /// </summary>
        public Adeudo GuardarAdeudo(Adeudo adeudo)
        {
            decimal monto = 0m;

            if (adeudo == null) throw new ArgumentNullException(nameof(adeudo));

            using (var tx = SCPSAPEntities.Database.BeginTransaction())
            {
                try
                {
                    if (adeudo.IdAdeudo == 0)
                    {
                        if (adeudo.FechaGeneracion == default(DateTime))
                            adeudo.FechaGeneracion = DateTime.Now;

                        // Insertar adeudo
                        SCPSAPEntities.Adeudos.Add(adeudo);
                        SCPSAPEntities.SaveChanges(); // obtener Id generado

                        // Generar AdeudoContribuyente para cada contribuyente existente
                        var contribuyentes = SCPSAPEntities.Contribuyentes.Where(x => x.IdEstado == 1).ToList();
                        foreach (var c in contribuyentes)
                        {
                            if (adeudo.EsMontoDiferente == true)
                                monto = adeudo.Monto;
                            else
                            {
                                Tarifa tarifa = SCPSAPEntities.Tarifas.FirstOrDefault(t => t.IdTarifa == c.IdTarifa);
                                monto = tarifa != null ? tarifa.MontoMensual : 0m;
                            }


                            var ac = new AdeudoContribuyente
                            {
                                IdContribuyente = c.IdContribuyente,
                                IdAdeudo = adeudo.IdAdeudo,
                                Periodo = adeudo.Periodo,
                                Concepto = adeudo.Concepto,
                                MontoOriginal = monto,
                                Recargo = 0m,
                                OtrosCargos = 0m,
                                //TotalAdeudo = 0m,
                                Estado = "Pendiente",
                                FechaGeneracion = adeudo.FechaGeneracion,
                                FechaVencimiento = adeudo.FechaVencimiento.AddDays((double)c.DiasGracia)
                            };
                            SCPSAPEntities.AdeudoContribuyentes.Add(ac);
                        }

                        SCPSAPEntities.SaveChanges();
                    }
                    else
                    {
                        // Actualizar adeudo existente
                        var existente = SCPSAPEntities.Adeudos.FirstOrDefault(a => a.IdAdeudo == adeudo.IdAdeudo);
                        if (existente == null)
                            throw new InvalidOperationException("No se encontró el adeudo a actualizar.");

                        existente.Periodo = adeudo.Periodo;
                        existente.Concepto = adeudo.Concepto;
                        existente.FechaGeneracion = adeudo.FechaGeneracion == default(DateTime) ? existente.FechaGeneracion : adeudo.FechaGeneracion;
                        existente.FechaVencimiento = adeudo.FechaVencimiento;

                        // Actualizar datos relacionados en AdeudoContribuyente (Periodo/Concepto/FechaGeneracion)
                        var adeudosContrib = SCPSAPEntities.AdeudoContribuyentes.Where(ac => ac.IdAdeudo == adeudo.IdAdeudo).ToList();
                        foreach (var ac in adeudosContrib)
                        {
                            if (adeudo.EsMontoDiferente == true)
                                monto = adeudo.Monto;
                            else
                            {
                                Contribuyente contribuyente = SCPSAPEntities.Contribuyentes.FirstOrDefault(c => c.IdContribuyente == ac.IdContribuyente);
                                Tarifa tarifa = SCPSAPEntities.Tarifas.FirstOrDefault(t => t.IdTarifa == contribuyente.IdTarifa);
                                monto = tarifa != null ? tarifa.MontoMensual : 0m;
                            }
                            ac.MontoOriginal = monto;
                            ac.Periodo = adeudo.Periodo;
                            ac.Concepto = adeudo.Concepto;
                            if (adeudo.FechaGeneracion != default(DateTime))
                                ac.FechaGeneracion = adeudo.FechaGeneracion;
                            ac.FechaVencimiento = adeudo.FechaVencimiento.AddDays((double)SCPSAPEntities.Contribuyentes.Where(x => x.IdContribuyente == ac.IdContribuyente).FirstOrDefault().DiasGracia);
                        }

                        SCPSAPEntities.SaveChanges();
                    }

                    tx.Commit();

                    // Devolver entidad actualizada/insertada desde BD
                    return SCPSAPEntities.Adeudos.FirstOrDefault(a => a.IdAdeudo == adeudo.IdAdeudo);
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        /// <summary>
        /// Elimina un adeudo configurado por Id.
        /// </summary>
        public bool EliminarAdeudo(int id)
        {
            try
            {
                var adeudo = SCPSAPEntities.Adeudos.FirstOrDefault(a => a.IdAdeudo == id);
                if (adeudo == null) return false;

                SCPSAPEntities.Adeudos.Remove(adeudo);
                SCPSAPEntities.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Guarda un pago y sus detalles, actualiza estado de los adeudos y lo hace en una transacción.
        /// </summary>
        /// <param name="pago">Entidad Pago con IdContribuyente, MetodoPago e IdUsuarioSistema (opcional).</param>
        /// <param name="detalles">Lista de tuplas (IdAdeudo, MontoAplicado).</param>
        /// <returns>true si se guardó correctamente.</returns>
        public bool GuardarPago(Pago pago, List<Tuple<int, decimal>> detalles)
        {
            if (pago == null) throw new ArgumentNullException(nameof(pago));
            if (detalles == null || detalles.Count == 0) throw new ArgumentException("No hay detalles de pago.", nameof(detalles));

            //using (var ctx = new SCPSAPEntities())
            using (var tx = SCPSAPEntities.Database.BeginTransaction())
            {
                try
                {
                    pago.FechaPago = DateTime.Now;
                    pago.TotalPagado = detalles.Sum(d => d.Item2);

                    if (pago.DetallePagoes == null)
                        pago.DetallePagoes = new List<DetallePago>();

                    foreach (var d in detalles)
                    {
                        var detalle = new DetallePago
                        {
                            IdAdeudoContribuyente = d.Item1,
                            MontoAplicado = d.Item2
                        };
                        pago.DetallePagoes.Add(detalle);

                        var adeudo = SCPSAPEntities.AdeudoContribuyentes.FirstOrDefault(a => a.IdAdeudo == d.Item1 && a.IdContribuyente == pago.IdContribuyente);
                        if (adeudo != null)
                            adeudo.Estado = "Pagado";
                    }

                    SCPSAPEntities.Pagos.Add(pago);
                    SCPSAPEntities.SaveChanges();

                    tx.Commit();
                    return true;
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }
    }
}
