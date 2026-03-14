using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Cobranza
{
    public class CobranzaDatos
    {
        SCPSAPEntities SCPSAPEntities = new SCPSAPEntities();

        public List<Adeudo> ObtenerAdeudosPorContribuyente(int Idcontribuyente) 
        {  
            return SCPSAPEntities.Adeudos.Where(a => a.IdContribuyente == Idcontribuyente).ToList();
        }
    }
}
