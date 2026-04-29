using Negocio.Configuracion;
using Negocio.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCPSAP.ControlesInventario
{
    public partial class ListaInventario : UserControl
    {
        MaterialesNegocio materialesNegocio = new MaterialesNegocio();
        public ListaInventario()
        {
            InitializeComponent();
            CargarMateriales();
        }

        private void CargarMateriales()
        {
            try
            {
                var lista = materialesNegocio.ObtenerMateriales();
                dgvListaMateriales.DataSource = lista;
                //txbNombre.Enabled = false;
                //txbMontoMensual.Enabled = false;
                //LimpiarControles();

                // Forzar que la columna "Eliminar" quede en la última posición visual
                if (dgvListaMateriales.Columns.Contains("Eliminar"))
                {
                    dgvListaMateriales.Columns["Eliminar"].DisplayIndex = dgvListaMateriales.Columns.Count - 1;
                    // Asegurar que el AutoSizeMode no provoque reordenamientos inesperados
                    dgvListaMateriales.Columns["Eliminar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar materiales", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
