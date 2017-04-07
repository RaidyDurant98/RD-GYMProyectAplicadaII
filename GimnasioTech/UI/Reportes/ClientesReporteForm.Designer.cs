namespace GimnasioTech.UI.Reportes
{
    partial class ClientesReporteForm
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
            this.ClientesreportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ClientesreportViewer
            // 
            this.ClientesreportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientesreportViewer.Location = new System.Drawing.Point(0, 0);
            this.ClientesreportViewer.Name = "ClientesreportViewer";
            this.ClientesreportViewer.Size = new System.Drawing.Size(771, 333);
            this.ClientesreportViewer.TabIndex = 0;
            // 
            // ClientesReporteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 333);
            this.Controls.Add(this.ClientesreportViewer);
            this.Name = "ClientesReporteForm";
            this.Text = "Reporte de clientes";
            this.Load += new System.EventHandler(this.ClientesReporteForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ClientesreportViewer;
    }
}