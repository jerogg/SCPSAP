using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Modelos;

namespace Datos.Contribuyentes
{
    public class ContribuyentesDatos
    {
        SCPSAPEntities SCPSAPEntities = new SCPSAPEntities();

        /// <summary>
        /// Obtiene todos los contribuyentes desde Entity Framework.
        /// </summary>
        public List<ContribuyenteDto> ObtenerContribuyentes( )
        {
            try
            {
                var query = from c in SCPSAPEntities.Contribuyentes
                            join t in SCPSAPEntities.Tarifas on c.IdTarifa equals t.IdTarifa into tj
                            from t in tj.DefaultIfEmpty()
                            join e in SCPSAPEntities.Estados on c.IdEstado equals e.IdEstado into ej
                            from e in ej.DefaultIfEmpty()
                            select new ContribuyenteDto
                            {
                                IdContribuyente = c.IdContribuyente,
                                Nombre = c.Nombre,
                                Direccion = c.Direccion,
                                Telefono = c.Telefono,
                                FechaAlta = c.FechaAlta,
                                IdEstado = c.IdEstado,
                                EstadoDescripcion = e != null ? e.Descripcion : null,
                                IdTarifa = c.IdTarifa,
                                Tarifa =  t.MontoMensual,
                                Email = c.Email,
                                FechaUltimoAviso = c.FechaUltimoAviso,
                                FechaLimitePago = c.FechaLimitePago,
                                DiasGracia = c.DiasGracia
                            };

                return query.ToList();

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

        public bool EliminarContribuyente(int id)
        {
            try
            {
                var contribuyente = SCPSAPEntities.Contribuyentes
                                  .FirstOrDefault(c => c.IdContribuyente == id);

                if (contribuyente != null)
                {
                    SCPSAPEntities.Contribuyentes.Remove(contribuyente);
                    SCPSAPEntities.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Contribuyente> BuscarContribuyentes(string criterio)
        {
            List<Contribuyente> lista = SCPSAPEntities.Contribuyentes
                .Where(x => x.Nombre.StartsWith(criterio)) 
                .ToList();

            return lista;
        }
    
    }
}
