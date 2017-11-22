using GimnasioTech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GimnacioTechWeb.UI
{
    public partial class FacturasRegistroaspx : System.Web.UI.Page
    {
        private Entidades.Facturas Factura = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            Factura = new Entidades.Facturas();
            FechaFacturaLabel.Text = DateTime.Now.ToString();
        }

        private void Limpiar()
        {
            FacturaIdTextBox.Text = "";
            ClienteIdTextBox.Text = "";
            NombreClienteTextBox.Text = "";
            ComentarioTextBox.Text = "";
            FormaPagoDropDownList.Text = "Contado";
            ProductoIdTextBox.Text = "";

            LimpiarDatosProducto();
        }

        private void LimpiarDatosProducto()
        {
            PrecioProductoTextBox.Text = "";
            DescripcionProductoTextBox.Text = "";
            CantidadProductoTextBox.Text = "";
        }

        private Entidades.Facturas LlenarInstanciaFactura()
        {
            Factura.FacturaId = Utilidades.TOINT(FacturaIdTextBox.Text);
            Factura.NombreCliente = NombreClienteTextBox.Text;
            Factura.Fecha = Convert.ToDateTime(FechaFacturaLabel.Text);
            Factura.Comentario = ComentarioTextBox.Text;
            Factura.FormaPago = FormaPagoDropDownList.Text;

            return Factura;
        }

        private void CargarDatosFactura()
        {
            FacturaIdTextBox.Text = Factura.FacturaId.ToString();
            NombreClienteTextBox.Text = Factura.NombreCliente;
            FechaFacturaLabel.Text = Factura.Fecha.ToString();
            ComentarioTextBox.Text = Factura.Comentario;
            FormaPagoDropDownList.Text = Factura.FormaPago;
        }

        private bool VerificarExistenciaFactura()
        {
            if (string.IsNullOrEmpty(FacturaIdTextBox.Text))
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Por favor digite el id de la factura');", addScriptTags: true);
            }
            else
            {
                int id = Utilidades.TOINT(FacturaIdTextBox.Text);

                Factura = BLL.FacturasBLL.Buscar(p => p.FacturaId == id);

                if (Factura != null)
                {
                    return true;
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('No existe factura con ese id');", addScriptTags: true);
                }
            }

            return false;
        }

        private void BuscarCliente()
        {
            if (!string.IsNullOrEmpty(ClienteIdTextBox.Text))
            {
                int id = Utilidades.TOINT(ClienteIdTextBox.Text);
                Entidades.Clientes cliente = new Entidades.Clientes();

                cliente = BLL.ClientesBLL.Buscar(p => p.ClienteId == id);

                if (cliente != null)
                {
                    NombreClienteTextBox.Text = cliente.Nombres;
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('No existe cliente con ese id');", addScriptTags: true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Por favor digite el id del cliente');", addScriptTags: true);
                ClienteIdTextBox.Focus();
            }
        }

        private void BuscarProducto()
        {
            if (!string.IsNullOrEmpty(ProductoIdTextBox.Text))
            {
                int id = Utilidades.TOINT(ProductoIdTextBox.Text);
                Entidades.Productos producto = new Entidades.Productos();

                producto = BLL.ProductosBLL.Buscar(p => p.ProductoId == id);

                if (producto != null)
                {
                    DescripcionProductoTextBox.Text = producto.Descripcion;
                    PrecioProductoTextBox.Text = producto.Precio.ToString();
                    CantidadProductoTextBox.Focus();
                }
                else
                {
                    LimpiarDatosProducto();
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('No existe un producto con ese id');", addScriptTags: true);
                    ProductoIdTextBox.Focus();
                }
            }
            else
            {
                LimpiarDatosProducto();
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Por favor igite el id de un producto');", addScriptTags: true);
                ProductoIdTextBox.Focus();
            }
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if (BLL.FacturasBLL.Guardar(LlenarInstanciaFactura()))
            {
                FacturaIdTextBox.Text = Convert.ToString(Factura.FacturaId);
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Factura guardado con exito');", addScriptTags: true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('No se pudo guardar la factura');", addScriptTags: true);
            }
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            if (VerificarExistenciaFactura())
            {
                CargarDatosFactura();
            }
        }

        protected void BuscarClienteButton_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        protected void EnviarAlModalEliminarButton_Click(object sender, EventArgs e)
        {
            if (VerificarExistenciaFactura())
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "#ModalEliminar", "showModalEliminar();", true);
            }
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.TOINT(FacturaIdTextBox.Text);

            if (BLL.FacturasBLL.Eliminar(BLL.FacturasBLL.Buscar(p => p.FacturaId == id)))
            {
                Limpiar();
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Factura eliminada con exito');", addScriptTags: true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('No se puedo eliminar la factura');", addScriptTags: true);
            }
        }

        protected void BuscarProductoButton_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }
    }
}