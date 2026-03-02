using Datos;
using Datos.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Login
{
    public class UsuariosNegocio
    {
        //Es la clase de la capa de datos
        UsuariosDatos usuarios = new UsuariosDatos();

        public bool ValidaUsuarios(string Nombre, string Contrasena)
        {

            try
            {
                var contrasenaConvertida = convertirSHA256(Contrasena);

                //Se valida si el nombre o contrasenia del usuario esta vacio
                if (Nombre == string.Empty && Contrasena == string.Empty)
                {
                    throw new Exception("Ingresar campos obligatorios");
                }
                else
                {
                    //Se llama al metodo de la capa de datos
                    return usuarios.ExisteUsuario(Nombre, contrasenaConvertida);
                }
            }
            catch (Exception ex)
            {
                //Regresa un error en caso de suceder
                throw new Exception(ex.Message);
            }

        }

        public string convertirSHA256(string texto)
        {
            //Se convierte la contraseña a SHA256 para compararla con la contraseña almacenada en la base de datos
            StringBuilder Sb = new StringBuilder();
            using (var hash = System.Security.Cryptography.SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(texto));
                foreach (byte b in result)
                    Sb.Append(b.ToString("x2"));
            }
            return Sb.ToString();
        }

        public string decodificarSHA256(string texto)
        {
            //Se decodifica la contraseña para mostrarla en caso de ser necesario
            byte[] data = Convert.FromBase64String(texto);
            string decodedString = Encoding.UTF8.GetString(data);
            return decodedString;
        }
    }
    }
