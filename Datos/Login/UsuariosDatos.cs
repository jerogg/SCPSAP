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
        public int ExisteUsuario(string Nombre, string Contrasena)
        {
            int usuarioId = 0;
            try
            {

            var usuario = SCPSAPEntities.UsuarioSistemas.FirstOrDefault(x => x.NombreUsuario == Nombre && x.PasswordHash == Contrasena);

            if(usuario != null)
                    usuarioId = usuario.IdUsuarioSistema;

            return usuarioId;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
