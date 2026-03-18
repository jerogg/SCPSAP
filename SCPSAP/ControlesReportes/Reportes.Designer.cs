namespace SCPSAP.Reportes
{
    partial class Reportes
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
            this.lblfiltros = new System.Windows.Forms.Label();
            this.lblFeachainicio = new System.Windows.Forms.Label();
            this.lblfechafin = new System.Windows.Forms.Label();
            this.dtpfechainicio = new System.Windows.Forms.DateTimePicker();
            this.dtpfechafin = new System.Windows.Forms.DateTimePicker();
            this.lbltiporeporte = new System.Windows.Forms.Label();
            this.cmbTiporeporte = new System.Windows.Forms.ComboBox();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.btngenerar = new System.Windows.Forms.Button();
            this.btnExpopdf = new System.Windows.Forms.Button();
            this.btnExpoexcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // lblfiltros
            // 
            this.lblfiltros.AutoSize = true;
            this.lblfiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblfiltros.Location = new System.Drawing.Point(35, 38);
            this.lblfiltros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfiltros.Name = "lblfiltros";
            this.lblfiltros.Size = new System.Drawing.Size(52, 13);
            this.lblfiltros.TabIndex = 0;
            this.lblfiltros.Text = "FILTROS";
            this.lblfiltros.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFeachainicio
            // 
            this.lblFeachainicio.AutoSize = true;
            this.lblFeachainicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblFeachainicio.Location = new System.Drawing.Point(38, 67);
            this.lblFeachainicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFeachainicio.Name = "lblFeachainicio";
            this.lblFeachainicio.Size = new System.Drawing.Size(68, 13);
            this.lblFeachainicio.TabIndex = 1;
            this.lblFeachainicio.Text = "Fecha Inicio:";
            // 
            // lblfechafin
            // 
            this.lblfechafin.AutoSize = true;
            this.lblfechafin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblfechafin.Location = new System.Drawing.Point(38, 99);
            this.lblfechafin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfechafin.Name = "lblfechafin";
            this.lblfechafin.Size = new System.Drawing.Size(57, 13);
            this.lblfechafin.TabIndex = 2;
            this.lblfechafin.Text = "Fecha Fin:";
            // 
            // dtpfechainicio
            // 
            this.dtpfechainicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dtpfechainicio.Location = new System.Drawing.Point(104, 63);
            this.dtpfechainicio.Margin = new System.Windows.Forms.Padding(2);
            this.dtpfechainicio.Name = "dtpfechainicio";
            this.dtpfechainicio.Size = new System.Drawing.Size(197, 20);
            this.dtpfechainicio.TabIndex = 3;
            // 
            // dtpfechafin
            // 
            this.dtpfechafin.Location = new System.Drawing.Point(104, 94);
            this.dtpfechafin.Margin = new System.Windows.Forms.Padding(2);
            this.dtpfechafin.Name = "dtpfechafin";
            this.dtpfechafin.Size = new System.Drawing.Size(197, 20);
            this.dtpfechafin.TabIndex = 4;
            // 
            // lbltiporeporte
            // 
            this.lbltiporeporte.AutoSize = true;
            this.lbltiporeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbltiporeporte.Location = new System.Drawing.Point(38, 127);
            this.lbltiporeporte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltiporeporte.Name = "lbltiporeporte";
            this.lbltiporeporte.Size = new System.Drawing.Size(82, 13);
            this.lbltiporeporte.TabIndex = 5;
            this.lbltiporeporte.Text = "Tipo de reporte:";
            // 
            // cmbTiporeporte
            // 
            this.cmbTiporeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cmbTiporeporte.FormattingEnabled = true;
            this.cmbTiporeporte.Location = new System.Drawing.Point(124, 124);
            this.cmbTiporeporte.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTiporeporte.Name = "cmbTiporeporte";
            this.cmbTiporeporte.Size = new System.Drawing.Size(176, 21);
            this.cmbTiporeporte.TabIndex = 6;
            // 
            // dgvReporte
            // 
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Location = new System.Drawing.Point(2, 149);
            this.dgvReporte.Margin = new System.Windows.Forms.Padding(2);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.RowHeadersWidth = 51;
            this.dgvReporte.RowTemplate.Height = 24;
            this.dgvReporte.Size = new System.Drawing.Size(567, 312);
            this.dgvReporte.TabIndex = 7;
            // 
            // btngenerar
            // 
            this.btngenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btngenerar.Location = new System.Drawing.Point(318, 479);
            this.btngenerar.Margin = new System.Windows.Forms.Padding(2);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(56, 25);
            this.btngenerar.TabIndex = 8;
            this.btngenerar.Text = "Generar";
            this.btngenerar.UseVisualStyleBackColor = true;
            // 
            // btnExpopdf
            // 
            this.btnExpopdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnExpopdf.Location = new System.Drawing.Point(384, 479);
            this.btnExpopdf.Margin = new System.Windows.Forms.Padding(2);
            this.btnExpopdf.Name = "btnExpopdf";
            this.btnExpopdf.Size = new System.Drawing.Size(92, 25);
            this.btnExpopdf.TabIndex = 9;
            this.btnExpopdf.Text = "Exportar PDF";
            this.btnExpopdf.UseVisualStyleBackColor = true;
            // 
            // btnExpoexcel
            // 
            this.btnExpoexcel.Location = new System.Drawing.Point(486, 479);
            this.btnExpoexcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExpoexcel.Name = "btnExpoexcel";
            this.btnExpoexcel.Size = new System.Drawing.Size(82, 25);
            this.btnExpoexcel.TabIndex = 10;
            this.btnExpoexcel.Text = "Exportar Excel";
            this.btnExpoexcel.UseVisualStyleBackColor = true;
            this.btnExpoexcel.Click += new System.EventHandler(this.btnExpoexcel_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExpoexcel);
            this.Controls.Add(this.btnExpopdf);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.dgvReporte);
            this.Controls.Add(this.cmbTiporeporte);
            this.Controls.Add(this.lbltiporeporte);
            this.Controls.Add(this.dtpfechafin);
            this.Controls.Add(this.dtpfechainicio);
            this.Controls.Add(this.lblfechafin);
            this.Controls.Add(this.lblFeachainicio);
            this.Controls.Add(this.lblfiltros);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Reportes";
            this.Size = new System.Drawing.Size(572, 509);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfiltros;
        private System.Windows.Forms.Label lblFeachainicio;
        private System.Windows.Forms.Label lblfechafin;
        private System.Windows.Forms.DateTimePicker dtpfechainicio;
        private System.Windows.Forms.DateTimePicker dtpfechafin;
        private System.Windows.Forms.Label lbltiporeporte;
        private System.Windows.Forms.ComboBox cmbTiporeporte;
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.Button btnExpopdf;
        private System.Windows.Forms.Button btnExpoexcel;
    }
}
