using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Contribuyentes;


namespace SCPSAP.Contribuyentes
{
    public partial class ListaContribuyentes : UserControl
    {
        ContribuyentesNegocio contribuyentesNegocio = new ContribuyentesNegocio();

        public ListaContribuyentes()
        {
            InitializeComponent();
            CargarContribuyentes();
            CargarTarifas();
            CargarEstados();
        }

        private void CargarContribuyentes()
        {
            try
            {
                var lista = contribuyentesNegocio.ObtenerContribuyentes();

                // Enlaza columnas útiles al DataGridView (evita exponer navegación completa)
                dgvListaContribuyentes.DataSource = lista
                    .Select(c => new
                    {
                        c.IdContribuyente,
                        c.Nombre,
                        c.Direccion,
                        c.Telefono,
                        c.Email,
                        FechaAlta = c.FechaAlta
                    })
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar contribuyentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListaContribuyentes_Load(object sender, EventArgs e)
        {

        }

        private void cbxTarifa_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void CargarTarifas()
        {
            try
            {
                string connectionString = "Server=localhost\\MSSQLSERVER03;Database=SCPSAP;Trusted_Connection=True;";
                string query = "SELECT IdTarifa, NombreTarifa FROM dbo.Tarifa";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cbxTarifa.DataSource = dt;
                    cbxTarifa.DisplayMember = "NombreTarifa"; // lo que se muestra
                    cbxTarifa.ValueMember = "IdTarifa";       // el valor interno
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar tarifas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
