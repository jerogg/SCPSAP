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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lblUsuario = new Label();
            txbUsuario = new TextBox();
            lblContraseña = new Label();
            txbContraseña = new TextBox();
            btnOk = new Button();
            btnCancelar = new Button();
            imgContraseña = new PictureBox();
            imgUser = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)imgContraseña).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgUser).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(86, 17);
            lblUsuario.Margin = new Padding(2, 0, 2, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(72, 25);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // txbUsuario
            // 
            txbUsuario.Location = new Point(165, 14);
            txbUsuario.Margin = new Padding(2);
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Size = new Size(150, 31);
            txbUsuario.TabIndex = 1;
            txbUsuario.TextChanged += txbUsuario_TextChanged;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(57, 15);
            lblContraseña.Margin = new Padding(2, 0, 2, 0);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(101, 25);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña";
            lblContraseña.Click += label1_Click;
            // 
            // txbContraseña
            // 
            txbContraseña.Location = new Point(164, 12);
            txbContraseña.Margin = new Padding(2);
            txbContraseña.Name = "txbContraseña";
            txbContraseña.PasswordChar = '*';
            txbContraseña.Size = new Size(150, 31);
            txbContraseña.TabIndex = 3;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(273, 232);
            btnOk.Margin = new Padding(4);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(118, 36);
            btnOk.TabIndex = 4;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(412, 232);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(118, 36);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // imgContraseña
            // 
            imgContraseña.Image = (Image)resources.GetObject("imgContraseña.Image");
            imgContraseña.Location = new Point(24, 18);
            imgContraseña.Name = "imgContraseña";
            imgContraseña.Size = new Size(25, 25);
            imgContraseña.SizeMode = PictureBoxSizeMode.StretchImage;
            imgContraseña.TabIndex = 7;
            imgContraseña.TabStop = false;
            // 
            // imgUser
            // 
            imgUser.Image = (Image)resources.GetObject("imgUser.Image");
            imgUser.Location = new Point(24, 18);
            imgUser.Name = "imgUser";
            imgUser.Size = new Size(25, 28);
            imgUser.SizeMode = PictureBoxSizeMode.StretchImage;
            imgUser.TabIndex = 8;
            imgUser.TabStop = false;
            imgUser.Click += imgUser_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(imgUser);
            panel1.Controls.Add(txbUsuario);
            panel1.Location = new Point(106, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 59);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblContraseña);
            panel2.Controls.Add(txbContraseña);
            panel2.Controls.Add(imgContraseña);
            panel2.Location = new Point(106, 133);
            panel2.Name = "panel2";
            panel2.Size = new Size(348, 59);
            panel2.TabIndex = 10;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 280);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)imgContraseña).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgUser).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblUsuario;
        private TextBox txbUsuario;
        private Label lblContraseña;
        private TextBox txbContraseña;
        private Button btnOk;
        private Button btnCancelar;
        private PictureBox imgContraseña;
        private PictureBox imgUser;
        private Panel panel1;
        private Panel panel2;
    }
}
