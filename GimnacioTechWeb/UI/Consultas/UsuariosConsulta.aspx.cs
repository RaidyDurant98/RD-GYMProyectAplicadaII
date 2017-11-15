 using GimnasioTech;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GimnacioTechWeb.Consultas
{
    public partial class UsuariosConsulta : System.Web.UI.Page
    {
        public static List<Entidades.Usuarios> Lista { get; set; }
        public static Entidades.Usuarios Usuario = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            AlertInfoPanel.Visible = false;
            AlertSuccessPanel.Visible = false;
            AlertDangerPanel.Visible = false;
            Usuario = null;

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

        private void AsignarTextoAlertaInfo(string texto)
        {
            AlertInfoLabel.Text = texto;
            AlertInfoPanel.Visible = true;
        }

        private void AsignarTextoAlertaSuccess(string texto)
        {
            AlertSuccessLabel.Text = texto;
            AlertSuccessPanel.Visible = true;
        }

        private void AsignarTextoAlertaDanger(string texto)
        {
            AlertDangerLabel.Text = texto;
            AlertDangerPanel.Visible = true;
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
            if(Lista.Count() == 0)
            {
                AsignarTextoAlertaInfo("No existe usuario.");
                ImprimirButton.Visible = false;
            }
        }

        protected void FiltroButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FiltroTextBox.Text) && FiltrarDropDownList.SelectedIndex != 0 && FiltrarDropDownList.SelectedIndex != 4)
            {
                UsuariosConsultaGridView.DataBind();
                AsignarTextoAlertaInfo("Por favor digite el dato que desea filtrar.");
                ImprimirButton.Visible = false;
            }
            else if(FiltrarDropDownList.SelectedIndex == 4)
            {
                if (string.IsNullOrEmpty(FechaDesdeTextBox.Text) || string.IsNullOrEmpty(FechaHastaTextBox.Text))
                {
                    UsuariosConsultaGridView.DataBind();
                    AsignarTextoAlertaInfo("Por favor eliga el rango de fecha que desea filtrar.");
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
                FiltroTextBox.Text = "";
                FiltrarDropDownList.Text = "Todo";
                FechaDesdeTextBox.Text = "";
                FechaHastaTextBox.Text = "";

                AsignarTextoAlertaSuccess("Usuario eliminado con exito.");
            }
            else
            {
                AsignarTextoAlertaDanger("No se puedo eliminar el usuario.");
            }
            Usuario = null;
            Lista = BLL.UsuariosBLL.GetListAll();
            CargarListaUsuario();
            BotonImprimirVisibleSiHayListas();
        }

        protected void ImprimirButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Reportes/UsuariosReporte.aspx");
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

            Response.Redirect("../Registros/UsuariosForm.aspx");
        }

        protected void CancelarModificacionButton_Click(object sender, EventArgs e)
        {
            ImprimirButton.Visible = true;
        }

        protected void SingOutButton_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            System.Web.Security.FormsAuthentication.RedirectToLoginPage();
        }
    }
}