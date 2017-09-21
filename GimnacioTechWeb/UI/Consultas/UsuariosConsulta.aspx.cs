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
            AlertSuccessPanel.Visible = false;
            AlertDangerPanel.Visible = false;

            if (!Page.IsPostBack)
            {
                Lista = BLL.UsuariosBLL.GetListAll();
                CargarListaUsuario();
            }
        }

        private void CargarListaUsuario()
        {
            UsuariosConsultaGridView.DataSource = Lista;
            UsuariosConsultaGridView.DataBind();
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
                    DateTime FechaDesde = Convert.ToDateTime(FechaDesdeTextBox.Text);
                    DateTime FechaHasta = Convert.ToDateTime(FechaHastaTextBox.Text);
                    Lista = BLL.UsuariosBLL.GetList(p => p.FechaIngreso >= FechaDesde.Date && p.FechaIngreso <= FechaHasta.Date);
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
            CargarListaUsuario();
        }

        protected void FiltroButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FiltroTextBox.Text) && FiltrarDropDownList.SelectedIndex != 0 && FiltrarDropDownList.SelectedIndex != 4)
            {
                UsuariosConsultaGridView.DataBind();
                AlertInfoLabel.Text = "Por favor digite el dato que desea filtrar.";
                AlertInfoPanel.Visible = true;
            }
            else if(FiltrarDropDownList.SelectedIndex == 4 && string.IsNullOrEmpty(FechaDesdeTextBox.Text) || string.IsNullOrEmpty(FechaHastaTextBox.Text))
            {
                UsuariosConsultaGridView.DataBind();
                AlertInfoLabel.Text = "Por favor eliga el rango de fecha que desea filtrar.";
                AlertInfoPanel.Visible = true;
            }
            else
            {
                Filtrar();
            }
        }

        protected void UsuariosConsultaGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            // Se obtiene la fila seleccionada del gridview
            //
            GridViewRow row = UsuariosConsultaGridView.SelectedRow;

            //
            // Obtengo el id de la entidad que se esta editando
            // en este caso de la entidad Usuario
            //
            int id = Convert.ToInt32(UsuariosConsultaGridView.DataKeys[row.RowIndex].Value);

            Usuario = BLL.UsuariosBLL.Buscar(U => U.UsuarioId == id);
            if (BLL.UsuariosBLL.Eliminar(Usuario))
            {
                AlertSuccessLabel.Text = "Usuario eliminado con exito.";
                AlertSuccessPanel.Visible = true;
            }
            else
            {
                AlertDangerLabel.Text = "No se puedo eliminar el usuario.";
                AlertDangerPanel.Visible = true;
            }

            Lista = BLL.UsuariosBLL.GetListAll();
            CargarListaUsuario();
        }

        protected void EnviarAlModalButton_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "showModal();", true);
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {

        }

        /*protected void UsuariosConsultaGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                //
                // Se obtiene indice de la row seleccionada
                //
                int indice = Convert.ToInt32(e.CommandArgument);
                //
                // Obtengo el id de la entidad que se esta editando
                // en este caso de la entidad Usuario
                //
                int id = Convert.ToInt32(UsuariosConsultaGridView.DataKeys[indice].Value);
            }
        }*/

        /*protected void EliminarButton_Click(object sender, EventArgs e)
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

        }*/
    }
}