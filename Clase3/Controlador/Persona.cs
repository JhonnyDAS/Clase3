using Clase3.Modelo;
using Clase3.Modelo.dsPruebaDBTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clase3.Controlador
{
    class Persona
    {
        dsPruebaDB _ds = new dsPruebaDB();
        PersonaTableAdapter _taPersona = new PersonaTableAdapter();
        #region Campos
        private string ci;

        public string Ci
        {
            get { return ci; }
            set { ci = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        private string genero;

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        private int celular;

        public int Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private DateTime fechaNac;

        public DateTime FechaNac
        {
            get { return fechaNac; }
            set { fechaNac = value; }
        }
        private string profesion;

        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }
        #endregion 
        #region Metodos
        public DataTable Listar()
        {
            return _taPersona.GetData();
        }
        public void Modificar(string pCi)
        {
            try
            {
                _taPersona.Update(
                        Ci,
                        Nombre,
                        Apellido,
                        Genero,
                        Celular,
                        Direccion,
                        FechaNac,
                        Profesion,
                        pCi
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void Insertar()
        {
            try
            {
                _taPersona.Insert(
                    Ci,
                    Nombre,
                    Apellido,
                    Genero,
                    Celular,
                    Direccion,
                    FechaNac,
                    Profesion
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
        public void Eliminar(string pCi)
        {
            try
            {
                _taPersona.Delete(pCi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
        #endregion
    }
}
