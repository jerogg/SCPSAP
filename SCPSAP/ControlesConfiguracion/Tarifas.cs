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
                dgvConfiguracion.DataSource = lista;
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

    }
}
