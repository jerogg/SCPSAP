namespace SCPSAP.Contribuyentes
{
    partial class ListaContribuyentes
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
            this.dgvListaContribuyentes = new System.Windows.Forms.DataGridView();
            this.lblListadoDeContribuyentes = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.lblDiasDeGracia = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbxTarifa = new System.Windows.Forms.ComboBox();
            this.cbxDiasDeGracia = new System.Windows.Forms.ComboBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.pnlDatosUsuario = new System.Windows.Forms.Panel();
            this.txbFolio = new System.Windows.Forms.TextBox();
            this.lblFolio = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.IdContribuyente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaUltimoAviso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaLimitePago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasGracia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaContribuyentes)).BeginInit();
            this.pnlDatosUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaContribuyentes
            // 
            this.dgvListaContribuyentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaContribuyentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaContribuyentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaContribuyentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdContribuyente,
            this.IdEstado,
            this.IdTarifa,
            this.FechaUltimoAviso,
            this.FechaLimitePago,
            this.DiasGracia,
            this.Nombre,
            this.Direccion,
            this.Telefono,
            this.FechaAlta,
            this.Estado,
            this.Tarifa,
            this.Email,
            this.Eliminar});
            this.dgvListaContribuyentes.Location = new System.Drawing.Point(3, 53);
            this.dgvListaContribuyentes.MultiSelect = false;
            this.dgvListaContribuyentes.Name = "dgvListaContribuyentes";
            this.dgvListaContribuyentes.ReadOnly = true;
            this.dgvListaContribuyentes.RowHeadersWidth = 51;
            this.dgvListaContribuyentes.Size = new System.Drawing.Size(586, 229);
            this.dgvListaContribuyentes.TabIndex = 0;
            this.dgvListaContribuyentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaContribuyentes_CellClick);
            this.dgvListaContribuyentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaContribuyentes_CellContentClick);
            this.dgvListaContribuyentes.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvListaContribuyentes_CellPainting);
            // 
            // lblListadoDeContribuyentes
            // 
            this.lblListadoDeContribuyentes.AutoSize = true;
            this.lblListadoDeContribuyentes.Location = new System.Drawing.Point(4, 23);
            this.lblListadoDeContribuyentes.Name = "lblListadoDeContribuyentes";
            this.lblListadoDeContribuyentes.Size = new System.Drawing.Size(173, 13);
            this.lblListadoDeContribuyentes.TabIndex = 1;
            this.lblListadoDeContribuyentes.Text = "LISTADO DE CONTRIBUYENTES";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txbNombre
            // 
            this.txbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbNombre.Location = new System.Drawing.Point(65, 11);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(206, 20);
            this.txbNombre.TabIndex = 3;
            // 
            // txbDireccion
            // 
            this.txbDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbDireccion.Location = new System.Drawing.Point(65, 50);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(206, 20);
            this.txbDireccion.TabIndex = 5;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(7, 54);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txbTelefono
            // 
            this.txbTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbTelefono.Location = new System.Drawing.Point(65, 89);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(206, 20);
            this.txbTelefono.TabIndex = 7;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(10, 93);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txbEmail
            // 
            this.txbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbEmail.Location = new System.Drawing.Point(65, 128);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(206, 20);
            this.txbEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(27, 132);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // lblTarifa
            // 
            this.lblTarifa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTarifa.AutoSize = true;
            this.lblTarifa.Location = new System.Drawing.Point(321, 15);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Size = new System.Drawing.Size(79, 13);
            this.lblTarifa.TabIndex = 10;
            this.lblTarifa.Text = "Tarifa mensual:";
            // 
            // lblDiasDeGracia
            // 
            this.lblDiasDeGracia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiasDeGracia.AutoSize = true;
            this.lblDiasDeGracia.Location = new System.Drawing.Point(318, 55);
            this.lblDiasDeGracia.Name = "lblDiasDeGracia";
            this.lblDiasDeGracia.Size = new System.Drawing.Size(82, 13);
            this.lblDiasDeGracia.TabIndex = 12;
            this.lblDiasDeGracia.Text = "Días de Gracia:";
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(346, 94);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(54, 13);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Situacion:";
            // 
            // cbxTarifa
            // 
            this.cbxTarifa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTarifa.FormattingEnabled = true;
            this.cbxTarifa.Location = new System.Drawing.Point(403, 12);
            this.cbxTarifa.Name = "cbxTarifa";
            this.cbxTarifa.Size = new System.Drawing.Size(165, 21);
            this.cbxTarifa.TabIndex = 16;
            // 
            // cbxDiasDeGracia
            // 
            this.cbxDiasDeGracia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxDiasDeGracia.FormattingEnabled = true;
            this.cbxDiasDeGracia.Items.AddRange(new object[] {
            "30",
            "60",
            "90"});
            this.cbxDiasDeGracia.Location = new System.Drawing.Point(403, 51);
            this.cbxDiasDeGracia.Name = "cbxDiasDeGracia";
            this.cbxDiasDeGracia.Size = new System.Drawing.Size(165, 21);
            this.cbxDiasDeGracia.TabIndex = 17;
            // 
            // cbxEstado
            // 
            this.cbxEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(403, 90);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(165, 21);
            this.cbxEstado.TabIndex = 18;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(510, 459);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.Location = new System.Drawing.Point(87, 459);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 20;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Location = new System.Drawing.Point(6, 459);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 21;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // pnlDatosUsuario
            // 
            this.pnlDatosUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDatosUsuario.Controls.Add(this.txbFolio);
            this.pnlDatosUsuario.Controls.Add(this.lblFolio);
            this.pnlDatosUsuario.Controls.Add(this.cbxEstado);
            this.pnlDatosUsuario.Controls.Add(this.cbxDiasDeGracia);
            this.pnlDatosUsuario.Controls.Add(this.cbxTarifa);
            this.pnlDatosUsuario.Controls.Add(this.lblEstado);
            this.pnlDatosUsuario.Controls.Add(this.lblDiasDeGracia);
            this.pnlDatosUsuario.Controls.Add(this.lblTarifa);
            this.pnlDatosUsuario.Controls.Add(this.txbEmail);
            this.pnlDatosUsuario.Controls.Add(this.lblEmail);
            this.pnlDatosUsuario.Controls.Add(this.txbTelefono);
            this.pnlDatosUsuario.Controls.Add(this.lblTelefono);
            this.pnlDatosUsuario.Controls.Add(this.txbDireccion);
            this.pnlDatosUsuario.Controls.Add(this.lblDireccion);
            this.pnlDatosUsuario.Controls.Add(this.txbNombre);
            this.pnlDatosUsuario.Controls.Add(this.lblNombre);
            this.pnlDatosUsuario.Enabled = false;
            this.pnlDatosUsuario.Location = new System.Drawing.Point(5, 289);
            this.pnlDatosUsuario.Name = "pnlDatosUsuario";
            this.pnlDatosUsuario.Size = new System.Drawing.Size(584, 159);
            this.pnlDatosUsuario.TabIndex = 22;
            // 
            // txbFolio
            // 
            this.txbFolio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txbFolio.Location = new System.Drawing.Point(403, 127);
            this.txbFolio.Name = "txbFolio";
            this.txbFolio.Size = new System.Drawing.Size(165, 20);
            this.txbFolio.TabIndex = 20;
            // 
            // lblFolio
            // 
            this.lblFolio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFolio.AutoSize = true;
            this.lblFolio.Location = new System.Drawing.Point(333, 131);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(67, 13);
            this.lblFolio.TabIndex = 19;
            this.lblFolio.Text = "Folio/Boleta:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(168, 459);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblBuscar.Location = new System.Drawing.Point(357, 20);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(111, 13);
            this.lblBuscar.TabIndex = 24;
            this.lblBuscar.Text = "Buscar Contribuyente ";
            // 
            // txbBuscar
            // 
            this.txbBuscar.Location = new System.Drawing.Point(472, 17);
            this.txbBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(101, 20);
            this.txbBuscar.TabIndex = 25;
            this.txbBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // IdContribuyente
            // 
            this.IdContribuyente.DataPropertyName = "IdContribuyente";
            this.IdContribuyente.HeaderText = "Folio";
            this.IdContribuyente.Name = "IdContribuyente";
            this.IdContribuyente.ReadOnly = true;
            // 
            // IdEstado
            // 
            this.IdEstado.DataPropertyName = "IdEstado";
            this.IdEstado.HeaderText = "IdEstado";
            this.IdEstado.Name = "IdEstado";
            this.IdEstado.ReadOnly = true;
            this.IdEstado.Visible = false;
            // 
            // IdTarifa
            // 
            this.IdTarifa.DataPropertyName = "IdTarifa";
            this.IdTarifa.HeaderText = "IdTarifa";
            this.IdTarifa.Name = "IdTarifa";
            this.IdTarifa.ReadOnly = true;
            this.IdTarifa.Visible = false;
            // 
            // FechaUltimoAviso
            // 
            this.FechaUltimoAviso.DataPropertyName = "FechaUltimoAviso";
            this.FechaUltimoAviso.HeaderText = "FechaUltimoAviso";
            this.FechaUltimoAviso.Name = "FechaUltimoAviso";
            this.FechaUltimoAviso.ReadOnly = true;
            this.FechaUltimoAviso.Visible = false;
            // 
            // FechaLimitePago
            // 
            this.FechaLimitePago.DataPropertyName = "FechaLimitePago";
            this.FechaLimitePago.HeaderText = "FechaLimitePago";
            this.FechaLimitePago.Name = "FechaLimitePago";
            this.FechaLimitePago.ReadOnly = true;
            this.FechaLimitePago.Visible = false;
            // 
            // DiasGracia
            // 
            this.DiasGracia.DataPropertyName = "DiasGracia";
            this.DiasGracia.HeaderText = "DiasGracia";
            this.DiasGracia.Name = "DiasGracia";
            this.DiasGracia.ReadOnly = true;
            this.DiasGracia.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // FechaAlta
            // 
            this.FechaAlta.DataPropertyName = "FechaAlta";
            this.FechaAlta.HeaderText = "Fecha de alta";
            this.FechaAlta.Name = "FechaAlta";
            this.FechaAlta.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "EstadoDescripcion";
            this.Estado.HeaderText = "Situacion";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Tarifa
            // 
            this.Tarifa.DataPropertyName = "Tarifa";
            this.Tarifa.HeaderText = "Tarifa mensual";
            this.Tarifa.Name = "Tarifa";
            this.Tarifa.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Eliminar.DataPropertyName = "btnEliminar";
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 49;
            // 
            // ListaContribuyentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txbBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnlDatosUsuario);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblListadoDeContribuyentes);
            this.Controls.Add(this.dgvListaContribuyentes);
            this.Name = "ListaContribuyentes";
            this.Size = new System.Drawing.Size(592, 493);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaContribuyentes)).EndInit();
            this.pnlDatosUsuario.ResumeLayout(false);
            this.pnlDatosUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaContribuyentes;
        private System.Windows.Forms.Label lblListadoDeContribuyentes;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.Label lblDiasDeGracia;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbxTarifa;
        private System.Windows.Forms.ComboBox cbxDiasDeGracia;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel pnlDatosUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txbFolio;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txbBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdContribuyente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaUltimoAviso;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaLimitePago;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasGracia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}
