using GimnasioTech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GimnacioTechWeb.UI
{
    public partial class UsuariosConsulta : System.Web.UI.Page
    {
        public static List<Entidades.Usuarios> Lista { get; set; }
        public static Entidades.Usuarios Usuario = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario = null;
            Limpiar();

            if (!Page.IsPostBack)
            {
                Lista = BLL.UsuariosBLL.GetListAll();
                CargarListaUsuario();
            }

            if (Lista == null || Lista.Count() == 0)
            {
                ImprimirButton.Visible = false;
            }
            else
            {
                ImprimirButton.Visible = true;
            }
        }

        private void Limpiar()
        {
            FiltroTextBox.Text = "";
            FiltrarDropDownList.SelectedIndex = 0;
            FechaDesdeTextBox.Text = "";
            FechaHastaTextBox.Text = "";
        }

        private void CargarListaUsuario()
        {
            UsuariosConsultaGridView.DataSource = Lista;
            UsuariosConsultaGridView.DataBind();
        }

        private void BotonImprimirVisibleSiHayListas()
        {
            if (Lista.Count() != 0)
            {
                ImprimirButton.Visible = true;
            }
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
            if (Lista.Count() == 0)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('No existe usuario');", addScriptTags: true);
                ImprimirButton.Visible = false;
            }
        }

        protected void FiltroButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FiltroTextBox.Text) && FiltrarDropDownList.SelectedIndex != 0 && FiltrarDropDownList.SelectedIndex != 4)
            {
                UsuariosConsultaGridView.DataBind();
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Por favor digite el dato del filtro');", addScriptTags: true);
                ImprimirButton.Visible = false;
            }
            else if (FiltrarDropDownList.SelectedIndex == 4)
            {
                if (string.IsNullOrEmpty(FechaDesdeTextBox.Text) || string.IsNullOrEmpty(FechaHastaTextBox.Text))
                {
                    UsuariosConsultaGridView.DataBind();
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Por favor elige el rango de la fecha');", addScriptTags: true);
                    ImprimirButton.Visible = false;
                }
                else
                {
                    Filtrar();
                    BotonImprimirVisibleSiHayListas();
                }
            }
            else
            {
                ImprimirButton.Visible = false;
                Filtrar();
                BotonImprimirVisibleSiHayListas();
            }
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
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
                Limpiar();

                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Usuario eliminado con exito');", addScriptTags: true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('No se pudo eliminar el usuario');", addScriptTags: true);
            }
            Usuario = null;
            Lista = BLL.UsuariosBLL.GetListAll();
            CargarListaUsuario();
            BotonImprimirVisibleSiHayListas();
        }

        protected void ImprimirButton_Click(object sender, EventArgs e)
        {
            Filtrar();
            Server.Transfer("Reportes/UsuariosReporte.aspx");
        }

        protected void EnviarAlModalEliminarButton_Click(object sender, EventArgs e)
        {
            ImprimirButton.Visible = true;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "#ModalEliminar", "showModalEliminar();", true);
        }

        protected void CancelarEliminacionButton_Click(object sender, EventArgs e)
        {
            ImprimirButton.Visible = true;
        }

        protected void EnviarAlModalModificarButton_Click(object sender, EventArgs e)
        {
            ImprimirButton.Visible = true;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "#ModalModificar", "showModalModificar();", true);
        }

        protected void ModificarButton_Click(object sender, EventArgs e)
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

            Response.Redirect("UsuariosRegistro.aspx");
        }

        protected void CancelarModificacionButton_Click(object sender, EventArgs e)
        {
            ImprimirButton.Visible = true;
        }
    }
}