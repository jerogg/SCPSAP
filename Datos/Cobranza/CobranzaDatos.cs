using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Datos.Cobranza
{
    public class CobranzaDatos
    {
        SCPSAPEntities SCPSAPEntities = new SCPSAPEntities();

        public List<AdeudoContribuyente> ObtenerAdeudosPorContribuyente(int Idcontribuyente, string estado ) 
        {  
            return SCPSAPEntities.AdeudoContribuyentes.Where(a => a.IdContribuyente == Idcontribuyente && a.Estado == estado).ToList();
        }

        
    }
}
