using BLL;
using Entidades;
using GimnasioTech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GimnacioTechWeb.UI.Registros
{
    public partial class ProductosForm : System.Web.UI.Page
    {
        public Productos producto;

        protected void Page_Load(object sender, EventArgs e)
        {
            producto = new Productos();
            AlertSuccessPanel.Visible = false;
            AlertInfoPanel.Visible = false;
            AlertDangerPanel.Visible = false;

            if (Consultas.ProductosConsulta.Producto != null)
            {
                producto = Consultas.ProductosConsulta.Producto;
                DatosProductos();
                Consultas.ProductosConsulta.Producto = null;
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

        private void AsignarTextoAlertaWarning(string texto)
        {
            AlertWarningLabel.Text = texto;
            AlertWarningPanel.Visible = true;
        }

        private void AsignarTextoAlertaDanger(string texto)
        {
            AlertDangerLabel.Text = texto;
            AlertDangerPanel.Visible = true;
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

            AlertSuccessPanel.Visible = false;
            AlertInfoPanel.Visible = false;
            AlertDangerPanel.Visible = false;
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

        private void DatosProductos()
        {
            ProductoIdTextBox.Text = producto.ProductoId.ToString();
            DescripcionTextBox.Text = producto.Descripcion;
            CantidadTextBox.Text = producto.Cantidad.ToString();
            CostoTextBox.Text = producto.Costo.ToString();
            PrecioTextBox.Text = producto.Precio.ToString();
            FechaIngresoTextBox.Text = producto.FechaIngreso.ToString("yyyy-MM-dd");
        }

        private Productos LlenarCampos()
        {
            producto.ProductoId = Utilidades.TOINT(ProductoIdTextBox.Text);
            producto.Descripcion = DescripcionTextBox.Text;
            producto.Cantidad = Utilidades.TOINT(CantidadTextBox.Text);
            producto.Costo = Utilidades.TOINT(CostoTextBox.Text);
            producto.Precio = Utilidades.TOINT(PrecioTextBox.Text);
            producto.FechaIngreso = Convert.ToDateTime(FechaIngresoTextBox.Text);

            return producto;
        }

        private void BuscarProductos()
        {
            if (string.IsNullOrEmpty(ProductoIdTextBox.Text))
            {
                AsignarTextoAlertaInfo("Digite el id del producto que desea buscar.");
            }
            else
            {
                int id = Utilidades.TOINT(ProductoIdTextBox.Text);

                producto = ProductosBLL.Buscar(p => p.ProductoId == id);

                if (producto != null)
                {

                    DatosProductos();
                }
                else
                {
                    AsignarTextoAlertaInfo("No existe producto con ese id.");
                }
            }
        }

        protected void SingOutButton_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            System.Web.Security.FormsAuthentication.RedirectToLoginPage();
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            BuscarProductos();
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                producto = LlenarCampos();

                if (ProductosBLL.Guardar(producto))
                {
                    ProductoIdTextBox.Text = Convert.ToString(producto.ProductoId);
                    AsignarTextoAlertaSuccess("Producto guardado con exito.");
                }
                else
                {
                    AsignarTextoAlertaDanger("No se pudo guardar el Producto.");
                }
            }
            else
            {
                AsignarTextoAlertaInfo("Favor llenar los campos vacios.");
            }
        }

        protected void EnviarAlModalEliminarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ProductoIdTextBox.Text))
            {
                AsignarTextoAlertaInfo("Ingresar el id del producto que desea eliminar.");
            }
            else
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
                AsignarTextoAlertaSuccess("Producto eliminado con exito.");
            }
            else
            {
                AsignarTextoAlertaDanger("No se pudo eliminar el producto.");
            }
        }
    }
}