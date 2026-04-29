namespace SCPSAP.ControlesInventario
{
    partial class Inventario
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
            this.lblMateriales = new System.Windows.Forms.Label();
            this.tbcMateriales = new System.Windows.Forms.TabControl();
            this.tbMateriales = new System.Windows.Forms.TabPage();
            this.pnlMateriales = new System.Windows.Forms.Panel();
            this.tbpEntradasSalidas = new System.Windows.Forms.TabPage();
            this.pnlEntradasSalidas = new System.Windows.Forms.Panel();
            this.tbcMateriales.SuspendLayout();
            this.tbMateriales.SuspendLayout();
            this.tbpEntradasSalidas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMateriales
            // 
            this.lblMateriales.AutoSize = true;
            this.lblMateriales.Location = new System.Drawing.Point(12, 9);
            this.lblMateriales.Name = "lblMateriales";
            this.lblMateriales.Size = new System.Drawing.Size(75, 13);
            this.lblMateriales.TabIndex = 3;
            this.lblMateriales.Text = "MATERIALES";
            // 
            // tbcMateriales
            // 
            this.tbcMateriales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcMateriales.Controls.Add(this.tbMateriales);
            this.tbcMateriales.Controls.Add(this.tbpEntradasSalidas);
            this.tbcMateriales.Location = new System.Drawing.Point(3, 34);
            this.tbcMateriales.Name = "tbcMateriales";
            this.tbcMateriales.SelectedIndex = 0;
            this.tbcMateriales.Size = new System.Drawing.Size(592, 380);
            this.tbcMateriales.TabIndex = 4;
            // 
            // tbMateriales
            // 
            this.tbMateriales.Controls.Add(this.pnlMateriales);
            this.tbMateriales.Location = new System.Drawing.Point(4, 22);
            this.tbMateriales.Name = "tbMateriales";
            this.tbMateriales.Padding = new System.Windows.Forms.Padding(3);
            this.tbMateriales.Size = new System.Drawing.Size(584, 354);
            this.tbMateriales.TabIndex = 0;
            this.tbMateriales.Text = "Materiales";
            this.tbMateriales.UseVisualStyleBackColor = true;
            // 
            // pnlMateriales
            // 
            this.pnlMateriales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMateriales.Location = new System.Drawing.Point(3, 3);
            this.pnlMateriales.Name = "pnlMateriales";
            this.pnlMateriales.Size = new System.Drawing.Size(578, 348);
            this.pnlMateriales.TabIndex = 0;
            // 
            // tbpEntradasSalidas
            // 
            this.tbpEntradasSalidas.Controls.Add(this.pnlEntradasSalidas);
            this.tbpEntradasSalidas.Location = new System.Drawing.Point(4, 22);
            this.tbpEntradasSalidas.Name = "tbpEntradasSalidas";
            this.tbpEntradasSalidas.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEntradasSalidas.Size = new System.Drawing.Size(584, 354);
            this.tbpEntradasSalidas.TabIndex = 1;
            this.tbpEntradasSalidas.Text = "Entradas/Salidas";
            this.tbpEntradasSalidas.UseVisualStyleBackColor = true;
            // 
            // pnlEntradasSalidas
            // 
            this.pnlEntradasSalidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEntradasSalidas.Location = new System.Drawing.Point(3, 3);
            this.pnlEntradasSalidas.Name = "pnlEntradasSalidas";
            this.pnlEntradasSalidas.Size = new System.Drawing.Size(578, 348);
            this.pnlEntradasSalidas.TabIndex = 0;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbcMateriales);
            this.Controls.Add(this.lblMateriales);
            this.Name = "Inventario";
            this.Size = new System.Drawing.Size(598, 421);
            this.tbcMateriales.ResumeLayout(false);
            this.tbMateriales.ResumeLayout(false);
            this.tbpEntradasSalidas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMateriales;
        private System.Windows.Forms.TabControl tbcMateriales;
        private System.Windows.Forms.TabPage tbMateriales;
        private System.Windows.Forms.Panel pnlMateriales;
        private System.Windows.Forms.TabPage tbpEntradasSalidas;
        private System.Windows.Forms.Panel pnlEntradasSalidas;
    }
}
