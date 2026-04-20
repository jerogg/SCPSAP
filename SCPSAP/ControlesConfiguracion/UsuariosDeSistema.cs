using CapaUI;
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
                    btnNuevo.Enabled = false;
                    btnActualizar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnGuardar.Enabled = true;
                    txbNombre.Enabled = true;
                    txbPassword.Enabled = true;
                    cbxRol.Enabled = true;

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
    }
}
