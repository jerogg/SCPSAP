using Datos;
using Datos.Configuracion;
using Datos.Contribuyentes;
using Datos.Inventario;
using Datos.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Modelos;

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

        public Material ObtenerMaterialesPorId(int id)
        {
            try
            {
                Material material = MaterialesDatos.ObtenerMaterialesPorId(id);

                return material;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AgregarMateriales(Material material)
        {
            try
            {
                MaterialesDatos.AgregarMateriales(material);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool EliminarMaterial(int id)
        {
            try
            {
                return MaterialesDatos.EliminarMaterial(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Material> BuscarMateriales(string criterio)
        {
            MaterialesDatos datos = new MaterialesDatos();
            return datos.BuscarMateriales(criterio);
        }


        public bool GuardaEntradasSalidas(int idMaterial, int existencias, int cantidad, string tipoMovimiento, string observaciones, int UsuarioId)
        {
            int existenciasActualizadas = 0;
            try
            {
                if (tipoMovimiento == "Salida")
                {
                    if(existencias < cantidad)
                        throw new Exception("Las Existencias son menores a la cantidad de salida");

                    existenciasActualizadas = existencias - cantidad;
                }else
                    existenciasActualizadas= existencias + cantidad;

                    return MaterialesDatos.GuardaEntradasSalidas(idMaterial, existenciasActualizadas, cantidad, tipoMovimiento, observaciones, UsuarioId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
