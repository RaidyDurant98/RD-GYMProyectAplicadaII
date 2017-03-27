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
    public partial class FacturasReporteForm : Form
    {
        public List<Entidades.Facturas> Lista { get; set; }

        public FacturasReporteForm(List<Entidades.Facturas> lista)
        {
            InitializeComponent();
            Lista = lista;
        }

        private void FacturasReporteForm_Load(object sender, EventArgs e)
        {
            this.FacturareportViewer.Reset();
            this.FacturareportViewer.ProcessingMode = ProcessingMode.Local;
            this.FacturareportViewer.LocalReport.ReportPath = @"C:\Users\raidy\Desktop\UCNE\PROGRAMACION APLICADA I\ProyectoMejor\RD-GYM\GimnasioTech\UI\Reportes\FacturasReport.rdlc";

            ReportDataSource source = new ReportDataSource("FacturasDataSet", Lista);
            this.FacturareportViewer.LocalReport.DataSources.Add(source);
            this.FacturareportViewer.RefreshReport();
        }
    }
}
