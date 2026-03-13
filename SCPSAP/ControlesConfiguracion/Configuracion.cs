using Datos.Configuracion;
using Negocio.Configuracion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCPSAP.ControlesConfiguracion
{
    public partial class Configuracion : UserControl
    {
        TarifasNegocio TarifasNegocio = new TarifasNegocio();
        public Configuracion()
        {
            InitializeComponent();
            CargarTarifas();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvConfiguracion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void lblNombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRol_Click(object sender, EventArgs e)
        {

        }

        private void dgvName_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        } 
    }
}
