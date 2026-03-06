using SCPSAP.Contribuyentes;
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
    }
}
