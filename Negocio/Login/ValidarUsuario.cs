using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Login
{
    public class ValidarUsuario
    {
        public bool ValidaUsuarios(string Nombre, string Contrasena)
        {

            try
            {
                if (Nombre == string.Empty && Contrasena == string.Empty)
                {
                    return false;
                }
                else
                {
                    //llamar metodo para validar el usuario en la capa de datos


                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
