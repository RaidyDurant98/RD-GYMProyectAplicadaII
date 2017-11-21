using GimnasioTech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GimnacioTechWeb.UI
{
    public partial class CategoriaProductosConsulta : System.Web.UI.Page
    {
        public static List<Entidades.CategoriaProductos> Lista { get; set; }
        public static Entidades.CategoriaProductos Categoria = null;

        protected void Page_Load(object sender, EventArgs e)
        {
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

        private void Limpiar()
        {
            FiltroTextBox.Text = "";
            FiltrarDropDownList.SelectedIndex = 0;
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
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('No existe categoria');", addScriptTags: true);
                ImprimirButton.Visible = false;
            }
        }

        protected void FiltroButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FiltroTextBox.Text) && FiltrarDropDownList.SelectedIndex != 0)
            {
                CategoriasConsultaGridView.DataBind();
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Por favor digite el dato a filtrar');", addScriptTags: true);
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
                Limpiar();

                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Categoria eliminada con exito');", addScriptTags: true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('No se pudo eliminar la categoria');", addScriptTags: true);
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

            Response.Redirect("CategoriaProductosRegistro.aspx");
        }

        protected void CancelarModificacionButton_Click(object sender, EventArgs e)
        {
            ImprimirButton.Visible = true;
        }

        protected void ImprimirButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Reportes/CategoriaProductosReporte.aspx");
        }
    }
}