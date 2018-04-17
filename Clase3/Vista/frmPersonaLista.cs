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
            Listar();
            this.WindowState = FormWindowState.Maximized;
            this.ControlBox = false;
        }

        private void Listar()
        {
            this.personaTableAdapter.Fill(this.dsPruebaDB.Persona);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmPersonaDetalle vn = new frmPersonaDetalle();
            vn.ShowDialog();

            Listar();
        }

        private void dgvGrilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                string nomCol = dgvGrilla.CurrentCell.OwningColumn.Name;
                string ci = dgvGrilla.Rows[e.RowIndex].Cells[0].Value.ToString();
                switch (nomCol)
                {
                    case "gEditar":
                        frmPersonaDetalle vn = new frmPersonaDetalle(ci);
                        vn.ShowDialog();

                        Listar();
                        break;
                }
            }
        }
    }
}
