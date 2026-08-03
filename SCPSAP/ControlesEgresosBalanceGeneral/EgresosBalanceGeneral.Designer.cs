namespace SCPSAP.ControlesEgresosIngresos
{
    partial class EgresosBalanceGeneral
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
            this.tbcEgresosBalanceGeneral = new System.Windows.Forms.TabControl();
            this.tbEgresos = new System.Windows.Forms.TabPage();
            this.pnlEgresos = new System.Windows.Forms.Panel();
            this.tbpBalanceGeneral = new System.Windows.Forms.TabPage();
            this.pnlEgresosBalanceGeneral = new System.Windows.Forms.Panel();
            this.tbcEgresosBalanceGeneral.SuspendLayout();
            this.tbEgresos.SuspendLayout();
            this.tbpBalanceGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConfiguracion
            // 
            this.lblConfiguracion.AutoSize = true;
            this.lblConfiguracion.Location = new System.Drawing.Point(13, 9);
            this.lblConfiguracion.Name = "lblConfiguracion";
            this.lblConfiguracion.Size = new System.Drawing.Size(171, 13);
            this.lblConfiguracion.TabIndex = 3;
            this.lblConfiguracion.Text = "INGRESOS/BALANCE GENERAL";
            // 
            // tbcEgresosBalanceGeneral
            // 
            this.tbcEgresosBalanceGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcEgresosBalanceGeneral.Controls.Add(this.tbEgresos);
            this.tbcEgresosBalanceGeneral.Controls.Add(this.tbpBalanceGeneral);
            this.tbcEgresosBalanceGeneral.Location = new System.Drawing.Point(3, 28);
            this.tbcEgresosBalanceGeneral.Name = "tbcEgresosBalanceGeneral";
            this.tbcEgresosBalanceGeneral.SelectedIndex = 0;
            this.tbcEgresosBalanceGeneral.Size = new System.Drawing.Size(592, 380);
            this.tbcEgresosBalanceGeneral.TabIndex = 4;
            // 
            // tbEgresos
            // 
            this.tbEgresos.Controls.Add(this.pnlEgresos);
            this.tbEgresos.Location = new System.Drawing.Point(4, 22);
            this.tbEgresos.Name = "tbEgresos";
            this.tbEgresos.Padding = new System.Windows.Forms.Padding(3);
            this.tbEgresos.Size = new System.Drawing.Size(584, 354);
            this.tbEgresos.TabIndex = 0;
            this.tbEgresos.Text = "Egresos";
            this.tbEgresos.UseVisualStyleBackColor = true;
            // 
            // pnlEgresos
            // 
            this.pnlEgresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEgresos.Location = new System.Drawing.Point(3, 3);
            this.pnlEgresos.Name = "pnlEgresos";
            this.pnlEgresos.Size = new System.Drawing.Size(578, 348);
            this.pnlEgresos.TabIndex = 0;
            // 
            // tbpBalanceGeneral
            // 
            this.tbpBalanceGeneral.Controls.Add(this.pnlEgresosBalanceGeneral);
            this.tbpBalanceGeneral.Location = new System.Drawing.Point(4, 22);
            this.tbpBalanceGeneral.Name = "tbpBalanceGeneral";
            this.tbpBalanceGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBalanceGeneral.Size = new System.Drawing.Size(584, 354);
            this.tbpBalanceGeneral.TabIndex = 1;
            this.tbpBalanceGeneral.Text = "Balance general";
            this.tbpBalanceGeneral.UseVisualStyleBackColor = true;
            // 
            // pnlEgresosBalanceGeneral
            // 
            this.pnlEgresosBalanceGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEgresosBalanceGeneral.Location = new System.Drawing.Point(3, 3);
            this.pnlEgresosBalanceGeneral.Name = "pnlEgresosBalanceGeneral";
            this.pnlEgresosBalanceGeneral.Size = new System.Drawing.Size(578, 348);
            this.pnlEgresosBalanceGeneral.TabIndex = 0;
            // 
            // EgresosBalanceGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbcEgresosBalanceGeneral);
            this.Controls.Add(this.lblConfiguracion);
            this.Name = "EgresosBalanceGeneral";
            this.Size = new System.Drawing.Size(598, 421);
            this.tbcEgresosBalanceGeneral.ResumeLayout(false);
            this.tbEgresos.ResumeLayout(false);
            this.tbpBalanceGeneral.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfiguracion;
        private System.Windows.Forms.TabControl tbcEgresosBalanceGeneral;
        private System.Windows.Forms.TabPage tbEgresos;
        private System.Windows.Forms.Panel pnlEgresos;
        private System.Windows.Forms.TabPage tbpBalanceGeneral;
        private System.Windows.Forms.Panel pnlEgresosBalanceGeneral;
    }
}
