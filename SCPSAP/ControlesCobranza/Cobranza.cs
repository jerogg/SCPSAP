using Datos;
using Negocio.Cobranza;
using Negocio.Contribuyentes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Entidades.Modelos;

namespace SCPSAP.ControlesCobranza
{
    public partial class Cobranza : UserControl
    {
        CobranzaNegocio cobranzaNegocio = new CobranzaNegocio();

        private Timer _filterTimer;
        private ListBox _lstResultados;
        private ContribuyentesNegocio _contribNeg;
        private List<ContribuyenteDto> _cacheContribuyentes;

        // Evento opcional para quien use este control
        public event Action<ContribuyenteDto> ContribuyenteSeleccionado;

        // Id del contribuyente actualmente mostrado en la grilla de adeudos
        private int _currentContribuyenteId = 0;

        // Adeudo en edición (puede ser null si no se está editando)
        private Adeudo _adeudoEnEdicion = null;

        public Cobranza()
        {
            InitializeComponent();
            _contribNeg = new ContribuyentesNegocio();
            InitializeSearchControls();

            // Suscribir eventos
            if (dgvAdeudosConfigurados != null)
            {
                dgvAdeudosConfigurados.SelectionChanged += dgvAdeudosConfigurados_SelectionChanged;
                dgvAdeudosConfigurados.CellClick += dgvAdeudosConfigurados_SelectionChanged; // para clicks en celdas
            }

            // Seleccionar método de pago por defecto ("Efectivo") si está en la lista.
            try
            {
                if (cbxMetodoPago != null)
                {
                    if (cbxMetodoPago.Items.Contains("Efectivo"))
                        cbxMetodoPago.SelectedItem = "Efectivo";
                    else if (cbxMetodoPago.Items.Count > 0)
                        cbxMetodoPago.SelectedIndex = 0;
                }
            }
            catch
            {
                // Silencioso: no queremos romper la inicialización por este ajuste.
            }

            // Eventos para manejar la selección (checkbox) en la grilla de adeudos
            dgvAdeudosPorContribuyente.CurrentCellDirtyStateChanged += DgvAdeudos_CurrentCellDirtyStateChanged;
            dgvAdeudosPorContribuyente.CellValueChanged += DgvAdeudos_CellValueChanged;
            dgvAdeudosPorContribuyente.DataBindingComplete += DgvAdeudos_DataBindingComplete;

            // Botón pagar
            btnPagar.Click += BtnPagar_Click;

            // Asegurar estado inicial de controles (deshabilitados si no hay datos)
            UpdateAdeudosControlsState();

            // Cargar adeudos configurados inicialmente
            CargarAdeudosConfigurados();

            // Recargar lista de adeudos configurados al cambiar a la pestaña de configuración
            tbCobranza.SelectedIndexChanged += (s, e) =>
            {
                if (tbCobranza.SelectedTab == tbPageConfiguraAdeudos)
                {
                    CargarAdeudosConfigurados();
                }
            };
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
        // Inicializa los controles usados para búsqueda sin usar DataGridView.
        private void InitializeSearchControls()
        {
            // Lista de resultados creada dinámicamente (no requiere cambios en el Designer)
            _lstResultados = new ListBox
            {
                Visible = false,
                Width = txbName.Width,
                Left = txbName.Left,
                Top = txbName.Bottom + 2,
                Height = 180
            };
            // Ajuste de anclaje para que la lista siga el ancho del TextBox si el control cambia de tamaño
            _lstResultados.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _lstResultados.DoubleClick += LstResultados_DoubleClick;
            _lstResultados.KeyDown += LstResultados_KeyDown;

            this.Controls.Add(_lstResultados);

            // Timer para debounce
            _filterTimer = new Timer { Interval = 350 };
            _filterTimer.Tick += FilterTimer_Tick;

            // Eventos del TextBox
            txbName.TextChanged += TxbName_TextChanged;
            txbName.KeyDown += TxbName_KeyDown;
        }

        private void TxbName_TextChanged(object sender, EventArgs e)
        {
            _filterTimer.Stop();
            _filterTimer.Start();
        }

        private void FilterTimer_Tick(object sender, EventArgs e)
        {
            _filterTimer.Stop();
            // Ejecutar filtrado asíncrono para no bloquear la UI
            _ = DoFilterAsync(txbName.Text.Trim());
        }

        private async Task DoFilterAsync(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                BeginInvoke(new Action(() => _lstResultados.Visible = false));
                return;
            }

            try
            {
                // Cargar y cachear la lista completa la primera vez.
                // Para grandes volúmenes, sustituir por búsqueda en la capa de datos.
                if (_cacheContribuyentes == null)
                    _cacheContribuyentes = await Task.Run(() => _contribNeg.ObtenerContribuyentes());

                var coincidencias = _cacheContribuyentes
                    .Where(c =>
                        (!string.IsNullOrEmpty(c.Nombre) && c.Nombre.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0) ||
                        c.IdContribuyente.ToString().Contains(texto))
                    .Take(50)
                    .ToList();

                if (!coincidencias.Any())
                {
                    BeginInvoke(new Action(() => _lstResultados.Visible = false));
                    return;
                }

                BeginInvoke(new Action(() =>
                {
                    _lstResultados.DisplayMember = "Nombre";
                    _lstResultados.ValueMember = "IdContribuyente";
                    _lstResultados.DataSource = coincidencias;
                    _lstResultados.Visible = true;
                    _lstResultados.BringToFront();
                }));
            }
            catch (Exception ex)
            {
                BeginInvoke(new Action(() =>
                    MessageBox.Show(ex.Message, "Error en búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ));
            }
        }

        private void LstResultados_DoubleClick(object sender, EventArgs e)
        {
            SelectCurrent();
        }

        private void LstResultados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SelectCurrent();
                _lstResultados.Visible = false;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                _lstResultados.Visible = false;
            }
        }

        private void TxbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (!_lstResultados.Visible) return;

            if (e.KeyCode == Keys.Down)
            {
                if (_lstResultados.Items.Count > 0)
                {
                    int idx = Math.Max(0, _lstResultados.SelectedIndex);
                    _lstResultados.SelectedIndex = Math.Min(_lstResultados.Items.Count - 1, idx + 1);
                    _lstResultados.Focus();
                }
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (_lstResultados.Items.Count > 0)
                {
                    int idx = Math.Max(0, _lstResultados.SelectedIndex);
                    _lstResultados.SelectedIndex = Math.Max(0, idx - 1);
                    _lstResultados.Focus();
                }
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                _lstResultados.Visible = false;
                    
            }
        }

        private void SelectCurrent()
        {
            if (_lstResultados.SelectedItem is ContribuyenteDto seleccionado)
            {
                txbName.Text = seleccionado.Nombre;
                ContribuyenteSeleccionado?.Invoke(seleccionado);
                ObtenerAdeudosPorContribuyente(seleccionado.IdContribuyente);
                _lstResultados.Visible = false;
            }
        }

        // Método público si quieres iniciar búsqueda con una nueva lista (p. ej. recargar desde BD)
        public void ClearCache()
        {
            _cacheContribuyentes = null;
        }

        public void ObtenerAdeudosPorContribuyente(int Idcontribuyente)
        {
            try
            {
                _currentContribuyenteId = Idcontribuyente;

                var adeudos = cobranzaNegocio.ObtenerAdeudosPorContribuyente(Idcontribuyente, "Pendiente");

                dgvAdeudosPorContribuyente.DataSource = adeudos;

                // Asegurar que el total se recalcula al cargar nueva fuente
                RecalcularTotalSeleccionado();

                // Actualizar estado de controles
                UpdateAdeudosControlsState();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al obtener adeudos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Carga la grilla de "ADEUDOS CONFIGURADOS" (tabla Adeudo).
        /// </summary>
        private void CargarAdeudosConfigurados()
        {
            try
            {
                var adeudos = cobranzaNegocio.ObtenerAdeudosConfigurados();

                // Proyección ligera para el DataGridView
                dgvAdeudosConfigurados.DataSource = adeudos
                    .Select(a => new
                    {
                        a.IdAdeudo,
                        a.Periodo,
                        a.Concepto,
                        FechaGeneracion = a.FechaGeneracion
                    })
                    .ToList();

                // Opcional: ajustar columnas visibles / formato aquí si se requiere
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
                var adeudo = cobranzaNegocio.ObtenerAdeudoPorId(id);
                if (adeudo == null)
                {
                    MessageBox.Show("No se encontró el adeudo seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _adeudoEnEdicion = adeudo;
                txbPeriodo.Text = _adeudoEnEdicion.Periodo;
                txbConcepto.Text = _adeudoEnEdicion.Concepto;

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
            // UI: limpiar y ocultar panel de edición.
        }

        // Guardar: recibe una entidad Adeudo (p. ej. creada por la UI desde controles) y la persiste.
        // Devuelve true si se guardó correctamente y recarga la grilla de adeudos configurados.
        public bool GuardarAdeudo(Adeudo adeudo)
        {
            try
            {
                var guardado = cobranzaNegocio.GuardarAdeudo(adeudo);
                if (guardado == null)
                {
                    MessageBox.Show("No fue posible guardar el adeudo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Recargar grilla
                CargarAdeudosConfigurados();

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
        public bool EliminarAdeudoSeleccionado()
        {
            int id = ObtenerIdAdeudoSeleccionadoDesdeGrid();
            if (id <= 0)
            {
                MessageBox.Show("Seleccione un adeudo para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            try
            {
                var ok = cobranzaNegocio.EliminarAdeudo(id);
                if (ok)
                {
                    CargarAdeudosConfigurados();
                    return true;
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el adeudo seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al eliminar adeudo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // ------------------------------
        // Resto del código existente (pagar, recalcular, etc.) se mantiene...
        // ------------------------------

        // Al hacer click en Pagar: recopilar filas marcadas y guardar pago
        private async void BtnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                // Recopilar detalles seleccionados
                var detalles = new List<Tuple<int, decimal>>();

                foreach (DataGridViewRow row in dgvAdeudosPorContribuyente.Rows)
                {
                    if (row.IsNewRow) continue;

                    bool marcar = false;
                    if (dgvAdeudosPorContribuyente.Columns.Contains("Pagar"))
                    {
                        var c = row.Cells["Pagar"];
                        if (c != null && c.Value != null)
                        {
                            bool.TryParse(Convert.ToString(c.Value), out marcar);
                        }
                    }

                    if (!marcar) continue;

                    // Obtener IdAdeudo
                    int idAdeudo = 0;
                    if (dgvAdeudosPorContribuyente.Columns.Contains("IdAdeudo"))
                    {
                        var cellId = row.Cells["IdAdeudo"].Value;
                        if (cellId != null && int.TryParse(Convert.ToString(cellId), out int tmpId))
                            idAdeudo = tmpId;
                    }

                    // Obtener TotalAdeudo
                    decimal monto = 0m;
                    if (dgvAdeudosPorContribuyente.Columns.Contains("TotalAdeudo"))
                    {
                        var cellMonto = row.Cells["TotalAdeudo"].Value;
                        if (cellMonto != null && decimal.TryParse(Convert.ToString(cellMonto), out decimal tmpMonto))
                            monto = tmpMonto;
                    }

                    if (idAdeudo > 0 && monto > 0m)
                    {
                        detalles.Add(Tuple.Create(idAdeudo, monto));
                    }
                }

                if (detalles.Count == 0)
                {
                    MessageBox.Show("No hay adeudos seleccionados para pagar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (_currentContribuyenteId == 0)
                {
                    MessageBox.Show("No se ha identificado al contribuyente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Construir entidad Pago
                var pago = new Pago
                {
                    IdContribuyente = _currentContribuyenteId,
                    MetodoPago = cbxMetodoPago.SelectedItem != null ? cbxMetodoPago.SelectedItem.ToString() : cbxMetodoPago.Text,
                    IdUsuarioSistema = Session.UsuarioId
                };

                // Ejecutar guardado en hilo de fondo para no bloquear UI
                bool ok = await Task.Run(() => cobranzaNegocio.GuardarPago(pago, detalles));

                if (ok)
                {
                    MessageBox.Show("Pago registrado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Recargar adeudos y limpiar total
                    ObtenerAdeudosPorContribuyente(_currentContribuyenteId);
                    txbTotalPagar.Text = 0m.ToString("N2");
                }
                else
                {
                    MessageBox.Show("No fue posible registrar el pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al registrar pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cuando el usuario está editando la celda checkbox, commit para que CellValueChanged se dispare inmediatamente.
        private void DgvAdeudos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvAdeudosPorContribuyente.IsCurrentCellDirty && dgvAdeudosPorContribuyente.CurrentCell is DataGridViewCheckBoxCell)
            {
                dgvAdeudosPorContribuyente.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        // Cuando cambia valor de celda (checkbox), recalcular total.
        private void DgvAdeudos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var col = dgvAdeudosPorContribuyente.Columns[e.ColumnIndex];
            if (string.Equals(col.Name, "Pagar", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(col.DataPropertyName, "Pagar", StringComparison.OrdinalIgnoreCase))
            {
                RecalcularTotalSeleccionado();
            }
        }

        // Al completar el binding (carga de datos), asegurar checkboxes en falso y recalcular
        private void DgvAdeudos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                // Asegurar que ninguna fila venga seleccionada para pagar por defecto
                if (dgvAdeudosPorContribuyente.Columns.Contains("Pagar"))
                {
                    foreach (DataGridViewRow row in dgvAdeudosPorContribuyente.Rows)
                    {
                        var cell = row.Cells["Pagar"];
                        if (cell != null)
                        {
                            if (cell.Value == null) cell.Value = false;
                        }
                    }
                }
            }
            catch
            {
                // silencioso
            }
            RecalcularTotalSeleccionado();

            // Actualizar estado de controles según datos cargados
            UpdateAdeudosControlsState();
        }

        // Suma los valores de la columna "TotalAdeudo" para las filas marcadas en "Pagar"
        private void RecalcularTotalSeleccionado()
        {
            decimal total = 0m;

            foreach (DataGridViewRow row in dgvAdeudosPorContribuyente.Rows)
            {
                if (row.IsNewRow) continue;

                bool marcar = false;
                // Intentar leer la celda Pagar (checkbox)
                if (dgvAdeudosPorContribuyente.Columns.Contains("Pagar"))
                {
                    var pagarCell = row.Cells["Pagar"];
                    if (pagarCell != null && pagarCell.Value != null)
                    {
                        // puede ser bool o int/decimal/string
                        bool.TryParse(Convert.ToString(pagarCell.Value), out marcar);
                    }
                }

                if (marcar)
                {
                    // Leer TotalAdeudo
                    if (dgvAdeudosPorContribuyente.Columns.Contains("TotalAdeudo"))
                    {
                        var totalCell = row.Cells["TotalAdeudo"];
                        if (totalCell != null && totalCell.Value != null)
                        {
                            decimal valor;
                            // Aceptar formatos numéricos y strings
                            if (decimal.TryParse(Convert.ToString(totalCell.Value), out valor))
                            {
                                total += valor;
                            }
                        }
                    }
                }
            }

            txbTotalPagar.Text = total.ToString("N2");
        }

        // Actualiza Enabled de DataGridView, btnPagar y cbxMetodoPago según tenga filas válidas.
        private void UpdateAdeudosControlsState()
        {
            try
            {
                bool hasData = dgvAdeudosPorContribuyente.Rows.Cast<DataGridViewRow>().Any(r => !r.IsNewRow);

                dgvAdeudosPorContribuyente.Enabled = hasData;
                btnPagar.Enabled = hasData;
                cbxMetodoPago.Enabled = hasData;

                if (!hasData)
                {
                    txbTotalPagar.Text = 0m.ToString("N2");
                }
            }
            catch
            {
                // Silencioso: si falla, desactivar para evitar acciones.
                dgvAdeudosPorContribuyente.Enabled = false;
                btnPagar.Enabled = false;
                cbxMetodoPago.Enabled = false;
                txbTotalPagar.Text = 0m.ToString("N2");
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
            NuevoAdeudo();
        }

        private void btnActualizarAdeudo_Click(object sender, EventArgs e)
        {
            ActualizarAdeudoSeleccionado();
            txbConcepto.Enabled = true;
            txbPeriodo.Enabled = true;
            btnNuevoAdeudo.Enabled = false;
            btnActualizarAdeudo.Enabled = false;
            btnCancelarConfiguracionAdeudo.Enabled = true;
            btnGuardarAdeudo.Enabled = true;
        }

        private void btnCancelarConfiguracionAdeudo_Click(object sender, EventArgs e)
        {
            CancelarEdicionAdeudo();
            LimpiarControles();
        }

        private void btnGuardarAdeudo_Click(object sender, EventArgs e)
        {
            txbConcepto.Enabled = false;
            txbPeriodo.Enabled = false;
            btnNuevoAdeudo.Enabled = true;
            btnActualizarAdeudo.Enabled = true;
            btnCancelarConfiguracionAdeudo.Enabled = false;
            _adeudoEnEdicion.Periodo = txbPeriodo.Text;
            _adeudoEnEdicion.Concepto = txbConcepto.Text;
            
            GuardarAdeudo(_adeudoEnEdicion);
            LimpiarControles();
        }

        private void dgvAdeudosConfigurados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvAdeudosConfigurados.Columns["EliminarAdeudo"].Index && e.RowIndex >= 0)
            {           
                EliminarAdeudoSeleccionado();
            }
        }

        private void LimpiarControles()
        {
            // Limpiar controles y restablecer estado
            btnNuevoAdeudo.Enabled = true;
            btnActualizarAdeudo.Enabled = true;
            btnCancelarConfiguracionAdeudo.Enabled = false;
            txbPeriodo.Clear();
            txbConcepto.Clear();
            btnGuardarAdeudo.Enabled = false;
        }
    }
}
