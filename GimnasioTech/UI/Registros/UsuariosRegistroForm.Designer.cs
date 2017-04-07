namespace GimnasioTech.UI.Registros
{
    partial class UsuariosRegistroForm
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
            System.Windows.Forms.Label usuarioIdLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label nombreUsuarioLabel;
            System.Windows.Forms.Label claveLabel;
            System.Windows.Forms.Label confirmarClaveLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosRegistroForm));
            this.CargoscomboBox = new System.Windows.Forms.ComboBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.usuarioIdMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.nombreUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.NombreserrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.NombreUsuarioerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ClaveerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ConfirmarClaveerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CargoerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.confirmarClaveTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            usuarioIdLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            nombreUsuarioLabel = new System.Windows.Forms.Label();
            claveLabel = new System.Windows.Forms.Label();
            confirmarClaveLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NombreserrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreUsuarioerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClaveerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmarClaveerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CargoerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(49, 185);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(43, 13);
            label1.TabIndex = 48;
            label1.Text = "Cargos:";
            // 
            // usuarioIdLabel
            // 
            usuarioIdLabel.AutoSize = true;
            usuarioIdLabel.Location = new System.Drawing.Point(49, 50);
            usuarioIdLabel.Name = "usuarioIdLabel";
            usuarioIdLabel.Size = new System.Drawing.Size(58, 13);
            usuarioIdLabel.TabIndex = 34;
            usuarioIdLabel.Text = "Usuario Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(49, 78);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(52, 13);
            nombreLabel.TabIndex = 36;
            nombreLabel.Text = "Nombres:";
            // 
            // nombreUsuarioLabel
            // 
            nombreUsuarioLabel.AutoSize = true;
            nombreUsuarioLabel.Location = new System.Drawing.Point(49, 107);
            nombreUsuarioLabel.Name = "nombreUsuarioLabel";
            nombreUsuarioLabel.Size = new System.Drawing.Size(86, 13);
            nombreUsuarioLabel.TabIndex = 38;
            nombreUsuarioLabel.Text = "Nombre Usuario:";
            // 
            // claveLabel
            // 
            claveLabel.AutoSize = true;
            claveLabel.Location = new System.Drawing.Point(49, 133);
            claveLabel.Name = "claveLabel";
            claveLabel.Size = new System.Drawing.Size(37, 13);
            claveLabel.TabIndex = 40;
            claveLabel.Text = "Clave:";
            // 
            // confirmarClaveLabel
            // 
            confirmarClaveLabel.AutoSize = true;
            confirmarClaveLabel.Location = new System.Drawing.Point(49, 159);
            confirmarClaveLabel.Name = "confirmarClaveLabel";
            confirmarClaveLabel.Size = new System.Drawing.Size(84, 13);
            confirmarClaveLabel.TabIndex = 42;
            confirmarClaveLabel.Text = "Confirmar Clave:";
            // 
            // CargoscomboBox
            // 
            this.CargoscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CargoscomboBox.FormattingEnabled = true;
            this.CargoscomboBox.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.CargoscomboBox.Location = new System.Drawing.Point(156, 182);
            this.CargoscomboBox.Name = "CargoscomboBox";
            this.CargoscomboBox.Size = new System.Drawing.Size(200, 21);
            this.CargoscomboBox.TabIndex = 5;
            this.CargoscomboBox.TextChanged += new System.EventHandler(this.CargoscomboBox_TextChanged);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::GimnasioTech.Properties.Resources.Search_25px1;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(199, 35);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 32);
            this.Buscarbutton.TabIndex = 47;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::GimnasioTech.Properties.Resources.Delete_25px1;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(247, 273);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 32);
            this.Eliminarbutton.TabIndex = 46;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::GimnasioTech.Properties.Resources.Save_50px;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.Location = new System.Drawing.Point(166, 273);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 32);
            this.Guardarbutton.TabIndex = 45;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::GimnasioTech.Properties.Resources.New_File_25px;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(85, 273);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 32);
            this.Nuevobutton.TabIndex = 44;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // usuarioIdMaskedTextBox
            // 
            this.usuarioIdMaskedTextBox.Location = new System.Drawing.Point(156, 47);
            this.usuarioIdMaskedTextBox.Mask = "99999";
            this.usuarioIdMaskedTextBox.Name = "usuarioIdMaskedTextBox";
            this.usuarioIdMaskedTextBox.Size = new System.Drawing.Size(37, 20);
            this.usuarioIdMaskedTextBox.TabIndex = 0;
            this.usuarioIdMaskedTextBox.ValidatingType = typeof(int);
            this.usuarioIdMaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usuarioIdMaskedTextBox_KeyPress);
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.Location = new System.Drawing.Point(156, 75);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombresTextBox.TabIndex = 1;
            this.nombresTextBox.TextChanged += new System.EventHandler(this.nombresTextBox_TextChanged);
            // 
            // nombreUsuarioTextBox
            // 
            this.nombreUsuarioTextBox.Location = new System.Drawing.Point(156, 104);
            this.nombreUsuarioTextBox.Name = "nombreUsuarioTextBox";
            this.nombreUsuarioTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreUsuarioTextBox.TabIndex = 2;
            this.nombreUsuarioTextBox.TextChanged += new System.EventHandler(this.nombreUsuarioTextBox_TextChanged);
            // 
            // claveTextBox
            // 
            this.claveTextBox.Location = new System.Drawing.Point(156, 130);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.Size = new System.Drawing.Size(200, 20);
            this.claveTextBox.TabIndex = 3;
            this.claveTextBox.TextChanged += new System.EventHandler(this.claveTextBox_TextChanged);
            // 
            // NombreserrorProvider
            // 
            this.NombreserrorProvider.ContainerControl = this;
            // 
            // NombreUsuarioerrorProvider
            // 
            this.NombreUsuarioerrorProvider.ContainerControl = this;
            // 
            // ClaveerrorProvider
            // 
            this.ClaveerrorProvider.ContainerControl = this;
            // 
            // ConfirmarClaveerrorProvider
            // 
            this.ConfirmarClaveerrorProvider.ContainerControl = this;
            // 
            // CargoerrorProvider
            // 
            this.CargoerrorProvider.ContainerControl = this;
            // 
            // confirmarClaveTextBox
            // 
            this.confirmarClaveTextBox.Location = new System.Drawing.Point(156, 156);
            this.confirmarClaveTextBox.Name = "confirmarClaveTextBox";
            this.confirmarClaveTextBox.Size = new System.Drawing.Size(200, 20);
            this.confirmarClaveTextBox.TabIndex = 4;
            this.confirmarClaveTextBox.TextChanged += new System.EventHandler(this.confirmarClaveTextBox_TextChanged);
            // 
            // UsuariosRegistroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(405, 347);
            this.Controls.Add(this.confirmarClaveTextBox);
            this.Controls.Add(this.CargoscomboBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(usuarioIdLabel);
            this.Controls.Add(this.usuarioIdMaskedTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(nombreUsuarioLabel);
            this.Controls.Add(this.nombreUsuarioTextBox);
            this.Controls.Add(claveLabel);
            this.Controls.Add(this.claveTextBox);
            this.Controls.Add(confirmarClaveLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UsuariosRegistroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.NombreserrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreUsuarioerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClaveerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmarClaveerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CargoerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CargoscomboBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.MaskedTextBox usuarioIdMaskedTextBox;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.TextBox nombreUsuarioTextBox;
        private System.Windows.Forms.TextBox claveTextBox;
        private System.Windows.Forms.ErrorProvider NombreserrorProvider;
        private System.Windows.Forms.ErrorProvider NombreUsuarioerrorProvider;
        private System.Windows.Forms.ErrorProvider ClaveerrorProvider;
        private System.Windows.Forms.ErrorProvider ConfirmarClaveerrorProvider;
        private System.Windows.Forms.ErrorProvider CargoerrorProvider;
        private System.Windows.Forms.TextBox confirmarClaveTextBox;
    }
}