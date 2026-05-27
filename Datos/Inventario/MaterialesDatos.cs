using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Modelos;

namespace Datos.Inventario
{
    public class MaterialesDatos
    {
        SCPSAPEntities SCPSAPEntities = new SCPSAPEntities();
        public List<Material> ObtenerMateriales()
        {
            try
            {
                return SCPSAPEntities.Materiales.ToList();
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
                return SCPSAPEntities.Materiales.Where(x => x.IdMaterial == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool AgregarMateriales(Material material)
        {
            try
            {
                if (material == null) throw new ArgumentNullException(nameof(material));
                Material materialExistente = SCPSAPEntities.Materiales.Where(x => x.IdMaterial != material.IdMaterial && x.Nombre == material.Nombre).FirstOrDefault();
                if (materialExistente != null)
                    throw new Exception("Ya existe un material con el mismo nombre");
                if (material.IdMaterial <= 0)
                    SCPSAPEntities.Materiales.Add(material);
                else
                {
                    Material actualizarMaterial = SCPSAPEntities.Materiales.Where(x => x.IdMaterial == material.IdMaterial).FirstOrDefault();
                    actualizarMaterial.Nombre = material.Nombre;
                    actualizarMaterial.StockActual = material.StockActual;
                    actualizarMaterial.StockMinimo = material.StockMinimo;
                    actualizarMaterial.UnidadMedida = material.UnidadMedida;
                }

                SCPSAPEntities.SaveChanges();
                return true;
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
                var material = SCPSAPEntities.Materiales
                                  .FirstOrDefault(c => c.IdMaterial == id);

                if (material != null)
                {
                    SCPSAPEntities.Materiales.Remove(material);
                    SCPSAPEntities.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Material> BuscarMateriales(string criterio)
        {
            var lista = from m in SCPSAPEntities.Materiales
                        where m.Nombre.Contains(criterio) select m;

            return lista.ToList();
        }

    }
}
