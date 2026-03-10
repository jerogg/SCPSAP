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

namespace SCPSAP.Contribuyentes
{
    public partial class ListaContribuyentes : UserControl
    {
        ContribuyentesNegocio contribuyentesNegocio = new ContribuyentesNegocio();

        public ListaContribuyentes()
        {
            InitializeComponent();
            CargarContribuyentes();
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
    }
}
