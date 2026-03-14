using Datos;
using Datos.Cobranza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Cobranza
{
    public class CobranzaNegocio
    {
        CobranzaDatos CobranzaDatos = new CobranzaDatos();
        public List<Adeudo> ObtenerAdeudosPorContribuyente(int Idcontribuyente)
        {
            try
            {
                return CobranzaDatos.ObtenerAdeudosPorContribuyente(Idcontribuyente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
