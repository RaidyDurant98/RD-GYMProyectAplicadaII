namespace GimnasioTech.UI.Reportes
{
    partial class ProductosReporteForm
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
            this.ProductosreportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ProductosreportViewer
            // 
            this.ProductosreportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductosreportViewer.Location = new System.Drawing.Point(0, 0);
            this.ProductosreportViewer.Name = "ProductosreportViewer";
            this.ProductosreportViewer.Size = new System.Drawing.Size(752, 333);
            this.ProductosreportViewer.TabIndex = 0;
            // 
            // ProductosReporteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 333);
            this.Controls.Add(this.ProductosreportViewer);
            this.Name = "ProductosReporteForm";
            this.Text = "Reporte de productos";
            this.Load += new System.EventHandler(this.ProductosReporteForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ProductosreportViewer;
    }
}