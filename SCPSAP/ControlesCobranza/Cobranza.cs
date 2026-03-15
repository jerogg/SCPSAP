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

        public Cobranza()
        {
            InitializeComponent();
            _contribNeg = new ContribuyentesNegocio();
            InitializeSearchControls();

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
            dgvAdeudos.CurrentCellDirtyStateChanged += DgvAdeudos_CurrentCellDirtyStateChanged;
            dgvAdeudos.CellValueChanged += DgvAdeudos_CellValueChanged;
            dgvAdeudos.DataBindingComplete += DgvAdeudos_DataBindingComplete;

            // Botón pagar
            btnPagar.Click += BtnPagar_Click;

            // Asegurar estado inicial de controles (deshabilitados si no hay datos)
            UpdateAdeudosControlsState();
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
                obtenerAdeudos(seleccionado.IdContribuyente);
                _lstResultados.Visible = false;
            }
        }

        // Método público si quieres iniciar búsqueda con una nueva lista (p. ej. recargar desde BD)
        public void ClearCache()
        {
            _cacheContribuyentes = null;
        }

        public void obtenerAdeudos(int Idcontribuyente)
        {
            try
            {
                _currentContribuyenteId = Idcontribuyente;

                var adeudos = cobranzaNegocio.ObtenerAdeudosPorContribuyente(Idcontribuyente, "Pendiente");

                dgvAdeudos.DataSource = adeudos;

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

        // Al hacer click en Pagar: recopilar filas marcadas y guardar pago
        private async void BtnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                // Recopilar detalles seleccionados
                var detalles = new List<Tuple<int, decimal>>();

                foreach (DataGridViewRow row in dgvAdeudos.Rows)
                {
                    if (row.IsNewRow) continue;

                    bool marcar = false;
                    if (dgvAdeudos.Columns.Contains("Pagar"))
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
                    if (dgvAdeudos.Columns.Contains("IdAdeudo"))
                    {
                        var cellId = row.Cells["IdAdeudo"].Value;
                        if (cellId != null && int.TryParse(Convert.ToString(cellId), out int tmpId))
                            idAdeudo = tmpId;
                    }

                    // Obtener TotalAdeudo
                    decimal monto = 0m;
                    if (dgvAdeudos.Columns.Contains("TotalAdeudo"))
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
                    IdUsuarioSistema = null // ajusta si el sistema tiene sesión de usuario
                };

                // Ejecutar guardado en hilo de fondo para no bloquear UI
                bool ok = await Task.Run(() => cobranzaNegocio.GuardarPago(pago, detalles));

                if (ok)
                {
                    MessageBox.Show("Pago registrado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Recargar adeudos y limpiar total
                    obtenerAdeudos(_currentContribuyenteId);
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
            if (dgvAdeudos.IsCurrentCellDirty && dgvAdeudos.CurrentCell is DataGridViewCheckBoxCell)
            {
                dgvAdeudos.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        // Cuando cambia valor de celda (checkbox), recalcular total.
        private void DgvAdeudos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var col = dgvAdeudos.Columns[e.ColumnIndex];
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
                if (dgvAdeudos.Columns.Contains("Pagar"))
                {
                    foreach (DataGridViewRow row in dgvAdeudos.Rows)
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

            foreach (DataGridViewRow row in dgvAdeudos.Rows)
            {
                if (row.IsNewRow) continue;

                bool marcar = false;
                // Intentar leer la celda Pagar (checkbox)
                if (dgvAdeudos.Columns.Contains("Pagar"))
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
                    if (dgvAdeudos.Columns.Contains("TotalAdeudo"))
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
                bool hasData = dgvAdeudos.Rows.Cast<DataGridViewRow>().Any(r => !r.IsNewRow);

                dgvAdeudos.Enabled = hasData;
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
                dgvAdeudos.Enabled = false;
                btnPagar.Enabled = false;
                cbxMetodoPago.Enabled = false;
                txbTotalPagar.Text = 0m.ToString("N2");
            }
        }
    }
}
