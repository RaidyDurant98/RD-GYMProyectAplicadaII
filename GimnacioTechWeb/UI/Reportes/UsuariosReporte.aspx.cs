using GimnacioTechWeb.Consultas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace GimnacioTechWeb.UI.Reportes
{
    public partial class UsuariosReporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UsuariosReportViewer.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
                UsuariosReportViewer.Reset();
                UsuariosReportViewer.LocalReport.ReportPath = @"D:\UCNE\PROGRAMACION APLICADA II\RD-GYM\GimnacioTechWeb\UI\Reportes\UsuariosReporte.rdlc";
                UsuariosReportViewer.LocalReport.DataSources.Clear();

                UsuariosReportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("UsuariosDataSet",
                    UI.UsuariosConsulta.Lista));

                UsuariosReportViewer.LocalReport.Refresh();
            }
        }
    }
}