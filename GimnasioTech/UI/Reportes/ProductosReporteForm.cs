using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GimnasioTech.UI.Reportes
{
    public partial class ProductosReporteForm : Form
    {
        public List<Entidades.Productos> Lista { get; set; }

        public ProductosReporteForm(List<Entidades.Productos> lista)
        {
            InitializeComponent();
            Lista = lista;
        }

        private void ProductosReporteForm_Load(object sender, EventArgs e)
        {
            this.ProductosreportViewer.Reset();
            this.ProductosreportViewer.ProcessingMode = ProcessingMode.Local;
            this.ProductosreportViewer.LocalReport.ReportPath = @"C:\Users\raidy\Desktop\UCNE\PROGRAMACION APLICADA I\ProyectoMejor\RD-GYM - copia\GimnasioTech\UI\Reportes\ProductosReport.rdlc";

            ReportDataSource source = new ReportDataSource("ProductosDataSet", Lista);
            this.ProductosreportViewer.LocalReport.DataSources.Add(source);
            this.ProductosreportViewer.RefreshReport();
        }
    }
}
