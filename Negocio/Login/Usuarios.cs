using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Login
{
    public class Usuarios
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
