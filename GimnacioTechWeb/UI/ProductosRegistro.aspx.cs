using BLL;
using Entidades;
using GimnasioTech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GimnacioTechWeb.UI
{
    public partial class ProductosRegistro : System.Web.UI.Page
    {
        public Productos producto;

        protected void Page_Load(object sender, EventArgs e)
        {
            producto = new Productos();

            if (!Page.IsPostBack)
            {
                LlenarDropCategorias();
            }

            if (UI.ProductosConsulta.Producto != null)
            {
                producto = UI.ProductosConsulta.Producto;
                CargarDatosProductos();
                UI.ProductosConsulta.Producto = null;
            }
        }

        private void Limpiar()
        {
            ProductoIdTextBox.Text = "";
            DescripcionTextBox.Text = "";
            CantidadTextBox.Text = "";
            CantidadTextBox.Text = "";
            CostoTextBox.Text = "";
            PrecioTextBox.Text = "";
            FechaIngresoTextBox.Text = "";
            CategoriaDropDownList.SelectedIndex = 0;
        }

        private bool Validar()
        {
            bool interruptor = true;

            if (string.IsNullOrEmpty(DescripcionTextBox.Text))
            {
                interruptor = false;
            }
            if (string.IsNullOrEmpty(CantidadTextBox.Text))
            {
                interruptor = false;
            }
            if (string.IsNullOrEmpty(CostoTextBox.Text))
            {
                interruptor = false;
            }
            if (string.IsNullOrEmpty(PrecioTextBox.Text))
            {
                interruptor = false;
            }
            if (string.IsNullOrEmpty(FechaIngresoTextBox.Text))
            {
                interruptor = false;
            }

            return interruptor;
        }

        private void CargarDatosProductos()
        {
            ProductoIdTextBox.Text = producto.ProductoId.ToString();
            DescripcionTextBox.Text = producto.Descripcion;
            CantidadTextBox.Text = producto.Cantidad.ToString();
            CostoTextBox.Text = producto.Costo.ToString();
            PrecioTextBox.Text = producto.Precio.ToString();
            FechaIngresoTextBox.Text = producto.FechaIngreso.ToString("yyyy-MM-dd");
            CategoriaDropDownList.Text = producto.CategoriaId.ToString();
        }

        private Productos LlenarInstanciaProducto()
        {
            producto.ProductoId = Utilidades.TOINT(ProductoIdTextBox.Text);
            producto.Descripcion = DescripcionTextBox.Text;
            producto.Cantidad = Utilidades.TOINT(CantidadTextBox.Text);
            producto.Costo = Utilidades.TOINT(CostoTextBox.Text);
            producto.Precio = Utilidades.TOINT(PrecioTextBox.Text);
            producto.FechaIngreso = Convert.ToDateTime(FechaIngresoTextBox.Text);
            producto.CategoriaId = Utilidades.TOINT(CategoriaDropDownList.SelectedValue);

            return producto;
        }

        private bool VerificarExistenciaProducto()
        {
            if (string.IsNullOrEmpty(ProductoIdTextBox.Text))
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Digite el id del producto');", addScriptTags: true);
            }
            else
            {
                int id = Utilidades.TOINT(ProductoIdTextBox.Text);

                producto = ProductosBLL.Buscar(p => p.ProductoId == id);

                if (producto != null)
                {

                    return true;
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('No existe producto con ese id');", addScriptTags: true);
                }
            }

            return false;
        }

        private void LlenarDropCategorias()
        {
            List<Entidades.CategoriaProductos> Lista = BLL.CategoriaProductosBLL.GetListAll();

            CategoriaDropDownList.DataSource = Lista;
            CategoriaDropDownList.DataValueField = "CategoriaId";
            CategoriaDropDownList.DataTextField = "Descripcion";
            CategoriaDropDownList.DataBind();
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            if (VerificarExistenciaProducto())
            {
                CargarDatosProductos();
            }
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (ProductosBLL.Guardar(LlenarInstanciaProducto()))
                {
                    ProductoIdTextBox.Text = Convert.ToString(producto.ProductoId);
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Producto guardado con exito');", addScriptTags: true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('No se pudo guardar el producto');", addScriptTags: true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Por favor llenar los campos vacios');", addScriptTags: true);
            }
        }

        protected void EnviarAlModalEliminarButton_Click(object sender, EventArgs e)
        {
            if (VerificarExistenciaProducto())
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "#ModalEliminar", "showModalEliminar();", true);
            }
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.TOINT(ProductoIdTextBox.Text);

            if (ProductosBLL.Eliminar(ProductosBLL.Buscar(p => p.ProductoId == id)))
            {
                Limpiar();
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Producto eliminado con exito');", addScriptTags: true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('No se pudo eliminar el producto');", addScriptTags: true);
            }
        }
    }
}
