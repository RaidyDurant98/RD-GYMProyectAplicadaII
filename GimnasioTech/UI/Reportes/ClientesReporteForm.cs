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
    public partial class ClientesReporteForm : Form
    {
        public List<Entidades.Clientes> Lista { get; set; }

        public ClientesReporteForm(List<Entidades.Clientes> lista)
        {
            InitializeComponent();
            Lista = lista;
        }

        private void ClientesReporteForm_Load(object sender, EventArgs e)
        {
            this.ClientesreportViewer.Reset();
            this.ClientesreportViewer.ProcessingMode = ProcessingMode.Local;
            this.ClientesreportViewer.LocalReport.ReportPath = @"C:\Users\raidy\Desktop\UCNE\PROGRAMACION APLICADA I\ProyectoMejor\RD-GYM\GimnasioTech\UI\Reportes\ClientesReport.rdlc";

            ReportDataSource source = new ReportDataSource("ClientesDataSet", Lista);
            this.ClientesreportViewer.LocalReport.DataSources.Add(source);
            this.ClientesreportViewer.RefreshReport();
        }
    }
}
