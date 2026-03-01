namespace SCPSAP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel2 = new Panel();
            lblContraseña = new Label();
            txbContraseña = new TextBox();
            imgContraseña = new PictureBox();
            panel1 = new Panel();
            lblUsuario = new Label();
            imgUser = new PictureBox();
            txbUsuario = new TextBox();
            btnCancelar = new Button();
            btnOk = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgContraseña).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgUser).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(lblContraseña);
            panel2.Controls.Add(txbContraseña);
            panel2.Controls.Add(imgContraseña);
            panel2.Location = new Point(38, 80);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(244, 35);
            panel2.TabIndex = 18;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(45, 11);
            lblContraseña.Margin = new Padding(1, 0, 1, 0);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña";
            // 
            // txbContraseña
            // 
            txbContraseña.Location = new Point(115, 6);
            txbContraseña.Margin = new Padding(1);
            txbContraseña.Name = "txbContraseña";
            txbContraseña.PasswordChar = '*';
            txbContraseña.Size = new Size(106, 23);
            txbContraseña.TabIndex = 3;
            // 
            // imgContraseña
            // 
            imgContraseña.Image = (Image)resources.GetObject("imgContraseña.Image");
            imgContraseña.Location = new Point(20, 10);
            imgContraseña.Margin = new Padding(2);
            imgContraseña.Name = "imgContraseña";
            imgContraseña.Size = new Size(18, 15);
            imgContraseña.SizeMode = PictureBoxSizeMode.StretchImage;
            imgContraseña.TabIndex = 7;
            imgContraseña.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(imgUser);
            panel1.Controls.Add(txbUsuario);
            panel1.Location = new Point(38, 34);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 35);
            panel1.TabIndex = 17;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(66, 11);
            lblUsuario.Margin = new Padding(1, 0, 1, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // imgUser
            // 
            imgUser.Image = (Image)resources.GetObject("imgUser.Image");
            imgUser.Location = new Point(20, 10);
            imgUser.Margin = new Padding(2);
            imgUser.Name = "imgUser";
            imgUser.Size = new Size(18, 15);
            imgUser.SizeMode = PictureBoxSizeMode.StretchImage;
            imgUser.TabIndex = 8;
            imgUser.TabStop = false;
            // 
            // txbUsuario
            // 
            txbUsuario.Location = new Point(116, 6);
            txbUsuario.Margin = new Padding(1);
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Size = new Size(106, 23);
            txbUsuario.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(250, 142);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(83, 22);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(153, 142);
            btnOk.Margin = new Padding(3, 2, 3, 2);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(83, 22);
            btnOk.TabIndex = 15;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 171);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgContraseña).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label lblContraseña;
        private TextBox txbContraseña;
        private PictureBox imgContraseña;
        private Panel panel1;
        private Label lblUsuario;
        private PictureBox imgUser;
        private TextBox txbUsuario;
        private Button btnCancelar;
        private Button btnOk;
    }
}
