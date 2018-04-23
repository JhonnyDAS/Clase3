using Clase3.Controlador;
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
        Persona _objPersona = new Persona();
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
            this.personaBindingSource.DataSource = _objPersona.Listar(txtBuscar.Text);
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

                    case "gEliminar":
                        if (DialogResult.OK == MessageBox.Show("¿Está seguro de eliminar este registro?", "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                            _objPersona.Eliminar(ci);

                        Listar();
                        break;
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
