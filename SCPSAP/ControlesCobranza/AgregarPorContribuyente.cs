using Datos;
using Negocio.Cobranza;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCPSAP.ControlesCobranza
{
    public partial class AgregarPorContribuyente : UserControl
    {
        AgregarAdeudoPorContribuyenteNegocio agregarAdeudoPorContribuyenteNegocio = new AgregarAdeudoPorContribuyenteNegocio();
        public AgregarPorContribuyente()
        {
            InitializeComponent();
            // Eventos para manejar la selección (checkbox) en la grilla de adeudos
            dgvAdeudosConfiguradosNoRelacionados.CurrentCellDirtyStateChanged += dgvAdeudosConfiguradosNoRelacionados_CurrentCellDirtyStateChanged;
            dgvAdeudosConfiguradosNoRelacionados.CellValueChanged += dgvAdeudosConfiguradosNoRelacionados_CellValueChanged;
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
            //this.Exit();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Recopilar ids de los adeudos a relacionar
                var ids = new List<int>();

                foreach (DataGridViewRow row in dgvAdeudosConfiguradosNoRelacionados.Rows)
                {
                    if (row.IsNewRow) continue;

                    bool marcar = false;
                    if (dgvAdeudosConfiguradosNoRelacionados.Columns.Contains("RelacionarAdeudo"))
                    {
                        var c = row.Cells["RelacionarAdeudo"];
                        if (c != null && c.Value != null)
                        {
                            bool.TryParse(Convert.ToString(c.Value), out marcar);
                        }
                    }

                    if (!marcar) continue;

                    // Obtener IdAdeudo
                    int idAdeudo = 0;
                    if (dgvAdeudosConfiguradosNoRelacionados.Columns.Contains("IdAdeudo"))
                    {
                        var cellId = row.Cells["IdAdeudo"].Value;
                        if (cellId != null && int.TryParse(Convert.ToString(cellId), out int tmpId))
                            idAdeudo = tmpId;
                    }

                    if (idAdeudo > 0)
                    {
                        ids.Add(idAdeudo);
                    }
                }

                if (ids.Count == 0)
                {
                    MessageBox.Show("No hay adeudos seleccionados para relacionar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Ejecutar guardado en hilo de fondo para no bloquear UI
                bool ok = await Task.Run(() => agregarAdeudoPorContribuyenteNegocio.RelacionarAdeudos(ids, ContribuyenteId));

                if (ok)
                {
                    CargarAdeudosNoRelacionados();
                    MessageBox.Show("Se relacionaron correctamente los adeudos seleccionados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No fue posible relacionar los adeudos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al relacionar adeudos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cuando el usuario está editando la celda checkbox, commit para que CellValueChanged se dispare inmediatamente.
        private void dgvAdeudosConfiguradosNoRelacionados_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvAdeudosConfiguradosNoRelacionados.IsCurrentCellDirty && dgvAdeudosConfiguradosNoRelacionados.CurrentCell is DataGridViewCheckBoxCell)
            {
                dgvAdeudosConfiguradosNoRelacionados.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        // Cuando cambia valor de celda (checkbox), activar boton guardar
        private void dgvAdeudosConfiguradosNoRelacionados_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int adeudosRelacionados = 0;
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var col = dgvAdeudosConfiguradosNoRelacionados.Columns[e.ColumnIndex];
           
                foreach (DataGridViewRow row in dgvAdeudosConfiguradosNoRelacionados.Rows)
                {
                bool marcar = false;
                    if (dgvAdeudosConfiguradosNoRelacionados.Columns.Contains("RelacionarAdeudo"))
                    {
                        var c = row.Cells["RelacionarAdeudo"];
                        if (c != null && c.Value != null)
                        {
                            bool.TryParse(Convert.ToString(c.Value), out marcar);
                        }
                    }
                if (marcar)
                adeudosRelacionados ++;
                }

                if(adeudosRelacionados > 0)
                btnGuardar.Enabled = true;
                else 
                btnGuardar.Enabled = false;
        }
    }
}
