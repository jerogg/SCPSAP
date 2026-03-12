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
            this.tbcConfiguracion.SuspendLayout();
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
            this.tbcConfiguracion.Location = new System.Drawing.Point(3, 37);
            this.tbcConfiguracion.Name = "tbcConfiguracion";
            this.tbcConfiguracion.SelectedIndex = 0;
            this.tbcConfiguracion.Size = new System.Drawing.Size(764, 467);
            this.tbcConfiguracion.TabIndex = 3;
            // 
            // tbTarifas
            // 
            this.tbTarifas.Location = new System.Drawing.Point(4, 22);
            this.tbTarifas.Name = "tbTarifas";
            this.tbTarifas.Padding = new System.Windows.Forms.Padding(3);
            this.tbTarifas.Size = new System.Drawing.Size(756, 441);
            this.tbTarifas.TabIndex = 0;
            this.tbTarifas.Text = "Tarifas";
            this.tbTarifas.UseVisualStyleBackColor = true;
            // 
            // tbpUsuarios
            // 
            this.tbpUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tbpUsuarios.Name = "tbpUsuarios";
            this.tbpUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUsuarios.Size = new System.Drawing.Size(756, 441);
            this.tbpUsuarios.TabIndex = 1;
            this.tbpUsuarios.Text = "Usuarios";
            this.tbpUsuarios.UseVisualStyleBackColor = true;
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbcConfiguracion);
            this.Controls.Add(this.lblConfiguracion);
            this.Name = "Configuracion";
            this.Size = new System.Drawing.Size(770, 507);
            this.tbcConfiguracion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfiguracion;
        private System.Windows.Forms.TabControl tbcConfiguracion;
        private System.Windows.Forms.TabPage tbTarifas;
        private System.Windows.Forms.TabPage tbpUsuarios;
    }
}
