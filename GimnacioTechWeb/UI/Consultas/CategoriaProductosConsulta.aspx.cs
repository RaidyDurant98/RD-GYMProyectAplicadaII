﻿using GimnasioTech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GimnacioTechWeb.UI.Consultas
{
    public partial class CategoriaProductosConsulta : System.Web.UI.Page
    {
        public static List<Entidades.CategoriaProductos> Lista { get; set; }
        public static Entidades.CategoriaProductos Categoria = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            AlertInfoPanel.Visible = false;
            AlertSuccessPanel.Visible = false;
            AlertDangerPanel.Visible = false;
            Categoria = null;

            if (!Page.IsPostBack)
            {
                Lista = BLL.CategoriaProductosBLL.GetListAll();
                CargarListaCategoria();
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

        private void CargarListaCategoria()
        {
            CategoriasConsultaGridView.DataSource = Lista;
            CategoriasConsultaGridView.DataBind();
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
                Lista = BLL.CategoriaProductosBLL.GetListAll();
            }
            else if (FiltrarDropDownList.SelectedIndex != 0)
            {
                if (FiltrarDropDownList.SelectedIndex == 2)
                {
                    Lista = BLL.CategoriaProductosBLL.GetList(p => p.Descripcion == FiltroTextBox.Text);
                }
                if (FiltrarDropDownList.SelectedIndex == 1)
                {
                    int id = Utilidades.TOINT(FiltroTextBox.Text);
                    Lista = BLL.CategoriaProductosBLL.GetList(p => p.CategoriaId == id);
                }
            }
            CargarListaCategoria();
            if (Lista.Count() == 0)
            {
                AsignarTextoAlertaInfo("No existe categoria.");
                ImprimirButton.Visible = false;
            }
        }

        protected void FiltroButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FiltroTextBox.Text) && FiltrarDropDownList.SelectedIndex != 0)
            {
                CategoriasConsultaGridView.DataBind();
                AsignarTextoAlertaInfo("Por favor digite el dato que desea filtrar.");
                ImprimirButton.Visible = false;
            }
            else
            {
                ImprimirButton.Visible = false;
                Filtrar();
                BotonImprimirVisibleSiHayListas();
            }
        }

        protected void EnviarAlModalEliminarButton_Click(object sender, EventArgs e)
        {
            ImprimirButton.Visible = true;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "#ModalEliminar", "showModalEliminar();", true);
        }

        protected void EnviarAlModalModificarButton_Click(object sender, EventArgs e)
        {
            ImprimirButton.Visible = true;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "#ModalModificar", "showModalModificar();", true);
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            //
            // Se obtiene la fila seleccionada del gridview
            //
            GridViewRow row = CategoriasConsultaGridView.SelectedRow;

            //
            // Obtengo el id de la entidad que se esta editando
            // en este caso de la entidad Usuario
            //
            int id = Convert.ToInt32(CategoriasConsultaGridView.DataKeys[row.RowIndex].Value);

            Categoria = BLL.CategoriaProductosBLL.Buscar(U => U.CategoriaId == id);
            if (BLL.CategoriaProductosBLL.Eliminar(Categoria))
            {
                FiltroTextBox.Text = "";
                FiltrarDropDownList.Text = "Todo";

                AsignarTextoAlertaSuccess("Categoria eliminado con exito.");
            }
            else
            {
                AsignarTextoAlertaDanger("No se puedo eliminar la categoria.");
            }
            Categoria = null;
            Lista = BLL.CategoriaProductosBLL.GetListAll();
            CargarListaCategoria();
            BotonImprimirVisibleSiHayListas();
        }

        protected void CancelarEliminacionButton_Click(object sender, EventArgs e)
        {
            ImprimirButton.Visible = true;
        }

        protected void ModificarButton_Click(object sender, EventArgs e)
        {
            //
            // Se obtiene la fila seleccionada del gridview
            //
            GridViewRow row = CategoriasConsultaGridView.SelectedRow;

            //
            // Obtengo el id de la entidad que se esta editando
            // en este caso de la entidad Usuario
            //
            int id = Convert.ToInt32(CategoriasConsultaGridView.DataKeys[row.RowIndex].Value);
            Categoria = BLL.CategoriaProductosBLL.Buscar(U => U.CategoriaId == id);

            Response.Redirect("../Registros/CategoriaProductosForm.aspx");
        }

        protected void CancelarModificacionButton_Click(object sender, EventArgs e)
        {
            ImprimirButton.Visible = true;
        }

        protected void ImprimirButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Reportes/CategoriaProductosReporte.aspx");
        }

        protected void SingOutButton_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            System.Web.Security.FormsAuthentication.RedirectToLoginPage();
        }
    }
}