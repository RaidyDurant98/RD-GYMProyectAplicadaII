namespace GimnasioTech.UI
{
    partial class FacturasForm
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
            this.SaldogroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RecibidotextBox = new System.Windows.Forms.TextBox();
            this.DevueltatextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MontotextBox = new System.Windows.Forms.TextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.ProductosgroupBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BuscarProductobutton = new System.Windows.Forms.Button();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.CantidadnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.ProductocomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductodataGridView = new System.Windows.Forms.DataGridView();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NombresClientescomboBox = new System.Windows.Forms.ComboBox();
            this.FacturaIdmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClienteerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CantidaderrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ProductoerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.RecibidoerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.GriderrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SaldogroupBox.SuspendLayout();
            this.ProductosgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductodataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidaderrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecibidoerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GriderrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // SaldogroupBox
            // 
            this.SaldogroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaldogroupBox.Controls.Add(this.label6);
            this.SaldogroupBox.Controls.Add(this.label7);
            this.SaldogroupBox.Controls.Add(this.RecibidotextBox);
            this.SaldogroupBox.Controls.Add(this.DevueltatextBox);
            this.SaldogroupBox.Controls.Add(this.label5);
            this.SaldogroupBox.Controls.Add(this.MontotextBox);
            this.SaldogroupBox.Location = new System.Drawing.Point(254, 384);
            this.SaldogroupBox.Name = "SaldogroupBox";
            this.SaldogroupBox.Size = new System.Drawing.Size(421, 93);
            this.SaldogroupBox.TabIndex = 43;
            this.SaldogroupBox.TabStop = false;
            this.SaldogroupBox.Text = "Dinero";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Recibido:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Devuelta:";
            // 
            // RecibidotextBox
            // 
            this.RecibidotextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RecibidotextBox.Location = new System.Drawing.Point(70, 55);
            this.RecibidotextBox.Name = "RecibidotextBox";
            this.RecibidotextBox.Size = new System.Drawing.Size(100, 20);
            this.RecibidotextBox.TabIndex = 13;
            this.RecibidotextBox.TextChanged += new System.EventHandler(this.RecibidotextBox_TextChanged);
            this.RecibidotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RecibidotextBox_KeyPress);
            // 
            // DevueltatextBox
            // 
            this.DevueltatextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DevueltatextBox.Enabled = false;
            this.DevueltatextBox.Location = new System.Drawing.Point(242, 55);
            this.DevueltatextBox.Name = "DevueltatextBox";
            this.DevueltatextBox.Size = new System.Drawing.Size(163, 20);
            this.DevueltatextBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Monto:";
            // 
            // MontotextBox
            // 
            this.MontotextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MontotextBox.Enabled = false;
            this.MontotextBox.Location = new System.Drawing.Point(154, 19);
            this.MontotextBox.Name = "MontotextBox";
            this.MontotextBox.Size = new System.Drawing.Size(163, 20);
            this.MontotextBox.TabIndex = 10;
            this.MontotextBox.TextChanged += new System.EventHandler(this.MontotextBox_TextChanged);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Buscarbutton.Image = global::GimnasioTech.Properties.Resources.Search_25px;
            this.Buscarbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Buscarbutton.Location = new System.Drawing.Point(134, 20);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(40, 31);
            this.Buscarbutton.TabIndex = 42;
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Eliminarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Eliminarbutton.Image = global::GimnasioTech.Properties.Resources.Delete_25px;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Eliminarbutton.Location = new System.Drawing.Point(173, 445);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 32);
            this.Eliminarbutton.TabIndex = 41;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Guardarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guardarbutton.Image = global::GimnasioTech.Properties.Resources.Save_25px;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Guardarbutton.Location = new System.Drawing.Point(92, 445);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 32);
            this.Guardarbutton.TabIndex = 40;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Nuevobutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Nuevobutton.Image = global::GimnasioTech.Properties.Resources.New_Document_25px;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Nuevobutton.Location = new System.Drawing.Point(11, 445);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 32);
            this.Nuevobutton.TabIndex = 39;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // ProductosgroupBox
            // 
            this.ProductosgroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductosgroupBox.Controls.Add(this.label8);
            this.ProductosgroupBox.Controls.Add(this.label4);
            this.ProductosgroupBox.Controls.Add(this.BuscarProductobutton);
            this.ProductosgroupBox.Controls.Add(this.PreciotextBox);
            this.ProductosgroupBox.Controls.Add(this.CantidadnumericUpDown);
            this.ProductosgroupBox.Controls.Add(this.Agregarbutton);
            this.ProductosgroupBox.Controls.Add(this.ProductocomboBox);
            this.ProductosgroupBox.Controls.Add(this.label3);
            this.ProductosgroupBox.Controls.Add(this.ProductodataGridView);
            this.ProductosgroupBox.Location = new System.Drawing.Point(11, 81);
            this.ProductosgroupBox.Name = "ProductosgroupBox";
            this.ProductosgroupBox.Size = new System.Drawing.Size(664, 279);
            this.ProductosgroupBox.TabIndex = 38;
            this.ProductosgroupBox.TabStop = false;
            this.ProductosgroupBox.Text = "Productos";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(439, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Precio:";
            // 
            // BuscarProductobutton
            // 
            this.BuscarProductobutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarProductobutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BuscarProductobutton.Image = global::GimnasioTech.Properties.Resources.Search_25px;
            this.BuscarProductobutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BuscarProductobutton.Location = new System.Drawing.Point(255, 23);
            this.BuscarProductobutton.Name = "BuscarProductobutton";
            this.BuscarProductobutton.Size = new System.Drawing.Size(40, 31);
            this.BuscarProductobutton.TabIndex = 32;
            this.BuscarProductobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarProductobutton.UseVisualStyleBackColor = true;
            this.BuscarProductobutton.Click += new System.EventHandler(this.BuscarProductobutton_Click);
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PreciotextBox.Enabled = false;
            this.PreciotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreciotextBox.Location = new System.Drawing.Point(344, 26);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(80, 26);
            this.PreciotextBox.TabIndex = 10;
            // 
            // CantidadnumericUpDown
            // 
            this.CantidadnumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CantidadnumericUpDown.Location = new System.Drawing.Point(497, 31);
            this.CantidadnumericUpDown.Name = "CantidadnumericUpDown";
            this.CantidadnumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.CantidadnumericUpDown.TabIndex = 9;
            this.CantidadnumericUpDown.ValueChanged += new System.EventHandler(this.CantidadnumericUpDown_ValueChanged);
            this.CantidadnumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantidadnumericUpDown_KeyPress);
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Agregarbutton.Location = new System.Drawing.Point(573, 29);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(75, 23);
            this.Agregarbutton.TabIndex = 8;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // ProductocomboBox
            // 
            this.ProductocomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductocomboBox.FormattingEnabled = true;
            this.ProductocomboBox.Location = new System.Drawing.Point(77, 29);
            this.ProductocomboBox.Name = "ProductocomboBox";
            this.ProductocomboBox.Size = new System.Drawing.Size(160, 21);
            this.ProductocomboBox.TabIndex = 7;
            this.ProductocomboBox.TextChanged += new System.EventHandler(this.ProductocomboBox_TextChanged);
            this.ProductocomboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductocomboBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Productos:";
            // 
            // ProductodataGridView
            // 
            this.ProductodataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductodataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductodataGridView.Location = new System.Drawing.Point(6, 61);
            this.ProductodataGridView.Name = "ProductodataGridView";
            this.ProductodataGridView.Size = new System.Drawing.Size(642, 212);
            this.ProductodataGridView.TabIndex = 0;
            this.ProductodataGridView.SelectionChanged += new System.EventHandler(this.ProductodataGridView_SelectionChanged);
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FechadateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(554, 29);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.FechadateTimePicker.TabIndex = 37;
            // 
            // NombresClientescomboBox
            // 
            this.NombresClientescomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NombresClientescomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NombresClientescomboBox.FormattingEnabled = true;
            this.NombresClientescomboBox.Location = new System.Drawing.Point(88, 54);
            this.NombresClientescomboBox.Name = "NombresClientescomboBox";
            this.NombresClientescomboBox.Size = new System.Drawing.Size(171, 21);
            this.NombresClientescomboBox.TabIndex = 36;
            this.NombresClientescomboBox.TextChanged += new System.EventHandler(this.NombresClientescomboBox_TextChanged);
            // 
            // FacturaIdmaskedTextBox
            // 
            this.FacturaIdmaskedTextBox.Location = new System.Drawing.Point(88, 26);
            this.FacturaIdmaskedTextBox.Mask = "99999";
            this.FacturaIdmaskedTextBox.Name = "FacturaIdmaskedTextBox";
            this.FacturaIdmaskedTextBox.Size = new System.Drawing.Size(40, 20);
            this.FacturaIdmaskedTextBox.TabIndex = 35;
            this.FacturaIdmaskedTextBox.ValidatingType = typeof(int);
            this.FacturaIdmaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FacturaIdmaskedTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Factura Id:";
            // 
            // ClienteerrorProvider
            // 
            this.ClienteerrorProvider.ContainerControl = this;
            // 
            // CantidaderrorProvider
            // 
            this.CantidaderrorProvider.ContainerControl = this;
            // 
            // ProductoerrorProvider
            // 
            this.ProductoerrorProvider.ContainerControl = this;
            // 
            // RecibidoerrorProvider
            // 
            this.RecibidoerrorProvider.ContainerControl = this;
            // 
            // GriderrorProvider
            // 
            this.GriderrorProvider.ContainerControl = this;
            // 
            // FacturasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 496);
            this.Controls.Add(this.SaldogroupBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.ProductosgroupBox);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.NombresClientescomboBox);
            this.Controls.Add(this.FacturaIdmaskedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FacturasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.FacturasForm_Load);
            this.SaldogroupBox.ResumeLayout(false);
            this.SaldogroupBox.PerformLayout();
            this.ProductosgroupBox.ResumeLayout(false);
            this.ProductosgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductodataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidaderrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecibidoerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GriderrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SaldogroupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RecibidotextBox;
        private System.Windows.Forms.TextBox DevueltatextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MontotextBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.GroupBox ProductosgroupBox;
        private System.Windows.Forms.Button BuscarProductobutton;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.NumericUpDown CantidadnumericUpDown;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.ComboBox ProductocomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ProductodataGridView;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.ComboBox NombresClientescomboBox;
        private System.Windows.Forms.MaskedTextBox FacturaIdmaskedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider ClienteerrorProvider;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider CantidaderrorProvider;
        private System.Windows.Forms.ErrorProvider ProductoerrorProvider;
        private System.Windows.Forms.ErrorProvider RecibidoerrorProvider;
        private System.Windows.Forms.ErrorProvider GriderrorProvider;
    }
}