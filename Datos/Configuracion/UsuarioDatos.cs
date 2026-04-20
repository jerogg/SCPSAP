using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Modelos;

namespace Datos.Configuracion
{
    public class UsuarioDatos
    {
       SCPSAPEntities SCPSAPEntities = new SCPSAPEntities();

       /// <summary>
       /// Obtiene todos los usuarios desde Entity Framework.
       /// </summary>
       public List<UsuarioSistemaDto> ObtenerUsuarios()
       {
         try
          {
                 var usuarios = from u in SCPSAPEntities.UsuarioSistemas
                                join r in SCPSAPEntities.UsuarioRols on u.IdRol equals r.IdRol
                                select new UsuarioSistemaDto
                                {
                                    IdUsuarioSistema = u.IdUsuarioSistema,
                                    NombreUsuario = u.NombreUsuario,
                                    PasswordHash = u.PasswordHash,
                                    Rol = r.Descripcion,
                                    Activo = (bool)u.Activo
                                };

                return usuarios.ToList();
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
                return SCPSAPEntities.UsuarioRols.ToList();
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
                return SCPSAPEntities.UsuarioSistemas.Where(x => x.IdRol == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}

