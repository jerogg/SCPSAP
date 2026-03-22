using CapaUI;
using Datos;
using Negocio.Contribuyentes;
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace SCPSAP.Contribuyentes
{
    public partial class ListaContribuyentes : UserControl
    {
        ContribuyentesNegocio contribuyentesNegocio = new ContribuyentesNegocio();

        // Id seleccionado actualmente en el DataGridView
        private int _idContribuyenteSeleccionado = 0;

        private bool esNuevo = false; // Para distinguir entre nuevo y actualización

        public ListaContribuyentes()
        {
            InitializeComponent();
            Theme.ApplyTo(this);

            // Suscribir eventos
            if (dgvListaContribuyentes != null)
            {
                dgvListaContribuyentes.SelectionChanged += DgvListaContribuyentes_SelectionChanged;
                dgvListaContribuyentes.CellClick += DgvListaContribuyentes_SelectionChanged; // para clicks en celdas

                // Mostrar cursor de mano al posar sobre la columna de eliminar (imagen)
                dgvListaContribuyentes.CellMouseEnter += DgvListaContribuyentes_CellMouseEnter;
                dgvListaContribuyentes.CellMouseLeave += DgvListaContribuyentes_CellMouseLeave;
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
                // Desactivar generación automática de columnas para respetar las columnas definidas en el Designer
                dgvListaContribuyentes.AutoGenerateColumns = false;

                var lista = contribuyentesNegocio.ObtenerContribuyentes();

                // Enlaza columnas útiles al DataGridView (evita exponer navegación completa)
                dgvListaContribuyentes.DataSource = lista;

                // Forzar que la columna "Eliminar" quede en la última posición visual
                if (dgvListaContribuyentes.Columns.Contains("Eliminar"))
                {
                    dgvListaContribuyentes.Columns["Eliminar"].DisplayIndex = dgvListaContribuyentes.Columns.Count - 1;
                    // Asegurar que el AutoSizeMode no provoque reordenamientos inesperados
                    dgvListaContribuyentes.Columns["Eliminar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }

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
                    btnNuevo.Enabled = false;
                    btnActualizar.Enabled = false;
                    txbBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnGuardar.Enabled = true;
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
            esNuevo = true;
            pnlDatosUsuario.Enabled = true;
            btnActualizar.Enabled = false;
            txbBuscar.Enabled = false;
            btnNuevo.Enabled = false;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            cbxDiasDeGracia.SelectedIndex = 1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar campos y construir entidad
            Contribuyente contribuyente;
            if (!TryBuildAndValidateContribuyente(out contribuyente))
                return; // si no valida, se detiene

            // VALIDAR SI EL FOLIO YA EXISTE (solo si es nuevo)
            if (esNuevo)
            {
                var existente = contribuyentesNegocio.ObtenerContribuyentePorId(contribuyente.IdContribuyente);
                if (existente != null)
                {
                    MessageBox.Show("El folio ya existe, ingresa uno diferente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbFolio.Focus();
                    return; // DETIENE EL GUARDADO
                }
            }

            // Guardar según modo
            try
            {
                pnlDatosUsuario.Enabled = false;
                btnNuevo.Enabled = true;
                btnActualizar.Enabled = true;
                txbBuscar.Enabled = true;
                btnCancelar.Enabled = false;

                if (esNuevo == false)
                {
                    contribuyentesNegocio.ActualizarContribuyente(contribuyente);
                    MessageBox.Show("Se actualizó correctamente datos del contribuyente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    contribuyentesNegocio.AgregarContribuyente(contribuyente);
                    MessageBox.Show("Se agregó nuevo contribuyente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CargarContribuyentes();
                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar contribuyente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Valida los campos del formulario y construye la entidad Contribuyente.
        /// Retorna true si los datos son válidos; en caso contrario muestra el error y devuelve false.
        /// </summary>
        private bool TryBuildAndValidateContribuyente(out Contribuyente contribuyente)
        {
            contribuyente = null;

            // Folio
            string folioText = txbFolio.Text.Trim();
            if (string.IsNullOrEmpty(folioText))
            {
                MessageBox.Show("El folio es requerido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbFolio.Focus();
                return false;
            }
            if (!int.TryParse(folioText, out int folio) || folio <= 0)
            {
                MessageBox.Show("El folio debe ser un número entero positivo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbFolio.Focus();
                return false;
            }

            // Nombre
            string nombre = txbNombre.Text?.Trim() ?? string.Empty;
            if (string.IsNullOrEmpty(nombre) || nombre.Length < 3)
            {
                MessageBox.Show("El nombre es requerido (mínimo 3 caracteres).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbNombre.Focus();
                return false;
            }
            if (nombre.Length > 150)
            {
                MessageBox.Show("El nombre es demasiado largo (máximo 150 caracteres).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbNombre.Focus();
                return false;
            }

            // Dirección
            string direccion = txbDireccion.Text?.Trim() ?? string.Empty;
            if (string.IsNullOrEmpty(direccion) || direccion.Length < 5)
            {
                MessageBox.Show("La dirección es requerida (mínimo 5 caracteres).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbDireccion.Focus();
                return false;
            }
            if (direccion.Length > 200)
            {
                MessageBox.Show("La dirección es demasiado larga (máximo 200 caracteres).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbDireccion.Focus();
                return false;
            }

            // Teléfono (opcional pero si se ingresa validar formato)
            string telefono = txbTelefono.Text?.Trim() ?? string.Empty;
            if (!string.IsNullOrEmpty(telefono))
            {
                // acepta dígitos, espacios, '+', '-', '(', ')', entre 7 y 20 caracteres
                var phonePattern = @"^[\d\+\-\s\(\)]{7,20}$";
                if (!Regex.IsMatch(telefono, phonePattern))
                {
                    MessageBox.Show("Teléfono inválido. Use solo números, espacios, +, -, ( ).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbTelefono.Focus();
                    return false;
                }
            }

            // Email (opcional pero si se ingresa validar formato básico)
            string email = txbEmail.Text?.Trim() ?? string.Empty;
            if (!string.IsNullOrEmpty(email))
            {
                var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(email, emailPattern, RegexOptions.IgnoreCase))
                {
                    MessageBox.Show("Correo electrónico inválido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbEmail.Focus();
                    return false;
                }
                if (email.Length > 200)
                {
                    MessageBox.Show("El correo electrónico es demasiado largo (máximo 200 caracteres).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbEmail.Focus();
                    return false;
                }
            }

            // Tarifa y estado: asegurar selección si son requeridos por tu lógica (aquí los dejamos opcionales pero coherentes)
            int? idTarifa = cbxTarifa.SelectedValue != null && int.TryParse(cbxTarifa.SelectedValue.ToString(), out int t) ? (int?)t : null;
            int idEstado = cbxEstado.SelectedValue != null && int.TryParse(cbxEstado.SelectedValue.ToString(), out int s) ? s : 0;

            // Dias de gracia (opcional)
            int? diasGracia = null;
            if (cbxDiasDeGracia.SelectedIndex >= 0)
            {
                var map = new[] { 30, 60, 90 };
                if (cbxDiasDeGracia.SelectedIndex < map.Length)
                    diasGracia = map[cbxDiasDeGracia.SelectedIndex];
            }

            // Construir entidad
            contribuyente = new Contribuyente
            {
                IdContribuyente = folio,
                Nombre = nombre,
                Direccion = direccion,
                Telefono = telefono,
                Email = email,
                IdTarifa = idTarifa,
                IdEstado = idEstado,
                DiasGracia = diasGracia
            };

            return true;
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
            if (dgvListaContribuyentes.Columns.Contains("IdContribuyente"))
            {
                valor = fila.Cells["IdContribuyente"].Value;
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
                    txbFolio.Text = contribuyente.IdContribuyente.ToString();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            // Limpiar controles y restablecer estado
            pnlDatosUsuario.Enabled = false;
            btnNuevo.Enabled = true;
            btnActualizar.Enabled = true;
            txbBuscar.Enabled = true;
            txbBuscar.Text = string.Empty;
            btnCancelar.Enabled = false;
            _idContribuyenteSeleccionado = 0;
            txbNombre.Clear();
            txbDireccion.Clear();
            txbTelefono.Clear();
            txbEmail.Clear();
            cbxTarifa.SelectedIndex = 0;
            cbxEstado.SelectedIndex = 0;
            cbxDiasDeGracia.SelectedIndex = 0;
            esNuevo = false;
            btnGuardar.Enabled = false;

        }

        private void dgvListaContribuyentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvListaContribuyentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvListaContribuyentes.Columns["Eliminar"].Index && e.RowIndex >= 0)
                {
                    int id = Convert.ToInt32(
                        dgvListaContribuyentes.Rows[e.RowIndex].Cells["IdContribuyente"].Value
                    );

                    // Confirmación antes de eliminar
                    var fila = dgvListaContribuyentes.Rows[e.RowIndex];
                    string nombre = fila.Cells["Nombre"].Value != null ? fila.Cells["Nombre"].Value.ToString() : string.Empty;
                    var pregunta = $"¿Desea eliminar al contribuyente {(!string.IsNullOrEmpty(nombre) ? $"\"{nombre}\" (Folio {id})" : $"Folio {id}")}?";
                    var dr = MessageBox.Show(pregunta, "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (dr == DialogResult.Yes)
                    {
                        contribuyentesNegocio.ElimiContribuyente(id);
                        MessageBox.Show("Contribuyente eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarContribuyentes();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al eliminar el contribuyente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string criterio = txbBuscar.Text.Trim();
            ContribuyentesNegocio negocio = new ContribuyentesNegocio();
            var lista = negocio.BuscarContribuyentes(criterio);

            dgvListaContribuyentes.DataSource = lista;
        }

        private void dgvListaContribuyentes_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //Aqui pondre algunas cosas 
        }

        // Cambia el cursor cuando el ratón entra en una celda; pone mano si es la columna Eliminar
        private void DgvListaContribuyentes_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    var col = dgvListaContribuyentes.Columns[e.ColumnIndex];
                    if (string.Equals(col.Name, "Eliminar", StringComparison.OrdinalIgnoreCase))
                    {
                        dgvListaContribuyentes.Cursor = Cursors.Hand;
                      }
                    else
                    {
                        dgvListaContribuyentes.Cursor = Cursors.Default;
                    }
                }
            }
            catch
            {
                // silencioso
            }
        }

        // Restaurar cursor al salir de la celda
        private void DgvListaContribuyentes_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvListaContribuyentes.Cursor = Cursors.Default;
            }
            catch
            {
                // silencioso
            }
        }
    }
}

