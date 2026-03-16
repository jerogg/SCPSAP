using Datos;
using Datos.Cobranza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Cobranza
{
    public class CobranzaNegocio
    {
        CobranzaDatos CobranzaDatos = new CobranzaDatos();
        public List<AdeudoContribuyente> ObtenerAdeudosPorContribuyente(int Idcontribuyente, string Estado)
        {
            try
            {
                return CobranzaDatos.ObtenerAdeudosPorContribuyente(Idcontribuyente, Estado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Obtiene la lista de adeudos configurados (tabla Adeudo) delegando a la capa de datos.
        /// </summary>
        public List<Adeudo> ObtenerAdeudosConfigurados()
        {
            try
            {
                return CobranzaDatos.ObtenerAdeudosConfigurados();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Obtiene un adeudo configurado por Id.
        /// </summary>
        public Adeudo ObtenerAdeudoPorId(int id)
        {
            try
            {
                return CobranzaDatos.ObtenerAdeudoPorId(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Inserta o actualiza un adeudo configurado.
        /// </summary>
        public Adeudo GuardarAdeudo(Adeudo adeudo)
        {
            try
            {
                if (adeudo == null) throw new ArgumentNullException(nameof(adeudo));
                if (string.IsNullOrWhiteSpace(adeudo.Periodo)) throw new ArgumentException("Periodo es requerido.");
                if (string.IsNullOrWhiteSpace(adeudo.Concepto)) throw new ArgumentException("Concepto es requerido.");

                return CobranzaDatos.GuardarAdeudo(adeudo);
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
                if (id <= 0) throw new ArgumentException("Id de adeudo inválido.");
                return CobranzaDatos.EliminarAdeudo(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Guarda el pago y sus detalles (wrapping a la capa de datos).
        /// Valida que el método de pago esté presente y que el total > 0.
        /// </summary>
        public bool GuardarPago(Pago pago, List<Tuple<int, decimal>> detalles)
        {
            try
            {
                if (pago == null)
                    throw new ArgumentNullException(nameof(pago), "Objeto pago no puede ser nulo.");

                // Validar método de pago
                if (string.IsNullOrWhiteSpace(pago.MetodoPago))
                    throw new ArgumentException("El método de pago es requerido.");

                // Validar detalles
                if (detalles == null || detalles.Count == 0)
                    throw new ArgumentException("No hay adeudos seleccionados para pagar.");

                // Validar total > 0
                decimal total = detalles.Sum(d => d.Item2);
                if (total <= 0m)
                    throw new ArgumentException("El total a pagar debe ser mayor a cero.");

                // Asignar TotalPagado en la entidad por seguridad
                pago.TotalPagado = total;

                return CobranzaDatos.GuardarPago(pago, detalles);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
