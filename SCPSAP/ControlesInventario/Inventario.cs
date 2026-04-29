using SCPSAP.ControlesConfiguracion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCPSAP.ControlesInventario
{
    public partial class Inventario : UserControl
    {
        public Inventario()
        {
            InitializeComponent();

            pnlMateriales.Controls.Clear();
            ListaInventario listaInventario = new ListaInventario();
            listaInventario.Dock = DockStyle.Fill;
            pnlMateriales.Controls.Add(listaInventario);
        }
    }
}
