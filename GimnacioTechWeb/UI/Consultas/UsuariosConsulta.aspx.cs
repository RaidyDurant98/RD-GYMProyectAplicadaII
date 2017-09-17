using GimnasioTech;
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
        public List<Entidades.Usuarios> Lista { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Lista = BLL.UsuariosBLL.GetListAll();
                UsuariosConsultaGridView.DataSource = Lista;
                UsuariosConsultaGridView.DataBind();
            }
        }

        public UsuariosConsulta()
        {

        }

        private void Filtrar()
        {
            if (FiltrarDropDownList.SelectedIndex == 0)
            {
                Lista = BLL.UsuariosBLL.GetListAll();
            }
            else if (FiltrarDropDownList.SelectedIndex != 0)
            {
                if (FiltrarDropDownList.SelectedIndex == 2)
                {
                    Lista = BLL.UsuariosBLL.GetList(p => p.Nombres == FiltroTextBox.Text);
                }
                if (FiltrarDropDownList.SelectedIndex == 3)
                {
                    Lista = BLL.UsuariosBLL.GetList(p => p.NombreUsuario == FiltroTextBox.Text);
                }
                if (FiltrarDropDownList.SelectedIndex == 4)
                {
                    Lista = BLL.UsuariosBLL.GetList(p => p.FechaIngreso.Date >= Convert.ToDateTime(FechaDesdeTextBox.Text) && p.FechaIngreso.Date <= Convert.ToDateTime(FechaHastaTextBox.Text));
                }
                if (FiltrarDropDownList.SelectedIndex == 5)
                {
                    Lista = BLL.UsuariosBLL.GetList(p => p.Cargo == FiltroTextBox.Text);
                }
                if (FiltrarDropDownList.SelectedIndex == 1)
                {
                    int id = Utilidades.TOINT(FiltroTextBox.Text);
                    Lista = BLL.UsuariosBLL.GetList(p => p.UsuarioId == id);
                }
            }
            UsuariosConsultaGridView.DataSource = Lista;
            UsuariosConsultaGridView.DataBind();
        }

        protected void FiltroButton_Click(object sender, EventArgs e)
        {
            Filtrar();
        }
    }
}