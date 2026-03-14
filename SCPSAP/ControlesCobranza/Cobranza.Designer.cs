namespace SCPSAP.ControlesCobranza
{
    partial class Cobranza
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
            this.lblBuscarContribuyente = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblAdeudosPendientes = new System.Windows.Forms.Label();
            this.dgvAdeudos = new System.Windows.Forms.DataGridView();
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.txbTotalPagar = new System.Windows.Forms.TextBox();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.cbxMetodoPago = new System.Windows.Forms.ComboBox();
            this.btnPagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdeudos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscarContribuyente
            // 
            this.lblBuscarContribuyente.AutoSize = true;
            this.lblBuscarContribuyente.Location = new System.Drawing.Point(16, 14);
            this.lblBuscarContribuyente.Name = "lblBuscarContribuyente";
            this.lblBuscarContribuyente.Size = new System.Drawing.Size(146, 13);
            this.lblBuscarContribuyente.TabIndex = 0;
            this.lblBuscarContribuyente.Text = "BUSCAR CONTRIBUYENTE";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(71, 46);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(161, 20);
            this.txbName.TabIndex = 2;
            // 
            // lblAdeudosPendientes
            // 
            this.lblAdeudosPendientes.AutoSize = true;
            this.lblAdeudosPendientes.Location = new System.Drawing.Point(16, 95);
            this.lblAdeudosPendientes.Name = "lblAdeudosPendientes";
            this.lblAdeudosPendientes.Size = new System.Drawing.Size(132, 13);
            this.lblAdeudosPendientes.TabIndex = 3;
            this.lblAdeudosPendientes.Text = "ADEUDOS PENDIENTES";
            // 
            // dgvAdeudos
            // 
            this.dgvAdeudos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdeudos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdeudos.Location = new System.Drawing.Point(19, 131);
            this.dgvAdeudos.Name = "dgvAdeudos";
            this.dgvAdeudos.Size = new System.Drawing.Size(615, 218);
            this.dgvAdeudos.TabIndex = 4;
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalAPagar.AutoSize = true;
            this.lblTotalAPagar.Location = new System.Drawing.Point(16, 375);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(95, 13);
            this.lblTotalAPagar.TabIndex = 5;
            this.lblTotalAPagar.Text = "TOTAL A PAGAR:";
            // 
            // txbTotalPagar
            // 
            this.txbTotalPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbTotalPagar.Enabled = false;
            this.txbTotalPagar.Location = new System.Drawing.Point(114, 371);
            this.txbTotalPagar.Name = "txbTotalPagar";
            this.txbTotalPagar.Size = new System.Drawing.Size(161, 20);
            this.txbTotalPagar.TabIndex = 6;
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Location = new System.Drawing.Point(64, 410);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(46, 13);
            this.lblMetodoPago.TabIndex = 7;
            this.lblMetodoPago.Text = "Método:";
            // 
            // cbxMetodoPago
            // 
            this.cbxMetodoPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxMetodoPago.FormattingEnabled = true;
            this.cbxMetodoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Transferencia",
            "Tarjeta"});
            this.cbxMetodoPago.Location = new System.Drawing.Point(114, 407);
            this.cbxMetodoPago.Name = "cbxMetodoPago";
            this.cbxMetodoPago.Size = new System.Drawing.Size(161, 21);
            this.cbxMetodoPago.TabIndex = 8;
            // 
            // btnPagar
            // 
            this.btnPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPagar.Location = new System.Drawing.Point(562, 475);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(72, 23);
            this.btnPagar.TabIndex = 9;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // Cobranza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.cbxMetodoPago);
            this.Controls.Add(this.lblMetodoPago);
            this.Controls.Add(this.txbTotalPagar);
            this.Controls.Add(this.lblTotalAPagar);
            this.Controls.Add(this.dgvAdeudos);
            this.Controls.Add(this.lblAdeudosPendientes);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblBuscarContribuyente);
            this.Name = "Cobranza";
            this.Size = new System.Drawing.Size(655, 510);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdeudos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarContribuyente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblAdeudosPendientes;
        private System.Windows.Forms.DataGridView dgvAdeudos;
        private System.Windows.Forms.Label lblTotalAPagar;
        private System.Windows.Forms.TextBox txbTotalPagar;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.ComboBox cbxMetodoPago;
        private System.Windows.Forms.Button btnPagar;
    }
}
