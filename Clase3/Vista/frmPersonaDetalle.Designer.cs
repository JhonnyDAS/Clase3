namespace Clase3.Vista
{
    partial class frmPersonaDetalle
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label ciLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label generoLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label fechaNacLabel;
            System.Windows.Forms.Label profesionLabel;
            this.dsPruebaDB = new Clase3.Modelo.dsPruebaDB();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personaTableAdapter = new Clase3.Modelo.dsPruebaDBTableAdapters.PersonaTableAdapter();
            this.tableAdapterManager = new Clase3.Modelo.dsPruebaDBTableAdapters.TableAdapterManager();
            this.ciTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.generoTextBox = new System.Windows.Forms.TextBox();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.profesionTextBox = new System.Windows.Forms.TextBox();
            ciLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            generoLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            fechaNacLabel = new System.Windows.Forms.Label();
            profesionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsPruebaDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(311, 40);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(138, 277);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(219, 277);
            // 
            // dsPruebaDB
            // 
            this.dsPruebaDB.DataSetName = "dsPruebaDB";
            this.dsPruebaDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataMember = "Persona";
            this.personaBindingSource.DataSource = this.dsPruebaDB;
            // 
            // personaTableAdapter
            // 
            this.personaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PersonaTableAdapter = this.personaTableAdapter;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Clase3.Modelo.dsPruebaDBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ciLabel
            // 
            ciLabel.AutoSize = true;
            ciLabel.Location = new System.Drawing.Point(21, 65);
            ciLabel.Name = "ciLabel";
            ciLabel.Size = new System.Drawing.Size(19, 13);
            ciLabel.TabIndex = 4;
            ciLabel.Text = "Ci:";
            // 
            // ciTextBox
            // 
            this.ciTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Ci", true));
            this.ciTextBox.Location = new System.Drawing.Point(90, 62);
            this.ciTextBox.Name = "ciTextBox";
            this.ciTextBox.Size = new System.Drawing.Size(200, 20);
            this.ciTextBox.TabIndex = 5;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(21, 91);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 6;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(90, 88);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 7;
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(21, 117);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 8;
            apellidoLabel.Text = "Apellido:";
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(90, 114);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(200, 20);
            this.apellidoTextBox.TabIndex = 9;
            // 
            // generoLabel
            // 
            generoLabel.AutoSize = true;
            generoLabel.Location = new System.Drawing.Point(21, 143);
            generoLabel.Name = "generoLabel";
            generoLabel.Size = new System.Drawing.Size(45, 13);
            generoLabel.TabIndex = 10;
            generoLabel.Text = "Genero:";
            // 
            // generoTextBox
            // 
            this.generoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Genero", true));
            this.generoTextBox.Location = new System.Drawing.Point(90, 140);
            this.generoTextBox.Name = "generoTextBox";
            this.generoTextBox.Size = new System.Drawing.Size(200, 20);
            this.generoTextBox.TabIndex = 11;
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(21, 169);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(42, 13);
            celularLabel.TabIndex = 12;
            celularLabel.Text = "Celular:";
            // 
            // celularTextBox
            // 
            this.celularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Celular", true));
            this.celularTextBox.Location = new System.Drawing.Point(90, 166);
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(200, 20);
            this.celularTextBox.TabIndex = 13;
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(21, 195);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 14;
            direccionLabel.Text = "Direccion:";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(90, 192);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(200, 20);
            this.direccionTextBox.TabIndex = 15;
            // 
            // fechaNacLabel
            // 
            fechaNacLabel.AutoSize = true;
            fechaNacLabel.Location = new System.Drawing.Point(21, 222);
            fechaNacLabel.Name = "fechaNacLabel";
            fechaNacLabel.Size = new System.Drawing.Size(63, 13);
            fechaNacLabel.TabIndex = 16;
            fechaNacLabel.Text = "Fecha Nac:";
            // 
            // fechaNacDateTimePicker
            // 
            this.fechaNacDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personaBindingSource, "FechaNac", true));
            this.fechaNacDateTimePicker.Location = new System.Drawing.Point(90, 218);
            this.fechaNacDateTimePicker.Name = "fechaNacDateTimePicker";
            this.fechaNacDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaNacDateTimePicker.TabIndex = 17;
            // 
            // profesionLabel
            // 
            profesionLabel.AutoSize = true;
            profesionLabel.Location = new System.Drawing.Point(21, 247);
            profesionLabel.Name = "profesionLabel";
            profesionLabel.Size = new System.Drawing.Size(54, 13);
            profesionLabel.TabIndex = 18;
            profesionLabel.Text = "Profesion:";
            // 
            // profesionTextBox
            // 
            this.profesionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Profesion", true));
            this.profesionTextBox.Location = new System.Drawing.Point(90, 244);
            this.profesionTextBox.Name = "profesionTextBox";
            this.profesionTextBox.Size = new System.Drawing.Size(200, 20);
            this.profesionTextBox.TabIndex = 19;
            // 
            // frmPersonaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(311, 312);
            this.Controls.Add(ciLabel);
            this.Controls.Add(this.ciTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(generoLabel);
            this.Controls.Add(this.generoTextBox);
            this.Controls.Add(celularLabel);
            this.Controls.Add(this.celularTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(fechaNacLabel);
            this.Controls.Add(this.fechaNacDateTimePicker);
            this.Controls.Add(profesionLabel);
            this.Controls.Add(this.profesionTextBox);
            this.Name = "frmPersonaDetalle";
            this.Load += new System.EventHandler(this.frmPersonaDetalle_Load);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.profesionTextBox, 0);
            this.Controls.SetChildIndex(profesionLabel, 0);
            this.Controls.SetChildIndex(this.fechaNacDateTimePicker, 0);
            this.Controls.SetChildIndex(fechaNacLabel, 0);
            this.Controls.SetChildIndex(this.direccionTextBox, 0);
            this.Controls.SetChildIndex(direccionLabel, 0);
            this.Controls.SetChildIndex(this.celularTextBox, 0);
            this.Controls.SetChildIndex(celularLabel, 0);
            this.Controls.SetChildIndex(this.generoTextBox, 0);
            this.Controls.SetChildIndex(generoLabel, 0);
            this.Controls.SetChildIndex(this.apellidoTextBox, 0);
            this.Controls.SetChildIndex(apellidoLabel, 0);
            this.Controls.SetChildIndex(this.nombreTextBox, 0);
            this.Controls.SetChildIndex(nombreLabel, 0);
            this.Controls.SetChildIndex(this.ciTextBox, 0);
            this.Controls.SetChildIndex(ciLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dsPruebaDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Modelo.dsPruebaDB dsPruebaDB;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private Modelo.dsPruebaDBTableAdapters.PersonaTableAdapter personaTableAdapter;
        private Modelo.dsPruebaDBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox ciTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox generoTextBox;
        private System.Windows.Forms.TextBox celularTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.DateTimePicker fechaNacDateTimePicker;
        private System.Windows.Forms.TextBox profesionTextBox;
    }
}
