using Datos.Egresos;
using Datos.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Egresos
{
    public class EgresosNegocio
    {
        EgresosDatos egresosDatos = new EgresosDatos();

        public bool GuardaEgreso(string Concepto, string Monto, string Descripcion, int UsuarioId)
        {
            try
            {
                return egresosDatos.GuardaEgreso(Concepto, decimal.Parse(Monto), Descripcion, UsuarioId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
