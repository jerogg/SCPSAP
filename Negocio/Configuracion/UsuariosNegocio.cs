using Datos;
using Datos.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Modelos;

namespace Negocio.Configuracion
{
    public class UsuariosNegocio
    {
        UsuarioDatos usuarioDatos = new UsuarioDatos();
        public List<UsuarioSistemaDto> ObtenerUsuarios()
        {
            try
            {
                return usuarioDatos.ObtenerUsuarios();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<UsuarioRol> ObtenerRoles()
        {
            try
            {
                return usuarioDatos.ObtenerRoles();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public UsuarioSistema ObtenerUsuariosPorId(int id)
        {
            try
            {
                UsuarioSistema usuarioSistema = usuarioDatos.ObtenerUsuariosPorId(id);
                usuarioSistema.PasswordHash = Compartido.Compartido.DescifrarAES(usuarioSistema.PasswordHash, "SCPSAP");

                return usuarioSistema;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
