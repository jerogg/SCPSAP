namespace SCPSAP.ControlesCobranza
{
    partial class ConfiguraAdeudo
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
            this.txbMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.cbxMontoDiferente = new System.Windows.Forms.CheckBox();
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
            this.IdConfiguracionAdeudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdeudoContribuyentes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConceptoAdeudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimientoAdeudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EliminarAdeudo = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblAdeudos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdeudosConfigurados)).BeginInit();
            this.SuspendLayout();
            // 
            // txbMonto
            // 
            this.txbMonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMonto.Enabled = false;
            this.txbMonto.Location = new System.Drawing.Point(551, 386);
            this.txbMonto.Name = "txbMonto";
            this.txbMonto.Size = new System.Drawing.Size(81, 20);
            this.txbMonto.TabIndex = 48;
            // 
            // lblMonto
            // 
            this.lblMonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(508, 390);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(40, 13);
            this.lblMonto.TabIndex = 47;
            this.lblMonto.Text = "Monto:";
            // 
            // cbxMontoDiferente
            // 
            this.cbxMontoDiferente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMontoDiferente.AutoSize = true;
            this.cbxMontoDiferente.Enabled = false;
            this.cbxMontoDiferente.Location = new System.Drawing.Point(392, 390);
            this.cbxMontoDiferente.Name = "cbxMontoDiferente";
            this.cbxMontoDiferente.Size = new System.Drawing.Size(100, 17);
            this.cbxMontoDiferente.TabIndex = 46;
            this.cbxMontoDiferente.Text = "Monto diferente";
            this.cbxMontoDiferente.UseVisualStyleBackColor = true;
            this.cbxMontoDiferente.CheckedChanged += new System.EventHandler(this.cbxMontoDiferente_CheckedChanged);
            // 
            // lblFechaLimitePago
            // 
            this.lblFechaLimitePago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaLimitePago.AutoSize = true;
            this.lblFechaLimitePago.Location = new System.Drawing.Point(321, 352);
            this.lblFechaLimitePago.Name = "lblFechaLimitePago";
            this.lblFechaLimitePago.Size = new System.Drawing.Size(108, 13);
            this.lblFechaLimitePago.TabIndex = 45;
            this.lblFechaLimitePago.Text = "Fecha limite de pago:";
            // 
            // dtpFechaLimitePago
            // 
            this.dtpFechaLimitePago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaLimitePago.Enabled = false;
            this.dtpFechaLimitePago.Location = new System.Drawing.Point(432, 348);
            this.dtpFechaLimitePago.Name = "dtpFechaLimitePago";
            this.dtpFechaLimitePago.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaLimitePago.TabIndex = 44;
            // 
            // btnCancelarConfiguracionAdeudo
            // 
            this.btnCancelarConfiguracionAdeudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelarConfiguracionAdeudo.Enabled = false;
            this.btnCancelarConfiguracionAdeudo.Location = new System.Drawing.Point(169, 439);
            this.btnCancelarConfiguracionAdeudo.Name = "btnCancelarConfiguracionAdeudo";
            this.btnCancelarConfiguracionAdeudo.Size = new System.Drawing.Size(75, 25);
            this.btnCancelarConfiguracionAdeudo.TabIndex = 43;
            this.btnCancelarConfiguracionAdeudo.Text = "Cancelar";
            this.btnCancelarConfiguracionAdeudo.UseVisualStyleBackColor = true;
            this.btnCancelarConfiguracionAdeudo.Click += new System.EventHandler(this.btnCancelarConfiguracionAdeudo_Click);
            // 
            // btnActualizarAdeudo
            // 
            this.btnActualizarAdeudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnActualizarAdeudo.Enabled = false;
            this.btnActualizarAdeudo.Location = new System.Drawing.Point(7, 439);
            this.btnActualizarAdeudo.Name = "btnActualizarAdeudo";
            this.btnActualizarAdeudo.Size = new System.Drawing.Size(75, 25);
            this.btnActualizarAdeudo.TabIndex = 42;
            this.btnActualizarAdeudo.Text = "Actualizar";
            this.btnActualizarAdeudo.UseVisualStyleBackColor = true;
            this.btnActualizarAdeudo.Click += new System.EventHandler(this.btnActualizarAdeudo_Click);
            // 
            // btnNuevoAdeudo
            // 
            this.btnNuevoAdeudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoAdeudo.Location = new System.Drawing.Point(88, 439);
            this.btnNuevoAdeudo.Name = "btnNuevoAdeudo";
            this.btnNuevoAdeudo.Size = new System.Drawing.Size(75, 25);
            this.btnNuevoAdeudo.TabIndex = 41;
            this.btnNuevoAdeudo.Text = "Nuevo";
            this.btnNuevoAdeudo.UseVisualStyleBackColor = true;
            this.btnNuevoAdeudo.Click += new System.EventHandler(this.btnNuevoAdeudo_Click);
            // 
            // btnGuardarAdeudo
            // 
            this.btnGuardarAdeudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarAdeudo.Enabled = false;
            this.btnGuardarAdeudo.Location = new System.Drawing.Point(565, 439);
            this.btnGuardarAdeudo.Name = "btnGuardarAdeudo";
            this.btnGuardarAdeudo.Size = new System.Drawing.Size(75, 25);
            this.btnGuardarAdeudo.TabIndex = 40;
            this.btnGuardarAdeudo.Text = "Guardar";
            this.btnGuardarAdeudo.UseVisualStyleBackColor = true;
            this.btnGuardarAdeudo.Click += new System.EventHandler(this.btnGuardarAdeudo_Click);
            // 
            // txbConcepto
            // 
            this.txbConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbConcepto.Enabled = false;
            this.txbConcepto.Location = new System.Drawing.Point(70, 387);
            this.txbConcepto.Name = "txbConcepto";
            this.txbConcepto.Size = new System.Drawing.Size(162, 20);
            this.txbConcepto.TabIndex = 39;
            // 
            // lblConcepto
            // 
            this.lblConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Location = new System.Drawing.Point(11, 391);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(56, 13);
            this.lblConcepto.TabIndex = 38;
            this.lblConcepto.Text = "Concepto:";
            // 
            // txbPeriodo
            // 
            this.txbPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbPeriodo.Enabled = false;
            this.txbPeriodo.Location = new System.Drawing.Point(70, 352);
            this.txbPeriodo.Name = "txbPeriodo";
            this.txbPeriodo.Size = new System.Drawing.Size(162, 20);
            this.txbPeriodo.TabIndex = 37;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(21, 355);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(46, 13);
            this.lblPeriodo.TabIndex = 36;
            this.lblPeriodo.Text = "Periodo:";
            // 
            // dgvAdeudosConfigurados
            // 
            this.dgvAdeudosConfigurados.AllowUserToAddRows = false;
            this.dgvAdeudosConfigurados.AllowUserToDeleteRows = false;
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
            this.dgvAdeudosConfigurados.Location = new System.Drawing.Point(14, 39);
            this.dgvAdeudosConfigurados.Name = "dgvAdeudosConfigurados";
            this.dgvAdeudosConfigurados.ReadOnly = true;
            this.dgvAdeudosConfigurados.Size = new System.Drawing.Size(618, 288);
            this.dgvAdeudosConfigurados.TabIndex = 35;
            this.dgvAdeudosConfigurados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdeudosConfigurados_CellClick);
            // 
            // IdConfiguracionAdeudo
            // 
            this.IdConfiguracionAdeudo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IdConfiguracionAdeudo.DataPropertyName = "IdAdeudo";
            this.IdConfiguracionAdeudo.HeaderText = "IdAdeudo";
            this.IdConfiguracionAdeudo.Name = "IdConfiguracionAdeudo";
            this.IdConfiguracionAdeudo.ReadOnly = true;
            this.IdConfiguracionAdeudo.Visible = false;
            // 
            // AdeudoContribuyentes
            // 
            this.AdeudoContribuyentes.DataPropertyName = "AdeudoContribuyentes";
            this.AdeudoContribuyentes.HeaderText = "AdeudoContribuyentes";
            this.AdeudoContribuyentes.Name = "AdeudoContribuyentes";
            this.AdeudoContribuyentes.ReadOnly = true;
            this.AdeudoContribuyentes.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Periodo";
            this.dataGridViewTextBoxColumn5.FillWeight = 105.9645F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Periodo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // ConceptoAdeudo
            // 
            this.ConceptoAdeudo.DataPropertyName = "Concepto";
            this.ConceptoAdeudo.FillWeight = 105.9645F;
            this.ConceptoAdeudo.HeaderText = "Concepto";
            this.ConceptoAdeudo.Name = "ConceptoAdeudo";
            this.ConceptoAdeudo.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "FechaGeneracion";
            this.dataGridViewTextBoxColumn12.FillWeight = 105.9645F;
            this.dataGridViewTextBoxColumn12.HeaderText = "Fecha de generacion";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // FechaVencimientoAdeudo
            // 
            this.FechaVencimientoAdeudo.DataPropertyName = "FechaVencimiento";
            this.FechaVencimientoAdeudo.FillWeight = 105.9645F;
            this.FechaVencimientoAdeudo.HeaderText = "Fecha limite de pago";
            this.FechaVencimientoAdeudo.Name = "FechaVencimientoAdeudo";
            this.FechaVencimientoAdeudo.ReadOnly = true;
            // 
            // EliminarAdeudo
            // 
            this.EliminarAdeudo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EliminarAdeudo.FillWeight = 76.14214F;
            this.EliminarAdeudo.HeaderText = "Eliminar";
            this.EliminarAdeudo.Image = global::SCPSAP.Properties.Resources.Borrar;
            this.EliminarAdeudo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EliminarAdeudo.Name = "EliminarAdeudo";
            this.EliminarAdeudo.ReadOnly = true;
            this.EliminarAdeudo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EliminarAdeudo.ToolTipText = "Eliminar adeudo";
            this.EliminarAdeudo.Width = 49;
            // 
            // lblAdeudos
            // 
            this.lblAdeudos.AutoSize = true;
            this.lblAdeudos.Location = new System.Drawing.Point(11, 13);
            this.lblAdeudos.Name = "lblAdeudos";
            this.lblAdeudos.Size = new System.Drawing.Size(149, 13);
            this.lblAdeudos.TabIndex = 34;
            this.lblAdeudos.Text = "ADEUDOS CONFIGURADOS";
            // 
            // ConfiguraAdeudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txbMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.cbxMontoDiferente);
            this.Controls.Add(this.lblFechaLimitePago);
            this.Controls.Add(this.dtpFechaLimitePago);
            this.Controls.Add(this.btnCancelarConfiguracionAdeudo);
            this.Controls.Add(this.btnActualizarAdeudo);
            this.Controls.Add(this.btnNuevoAdeudo);
            this.Controls.Add(this.btnGuardarAdeudo);
            this.Controls.Add(this.txbConcepto);
            this.Controls.Add(this.lblConcepto);
            this.Controls.Add(this.txbPeriodo);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.dgvAdeudosConfigurados);
            this.Controls.Add(this.lblAdeudos);
            this.Name = "ConfiguraAdeudo";
            this.Size = new System.Drawing.Size(647, 470);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdeudosConfigurados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.CheckBox cbxMontoDiferente;
        private System.Windows.Forms.Label lblFechaLimitePago;
        private System.Windows.Forms.DateTimePicker dtpFechaLimitePago;
        private System.Windows.Forms.Button btnCancelarConfiguracionAdeudo;
        private System.Windows.Forms.Button btnActualizarAdeudo;
        private System.Windows.Forms.Button btnNuevoAdeudo;
        private System.Windows.Forms.Button btnGuardarAdeudo;
        private System.Windows.Forms.TextBox txbConcepto;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.TextBox txbPeriodo;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.DataGridView dgvAdeudosConfigurados;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdConfiguracionAdeudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdeudoContribuyentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConceptoAdeudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimientoAdeudo;
        private System.Windows.Forms.DataGridViewImageColumn EliminarAdeudo;
        private System.Windows.Forms.Label lblAdeudos;
    }
}
