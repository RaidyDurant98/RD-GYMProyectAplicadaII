namespace GimnasioTech.UI.Registros
{
    partial class ClientesRegistroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label clienteIdLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label fechaInscripcionLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label numeroCelularLabel;
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.clienteIdMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.sexoComboBox = new System.Windows.Forms.ComboBox();
            this.fechaInscripcionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.numeroCelularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.NombreerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DireccionerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SexoerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.NumeroCelularerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.EmailerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            label1 = new System.Windows.Forms.Label();
            clienteIdLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            fechaInscripcionLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            numeroCelularLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NombreerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DireccionerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SexoerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroCelularerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label1.Location = new System.Drawing.Point(52, 206);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 13);
            label1.TabIndex = 47;
            label1.Text = "Email:";
            // 
            // clienteIdLabel
            // 
            clienteIdLabel.AutoSize = true;
            clienteIdLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            clienteIdLabel.Location = new System.Drawing.Point(52, 49);
            clienteIdLabel.Name = "clienteIdLabel";
            clienteIdLabel.Size = new System.Drawing.Size(54, 13);
            clienteIdLabel.TabIndex = 31;
            clienteIdLabel.Text = "Cliente Id:";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            nombresLabel.Location = new System.Drawing.Point(52, 75);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(52, 13);
            nombresLabel.TabIndex = 33;
            nombresLabel.Text = "Nombres:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            sexoLabel.Location = new System.Drawing.Point(52, 101);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(34, 13);
            sexoLabel.TabIndex = 35;
            sexoLabel.Text = "Sexo:";
            // 
            // fechaInscripcionLabel
            // 
            fechaInscripcionLabel.AutoSize = true;
            fechaInscripcionLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            fechaInscripcionLabel.Location = new System.Drawing.Point(52, 129);
            fechaInscripcionLabel.Name = "fechaInscripcionLabel";
            fechaInscripcionLabel.Size = new System.Drawing.Size(94, 13);
            fechaInscripcionLabel.TabIndex = 37;
            fechaInscripcionLabel.Text = "Fecha Inscripcion:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            direccionLabel.Location = new System.Drawing.Point(52, 154);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 39;
            direccionLabel.Text = "Direccion:";
            // 
            // numeroCelularLabel
            // 
            numeroCelularLabel.AutoSize = true;
            numeroCelularLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            numeroCelularLabel.Location = new System.Drawing.Point(52, 180);
            numeroCelularLabel.Name = "numeroCelularLabel";
            numeroCelularLabel.Size = new System.Drawing.Size(82, 13);
            numeroCelularLabel.TabIndex = 41;
            numeroCelularLabel.Text = "Numero Celular:";
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(153, 203);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(200, 20);
            this.EmailtextBox.TabIndex = 48;
            this.EmailtextBox.TextChanged += new System.EventHandler(this.EmailtextBox_TextChanged);
            // 
            // clienteIdMaskedTextBox
            // 
            this.clienteIdMaskedTextBox.Location = new System.Drawing.Point(153, 46);
            this.clienteIdMaskedTextBox.Mask = "99999";
            this.clienteIdMaskedTextBox.Name = "clienteIdMaskedTextBox";
            this.clienteIdMaskedTextBox.Size = new System.Drawing.Size(39, 20);
            this.clienteIdMaskedTextBox.TabIndex = 32;
            this.clienteIdMaskedTextBox.ValidatingType = typeof(int);
            this.clienteIdMaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clienteIdMaskedTextBox_KeyPress);
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.Location = new System.Drawing.Point(153, 72);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombresTextBox.TabIndex = 34;
            this.nombresTextBox.TextChanged += new System.EventHandler(this.nombresTextBox_TextChanged);
            // 
            // sexoComboBox
            // 
            this.sexoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexoComboBox.FormattingEnabled = true;
            this.sexoComboBox.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.sexoComboBox.Location = new System.Drawing.Point(153, 98);
            this.sexoComboBox.Name = "sexoComboBox";
            this.sexoComboBox.Size = new System.Drawing.Size(200, 21);
            this.sexoComboBox.TabIndex = 36;
            this.sexoComboBox.TextChanged += new System.EventHandler(this.sexoComboBox_TextChanged);
            // 
            // fechaInscripcionDateTimePicker
            // 
            this.fechaInscripcionDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.fechaInscripcionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaInscripcionDateTimePicker.Location = new System.Drawing.Point(153, 125);
            this.fechaInscripcionDateTimePicker.Name = "fechaInscripcionDateTimePicker";
            this.fechaInscripcionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaInscripcionDateTimePicker.TabIndex = 38;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Location = new System.Drawing.Point(153, 151);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(200, 20);
            this.direccionTextBox.TabIndex = 40;
            this.direccionTextBox.TextChanged += new System.EventHandler(this.direccionTextBox_TextChanged);
            // 
            // numeroCelularMaskedTextBox
            // 
            this.numeroCelularMaskedTextBox.Location = new System.Drawing.Point(153, 177);
            this.numeroCelularMaskedTextBox.Mask = "000-000-0000";
            this.numeroCelularMaskedTextBox.Name = "numeroCelularMaskedTextBox";
            this.numeroCelularMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.numeroCelularMaskedTextBox.TabIndex = 42;
            this.numeroCelularMaskedTextBox.TextChanged += new System.EventHandler(this.numeroCelularMaskedTextBox_TextChanged);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Buscarbutton.Image = global::GimnasioTech.Properties.Resources.Search_25px;
            this.Buscarbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Buscarbutton.Location = new System.Drawing.Point(198, 35);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(40, 31);
            this.Buscarbutton.TabIndex = 46;
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Eliminarbutton.Image = global::GimnasioTech.Properties.Resources.Delete_25px;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Eliminarbutton.Location = new System.Drawing.Point(244, 317);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 32);
            this.Eliminarbutton.TabIndex = 45;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guardarbutton.Image = global::GimnasioTech.Properties.Resources.Save_25px;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Guardarbutton.Location = new System.Drawing.Point(163, 317);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 32);
            this.Guardarbutton.TabIndex = 44;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Nuevobutton.Image = global::GimnasioTech.Properties.Resources.New_Document_25px;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Nuevobutton.Location = new System.Drawing.Point(82, 317);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 32);
            this.Nuevobutton.TabIndex = 43;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // NombreerrorProvider
            // 
            this.NombreerrorProvider.ContainerControl = this;
            // 
            // DireccionerrorProvider
            // 
            this.DireccionerrorProvider.ContainerControl = this;
            // 
            // SexoerrorProvider
            // 
            this.SexoerrorProvider.ContainerControl = this;
            // 
            // NumeroCelularerrorProvider
            // 
            this.NumeroCelularerrorProvider.ContainerControl = this;
            // 
            // EmailerrorProvider
            // 
            this.EmailerrorProvider.ContainerControl = this;
            // 
            // ClientesRegistroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 384);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(clienteIdLabel);
            this.Controls.Add(this.clienteIdMaskedTextBox);
            this.Controls.Add(nombresLabel);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(this.sexoComboBox);
            this.Controls.Add(fechaInscripcionLabel);
            this.Controls.Add(this.fechaInscripcionDateTimePicker);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(numeroCelularLabel);
            this.Controls.Add(this.numeroCelularMaskedTextBox);
            this.Name = "ClientesRegistroForm";
            this.Text = "S";
            ((System.ComponentModel.ISupportInitialize)(this.NombreerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DireccionerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SexoerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroCelularerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.MaskedTextBox clienteIdMaskedTextBox;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.ComboBox sexoComboBox;
        private System.Windows.Forms.DateTimePicker fechaInscripcionDateTimePicker;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.MaskedTextBox numeroCelularMaskedTextBox;
        private System.Windows.Forms.ErrorProvider NombreerrorProvider;
        private System.Windows.Forms.ErrorProvider DireccionerrorProvider;
        private System.Windows.Forms.ErrorProvider SexoerrorProvider;
        private System.Windows.Forms.ErrorProvider NumeroCelularerrorProvider;
        private System.Windows.Forms.ErrorProvider EmailerrorProvider;
    }
}