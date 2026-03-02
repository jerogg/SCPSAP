using Negocio.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCPSAP
{
    public partial class Login : Form
    {
        UsuariosNegocio usuario = new UsuariosNegocio();

        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                var result = usuario.ValidaUsuarios(txbUsuario.Text, txbContraseña.Text);

                if(!result)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
                else
                {
                    MenuPrincipal menuPrincipal = new MenuPrincipal();
                    menuPrincipal.Show();
                    this.Hide();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
