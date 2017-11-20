using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GimnacioTechWeb.UI.Reportes
{
    public partial class ClientesReporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ClientesReportViewer.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
                ClientesReportViewer.Reset();
                ClientesReportViewer.LocalReport.ReportPath = Server.MapPath(@"ClientesReporte.rdlc");
                ClientesReportViewer.LocalReport.DataSources.Clear();

                ClientesReportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("ClientesDataSet",
                    UI.ClientesConsulta.Lista));

                ClientesReportViewer.LocalReport.Refresh();
            }
        }
    }
}