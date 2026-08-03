using SCPSAP.ControlesEgresos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCPSAP.ControlesEgresosIngresos
{
    public partial class EgresosBalanceGeneral : UserControl
    {
        public EgresosBalanceGeneral()
        {
            InitializeComponent();

            pnlEgresos.Controls.Clear();
            Egresos egreso = new Egresos();
            egreso.Dock = DockStyle.Fill;
            pnlEgresos.Controls.Add(egreso);

            pnlEgresosBalanceGeneral.Controls.Clear();
            BalanceGeneral ingreso = new BalanceGeneral();
            ingreso.Dock = DockStyle.Fill;
            pnlEgresosBalanceGeneral.Controls.Add(ingreso);
        }
    }
}
