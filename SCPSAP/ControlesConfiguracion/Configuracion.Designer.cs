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
            this.tbpUsuarios = new System.Windows.Forms.TabPage();
            this.lblNombreTarifa = new System.Windows.Forms.Label();
            this.dgvConfiguracion = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMonto_mensual = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.dgvName = new System.Windows.Forms.DataGridView();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.btnActualizarUsuario = new System.Windows.Forms.Button();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.btnCancelarUsuario = new System.Windows.Forms.Button();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.tbcConfiguracion.SuspendLayout();
            this.tbpUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvName)).BeginInit();
            this.tbTarifas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfiguracion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConfiguracion
            // 
            this.lblConfiguracion.AutoSize = true;
            this.lblConfiguracion.Location = new System.Drawing.Point(17, 11);
            this.lblConfiguracion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfiguracion.Location = new System.Drawing.Point(20, 14);
            this.lblConfiguracion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfiguracion.Name = "lblConfiguracion";
            this.lblConfiguracion.Size = new System.Drawing.Size(118, 16);
            this.lblConfiguracion.Size = new System.Drawing.Size(145, 20);
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
            this.tbcConfiguracion.Location = new System.Drawing.Point(4, 57);
            this.tbcConfiguracion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbcConfiguracion.Location = new System.Drawing.Point(4, 46);
            this.tbcConfiguracion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbcConfiguracion.Name = "tbcConfiguracion";
            this.tbcConfiguracion.SelectedIndex = 0;
            this.tbcConfiguracion.Size = new System.Drawing.Size(1019, 575);
            this.tbcConfiguracion.Size = new System.Drawing.Size(1146, 718);
            this.tbcConfiguracion.TabIndex = 3;
            // 
            // tbTarifas
            // 
            this.tbTarifas.Controls.Add(this.btnGuardar);
            this.tbTarifas.Controls.Add(this.btnCancelar);
            this.tbTarifas.Controls.Add(this.btnNuevo);
            this.tbTarifas.Controls.Add(this.btnActualizar);
            this.tbTarifas.Controls.Add(this.txtMonto_mensual);
            this.tbTarifas.Controls.Add(this.txtNombre);
            this.tbTarifas.Controls.Add(this.label1);
            this.tbTarifas.Controls.Add(this.dgvConfiguracion);
            this.tbTarifas.Controls.Add(this.lblNombreTarifa);
            this.tbTarifas.Location = new System.Drawing.Point(4, 29);
            this.tbTarifas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTarifas.Location = new System.Drawing.Point(4, 25);
            this.tbTarifas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTarifas.Name = "tbTarifas";
            this.tbTarifas.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTarifas.Size = new System.Drawing.Size(1011, 546);
            this.tbTarifas.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTarifas.Size = new System.Drawing.Size(1138, 685);
            this.tbTarifas.TabIndex = 0;
            this.tbTarifas.Text = "Tarifas";
            this.tbTarifas.UseVisualStyleBackColor = true;
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
            this.tbpUsuarios.Location = new System.Drawing.Point(4, 25);
            this.tbpUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpUsuarios.Location = new System.Drawing.Point(4, 29);
            this.tbpUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbpUsuarios.Name = "tbpUsuarios";
            this.tbpUsuarios.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpUsuarios.Size = new System.Drawing.Size(1011, 546);
            this.tbpUsuarios.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbpUsuarios.Size = new System.Drawing.Size(1138, 685);
            this.tbpUsuarios.TabIndex = 1;
            this.tbpUsuarios.Text = "Usuarios";
            this.tbpUsuarios.UseVisualStyleBackColor = true;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(30, 239);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(56, 16);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Nombre";
            this.lblNombreUsuario.Click += new System.EventHandler(this.lblNombreUsuario_Click);
            // 
            // dgvName
            // 
            this.dgvName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvName.Location = new System.Drawing.Point(12, 19);
            this.dgvName.Name = "dgvName";
            this.dgvName.RowHeadersWidth = 51;
            this.dgvName.RowTemplate.Height = 24;
            this.dgvName.Size = new System.Drawing.Size(978, 166);
            this.dgvName.TabIndex = 1;
            this.dgvName.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvName_CellContentClick);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(30, 280);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(30, 332);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(28, 16);
            this.lblRol.TabIndex = 3;
            this.lblRol.Text = "Rol";
            this.lblRol.Click += new System.EventHandler(this.lblRol_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(208, 232);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(216, 22);
            this.txt_Nombre.TabIndex = 5;
            this.txt_Nombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(208, 274);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(216, 22);
            this.txt_Password.TabIndex = 6;
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(208, 326);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(216, 22);
            this.txtRol.TabIndex = 7;
            this.txtRol.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizarUsuario.Location = new System.Drawing.Point(76, 428);
            this.btnActualizarUsuario.Name = "btnActualizar";
            this.btnActualizarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarUsuario.TabIndex = 8;
            this.btnActualizarUsuario.Text = "Actualizar";
            this.btnActualizarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevoUsuario.Location = new System.Drawing.Point(208, 428);
            this.btnNuevoUsuario.Name = "btnNuevo";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoUsuario.TabIndex = 9;
            this.btnNuevoUsuario.Text = "Nuevo";
            this.btnNuevoUsuario.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelarUsuario.Location = new System.Drawing.Point(338, 428);
            this.btnCancelarUsuario.Name = "btnCancelar";
            this.btnCancelarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarUsuario.TabIndex = 10;
            this.btnCancelarUsuario.Text = "Cancelar";
            this.btnCancelarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardarUsuario.Location = new System.Drawing.Point(473, 428);
            this.btnGuardarUsuario.Name = "btnGuardar";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarUsuario.TabIndex = 11;
            this.btnGuardarUsuario.Text = "Guardar";
            this.btnGuardarUsuario.UseVisualStyleBackColor = true;
            // 
            // lblNombreTarifa
            // 
            this.lblNombreTarifa.AutoSize = true;
            this.lblNombreTarifa.Location = new System.Drawing.Point(44, 345);
            this.lblNombreTarifa.Name = "lblNombreTarifa";
            this.lblNombreTarifa.Size = new System.Drawing.Size(65, 20);
            this.lblNombreTarifa.TabIndex = 0;
            this.lblNombreTarifa.Text = "Nombre";
            // 
            // dgvConfiguracion
            // 
            this.dgvConfiguracion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfiguracion.Location = new System.Drawing.Point(0, 4);
            this.dgvConfiguracion.Name = "dgvConfiguracion";
            this.dgvConfiguracion.RowHeadersWidth = 62;
            this.dgvConfiguracion.RowTemplate.Height = 28;
            this.dgvConfiguracion.Size = new System.Drawing.Size(1135, 306);
            this.dgvConfiguracion.TabIndex = 1;
            this.dgvConfiguracion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConfiguracion_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(588, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Monto mensual:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(132, 342);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(310, 26);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMonto_mensual
            // 
            this.txtMonto_mensual.Location = new System.Drawing.Point(741, 344);
            this.txtMonto_mensual.Name = "txtMonto_mensual";
            this.txtMonto_mensual.Size = new System.Drawing.Size(325, 26);
            this.txtMonto_mensual.TabIndex = 4;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(10, 495);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(107, 38);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(128, 495);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(112, 38);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(252, 495);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 37);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(997, 495);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(121, 36);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbcConfiguracion);
            this.Controls.Add(this.lblConfiguracion);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Configuracion";
            this.Size = new System.Drawing.Size(1027, 624);
            this.Size = new System.Drawing.Size(1155, 780);
            this.tbcConfiguracion.ResumeLayout(false);
            this.tbpUsuarios.ResumeLayout(false);
            this.tbpUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvName)).EndInit();
            this.tbTarifas.ResumeLayout(false);
            this.tbTarifas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfiguracion)).EndInit();
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
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnActualizarUsuario;
        private System.Windows.Forms.TextBox txtMonto_mensual;
        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.Button btnCancelarUsuario;
        private System.Windows.Forms.Button btnGuardarUsuario;
    }
}
