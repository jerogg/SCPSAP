using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Contribuyentes
{
    public class ContribuyentesDatos
    {
        SCPSAPEntities SCPSAPEntities = new SCPSAPEntities();

        /// <summary>
        /// Obtiene todos los contribuyentes desde Entity Framework.
        /// </summary>
        public List<Contribuyente> ObtenerContribuyentes( )
        {
            try
            {
                return SCPSAPEntities.Contribuyentes.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

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

        public List<Estado> ObtenerEstados()
        {
            try
            {
                return SCPSAPEntities.Estados.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public Contribuyente ObtenerContribuyentePorId(int id)
        {
            try
            {
                return SCPSAPEntities.Contribuyentes.FirstOrDefault(c => c.IdContribuyente == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool AgregarContribuyente(Contribuyente nuevoContribuyente)
        {
            try
            {
                SCPSAPEntities.Contribuyentes.Add(nuevoContribuyente);
                SCPSAPEntities.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool ActualizarContribuyente(Contribuyente contribuyenteActualizado)
        {
            try
            {
                var contribuyenteExistente = SCPSAPEntities.Contribuyentes.FirstOrDefault(c => c.IdContribuyente == contribuyenteActualizado.IdContribuyente);
                if (contribuyenteExistente != null)
                {
                    // Actualizar propiedades
                    contribuyenteExistente.Nombre = contribuyenteActualizado.Nombre;
                    contribuyenteExistente.Direccion = contribuyenteActualizado.Direccion;
                    contribuyenteExistente.IdTarifa = contribuyenteActualizado.IdTarifa;
                    contribuyenteExistente.IdEstado = contribuyenteActualizado.IdEstado;
                    contribuyenteExistente.Telefono = contribuyenteActualizado.Telefono;
                    contribuyenteExistente.Email = contribuyenteActualizado.Email;
                    contribuyenteExistente.DiasGracia = contribuyenteActualizado.DiasGracia;
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
