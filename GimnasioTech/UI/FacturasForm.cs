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
            RecibidomaskedTextBox.Clear();
            ClienteerrorProvider.Clear();
            CantidaderrorProvider.Clear();
            ProductoerrorProvider.Clear();
            RecibidoerrorProvider.Clear();
            GriderrorProvider.Clear();

            RecibidomaskedTextBox.Enabled = false;
            CantidadnumericUpDown.Enabled = false;
        }

        private bool Validar()
        {
            bool interruptor = true;

            if (string.IsNullOrEmpty(NombresClientescomboBox.Text))
            {
                ClienteerrorProvider.SetError(NombresClientescomboBox, "Por favor llenar el campo.");
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
                    NombresClientescomboBox.Text = factura.NombreCliente;
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

        private decimal ExistenciaProducto()
        {
            decimal existecia = Detalle.Producto.Cantidad - CantidadnumericUpDown.Value;

            return existecia;
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            AgregarProducto();
        }

        private void AgregarProducto()
        {
            //Detalle.Producto.Cantidad = ExistenciaProducto();

            if (ProductocomboBox.SelectedItem != null)
            {
                if (CantidadnumericUpDown.Value != 0)
                {
                    Factura.AgregarDetalle(Detalle.Producto, CantidadnumericUpDown.Value);
                    LlenarDataGrid(Factura);

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
                ProductoerrorProvider.SetError(ProductocomboBox, "Eliga un producto.");
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
            int id = Convert.ToInt32(ProductocomboBox.SelectedValue);

            Detalle.Producto = BLL.ProductosBLL.Buscar(p => p.ProductoId == id);

            if (ProductocomboBox.SelectedItem != null)
            {
                if (Detalle.Producto != null)
                {
                    PreciotextBox.Text = Detalle.Producto.Precio.ToString();
                    CantidadnumericUpDown.Enabled = true;
                    CantidadnumericUpDown.Focus();
                }
            }
            else
            {
                ProductoerrorProvider.SetError(ProductocomboBox, "Eliga un producto.");
            }
        }

        private void BuscarProductobutton_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void ProductocomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                BuscarProducto();
            }
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
                CantidadnumericUpDown.Value = 0;
            }
        }

        private void CantidadnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CantidaderrorProvider.Clear();
        }

        private void ProductocomboBox_TextChanged(object sender, EventArgs e)
        {
            ProductoerrorProvider.Clear();
        }

        private void NombresClientescomboBox_TextChanged(object sender, EventArgs e)
        {
            ClienteerrorProvider.Clear();
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

                if (DevueltatextBox.Text != null)
                {
                    Guardarbutton.Focus();
                }
            }
        }

        private void RecibidomaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            RecibidoerrorProvider.Clear();
        }
    }
}
