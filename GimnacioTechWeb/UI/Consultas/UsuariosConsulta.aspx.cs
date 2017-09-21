using GimnasioTech;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GimnacioTechWeb.Consultas
{
    public partial class UsuariosConsulta : System.Web.UI.Page
    {
        public List<Entidades.Usuarios> Lista { get; set; }
        public Entidades.Usuarios Usuario;

        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario = new Entidades.Usuarios();
            AlertInfoPanel.Visible = false;

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
                    Lista = BLL.UsuariosBLL.GetList(p => p.FechaIngreso >= Convert.ToDateTime(FechaDesdeTextBox.Text) && p.FechaIngreso <= Convert.ToDateTime(FechaHastaTextBox.Text));
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
            if (string.IsNullOrEmpty(FiltroTextBox.Text) && FiltrarDropDownList.SelectedIndex != 0 && FiltrarDropDownList.SelectedIndex != 4)
            {
                UsuariosConsultaGridView.DataBind();
                AlertInfoLabel.Text = "Por favor digite el dato a filtrar.";
                AlertInfoPanel.Visible = true;
            }
            else
            {
                Filtrar();
            }
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            GridViewRow row = UsuariosConsultaGridView.SelectedRow;
            int fila = Convert.ToInt32(row);

            string valor = UsuariosConsultaGridView.Rows[fila].Cells[0].Text;
            int id = Convert.ToInt32(valor);

            Usuario = BLL.UsuariosBLL.Buscar(U => U.UsuarioId == id);
            BLL.UsuariosBLL.Eliminar(Usuario);

            Lista = BLL.UsuariosBLL.GetListAll();
            UsuariosConsultaGridView.DataSource = Lista;
            UsuariosConsultaGridView.DataBind();
        }

        protected void ModificarButton_Click(object sender, EventArgs e)
        {

        }
    }
}