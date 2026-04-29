using Datos;
using Datos.Configuracion;
using Datos.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Inventario
{
    public class MaterialesNegocio
    {
        MaterialesDatos MaterialesDatos = new MaterialesDatos();
        public List<Material> ObtenerMateriales()
        {
            try
            {
                return MaterialesDatos.ObtenerMateriales();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
