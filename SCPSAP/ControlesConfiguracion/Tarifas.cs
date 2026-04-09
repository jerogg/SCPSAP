using CapaUI;
using Datos;
using Negocio.Configuracion;
using SCPSAP.ControlesCobranza;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCPSAP.ControlesConfiguracion
{
    public partial class Tarifas : UserControl
    {
        TarifasNegocio TarifasNegocio = new TarifasNegocio();

        // Id seleccionado actualmente en el DataGridView
        private int _idTarifaSeleccionada = 0;

        public Tarifas()
        {
            InitializeComponent();
            Theme.ApplyTo(this);
            CargarTarifas();

            // Suscribir eventos
            if (dgvListaTarifas != null)
            {
                dgvListaTarifas.SelectionChanged += dgvListaTarifas_SelectionChanged;
                dgvListaTarifas.CellClick += dgvListaTarifas_SelectionChanged; // para clicks en celdas

                // Mostrar cursor de mano al posar sobre la columna de eliminar (imagen)
                dgvListaTarifas.CellMouseEnter += dgvListaTarifas_CellMouseEnter;
                dgvListaTarifas.CellMouseLeave += dgvListaTarifas_CellMouseLeave;
            }
        }

        private void CargarTarifas()
        {
            try
            {
                var lista = TarifasNegocio.ObtenerTarifas();
                dgvListaTarifas.DataSource = lista;
                txbNombre.Enabled = false;
                txbMontoMensual.Enabled = false;
                LimpiarControles();

                // Forzar que la columna "Eliminar" quede en la última posición visual
                if (dgvListaTarifas.Columns.Contains("Eliminar"))
                {
                    dgvListaTarifas.Columns["Eliminar"].DisplayIndex = dgvListaTarifas.Columns.Count - 1;
                    // Asegurar que el AutoSizeMode no provoque reordenamientos inesperados
                    dgvListaTarifas.Columns["Eliminar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar tarifas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AgregarTarifas(Tarifa tarifa)
        {
            try
            {
                TarifasNegocio.AgregarTarifas(tarifa);
                MessageBox.Show("Se agrego una nueva tarifa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarTarifas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar tarifa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Tarifa tarifa = new Tarifa();
            tarifa.IdTarifa = _idTarifaSeleccionada;
            tarifa.NombreTarifa = txbNombre.Text;
            tarifa.MontoMensual = decimal.Parse(txbMontoMensual.Text);
            AgregarTarifas(tarifa);
        }

        private void LimpiarControles()
        {
            btnNuevo.Enabled = true;
            btnActualizar.Enabled = true;
            btnCancelar.Enabled = false;
            txbNombre.Clear();
            txbMontoMensual.Clear();
            btnGuardar.Enabled = false;
            txbNombre.Enabled = false;
            txbMontoMensual.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = ObtenerIdTarifaSeleccionadaDesdeGrid();
                if (id > 0)
                {
                    _idTarifaSeleccionada = id;
                    btnNuevo.Enabled = false;
                    btnActualizar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnGuardar.Enabled = true;
                    txbNombre.Enabled = true;
                    txbMontoMensual.Enabled = true;

                    // Aquí podrías cargar los datos completos del contribuyente en los controles:
                    CargarTarifasEnControles(_idTarifaSeleccionada);
                }
                else
                {
                    MessageBox.Show("Seleccione un contribuyente antes de actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al obtener contribuyente seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ObtenerIdTarifaSeleccionadaDesdeGrid()
        {
            if (dgvListaTarifas == null)
                return 0;

            DataGridViewRow fila = null;

            if (dgvListaTarifas.SelectedRows != null && dgvListaTarifas.SelectedRows.Count > 0)
            {
                fila = dgvListaTarifas.SelectedRows[0];
            }
            else if (dgvListaTarifas.CurrentRow != null)
            {
                fila = dgvListaTarifas.CurrentRow;
            }

            if (fila == null)
                return 0;

            object valor = null;

            if (dgvListaTarifas.Columns.Contains("IdTarifa"))
            {
                valor = fila.Cells["IdTarifa"].Value;
            }
            else
            {
                valor = fila.Cells.Count > 0 ? fila.Cells[0].Value : null;
            }

            if (valor == null)
                return 0;

            int id;
            if (int.TryParse(Convert.ToString(valor), out id))
                return id;

            return 0;
        }


        public void CargarTarifasEnControles(int idTarifa)
        {
            try
            {
                var tarifa = TarifasNegocio.ObtenerTarifasPorId(idTarifa);
                if (tarifa != null)
                {
                    txbNombre.Text = tarifa.NombreTarifa;
                    txbMontoMensual.Text = tarifa.MontoMensual.ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró la tarifa seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar datos de la tarifa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            btnNuevo.Enabled = false;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            txbNombre.Enabled = true;
            txbMontoMensual.Enabled = true;
        }

        private void dgvListaTarifas_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarEstadoBotonActualizar();
        }

        // Habilita btnActualizar sólo cuando hay una fila seleccionada
        private void ActualizarEstadoBotonActualizar()
        {
            try
            {
                bool tieneSeleccion = false;

                if (dgvListaTarifas != null)
                {
                    // Preferir SelectedRows cuando el SelectionMode lo permita
                    if (dgvListaTarifas.SelectedRows != null && dgvListaTarifas.SelectedRows.Count > 0)
                    {
                        tieneSeleccion = dgvListaTarifas.SelectedRows.Cast<DataGridViewRow>()
                            .Any(r => r != null && r.Index >= 0);
                    }
                    else
                    {
                        // Fallback a CurrentRow / CurrentCell
                        tieneSeleccion = dgvListaTarifas.CurrentRow != null && dgvListaTarifas.CurrentRow.Index >= 0;
                    }
                }

                btnActualizar.Enabled = tieneSeleccion;
            }
            catch
            {
                btnActualizar.Enabled = false;
            }
        }

        // Cambia el cursor cuando el ratón entra en una celda; pone mano si es la columna Eliminar o AgregarAdeudo
        private void dgvListaTarifas_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    var col = dgvListaTarifas.Columns[e.ColumnIndex];
                    if (string.Equals(col.Name, "Eliminar", StringComparison.OrdinalIgnoreCase) || string.Equals(col.Name, "AgregarAdeudo", StringComparison.OrdinalIgnoreCase))
                    {
                        dgvListaTarifas.Cursor = Cursors.Hand;
                    }
                    else
                    {
                        dgvListaTarifas.Cursor = Cursors.Default;
                    }
                }
            }
            catch
            {
                // silencioso
            }
        }

        // Restaurar cursor al salir de la celda
        private void dgvListaTarifas_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvListaTarifas.Cursor = Cursors.Default;
            }
            catch
            {
                // silencioso
            }
        }

        private async void dgvListaTarifas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvListaTarifas.Columns["Eliminar"].Index && e.RowIndex >= 0)
                {
                    int id = Convert.ToInt32(
                        dgvListaTarifas.Rows[e.RowIndex].Cells["IdTarifa"].Value
                    );

                    // Confirmación antes de eliminar
                    var fila = dgvListaTarifas.Rows[e.RowIndex];
                    string nombre = fila.Cells["NombreTarifa"].Value != null ? fila.Cells["NombreTarifa"].Value.ToString() : string.Empty;
                    var pregunta = $"¿Desea eliminar la tarifa " + nombre  + "?";
                    var dr = MessageBox.Show(pregunta, "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (dr == DialogResult.Yes)
                    {
                        this.Enabled = false;

                        await Task.Run(() =>
                        {
                            TarifasNegocio.EliminaTarifa(id);
                        });

                        MessageBox.Show("Tarifa eliminada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarTarifas();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al eliminar la tarifa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Enabled = true;
            }
        }
    }
}
