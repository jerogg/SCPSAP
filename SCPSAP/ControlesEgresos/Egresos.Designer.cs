namespace SCPSAP.ControlesEgresos
{
    partial class Egresos
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
            this.lblConcepto = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.txbConcepto = new System.Windows.Forms.TextBox();
            this.txbMonto = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvListaContribuyentes = new System.Windows.Forms.DataGridView();
            this.IdEgreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaContribuyentes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConcepto
            // 
            this.lblConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Location = new System.Drawing.Point(10, 309);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(56, 13);
            this.lblConcepto.TabIndex = 18;
            this.lblConcepto.Text = "Concepto:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(7, 384);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 19;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblMonto
            // 
            this.lblMonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(25, 347);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(40, 13);
            this.lblMonto.TabIndex = 20;
            this.lblMonto.Text = "Monto:";
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDescripcion.Location = new System.Drawing.Point(0, 400);
            this.txbDescripcion.Multiline = true;
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(601, 61);
            this.txbDescripcion.TabIndex = 25;
            // 
            // txbConcepto
            // 
            this.txbConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbConcepto.Enabled = false;
            this.txbConcepto.Location = new System.Drawing.Point(69, 306);
            this.txbConcepto.Name = "txbConcepto";
            this.txbConcepto.Size = new System.Drawing.Size(262, 20);
            this.txbConcepto.TabIndex = 29;
            // 
            // txbMonto
            // 
            this.txbMonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbMonto.Enabled = false;
            this.txbMonto.Location = new System.Drawing.Point(69, 344);
            this.txbMonto.Name = "txbMonto";
            this.txbMonto.Size = new System.Drawing.Size(262, 20);
            this.txbMonto.TabIndex = 30;
            this.txbMonto.TextChanged += new System.EventHandler(this.txbMonto_TextChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(526, 474);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 25);
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvListaContribuyentes
            // 
            this.dgvListaContribuyentes.AllowUserToAddRows = false;
            this.dgvListaContribuyentes.AllowUserToDeleteRows = false;
            this.dgvListaContribuyentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaContribuyentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaContribuyentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaContribuyentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEgreso,
            this.Concepto,
            this.Descripcion,
            this.Monto,
            this.FechaMovimiento,
            this.UsuarioSistema});
            this.dgvListaContribuyentes.Location = new System.Drawing.Point(3, 3);
            this.dgvListaContribuyentes.MultiSelect = false;
            this.dgvListaContribuyentes.Name = "dgvListaContribuyentes";
            this.dgvListaContribuyentes.ReadOnly = true;
            this.dgvListaContribuyentes.RowHeadersWidth = 51;
            this.dgvListaContribuyentes.Size = new System.Drawing.Size(598, 277);
            this.dgvListaContribuyentes.TabIndex = 32;
            // 
            // IdEgreso
            // 
            this.IdEgreso.DataPropertyName = "IdEgreso";
            this.IdEgreso.HeaderText = "IdEgreso";
            this.IdEgreso.MinimumWidth = 6;
            this.IdEgreso.Name = "IdEgreso";
            this.IdEgreso.ReadOnly = true;
            this.IdEgreso.Visible = false;
            // 
            // Concepto
            // 
            this.Concepto.DataPropertyName = "Concepto";
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.MinimumWidth = 6;
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            this.Monto.HeaderText = "Monto";
            this.Monto.MinimumWidth = 6;
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // FechaMovimiento
            // 
            this.FechaMovimiento.DataPropertyName = "FechaMovimiento";
            this.FechaMovimiento.HeaderText = "Fecha";
            this.FechaMovimiento.MinimumWidth = 6;
            this.FechaMovimiento.Name = "FechaMovimiento";
            this.FechaMovimiento.ReadOnly = true;
            // 
            // UsuarioSistema
            // 
            this.UsuarioSistema.DataPropertyName = "UsuarioSistema";
            this.UsuarioSistema.HeaderText = "Usuario sistema";
            this.UsuarioSistema.MinimumWidth = 6;
            this.UsuarioSistema.Name = "UsuarioSistema";
            this.UsuarioSistema.ReadOnly = true;
            // 
            // Egresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvListaContribuyentes);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txbMonto);
            this.Controls.Add(this.txbConcepto);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblConcepto);
            this.Name = "Egresos";
            this.Size = new System.Drawing.Size(604, 502);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaContribuyentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.TextBox txbConcepto;
        private System.Windows.Forms.TextBox txbMonto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvListaContribuyentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEgreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioSistema;
    }
}
