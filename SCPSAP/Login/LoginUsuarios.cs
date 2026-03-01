using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SCPSAP_Presentacion.Login
{
    public partial class LoginUsuarios : Form
{
    public LoginUsuarios()
    {
        InitializeComponent();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        Close();
    }
}
}
