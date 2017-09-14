using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GimnacioTechWeb.Consultas
{
    public partial class UsuariosConsulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public UsuariosConsulta()
        {

        }

        protected void UsuarioConsultaButton_Click(object sender, EventArgs e)
        {
            UsuariosConsultaGridView.DataSource = BLL.UsuariosBLL.GetListAll();
            UsuariosConsultaGridView.DataBind();
        }
    }
}