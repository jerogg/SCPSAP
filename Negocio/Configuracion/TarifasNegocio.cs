using Datos;
using Datos.Configuracion;
using Datos.Contribuyentes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Configuracion
{
    public class TarifasNegocio
    {
        TarifasDatos TarifasDatos = new TarifasDatos();
        public List<Tarifa> ObtenerTarifas()
        {
            try
            {
                return TarifasDatos.ObtenerTarifas();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AgregarTarifas(Tarifa nuevaTarifa)
        {
            try
            {
                TarifasDatos.AgregarTarifas(nuevaTarifa);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

// Método de extensión para `TarifasDatos` que añade `AgregarTarifas` si no existe en la capa de datos.
// Si la clase `TarifasDatos` ya implementa persistencia, borre esta sección y use esa implementación.
namespace Datos.Configuracion
{
    public static class TarifasDatosExtensions
    {
        public static void AgregarTarifas(this TarifasDatos datos, Tarifa tarifa)
        {
            if (datos == null) throw new ArgumentNullException(nameof(datos));
            if (tarifa == null) throw new ArgumentNullException(nameof(tarifa));

            // Implementación mínima: obtener lista actual y añadir la tarifa.
            // Sustituya por la lógica real de persistencia si está disponible.
            var list = datos.ObtenerTarifas();
            if (list == null)
            {
                // Si ObtenerTarifas puede devolver null, inicializamos una lista local.
                list = new List<Tarifa>();
            }

            list.Add(tarifa);

            // Nota: añadir a la lista retornada puede no persistir cambios si la capa de datos
            // devuelve una copia. Si necesita que esto persista (BD/archivo), implemente la
            // lógica de persistencia real dentro de `TarifasDatos` y elimine esta extensión.
        }
    }
}
