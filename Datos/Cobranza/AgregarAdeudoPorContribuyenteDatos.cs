using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos.Cobranza
{
    public class AgregarAdeudoPorContribuyenteDatos
    {
        SCPSAPEntities SCPSAPEntities = new SCPSAPEntities();

        public List<Adeudo> ObtenerAdeudosNoRelacionadosConContribuyente(int contribuyenteId)
        {
            try
            {
                return SCPSAPEntities.Adeudos.Where(a => !SCPSAPEntities.AdeudoContribuyentes.Any(ac => ac.IdAdeudo == a.IdAdeudo && ac.IdContribuyente == contribuyenteId)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
