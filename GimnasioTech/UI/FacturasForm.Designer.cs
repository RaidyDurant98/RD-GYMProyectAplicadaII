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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SubTotaltextBox = new System.Windows.Forms.TextBox();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.ProductosgroupBox = new System.Windows.Forms.GroupBox();
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.SaldogroupBox.SuspendLayout();
            this.ProductosgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductodataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // SaldogroupBox
            // 
            this.SaldogroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaldogroupBox.Controls.Add(this.label6);
            this.SaldogroupBox.Controls.Add(this.label7);
            this.SaldogroupBox.Controls.Add(this.textBox1);
            this.SaldogroupBox.Controls.Add(this.textBox2);
            this.SaldogroupBox.Controls.Add(this.label4);
            this.SaldogroupBox.Controls.Add(this.label5);
            this.SaldogroupBox.Controls.Add(this.SubTotaltextBox);
            this.SaldogroupBox.Controls.Add(this.TotaltextBox);
            this.SaldogroupBox.Location = new System.Drawing.Point(267, 384);
            this.SaldogroupBox.Name = "SaldogroupBox";
            this.SaldogroupBox.Size = new System.Drawing.Size(409, 93);
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
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(70, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(242, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 20);
            this.textBox2.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "SubTotal:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total:";
            // 
            // SubTotaltextBox
            // 
            this.SubTotaltextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SubTotaltextBox.Enabled = false;
            this.SubTotaltextBox.Location = new System.Drawing.Point(70, 19);
            this.SubTotaltextBox.Name = "SubTotaltextBox";
            this.SubTotaltextBox.Size = new System.Drawing.Size(100, 20);
            this.SubTotaltextBox.TabIndex = 9;
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotaltextBox.Enabled = false;
            this.TotaltextBox.Location = new System.Drawing.Point(242, 19);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.Size = new System.Drawing.Size(151, 20);
            this.TotaltextBox.TabIndex = 10;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
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
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Eliminarbutton.Location = new System.Drawing.Point(180, 442);
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
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Guardarbutton.Location = new System.Drawing.Point(99, 442);
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
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Nuevobutton.Location = new System.Drawing.Point(18, 442);
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
            this.ProductosgroupBox.Controls.Add(this.BuscarProductobutton);
            this.ProductosgroupBox.Controls.Add(this.PreciotextBox);
            this.ProductosgroupBox.Controls.Add(this.CantidadnumericUpDown);
            this.ProductosgroupBox.Controls.Add(this.Agregarbutton);
            this.ProductosgroupBox.Controls.Add(this.ProductocomboBox);
            this.ProductosgroupBox.Controls.Add(this.label3);
            this.ProductosgroupBox.Controls.Add(this.ProductodataGridView);
            this.ProductosgroupBox.Location = new System.Drawing.Point(11, 81);
            this.ProductosgroupBox.Name = "ProductosgroupBox";
            this.ProductosgroupBox.Size = new System.Drawing.Size(665, 279);
            this.ProductosgroupBox.TabIndex = 38;
            this.ProductosgroupBox.TabStop = false;
            this.ProductosgroupBox.Text = "Productos";
            // 
            // BuscarProductobutton
            // 
            this.BuscarProductobutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarProductobutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BuscarProductobutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BuscarProductobutton.Location = new System.Drawing.Point(255, 24);
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
            this.PreciotextBox.Location = new System.Drawing.Point(314, 30);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(100, 20);
            this.PreciotextBox.TabIndex = 10;
            // 
            // CantidadnumericUpDown
            // 
            this.CantidadnumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CantidadnumericUpDown.Location = new System.Drawing.Point(447, 30);
            this.CantidadnumericUpDown.Name = "CantidadnumericUpDown";
            this.CantidadnumericUpDown.Size = new System.Drawing.Size(73, 20);
            this.CantidadnumericUpDown.TabIndex = 9;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Agregarbutton.Location = new System.Drawing.Point(584, 27);
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
            this.ProductocomboBox.Location = new System.Drawing.Point(77, 30);
            this.ProductocomboBox.Name = "ProductocomboBox";
            this.ProductocomboBox.Size = new System.Drawing.Size(172, 21);
            this.ProductocomboBox.TabIndex = 7;
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
            this.ProductodataGridView.Size = new System.Drawing.Size(653, 212);
            this.ProductodataGridView.TabIndex = 0;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FechadateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(555, 29);
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
            this.NombresClientescomboBox.Size = new System.Drawing.Size(172, 21);
            this.NombresClientescomboBox.TabIndex = 36;
            // 
            // FacturaIdmaskedTextBox
            // 
            this.FacturaIdmaskedTextBox.Location = new System.Drawing.Point(88, 26);
            this.FacturaIdmaskedTextBox.Mask = "99999";
            this.FacturaIdmaskedTextBox.Name = "FacturaIdmaskedTextBox";
            this.FacturaIdmaskedTextBox.Size = new System.Drawing.Size(40, 20);
            this.FacturaIdmaskedTextBox.TabIndex = 35;
            this.FacturaIdmaskedTextBox.ValidatingType = typeof(int);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FacturasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 496);
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
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.FacturasForm_Load);
            this.SaldogroupBox.ResumeLayout(false);
            this.SaldogroupBox.PerformLayout();
            this.ProductosgroupBox.ResumeLayout(false);
            this.ProductosgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductodataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SaldogroupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SubTotaltextBox;
        private System.Windows.Forms.TextBox TotaltextBox;
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}