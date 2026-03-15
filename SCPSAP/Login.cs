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
                var usuarioId = usuario.ValidaUsuarios(txbUsuario.Text, txbContraseña.Text);

                if(usuarioId == 0)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
                else
                {
                    Session.Set(usuarioId, txbUsuario.Text); // Establecer datos de sesión
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

namespace SCPSAP
{
    /// <summary>
    /// Gestor de sesión simple para la aplicación WinForms.
    /// Almacena valores globales accesibles desde cualquier parte de la aplicación.
    /// </summary>
    public static class Session
    {
        /// <summary>Id del usuario autenticado (0 = no autenticado).</summary>
        public static int UsuarioId { get; private set; }

        /// <summary>Nombre de usuario (opcional).</summary>
        public static string NombreUsuario { get; private set; }

        /// <summary>Establece los datos de sesión.</summary>
        public static void Set(int usuarioId, string nombreUsuario = null)
        {
            UsuarioId = usuarioId;
            NombreUsuario = nombreUsuario;
        }

        /// <summary>Limpia la sesión actual.</summary>
        public static void Clear()
        {
            UsuarioId = 0;
            NombreUsuario = null;
        }
    }
}
