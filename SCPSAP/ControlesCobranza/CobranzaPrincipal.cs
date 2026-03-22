using CapaUI;
using Datos;
using Negocio.Cobranza;
using Negocio.Contribuyentes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Entidades.Modelos;

namespace SCPSAP.ControlesCobranza
{
    public partial class CobranzaPrincipal : UserControl
    {    
        public CobranzaPrincipal()
        {
            InitializeComponent();

            pnlCobranza.Controls.Clear();
            Cobranza cobranza = new Cobranza();
            cobranza.Dock = DockStyle.Fill;
            pnlCobranza.Controls.Add(cobranza);

            pnlConfigurarAdeudos.Controls.Clear();
            ConfiguraAdeudo configuraAdeudo = new ConfiguraAdeudo();
            configuraAdeudo.Dock = DockStyle.Fill;
            pnlConfigurarAdeudos.Controls.Add(configuraAdeudo);
        }
    }
}
