using Datos;
using Datos.Configuracion;
using Datos.Contribuyentes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Configuracion
{
    public class TarifasNegocio
    {
        TarifasDatos TarifasDatos = new TarifasDatos();
        public List<Tarifa> ObtenerTarifas()
        {
            try
            {
                return TarifasDatos.ObtenerTarifas();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
