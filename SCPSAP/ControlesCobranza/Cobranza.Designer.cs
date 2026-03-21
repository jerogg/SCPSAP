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
            this.lblFechaLimitePago = new System.Windows.Forms.Label();
            this.dtpFechaLimitePago = new System.Windows.Forms.DateTimePicker();
            this.btnCancelarConfiguracionAdeudo = new System.Windows.Forms.Button();
            this.btnActualizarAdeudo = new System.Windows.Forms.Button();
            this.btnNuevoAdeudo = new System.Windows.Forms.Button();
            this.btnGuardarAdeudo = new System.Windows.Forms.Button();
            this.txbConcepto = new System.Windows.Forms.TextBox();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.txbPeriodo = new System.Windows.Forms.TextBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.dgvAdeudosConfigurados = new System.Windows.Forms.DataGridView();
            this.lblAdeudos = new System.Windows.Forms.Label();
            this.cbxMontoDiferente = new System.Windows.Forms.CheckBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txbMonto = new System.Windows.Forms.TextBox();
            this.IdConfiguracionAdeudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdeudoContribuyentes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConceptoAdeudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimientoAdeudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EliminarAdeudo = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.tbPageConfiguraAdeudos.Controls.Add(this.txbMonto);
            this.tbPageConfiguraAdeudos.Controls.Add(this.lblMonto);
            this.tbPageConfiguraAdeudos.Controls.Add(this.cbxMontoDiferente);
            this.tbPageConfiguraAdeudos.Controls.Add(this.lblFechaLimitePago);
            this.tbPageConfiguraAdeudos.Controls.Add(this.dtpFechaLimitePago);
            this.tbPageConfiguraAdeudos.Controls.Add(this.btnCancelarConfiguracionAdeudo);
            this.tbPageConfiguraAdeudos.Controls.Add(this.btnActualizarAdeudo);
            this.tbPageConfiguraAdeudos.Controls.Add(this.btnNuevoAdeudo);
            this.tbPageConfiguraAdeudos.Controls.Add(this.btnGuardarAdeudo);
            this.tbPageConfiguraAdeudos.Controls.Add(this.txbConcepto);
            this.tbPageConfiguraAdeudos.Controls.Add(this.lblConcepto);
            this.tbPageConfiguraAdeudos.Controls.Add(this.txbPeriodo);
            this.tbPageConfiguraAdeudos.Controls.Add(this.lblPeriodo);
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
            // lblFechaLimitePago
            // 
            this.lblFechaLimitePago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaLimitePago.AutoSize = true;
            this.lblFechaLimitePago.Location = new System.Drawing.Point(321, 363);
            this.lblFechaLimitePago.Name = "lblFechaLimitePago";
            this.lblFechaLimitePago.Size = new System.Drawing.Size(108, 13);
            this.lblFechaLimitePago.TabIndex = 29;
            this.lblFechaLimitePago.Text = "Fecha limite de pago:";
            // 
            // dtpFechaLimitePago
            // 
            this.dtpFechaLimitePago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaLimitePago.Enabled = false;
            this.dtpFechaLimitePago.Location = new System.Drawing.Point(432, 359);
            this.dtpFechaLimitePago.Name = "dtpFechaLimitePago";
            this.dtpFechaLimitePago.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaLimitePago.TabIndex = 28;
            // 
            // btnCancelarConfiguracionAdeudo
            // 
            this.btnCancelarConfiguracionAdeudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelarConfiguracionAdeudo.Enabled = false;
            this.btnCancelarConfiguracionAdeudo.Location = new System.Drawing.Point(169, 452);
            this.btnCancelarConfiguracionAdeudo.Name = "btnCancelarConfiguracionAdeudo";
            this.btnCancelarConfiguracionAdeudo.Size = new System.Drawing.Size(75, 25);
            this.btnCancelarConfiguracionAdeudo.TabIndex = 27;
            this.btnCancelarConfiguracionAdeudo.Text = "Cancelar";
            this.btnCancelarConfiguracionAdeudo.UseVisualStyleBackColor = true;
            this.btnCancelarConfiguracionAdeudo.Click += new System.EventHandler(this.btnCancelarConfiguracionAdeudo_Click);
            // 
            // btnActualizarAdeudo
            // 
            this.btnActualizarAdeudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnActualizarAdeudo.Enabled = false;
            this.btnActualizarAdeudo.Location = new System.Drawing.Point(7, 452);
            this.btnActualizarAdeudo.Name = "btnActualizarAdeudo";
            this.btnActualizarAdeudo.Size = new System.Drawing.Size(75, 25);
            this.btnActualizarAdeudo.TabIndex = 26;
            this.btnActualizarAdeudo.Text = "Actualizar";
            this.btnActualizarAdeudo.UseVisualStyleBackColor = true;
            this.btnActualizarAdeudo.Click += new System.EventHandler(this.btnActualizarAdeudo_Click);
            // 
            // btnNuevoAdeudo
            // 
            this.btnNuevoAdeudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoAdeudo.Location = new System.Drawing.Point(88, 452);
            this.btnNuevoAdeudo.Name = "btnNuevoAdeudo";
            this.btnNuevoAdeudo.Size = new System.Drawing.Size(75, 25);
            this.btnNuevoAdeudo.TabIndex = 25;
            this.btnNuevoAdeudo.Text = "Nuevo";
            this.btnNuevoAdeudo.UseVisualStyleBackColor = true;
            this.btnNuevoAdeudo.Click += new System.EventHandler(this.btnNuevoAdeudo_Click);
            // 
            // btnGuardarAdeudo
            // 
            this.btnGuardarAdeudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarAdeudo.Enabled = false;
            this.btnGuardarAdeudo.Location = new System.Drawing.Point(565, 452);
            this.btnGuardarAdeudo.Name = "btnGuardarAdeudo";
            this.btnGuardarAdeudo.Size = new System.Drawing.Size(75, 25);
            this.btnGuardarAdeudo.TabIndex = 24;
            this.btnGuardarAdeudo.Text = "Guardar";
            this.btnGuardarAdeudo.UseVisualStyleBackColor = true;
            this.btnGuardarAdeudo.Click += new System.EventHandler(this.btnGuardarAdeudo_Click);
            // 
            // txbConcepto
            // 
            this.txbConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbConcepto.Enabled = false;
            this.txbConcepto.Location = new System.Drawing.Point(70, 398);
            this.txbConcepto.Name = "txbConcepto";
            this.txbConcepto.Size = new System.Drawing.Size(162, 20);
            this.txbConcepto.TabIndex = 11;
            // 
            // lblConcepto
            // 
            this.lblConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Location = new System.Drawing.Point(11, 402);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(56, 13);
            this.lblConcepto.TabIndex = 10;
            this.lblConcepto.Text = "Concepto:";
            // 
            // txbPeriodo
            // 
            this.txbPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbPeriodo.Enabled = false;
            this.txbPeriodo.Location = new System.Drawing.Point(70, 363);
            this.txbPeriodo.Name = "txbPeriodo";
            this.txbPeriodo.Size = new System.Drawing.Size(162, 20);
            this.txbPeriodo.TabIndex = 9;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(21, 366);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(46, 13);
            this.lblPeriodo.TabIndex = 8;
            this.lblPeriodo.Text = "Periodo:";
            // 
            // dgvAdeudosConfigurados
            // 
            this.dgvAdeudosConfigurados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdeudosConfigurados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdeudosConfigurados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdeudosConfigurados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdConfiguracionAdeudo,
            this.AdeudoContribuyentes,
            this.dataGridViewTextBoxColumn5,
            this.ConceptoAdeudo,
            this.dataGridViewTextBoxColumn12,
            this.FechaVencimientoAdeudo,
            this.EliminarAdeudo});
            this.dgvAdeudosConfigurados.Location = new System.Drawing.Point(14, 44);
            this.dgvAdeudosConfigurados.Name = "dgvAdeudosConfigurados";
            this.dgvAdeudosConfigurados.Size = new System.Drawing.Size(618, 283);
            this.dgvAdeudosConfigurados.TabIndex = 5;
            this.dgvAdeudosConfigurados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdeudosConfigurados_CellClick);
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
            // cbxMontoDiferente
            // 
            this.cbxMontoDiferente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMontoDiferente.AutoSize = true;
            this.cbxMontoDiferente.Enabled = false;
            this.cbxMontoDiferente.Location = new System.Drawing.Point(392, 401);
            this.cbxMontoDiferente.Name = "cbxMontoDiferente";
            this.cbxMontoDiferente.Size = new System.Drawing.Size(100, 17);
            this.cbxMontoDiferente.TabIndex = 31;
            this.cbxMontoDiferente.Text = "Monto diferente";
            this.cbxMontoDiferente.UseVisualStyleBackColor = true;
            this.cbxMontoDiferente.CheckedChanged += new System.EventHandler(this.cbxMontoDiferente_CheckedChanged);
            // 
            // lblMonto
            // 
            this.lblMonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(508, 401);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(40, 13);
            this.lblMonto.TabIndex = 32;
            this.lblMonto.Text = "Monto:";
            // 
            // txbMonto
            // 
            this.txbMonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMonto.Enabled = false;
            this.txbMonto.Location = new System.Drawing.Point(551, 397);
            this.txbMonto.Name = "txbMonto";
            this.txbMonto.Size = new System.Drawing.Size(81, 20);
            this.txbMonto.TabIndex = 33;
            // 
            // IdConfiguracionAdeudo
            // 
            this.IdConfiguracionAdeudo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IdConfiguracionAdeudo.DataPropertyName = "IdAdeudo";
            this.IdConfiguracionAdeudo.HeaderText = "IdAdeudo";
            this.IdConfiguracionAdeudo.Name = "IdConfiguracionAdeudo";
            this.IdConfiguracionAdeudo.Visible = false;
            this.IdConfiguracionAdeudo.Width = 78;
            // 
            // AdeudoContribuyentes
            // 
            this.AdeudoContribuyentes.DataPropertyName = "AdeudoContribuyentes";
            this.AdeudoContribuyentes.HeaderText = "AdeudoContribuyentes";
            this.AdeudoContribuyentes.Name = "AdeudoContribuyentes";
            this.AdeudoContribuyentes.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Periodo";
            this.dataGridViewTextBoxColumn5.FillWeight = 105.9645F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Periodo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // ConceptoAdeudo
            // 
            this.ConceptoAdeudo.DataPropertyName = "Concepto";
            this.ConceptoAdeudo.FillWeight = 105.9645F;
            this.ConceptoAdeudo.HeaderText = "Concepto";
            this.ConceptoAdeudo.Name = "ConceptoAdeudo";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "FechaGeneracion";
            this.dataGridViewTextBoxColumn12.FillWeight = 105.9645F;
            this.dataGridViewTextBoxColumn12.HeaderText = "Fecha de generacion";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // FechaVencimientoAdeudo
            // 
            this.FechaVencimientoAdeudo.DataPropertyName = "FechaVencimiento";
            this.FechaVencimientoAdeudo.FillWeight = 105.9645F;
            this.FechaVencimientoAdeudo.HeaderText = "Fecha limite de pago";
            this.FechaVencimientoAdeudo.Name = "FechaVencimientoAdeudo";
            // 
            // EliminarAdeudo
            // 
            this.EliminarAdeudo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EliminarAdeudo.FillWeight = 76.14214F;
            this.EliminarAdeudo.HeaderText = "Eliminar";
            this.EliminarAdeudo.Image = global::SCPSAP.Properties.Resources.Borrar;
            this.EliminarAdeudo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EliminarAdeudo.Name = "EliminarAdeudo";
            this.EliminarAdeudo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EliminarAdeudo.ToolTipText = "Eliminar adeudo";
            this.EliminarAdeudo.Width = 49;
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
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.TextBox txbConcepto;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.TextBox txbPeriodo;
        private System.Windows.Forms.Button btnCancelarConfiguracionAdeudo;
        private System.Windows.Forms.Button btnActualizarAdeudo;
        private System.Windows.Forms.Button btnNuevoAdeudo;
        private System.Windows.Forms.Button btnGuardarAdeudo;
        private System.Windows.Forms.DateTimePicker dtpFechaLimitePago;
        private System.Windows.Forms.Label lblFechaLimitePago;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txbFolio;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.CheckBox cbxMontoDiferente;
        private System.Windows.Forms.TextBox txbMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdConfiguracionAdeudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdeudoContribuyentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConceptoAdeudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimientoAdeudo;
        private System.Windows.Forms.DataGridViewImageColumn EliminarAdeudo;
    }
}
