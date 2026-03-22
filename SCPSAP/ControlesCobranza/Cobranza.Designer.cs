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
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.txbTotalPagar = new System.Windows.Forms.TextBox();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.cbxMetodoPago = new System.Windows.Forms.ComboBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.tbCobranza = new System.Windows.Forms.TabControl();
            this.tbPageCobranza = new System.Windows.Forms.TabPage();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txbFolio = new System.Windows.Forms.TextBox();
            this.lblFolio = new System.Windows.Forms.Label();
            this.tbPageConfiguraAdeudos = new System.Windows.Forms.TabPage();
            this.pnlConfigurarAdeudos = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdeudosPorContribuyente)).BeginInit();
            this.tbCobranza.SuspendLayout();
            this.tbPageCobranza.SuspendLayout();
            this.tbPageConfiguraAdeudos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBuscarContribuyente
            // 
            this.lblBuscarContribuyente.AutoSize = true;
            this.lblBuscarContribuyente.Location = new System.Drawing.Point(12, 22);
            this.lblBuscarContribuyente.Name = "lblBuscarContribuyente";
            this.lblBuscarContribuyente.Size = new System.Drawing.Size(146, 13);
            this.lblBuscarContribuyente.TabIndex = 0;
            this.lblBuscarContribuyente.Text = "BUSCAR CONTRIBUYENTE";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(62, 45);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(161, 20);
            this.txbName.TabIndex = 2;
            // 
            // lblAdeudosPendientes
            // 
            this.lblAdeudosPendientes.AutoSize = true;
            this.lblAdeudosPendientes.Location = new System.Drawing.Point(13, 90);
            this.lblAdeudosPendientes.Name = "lblAdeudosPendientes";
            this.lblAdeudosPendientes.Size = new System.Drawing.Size(132, 13);
            this.lblAdeudosPendientes.TabIndex = 3;
            this.lblAdeudosPendientes.Text = "ADEUDOS PENDIENTES";
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
            this.dgvAdeudosPorContribuyente.Location = new System.Drawing.Point(15, 109);
            this.dgvAdeudosPorContribuyente.Name = "dgvAdeudosPorContribuyente";
            this.dgvAdeudosPorContribuyente.Size = new System.Drawing.Size(618, 283);
            this.dgvAdeudosPorContribuyente.TabIndex = 4;
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
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalAPagar.AutoSize = true;
            this.lblTotalAPagar.Location = new System.Drawing.Point(10, 414);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(95, 13);
            this.lblTotalAPagar.TabIndex = 5;
            this.lblTotalAPagar.Text = "TOTAL A PAGAR:";
            // 
            // txbTotalPagar
            // 
            this.txbTotalPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbTotalPagar.Enabled = false;
            this.txbTotalPagar.Location = new System.Drawing.Point(108, 410);
            this.txbTotalPagar.Name = "txbTotalPagar";
            this.txbTotalPagar.Size = new System.Drawing.Size(161, 20);
            this.txbTotalPagar.TabIndex = 6;
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Location = new System.Drawing.Point(58, 449);
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
            this.cbxMetodoPago.Location = new System.Drawing.Point(108, 446);
            this.cbxMetodoPago.Name = "cbxMetodoPago";
            this.cbxMetodoPago.Size = new System.Drawing.Size(161, 21);
            this.cbxMetodoPago.TabIndex = 8;
            // 
            // btnPagar
            // 
            this.btnPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPagar.Location = new System.Drawing.Point(569, 452);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(72, 25);
            this.btnPagar.TabIndex = 9;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
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
            this.tbPageCobranza.Controls.Add(this.txbDireccion);
            this.tbPageCobranza.Controls.Add(this.lblDireccion);
            this.tbPageCobranza.Controls.Add(this.txbFolio);
            this.tbPageCobranza.Controls.Add(this.lblFolio);
            this.tbPageCobranza.Controls.Add(this.lblBuscarContribuyente);
            this.tbPageCobranza.Controls.Add(this.btnPagar);
            this.tbPageCobranza.Controls.Add(this.txbName);
            this.tbPageCobranza.Controls.Add(this.cbxMetodoPago);
            this.tbPageCobranza.Controls.Add(this.lblNombre);
            this.tbPageCobranza.Controls.Add(this.lblMetodoPago);
            this.tbPageCobranza.Controls.Add(this.lblAdeudosPendientes);
            this.tbPageCobranza.Controls.Add(this.txbTotalPagar);
            this.tbPageCobranza.Controls.Add(this.lblTotalAPagar);
            this.tbPageCobranza.Controls.Add(this.dgvAdeudosPorContribuyente);
            this.tbPageCobranza.Location = new System.Drawing.Point(4, 22);
            this.tbPageCobranza.Name = "tbPageCobranza";
            this.tbPageCobranza.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageCobranza.Size = new System.Drawing.Size(647, 484);
            this.tbPageCobranza.TabIndex = 0;
            this.tbPageCobranza.Text = "Cobranza";
            this.tbPageCobranza.UseVisualStyleBackColor = true;
            // 
            // txbDireccion
            // 
            this.txbDireccion.Enabled = false;
            this.txbDireccion.Location = new System.Drawing.Point(406, 45);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(198, 20);
            this.txbDireccion.TabIndex = 13;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(348, 48);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 12;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txbFolio
            // 
            this.txbFolio.Enabled = false;
            this.txbFolio.Location = new System.Drawing.Point(272, 46);
            this.txbFolio.Name = "txbFolio";
            this.txbFolio.Size = new System.Drawing.Size(63, 20);
            this.txbFolio.TabIndex = 11;
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Location = new System.Drawing.Point(236, 49);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(32, 13);
            this.lblFolio.TabIndex = 10;
            this.lblFolio.Text = "Folio:";
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
            // Cobranza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbCobranza);
            this.Name = "Cobranza";
            this.Size = new System.Drawing.Size(655, 510);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdeudosPorContribuyente)).EndInit();
            this.tbCobranza.ResumeLayout(false);
            this.tbPageCobranza.ResumeLayout(false);
            this.tbPageCobranza.PerformLayout();
            this.tbPageConfiguraAdeudos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarContribuyente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblAdeudosPendientes;
        private System.Windows.Forms.DataGridView dgvAdeudosPorContribuyente;
        private System.Windows.Forms.Label lblTotalAPagar;
        private System.Windows.Forms.TextBox txbTotalPagar;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.ComboBox cbxMetodoPago;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.TabControl tbCobranza;
        private System.Windows.Forms.TabPage tbPageCobranza;
        private System.Windows.Forms.TabPage tbPageConfiguraAdeudos;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txbFolio;
        private System.Windows.Forms.Label lblFolio;
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
        private System.Windows.Forms.Panel pnlConfigurarAdeudos;
    }
}
