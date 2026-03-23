using Negocio.Cobranza;
using System;
using System.Windows.Forms;

namespace SCPSAP.ControlesCobranza
{
    public partial class AgregarPorContribuyente : UserControl
    {
        AgregarAdeudoPorContribuyenteNegocio agregarAdeudoPorContribuyenteNegocio = new AgregarAdeudoPorContribuyenteNegocio();
        public AgregarPorContribuyente()
        {
            InitializeComponent();
        }

        // Propiedades públicas para recibir datos desde el formulario padre
        public int ContribuyenteId { get; set; }
        public string ContribuyenteNombre { get; set; }
        public string ContribuyenteFolio { get; set; }
        public string ContribuyenteDireccion { get; set; }

        // Método para inicializar la vista con los datos proporcionados
        public void CargarContribuyente(int id, string nombre, string folio, string direccion)
        {
            ContribuyenteId = id;
            ContribuyenteNombre = nombre;
            ContribuyenteFolio = folio;
            ContribuyenteDireccion = direccion;

            txbName.Text = ContribuyenteNombre;
            txbFolio.Text = ContribuyenteFolio;
            txbDireccion.Text = ContribuyenteDireccion;

            CargarAdeudosNoRelacionados();
        }

        public void CargarAdeudosNoRelacionados()
        {
            try
            {
                dgvAdeudosConfiguradosNoRelacionados.DataSource = agregarAdeudoPorContribuyenteNegocio.ObtenerAdeudosNoRelacionadosConContribuyente(ContribuyenteId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al obtener los adeudos no relacionados al contribuyente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //this.Close();
        }
    }
}
