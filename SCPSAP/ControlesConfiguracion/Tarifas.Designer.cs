namespace SCPSAP.ControlesConfiguracion
{
    partial class Tarifas
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txbMontoMensual = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListaTarifas = new System.Windows.Forms.DataGridView();
            this.IdTarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contribuyentes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoMensual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNombreTarifa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTarifas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(503, 324);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 25);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.Location = new System.Drawing.Point(169, 324);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 24);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.Location = new System.Drawing.Point(86, 324);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 25);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnActualizar.Location = new System.Drawing.Point(7, 324);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(71, 25);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txbMontoMensual
            // 
            this.txbMontoMensual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbMontoMensual.Location = new System.Drawing.Point(366, 277);
            this.txbMontoMensual.Margin = new System.Windows.Forms.Padding(2);
            this.txbMontoMensual.Name = "txbMontoMensual";
            this.txbMontoMensual.Size = new System.Drawing.Size(83, 20);
            this.txbMontoMensual.TabIndex = 13;
            // 
            // txbNombre
            // 
            this.txbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbNombre.Location = new System.Drawing.Point(54, 276);
            this.txbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(208, 20);
            this.txbNombre.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 281);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Monto mensual:";
            // 
            // dgvListaTarifas
            // 
            this.dgvListaTarifas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaTarifas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaTarifas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTarifa,
            this.NombreTarifa,
            this.Contribuyentes,
            this.MontoMensual});
            this.dgvListaTarifas.Location = new System.Drawing.Point(7, 5);
            this.dgvListaTarifas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListaTarifas.Name = "dgvListaTarifas";
            this.dgvListaTarifas.RowHeadersWidth = 62;
            this.dgvListaTarifas.RowTemplate.Height = 28;
            this.dgvListaTarifas.Size = new System.Drawing.Size(571, 249);
            this.dgvListaTarifas.TabIndex = 10;
            // 
            // IdTarifa
            // 
            this.IdTarifa.DataPropertyName = "IdTarifa";
            this.IdTarifa.HeaderText = "IdTarifa";
            this.IdTarifa.Name = "IdTarifa";
            this.IdTarifa.Visible = false;
            // 
            // NombreTarifa
            // 
            this.NombreTarifa.DataPropertyName = "NombreTarifa";
            this.NombreTarifa.HeaderText = "Nombre tarifa";
            this.NombreTarifa.Name = "NombreTarifa";
            // 
            // Contribuyentes
            // 
            this.Contribuyentes.DataPropertyName = "Contribuyentes";
            this.Contribuyentes.HeaderText = "Contribuyentes";
            this.Contribuyentes.Name = "Contribuyentes";
            this.Contribuyentes.Visible = false;
            // 
            // MontoMensual
            // 
            this.MontoMensual.DataPropertyName = "MontoMensual";
            this.MontoMensual.HeaderText = "Monto mensual";
            this.MontoMensual.Name = "MontoMensual";
            // 
            // lblNombreTarifa
            // 
            this.lblNombreTarifa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNombreTarifa.AutoSize = true;
            this.lblNombreTarifa.Location = new System.Drawing.Point(6, 280);
            this.lblNombreTarifa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreTarifa.Name = "lblNombreTarifa";
            this.lblNombreTarifa.Size = new System.Drawing.Size(44, 13);
            this.lblNombreTarifa.TabIndex = 9;
            this.lblNombreTarifa.Text = "Nombre";
            // 
            // Tarifas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txbMontoMensual);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListaTarifas);
            this.Controls.Add(this.lblNombreTarifa);
            this.Name = "Tarifas";
            this.Size = new System.Drawing.Size(584, 354);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTarifas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txbMontoMensual;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListaTarifas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contribuyentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoMensual;
        private System.Windows.Forms.Label lblNombreTarifa;
    }
}
