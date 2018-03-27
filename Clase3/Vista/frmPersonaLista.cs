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
    public partial class frmPersonaLista : Form
    {
        public frmPersonaLista()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmPersonaLista_Load(object sender, EventArgs e)
        {
            this.personaTableAdapter.Fill(this.dsPruebaDB.Persona);
            this.WindowState = FormWindowState.Maximized;
            this.ControlBox = false;
        }
    }
}
