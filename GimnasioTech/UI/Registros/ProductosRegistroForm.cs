using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GimnasioTech.UI.Registros
{
    public partial class ProductosRegistroForm : Form
    {
        public ProductosRegistroForm()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            productoIdMaskedTextBox.Clear();
            descripcionTextBox.Clear();
            cantidadNumericUpDown.Value = 0;
            CostotextBox.Clear();
            PreciotextBox.Clear();
            fechaIngresoDateTimePicker.Value = DateTime.Today;

            DescripcionerrorProvider.Clear();
            PrecioerrorProvider.Clear();
            CostoerrorProvider.Clear();
            CantidaderrorProvider.Clear();
        }

        private bool Validar()
        {
            bool interruptor = true;

            if (string.IsNullOrEmpty(descripcionTextBox.Text))
            {
                DescripcionerrorProvider.SetError(descripcionTextBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }
            if (cantidadNumericUpDown.Value == 0)
            {
                CantidaderrorProvider.SetError(cantidadNumericUpDown, "Por favor llenar el campo vacio.");
                interruptor = false;
            }
            if (string.IsNullOrEmpty(CostotextBox.Text))
            {
                CostoerrorProvider.SetError(CostotextBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }
            if (string.IsNullOrEmpty(PreciotextBox.Text))
            {
                PrecioerrorProvider.SetError(PreciotextBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }

            return interruptor;
        }

        private Productos LlenarCampos()
        {
            Productos producto = new Productos();

            producto.ProductoId = Utilidades.TOINT(productoIdMaskedTextBox.Text);
            producto.Descripcion = descripcionTextBox.Text;
            producto.Cantidad = cantidadNumericUpDown.Value;
            producto.Costo = Utilidades.TOINT(CostotextBox.Text);
            producto.Precio = Utilidades.TOINT(PreciotextBox.Text);
            producto.FechaIngreso = fechaIngresoDateTimePicker.Value;

            return producto;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Productos producto = new Productos();

            if (!Validar())
            {
                MessageBox.Show("Por favor llenar los campos vacios.");
            }
            else
            {
                producto = LlenarCampos();

                if (ProductosBLL.Guardar(producto))
                {
                    productoIdMaskedTextBox.Text = producto.ProductoId.ToString();
                    MessageBox.Show("Guardado con exito.");
                }
                else
                    MessageBox.Show("Error! no se pudo guardar.");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(productoIdMaskedTextBox.Text))
            {
                MessageBox.Show("Por favor insertar el id del cliente que desea eliminar.");
                Limpiar();
            }
            else
            {
                DialogResult eliminar = MessageBox.Show("¿Seguro desea eliminar el producto seleccionado?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (eliminar == DialogResult.Yes)
                {
                    int id = Utilidades.TOINT(productoIdMaskedTextBox.Text);

                    if (ProductosBLL.Eliminar(ProductosBLL.Buscar(p => p.ProductoId == id)))
                    {
                        Limpiar();
                    }
                    else
                        MessageBox.Show("No se pudo eliminar el cliente.");
                }
            }
        }

        private void BuscarProducto()
        {
            if (string.IsNullOrEmpty(productoIdMaskedTextBox.Text))
            {
                MessageBox.Show("Por favor insertar el id que desea buscar.");
                Limpiar();
            }
            else
            {
                int id = Utilidades.TOINT(productoIdMaskedTextBox.Text);
                Productos producto = new Productos();

                producto = ProductosBLL.Buscar(p => p.ProductoId == id);

                if (producto != null)
                {
                    descripcionTextBox.Text = producto.Descripcion;
                    cantidadNumericUpDown.Value = producto.Cantidad;
                    CostotextBox.Text = producto.Costo.ToString();
                    PreciotextBox.Text = producto.Precio.ToString();
                    fechaIngresoDateTimePicker.Value = producto.FechaIngreso;
                }
                else
                {
                    MessageBox.Show("El Producto no exite.");
                    Limpiar();
                }
            }
        }

        private void CostotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void PreciotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void productoIdMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                BuscarProducto();
            }
        }

        private void descripcionTextBox_TextChanged(object sender, EventArgs e)
        {
            DescripcionerrorProvider.Clear();
        }

        private void cantidadNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CantidaderrorProvider.Clear();
        }

        private void CostotextBox_TextChanged(object sender, EventArgs e)
        {
            CostoerrorProvider.Clear();
        }

        private void PreciotextBox_TextChanged(object sender, EventArgs e)
        {
            PrecioerrorProvider.Clear();
        }
    }
}
