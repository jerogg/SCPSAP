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

        public List<Tarifa> ObtenerTarifas()
        {
            try
            {
                return contribuyentesDatos.ObtenerTarifas();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Estado> ObtenerEstados()
        {
            try
            {
                return contribuyentesDatos.ObtenerEstados();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public Contribuyente ObtenerContribuyentePorId(int id)
        {
            try
            {
                return contribuyentesDatos.ObtenerContribuyentePorId(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
