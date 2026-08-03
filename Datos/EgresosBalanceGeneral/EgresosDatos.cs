using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Egresos
{
    public class EgresosDatos
    {
        SCPSAPEntities SCPSAPEntities = new SCPSAPEntities();

        public bool GuardaEgreso(string Concepto, decimal Monto, string Descripcion, int UsuarioId)
        {
            try
            {
                Egreso nuevoEgreso = new Egreso();
                nuevoEgreso.Concepto = Concepto;
                nuevoEgreso.Monto = Monto;
                nuevoEgreso.Descripcion = Descripcion;
                nuevoEgreso.IdUsuarioSistema = UsuarioId;

                SCPSAPEntities.Egresos.Add(nuevoEgreso);

                SCPSAPEntities.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
