using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Datos.Cobranza
{
    public class CobranzaDatos
    {
        SCPSAPEntities SCPSAPEntities = new SCPSAPEntities();

        public List<AdeudoContribuyente> ObtenerAdeudosPorContribuyente(int Idcontribuyente, string estado ) 
        {  
            return SCPSAPEntities.AdeudoContribuyentes.Where(a => a.IdContribuyente == Idcontribuyente && a.Estado == estado).ToList();
        }

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
        /// Devuelve la entidad guardada (con Id generado en caso de inserción).
        /// </summary>
        public Adeudo GuardarAdeudo(Adeudo adeudo)
        {
            if (adeudo == null) throw new ArgumentNullException(nameof(adeudo));
            try
            {
                if (adeudo.IdAdeudo == 0)
                {
                    if (adeudo.FechaGeneracion == default(DateTime))
                        adeudo.FechaGeneracion = DateTime.Now;

                    SCPSAPEntities.Adeudos.Add(adeudo);
                }
                else
                {
                    var existente = SCPSAPEntities.Adeudos.FirstOrDefault(a => a.IdAdeudo == adeudo.IdAdeudo);
                    if (existente == null)
                        throw new InvalidOperationException("No se encontró el adeudo a actualizar.");

                    existente.Periodo = adeudo.Periodo;
                    existente.Concepto = adeudo.Concepto;
                    existente.FechaGeneracion = adeudo.FechaGeneracion == default(DateTime) ? existente.FechaGeneracion : adeudo.FechaGeneracion;
                }

                SCPSAPEntities.SaveChanges();

                // Si fue inserción, adeudo.IdAdeudo ya contiene el valor generado por EF.
                return adeudo.IdAdeudo == 0
                    ? SCPSAPEntities.Adeudos.OrderByDescending(a => a.IdAdeudo).FirstOrDefault()
                    : SCPSAPEntities.Adeudos.FirstOrDefault(a => a.IdAdeudo == adeudo.IdAdeudo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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

            using (var tx = SCPSAPEntities.Database.BeginTransaction())
            {
                try
                {
                    // Asignar fecha y total
                    pago.FechaPago = DateTime.Now;
                    pago.TotalPagado = detalles.Sum(d => d.Item2);

                    // Asegurar colección inicializada
                    if (pago.DetallePagoes == null)
                        pago.DetallePagoes = new List<DetallePago>();

                    // Añadir detalles vinculados al pago
                    foreach (var d in detalles)
                    {
                        var detalle = new DetallePago
                        {
                            IdAdeudoContribuyente = d.Item1,
                            MontoAplicado = d.Item2
                        };
                        pago.DetallePagoes.Add(detalle);

                        // Actualizar estado del adeudo aplicado
                        var adeudo = SCPSAPEntities.AdeudoContribuyentes.FirstOrDefault(a => a.IdAdeudoContribuyente == d.Item1);
                        if (adeudo != null)
                        {
                            adeudo.Estado = "Pagado";
                        }
                    }

                    // Guardar pago (y detalles por cascade)
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
