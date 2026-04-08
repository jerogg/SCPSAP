using CapaUI;
using Datos;
using Negocio.Configuracion;
using System;
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
        }

        private void CargarTarifas()
        {
            try
            {
                var lista = TarifasNegocio.ObtenerTarifas();
                dgvListaTarifas.DataSource = lista;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar tarifa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Tarifa tarifa = new Tarifa();
            tarifa.NombreTarifa = txbNombre.Text;
            tarifa.MontoMensual = decimal.Parse(txbMontoMensual.Text);
            AgregarTarifas(tarifa);
            CargarTarifas();
        }

        private void LimpiarControles()
        {
            btnNuevo.Enabled = true;
            btnActualizar.Enabled = true;
            btnCancelar.Enabled = false;
            txbNombre.Clear();
            txbMontoMensual.Clear();
            btnGuardar.Enabled = false;
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
        }
    }
}
