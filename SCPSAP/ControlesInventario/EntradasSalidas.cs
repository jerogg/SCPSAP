using CapaUI;
using Datos;
using Negocio.Inventario;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace SCPSAP.ControlesInventario
{
    public partial class EntradasSalidas : UserControl
    {
        MaterialesNegocio materialesNegocio = new MaterialesNegocio();
        // Id seleccionado actualmente en el DataGridView
        private int _idMaterialSeleccionado = 0;

        List<Material> listaMateriales = new List<Material>();
        public EntradasSalidas()
        {
            InitializeComponent();
            Theme.ApplyTo(this);
            CargarMateriales();
            btnGuardar.Enabled = false;
            // Suscribir eventos
            if (listaMateriales.Count > 0)
            {
                cbxTipoMovimiento.SelectedIndexChanged += ValidaCampos;
                txbExistencias.TextChanged += ValidaCampos;
                txbCantidad.TextChanged += ValidaCampos;
                txbObservaciones.TextChanged += ValidaCampos;
            }
        }

        private void CargarMateriales()
        {
            try
            {
                listaMateriales = materialesNegocio.ObtenerMateriales();
                cbxMaterial.DataSource = listaMateriales;
                cbxMaterial.DisplayMember = "Nombre"; 
                cbxMaterial.ValueMember = "IdMaterial";

                if (listaMateriales.Count > 0)
                {
                    cbxMaterial.SelectedIndex = 0;
                    EnableFields(true);
                    _idMaterialSeleccionado = listaMateriales[0].IdMaterial;
                    cargaExistencias(_idMaterialSeleccionado);
                }
                else 
                {
                    EnableFields(false);
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar materiales", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnableFields(bool enable)
        {
            cbxTipoMovimiento.Enabled = enable;
            txbCantidad.Enabled = enable;
            txbObservaciones.Enabled = enable;
            btnGuardar.Enabled = enable;
        }

        private void cargaExistencias(int IdMaterial)
        {
            txbExistencias.Text = listaMateriales.Find(x=> x.IdMaterial == IdMaterial).StockActual.ToString();
        }

        private void cbxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = cbxMaterial.SelectedIndex;
            _idMaterialSeleccionado = listaMateriales[selectedIndex].IdMaterial;
            EnableFields(true);
            cargaExistencias(_idMaterialSeleccionado);
        }

        private void ValidaCampos(object sender, EventArgs e)
        {
            if (cbxTipoMovimiento.SelectedIndex != -1 && txbCantidad.Text.Length > 0 && txbObservaciones.Text.Length > 0)
                btnGuardar.Enabled = true;
            else 
                btnGuardar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int existencias = int.Parse(txbExistencias.Text);
            int cantidad = int.Parse(txbCantidad.Text);
            string tipoMovimiento = cbxTipoMovimiento.Text;
            string observaciones = txbObservaciones.Text;

            var pregunta = $"¿Desea guardar el movimiento {(!string.IsNullOrEmpty(tipoMovimiento) ? $"\"{tipoMovimiento}\" (cantidad de  {cantidad})" : $"cantidad de {cantidad}")}?";
            var dr = MessageBox.Show(pregunta, "Confirmar el movimiento", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                materialesNegocio.GuardaEntradasSalidas(_idMaterialSeleccionado, existencias, cantidad, tipoMovimiento, observaciones, Session.UsuarioId);
                MessageBox.Show("Se guardo correctamente la " + cbxTipoMovimiento.Text, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargaExistencias(_idMaterialSeleccionado);
                limpiarCampos();
            }

        }

        private void limpiarCampos()
        {
            txbCantidad.Text = string.Empty;
            txbObservaciones.Text = string.Empty;
            cbxTipoMovimiento.SelectedIndex = -1;
        }

        private void txbCantidad_TextChanged(object sender, EventArgs e)
        {
            decimal Cantidad = 0m;
            string CantidadText = txbCantidad.Text?.Trim() ?? string.Empty;
            // Intentar parsear con la cultura actual
            if (!decimal.TryParse(CantidadText, NumberStyles.Number, CultureInfo.CurrentCulture, out Cantidad))
            {
                // Intentar con InvariantCulture como fallback
                if (!decimal.TryParse(CantidadText, NumberStyles.Number, CultureInfo.InvariantCulture, out Cantidad))
                {
                    MessageBox.Show("El monto debe ser un valor numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbCantidad.Focus();
                    return;
                }
            }
        }
    }
}
