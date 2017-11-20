using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GimnacioTechWeb.UI
{
    public partial class ProductosConsulta : System.Web.UI.Page
    {
        public static List<Entidades.Productos> Lista { get; set; }
        public static Entidades.Productos Producto = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            Producto = null;

            if (!Page.IsPostBack)
            {
                Lista = BLL.ProductosBLL.GetListAll();
                CargarListaProductos();
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

        private void CargarListaProductos()
        {
            ProductosConsultaGridView.DataSource = Lista;
            ProductosConsultaGridView.DataBind();
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
                Lista = BLL.ProductosBLL.GetListAll();
            }
            else if (FiltrarDropDownList.SelectedIndex != 0)
            {
                if (FiltrarDropDownList.SelectedIndex == 1)
                {
                    Lista = BLL.ProductosBLL.GetList(p => p.Descripcion == FiltroTextBox.Text);
                }
                if (FiltrarDropDownList.SelectedIndex == 2)
                {
                    DateTime FechaDesde = Convert.ToDateTime(FechaDesdeTextBox.Text);
                    DateTime FechaHasta = Convert.ToDateTime(FechaHastaTextBox.Text);
                    Lista = BLL.ProductosBLL.GetList(p => p.FechaIngreso >= FechaDesde.Date && p.FechaIngreso <= FechaHasta.Date);
                }
            }
            CargarListaProductos();
            if (Lista.Count() == 0)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('No existe producto');", addScriptTags: true);
                ImprimirButton.Visible = false;
            }
        }

        protected void FiltroButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FiltroTextBox.Text) && FiltrarDropDownList.SelectedIndex != 0 && FiltrarDropDownList.SelectedIndex != 2)
            {
                ProductosConsultaGridView.DataBind();
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Por favor digite el dato del filtro');", addScriptTags: true);
                ImprimirButton.Visible = false;
            }
            else if (FiltrarDropDownList.SelectedIndex == 2)
            {
                if (string.IsNullOrEmpty(FechaDesdeTextBox.Text) || string.IsNullOrEmpty(FechaHastaTextBox.Text))
                {
                    ProductosConsultaGridView.DataBind();
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
            GridViewRow row = ProductosConsultaGridView.SelectedRow;

            //
            // Obtengo el id de la entidad que se esta editando
            // en este caso de la entidad Usuario
            //
            int id = Convert.ToInt32(ProductosConsultaGridView.DataKeys[row.RowIndex].Value);

            Producto = BLL.ProductosBLL.Buscar(U => U.ProductoId == id);
            if (BLL.ProductosBLL.Eliminar(Producto))
            {
                FiltroTextBox.Text = "";
                FiltrarDropDownList.SelectedIndex = 0;
                FechaDesdeTextBox.Text = "";
                FechaHastaTextBox.Text = "";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('producto eliminado con exito');", addScriptTags: true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('No se pudo eliminar el producto');", addScriptTags: true);
            }
            Producto = null;
            Lista = BLL.ProductosBLL.GetListAll();
            CargarListaProductos();
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
            GridViewRow row = ProductosConsultaGridView.SelectedRow;

            //
            // Obtengo el id de la entidad que se esta editando
            // en este caso de la entidad Usuario
            //
            int id = Convert.ToInt32(ProductosConsultaGridView.DataKeys[row.RowIndex].Value);
            Producto = BLL.ProductosBLL.Buscar(U => U.ProductoId == id);

            Response.Redirect("ProductosRegistro.aspx");
        }

        protected void CancelarModificacionButton_Click(object sender, EventArgs e)
        {
            ImprimirButton.Visible = true;
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

        protected void ImprimirButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Reportes/ProductosReporte.aspx");
        }
    }
}