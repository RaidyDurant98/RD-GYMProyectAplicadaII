namespace GimnasioTech.UI
{
    partial class MenuPrincipalForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CambiarusuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.registrosToolStripMenuItem1,
            this.consultasToolStripMenuItem1,
            this.ayudaToolStripMenuItem,
            this.ayudarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(583, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CambiarusuarioToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.registrosToolStripMenuItem.Text = "Archivos";
            // 
            // CambiarusuarioToolStripMenuItem
            // 
            this.CambiarusuarioToolStripMenuItem.Image = global::GimnasioTech.Properties.Resources.Change_User_Male_32;
            this.CambiarusuarioToolStripMenuItem.Name = "CambiarusuarioToolStripMenuItem";
            this.CambiarusuarioToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.CambiarusuarioToolStripMenuItem.Text = "Cambiar usuario";
            this.CambiarusuarioToolStripMenuItem.Click += new System.EventHandler(this.CambiarusuarioToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::GimnasioTech.Properties.Resources.Logout_Rounded_25px;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.consultasToolStripMenuItem.Text = "Editar";
            // 
            // registrosToolStripMenuItem1
            // 
            this.registrosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem1,
            this.clientesToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.registrosToolStripMenuItem1.Name = "registrosToolStripMenuItem1";
            this.registrosToolStripMenuItem1.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem1.Text = "Registros";
            // 
            // usuariosToolStripMenuItem1
            // 
            this.usuariosToolStripMenuItem1.Image = global::GimnasioTech.Properties.Resources.Add_User_Male_32px;
            this.usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            this.usuariosToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.usuariosToolStripMenuItem1.Text = "Usuarios";
            this.usuariosToolStripMenuItem1.Click += new System.EventHandler(this.usuariosToolStripMenuItem1_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = global::GimnasioTech.Properties.Resources.Add_User_Male_32px;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Image = global::GimnasioTech.Properties.Resources.New_Product_32px;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem1
            // 
            this.consultasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.usuariosToolStripMenuItem,
            this.productosToolStripMenuItem1});
            this.consultasToolStripMenuItem1.Name = "consultasToolStripMenuItem1";
            this.consultasToolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem1.Text = "Consultas";
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Image = global::GimnasioTech.Properties.Resources.Checked_User_Male_32px;
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.clientesToolStripMenuItem1.Text = "Usuarios";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = global::GimnasioTech.Properties.Resources.Checked_User_Male_32px;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.usuariosToolStripMenuItem.Text = "Clientes";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem1
            // 
            this.productosToolStripMenuItem1.Image = global::GimnasioTech.Properties.Resources.Inspection_32px;
            this.productosToolStripMenuItem1.Name = "productosToolStripMenuItem1";
            this.productosToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.productosToolStripMenuItem1.Text = "Productos";
            this.productosToolStripMenuItem1.Click += new System.EventHandler(this.productosToolStripMenuItem1_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ayudaToolStripMenuItem.Text = "Factura";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // ayudarToolStripMenuItem
            // 
            this.ayudarToolStripMenuItem.Name = "ayudarToolStripMenuItem";
            this.ayudarToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudarToolStripMenuItem.Text = "Ayuda";
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 376);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MenuPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipalForm_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.MenuPrincipalForm_VisibleChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CambiarusuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudarToolStripMenuItem;
    }
}