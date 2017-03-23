namespace GimnasioTech.UI.Consultas
{
    partial class UsuariosConsultaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.CampoVacioerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.FiltrarcomboBox = new System.Windows.Forms.ComboBox();
            this.Imprimibutton = new System.Windows.Forms.Button();
            this.Filtrarbutton = new System.Windows.Forms.Button();
            this.FiltrartextBox = new System.Windows.Forms.TextBox();
            this.ConsultadataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CampoVacioerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-140, -79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Elegir opcion:";
            // 
            // CampoVacioerrorProvider
            // 
            this.CampoVacioerrorProvider.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Elegir opcion:";
            // 
            // FiltrarcomboBox
            // 
            this.FiltrarcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrarcomboBox.FormattingEnabled = true;
            this.FiltrarcomboBox.Items.AddRange(new object[] {
            "Todo",
            "Nombre",
            "Cargo"});
            this.FiltrarcomboBox.Location = new System.Drawing.Point(59, 36);
            this.FiltrarcomboBox.Name = "FiltrarcomboBox";
            this.FiltrarcomboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltrarcomboBox.TabIndex = 23;
            this.FiltrarcomboBox.SelectedIndexChanged += new System.EventHandler(this.FiltrarcomboBox_SelectedIndexChanged);
            // 
            // Imprimibutton
            // 
            this.Imprimibutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Imprimibutton.Image = global::GimnasioTech.Properties.Resources.Print_25px;
            this.Imprimibutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Imprimibutton.Location = new System.Drawing.Point(16, 411);
            this.Imprimibutton.Name = "Imprimibutton";
            this.Imprimibutton.Size = new System.Drawing.Size(75, 32);
            this.Imprimibutton.TabIndex = 22;
            this.Imprimibutton.Text = "Imprimir";
            this.Imprimibutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Imprimibutton.UseVisualStyleBackColor = true;
            // 
            // Filtrarbutton
            // 
            this.Filtrarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Filtrarbutton.Image = global::GimnasioTech.Properties.Resources.Search_25px1;
            this.Filtrarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Filtrarbutton.Location = new System.Drawing.Point(499, 33);
            this.Filtrarbutton.Name = "Filtrarbutton";
            this.Filtrarbutton.Size = new System.Drawing.Size(75, 32);
            this.Filtrarbutton.TabIndex = 21;
            this.Filtrarbutton.Text = "Buscar";
            this.Filtrarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Filtrarbutton.UseVisualStyleBackColor = true;
            this.Filtrarbutton.Click += new System.EventHandler(this.Filtrarbutton_Click);
            // 
            // FiltrartextBox
            // 
            this.FiltrartextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltrartextBox.Location = new System.Drawing.Point(202, 36);
            this.FiltrartextBox.Name = "FiltrartextBox";
            this.FiltrartextBox.Size = new System.Drawing.Size(274, 20);
            this.FiltrartextBox.TabIndex = 20;
            this.FiltrartextBox.TextChanged += new System.EventHandler(this.FiltrartextBox_TextChanged);
            this.FiltrartextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FiltrartextBox_KeyPress);
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
            this.ConsultadataGridView.TabIndex = 19;
            // 
            // UsuariosConsultaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FiltrarcomboBox);
            this.Controls.Add(this.Imprimibutton);
            this.Controls.Add(this.Filtrarbutton);
            this.Controls.Add(this.FiltrartextBox);
            this.Controls.Add(this.ConsultadataGridView);
            this.Controls.Add(this.label1);
            this.Name = "UsuariosConsultaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de usuarios";
            this.Load += new System.EventHandler(this.UsuariosConsultaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CampoVacioerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider CampoVacioerrorProvider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FiltrarcomboBox;
        private System.Windows.Forms.Button Imprimibutton;
        private System.Windows.Forms.Button Filtrarbutton;
        private System.Windows.Forms.TextBox FiltrartextBox;
        private System.Windows.Forms.DataGridView ConsultadataGridView;
    }
}