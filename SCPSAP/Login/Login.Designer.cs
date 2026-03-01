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
            ((System.ComponentModel.ISupportInitialize)imgContraseña).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgUser).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(158, 95);
            lblUsuario.Margin = new Padding(2, 0, 2, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(72, 25);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // txbUsuario
            // 
            txbUsuario.Location = new Point(268, 92);
            txbUsuario.Margin = new Padding(2);
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Size = new Size(150, 31);
            txbUsuario.TabIndex = 1;
            txbUsuario.TextChanged += txbUsuario_TextChanged;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(151, 171);
            lblContraseña.Margin = new Padding(2, 0, 2, 0);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(101, 25);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña";
            lblContraseña.Click += label1_Click;
            // 
            // txbContraseña
            // 
            txbContraseña.Location = new Point(269, 168);
            txbContraseña.Margin = new Padding(2);
            txbContraseña.Name = "txbContraseña";
            txbContraseña.PasswordChar = '*';
            txbContraseña.Size = new Size(150, 31);
            txbContraseña.TabIndex = 3;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(267, 274);
            btnOk.Margin = new Padding(4);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(118, 36);
            btnOk.TabIndex = 4;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(412, 274);
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
            imgContraseña.Location = new Point(123, 170);
            imgContraseña.Name = "imgContraseña";
            imgContraseña.Size = new Size(25, 25);
            imgContraseña.SizeMode = PictureBoxSizeMode.StretchImage;
            imgContraseña.TabIndex = 7;
            imgContraseña.TabStop = false;
            // 
            // imgUser
            // 
            imgUser.Image = (Image)resources.GetObject("imgUser.Image");
            imgUser.Location = new Point(123, 94);
            imgUser.Name = "imgUser";
            imgUser.Size = new Size(29, 30);
            imgUser.SizeMode = PictureBoxSizeMode.StretchImage;
            imgUser.TabIndex = 8;
            imgUser.TabStop = false;
            imgUser.Click += imgUser_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 336);
            Controls.Add(imgUser);
            Controls.Add(imgContraseña);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(txbContraseña);
            Controls.Add(lblContraseña);
            Controls.Add(txbUsuario);
            Controls.Add(lblUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)imgContraseña).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgUser).EndInit();
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
        private PictureBox imgContraseña;
        private PictureBox imgUser;
    }
}
