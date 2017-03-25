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
    public partial class UsuariosReporteForm : Form
    {
        public List<Entidades.Usuarios> Lista { get; set; }

        public UsuariosReporteForm(List<Entidades.Usuarios> lista)
        {
            InitializeComponent();
            Lista = lista;
        }

        private void UsuariosReporteForm_Load(object sender, EventArgs e)
        {
            this.UsuariosreportViewer.Reset();
            this.UsuariosreportViewer.ProcessingMode = ProcessingMode.Local;
            this.UsuariosreportViewer.LocalReport.ReportPath = @"C:\Users\raidy\Desktop\UCNE\PROGRAMACION APLICADA I\ProyectoMejor\RD-GYM\GimnasioTech\UI\Reportes\UsuariosReport.rdlc";

            ReportDataSource source = new ReportDataSource("UsuariosDataSet", Lista);
            this.UsuariosreportViewer.LocalReport.DataSources.Add(source);
            this.UsuariosreportViewer.RefreshReport();
        }
    }
}
