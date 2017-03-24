using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GimnasioTech.UI
{
    public partial class FacturasForm : Form
    {
        Entidades.FacturasProductos Detalle = null;
        Entidades.Facturas Factura = null;

        public FacturasForm()
        {
            InitializeComponent();
            Limpiar();
        }

        private void FacturasForm_Load(object sender, EventArgs e)
        {
            RecibidomaskedTextBox.Enabled = false;
            CantidadnumericUpDown.Enabled = false;
        }

        private void Limpiar()
        {
            Detalle = new Entidades.FacturasProductos();
            Factura = new Entidades.Facturas();

            FacturaIdmaskedTextBox.Clear();
            ClienteIdmaskedTextBox.Clear();
            NombreClientetextBox.Clear();
            MontotextBox.Clear();
            FechadateTimePicker.Value = DateTime.Now;
            ProductoIdmaskedTextBox.Clear();
            DescripcionProductotextBox.Clear();
            ProductodataGridView.DataSource = null;
            CantidadnumericUpDown.Value = 0;
            PreciotextBox.Clear();
            DevueltatextBox.Clear();
            RecibidomaskedTextBox.Clear();
            NombreClienteerrorProvider.Clear();
            CantidaderrorProvider.Clear();
            ProductoerrorProvider.Clear();
            RecibidoerrorProvider.Clear();
            GriderrorProvider.Clear();
            ClienteIderrorProvider.Clear();

            RecibidomaskedTextBox.Enabled = false;
            CantidadnumericUpDown.Enabled = false;
        }

        private bool Validar()
        {
            bool interruptor = true;

            if (string.IsNullOrEmpty(NombreClientetextBox.Text))
            {
                NombreClienteerrorProvider.SetError(NombreClientetextBox, "Debe de elegir un cliente.");
                interruptor = false;
            }
            if (ProductodataGridView.DataSource == null)
            {
                GriderrorProvider.SetError(ProductodataGridView, "Por favor llenar el campo.");
                interruptor = false;
            }
            if (string.IsNullOrEmpty(RecibidomaskedTextBox.Text))
            {
                RecibidoerrorProvider.SetError(RecibidomaskedTextBox, "Por favor llenar el campo.");
                interruptor = false;
            }

            return interruptor;
        }

        private Entidades.Facturas LlenarCampos()
        {
            Factura.NombreCliente = NombreClientetextBox.Text;
            Factura.FacturaId = Utilidades.TOINT(FacturaIdmaskedTextBox.Text);
            Factura.Monto = Utilidades.TOINT(MontotextBox.Text);
            Factura.Fecha = FechadateTimePicker.Value;
            Factura.DineroPagado = Utilidades.TOINT(RecibidomaskedTextBox.Text);
            Factura.Devuelta = Utilidades.TOINT(DevueltatextBox.Text);

            return Factura;
        }

        public void LlenarDataGrid(Entidades.Facturas factura)
        {
            ProductodataGridView.DataSource = null;
            ProductodataGridView.DataSource = factura.Relacion.ToList();

            this.ProductodataGridView.Columns["Id"].Visible = false;
            this.ProductodataGridView.Columns["FacturaId"].Visible = false;
            this.ProductodataGridView.Columns["Producto"].Visible = false;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Factura = LlenarCampos();

                if (BLL.FacturasBLL.Guardar(Factura))
                {
                    ExistenciaProducto(CantidadnumericUpDown.Value);
                    MessageBox.Show("Guardado con exito.");                    
                    Limpiar();
                }
                else
                    MessageBox.Show("Error! no se pudo guardar.");
            }

            if (string.IsNullOrEmpty(RecibidomaskedTextBox.Text))
            {
                RecibidomaskedTextBox.Focus();
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            BuscarFactura();
        }

        private void BuscarFactura()
        {
            if (string.IsNullOrEmpty(FacturaIdmaskedTextBox.Text))
            {
                MessageBox.Show("Por favor insertar el id que desea buscar.");
                Limpiar();
            }
            else
            {
                Entidades.Facturas factura = new Entidades.Facturas();
                int id = Utilidades.TOINT(FacturaIdmaskedTextBox.Text);

                factura = BLL.FacturasBLL.Buscar(p => p.FacturaId == id);

                if (factura != null)
                {
                    NombreClientetextBox.Text = factura.NombreCliente;
                    FechadateTimePicker.Value = factura.Fecha;
                    MontotextBox.Text = factura.Monto.ToString();
                    RecibidomaskedTextBox.Text = factura.DineroPagado.ToString();
                    DevueltatextBox.Text = factura.Devuelta.ToString();

                    LlenarDataGrid(factura);
                }
                else
                {
                    MessageBox.Show("La factura no exite.");
                    Limpiar();
                }
            }
        }

        private void ExistenciaProducto(decimal existencia)
        {
            Entidades.Productos producto = new Entidades.Productos();

            producto = BLL.ProductosBLL.BuscarOtro(Utilidades.TOINT(ProductoIdmaskedTextBox.Text));
            producto.Cantidad -= existencia;
            BLL.ProductosBLL.Modificar(producto);
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            AgregarProducto();
        }

        private void AgregarProducto()
        {
            if (!string.IsNullOrEmpty(DescripcionProductotextBox.Text))
            {
                if (CantidadnumericUpDown.Value != 0)
                {
                    Factura.AgregarDetalle(Detalle.Producto, CantidadnumericUpDown.Value);
                    LlenarDataGrid(Factura);

                    CantidadnumericUpDown.Enabled = false;
                    DescripcionProductotextBox.Clear();
                    PreciotextBox.Clear();
                    CalculoMonto();
                }
                else
                {
                    CantidaderrorProvider.SetError(CantidadnumericUpDown, "Digite una cantidad diferente de (0).");
                    CantidadnumericUpDown.Focus();
                }
            }
            else
            {
                ProductoerrorProvider.SetError(ProductoIdmaskedTextBox, "Busque un producto para poder agregar.");
            }
        }

        private void CalculoMonto()
        {
            Factura.Monto += Detalle.Producto.Precio * CantidadnumericUpDown.Value;
            MontotextBox.Text = Factura.Monto.ToString();

            RecibidomaskedTextBox.Focus();
        }

        private void CalcularDevuelta()
        {
            Factura.DineroPagado = Utilidades.TOINT(RecibidomaskedTextBox.Text);
            Factura.Monto = Utilidades.TOINT(MontotextBox.Text);

            if (!string.IsNullOrEmpty(RecibidomaskedTextBox.Text))
            {
                if (Factura.DineroPagado < Factura.Monto)
                {
                    MessageBox.Show("El dinero no es suficiente para cubrir su comprar.");
                    RecibidomaskedTextBox.Clear();
                    RecibidomaskedTextBox.Focus();

                }
                else
                {
                    Factura.Devuelta = Factura.DineroPagado - Factura.Monto;
                    DevueltatextBox.Text = Factura.Devuelta.ToString();
                }
            }
            else
            {
                RecibidoerrorProvider.SetError(RecibidomaskedTextBox, "Digite la cantidad de dinero pagada.");
                RecibidomaskedTextBox.Focus();
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                MessageBox.Show("Los campos estan vacios.");
            }
            else
            {
                int id = Utilidades.TOINT(FacturaIdmaskedTextBox.Text);

                if (BLL.FacturasBLL.Eliminar(BLL.FacturasBLL.Buscar(p => p.FacturaId == id)))
                {
                    Limpiar();
                    MessageBox.Show("La factura se elimino con exito.");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la factura.");
                }
            }
        }

        private void BuscarProducto()
        {
            if (!string.IsNullOrEmpty(ProductoIdmaskedTextBox.Text))
            {
                int id = Utilidades.TOINT(ProductoIdmaskedTextBox.Text);

                Detalle.Producto = BLL.ProductosBLL.Buscar(p => p.ProductoId == id);

                if (Detalle.Producto != null)
                {
                    DescripcionProductotextBox.Text = Detalle.Producto.Descripcion;
                    PreciotextBox.Text = Detalle.Producto.Precio.ToString();
                    CantidadnumericUpDown.Enabled = true;                   
                    CantidadnumericUpDown.Focus();
                }
                else
                {
                    ProductoerrorProvider.SetError(ProductoIdmaskedTextBox, "No existe un producto con ese id.");
                    DescripcionProductotextBox.Clear();
                    CantidadnumericUpDown.Enabled = false;
                    ProductoIdmaskedTextBox.Focus();
                }
            }
            else
            {
                ProductoerrorProvider.SetError(ProductoIdmaskedTextBox, "Digite el id de un producto.");
                DescripcionProductotextBox.Clear();
                ProductoIdmaskedTextBox.Focus();
            }
        }

        private void BuscarProductobutton_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void FacturaIdmaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                BuscarFactura();
            }
        }

        private void CantidadnumericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                AgregarProducto();
                CantidadnumericUpDown.Text = null;
            }
        }

        private void CantidadnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CantidaderrorProvider.Clear();
        }

        private void ProductodataGridView_SelectionChanged(object sender, EventArgs e)
        {
            GriderrorProvider.Clear();
        }

        private void MontotextBox_TextChanged(object sender, EventArgs e)
        {
            RecibidomaskedTextBox.Enabled = true;
        }

        private void RecibidomaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                CalcularDevuelta();
            }
        }

        private void RecibidomaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            RecibidoerrorProvider.Clear();
        }

        private void ProductoIdmaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                BuscarProducto();
            }
        }

        private void ProductoIdmaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            ProductoerrorProvider.Clear();
        }

        private void BuscarClientebutton_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void BuscarCliente()
        {
            if (!string.IsNullOrEmpty(ClienteIdmaskedTextBox.Text))
            {
                int id = Utilidades.TOINT(ClienteIdmaskedTextBox.Text);
                Entidades.Clientes cliente = new Entidades.Clientes();

                cliente = BLL.ClientesBLL.Buscar(p => p.ClienteId == id);

                if (cliente != null)
                {
                    NombreClientetextBox.Text = cliente.Nombres;
                    ProductoIdmaskedTextBox.Focus();
                }
                else
                {
                    ClienteIderrorProvider.SetError(ClienteIdmaskedTextBox, "No existe un cliente con ese id.");
                    NombreClientetextBox.Clear();
                    ClienteIdmaskedTextBox.Focus();
                }
            }
            else
            {
                ClienteIderrorProvider.SetError(ClienteIdmaskedTextBox, "Digite el id de un cliente.");
                NombreClientetextBox.Clear();
                ClienteIdmaskedTextBox.Focus();
            }
        }

        private void ClienteIdmaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            ClienteIderrorProvider.Clear();
        }

        private void ClienteIdmaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            BuscarCliente();
        }
    }
}
