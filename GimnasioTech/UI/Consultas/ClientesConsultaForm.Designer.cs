namespace GimnasioTech.UI.Consultas
{
    partial class ClientesConsultaForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ConsultarcomboBox = new System.Windows.Forms.ComboBox();
            this.ConsultartextBox = new System.Windows.Forms.TextBox();
            this.ConsultadataGridView = new System.Windows.Forms.DataGridView();
            this.CampoVacioerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CampoVacioerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Hasta:";
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HastadateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(338, 79);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(102, 20);
            this.HastadateTimePicker.TabIndex = 28;
            this.HastadateTimePicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HastadateTimePicker_KeyPress);
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(171, 79);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(102, 20);
            this.DesdedateTimePicker.TabIndex = 27;
            this.DesdedateTimePicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DesdedateTimePicker_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Elegir opcion:";
            // 
            // ConsultarcomboBox
            // 
            this.ConsultarcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConsultarcomboBox.FormattingEnabled = true;
            this.ConsultarcomboBox.Items.AddRange(new object[] {
            "Todo",
            "Id",
            "Nombre",
            "Sexo",
            "Fecha Inscripcion",
            "Direccion"});
            this.ConsultarcomboBox.Location = new System.Drawing.Point(59, 36);
            this.ConsultarcomboBox.Name = "ConsultarcomboBox";
            this.ConsultarcomboBox.Size = new System.Drawing.Size(121, 21);
            this.ConsultarcomboBox.TabIndex = 25;
            this.ConsultarcomboBox.SelectedIndexChanged += new System.EventHandler(this.ConsultarcomboBox_SelectedIndexChanged);
            // 
            // ConsultartextBox
            // 
            this.ConsultartextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultartextBox.Location = new System.Drawing.Point(202, 36);
            this.ConsultartextBox.Name = "ConsultartextBox";
            this.ConsultartextBox.Size = new System.Drawing.Size(274, 20);
            this.ConsultartextBox.TabIndex = 22;
            this.ConsultartextBox.TextChanged += new System.EventHandler(this.ConsultartextBox_TextChanged);
            this.ConsultartextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConsultartextBox_KeyPress);
            // 
            // ConsultadataGridView
            // 
            this.ConsultadataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultadataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConsultadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultadataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.ConsultadataGridView.Location = new System.Drawing.Point(10, 115);
            this.ConsultadataGridView.Name = "ConsultadataGridView";
            this.ConsultadataGridView.Size = new System.Drawing.Size(564, 268);
            this.ConsultadataGridView.TabIndex = 21;
            // 
            // CampoVacioerrorProvider
            // 
            this.CampoVacioerrorProvider.ContainerControl = this;
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Imprimirbutton.Image = global::GimnasioTech.Properties.Resources.Print_25px;
            this.Imprimirbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Imprimirbutton.Location = new System.Drawing.Point(16, 411);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(75, 32);
            this.Imprimirbutton.TabIndex = 24;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            this.Imprimirbutton.Click += new System.EventHandler(this.Imprimirbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Buscarbutton.Image = global::GimnasioTech.Properties.Resources.Search_25px1;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(499, 29);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 32);
            this.Buscarbutton.TabIndex = 23;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // ClientesConsultaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.DesdedateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConsultarcomboBox);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.ConsultartextBox);
            this.Controls.Add(this.ConsultadataGridView);
            this.Name = "ClientesConsultaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de clientes";
            this.Load += new System.EventHandler(this.ClientesConsultaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CampoVacioerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ConsultarcomboBox;
        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox ConsultartextBox;
        private System.Windows.Forms.DataGridView ConsultadataGridView;
        private System.Windows.Forms.ErrorProvider CampoVacioerrorProvider;
    }
}