using GimnasioTech;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GimnacioTechWeb.UI
{
    public partial class FacturasRegistroaspx : System.Web.UI.Page
    {
        private Entidades.Facturas Factura = new Entidades.Facturas();
        DataTable dt = new DataTable();
        private static List<Entidades.FacturasProductos> listaRelaciones;
        private static List<Entidades.Productos> listadoProductos = null;

        public static List<Entidades.FacturasProductos> Detalle { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            FechaFacturaLabel.Text = DateTime.Now.ToString();

            if (!Page.IsPostBack)
            {
                dt.Columns.AddRange(new DataColumn[4] {new DataColumn("Producto Id"), new DataColumn("Descripcion"), new DataColumn("Precio"), new DataColumn("Cantidad")});
                ViewState["Detalle"] = dt;

                listadoProductos = new List<Entidades.Productos>();
                listaRelaciones = new List<Entidades.FacturasProductos>();
                Detalle = new List<Entidades.FacturasProductos>();

                Factura = new Entidades.Facturas();
            }
        }

        private void Limpiar()
        {
            dt.Columns.AddRange(new DataColumn[5] { new DataColumn("Factura Id"), new DataColumn("Producto Id"), new DataColumn("Producto"), new DataColumn("Precio"), new DataColumn("Cantidad") });
            ViewState["Detalle"] = dt;
          
            FacturaIdTextBox.Text = "";
            ClienteIdTextBox.Text = "";
            NombreClienteTextBox.Text = "";
            ComentarioTextBox.Text = "";
            FormaPagoDropDownList.Text = "Contado";
            ProductoIdTextBox.Text = "";

            LimpiarDatosProducto();        
        }

        public void LlenarRegistro(List<Entidades.FacturasProductos> llenar)
        {
            foreach (var li in llenar)
            {
                DataTable dt = (DataTable)ViewState["Detalle"];
                dt.Rows.Add(li.ProductoId, li.Descripcion, li.Precio, li.Cantidad);
                ViewState["Detalle"] = dt;
                this.BindGrid();
            }
        }

        public void LlenarDatos(Entidades.FacturasProductos detalle)
        {
            /*int id = 0;

            if (Factura != null)
            {
                id = Factura.FacturaId;
            }*/

            int cantidad = 0;

            foreach (GridViewRow dr in DetalleGridView.Rows)
            {
                Factura.Relacion.Add(new Entidades.FacturasProductos(
                    Convert.ToInt32(dr.Cells[0].Text), 
                    Convert.ToString(dr.Cells[1].Text),
                    Convert.ToDecimal(dr.Cells[2].Text), 
                    Convert.ToInt32(dr.Cells[3].Text)));

                cantidad =+ 1;
            }

            //facturaG = new Entidades.Facturas(0, "Anthony", DateTime.Now, "Clente", "Prueba", cantidad, 100);
        }

        protected void BindGrid()
        {          
            DetalleGridView.DataSource = (DataTable)ViewState["Detalle"];
            DetalleGridView.DataBind();
        }

        private void RefreshListaRelciones()
        {
            DetalleGridView.DataSource = null;
            DetalleGridView.DataSource = listaRelaciones;
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
            Factura.FacturaId = Utilidades.TOINT(FacturaIdTextBox.Text);
            Factura.NombreCliente = NombreClienteTextBox.Text;
            Factura.Fecha = Convert.ToDateTime(FechaFacturaLabel.Text);
            Factura.Comentario = ComentarioTextBox.Text;
            Factura.FormaPago = FormaPagoDropDownList.Text;

            return Factura;
        }

        private void CargarDatosFactura()
        {
            listaRelaciones = BLL.FacturasProductosBLL.GetList(A => A.FacturaId == Factura.FacturaId);

            FacturaIdTextBox.Text = Factura.FacturaId.ToString();
            NombreClienteTextBox.Text = Factura.NombreCliente;
            FechaFacturaLabel.Text = Factura.Fecha.ToString();
            ComentarioTextBox.Text = Factura.Comentario;
            FormaPagoDropDownList.Text = Factura.FormaPago;

            /*if (listaRelaciones.Count != 0)
            {
                foreach (var relacion in listaRelaciones)
                {
                    listadoProductos.Add(BLL.ProductosBLL.Buscar(A => A.ProductoId == relacion.ProductoId));
                }

                foreach (var articulo in listadoProductos)
                {
                    articulo.ProductoId = BLL.ProductosBLL.Buscar(A => A.ProductoId == articulo.ProductoId).ProductoId;
                } 
            }*/
            RefreshListaRelciones();
            LlenarRegistro(listaRelaciones);
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
            Entidades.FacturasProductos detalle = new Entidades.FacturasProductos();
            LlenarDatos(detalle);

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

        protected void AgregarProductoButton_Click(object sender, EventArgs e)
        {
            /*int id = Utilidades.TOINT(ProductoIdTextBox.Text);
            Producto = BLL.ProductosBLL.Buscar(p => p.ProductoId == id);

            int id2 = 0;
            if (Factura != null)
            {
                id2 = Factura.FacturaId;
            }*/

            DataTable dt = (DataTable)ViewState["Detalle"];
            dt.Rows.Add(Utilidades.TOINT(ProductoIdTextBox.Text), DescripcionProductoTextBox.Text, Utilidades.TODECIMAL(PrecioProductoTextBox.Text), CantidadProductoTextBox.Text.Trim());
            ViewState["Detalle"] = dt;
            this.BindGrid();
        }
    }
}