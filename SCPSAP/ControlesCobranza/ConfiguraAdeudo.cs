using CapaUI;
using Datos;
using Negocio.Cobranza;
using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using static Entidades.Modelos;

namespace SCPSAP.ControlesCobranza
{
    public partial class ConfiguraAdeudo : UserControl
    {
        ConfiguraAdeudoNegocio configuraAdeudoNegocio = new ConfiguraAdeudoNegocio();

        // Evento opcional para quien use este control
        public event Action<ContribuyenteDto> ContribuyenteSeleccionado;

        // Adeudo en edición (puede ser null si no se está editando)
        private Adeudo _adeudoEnEdicion = null;
        public ConfiguraAdeudo()
        {
            InitializeComponent();
            Theme.ApplyTo(this);

            // Suscribir eventos
            if (dgvAdeudosConfigurados != null)
            {
                dgvAdeudosConfigurados.SelectionChanged += dgvAdeudosConfigurados_SelectionChanged;
                dgvAdeudosConfigurados.CellClick += dgvAdeudosConfigurados_SelectionChanged; // para clicks en celdas
            }
          
            // Mostrar cursor de mano al posar sobre la columna de eliminar (imagen)
            dgvAdeudosConfigurados.CellMouseEnter += dgvAdeudosConfigurados_CellMouseEnter;
            dgvAdeudosConfigurados.CellMouseLeave += dgvAdeudosConfigurados_CellMouseLeave;

            // Cargar adeudos configurados inicialmente
            CargarAdeudosConfigurados();
        }

        private void dgvAdeudosConfigurados_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarEstadoBotonActualizar();
        }

        private void ActualizarEstadoBotonActualizar()
        {
            try
            {
                bool tieneSeleccion = false;

                if (dgvAdeudosConfigurados != null)
                {
                    // Preferir SelectedRows cuando el SelectionMode lo permita
                    if (dgvAdeudosConfigurados.SelectedRows != null && dgvAdeudosConfigurados.SelectedRows.Count > 0)
                    {
                        tieneSeleccion = dgvAdeudosConfigurados.SelectedRows.Cast<DataGridViewRow>()
                            .Any(r => r != null && r.Index >= 0);
                    }
                    else
                    {
                        // Fallback a CurrentRow / CurrentCell
                        tieneSeleccion = dgvAdeudosConfigurados.CurrentRow != null && dgvAdeudosConfigurados.CurrentRow.Index >= 0;
                    }
                }

                btnActualizarAdeudo.Enabled = tieneSeleccion;
            }
            catch
            {
                btnActualizarAdeudo.Enabled = false;
            }
        }

        /// <summary>
        /// Carga la grilla de "ADEUDOS CONFIGURADOS" (tabla Adeudo).
        /// </summary>
        private void CargarAdeudosConfigurados()
        {
            try
            {
                // Desactivar generación automática de columnas para respetar las columnas definidas en el Designer
                dgvAdeudosConfigurados.AutoGenerateColumns = false;

                var adeudos = configuraAdeudoNegocio.ObtenerAdeudosConfigurados();

                // Proyección ligera para el DataGridView
                dgvAdeudosConfigurados.DataSource = adeudos;

                // Forzar que la columna "Eliminar" quede en la última posición visual
                if (dgvAdeudosConfigurados.Columns.Contains("EliminarAdeudo"))
                {
                    dgvAdeudosConfigurados.Columns["EliminarAdeudo"].DisplayIndex = dgvAdeudosConfigurados.Columns.Count - 1;
                    // Asegurar que el AutoSizeMode no provoque reordenamientos inesperados
                    dgvAdeudosConfigurados.Columns["EliminarAdeudo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar adeudos configurados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ------------------------------
        // Métodos públicos para los botones
        // ------------------------------

        // Obtiene el IdAdeudo desde la fila seleccionada en dgvAdeudosConfigurados (0 si no hay selección)
        public int ObtenerIdAdeudoSeleccionadoDesdeGrid()
        {
            if (dgvAdeudosConfigurados == null) return 0;

            DataGridViewRow fila = null;
            if (dgvAdeudosConfigurados.SelectedRows != null && dgvAdeudosConfigurados.SelectedRows.Count > 0)
            {
                fila = dgvAdeudosConfigurados.SelectedRows[0];
            }
            else if (dgvAdeudosConfigurados.CurrentRow != null)
            {
                fila = dgvAdeudosConfigurados.CurrentRow;
            }

            if (fila == null) return 0;

            object valor = null;
            if (dgvAdeudosConfigurados.Columns.Contains("IdConfiguracionAdeudo"))
            {
                valor = fila.Cells["IdConfiguracionAdeudo"].Value;
            }
            else if (dgvAdeudosConfigurados.Columns.Count > 0)
            {
                valor = fila.Cells[0].Value;
            }

            if (valor == null) return 0;
            int id;
            return int.TryParse(Convert.ToString(valor), out id) ? id : 0;
        }

        // Nuevo: prepara una nueva entidad Adeudo para edición.
        // UI debe tomar _adeudoEnEdicion y mostrar los campos en el editor (panel propio).
        public void NuevoAdeudo()
        {
            _adeudoEnEdicion = new Adeudo
            {
                IdAdeudo = 0,
                Periodo = txbPeriodo.Text,
                Concepto = txbConcepto.Text,
                EsMontoDiferente = false,
                Monto = 0m,
                FechaGeneracion = DateTime.Now
            };

            // Dejar que la UI habilite el panel de edición para completar datos.
            // Ejemplo: pnlEditor.Visible = true; txbPeriodo.Text = ""; ...
        }

        // Actualizar: carga la entidad seleccionada para edición.
        public void ActualizarAdeudoSeleccionado()
        {
            int id = ObtenerIdAdeudoSeleccionadoDesdeGrid();
            if (id <= 0)
            {
                MessageBox.Show("Seleccione un adeudo para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var adeudo = configuraAdeudoNegocio.ObtenerAdeudoPorId(id);
                if (adeudo == null)
                {
                    MessageBox.Show("No se encontró el adeudo seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _adeudoEnEdicion = adeudo;
                txbPeriodo.Text = _adeudoEnEdicion.Periodo;
                txbConcepto.Text = _adeudoEnEdicion.Concepto;
                dtpFechaLimitePago.Value = _adeudoEnEdicion.FechaVencimiento;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar adeudo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cancelar: descarta la edición actual.
        public void CancelarEdicionAdeudo()
        {
            _adeudoEnEdicion = null;
        }

        // Guardar: recibe una entidad Adeudo (p. ej. creada por la UI desde controles) y la persiste.
        // Devuelve true si se guardó correctamente y recarga la grilla de adeudos configurados.
        public bool GuardarAdeudo(Adeudo adeudo)
        {
            try
            {
                var guardado = configuraAdeudoNegocio.GuardarAdeudo(adeudo);
                if (guardado == null)
                {
                    MessageBox.Show("No fue posible guardar el adeudo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Recargar grilla
                CargarAdeudosConfigurados();

                LimpiarControles();

                // actualizar estado interno
                _adeudoEnEdicion = null;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar adeudo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Eliminar: elimina el adeudo seleccionado (si existe) y recarga la grilla.
        public void EliminarAdeudoSeleccionado(DataGridViewCellEventArgs e)
        {
            int id = ObtenerIdAdeudoSeleccionadoDesdeGrid();
            if (id <= 0)
            {
                MessageBox.Show("Seleccione un adeudo para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            try
            {
                // Confirmación antes de eliminar
                var fila = dgvAdeudosConfigurados.Rows[e.RowIndex];
                string concepto = fila.Cells["ConceptoAdeudo"].Value != null ? fila.Cells["ConceptoAdeudo"].Value.ToString() : string.Empty;
                var pregunta = $"¿Desea eliminar el adeudo con concepto de '" + concepto + "'?";
                var dr = MessageBox.Show(pregunta, "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.Yes)
                {
                    var ok = configuraAdeudoNegocio.EliminarAdeudo(id);
                    if (ok)
                    {
                        CargarAdeudosConfigurados();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el adeudo seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al eliminar adeudo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevoAdeudo_Click(object sender, EventArgs e)
        {
            btnGuardarAdeudo.Enabled = true; // Asegurar que el botón de guardar esté habilitado para un nuevo adeudo
            btnActualizarAdeudo.Enabled = false;
            btnNuevoAdeudo.Enabled = false;
            btnCancelarConfiguracionAdeudo.Enabled = true;
            txbConcepto.Enabled = true;
            txbPeriodo.Enabled = true;
            dtpFechaLimitePago.Enabled = true;
            cbxMontoDiferente.Enabled = true;
            NuevoAdeudo();
        }

        private void btnActualizarAdeudo_Click(object sender, EventArgs e)
        {
            ActualizarAdeudoSeleccionado();
            txbConcepto.Enabled = true;
            txbPeriodo.Enabled = true;
            dtpFechaLimitePago.Enabled = true;
            btnNuevoAdeudo.Enabled = false;
            btnActualizarAdeudo.Enabled = false;
            btnCancelarConfiguracionAdeudo.Enabled = true;
            btnGuardarAdeudo.Enabled = true;
            cbxMontoDiferente.Enabled = true;
        }

        private void btnCancelarConfiguracionAdeudo_Click(object sender, EventArgs e)
        {
            CancelarEdicionAdeudo();
            LimpiarControles();
        }

        private void btnGuardarAdeudo_Click(object sender, EventArgs e)
        {
            try
            {

                // Validaciones:
                // 1) Fecha límite debe ser mayor al día de hoy
                DateTime fechaLimite = dtpFechaLimitePago.Value.Date;
                if (fechaLimite <= DateTime.Today)
                {
                    MessageBox.Show("La fecha límite de pago debe ser mayor al día de hoy.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpFechaLimitePago.Focus();
                    return;
                }

                // 2) Si el monto es diferente, debe ser numérico (decimal)
                decimal monto = 0m;
                if (cbxMontoDiferente.Checked)
                {
                    string montoText = txbMonto.Text?.Trim() ?? string.Empty;
                    if (string.IsNullOrEmpty(montoText))
                    {
                        MessageBox.Show("Ingrese el monto cuando la opción 'Monto diferente' está activada.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbMonto.Focus();
                        return;
                    }

                    // Intentar parsear con la cultura actual
                    if (!decimal.TryParse(montoText, NumberStyles.Number, CultureInfo.CurrentCulture, out monto))
                    {
                        // Intentar con InvariantCulture como fallback
                        if (!decimal.TryParse(montoText, NumberStyles.Number, CultureInfo.InvariantCulture, out monto))
                        {
                            MessageBox.Show("El monto debe ser un valor numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txbMonto.Focus();
                            return;
                        }
                    }

                    if (monto < 0m)
                    {
                        MessageBox.Show("El monto no puede ser negativo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbMonto.Focus();
                        return;
                    }
                }

                // Preparar la entidad Adeudo para guardar
                if (_adeudoEnEdicion == null)
                {
                    NuevoAdeudo();
                }

                _adeudoEnEdicion.Periodo = txbPeriodo.Text.Trim();
                _adeudoEnEdicion.Concepto = txbConcepto.Text.Trim();
                _adeudoEnEdicion.FechaVencimiento = fechaLimite;
                _adeudoEnEdicion.EsMontoDiferente = cbxMontoDiferente.Checked;
                _adeudoEnEdicion.Monto = cbxMontoDiferente.Checked ? monto : 0m;

                var result = GuardarAdeudo(_adeudoEnEdicion);

                if (result)
                {
                    txbConcepto.Enabled = false;
                    txbPeriodo.Enabled = false;
                    dtpFechaLimitePago.Enabled = false;
                    cbxMontoDiferente.Enabled = false;
                    btnNuevoAdeudo.Enabled = true;
                    btnActualizarAdeudo.Enabled = true;
                    btnCancelarConfiguracionAdeudo.Enabled = false;
                    txbMonto.Text = txbMonto.Text != "" ? txbMonto.Text : "0";
                    MessageBox.Show("Se agregó correctamente el adeudo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar adeudo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAdeudosConfigurados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvAdeudosConfigurados.Columns["EliminarAdeudo"].Index && e.RowIndex >= 0)
            {
                EliminarAdeudoSeleccionado(e);
            }
        }

        private void LimpiarControles()
        {
            // Limpiar controles y restablecer estado
            btnNuevoAdeudo.Enabled = true;
            btnActualizarAdeudo.Enabled = true;
            btnCancelarConfiguracionAdeudo.Enabled = false;
            cbxMontoDiferente.Enabled = false;
            txbPeriodo.Clear();
            txbConcepto.Clear();
            txbMonto.Clear();
            cbxMontoDiferente.Checked = false;
            btnGuardarAdeudo.Enabled = false;
            dtpFechaLimitePago.Value = DateTime.Now;
        }

        private void cbxMontoDiferente_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMontoDiferente.Checked)
            {
                txbMonto.Enabled = true;
                txbMonto.Focus();
            }
            else
            {
                txbMonto.Enabled = false;
                txbMonto.Clear();
            }
        }

        // Cambia el cursor cuando el ratón entra en una celda; pone mano si es la columna Eliminar
        private void dgvAdeudosConfigurados_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    var col = dgvAdeudosConfigurados.Columns[e.ColumnIndex];
                    if (string.Equals(col.Name, "EliminarAdeudo", StringComparison.OrdinalIgnoreCase))
                    {
                        dgvAdeudosConfigurados.Cursor = Cursors.Hand;
                    }
                    else
                    {
                        dgvAdeudosConfigurados.Cursor = Cursors.Default;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Restaurar cursor al salir de la celda
        private void dgvAdeudosConfigurados_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvAdeudosConfigurados.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
