using Datos;
using Datos.Contribuyentes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Contribuyentes
{
    public class ContribuyentesNegocio
    {
        // Instancia de la capa de datos
        ContribuyentesDatos contribuyentesDatos = new ContribuyentesDatos();

        /// <summary>
        /// Obtiene la lista de contribuyentes delegando a la capa de datos.
        /// </summary>
        public List<Contribuyente> ObtenerContribuyentes()
        {
            try
            {
                return contribuyentesDatos.ObtenerContribuyentes();
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
                return contribuyentesDatos.ObtenerTarifas();
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
                return contribuyentesDatos.ObtenerEstados();
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
                return contribuyentesDatos.ObtenerContribuyentePorId(id);
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
                    nuevoContribuyente.FechaAlta = DateTime.Now; // Establece la fecha de registro al momento de agregar
                    nuevoContribuyente.FechaLimitePago = DateTime.Now.AddDays((double)nuevoContribuyente.DiasGracia); // Establece el estado inicial (activo)

                return contribuyentesDatos.AgregarContribuyente(nuevoContribuyente);
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
                return contribuyentesDatos.ActualizarContribuyente(contribuyenteActualizado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool ElimiContribuyente(int id)
        {
            try
            {
                return contribuyentesDatos.EliminarContribuyente(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Contribuyente> BuscarContribuyentes(string criterio)
        {
            ContribuyentesDatos datos = new ContribuyentesDatos();
            return datos.BuscarContribuyentes(criterio);
        }
    }
}
