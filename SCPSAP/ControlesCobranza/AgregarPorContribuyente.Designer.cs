namespace SCPSAP.ControlesCobranza
{
    partial class AgregarPorContribuyente
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
            this.lblContribuyente = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvAdeudosConfiguradosNoRelacionados = new System.Windows.Forms.DataGridView();
            this.lblAdeudos = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.IdAdeudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdeudoContribuyentes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConceptoAdeudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimientoAdeudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoDiferente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RelacionarAdeudo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdeudosConfiguradosNoRelacionados)).BeginInit();
            this.SuspendLayout();
            // 
            // txbDireccion
            // 
            this.txbDireccion.Enabled = false;
            this.txbDireccion.Location = new System.Drawing.Point(408, 32);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(198, 20);
            this.txbDireccion.TabIndex = 34;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(350, 35);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 33;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txbFolio
            // 
            this.txbFolio.Enabled = false;
            this.txbFolio.Location = new System.Drawing.Point(274, 33);
            this.txbFolio.Name = "txbFolio";
            this.txbFolio.Size = new System.Drawing.Size(63, 20);
            this.txbFolio.TabIndex = 32;
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Location = new System.Drawing.Point(238, 36);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(32, 13);
            this.lblFolio.TabIndex = 31;
            this.lblFolio.Text = "Folio:";
            // 
            // lblContribuyente
            // 
            this.lblContribuyente.AutoSize = true;
            this.lblContribuyente.Location = new System.Drawing.Point(14, 9);
            this.lblContribuyente.Name = "lblContribuyente";
            this.lblContribuyente.Size = new System.Drawing.Size(99, 13);
            this.lblContribuyente.TabIndex = 28;
            this.lblContribuyente.Text = "CONTRIBUYENTE";
            // 
            // txbName
            // 
            this.txbName.Enabled = false;
            this.txbName.Location = new System.Drawing.Point(64, 32);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(161, 20);
            this.txbName.TabIndex = 30;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(14, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 29;
            this.lblNombre.Text = "Nombre:";
            // 
            // dgvAdeudosConfiguradosNoRelacionados
            // 
            this.dgvAdeudosConfiguradosNoRelacionados.AllowUserToAddRows = false;
            this.dgvAdeudosConfiguradosNoRelacionados.AllowUserToDeleteRows = false;
            this.dgvAdeudosConfiguradosNoRelacionados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdeudosConfiguradosNoRelacionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdeudosConfiguradosNoRelacionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdeudosConfiguradosNoRelacionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAdeudo,
            this.AdeudoContribuyentes,
            this.dataGridViewTextBoxColumn5,
            this.ConceptoAdeudo,
            this.dataGridViewTextBoxColumn12,
            this.FechaVencimientoAdeudo,
            this.MontoDiferente,
            this.Monto,
            this.RelacionarAdeudo});
            this.dgvAdeudosConfiguradosNoRelacionados.Location = new System.Drawing.Point(16, 104);
            this.dgvAdeudosConfiguradosNoRelacionados.Name = "dgvAdeudosConfiguradosNoRelacionados";
            this.dgvAdeudosConfiguradosNoRelacionados.Size = new System.Drawing.Size(618, 318);
            this.dgvAdeudosConfiguradosNoRelacionados.TabIndex = 37;
            // 
            // lblAdeudos
            // 
            this.lblAdeudos.AutoSize = true;
            this.lblAdeudos.Location = new System.Drawing.Point(13, 78);
            this.lblAdeudos.Name = "lblAdeudos";
            this.lblAdeudos.Size = new System.Drawing.Size(366, 13);
            this.lblAdeudos.TabIndex = 36;
            this.lblAdeudos.Text = "ADEUDOS CONFIGURADOS NO RELACIONADOS AL CONTRIBUYENTE";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(471, 440);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 45;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(559, 440);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 25);
            this.btnGuardar.TabIndex = 44;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // IdAdeudo
            // 
            this.IdAdeudo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IdAdeudo.DataPropertyName = "IdAdeudo";
            this.IdAdeudo.HeaderText = "IdAdeudo";
            this.IdAdeudo.Name = "IdAdeudo";
            this.IdAdeudo.Visible = false;
            this.IdAdeudo.Width = 78;
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
            // MontoDiferente
            // 
            this.MontoDiferente.DataPropertyName = "EsMontoDiferente";
            this.MontoDiferente.HeaderText = "Monto diferente";
            this.MontoDiferente.Name = "MontoDiferente";
            this.MontoDiferente.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // RelacionarAdeudo
            // 
            this.RelacionarAdeudo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RelacionarAdeudo.FillWeight = 76.14214F;
            this.RelacionarAdeudo.HeaderText = "Relacionar";
            this.RelacionarAdeudo.Name = "RelacionarAdeudo";
            this.RelacionarAdeudo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RelacionarAdeudo.ToolTipText = "Relacionar un adeudo existente al contribuyente";
            this.RelacionarAdeudo.Width = 64;
            // 
            // AgregarPorContribuyente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvAdeudosConfiguradosNoRelacionados);
            this.Controls.Add(this.lblAdeudos);
            this.Controls.Add(this.txbDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txbFolio);
            this.Controls.Add(this.lblFolio);
            this.Controls.Add(this.lblContribuyente);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblNombre);
            this.Name = "AgregarPorContribuyente";
            this.Size = new System.Drawing.Size(647, 470);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdeudosConfiguradosNoRelacionados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txbFolio;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.Label lblContribuyente;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgvAdeudosConfiguradosNoRelacionados;
        private System.Windows.Forms.Label lblAdeudos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAdeudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdeudoContribuyentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConceptoAdeudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimientoAdeudo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MontoDiferente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RelacionarAdeudo;
    }
}
