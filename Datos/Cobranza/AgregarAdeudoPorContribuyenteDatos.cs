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

        public bool RelacionarAdeudos(List<int> ids, int contribuyenteId)
        {
            bool result = false;
            using (var tx = SCPSAPEntities.Database.BeginTransaction())
            {

            try
            {
                foreach (var id in ids)
                {
                    Adeudo adeudo = SCPSAPEntities.Adeudos.Where(x => x.IdAdeudo == id).FirstOrDefault();
                    Contribuyente contribuyente = SCPSAPEntities.Contribuyentes.Where(x => x.IdContribuyente == contribuyenteId).FirstOrDefault();
                    Tarifa tarifa = SCPSAPEntities.Tarifas.Where(x=> x.IdTarifa == contribuyente.IdTarifa).FirstOrDefault();

                       

                    if (adeudo != null)
                    {
                        AdeudoContribuyente adeudoContribuyente = new AdeudoContribuyente();
                        adeudoContribuyente.IdContribuyente = contribuyenteId;
                        adeudoContribuyente.IdAdeudo = id;
                        adeudoContribuyente.Periodo = adeudo.Periodo;
                        adeudoContribuyente.Concepto = adeudo.Concepto;
                        adeudoContribuyente.MontoOriginal = adeudo.EsMontoDiferente == true? adeudo.Monto : tarifa.MontoMensual;
                        adeudoContribuyente.Estado = "Pendiente";
                        adeudoContribuyente.FechaGeneracion = DateTime.Now;
                        adeudoContribuyente.FechaVencimiento = DateTime.Now.AddDays((int)(contribuyente.DiasGracia));

                        SCPSAPEntities.AdeudoContribuyentes.Add(adeudoContribuyente);
                    }
                    
                }
                    SCPSAPEntities.SaveChanges();

                    tx.Commit();
                    result = true;

                return result;
            }
            catch (Exception ex)
            {
                    tx.Rollback();
                    throw new Exception(ex.Message);
            }
            }
        }
    }
}
