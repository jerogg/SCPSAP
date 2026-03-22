namespace SCPSAP.ControlesCobranza
{
    partial class CobranzaPrincipal
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
            this.tbCobranza = new System.Windows.Forms.TabControl();
            this.tbPageCobranza = new System.Windows.Forms.TabPage();
            this.tbPageConfiguraAdeudos = new System.Windows.Forms.TabPage();
            this.pnlConfigurarAdeudos = new System.Windows.Forms.Panel();
            this.pnlCobranza = new System.Windows.Forms.Panel();
            this.tbCobranza.SuspendLayout();
            this.tbPageCobranza.SuspendLayout();
            this.tbPageConfiguraAdeudos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCobranza
            // 
            this.tbCobranza.Controls.Add(this.tbPageCobranza);
            this.tbCobranza.Controls.Add(this.tbPageConfiguraAdeudos);
            this.tbCobranza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCobranza.Location = new System.Drawing.Point(0, 0);
            this.tbCobranza.Name = "tbCobranza";
            this.tbCobranza.SelectedIndex = 0;
            this.tbCobranza.Size = new System.Drawing.Size(655, 510);
            this.tbCobranza.TabIndex = 10;
            // 
            // tbPageCobranza
            // 
            this.tbPageCobranza.Controls.Add(this.pnlCobranza);
            this.tbPageCobranza.Location = new System.Drawing.Point(4, 22);
            this.tbPageCobranza.Name = "tbPageCobranza";
            this.tbPageCobranza.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageCobranza.Size = new System.Drawing.Size(647, 484);
            this.tbPageCobranza.TabIndex = 0;
            this.tbPageCobranza.Text = "Cobranza";
            this.tbPageCobranza.UseVisualStyleBackColor = true;
            // 
            // tbPageConfiguraAdeudos
            // 
            this.tbPageConfiguraAdeudos.Controls.Add(this.pnlConfigurarAdeudos);
            this.tbPageConfiguraAdeudos.Location = new System.Drawing.Point(4, 22);
            this.tbPageConfiguraAdeudos.Name = "tbPageConfiguraAdeudos";
            this.tbPageConfiguraAdeudos.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageConfiguraAdeudos.Size = new System.Drawing.Size(647, 484);
            this.tbPageConfiguraAdeudos.TabIndex = 1;
            this.tbPageConfiguraAdeudos.Text = "Configura adeudos";
            this.tbPageConfiguraAdeudos.UseVisualStyleBackColor = true;
            // 
            // pnlConfigurarAdeudos
            // 
            this.pnlConfigurarAdeudos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConfigurarAdeudos.Location = new System.Drawing.Point(3, 3);
            this.pnlConfigurarAdeudos.Name = "pnlConfigurarAdeudos";
            this.pnlConfigurarAdeudos.Size = new System.Drawing.Size(641, 478);
            this.pnlConfigurarAdeudos.TabIndex = 0;
            // 
            // pnlCobranza
            // 
            this.pnlCobranza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCobranza.Location = new System.Drawing.Point(3, 3);
            this.pnlCobranza.Name = "pnlCobranza";
            this.pnlCobranza.Size = new System.Drawing.Size(641, 478);
            this.pnlCobranza.TabIndex = 1;
            // 
            // CobranzaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbCobranza);
            this.Name = "CobranzaPrincipal";
            this.Size = new System.Drawing.Size(655, 510);
            this.tbCobranza.ResumeLayout(false);
            this.tbPageCobranza.ResumeLayout(false);
            this.tbPageConfiguraAdeudos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tbCobranza;
        private System.Windows.Forms.TabPage tbPageCobranza;
        private System.Windows.Forms.TabPage tbPageConfiguraAdeudos;
        private System.Windows.Forms.Panel pnlConfigurarAdeudos;
        private System.Windows.Forms.Panel pnlCobranza;
    }
}
