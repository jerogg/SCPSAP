using CapaUI;
using Datos;
using Datos.Configuracion;
using Negocio.Configuracion;
using Negocio.Contribuyentes;
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
        // Id seleccionado actualmente en el DataGridView
        private int _idMaterialSeleccionado = 0;
        public ListaInventario()
        {
            InitializeComponent();
            Theme.ApplyTo(this);
            CargarMateriales();


            // Suscribir eventos
            if (dgvListaMateriales != null)
            {
                dgvListaMateriales.SelectionChanged += dgvListaMateriales_SelectionChanged;
                dgvListaMateriales.CellClick += dgvListaMateriales_SelectionChanged; // para clicks en celdas

                // Mostrar cursor de mano al posar sobre la columna de eliminar (imagen)
                dgvListaMateriales.CellMouseEnter += dgvListaMateriales_CellMouseEnter;
                dgvListaMateriales.CellMouseLeave += dgvListaMateriales_CellMouseLeave;
            }
        }

        private void CargarMateriales()
        {
            try
            {
                var lista = materialesNegocio.ObtenerMateriales();
                dgvListaMateriales.DataSource = lista;
                LimpiarControles();

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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = ObtenerIdMaterialSeleccionadaDesdeGrid();
                if (id > 0)
                {
                    _idMaterialSeleccionado = id;
                    btnNuevo.Enabled = false;
                    btnActualizar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnGuardar.Enabled = true;
                    txbNombre.Enabled = true;
                    txbStockActual.Enabled = true;
                    cbxUnidadMedida.Enabled = true;
                    txbStockMinimo.Enabled = true;

                    // Aquí podrías cargar los datos completos del material en los controles:
                    CargarMaterialesEnControles(_idMaterialSeleccionado);
                }
                else
                {
                    MessageBox.Show("Seleccione un material antes de actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al obtener contribuyente seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ObtenerIdMaterialSeleccionadaDesdeGrid()
        {
            if (dgvListaMateriales == null)
                return 0;

            DataGridViewRow fila = null;

            if (dgvListaMateriales.SelectedRows != null && dgvListaMateriales.SelectedRows.Count > 0)
            {
                fila = dgvListaMateriales.SelectedRows[0];
            }
            else if (dgvListaMateriales.CurrentRow != null)
            {
                fila = dgvListaMateriales.CurrentRow;
            }

            if (fila == null)
                return 0;

            object valor = null;

            if (dgvListaMateriales.Columns.Contains("IdMaterial"))
            {
                valor = fila.Cells["IdMaterial"].Value;
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

        public void CargarMaterialesEnControles(int IdMaterial)
        {
            try
            {
                var material = materialesNegocio.ObtenerMaterialesPorId(IdMaterial);
                if (material != null)
                {
                    txbNombre.Text = material.Nombre;
                    txbStockActual.Text = material.StockActual.ToString();
                    cbxUnidadMedida.SelectedValue = material.UnidadMedida;
                    txbStockMinimo.Text = material.StockMinimo.ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró el material seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar datos del material", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            txbStockActual.Enabled = true;
            cbxUnidadMedida.Enabled = true;
            txbStockMinimo.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            btnNuevo.Enabled = true;
            btnActualizar.Enabled = true;
            btnCancelar.Enabled = false;
            txbNombre.Clear();
            txbStockActual.Clear();
            cbxUnidadMedida.SelectedIndex = 0;
            txbStockMinimo.Clear();
            btnGuardar.Enabled = false;
            txbNombre.Enabled = false;
            txbStockActual.Enabled = false;
            cbxUnidadMedida.Enabled = false;
            txbStockMinimo.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Material material = new Material();
            material.IdMaterial = _idMaterialSeleccionado;
            material.Nombre = txbNombre.Text;
            material.StockActual = int.Parse(txbStockActual.Text);
            material.UnidadMedida = cbxUnidadMedida.SelectedItem.ToString();
            material.StockMinimo = int.Parse(txbStockMinimo.Text);
            AgregarMateriales(material);
        }

        public void AgregarMateriales(Material material)
        {
            try
            {
                materialesNegocio.AgregarMateriales(material);
                MessageBox.Show("Se guardo material", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarMateriales();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar material", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvListaMateriales_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarEstadoBotonActualizar();
        }

        // Habilita btnActualizar sólo cuando hay una fila seleccionada
        private void ActualizarEstadoBotonActualizar()
        {
            try
            {
                bool tieneSeleccion = false;

                if (dgvListaMateriales != null)
                {
                    // Preferir SelectedRows cuando el SelectionMode lo permita
                    if (dgvListaMateriales.SelectedRows != null && dgvListaMateriales.SelectedRows.Count > 0)
                    {
                        tieneSeleccion = dgvListaMateriales.SelectedRows.Cast<DataGridViewRow>()
                            .Any(r => r != null && r.Index >= 0);
                    }
                    else
                    {
                        // Fallback a CurrentRow / CurrentCell
                        tieneSeleccion = dgvListaMateriales.CurrentRow != null && dgvListaMateriales.CurrentRow.Index >= 0;
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
        private void dgvListaMateriales_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    var col = dgvListaMateriales.Columns[e.ColumnIndex];
                    if (string.Equals(col.Name, "Eliminar", StringComparison.OrdinalIgnoreCase))
                    {
                        dgvListaMateriales.Cursor = Cursors.Hand;
                    }
                    else
                    {
                        dgvListaMateriales.Cursor = Cursors.Default;
                    }
                }
            }
            catch
            {
                // silencioso
            }
        }

        // Restaurar cursor al salir de la celda
        private void dgvListaMateriales_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvListaMateriales.Cursor = Cursors.Default;
            }
            catch
            {
                // silencioso
            }
        }

        private async void dgvListaMateriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvListaMateriales.Columns["Eliminar"].Index && e.RowIndex >= 0)
                {
                    int id = Convert.ToInt32(
                        dgvListaMateriales.Rows[e.RowIndex].Cells["IdMaterial"].Value
                    );

                    // Confirmación antes de eliminar
                    var fila = dgvListaMateriales.Rows[e.RowIndex];
                    string nombre = fila.Cells["Nombre"].Value != null ? fila.Cells["Nombre"].Value.ToString() : string.Empty;
                    var pregunta = $"¿Desea eliminar el material " + nombre + "?";
                    var dr = MessageBox.Show(pregunta, "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (dr == DialogResult.Yes)
                    {
                        this.Enabled = false;

                        await Task.Run(() =>
                        {
                            materialesNegocio.EliminarMaterial(id);
                        });

                        MessageBox.Show("Material eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarMateriales();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al eliminar material", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Enabled = true;
            }
        }

        private async void txbBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;

                string texto = txbBuscar.Text;

                var lista = await Task.Run(() =>
                {
                    return new MaterialesNegocio().BuscarMateriales(texto);
                });

                dgvListaMateriales.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                this.Enabled = true;
            }
        }
    }
}
