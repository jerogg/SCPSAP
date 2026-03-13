using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Configuracion
{
    internal class UsuarioDatos
    {
    }
}
public class UsuarioDatos
{
    SCPSAPEntities SCPSAPEntities = new SCPSAPEntities();

    /// <summary>
    /// Obtiene todos los contribuyentes desde Entity Framework.
    /// </summary>
    public List<Contribuyente> ObtenerUsuario()
    {
        try
        {
            return SCPSAPEntities.UsuarioRols.ToList();
        }
         catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
