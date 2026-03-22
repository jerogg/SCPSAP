using Datos;
using Datos.Cobranza;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Negocio.Cobranza
{
    public class CobranzaNegocio
    {
        CobranzaDatos CobranzaDatos = new CobranzaDatos();
        public List<AdeudoContribuyente> ObtenerAdeudosPorContribuyente(int Idcontribuyente, string Estado)
        {
            try
            {
                return CobranzaDatos.ObtenerAdeudosPorContribuyente(Idcontribuyente, Estado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
