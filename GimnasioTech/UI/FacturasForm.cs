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
            LlenarLabel();
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
            ComentariotextBox.Clear();
            NombreClienteerrorProvider.Clear();
            CantidaderrorProvider.Clear();
            ProductoerrorProvider.Clear();
            RecibidoerrorProvider.Clear();
            GriderrorProvider.Clear();
            ClienteIderrorProvider.Clear();
            FacturaIderrorProvider.Clear();
            DevueltaerrorProvider.Clear();
            FormaPagoComboBox.Text = null;

            ClienteIdmaskedTextBox.Enabled = true;
            ProductoIdmaskedTextBox.Enabled = true;
            FechadateTimePicker.Enabled = true;
            ComentariotextBox.Enabled = true;
            FormaPagoComboBox.Enabled = true;
            ProductodataGridView.Enabled = true;
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
            if (string.IsNullOrEmpty(FormaPagoComboBox.Text))
            {
                FormaPagoerrorProvider.SetError(FormaPagoComboBox, "Por favor Elija la forma de pago.");
                interruptor = false;
            }

            return interruptor;
        }

        private Entidades.Facturas LlenarCampos()
        {
            Factura.NombreCliente = NombreClientetextBox.Text;
            Factura.NombreUsuario = NombreUsuariolabel.Text;
            Factura.FacturaId = Utilidades.TOINT(FacturaIdmaskedTextBox.Text);
            Factura.Monto = Utilidades.TOINT(MontotextBox.Text);
            Factura.Fecha = FechadateTimePicker.Value;
            Factura.DineroPagado = Utilidades.TOINT(RecibidomaskedTextBox.Text);
            Factura.Devuelta = Utilidades.TOINT(DevueltatextBox.Text);
            Factura.Comentario = ComentariotextBox.Text;
            Factura.FormaPago = FormaPagoComboBox.Text;

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
            RecibidomaskedTextBox.Enabled = false;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (FormaPagoComboBox.Text == "Contado")
                {
                    if (string.IsNullOrEmpty(RecibidomaskedTextBox.Text))
                    {
                        RecibidoerrorProvider.SetError(RecibidomaskedTextBox, "Por favor llenar el campo.");
                    }
                    else if (string.IsNullOrEmpty(DevueltatextBox.Text))
                    {
                        DevueltaerrorProvider.SetError(DevueltatextBox, "Por favor llenar el campo.");
                    }
                    else
                    {
                        Factura = LlenarCampos();

                        if (BLL.FacturasBLL.Guardar(Factura))
                        {
                            ReducirExistenciaProducto(CantidadnumericUpDown.Value);
                            MessageBox.Show("Guardado con exito.");
                            Limpiar();
                            RecibidomaskedTextBox.Enabled = false;
                        }
                        else
                            MessageBox.Show("Error! no se pudo guardar.");
                    }
                }
                else if(FormaPagoComboBox.Text == "Credito")
                {
                    Factura = LlenarCampos();

                    if (BLL.FacturasBLL.Guardar(Factura))
                    {
                        ReducirExistenciaProducto(CantidadnumericUpDown.Value);
                        MessageBox.Show("Guardado con exito.");
                        Limpiar();
                        RecibidomaskedTextBox.Enabled = false;
                    }
                    else
                        MessageBox.Show("Error! no se pudo guardar.");
                }
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            BuscarFactura();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FacturaIdmaskedTextBox.Text))
            {
                MessageBox.Show("Por favor insertar el id de la factura que desea eliminar.");
            }
            else
            {
                VerificarExistenciaFactura();

                if (Factura != null)
                {
                    DialogResult eliminar = MessageBox.Show("¿Seguro desea eliminar la factura seleccionada?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (eliminar == DialogResult.Yes)
                    {
                        int id = Utilidades.TOINT(FacturaIdmaskedTextBox.Text);

                        if (BLL.FacturasBLL.Eliminar(BLL.FacturasBLL.Buscar(p => p.FacturaId == id)))
                        {
                            AumentarExistenciaProducto(CantidadnumericUpDown.Value);

                            Limpiar();
                            RecibidomaskedTextBox.Enabled = false;
                        }
                        else
                            MessageBox.Show("No se pudo eliminar la factura.");
                    }
                }
                else
                {
                    FacturaIderrorProvider.SetError(FacturaIdmaskedTextBox, "No existe factura con ese id.");
                    FacturaIdmaskedTextBox.Focus();
                }
            }
        }

        private void BuscarProductobutton_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void BuscarClientebutton_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void Devueltabutton_Click(object sender, EventArgs e)
        {
            CalcularDevuelta();
        }

        private void VerificarExistenciaFactura()
        {
            int id = Utilidades.TOINT(FacturaIdmaskedTextBox.Text);
            Factura = BLL.FacturasBLL.Buscar(p => p.FacturaId == id);
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
                VerificarExistenciaFactura();

                if (Factura != null)
                {
                    NombreClientetextBox.Text = Factura.NombreCliente;
                    NombreUsuariolabel.Text = Factura.NombreUsuario;
                    FechadateTimePicker.Value = Factura.Fecha;
                    MontotextBox.Text = Factura.Monto.ToString();
                    RecibidomaskedTextBox.Text = Factura.DineroPagado.ToString();
                    DevueltatextBox.Text = Factura.Devuelta.ToString();
                    ComentariotextBox.Text = Factura.Comentario;
                    FormaPagoComboBox.Text = Factura.FormaPago;

                    LlenarDataGrid(Factura);

                    ClienteIdmaskedTextBox.Enabled = false;
                    ProductoIdmaskedTextBox.Enabled = false;
                    RecibidomaskedTextBox.Enabled = false;
                    ProductodataGridView.Enabled = false;
                    FechadateTimePicker.Enabled = false;
                    ComentariotextBox.Enabled = false;
                    FormaPagoComboBox.Enabled = false;
                }
                else
                {
                    MessageBox.Show("La factura no exite.");
                    Limpiar();
                }
            }
        }

        private void ReducirExistenciaProducto(decimal cantidad)
        {
            foreach (DataGridViewRow producto in ProductodataGridView.Rows)
            {
                int id = Convert.ToInt32(producto.Cells[2].Value);
                cantidad = Convert.ToDecimal(producto.Cells[5].Value);

                Detalle.Producto = BLL.ProductosBLL.BuscarOtro(id);
                Detalle.Producto.Cantidad -= cantidad;
                BLL.ProductosBLL.Modificar(Detalle.Producto);
            }
        }

        private void AumentarExistenciaProducto(decimal cantidad)
        {
            foreach (DataGridViewRow producto in ProductodataGridView.Rows)
            {
                int id = Convert.ToInt32(producto.Cells[2].Value);
                cantidad = Convert.ToDecimal(producto.Cells[5].Value);

                Detalle.Producto = BLL.ProductosBLL.BuscarOtro(id);
                Detalle.Producto.Cantidad += cantidad;
                BLL.ProductosBLL.Modificar(Detalle.Producto);
            }
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
                    if (Detalle.Producto.Cantidad >= CantidadnumericUpDown.Value)
                    {
                        bool productoAgregado = false;
                        foreach (var producto in Factura.Relacion)
                        {
                            if (Detalle.Producto.ProductoId == producto.ProductoId)
                            {
                                productoAgregado = true;
                                break;
                            }
                        }
                        if (!productoAgregado)
                        {
                            Factura.Relacion.Add(new Entidades.FacturasProductos(Factura.FacturaId, Detalle.Producto.ProductoId, Detalle.Producto.Descripcion, Detalle.Producto.Precio, CantidadnumericUpDown.Value));
                            LlenarDataGrid(Factura);

                            CantidadnumericUpDown.Enabled = false;
                            CalculoMonto();
                            ProductoIdmaskedTextBox.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Este producto ya esta agregado en la factura.");
                            DescripcionProductotextBox.Clear();
                            PreciotextBox.Clear();
                            CantidadnumericUpDown.Text = "0";
                            CantidadnumericUpDown.Enabled = false;
                            ProductoIdmaskedTextBox.Focus();
                        }
                    }
                    else
                    {
                        if (Detalle.Producto.Cantidad <= 0)
                        {
                            MessageBox.Show("No queda producto de ese tipo");
                            ProductoIdmaskedTextBox.Clear();
                            DescripcionProductotextBox.Clear();
                            CantidadnumericUpDown.Text = "0";

                            ProductoIdmaskedTextBox.Focus();
                        }
                        else
                        {
                            MessageBox.Show("La cantidad excede la existencia, se cuenta con (" + Detalle.Producto.Cantidad + ") " + Detalle.Producto.Descripcion + ".");
                            CantidadnumericUpDown.Focus();
                        }
                    }
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

            ClienteIdmaskedTextBox.Clear();
        }

        private void CalculoMonto()
        {
            decimal monto = 0;
            foreach (DataGridViewRow producto in ProductodataGridView.Rows)
            {
                monto += Convert.ToDecimal(producto.Cells[4].Value) * Convert.ToDecimal(producto.Cells[5].Value);
            }

            Factura.Monto = monto;
            MontotextBox.Text = Factura.Monto.ToString();       
        }

        private void CalcularDevuelta()
        {
            DevueltaerrorProvider.Clear();
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
                    ProductoIdmaskedTextBox.Clear();
                    ProductoerrorProvider.SetError(ProductoIdmaskedTextBox, "No existe un producto con ese id.");
                    DescripcionProductotextBox.Clear();
                    PreciotextBox.Clear();
                    CantidadnumericUpDown.Enabled = false;
                    ProductoIdmaskedTextBox.Focus();
                }
            }
            else
            {
                DescripcionProductotextBox.Clear();
                ProductoerrorProvider.SetError(ProductoIdmaskedTextBox, "Digite el id de un producto.");
                ProductoIdmaskedTextBox.Focus();
            }
        }

        private void LlenarLabel()
        {
            NombreUsuariolabel.Text = InicioSesionForm.GetUsuario().Nombres;
        }

        private void FacturaIdmaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                BuscarFactura();
                FacturaIderrorProvider.Clear();
            }
        }

        private void CantidadnumericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                AgregarProducto();
                ClienteIdmaskedTextBox.Clear();
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
            if (FormaPagoComboBox.Text == "Contado" || FormaPagoComboBox.Text == "")
            {               
                RecibidomaskedTextBox.Enabled = true;
                RecibidomaskedTextBox.Focus();
            }
            DevueltatextBox.Clear();
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
            CantidadnumericUpDown.Text = "0";
            DescripcionProductotextBox.Clear();
            PreciotextBox.Clear();
            ProductoerrorProvider.Clear();
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
                    FormaPagoComboBox.Focus();
                }
                else
                {
                    ClienteIdmaskedTextBox.Clear();
                    NombreClientetextBox.Clear();
                    ClienteIderrorProvider.SetError(ClienteIdmaskedTextBox, "No existe un cliente con ese id.");
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

        private void NombreClientetextBox_TextChanged(object sender, EventArgs e)
        {
            NombreClienteerrorProvider.Clear();
        }

        private void FacturaIdmaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            FacturaIderrorProvider.Clear();
        }

        private void RegistroClientebutton_Click(object sender, EventArgs e)
        {
            new UI.Registros.ClientesRegistroForm().Show();
        }

        private void ProductodataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalculoMonto();
        }

        private void FormaPagoComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProductoIdmaskedTextBox.Focus();
        }

        private void FormaPagoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormaPagoerrorProvider.Clear();
            if (FormaPagoComboBox.Text == "Credito")
            {
                RecibidomaskedTextBox.Clear();
                DevueltatextBox.Clear();
                RecibidomaskedTextBox.Enabled = false;
            }
            if (FormaPagoComboBox.Text == "Contado")
            {
                RecibidomaskedTextBox.Enabled = true;
            }
        }
    }
}
