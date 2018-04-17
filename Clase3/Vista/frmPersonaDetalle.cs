using Clase3.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clase3.Vista
{
    public partial class frmPersonaDetalle : Clase3.Vista.frmPatron
    {
        Persona _objPersona = new Persona();
        bool _esNuevo;
        string _ci;
        public frmPersonaDetalle(string pCi)
        {
            InitializeComponent();
            _ci = pCi;
            _esNuevo = false;
        }
        public frmPersonaDetalle()
        {
            InitializeComponent();
            _esNuevo = true;
        }
        private void frmPersonaDetalle_Load(object sender, EventArgs e)
        {
            if (_esNuevo)
                lblTitulo.Text = "Nueva Persona";
            else
            {
                lblTitulo.Text = "Modificar Persona";
                personaBindingSource.DataSource = _objPersona.BuscarPK(_ci);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(CargarDatos())
            {
                if(_esNuevo)
                {
                    _objPersona.Insertar();
                    MessageBox.Show("Datos Guardados Correctamente");
                    this.Close();
                }
                else
                {
                    _objPersona.Modificar(_ci);
                    MessageBox.Show("Datos Modificados Correctamente");
                    this.Close();
                }
            }
        }

        private bool CargarDatos()
        {
            try
            {
                _objPersona.Ci = ciTextBox.Text;
                _objPersona.Nombre = nombreTextBox.Text;
                _objPersona.Apellido = apellidoTextBox.Text;
                _objPersona.Genero = generoTextBox.Text;
                _objPersona.Celular = Convert.ToInt32(celularTextBox.Text);
                _objPersona.FechaNac = fechaNacDateTimePicker.Value;
                _objPersona.Profesion = profesionTextBox.Text;
                _objPersona.Direccion = direccionTextBox.Text;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
