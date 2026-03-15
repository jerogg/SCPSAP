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

        public List<Adeudo> ObtenerAdeudosPorContribuyente(int Idcontribuyente, string estado ) 
        {  
            return SCPSAPEntities.Adeudos.Where(a => a.IdContribuyente == Idcontribuyente && a.Estado == estado).ToList();
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
                            IdAdeudo = d.Item1,
                            MontoAplicado = d.Item2
                        };
                        pago.DetallePagoes.Add(detalle);

                        // Actualizar estado del adeudo aplicado
                        var adeudo = SCPSAPEntities.Adeudos.FirstOrDefault(a => a.IdAdeudo == d.Item1);
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
