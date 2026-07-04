namespace SCPSAP.ControlesInventario
{
    partial class EntradasSalidas
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
            this.cbxMaterial = new System.Windows.Forms.ComboBox();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblExistencias = new System.Windows.Forms.Label();
            this.cbxTipoMovimiento = new System.Windows.Forms.ComboBox();
            this.lblTipoMovimiento = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txbObservaciones = new System.Windows.Forms.TextBox();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txbExistencias = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbxMaterial
            // 
            this.cbxMaterial.FormattingEnabled = true;
            this.cbxMaterial.Location = new System.Drawing.Point(69, 17);
            this.cbxMaterial.Name = "cbxMaterial";
            this.cbxMaterial.Size = new System.Drawing.Size(165, 21);
            this.cbxMaterial.TabIndex = 18;
            this.cbxMaterial.SelectedIndexChanged += new System.EventHandler(this.cbxMaterial_SelectedIndexChanged);
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(19, 21);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(47, 13);
            this.lblMaterial.TabIndex = 17;
            this.lblMaterial.Text = "Material:";
            // 
            // lblExistencias
            // 
            this.lblExistencias.AutoSize = true;
            this.lblExistencias.Location = new System.Drawing.Point(3, 64);
            this.lblExistencias.Name = "lblExistencias";
            this.lblExistencias.Size = new System.Drawing.Size(63, 13);
            this.lblExistencias.TabIndex = 19;
            this.lblExistencias.Text = "Existencias:";
            // 
            // cbxTipoMovimiento
            // 
            this.cbxTipoMovimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTipoMovimiento.Enabled = false;
            this.cbxTipoMovimiento.FormattingEnabled = true;
            this.cbxTipoMovimiento.Items.AddRange(new object[] {
            "Entrada",
            "Salida"});
            this.cbxTipoMovimiento.Location = new System.Drawing.Point(432, 18);
            this.cbxTipoMovimiento.Name = "cbxTipoMovimiento";
            this.cbxTipoMovimiento.Size = new System.Drawing.Size(165, 21);
            this.cbxTipoMovimiento.TabIndex = 22;
            // 
            // lblTipoMovimiento
            // 
            this.lblTipoMovimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoMovimiento.AutoSize = true;
            this.lblTipoMovimiento.Location = new System.Drawing.Point(327, 22);
            this.lblTipoMovimiento.Name = "lblTipoMovimiento";
            this.lblTipoMovimiento.Size = new System.Drawing.Size(102, 13);
            this.lblTipoMovimiento.TabIndex = 21;
            this.lblTipoMovimiento.Text = "Tipo de movimiento:";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(6, 111);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(81, 13);
            this.lblObservaciones.TabIndex = 23;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // txbObservaciones
            // 
            this.txbObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbObservaciones.Location = new System.Drawing.Point(0, 129);
            this.txbObservaciones.Multiline = true;
            this.txbObservaciones.Name = "txbObservaciones";
            this.txbObservaciones.Size = new System.Drawing.Size(598, 61);
            this.txbObservaciones.TabIndex = 24;
            // 
            // txbCantidad
            // 
            this.txbCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCantidad.Location = new System.Drawing.Point(432, 57);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(165, 20);
            this.txbCantidad.TabIndex = 26;
            this.txbCantidad.TextChanged += new System.EventHandler(this.txbCantidad_TextChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(377, 61);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 25;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(520, 207);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 25);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txbExistencias
            // 
            this.txbExistencias.Enabled = false;
            this.txbExistencias.Location = new System.Drawing.Point(69, 58);
            this.txbExistencias.Name = "txbExistencias";
            this.txbExistencias.Size = new System.Drawing.Size(165, 20);
            this.txbExistencias.TabIndex = 28;
            // 
            // EntradasSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txbExistencias);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txbCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txbObservaciones);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.cbxTipoMovimiento);
            this.Controls.Add(this.lblTipoMovimiento);
            this.Controls.Add(this.lblExistencias);
            this.Controls.Add(this.cbxMaterial);
            this.Controls.Add(this.lblMaterial);
            this.Name = "EntradasSalidas";
            this.Size = new System.Drawing.Size(598, 235);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxMaterial;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblExistencias;
        private System.Windows.Forms.ComboBox cbxTipoMovimiento;
        private System.Windows.Forms.Label lblTipoMovimiento;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txbObservaciones;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txbExistencias;
    }
}
