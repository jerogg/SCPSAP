using Datos.Egresos;
using Negocio.Egresos;
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
        EgresosNegocio egresosNegocio = new EgresosNegocio();

        public Egresos()
        {
            InitializeComponent();

            txbConcepto.TextChanged += activaGuardar;
            txbMonto.TextChanged += activaGuardar;
            txbDescripcion.TextChanged += activaGuardar;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try {
                var resultado = egresosNegocio.GuardaEgreso(txbConcepto.Text, txbMonto.Text, txbDescripcion.Text, Session.UsuarioId);
                if (resultado)
                    MessageBox.Show("Se guardo correctamente el egreso", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar egreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txbConcepto.Text = string.Empty;
            txbMonto.Text = string.Empty;
            txbDescripcion.Text = string.Empty;
            btnGuardar.Enabled = false;
        }

        private void activaGuardar(object sender, EventArgs e)
        {
            if(txbConcepto.Text != string.Empty && txbMonto.Text != string.Empty && txbDescripcion.Text != string.Empty)
                btnGuardar.Enabled = true;
            else
                btnGuardar.Enabled =false;
        }
    }
}
