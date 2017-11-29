using GimnasioTech;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace GimnacioTechWeb.UI
{
    public partial class FacturasRegistro : System.Web.UI.Page
    {
        private Entidades.Facturas Factura = new Entidades.Facturas();
        DataTable dt = new DataTable();
        private static List<Entidades.FacturasProductos> listaRelaciones;
        public static List<Entidades.FacturasProductos> Detalle { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            FechaFacturaLabel.Text = DateTime.Now.ToString();

            if (UI.FacturasConsulta.Factura != null)
            {
                Factura = UI.FacturasConsulta.Factura;
                CargarDatosFactura();
                UI.FacturasConsulta.Factura = null;
            }

            if (!Page.IsPostBack)
            {
                dt.Columns.AddRange(new DataColumn[4] { new DataColumn("Producto Id"), new DataColumn("Descripcion"), new DataColumn("Precio"), new DataColumn("Cantidad") });
                ViewState["Detalle"] = dt;

                listaRelaciones = new List<Entidades.FacturasProductos>();
                Detalle = new List<Entidades.FacturasProductos>();

                Factura = new Entidades.Facturas();
            }
        }

        private void Limpiar()
        {
            FacturaIdTextBox.Text = "";
            ClienteIdTextBox.Text = "";
            NombreClienteTextBox.Text = "";
            ComentarioTextBox.Text = "";
            FormaPagoDropDownList.Text = "Contado";
            ProductoIdTextBox.Text = "";
            MontoTextBox.Text = "";
            DineroPagadoTextBox.Text = "";
            DevueltaTextBox.Text = "";

            LimpiarDatosProducto();
            LimpiarListaRelaciones();

            Response.Redirect("FacturasRegistro.aspx");
        }

        private bool Validar()
        {
            bool interruptor = true;

            if (string.IsNullOrEmpty(NombreClienteTextBox.Text))
            {
                interruptor = false;
            }
            if (DetalleGridView.Rows.Count == 0)
            {
                interruptor = false;
            }
            if (FormaPagoDropDownList.SelectedIndex != 1)
            {
                if (string.IsNullOrEmpty(DevueltaTextBox.Text))
                {
                    interruptor = false;
                }
            }


            return interruptor;
        }

        public void BuscarDatosDetalle(List<Entidades.FacturasProductos> facturaProducto)
        {
            foreach (var detalle in facturaProducto)
            {
                dt = (DataTable)ViewState["Detalle"];
                dt.Rows.Add(detalle.ProductoId, detalle.Descripcion, detalle.Precio, detalle.Cantidad);
                ViewState["Detalle"] = dt;
                this.BindGrid();
            }
        }

        public void GuardarDatosDetalle()
        {
            foreach (GridViewRow dr in DetalleGridView.Rows)
            {
                Factura.Relacion.Add(new Entidades.FacturasProductos(
                    Convert.ToInt32(dr.Cells[0].Text),
                    Convert.ToString(dr.Cells[1].Text),
                    Convert.ToDecimal(dr.Cells[2].Text),
                    Convert.ToInt32(dr.Cells[3].Text)));
            }
        }

        protected void BindGrid()
        {
            DetalleGridView.DataSource = (DataTable)ViewState["Detalle"];
            DetalleGridView.DataBind();
        }

        private void LimpiarListaRelaciones()
        {
            listaRelaciones = new List<Entidades.FacturasProductos>();
            DetalleGridView.DataSource = (DataTable)ViewState["listaRelaciones"];
            DetalleGridView.DataBind();
        }

        private void LimpiarDatosProducto()
        {
            PrecioProductoTextBox.Text = "";
            DescripcionProductoTextBox.Text = "";
            CantidadProductoTextBox.Text = "";
        }

        private Entidades.Facturas LlenarInstanciaFactura()
        {
            //Factura.FacturaId = Utilidades.TOINT(FacturaIdTextBox.Text);
            Factura.NombreCliente = NombreClienteTextBox.Text;
            Factura.Fecha = Convert.ToDateTime(FechaFacturaLabel.Text);
            Factura.Comentario = ComentarioTextBox.Text;
            Factura.FormaPago = FormaPagoDropDownList.Text;
            Factura.Monto = Utilidades.TODECIMAL(MontoTextBox.Text);
            Factura.DineroPagado = Utilidades.TODECIMAL(DineroPagadoTextBox.Text);
            Factura.Devuelta = Utilidades.TODECIMAL(DevueltaTextBox.Text);

            return Factura;
        }

        private void CargarDatosFactura()
        {
            FacturaIdTextBox.Text = Factura.FacturaId.ToString();
            NombreClienteTextBox.Text = Factura.NombreCliente;
            FechaFacturaLabel.Text = Factura.Fecha.ToString();
            ComentarioTextBox.Text = Factura.Comentario;
            FormaPagoDropDownList.Text = Factura.FormaPago;
            MontoTextBox.Text = Factura.Monto.ToString();
            DineroPagadoTextBox.Text = Factura.DineroPagado.ToString();
            DevueltaTextBox.Text = Factura.Devuelta.ToString();

            listaRelaciones = BLL.FacturasProductosBLL.GetList(A => A.FacturaId == Factura.FacturaId);
            BuscarDatosDetalle(listaRelaciones);
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
            if (Validar())
            {
                Factura.FacturaId = Utilidades.TOINT(FacturaIdTextBox.Text);
                GuardarDatosDetalle();

                if (BLL.FacturasBLL.Guardar(LlenarInstanciaFactura()))
                {
                    ReducirExistenciaProducto();
                    FacturaIdTextBox.Text = Convert.ToString(Factura.FacturaId);
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Factura guardado con exito');", addScriptTags: true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('No se pudo guardar la factura');", addScriptTags: true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Por favor llenar los campos vacios');", addScriptTags: true);
            }
        }

        private void ReducirExistenciaProducto()
        {
            decimal cantidadDescontar = 0;
            Entidades.Productos Producto = new Entidades.Productos();
            foreach (GridViewRow producto in DetalleGridView.Rows)
            {
                int id = Convert.ToInt32(producto.Cells[0].Text);
                cantidadDescontar = Convert.ToDecimal(producto.Cells[3].Text);

                Producto = BLL.ProductosBLL.BuscarPorId(id);
                Producto.Cantidad -= cantidadDescontar;
                BLL.ProductosBLL.Modificar(Producto);
            }
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            if (DetalleGridView.Rows.Count > 0)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Por favor limpie la pagina antes de buscar');", addScriptTags: true);
            }
            else
            {
                if (VerificarExistenciaFactura())
                {
                    CargarDatosFactura();
                }
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
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('No se puedo eliminar la factura');", addScriptTags: true);
            }
        }

        protected void BuscarProductoButton_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private bool ValidarProductoAgregadoGrid()
        {
            int id = Utilidades.TOINT(ProductoIdTextBox.Text);
            Entidades.Productos Producto = BLL.ProductosBLL.Buscar(p => p.ProductoId == id);

            if (Producto != null)
            {
                foreach (GridViewRow row in DetalleGridView.Rows)
                {
                    if (row.Cells[0].Text == Producto.ProductoId.ToString())
                    {
                        return true;
                    }
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('No existe producto con ese id');", addScriptTags: true);
            }

            return false;
        }

        protected void AgregarProductoButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DescripcionProductoTextBox.Text))
            {
                int id = Utilidades.TOINT(ProductoIdTextBox.Text);
                Entidades.Productos Producto = BLL.ProductosBLL.Buscar(p => p.ProductoId == id);

                if (Producto != null)
                {
                    if (!string.IsNullOrEmpty(CantidadProductoTextBox.Text) && Utilidades.TOINT(CantidadProductoTextBox.Text) > 0)
                    {                      
                        if (Producto.Cantidad >= Utilidades.TOINT(CantidadProductoTextBox.Text))
                        {
                            if (!ValidarProductoAgregadoGrid())
                            {
                                dt = (DataTable)ViewState["Detalle"];
                                dt.Rows.Add(Utilidades.TOINT(ProductoIdTextBox.Text), DescripcionProductoTextBox.Text, Utilidades.TODECIMAL(PrecioProductoTextBox.Text), CantidadProductoTextBox.Text);
                                ViewState["Detalle"] = dt;
                                this.BindGrid();
                                CalcularMonto();
                            }
                            else
                            {
                                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('El producto ya esta agregado');", addScriptTags: true);
                            }
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('La cantidad elegida es mayor que la existencia');", addScriptTags: true);
                        }
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Por favor digite la cantidad');", addScriptTags: true);
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('No existe producto con ese id');", addScriptTags: true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Por favor busque el producto que desea agregar');", addScriptTags: true);
            }
        }

        private void CalcularMonto()
        {
            decimal monto = 0;
            foreach (GridViewRow producto in DetalleGridView.Rows)
            {
                monto += Convert.ToDecimal(producto.Cells[2].Text) * Convert.ToDecimal(producto.Cells[3].Text);
            }

            Factura.Monto = monto;
            MontoTextBox.Text = Factura.Monto.ToString();
            DevueltaTextBox.Text = "";
        }

        protected void CrearClienteButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ClientesRegistro.aspx");
        }

        private void CalcularDevuelta()
        {
            if (!string.IsNullOrEmpty(DineroPagadoTextBox.Text))
            {
                if (Utilidades.TOINT(DineroPagadoTextBox.Text) >= Utilidades.TODECIMAL(MontoTextBox.Text))
                {
                    DevueltaTextBox.Text = (Utilidades.TOINT(DineroPagadoTextBox.Text) - Utilidades.TODECIMAL(MontoTextBox.Text)).ToString();
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('El dinero no es suficiente');", addScriptTags: true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Por favor digite la cantidad pagada');", addScriptTags: true);
            }
        }

        protected void CalcularDevueltaButton_Click(object sender, EventArgs e)
        {
            CalcularDevuelta();
        }

        protected void ProductoIdTextBox_TextChanged(object sender, EventArgs e)
        {
            DescripcionProductoTextBox.Text = "";
            PrecioProductoTextBox.Text = "";
            CantidadProductoTextBox.Text = "";
        }

        protected void FormaPagoDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormaPagoDropDownList.SelectedIndex == 1)
            {
                DineroPagadoTextBox.Enabled = false;
                MontoTextBox.Text = "";
                DineroPagadoTextBox.Text = "";
                DevueltaTextBox.Text = "";
            }
            else
            {
                DineroPagadoTextBox.Enabled = true;
                CalcularMonto();
            }     
        }
    }
}