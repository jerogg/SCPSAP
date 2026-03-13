using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Configuracion
{
    public class TarifasDatos
    {
        SCPSAPEntities SCPSAPEntities = new SCPSAPEntities();

        /// <summary>
        /// Obtiene todos los contribuyentes desde Entity Framework.
        /// </summary>
        public List<Tarifa> ObtenerTarifas()
        {
            try
            {
                return SCPSAPEntities.Tarifas.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
