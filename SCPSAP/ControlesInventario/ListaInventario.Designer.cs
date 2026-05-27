namespace SCPSAP.ControlesInventario
{
    partial class ListaInventario
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblListadoDeMateriales = new System.Windows.Forms.Label();
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dgvListaMateriales = new System.Windows.Forms.DataGridView();
            this.IdMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovimientoInventarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlDatosUsuario = new System.Windows.Forms.Panel();
            this.txbStockMinimo = new System.Windows.Forms.TextBox();
            this.cbxUnidadMedida = new System.Windows.Forms.ComboBox();
            this.lblStockMinimo = new System.Windows.Forms.Label();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.txbStockActual = new System.Windows.Forms.TextBox();
            this.lblStockActual = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMateriales)).BeginInit();
            this.pnlDatosUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblListadoDeMateriales
            // 
            this.lblListadoDeMateriales.AutoSize = true;
            this.lblListadoDeMateriales.Location = new System.Drawing.Point(3, 16);
            this.lblListadoDeMateriales.Name = "lblListadoDeMateriales";
            this.lblListadoDeMateriales.Size = new System.Drawing.Size(142, 13);
            this.lblListadoDeMateriales.TabIndex = 2;
            this.lblListadoDeMateriales.Text = "LISTADO DE MATERIALES";
            // 
            // txbBuscar
            // 
            this.txbBuscar.Location = new System.Drawing.Point(488, 9);
            this.txbBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(101, 20);
            this.txbBuscar.TabIndex = 27;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblBuscar.Location = new System.Drawing.Point(406, 13);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(79, 13);
            this.lblBuscar.TabIndex = 26;
            this.lblBuscar.Text = "Buscar material";
            // 
            // dgvListaMateriales
            // 
            this.dgvListaMateriales.AllowUserToAddRows = false;
            this.dgvListaMateriales.AllowUserToDeleteRows = false;
            this.dgvListaMateriales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaMateriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaMateriales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMaterial,
            this.Nombre,
            this.UnidadMedida,
            this.StockActual,
            this.StockMinimo,
            this.Activo,
            this.MovimientoInventarios,
            this.Eliminar});
            this.dgvListaMateriales.Location = new System.Drawing.Point(3, 41);
            this.dgvListaMateriales.MultiSelect = false;
            this.dgvListaMateriales.Name = "dgvListaMateriales";
            this.dgvListaMateriales.ReadOnly = true;
            this.dgvListaMateriales.RowHeadersWidth = 51;
            this.dgvListaMateriales.Size = new System.Drawing.Size(586, 327);
            this.dgvListaMateriales.TabIndex = 28;
            this.dgvListaMateriales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaMateriales_CellClick);
            // 
            // IdMaterial
            // 
            this.IdMaterial.DataPropertyName = "IdMaterial";
            this.IdMaterial.HeaderText = "IdMaterial";
            this.IdMaterial.MinimumWidth = 6;
            this.IdMaterial.Name = "IdMaterial";
            this.IdMaterial.ReadOnly = true;
            this.IdMaterial.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // UnidadMedida
            // 
            this.UnidadMedida.DataPropertyName = "UnidadMedida";
            this.UnidadMedida.HeaderText = "Unidad medida";
            this.UnidadMedida.MinimumWidth = 6;
            this.UnidadMedida.Name = "UnidadMedida";
            this.UnidadMedida.ReadOnly = true;
            // 
            // StockActual
            // 
            this.StockActual.DataPropertyName = "StockActual";
            this.StockActual.HeaderText = "Stock actual";
            this.StockActual.MinimumWidth = 6;
            this.StockActual.Name = "StockActual";
            this.StockActual.ReadOnly = true;
            // 
            // StockMinimo
            // 
            this.StockMinimo.DataPropertyName = "StockMinimo";
            this.StockMinimo.HeaderText = "Stock minimo";
            this.StockMinimo.MinimumWidth = 6;
            this.StockMinimo.Name = "StockMinimo";
            this.StockMinimo.ReadOnly = true;
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "Activo";
            this.Activo.HeaderText = "Activo";
            this.Activo.MinimumWidth = 6;
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Visible = false;
            // 
            // MovimientoInventarios
            // 
            this.MovimientoInventarios.DataPropertyName = "MovimientoInventarios";
            this.MovimientoInventarios.HeaderText = "MovimientoInventarios";
            this.MovimientoInventarios.MinimumWidth = 6;
            this.MovimientoInventarios.Name = "MovimientoInventarios";
            this.MovimientoInventarios.ReadOnly = true;
            this.MovimientoInventarios.Visible = false;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Eliminar.DataPropertyName = "btnEliminar";
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::SCPSAP.Properties.Resources.Borrar;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.ToolTipText = "Eliminar contribuyente";
            this.Eliminar.Width = 49;
            // 
            // pnlDatosUsuario
            // 
            this.pnlDatosUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDatosUsuario.Controls.Add(this.txbStockMinimo);
            this.pnlDatosUsuario.Controls.Add(this.cbxUnidadMedida);
            this.pnlDatosUsuario.Controls.Add(this.lblStockMinimo);
            this.pnlDatosUsuario.Controls.Add(this.lblUnidadMedida);
            this.pnlDatosUsuario.Controls.Add(this.txbStockActual);
            this.pnlDatosUsuario.Controls.Add(this.lblStockActual);
            this.pnlDatosUsuario.Controls.Add(this.txbNombre);
            this.pnlDatosUsuario.Controls.Add(this.lblNombre);
            this.pnlDatosUsuario.Location = new System.Drawing.Point(0, 374);
            this.pnlDatosUsuario.Name = "pnlDatosUsuario";
            this.pnlDatosUsuario.Size = new System.Drawing.Size(589, 77);
            this.pnlDatosUsuario.TabIndex = 29;
            // 
            // txbStockMinimo
            // 
            this.txbStockMinimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txbStockMinimo.Location = new System.Drawing.Point(408, 48);
            this.txbStockMinimo.Name = "txbStockMinimo";
            this.txbStockMinimo.Size = new System.Drawing.Size(165, 20);
            this.txbStockMinimo.TabIndex = 21;
            // 
            // cbxUnidadMedida
            // 
            this.cbxUnidadMedida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxUnidadMedida.FormattingEnabled = true;
            this.cbxUnidadMedida.Items.AddRange(new object[] {
            "Metro (m)",
            "Centímetro (cm)",
            "Pulgada (in)",
            "Pie (ft)",
            "Kilogramo (kg)",
            "Gramo (g)",
            "Tonelada (t)",
            "Libra (lb)",
            "Litro (L)",
            "Mililitro (mL)",
            "Metro cúbico (m³)",
            "Amperio (A)",
            "Voltio (V)",
            "Ohmio (Ω)"});
            this.cbxUnidadMedida.Location = new System.Drawing.Point(408, 9);
            this.cbxUnidadMedida.Name = "cbxUnidadMedida";
            this.cbxUnidadMedida.Size = new System.Drawing.Size(165, 21);
            this.cbxUnidadMedida.TabIndex = 16;
            // 
            // lblStockMinimo
            // 
            this.lblStockMinimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStockMinimo.AutoSize = true;
            this.lblStockMinimo.Location = new System.Drawing.Point(323, 52);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(73, 13);
            this.lblStockMinimo.TabIndex = 12;
            this.lblStockMinimo.Text = "Stock minimo:";
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Location = new System.Drawing.Point(324, 12);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(81, 13);
            this.lblUnidadMedida.TabIndex = 10;
            this.lblUnidadMedida.Text = "Unidad medida:";
            // 
            // txbStockActual
            // 
            this.txbStockActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbStockActual.Location = new System.Drawing.Point(82, 47);
            this.txbStockActual.Name = "txbStockActual";
            this.txbStockActual.Size = new System.Drawing.Size(189, 20);
            this.txbStockActual.TabIndex = 5;
            // 
            // lblStockActual
            // 
            this.lblStockActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStockActual.AutoSize = true;
            this.lblStockActual.Location = new System.Drawing.Point(7, 51);
            this.lblStockActual.Name = "lblStockActual";
            this.lblStockActual.Size = new System.Drawing.Size(73, 13);
            this.lblStockActual.TabIndex = 4;
            this.lblStockActual.Text = "Stock actual :";
            // 
            // txbNombre
            // 
            this.txbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbNombre.Location = new System.Drawing.Point(82, 8);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(189, 20);
            this.txbNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(32, 12);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(167, 462);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Location = new System.Drawing.Point(4, 462);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 25);
            this.btnActualizar.TabIndex = 32;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.Location = new System.Drawing.Point(86, 462);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 25);
            this.btnNuevo.TabIndex = 31;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(514, 463);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 25);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.DataPropertyName = "btnEliminar";
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.Image = global::SCPSAP.Properties.Resources.Borrar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.ToolTipText = "Eliminar contribuyente";
            // 
            // ListaInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnlDatosUsuario);
            this.Controls.Add(this.dgvListaMateriales);
            this.Controls.Add(this.txbBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblListadoDeMateriales);
            this.Name = "ListaInventario";
            this.Size = new System.Drawing.Size(592, 493);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMateriales)).EndInit();
            this.pnlDatosUsuario.ResumeLayout(false);
            this.pnlDatosUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListadoDeMateriales;
        private System.Windows.Forms.TextBox txbBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView dgvListaMateriales;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovimientoInventarios;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.Panel pnlDatosUsuario;
        private System.Windows.Forms.ComboBox cbxUnidadMedida;
        private System.Windows.Forms.Label lblStockMinimo;
        private System.Windows.Forms.Label lblUnidadMedida;
        private System.Windows.Forms.TextBox txbStockActual;
        private System.Windows.Forms.Label lblStockActual;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txbStockMinimo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}
