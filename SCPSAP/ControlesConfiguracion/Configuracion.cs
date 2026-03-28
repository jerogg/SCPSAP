using SCPSAP.ControlesCobranza;
using System;
using System.Windows.Forms;

namespace SCPSAP.ControlesConfiguracion
{
    public partial class Configuracion : UserControl
    {
        
        public Configuracion()
        {
            InitializeComponent();

            pnlTarifas.Controls.Clear();
            Tarifas tarifa = new Tarifas();
            tarifa.Dock = DockStyle.Fill;
            pnlTarifas.Controls.Add(tarifa);

            pnlUsuariosSistema.Controls.Clear();
            UsuariosDeSistema usuariosDeSistema = new UsuariosDeSistema();
            usuariosDeSistema.Dock = DockStyle.Fill;
            pnlUsuariosSistema.Controls.Add(usuariosDeSistema);
        }

    }
}
