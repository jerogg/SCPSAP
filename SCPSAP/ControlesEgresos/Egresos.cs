using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCPSAP.ControlesEgresos
{
    public partial class Egresos : UserControl
    {
        public Egresos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void txbMonto_TextChanged(object sender, EventArgs e)
        {
            decimal Cantidad = 0m;
            string CantidadText = txbMonto.Text?.Trim() ?? string.Empty;
            // Intentar parsear con la cultura actual
            if (!decimal.TryParse(CantidadText, NumberStyles.Number, CultureInfo.CurrentCulture, out Cantidad))
            {
                // Intentar con InvariantCulture como fallback
                if (!decimal.TryParse(CantidadText, NumberStyles.Number, CultureInfo.InvariantCulture, out Cantidad))
                {
                    MessageBox.Show("El monto debe ser un valor numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbMonto.Focus();
                    return;
                }
            }
        }
    }
}
