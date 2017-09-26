using GimnasioTech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GimnacioTechWeb.Consultas
{
    public partial class ClientesConsulta : System.Web.UI.Page
    {
        public static List<Entidades.Clientes> Lista { get; set; }
        public static Entidades.Clientes Cliente = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            AlertInfoPanel.Visible = false;
            AlertSuccessPanel.Visible = false;
            AlertDangerPanel.Visible = false;
            Cliente = null;

            if (!Page.IsPostBack)
            {
                Lista = BLL.ClientesBLL.GetListAll();
                CargarListaCliente();
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

        private void CargarListaCliente()
        {
            ClientesConsultaGridView.DataSource = Lista;
            ClientesConsultaGridView.DataBind();
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
                Lista = BLL.ClientesBLL.GetListAll();
            }
            else if (FiltrarDropDownList.SelectedIndex != 0)
            {
                if (FiltrarDropDownList.SelectedIndex == 2)
                {
                    Lista = BLL.ClientesBLL.GetList(p => p.Nombres == FiltroTextBox.Text);
                }
                if (FiltrarDropDownList.SelectedIndex == 3)
                {
                    Lista = BLL.ClientesBLL.GetList(p => p.Direccion == FiltroTextBox.Text);
                }
                if (FiltrarDropDownList.SelectedIndex == 4)
                {
                    DateTime FechaDesde = Convert.ToDateTime(FechaDesdeTextBox.Text);
                    DateTime FechaHasta = Convert.ToDateTime(FechaHastaTextBox.Text);
                    Lista = BLL.ClientesBLL.GetList(p => p.FechaInscripcion >= FechaDesde.Date && p.FechaInscripcion <= FechaHasta.Date);
                }
                if (FiltrarDropDownList.SelectedIndex == 5)
                {
                    Lista = BLL.ClientesBLL.GetList(p => p.Sexo == FiltroTextBox.Text);
                }
                if (FiltrarDropDownList.SelectedIndex == 1)
                {
                    int id = Utilidades.TOINT(FiltroTextBox.Text);
                    Lista = BLL.ClientesBLL.GetList(p => p.ClienteId == id);
                }
            }
            CargarListaCliente();
            if (Lista.Count() == 0)
            {
                AsignarTextoAlertaInfo("No existe Cliente.");
            }
        }

        protected void FiltroButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FiltroTextBox.Text) && FiltrarDropDownList.SelectedIndex != 0 && FiltrarDropDownList.SelectedIndex != 4)
            {
                ClientesConsultaGridView.DataBind();
                AsignarTextoAlertaInfo("Por favor digite el dato que desea filtrar.");
                ImprimirButton.Visible = false;
            }
            else if (FiltrarDropDownList.SelectedIndex == 4)
            {
                if (string.IsNullOrEmpty(FechaDesdeTextBox.Text) || string.IsNullOrEmpty(FechaHastaTextBox.Text))
                {
                    ClientesConsultaGridView.DataBind();
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
            GridViewRow row = ClientesConsultaGridView.SelectedRow;

            //
            // Obtengo el id de la entidad que se esta editando
            // en este caso de la entidad Usuario
            //
            int id = Convert.ToInt32(ClientesConsultaGridView.DataKeys[row.RowIndex].Value);

            Cliente = BLL.ClientesBLL.Buscar(U => U.ClienteId == id);
            if (BLL.ClientesBLL.Eliminar(Cliente))
            {
                FiltroTextBox.Text = "";
                FiltrarDropDownList.Text = "Todo";
                FechaDesdeTextBox.Text = "";
                FechaHastaTextBox.Text = "";

                AsignarTextoAlertaSuccess("Cliente eliminado con exito.");
            }
            else
            {
                AsignarTextoAlertaDanger("No se puedo eliminar el cliente.");
            }
            Cliente = null;
            Lista = BLL.ClientesBLL.GetListAll();
            CargarListaCliente();
            BotonImprimirVisibleSiHayListas();
        }

        protected void ImprimirButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Reportes/ClientesReporte.aspx");
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
            GridViewRow row = ClientesConsultaGridView.SelectedRow;

            //
            // Obtengo el id de la entidad que se esta editando
            // en este caso de la entidad Usuario
            //
            int id = Convert.ToInt32(ClientesConsultaGridView.DataKeys[row.RowIndex].Value);
            Cliente = BLL.ClientesBLL.Buscar(U => U.ClienteId == id);

            Response.Redirect("../Registros/ClientesForm.aspx");
        }

        protected void CancelarModificacionButton_Click(object sender, EventArgs e)
        {
            ImprimirButton.Visible = true;
        }
    }
}