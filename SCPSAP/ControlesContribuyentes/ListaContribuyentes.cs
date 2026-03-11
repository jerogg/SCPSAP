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

        // Id seleccionado actualmente en el DataGridView
        private int _idContribuyenteSeleccionado = 0;

        public ListaContribuyentes()
        {
            InitializeComponent();

            // Suscribir eventos
            if (dgvListaContribuyentes != null)
            {
                dgvListaContribuyentes.SelectionChanged += DgvListaContribuyentes_SelectionChanged;
                dgvListaContribuyentes.CellClick += DgvListaContribuyentes_SelectionChanged; // para clicks en celdas
            }


            CargarContribuyentes();
            CargarTarifas();
            CargarEstados();

            // Asegurar estado correcto después de cargar datos
            ActualizarEstadoBotonActualizar();
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
                        Folio = c.IdContribuyente,
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

        private void CargarTarifas()
        {
            try
            {
                cbxTarifa.DataSource = contribuyentesNegocio.ObtenerTarifas();
                cbxTarifa.DisplayMember = "MontoMensual"; // Muestra la descripción de la tarifa
                cbxTarifa.ValueMember = "IdTarifa"; // Usa el ID de la tarifa como valor
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar tarifas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEstados()
        {
            try
            {
                cbxEstado.DataSource = contribuyentesNegocio.ObtenerEstados();
                cbxEstado.DisplayMember = "Descripcion"; // Muestra la descripción del estado
                cbxEstado.ValueMember = "IdEstado"; // Usa el ID del estado como valor
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar estados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Obtener IdContribuyente del registro seleccionado y habilitar el panel de edición
            try
            {
                int id = ObtenerIdContribuyenteSeleccionadoDesdeGrid();
                if (id > 0)
                {
                    _idContribuyenteSeleccionado = id;
                    pnlDatosUsuario.Enabled = true;

                    // Aquí podrías cargar los datos completos del contribuyente en los controles:
                    CargarContribuyenteEnControles(_idContribuyenteSeleccionado);
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            pnlDatosUsuario.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            pnlDatosUsuario.Enabled = false;
        }

        // Evento que dispara la actualización del estado del botón
        private void DgvListaContribuyentes_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarEstadoBotonActualizar();
        }

        // Habilita btnActualizar sólo cuando hay una fila seleccionada
        private void ActualizarEstadoBotonActualizar()
        {
            try
            {
                bool tieneSeleccion = false;

                if (dgvListaContribuyentes != null)
                {
                    // Preferir SelectedRows cuando el SelectionMode lo permita
                    if (dgvListaContribuyentes.SelectedRows != null && dgvListaContribuyentes.SelectedRows.Count > 0)
                    {
                        tieneSeleccion = dgvListaContribuyentes.SelectedRows.Cast<DataGridViewRow>()
                            .Any(r => r != null && r.Index >= 0);
                    }
                    else
                    {
                        // Fallback a CurrentRow / CurrentCell
                        tieneSeleccion = dgvListaContribuyentes.CurrentRow != null && dgvListaContribuyentes.CurrentRow.Index >= 0;
                    }
                }

                btnActualizar.Enabled = tieneSeleccion;
            }
            catch
            {
                btnActualizar.Enabled = false;
            }
        }

        // Extrae el IdContribuyente (Folio) desde la fila seleccionada del DataGridView.
        // Retorna 0 si no hay selección válida.
        private int ObtenerIdContribuyenteSeleccionadoDesdeGrid()
        {
            if (dgvListaContribuyentes == null)
                return 0;

            DataGridViewRow fila = null;

            if (dgvListaContribuyentes.SelectedRows != null && dgvListaContribuyentes.SelectedRows.Count > 0)
            {
                fila = dgvListaContribuyentes.SelectedRows[0];
            }
            else if (dgvListaContribuyentes.CurrentRow != null)
            {
                fila = dgvListaContribuyentes.CurrentRow;
            }

            if (fila == null)
                return 0;

            object valor = null;

            // Intentar obtener por el nombre de columna que usamos en la proyección
            if (dgvListaContribuyentes.Columns.Contains("Folio"))
            {
                valor = fila.Cells["Folio"].Value;
            }
            else
            {
                // Fallback a la primera celda si el nombre no coincide
                valor = fila.Cells.Count > 0 ? fila.Cells[0].Value : null;
            }

            if (valor == null)
                return 0;

            int id;
            if (int.TryParse(Convert.ToString(valor), out id))
                return id;

            return 0;
        }

        public void CargarContribuyenteEnControles(int idContribuyente)
        {
            try
            {
                var contribuyente = contribuyentesNegocio.ObtenerContribuyentePorId(idContribuyente);
                if (contribuyente != null)
                {
                    txbNombre.Text = contribuyente.Nombre;
                    txbDireccion.Text = contribuyente.Direccion;
                    txbTelefono.Text = contribuyente.Telefono;
                    txbEmail.Text = contribuyente.Email;
                    // Seleccionar la tarifa correspondiente en el ComboBox
                    if (contribuyente.IdTarifa.HasValue)
                        cbxTarifa.SelectedValue = contribuyente.IdTarifa.Value;
                    else
                        cbxTarifa.SelectedIndex = -1; // No seleccionado
                    // Seleccionar el estado correspondiente en el ComboBox
                    if (contribuyente.IdEstado != 0)
                        cbxEstado.SelectedValue = contribuyente.IdEstado;
                    else
                        cbxEstado.SelectedIndex = -1; // No seleccionado

                    if (contribuyente.DiasGracia.HasValue)
                    {
                        switch (contribuyente.DiasGracia.Value)
                        {
                            case 30:
                                cbxDiasDeGracia.SelectedIndex = 0;
                                break;

                            case 60:
                                cbxDiasDeGracia.SelectedIndex = 1;
                                break;

                            case 90:
                                cbxDiasDeGracia.SelectedIndex = 2;
                                break;
                            // Puedes agregar más casos aquí si es necesario
                            default:
                                cbxDiasDeGracia.SelectedIndex = -1;
                                break;
                        }
                    }
                    else
                    {
                        cbxDiasDeGracia.SelectedIndex = -1;
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el contribuyente seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar datos del contribuyente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
