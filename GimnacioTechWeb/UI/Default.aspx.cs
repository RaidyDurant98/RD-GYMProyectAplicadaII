using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GimnacioTechWeb.UI
{
    public partial class DefaultP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegistroProductoButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductosRegistro.aspx");
        }

        protected void ConsultaProductoButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductosConsulta.aspx");
        }

        protected void RegistroFacturaButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("FacturasRegistro.aspx");
        }

        protected void ConsultaFacturaButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("FacturasConsulta.aspx");
        }

        protected void RegistroClientesButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ClientesRegistro.aspx");
        }

        protected void ConsultaClientesButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ClientesConsulta.aspx");
        }
    }
}