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
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(77, 85);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(72, 25);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // txbUsuario
            // 
            txbUsuario.Location = new Point(172, 85);
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Size = new Size(150, 31);
            txbUsuario.TabIndex = 1;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(77, 170);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(101, 25);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña";
            lblContraseña.Click += label1_Click;
            // 
            // txbContraseña
            // 
            txbContraseña.Location = new Point(184, 171);
            txbContraseña.Name = "txbContraseña";
            txbContraseña.Size = new Size(150, 31);
            txbContraseña.TabIndex = 3;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txbContraseña);
            Controls.Add(lblContraseña);
            Controls.Add(txbUsuario);
            Controls.Add(lblUsuario);
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
    }
}
