using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clase3.Vista
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarVentana();
            frmPersonaLista ventanaPersona = new frmPersonaLista();
            ventanaPersona.MdiParent = this;

            ventanaPersona.Show();
        }

        private void CerrarVentana()
        {
            if(this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
        }
    }
}
