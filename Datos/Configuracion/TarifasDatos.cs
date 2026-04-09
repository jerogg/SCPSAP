using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Configuracion
{
    public class TarifasDatos
    {
        SCPSAPEntities SCPSAPEntities = new SCPSAPEntities();

        /// <summary>
        /// Obtiene todos los contribuyentes desde Entity Framework.
        /// </summary>
        public List<Tarifa> ObtenerTarifas()
        {
            try
            {
                return SCPSAPEntities.Tarifas.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool AgregarTarifas(Tarifa tarifa)
        {
            try
            {
                if (tarifa == null) throw new ArgumentNullException(nameof(tarifa));
                Tarifa tarifaExistente = SCPSAPEntities.Tarifas.Where(x => x.IdTarifa != tarifa.IdTarifa && x.NombreTarifa == tarifa.NombreTarifa && x.MontoMensual == tarifa.MontoMensual).FirstOrDefault();
                if(tarifaExistente != null)
                    throw new Exception("Ya existe una tarifa con el mismo nombre y monto mensual");
                if (tarifa.IdTarifa <= 0)
                    SCPSAPEntities.Tarifas.Add(tarifa);
                else 
                {
                    Tarifa actualizarTarifa= SCPSAPEntities.Tarifas.Where(x => x.IdTarifa == tarifa.IdTarifa).FirstOrDefault();
                    actualizarTarifa.NombreTarifa = tarifa.NombreTarifa;
                    actualizarTarifa.MontoMensual = tarifa.MontoMensual;
                }

                SCPSAPEntities.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Tarifa ObtenerTarifasPorId(int id)
        {
            try
            {
                return SCPSAPEntities.Tarifas.FirstOrDefault(c => c.IdTarifa == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool EliminaTarifa(int id)
        {
            try
            {
                var tarifa = SCPSAPEntities.Tarifas
                                  .FirstOrDefault(c => c.IdTarifa == id);

                if (tarifa != null)
                {
                    SCPSAPEntities.Tarifas.Remove(tarifa);
                    SCPSAPEntities.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
