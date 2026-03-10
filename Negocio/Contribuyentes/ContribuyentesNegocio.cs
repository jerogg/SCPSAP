using Datos;
using Datos.Contribuyentes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Contribuyentes
{
    public class ContribuyentesNegocio
    {
        // Instancia de la capa de datos
        ContribuyentesDatos contribuyentesDatos = new ContribuyentesDatos();

        /// <summary>
        /// Obtiene la lista de contribuyentes delegando a la capa de datos.
        /// </summary>
        public List<Contribuyente> ObtenerContribuyentes()
        {
            try
            {
                return contribuyentesDatos.ObtenerContribuyentes();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
