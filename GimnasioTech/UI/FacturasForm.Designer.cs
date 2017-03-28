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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturasForm));
            this.SaldogroupBox = new System.Windows.Forms.GroupBox();
            this.Devueltabutton = new System.Windows.Forms.Button();
            this.RecibidomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DevueltatextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MontotextBox = new System.Windows.Forms.TextBox();
            this.ProductosgroupBox = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DescripcionProductotextBox = new System.Windows.Forms.TextBox();
            this.ProductoIdmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BuscarProductobutton = new System.Windows.Forms.Button();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.CantidadnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.ProductodataGridView = new System.Windows.Forms.DataGridView();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FacturaIdmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreClienteerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CantidaderrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ProductoerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.RecibidoerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.GriderrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.NombreClientetextBox = new System.Windows.Forms.TextBox();
            this.ClienteIdmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ClienteIderrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.FacturaIderrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DevueltaerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.NombreUsuariolabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BuscarClientebutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.RegistroClientebutton = new System.Windows.Forms.Button();
            this.SaldogroupBox.SuspendLayout();
            this.ProductosgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductodataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreClienteerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidaderrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecibidoerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GriderrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteIderrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaIderrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DevueltaerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // SaldogroupBox
            // 
            this.SaldogroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaldogroupBox.Controls.Add(this.Devueltabutton);
            this.SaldogroupBox.Controls.Add(this.RecibidomaskedTextBox);
            this.SaldogroupBox.Controls.Add(this.label6);
            this.SaldogroupBox.Controls.Add(this.label7);
            this.SaldogroupBox.Controls.Add(this.DevueltatextBox);
            this.SaldogroupBox.Controls.Add(this.label5);
            this.SaldogroupBox.Controls.Add(this.MontotextBox);
            this.SaldogroupBox.Location = new System.Drawing.Point(254, 384);
            this.SaldogroupBox.Name = "SaldogroupBox";
            this.SaldogroupBox.Size = new System.Drawing.Size(496, 93);
            this.SaldogroupBox.TabIndex = 43;
            this.SaldogroupBox.TabStop = false;
            this.SaldogroupBox.Text = "Dinero";
            // 
            // Devueltabutton
            // 
            this.Devueltabutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Devueltabutton.Image = global::GimnasioTech.Properties.Resources.Calculator_25px;
            this.Devueltabutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Devueltabutton.Location = new System.Drawing.Point(190, 46);
            this.Devueltabutton.Name = "Devueltabutton";
            this.Devueltabutton.Size = new System.Drawing.Size(40, 32);
            this.Devueltabutton.TabIndex = 45;
            this.Devueltabutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Devueltabutton.UseVisualStyleBackColor = true;
            this.Devueltabutton.Click += new System.EventHandler(this.Devueltabutton_Click);
            // 
            // RecibidomaskedTextBox
            // 
            this.RecibidomaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.RecibidomaskedTextBox.Location = new System.Drawing.Point(69, 50);
            this.RecibidomaskedTextBox.Mask = "999999999999";
            this.RecibidomaskedTextBox.Name = "RecibidomaskedTextBox";
            this.RecibidomaskedTextBox.Size = new System.Drawing.Size(100, 26);
            this.RecibidomaskedTextBox.TabIndex = 44;
            this.RecibidomaskedTextBox.TextChanged += new System.EventHandler(this.RecibidomaskedTextBox_TextChanged);
            this.RecibidomaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RecibidomaskedTextBox_KeyPress);
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
            this.label7.Location = new System.Drawing.Point(236, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Devuelta:";
            // 
            // DevueltatextBox
            // 
            this.DevueltatextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DevueltatextBox.Enabled = false;
            this.DevueltatextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.DevueltatextBox.Location = new System.Drawing.Point(295, 50);
            this.DevueltatextBox.Name = "DevueltatextBox";
            this.DevueltatextBox.Size = new System.Drawing.Size(185, 26);
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
            this.MontotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.MontotextBox.Location = new System.Drawing.Point(159, 14);
            this.MontotextBox.Name = "MontotextBox";
            this.MontotextBox.Size = new System.Drawing.Size(238, 26);
            this.MontotextBox.TabIndex = 10;
            this.MontotextBox.TextChanged += new System.EventHandler(this.MontotextBox_TextChanged);
            // 
            // ProductosgroupBox
            // 
            this.ProductosgroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductosgroupBox.Controls.Add(this.label9);
            this.ProductosgroupBox.Controls.Add(this.DescripcionProductotextBox);
            this.ProductosgroupBox.Controls.Add(this.ProductoIdmaskedTextBox);
            this.ProductosgroupBox.Controls.Add(this.label3);
            this.ProductosgroupBox.Controls.Add(this.label8);
            this.ProductosgroupBox.Controls.Add(this.label4);
            this.ProductosgroupBox.Controls.Add(this.BuscarProductobutton);
            this.ProductosgroupBox.Controls.Add(this.PreciotextBox);
            this.ProductosgroupBox.Controls.Add(this.CantidadnumericUpDown);
            this.ProductosgroupBox.Controls.Add(this.Agregarbutton);
            this.ProductosgroupBox.Controls.Add(this.ProductodataGridView);
            this.ProductosgroupBox.Location = new System.Drawing.Point(11, 81);
            this.ProductosgroupBox.Name = "ProductosgroupBox";
            this.ProductosgroupBox.Size = new System.Drawing.Size(739, 279);
            this.ProductosgroupBox.TabIndex = 38;
            this.ProductosgroupBox.TabStop = false;
            this.ProductosgroupBox.Text = "Productos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(181, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Descripcion:";
            // 
            // DescripcionProductotextBox
            // 
            this.DescripcionProductotextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescripcionProductotextBox.Enabled = false;
            this.DescripcionProductotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionProductotextBox.Location = new System.Drawing.Point(253, 31);
            this.DescripcionProductotextBox.MaxLength = 80;
            this.DescripcionProductotextBox.Name = "DescripcionProductotextBox";
            this.DescripcionProductotextBox.Size = new System.Drawing.Size(117, 21);
            this.DescripcionProductotextBox.TabIndex = 39;
            // 
            // ProductoIdmaskedTextBox
            // 
            this.ProductoIdmaskedTextBox.Location = new System.Drawing.Point(77, 32);
            this.ProductoIdmaskedTextBox.Mask = "99999";
            this.ProductoIdmaskedTextBox.Name = "ProductoIdmaskedTextBox";
            this.ProductoIdmaskedTextBox.Size = new System.Drawing.Size(40, 20);
            this.ProductoIdmaskedTextBox.TabIndex = 38;
            this.ProductoIdmaskedTextBox.ValidatingType = typeof(int);
            this.ProductoIdmaskedTextBox.TextChanged += new System.EventHandler(this.ProductoIdmaskedTextBox_TextChanged);
            this.ProductoIdmaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductoIdmaskedTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Producto Id:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(514, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Precio:";
            // 
            // BuscarProductobutton
            // 
            this.BuscarProductobutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BuscarProductobutton.Image = global::GimnasioTech.Properties.Resources.Search_25px1;
            this.BuscarProductobutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BuscarProductobutton.Location = new System.Drawing.Point(135, 23);
            this.BuscarProductobutton.Name = "BuscarProductobutton";
            this.BuscarProductobutton.Size = new System.Drawing.Size(40, 32);
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
            this.PreciotextBox.Location = new System.Drawing.Point(419, 26);
            this.PreciotextBox.MaxLength = 80;
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(80, 26);
            this.PreciotextBox.TabIndex = 10;
            // 
            // CantidadnumericUpDown
            // 
            this.CantidadnumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CantidadnumericUpDown.Location = new System.Drawing.Point(572, 31);
            this.CantidadnumericUpDown.Name = "CantidadnumericUpDown";
            this.CantidadnumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.CantidadnumericUpDown.TabIndex = 9;
            this.CantidadnumericUpDown.ValueChanged += new System.EventHandler(this.CantidadnumericUpDown_ValueChanged);
            this.CantidadnumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantidadnumericUpDown_KeyPress);
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Agregarbutton.Image = global::GimnasioTech.Properties.Resources.Add_25px;
            this.Agregarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Agregarbutton.Location = new System.Drawing.Point(648, 20);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(75, 32);
            this.Agregarbutton.TabIndex = 8;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
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
            this.ProductodataGridView.Size = new System.Drawing.Size(717, 212);
            this.ProductodataGridView.TabIndex = 0;
            this.ProductodataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductodataGridView_CellValueChanged);
            this.ProductodataGridView.SelectionChanged += new System.EventHandler(this.ProductodataGridView_SelectionChanged);
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FechadateTimePicker.CustomFormat = "yyyy/MM/dd          HH:mm:ss";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(566, 29);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(168, 20);
            this.FechadateTimePicker.TabIndex = 37;
            // 
            // FacturaIdmaskedTextBox
            // 
            this.FacturaIdmaskedTextBox.Location = new System.Drawing.Point(88, 26);
            this.FacturaIdmaskedTextBox.Mask = "99999";
            this.FacturaIdmaskedTextBox.Name = "FacturaIdmaskedTextBox";
            this.FacturaIdmaskedTextBox.Size = new System.Drawing.Size(40, 20);
            this.FacturaIdmaskedTextBox.TabIndex = 35;
            this.FacturaIdmaskedTextBox.ValidatingType = typeof(int);
            this.FacturaIdmaskedTextBox.TextChanged += new System.EventHandler(this.FacturaIdmaskedTextBox_TextChanged);
            this.FacturaIdmaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FacturaIdmaskedTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Cliente Id:";
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
            // NombreClienteerrorProvider
            // 
            this.NombreClienteerrorProvider.ContainerControl = this;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(192, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Nombre:";
            // 
            // NombreClientetextBox
            // 
            this.NombreClientetextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NombreClientetextBox.Enabled = false;
            this.NombreClientetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreClientetextBox.Location = new System.Drawing.Point(245, 55);
            this.NombreClientetextBox.MaxLength = 80;
            this.NombreClientetextBox.Name = "NombreClientetextBox";
            this.NombreClientetextBox.Size = new System.Drawing.Size(136, 21);
            this.NombreClientetextBox.TabIndex = 46;
            this.NombreClientetextBox.TextChanged += new System.EventHandler(this.NombreClientetextBox_TextChanged);
            // 
            // ClienteIdmaskedTextBox
            // 
            this.ClienteIdmaskedTextBox.Location = new System.Drawing.Point(88, 56);
            this.ClienteIdmaskedTextBox.Mask = "99999";
            this.ClienteIdmaskedTextBox.Name = "ClienteIdmaskedTextBox";
            this.ClienteIdmaskedTextBox.Size = new System.Drawing.Size(40, 20);
            this.ClienteIdmaskedTextBox.TabIndex = 45;
            this.ClienteIdmaskedTextBox.ValidatingType = typeof(int);
            this.ClienteIdmaskedTextBox.TextChanged += new System.EventHandler(this.ClienteIdmaskedTextBox_TextChanged);
            this.ClienteIdmaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClienteIdmaskedTextBox_KeyPress);
            // 
            // ClienteIderrorProvider
            // 
            this.ClienteIderrorProvider.ContainerControl = this;
            // 
            // FacturaIderrorProvider
            // 
            this.FacturaIderrorProvider.ContainerControl = this;
            // 
            // DevueltaerrorProvider
            // 
            this.DevueltaerrorProvider.ContainerControl = this;
            // 
            // NombreUsuariolabel
            // 
            this.NombreUsuariolabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NombreUsuariolabel.AutoSize = true;
            this.NombreUsuariolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreUsuariolabel.Location = new System.Drawing.Point(70, 464);
            this.NombreUsuariolabel.Name = "NombreUsuariolabel";
            this.NombreUsuariolabel.Size = new System.Drawing.Size(95, 13);
            this.NombreUsuariolabel.TabIndex = 51;
            this.NombreUsuariolabel.Text = "Nombre usuario";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 464);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Le atendio:";
            // 
            // BuscarClientebutton
            // 
            this.BuscarClientebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BuscarClientebutton.Image = global::GimnasioTech.Properties.Resources.Search_25px1;
            this.BuscarClientebutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BuscarClientebutton.Location = new System.Drawing.Point(146, 47);
            this.BuscarClientebutton.Name = "BuscarClientebutton";
            this.BuscarClientebutton.Size = new System.Drawing.Size(40, 32);
            this.BuscarClientebutton.TabIndex = 44;
            this.BuscarClientebutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarClientebutton.UseVisualStyleBackColor = true;
            this.BuscarClientebutton.Click += new System.EventHandler(this.BuscarClientebutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Buscarbutton.Image = global::GimnasioTech.Properties.Resources.Search_25px1;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Buscarbutton.Location = new System.Drawing.Point(143, 14);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 32);
            this.Buscarbutton.TabIndex = 42;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Eliminarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Eliminarbutton.Image = global::GimnasioTech.Properties.Resources.Delete_25px1;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Eliminarbutton.Location = new System.Drawing.Point(169, 406);
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
            this.Guardarbutton.Image = global::GimnasioTech.Properties.Resources.Save_50px;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Guardarbutton.Location = new System.Drawing.Point(88, 406);
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
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Nuevobutton.Location = new System.Drawing.Point(7, 406);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 32);
            this.Nuevobutton.TabIndex = 39;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // RegistroClientebutton
            // 
            this.RegistroClientebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RegistroClientebutton.Image = global::GimnasioTech.Properties.Resources.Plus_50px;
            this.RegistroClientebutton.Location = new System.Drawing.Point(390, 47);
            this.RegistroClientebutton.Name = "RegistroClientebutton";
            this.RegistroClientebutton.Size = new System.Drawing.Size(38, 32);
            this.RegistroClientebutton.TabIndex = 53;
            this.RegistroClientebutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RegistroClientebutton.UseVisualStyleBackColor = true;
            this.RegistroClientebutton.Click += new System.EventHandler(this.RegistroClientebutton_Click);
            // 
            // FacturasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 496);
            this.Controls.Add(this.RegistroClientebutton);
            this.Controls.Add(this.NombreUsuariolabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.NombreClientetextBox);
            this.Controls.Add(this.ClienteIdmaskedTextBox);
            this.Controls.Add(this.BuscarClientebutton);
            this.Controls.Add(this.SaldogroupBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.ProductosgroupBox);
            this.Controls.Add(this.FechadateTimePicker);
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
            ((System.ComponentModel.ISupportInitialize)(this.NombreClienteerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidaderrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecibidoerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GriderrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteIderrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaIderrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DevueltaerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SaldogroupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.DataGridView ProductodataGridView;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.MaskedTextBox FacturaIdmaskedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider NombreClienteerrorProvider;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider CantidaderrorProvider;
        private System.Windows.Forms.ErrorProvider ProductoerrorProvider;
        private System.Windows.Forms.ErrorProvider RecibidoerrorProvider;
        private System.Windows.Forms.ErrorProvider GriderrorProvider;
        private System.Windows.Forms.MaskedTextBox RecibidomaskedTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DescripcionProductotextBox;
        private System.Windows.Forms.MaskedTextBox ProductoIdmaskedTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox NombreClientetextBox;
        private System.Windows.Forms.MaskedTextBox ClienteIdmaskedTextBox;
        private System.Windows.Forms.Button BuscarClientebutton;
        private System.Windows.Forms.ErrorProvider ClienteIderrorProvider;
        private System.Windows.Forms.Button Devueltabutton;
        private System.Windows.Forms.ErrorProvider FacturaIderrorProvider;
        private System.Windows.Forms.ErrorProvider DevueltaerrorProvider;
        private System.Windows.Forms.Label NombreUsuariolabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button RegistroClientebutton;
    }
}