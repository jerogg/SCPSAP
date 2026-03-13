using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Contribuyentes;
using Datos;

namespace SCPSAP.ControlesCobranza
{
    public partial class Cobranza : UserControl
    {
        private Timer _filterTimer;
        private ListBox _lstResultados;
        private ContribuyentesNegocio _contribNeg;
        private List<Contribuyente> _cacheContribuyentes;

        // Evento opcional para quien use este control
        public event Action<Contribuyente> ContribuyenteSeleccionado;

        public Cobranza()
        {
            InitializeComponent();
            _contribNeg = new ContribuyentesNegocio();
            InitializeSearchControls();
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
                e.Handled = true;
            }
        }

        private void SelectCurrent()
        {
            if (_lstResultados.SelectedItem is Contribuyente seleccionado)
            {
                txbName.Text = seleccionado.Nombre;
                _lstResultados.Visible = false;
                ContribuyenteSeleccionado?.Invoke(seleccionado);
            }
        }

        // Método público si quieres iniciar búsqueda con una nueva lista (p. ej. recargar desde BD)
        public void ClearCache()
        {
            _cacheContribuyentes = null;
        }
    }
}
