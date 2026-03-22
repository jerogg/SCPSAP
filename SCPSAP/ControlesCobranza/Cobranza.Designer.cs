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
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txbFolio = new System.Windows.Forms.TextBox();
            this.lblFolio = new System.Windows.Forms.Label();
            this.lblBuscarContribuyente = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.txbName = new System.Windows.Forms.TextBox();
            this.cbxMetodoPago = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.lblAdeudosPendientes = new System.Windows.Forms.Label();
            this.txbTotalPagar = new System.Windows.Forms.TextBox();
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.dgvAdeudosPorContribuyente = new System.Windows.Forms.DataGridView();
            this.IdAdeudoContribuyente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetallePagoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdContribuyente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAdeudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contribuyente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtrosCargos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAdeudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdeudoObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaGeneracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdeudosPorContribuyente)).BeginInit();
            this.SuspendLayout();
            // 
            // txbDireccion
            // 
            this.txbDireccion.Enabled = false;
            this.txbDireccion.Location = new System.Drawing.Point(404, 38);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(198, 20);
            this.txbDireccion.TabIndex = 27;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(346, 41);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 26;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txbFolio
            // 
            this.txbFolio.Enabled = false;
            this.txbFolio.Location = new System.Drawing.Point(270, 39);
            this.txbFolio.Name = "txbFolio";
            this.txbFolio.Size = new System.Drawing.Size(63, 20);
            this.txbFolio.TabIndex = 25;
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Location = new System.Drawing.Point(234, 42);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(32, 13);
            this.lblFolio.TabIndex = 24;
            this.lblFolio.Text = "Folio:";
            // 
            // lblBuscarContribuyente
            // 
            this.lblBuscarContribuyente.AutoSize = true;
            this.lblBuscarContribuyente.Location = new System.Drawing.Point(10, 15);
            this.lblBuscarContribuyente.Name = "lblBuscarContribuyente";
            this.lblBuscarContribuyente.Size = new System.Drawing.Size(146, 13);
            this.lblBuscarContribuyente.TabIndex = 14;
            this.lblBuscarContribuyente.Text = "BUSCAR CONTRIBUYENTE";
            // 
            // btnPagar
            // 
            this.btnPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPagar.Location = new System.Drawing.Point(567, 454);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(72, 25);
            this.btnPagar.TabIndex = 23;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(60, 38);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(161, 20);
            this.txbName.TabIndex = 16;
            // 
            // cbxMetodoPago
            // 
            this.cbxMetodoPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxMetodoPago.FormattingEnabled = true;
            this.cbxMetodoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Transferencia",
            "Tarjeta"});
            this.cbxMetodoPago.Location = new System.Drawing.Point(106, 448);
            this.cbxMetodoPago.Name = "cbxMetodoPago";
            this.cbxMetodoPago.Size = new System.Drawing.Size(161, 21);
            this.cbxMetodoPago.TabIndex = 22;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(10, 42);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Location = new System.Drawing.Point(56, 451);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(46, 13);
            this.lblMetodoPago.TabIndex = 21;
            this.lblMetodoPago.Text = "Método:";
            // 
            // lblAdeudosPendientes
            // 
            this.lblAdeudosPendientes.AutoSize = true;
            this.lblAdeudosPendientes.Location = new System.Drawing.Point(11, 83);
            this.lblAdeudosPendientes.Name = "lblAdeudosPendientes";
            this.lblAdeudosPendientes.Size = new System.Drawing.Size(132, 13);
            this.lblAdeudosPendientes.TabIndex = 17;
            this.lblAdeudosPendientes.Text = "ADEUDOS PENDIENTES";
            // 
            // txbTotalPagar
            // 
            this.txbTotalPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbTotalPagar.Enabled = false;
            this.txbTotalPagar.Location = new System.Drawing.Point(106, 412);
            this.txbTotalPagar.Name = "txbTotalPagar";
            this.txbTotalPagar.Size = new System.Drawing.Size(161, 20);
            this.txbTotalPagar.TabIndex = 20;
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalAPagar.AutoSize = true;
            this.lblTotalAPagar.Location = new System.Drawing.Point(8, 416);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(95, 13);
            this.lblTotalAPagar.TabIndex = 19;
            this.lblTotalAPagar.Text = "TOTAL A PAGAR:";
            // 
            // dgvAdeudosPorContribuyente
            // 
            this.dgvAdeudosPorContribuyente.AllowUserToAddRows = false;
            this.dgvAdeudosPorContribuyente.AllowUserToDeleteRows = false;
            this.dgvAdeudosPorContribuyente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdeudosPorContribuyente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdeudosPorContribuyente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdeudosPorContribuyente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAdeudoContribuyente,
            this.DetallePagoes,
            this.IdContribuyente,
            this.IdAdeudo,
            this.Contribuyente,
            this.Periodo,
            this.Concepto,
            this.MontoOriginal,
            this.Recargo,
            this.OtrosCargos,
            this.TotalAdeudo,
            this.AdeudoObject,
            this.Estado,
            this.FechaGeneracion,
            this.FechaVencimiento,
            this.Pagar});
            this.dgvAdeudosPorContribuyente.Location = new System.Drawing.Point(13, 102);
            this.dgvAdeudosPorContribuyente.Name = "dgvAdeudosPorContribuyente";
            this.dgvAdeudosPorContribuyente.Size = new System.Drawing.Size(618, 293);
            this.dgvAdeudosPorContribuyente.TabIndex = 18;
            // 
            // IdAdeudoContribuyente
            // 
            this.IdAdeudoContribuyente.DataPropertyName = "IdAdeudoContribuyente";
            this.IdAdeudoContribuyente.HeaderText = "IdAdeudoContribuyente";
            this.IdAdeudoContribuyente.Name = "IdAdeudoContribuyente";
            this.IdAdeudoContribuyente.ReadOnly = true;
            this.IdAdeudoContribuyente.Visible = false;
            // 
            // DetallePagoes
            // 
            this.DetallePagoes.DataPropertyName = "DetallePagoes";
            this.DetallePagoes.HeaderText = "DetallePagoes";
            this.DetallePagoes.Name = "DetallePagoes";
            this.DetallePagoes.ReadOnly = true;
            this.DetallePagoes.Visible = false;
            // 
            // IdContribuyente
            // 
            this.IdContribuyente.DataPropertyName = "IdContribuyente";
            this.IdContribuyente.HeaderText = "IdContribuyente";
            this.IdContribuyente.Name = "IdContribuyente";
            this.IdContribuyente.ReadOnly = true;
            this.IdContribuyente.Visible = false;
            // 
            // IdAdeudo
            // 
            this.IdAdeudo.DataPropertyName = "IdAdeudo";
            this.IdAdeudo.HeaderText = "IdAdeudo";
            this.IdAdeudo.Name = "IdAdeudo";
            this.IdAdeudo.ReadOnly = true;
            this.IdAdeudo.Visible = false;
            // 
            // Contribuyente
            // 
            this.Contribuyente.DataPropertyName = "Contribuyente";
            this.Contribuyente.HeaderText = "Contribuyente";
            this.Contribuyente.Name = "Contribuyente";
            this.Contribuyente.ReadOnly = true;
            this.Contribuyente.Visible = false;
            // 
            // Periodo
            // 
            this.Periodo.DataPropertyName = "Periodo";
            this.Periodo.HeaderText = "Periodo";
            this.Periodo.Name = "Periodo";
            this.Periodo.ReadOnly = true;
            // 
            // Concepto
            // 
            this.Concepto.DataPropertyName = "Concepto";
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            // 
            // MontoOriginal
            // 
            this.MontoOriginal.DataPropertyName = "MontoOriginal";
            this.MontoOriginal.HeaderText = "MontoOriginal";
            this.MontoOriginal.Name = "MontoOriginal";
            this.MontoOriginal.ReadOnly = true;
            this.MontoOriginal.Visible = false;
            // 
            // Recargo
            // 
            this.Recargo.DataPropertyName = "Recargo";
            this.Recargo.HeaderText = "Recargo";
            this.Recargo.Name = "Recargo";
            this.Recargo.ReadOnly = true;
            this.Recargo.Visible = false;
            // 
            // OtrosCargos
            // 
            this.OtrosCargos.DataPropertyName = "OtrosCargos";
            this.OtrosCargos.HeaderText = "OtrosCargos";
            this.OtrosCargos.Name = "OtrosCargos";
            this.OtrosCargos.ReadOnly = true;
            this.OtrosCargos.Visible = false;
            // 
            // TotalAdeudo
            // 
            this.TotalAdeudo.DataPropertyName = "TotalAdeudo";
            this.TotalAdeudo.HeaderText = "Adeudo";
            this.TotalAdeudo.Name = "TotalAdeudo";
            this.TotalAdeudo.ReadOnly = true;
            // 
            // AdeudoObject
            // 
            this.AdeudoObject.DataPropertyName = "Adeudo";
            this.AdeudoObject.HeaderText = "AdeudoObject";
            this.AdeudoObject.Name = "AdeudoObject";
            this.AdeudoObject.ReadOnly = true;
            this.AdeudoObject.Visible = false;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // FechaGeneracion
            // 
            this.FechaGeneracion.DataPropertyName = "FechaGeneracion";
            this.FechaGeneracion.HeaderText = "Fecha de generacion";
            this.FechaGeneracion.Name = "FechaGeneracion";
            this.FechaGeneracion.ReadOnly = true;
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.DataPropertyName = "FechaVencimiento";
            this.FechaVencimiento.HeaderText = "Fecha de vencimiento";
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.ReadOnly = true;
            // 
            // Pagar
            // 
            this.Pagar.HeaderText = "Pagar";
            this.Pagar.Name = "Pagar";
            // 
            // Cobranza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txbDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txbFolio);
            this.Controls.Add(this.lblFolio);
            this.Controls.Add(this.lblBuscarContribuyente);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.cbxMetodoPago);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblMetodoPago);
            this.Controls.Add(this.lblAdeudosPendientes);
            this.Controls.Add(this.txbTotalPagar);
            this.Controls.Add(this.lblTotalAPagar);
            this.Controls.Add(this.dgvAdeudosPorContribuyente);
            this.Name = "Cobranza";
            this.Size = new System.Drawing.Size(647, 484);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdeudosPorContribuyente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txbFolio;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.Label lblBuscarContribuyente;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.ComboBox cbxMetodoPago;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.Label lblAdeudosPendientes;
        private System.Windows.Forms.TextBox txbTotalPagar;
        private System.Windows.Forms.Label lblTotalAPagar;
        private System.Windows.Forms.DataGridView dgvAdeudosPorContribuyente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAdeudoContribuyente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetallePagoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdContribuyente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAdeudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contribuyente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoOriginal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtrosCargos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAdeudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdeudoObject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaGeneracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimiento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Pagar;
    }
}
