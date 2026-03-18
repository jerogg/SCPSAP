namespace SCPSAP.ControlesConfiguracion
{
    partial class Configuracion
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
            this.lblConfiguracion = new System.Windows.Forms.Label();
            this.tbcConfiguracion = new System.Windows.Forms.TabControl();
            this.tbTarifas = new System.Windows.Forms.TabPage();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txbMontoMensual = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvConfiguracion = new System.Windows.Forms.DataGridView();
            this.lblNombreTarifa = new System.Windows.Forms.Label();
            this.tbpUsuarios = new System.Windows.Forms.TabPage();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.btnCancelarUsuario = new System.Windows.Forms.Button();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.btnActualizarUsuario = new System.Windows.Forms.Button();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.dgvName = new System.Windows.Forms.DataGridView();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.tbcConfiguracion.SuspendLayout();
            this.tbTarifas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfiguracion)).BeginInit();
            this.tbpUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvName)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConfiguracion
            // 
            this.lblConfiguracion.AutoSize = true;
            this.lblConfiguracion.Location = new System.Drawing.Point(13, 9);
            this.lblConfiguracion.Name = "lblConfiguracion";
            this.lblConfiguracion.Size = new System.Drawing.Size(96, 13);
            this.lblConfiguracion.TabIndex = 2;
            this.lblConfiguracion.Text = "CONFIGURACION";
            // 
            // tbcConfiguracion
            // 
            this.tbcConfiguracion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcConfiguracion.Controls.Add(this.tbTarifas);
            this.tbcConfiguracion.Controls.Add(this.tbpUsuarios);
            this.tbcConfiguracion.Location = new System.Drawing.Point(3, 30);
            this.tbcConfiguracion.Name = "tbcConfiguracion";
            this.tbcConfiguracion.SelectedIndex = 0;
            this.tbcConfiguracion.Size = new System.Drawing.Size(592, 380);
            this.tbcConfiguracion.TabIndex = 3;
            // 
            // tbTarifas
            // 
            this.tbTarifas.Controls.Add(this.btnGuardar);
            this.tbTarifas.Controls.Add(this.btnCancelar);
            this.tbTarifas.Controls.Add(this.btnNuevo);
            this.tbTarifas.Controls.Add(this.btnActualizar);
            this.tbTarifas.Controls.Add(this.txbMontoMensual);
            this.tbTarifas.Controls.Add(this.txbNombre);
            this.tbTarifas.Controls.Add(this.label1);
            this.tbTarifas.Controls.Add(this.dgvConfiguracion);
            this.tbTarifas.Controls.Add(this.lblNombreTarifa);
            this.tbTarifas.Location = new System.Drawing.Point(4, 22);
            this.tbTarifas.Name = "tbTarifas";
            this.tbTarifas.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbTarifas.Size = new System.Drawing.Size(584, 354);
            this.tbTarifas.TabIndex = 0;
            this.tbTarifas.Text = "Tarifas";
            this.tbTarifas.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(502, 322);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 25);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.Location = new System.Drawing.Point(168, 322);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 24);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.Location = new System.Drawing.Point(85, 322);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 25);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnActualizar.Location = new System.Drawing.Point(6, 322);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(71, 25);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // txbMontoMensual
            // 
            this.txbMontoMensual.Location = new System.Drawing.Point(395, 222);
            this.txbMontoMensual.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbMontoMensual.Name = "txbMontoMensual";
            this.txbMontoMensual.Size = new System.Drawing.Size(83, 20);
            this.txbMontoMensual.TabIndex = 4;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(63, 222);
            this.txbNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(208, 20);
            this.txbNombre.TabIndex = 3;
            this.txbNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 226);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Monto mensual:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvConfiguracion
            // 
            this.dgvConfiguracion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfiguracion.Location = new System.Drawing.Point(0, 3);
            this.dgvConfiguracion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvConfiguracion.Name = "dgvConfiguracion";
            this.dgvConfiguracion.RowHeadersWidth = 62;
            this.dgvConfiguracion.RowTemplate.Height = 28;
            this.dgvConfiguracion.Size = new System.Drawing.Size(587, 199);
            this.dgvConfiguracion.TabIndex = 1;
            this.dgvConfiguracion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConfiguracion_CellContentClick);
            // 
            // lblNombreTarifa
            // 
            this.lblNombreTarifa.AutoSize = true;
            this.lblNombreTarifa.Location = new System.Drawing.Point(15, 226);
            this.lblNombreTarifa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreTarifa.Name = "lblNombreTarifa";
            this.lblNombreTarifa.Size = new System.Drawing.Size(44, 13);
            this.lblNombreTarifa.TabIndex = 0;
            this.lblNombreTarifa.Text = "Nombre";
            // 
            // tbpUsuarios
            // 
            this.tbpUsuarios.Controls.Add(this.btnGuardarUsuario);
            this.tbpUsuarios.Controls.Add(this.btnCancelarUsuario);
            this.tbpUsuarios.Controls.Add(this.btnNuevoUsuario);
            this.tbpUsuarios.Controls.Add(this.btnActualizarUsuario);
            this.tbpUsuarios.Controls.Add(this.txtRol);
            this.tbpUsuarios.Controls.Add(this.txt_Password);
            this.tbpUsuarios.Controls.Add(this.txt_Nombre);
            this.tbpUsuarios.Controls.Add(this.lblRol);
            this.tbpUsuarios.Controls.Add(this.lblPassword);
            this.tbpUsuarios.Controls.Add(this.dgvName);
            this.tbpUsuarios.Controls.Add(this.lblNombreUsuario);
            this.tbpUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tbpUsuarios.Name = "tbpUsuarios";
            this.tbpUsuarios.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbpUsuarios.Size = new System.Drawing.Size(584, 354);
            this.tbpUsuarios.TabIndex = 1;
            this.tbpUsuarios.Text = "Usuarios";
            this.tbpUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.Location = new System.Drawing.Point(315, 278);
            this.btnGuardarUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(50, 15);
            this.btnGuardarUsuario.TabIndex = 11;
            this.btnGuardarUsuario.Text = "Guardar";
            this.btnGuardarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnCancelarUsuario
            // 
            this.btnCancelarUsuario.Location = new System.Drawing.Point(225, 278);
            this.btnCancelarUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelarUsuario.Name = "btnCancelarUsuario";
            this.btnCancelarUsuario.Size = new System.Drawing.Size(50, 15);
            this.btnCancelarUsuario.TabIndex = 10;
            this.btnCancelarUsuario.Text = "Cancelar";
            this.btnCancelarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Location = new System.Drawing.Point(139, 278);
            this.btnNuevoUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(50, 15);
            this.btnNuevoUsuario.TabIndex = 9;
            this.btnNuevoUsuario.Text = "Nuevo";
            this.btnNuevoUsuario.UseVisualStyleBackColor = true;
            // 
            // btnActualizarUsuario
            // 
            this.btnActualizarUsuario.Location = new System.Drawing.Point(51, 278);
            this.btnActualizarUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizarUsuario.Name = "btnActualizarUsuario";
            this.btnActualizarUsuario.Size = new System.Drawing.Size(50, 15);
            this.btnActualizarUsuario.TabIndex = 8;
            this.btnActualizarUsuario.Text = "Actualizar";
            this.btnActualizarUsuario.UseVisualStyleBackColor = true;
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(139, 212);
            this.txtRol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(145, 20);
            this.txtRol.TabIndex = 7;
            this.txtRol.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(139, 178);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(145, 20);
            this.txt_Password.TabIndex = 6;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(139, 151);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(145, 20);
            this.txt_Nombre.TabIndex = 5;
            this.txt_Nombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(20, 216);
            this.lblRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(23, 13);
            this.lblRol.TabIndex = 3;
            this.lblRol.Text = "Rol";
            this.lblRol.Click += new System.EventHandler(this.lblRol_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 182);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // dgvName
            // 
            this.dgvName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvName.Location = new System.Drawing.Point(8, 12);
            this.dgvName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvName.Name = "dgvName";
            this.dgvName.RowHeadersWidth = 51;
            this.dgvName.RowTemplate.Height = 24;
            this.dgvName.Size = new System.Drawing.Size(652, 108);
            this.dgvName.TabIndex = 1;
            this.dgvName.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvName_CellContentClick);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(20, 155);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(44, 13);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Nombre";
            this.lblNombreUsuario.Click += new System.EventHandler(this.lblNombreUsuario_Click);
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbcConfiguracion);
            this.Controls.Add(this.lblConfiguracion);
            this.Name = "Configuracion";
            this.Size = new System.Drawing.Size(598, 421);
            this.tbcConfiguracion.ResumeLayout(false);
            this.tbTarifas.ResumeLayout(false);
            this.tbTarifas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfiguracion)).EndInit();
            this.tbpUsuarios.ResumeLayout(false);
            this.tbpUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfiguracion;
        private System.Windows.Forms.TabControl tbcConfiguracion;
        private System.Windows.Forms.TabPage tbTarifas;
        private System.Windows.Forms.TabPage tbpUsuarios;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.DataGridView dgvName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvConfiguracion;
        private System.Windows.Forms.Label lblNombreTarifa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Button btnActualizarUsuario;
        private System.Windows.Forms.TextBox txbMontoMensual;
        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.Button btnCancelarUsuario;
        private System.Windows.Forms.Button btnGuardarUsuario;
    }
}
