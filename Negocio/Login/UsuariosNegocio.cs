using Compartido;
using Datos.Login;
using System;

namespace Negocio.Login
{
    public class UsuariosNegocio
    {
        //Es la clase de la capa de datos
        UsuariosDatos usuarios = new UsuariosDatos();

        public int ValidaUsuarios(string Nombre, string Contrasena)
        {

            try
            {
                var contrasenaConvertida = Compartido.Compartido.CifrarAES(Contrasena, "SCPSAP");

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
    }
    }
