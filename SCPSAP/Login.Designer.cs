namespace SCPSAP
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsuario = new Label();
            txbUsuario = new TextBox();
            lblContraseña = new Label();
            txbContraseña = new TextBox();
            btnOk = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(62, 68);
            lblUsuario.Margin = new Padding(2, 0, 2, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // txbUsuario
            // 
            txbUsuario.Location = new Point(138, 68);
            txbUsuario.Margin = new Padding(2, 2, 2, 2);
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Size = new Size(121, 27);
            txbUsuario.TabIndex = 1;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(62, 136);
            lblContraseña.Margin = new Padding(2, 0, 2, 0);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(83, 20);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña";
            lblContraseña.Click += label1_Click;
            // 
            // txbContraseña
            // 
            txbContraseña.Location = new Point(147, 137);
            txbContraseña.Margin = new Padding(2, 2, 2, 2);
            txbContraseña.Name = "txbContraseña";
            txbContraseña.Size = new Size(121, 27);
            txbContraseña.TabIndex = 3;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(222, 236);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 4;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(356, 236);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(txbContraseña);
            Controls.Add(lblContraseña);
            Controls.Add(txbUsuario);
            Controls.Add(lblUsuario);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Login";
            Text = "Contraseña";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private TextBox txbUsuario;
        private Label lblContraseña;
        private TextBox txbContraseña;
        private Button btnOk;
        private Button btnCancelar;
    }
}
