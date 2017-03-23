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
            LlenarComboClientes();
            LlenarComboProductos();
        }

        private void Limpiar()
        {
            Detalle = new Entidades.FacturasProductos();
            Factura = new Entidades.Facturas();

            FacturaIdmaskedTextBox.Clear();
            NombresClientescomboBox.Text = null;
            MontotextBox.Clear();
            FechadateTimePicker.Value = DateTime.Now;
            ProductocomboBox.Text = null;
            ProductodataGridView.DataSource = null;
            CantidadnumericUpDown.Value = 0;
            PreciotextBox.Clear();
            DevueltatextBox.Clear();
            RecibidotextBox.Clear();
        }

        private bool Validar()
        {
            bool x = true;

            if (string.IsNullOrEmpty(NombresClientescomboBox.Text))
            {
                errorProvider1.SetError(NombresClientescomboBox, "Favor Llenar");
                x = false;
            }
            if (string.IsNullOrEmpty(ProductocomboBox.Text))
            {
                errorProvider1.SetError(ProductocomboBox, "Favor Llenar");
                x = false;
            }

            return x;
        }

        private void LlenarComboClientes()
        {
            List<Entidades.Clientes> lista = BLL.ClientesBLL.GetListAll();
            NombresClientescomboBox.DataSource = lista;
            NombresClientescomboBox.DisplayMember = "Nombres";
            NombresClientescomboBox.ValueMember = "ClienteId";

            if (NombresClientescomboBox.Items.Count > 0)
                NombresClientescomboBox.SelectedIndex = -1;
        }

        private void LlenarComboProductos()
        {
            List<Entidades.Productos> lista = BLL.ProductosBLL.GetListAll();
            ProductocomboBox.DataSource = lista;
            ProductocomboBox.DisplayMember = "Descripcion";
            ProductocomboBox.ValueMember = "ProductoId";

            if (ProductocomboBox.Items.Count > 0)
                ProductocomboBox.SelectedIndex = -1;
        }

        private Entidades.Facturas LlenarCampos()
        {
            Factura.NombreCliente = NombresClientescomboBox.Text;
            Factura.FacturaId = Utilidades.TOINT(FacturaIdmaskedTextBox.Text);
            Factura.Monto = Utilidades.TOINT(MontotextBox.Text);
            Factura.Fecha = FechadateTimePicker.Value;
            Factura.DineroPagado = Utilidades.TOINT(RecibidotextBox.Text);
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
            if (!Validar())
            {
                MessageBox.Show("Por favor llenar los campos vacios.");
            }
            else
            {
                Factura = LlenarCampos();

                if (BLL.FacturasBLL.Guardar(Factura))
                {
                    MessageBox.Show("Guardado con exito.");
                    Limpiar();
                }
                else
                    MessageBox.Show("Error! no se pudo guardar.");
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
                    NombresClientescomboBox.Text = factura.NombreCliente;
                    FechadateTimePicker.Value = factura.Fecha;
                    MontotextBox.Text = factura.Monto.ToString();
                    RecibidotextBox.Text = factura.DineroPagado.ToString();
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

        private decimal ExistenciaProducto()
        {
            decimal existecia = Detalle.Producto.Cantidad - CantidadnumericUpDown.Value;

            return existecia;
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            Detalle.Producto.Cantidad = ExistenciaProducto();

            if (Detalle.Producto.Cantidad >= 0)
            {
                Factura.AgregarDetalle(Detalle.Producto, CantidadnumericUpDown.Value);
                LlenarDataGrid(Factura);

                CalculoMonto();
            }
            else
            {
                MessageBox.Show("No que en existencia ese producto.");
            }
        }

        private void CalculoMonto()
        {
            Factura.Monto += Detalle.Producto.Precio * CantidadnumericUpDown.Value;
            MontotextBox.Text = Factura.Monto.ToString();

            RecibidotextBox.Focus();
        }

        private void CalcularDevuelta()
        {
            Factura.DineroPagado = Utilidades.TOINT(RecibidotextBox.Text);

            if (Factura.DineroPagado < Factura.Monto)
            {
                MessageBox.Show("El dinero no es suficiente para cubrir su comprar.");
                RecibidotextBox.Clear();
                RecibidotextBox.Focus();
            }
            else
            {
                Factura.Devuelta = Factura.DineroPagado - Factura.Monto;
                DevueltatextBox.Text = Factura.Devuelta.ToString();
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

        private void BuscarProductobutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ProductocomboBox.SelectedValue);

            Detalle.Producto = BLL.ProductosBLL.Buscar(p => p.ProductoId == id);

            if (Detalle.Producto != null)
            {
                PreciotextBox.Text = Detalle.Producto.Precio.ToString();
                CantidadnumericUpDown.Focus();
            }
        }

        private void RecibidotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                CalcularDevuelta();
            }
        }
    }
}
