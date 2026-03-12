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
            this.dgvListaContribuyentes.Location = new System.Drawing.Point(3, 53);
            this.dgvListaContribuyentes.MultiSelect = false;
            this.dgvListaContribuyentes.Name = "dgvListaContribuyentes";
            this.dgvListaContribuyentes.ReadOnly = true;
            this.dgvListaContribuyentes.RowHeadersWidth = 51;
            this.dgvListaContribuyentes.Size = new System.Drawing.Size(586, 229);
            this.dgvListaContribuyentes.TabIndex = 0;
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
            this.lblTarifa.Location = new System.Drawing.Point(363, 15);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Size = new System.Drawing.Size(37, 13);
            this.lblTarifa.TabIndex = 10;
            this.lblTarifa.Text = "Tarifa:";
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
            this.lblEstado.Location = new System.Drawing.Point(357, 94);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado:";
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
            this.lblFolio.Location = new System.Drawing.Point(367, 131);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(32, 13);
            this.lblFolio.TabIndex = 19;
            this.lblFolio.Text = "Folio:";
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
            // ListaContribuyentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
