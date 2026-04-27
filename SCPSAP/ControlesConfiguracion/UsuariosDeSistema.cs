using CapaUI;
using Datos;
using Negocio.Configuracion;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCPSAP.ControlesConfiguracion
{
    public partial class UsuariosDeSistema : UserControl
    {
        UsuariosNegocio UsuariosNegocio = new UsuariosNegocio();

        // Id seleccionado actualmente en el DataGridView
        private int _idUsuarioSeleccionado = 0;

        public UsuariosDeSistema()
        {
            InitializeComponent();
            Theme.ApplyTo(this);
            CargarRoles();
            CargarUsuarios();

            // Suscribir eventos
            if (dgvListaUsuarios != null)
            {
                dgvListaUsuarios.SelectionChanged += dgvListaUsuarios_SelectionChanged;
                dgvListaUsuarios.CellClick += dgvListaUsuarios_SelectionChanged; // para clicks en celdas

                // Mostrar cursor de mano al posar sobre la columna de eliminar (imagen)
                dgvListaUsuarios.CellMouseEnter += dgvListaUsuarios_CellMouseEnter;
                dgvListaUsuarios.CellMouseLeave += dgvListaUsuarios_CellMouseLeave;
            }
        }

        private void CargarRoles()
        {
            try
            {
                var lista = UsuariosNegocio.ObtenerRoles();
                cbxRol.DataSource = lista;
                cbxRol.DisplayMember = "Descripcion"; // Muestra la descripción del rol 
                cbxRol.ValueMember = "IdRol"; // Usa el ID del rol como valor
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar los roles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarUsuarios()
        {
            try
            {
                var lista = UsuariosNegocio.ObtenerUsuarios();
                dgvListaUsuarios.DataSource = lista;
                txbNombre.Enabled = false;
                txbPassword.Enabled = false;
                cbxRol.Enabled = false;
                LimpiarControles();

                // Forzar que la columna "Eliminar" quede en la última posición visual
                if (dgvListaUsuarios.Columns.Contains("Eliminar"))
                {
                    dgvListaUsuarios.Columns["Eliminar"].DisplayIndex = dgvListaUsuarios.Columns.Count - 1;
                    // Asegurar que el AutoSizeMode no provoque reordenamientos inesperados
                    dgvListaUsuarios.Columns["Eliminar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar tarifas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarControles()
        {
            btnNuevo.Enabled = true;
            btnActualizar.Enabled = true;
            btnCancelar.Enabled = false;
            txbNombre.Clear();
            txbPassword.Clear();
            cbxRol.SelectedIndex = 0;
            btnGuardar.Enabled = false;
            txbNombre.Enabled = false;
            txbPassword.Enabled = false;
            cbxRol.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = ObtenerIdUsuarioSeleccionadoDesdeGrid();
                if (id > 0)
                {
                    _idUsuarioSeleccionado = id;
                    HabilitarControles();

                    // Aquí podrías cargar los datos completos del contribuyente en los controles:
                    CargarUsuariosEnControles(_idUsuarioSeleccionado);
                }
                else
                {
                    MessageBox.Show("Seleccione un usuario antes de actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al obtener usuario seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ObtenerIdUsuarioSeleccionadoDesdeGrid()
        {
            if (dgvListaUsuarios == null)
                return 0;

            DataGridViewRow fila = null;

            if (dgvListaUsuarios.SelectedRows != null && dgvListaUsuarios.SelectedRows.Count > 0)
            {
                fila = dgvListaUsuarios.SelectedRows[0];
            }
            else if (dgvListaUsuarios.CurrentRow != null)
            {
                fila = dgvListaUsuarios.CurrentRow;
            }

            if (fila == null)
                return 0;

            object valor = null;

            if (dgvListaUsuarios.Columns.Contains("IdUsuarioSistema"))
            {
                valor = fila.Cells["IdUsuarioSistema"].Value;
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

        public void CargarUsuariosEnControles(int idUsuario)
        {
            try
            {
                var usuario = UsuariosNegocio.ObtenerUsuariosPorId(idUsuario);
                if (usuario != null)
                {
                    txbNombre.Text = usuario.NombreUsuario;
                    txbPassword.Text = usuario.PasswordHash;
                    cbxRol.SelectedValue = (int)usuario.IdRol;
                }
                else
                {
                    MessageBox.Show("No se encontró el usuario seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar datos del usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarControles();
        }

        public void HabilitarControles()
        {
            btnNuevo.Enabled = false;
            btnActualizar.Enabled = false;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            txbNombre.Enabled = true;
            txbPassword.Enabled = true;
            cbxRol.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            UsuarioSistema usuariosDeSistema = new UsuarioSistema();
            usuariosDeSistema.IdUsuarioSistema = _idUsuarioSeleccionado;
            usuariosDeSistema.NombreUsuario = txbNombre.Text;
            usuariosDeSistema.PasswordHash = txbPassword.Text;
            usuariosDeSistema.IdRol = int.Parse(cbxRol.SelectedValue.ToString());
            usuariosDeSistema.Activo = true;
            AgregarUsuarios(usuariosDeSistema);
        }

        public void AgregarUsuarios(UsuarioSistema usuarioDeSistema)
        {
            try
            {
                UsuariosNegocio.AgregarUsuarios(usuarioDeSistema);
                MessageBox.Show("Se guardo usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void dgvListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvListaUsuarios.Columns["Eliminar"].Index && e.RowIndex >= 0)
                {
                    int id = Convert.ToInt32(
                        dgvListaUsuarios.Rows[e.RowIndex].Cells["IdUsuarioSistema"].Value
                    );

                    // Confirmación antes de eliminar
                    var fila = dgvListaUsuarios.Rows[e.RowIndex];
                    string nombre = fila.Cells["NombreUsuario"].Value != null ? fila.Cells["NombreUsuario"].Value.ToString() : string.Empty;
                    var pregunta = $"¿Desea eliminar el usuario " + nombre + "?";
                    var dr = MessageBox.Show(pregunta, "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (dr == DialogResult.Yes)
                    {
                        this.Enabled = false;

                        await Task.Run(() =>
                        {
                            UsuariosNegocio.EliminarUsuario(id);
                        });

                        MessageBox.Show("Usuario eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarUsuarios();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al eliminar usaurio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Enabled = true;
            }
        }

        private void dgvListaUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarEstadoBotonActualizar();
        }

        // Habilita btnActualizar sólo cuando hay una fila seleccionada
        private void ActualizarEstadoBotonActualizar()
        {
            try
            {
                bool tieneSeleccion = false;

                if (dgvListaUsuarios != null)
                {
                    // Preferir SelectedRows cuando el SelectionMode lo permita
                    if (dgvListaUsuarios.SelectedRows != null && dgvListaUsuarios.SelectedRows.Count > 0)
                    {
                        tieneSeleccion = dgvListaUsuarios.SelectedRows.Cast<DataGridViewRow>()
                            .Any(r => r != null && r.Index >= 0);
                    }
                    else
                    {
                        // Fallback a CurrentRow / CurrentCell
                        tieneSeleccion = dgvListaUsuarios.CurrentRow != null && dgvListaUsuarios.CurrentRow.Index >= 0;
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
        private void dgvListaUsuarios_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    var col = dgvListaUsuarios.Columns[e.ColumnIndex];
                    if (string.Equals(col.Name, "Eliminar", StringComparison.OrdinalIgnoreCase))
                    {
                        dgvListaUsuarios.Cursor = Cursors.Hand;
                    }
                    else
                    {
                        dgvListaUsuarios.Cursor = Cursors.Default;
                    }
                }
            }
            catch
            {
                // silencioso
            }
        }

        // Restaurar cursor al salir de la celda
        private void dgvListaUsuarios_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvListaUsuarios.Cursor = Cursors.Default;
            }
            catch
            {
                // silencioso
            }
        }
    }
}
