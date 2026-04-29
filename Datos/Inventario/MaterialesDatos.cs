using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Inventario
{
    public class MaterialesDatos
    {
        SCPSAPEntities SCPSAPEntities = new SCPSAPEntities();
        public List<Material> ObtenerMateriales()
        {
            try
            {
                return SCPSAPEntities.Materiales.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
