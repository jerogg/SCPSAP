using Datos;
using Datos.Cobranza;
using System;
using System.Collections.Generic;

namespace Negocio.Cobranza
{
    public class AgregarAdeudoPorContribuyenteNegocio
    {
        AgregarAdeudoPorContribuyenteDatos agregarAdeudoPorContribuyenteDatos = new AgregarAdeudoPorContribuyenteDatos();

        /// <summary>
        /// Obtiene la lista de adeudos no relacionados con el contribuyente.
        /// </summary>  
        public List<Adeudo> ObtenerAdeudosNoRelacionadosConContribuyente(int contribuyenteId)
        {
            try
            {
                return agregarAdeudoPorContribuyenteDatos.ObtenerAdeudosNoRelacionadosConContribuyente(contribuyenteId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
