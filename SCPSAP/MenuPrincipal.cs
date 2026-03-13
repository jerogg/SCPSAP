using Datos;
using SCPSAP.Contribuyentes;
using SCPSAP.ControlesCobranza;
using SCPSAP.ControlesConfiguracion;
using SCPSAP.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SCPSAP
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnMenuContribuyentes_Click(object sender, EventArgs e)
        {
            
            splitContainerMenuPrincipal.Panel2.Controls.Clear();
            ListaContribuyentes contribuyentes = new ListaContribuyentes();
            contribuyentes.Dock = DockStyle.Fill;
            splitContainerMenuPrincipal.Panel2.Controls.Add(contribuyentes);

        }


        private void btnMenuReportes_Click(object sender, EventArgs e)
        {
            splitContainerMenuPrincipal.Panel2.Controls.Clear();
            Reportes.Reportes reporte = new Reportes.Reportes();
            reporte.Dock = DockStyle.Fill;
            splitContainerMenuPrincipal.Panel2.Controls.Add(reporte);
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            splitContainerMenuPrincipal.Panel2.Controls.Clear();
            Configuracion configuracion = new Configuracion();
            configuracion.Dock = DockStyle.Fill;
            splitContainerMenuPrincipal.Panel2.Controls.Add(configuracion);
        }

        private void btnMenuCobranza_Click(object sender, EventArgs e)
        {
            splitContainerMenuPrincipal.Panel2.Controls.Clear();
            Cobranza cobranza = new Cobranza();
            cobranza.Dock = DockStyle.Fill;
            splitContainerMenuPrincipal.Panel2.Controls.Add(cobranza);
        }
    }
}
