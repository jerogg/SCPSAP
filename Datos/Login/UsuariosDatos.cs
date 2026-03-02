using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Login
{
    public class UsuariosDatos
    {
        SCPSAPEntities SCPSAPEntities = new SCPSAPEntities();
        public bool ExisteUsuario(string Nombre, string Contrasena)
        {
            bool existeUsuario = false;
            try
            {

            var usuario = SCPSAPEntities.UsuarioSistemas.FirstOrDefault(x => x.NombreUsuario == Nombre && x.PasswordHash == Contrasena);

            if(usuario != null)
            existeUsuario = true;

            return existeUsuario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
