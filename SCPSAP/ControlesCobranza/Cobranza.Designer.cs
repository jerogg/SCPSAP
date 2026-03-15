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
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.txbTotalPagar = new System.Windows.Forms.TextBox();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.cbxMetodoPago = new System.Windows.Forms.ComboBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.tbCobranza = new System.Windows.Forms.TabControl();
            this.tbPageCobranza = new System.Windows.Forms.TabPage();
            this.tbPageConfiguraAdeudos = new System.Windows.Forms.TabPage();
            this.lblAdeudos = new System.Windows.Forms.Label();
            this.dgvAdeudosConfigurados = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.tbCobranza.SuspendLayout();
            this.tbPageCobranza.SuspendLayout();
            this.tbPageConfiguraAdeudos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdeudosConfigurados)).BeginInit();
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
            this.btnPagar.Location = new System.Drawing.Point(559, 450);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(72, 23);
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
            // tbPageConfiguraAdeudos
            // 
            this.tbPageConfiguraAdeudos.Controls.Add(this.dgvAdeudosConfigurados);
            this.tbPageConfiguraAdeudos.Controls.Add(this.lblAdeudos);
            this.tbPageConfiguraAdeudos.Location = new System.Drawing.Point(4, 22);
            this.tbPageConfiguraAdeudos.Name = "tbPageConfiguraAdeudos";
            this.tbPageConfiguraAdeudos.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageConfiguraAdeudos.Size = new System.Drawing.Size(647, 484);
            this.tbPageConfiguraAdeudos.TabIndex = 1;
            this.tbPageConfiguraAdeudos.Text = "Configura adeudos";
            this.tbPageConfiguraAdeudos.UseVisualStyleBackColor = true;
            // 
            // lblAdeudos
            // 
            this.lblAdeudos.AutoSize = true;
            this.lblAdeudos.Location = new System.Drawing.Point(11, 18);
            this.lblAdeudos.Name = "lblAdeudos";
            this.lblAdeudos.Size = new System.Drawing.Size(149, 13);
            this.lblAdeudos.TabIndex = 1;
            this.lblAdeudos.Text = "ADEUDOS CONFIGURADOS";
            // 
            // dgvAdeudosConfigurados
            // 
            this.dgvAdeudosConfigurados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdeudosConfigurados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdeudosConfigurados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdeudosConfigurados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewCheckBoxColumn1});
            this.dgvAdeudosConfigurados.Location = new System.Drawing.Point(14, 44);
            this.dgvAdeudosConfigurados.Name = "dgvAdeudosConfigurados";
            this.dgvAdeudosConfigurados.Size = new System.Drawing.Size(618, 283);
            this.dgvAdeudosConfigurados.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdAdeudo";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdAdeudo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DetallePagoes";
            this.dataGridViewTextBoxColumn2.HeaderText = "DetallePagoes";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdContribuyente";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdContribuyente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Contribuyente";
            this.dataGridViewTextBoxColumn4.HeaderText = "Contribuyente";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Periodo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Periodo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Concepto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Concepto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MontoOriginal";
            this.dataGridViewTextBoxColumn7.HeaderText = "MontoOriginal";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Recargo";
            this.dataGridViewTextBoxColumn8.HeaderText = "Recargo";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "OtrosCargos";
            this.dataGridViewTextBoxColumn9.HeaderText = "OtrosCargos";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "TotalAdeudo";
            this.dataGridViewTextBoxColumn10.HeaderText = "Adeudo";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn11.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "FechaGeneracion";
            this.dataGridViewTextBoxColumn12.HeaderText = "Fecha de generacion";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "FechaVencimiento";
            this.dataGridViewTextBoxColumn13.HeaderText = "Fecha de vencimiento";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Pagar";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // IdAdeudoContribuyente
            // 
            this.IdAdeudoContribuyente.DataPropertyName = "IdAdeudoContribuyente";
            this.IdAdeudoContribuyente.HeaderText = "IdAdeudoContribuyente";
            this.IdAdeudoContribuyente.Name = "IdAdeudoContribuyente";
            this.IdAdeudoContribuyente.Visible = false;
            // 
            // DetallePagoes
            // 
            this.DetallePagoes.DataPropertyName = "DetallePagoes";
            this.DetallePagoes.HeaderText = "DetallePagoes";
            this.DetallePagoes.Name = "DetallePagoes";
            this.DetallePagoes.Visible = false;
            // 
            // IdContribuyente
            // 
            this.IdContribuyente.DataPropertyName = "IdContribuyente";
            this.IdContribuyente.HeaderText = "IdContribuyente";
            this.IdContribuyente.Name = "IdContribuyente";
            this.IdContribuyente.Visible = false;
            // 
            // IdAdeudo
            // 
            this.IdAdeudo.DataPropertyName = "IdAdeudo";
            this.IdAdeudo.HeaderText = "IdAdeudo";
            this.IdAdeudo.Name = "IdAdeudo";
            this.IdAdeudo.Visible = false;
            // 
            // Contribuyente
            // 
            this.Contribuyente.DataPropertyName = "Contribuyente";
            this.Contribuyente.HeaderText = "Contribuyente";
            this.Contribuyente.Name = "Contribuyente";
            this.Contribuyente.Visible = false;
            // 
            // Periodo
            // 
            this.Periodo.DataPropertyName = "Periodo";
            this.Periodo.HeaderText = "Periodo";
            this.Periodo.Name = "Periodo";
            // 
            // Concepto
            // 
            this.Concepto.DataPropertyName = "Concepto";
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            // 
            // MontoOriginal
            // 
            this.MontoOriginal.DataPropertyName = "MontoOriginal";
            this.MontoOriginal.HeaderText = "MontoOriginal";
            this.MontoOriginal.Name = "MontoOriginal";
            this.MontoOriginal.Visible = false;
            // 
            // Recargo
            // 
            this.Recargo.DataPropertyName = "Recargo";
            this.Recargo.HeaderText = "Recargo";
            this.Recargo.Name = "Recargo";
            this.Recargo.Visible = false;
            // 
            // OtrosCargos
            // 
            this.OtrosCargos.DataPropertyName = "OtrosCargos";
            this.OtrosCargos.HeaderText = "OtrosCargos";
            this.OtrosCargos.Name = "OtrosCargos";
            this.OtrosCargos.Visible = false;
            // 
            // TotalAdeudo
            // 
            this.TotalAdeudo.DataPropertyName = "TotalAdeudo";
            this.TotalAdeudo.HeaderText = "Adeudo";
            this.TotalAdeudo.Name = "TotalAdeudo";
            // 
            // AdeudoObject
            // 
            this.AdeudoObject.DataPropertyName = "Adeudo";
            this.AdeudoObject.HeaderText = "AdeudoObject";
            this.AdeudoObject.Name = "AdeudoObject";
            this.AdeudoObject.Visible = false;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // FechaGeneracion
            // 
            this.FechaGeneracion.DataPropertyName = "FechaGeneracion";
            this.FechaGeneracion.HeaderText = "Fecha de generacion";
            this.FechaGeneracion.Name = "FechaGeneracion";
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.DataPropertyName = "FechaVencimiento";
            this.FechaVencimiento.HeaderText = "Fecha de vencimiento";
            this.FechaVencimiento.Name = "FechaVencimiento";
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
            this.Controls.Add(this.tbCobranza);
            this.Name = "Cobranza";
            this.Size = new System.Drawing.Size(655, 510);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdeudosPorContribuyente)).EndInit();
            this.tbCobranza.ResumeLayout(false);
            this.tbPageCobranza.ResumeLayout(false);
            this.tbPageCobranza.PerformLayout();
            this.tbPageConfiguraAdeudos.ResumeLayout(false);
            this.tbPageConfiguraAdeudos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdeudosConfigurados)).EndInit();
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
        private System.Windows.Forms.Label lblAdeudos;
        private System.Windows.Forms.DataGridView dgvAdeudosConfigurados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
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
