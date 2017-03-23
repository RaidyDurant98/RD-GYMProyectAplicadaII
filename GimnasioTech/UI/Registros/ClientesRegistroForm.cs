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
    public partial class ClientesRegistroForm : Form
    {
        public ClientesRegistroForm()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            clienteIdMaskedTextBox.Clear();
            nombresTextBox.Clear();
            sexoComboBox.Text = null;
            fechaInscripcionDateTimePicker.Value = DateTime.Today;
            direccionTextBox.Clear();
            numeroCelularMaskedTextBox.Clear();
            EmailtextBox.Clear();
        }

        private bool Validar()
        {
            bool interruptor = true;

            if (string.IsNullOrEmpty(nombresTextBox.Text))
            {
                NombreerrorProvider.SetError(nombresTextBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }
            if (string.IsNullOrEmpty(sexoComboBox.Text))
            {
                SexoerrorProvider.SetError(sexoComboBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }
            if (string.IsNullOrEmpty(direccionTextBox.Text))
            {
                DireccionerrorProvider.SetError(direccionTextBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }
            if (numeroCelularMaskedTextBox.Text.Length < 12)
            {
                NumeroCelularerrorProvider.SetError(numeroCelularMaskedTextBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }
            if (string.IsNullOrEmpty(EmailtextBox.Text))
            {
                EmailerrorProvider.SetError(EmailtextBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }


            return interruptor;
        }

        private Clientes LlenarCampos()
        {
            Clientes cliente = new Clientes();

            cliente.ClienteId = Utilidades.TOINT(clienteIdMaskedTextBox.Text);
            cliente.Nombres = nombresTextBox.Text;
            cliente.Sexo = sexoComboBox.SelectedItem.ToString();
            cliente.FechaInscripcion = fechaInscripcionDateTimePicker.Value;
            cliente.Direccion = direccionTextBox.Text;
            cliente.NumeroCelular = numeroCelularMaskedTextBox.Text;
            cliente.Email = EmailtextBox.Text;

            return cliente;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();

            if (!Validar())
            {
                MessageBox.Show("Por favor llenar los campos vacios.");
            }
            else
            {
                cliente = LlenarCampos();

                if (ClientesBLL.Guardar(cliente))
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
            BuscarCliente();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(clienteIdMaskedTextBox.Text))
            {
                MessageBox.Show("Por favor insertar el id del cliente que desea eliminar.");
                Limpiar();
            }
            else
            {
                DialogResult eliminar = MessageBox.Show("¿Seguro desea eliminar el cliente seleccionado?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (eliminar == DialogResult.Yes)
                {
                    int id = Utilidades.TOINT(clienteIdMaskedTextBox.Text);

                    if (ClientesBLL.Eliminar(ClientesBLL.Buscar(p => p.ClienteId == id)))
                    {
                        Limpiar();
                        MessageBox.Show("Cliente eliminado con exito.");
                    }
                    else
                        MessageBox.Show("No se pudo eliminar el cliente.");
                }
            }
        }

        private void BuscarCliente()
        {
            if (string.IsNullOrEmpty(clienteIdMaskedTextBox.Text))
            {
                MessageBox.Show("Por favor insertar el id que desea buscar.");
                Limpiar();
            }
            else
            {
                int id = Utilidades.TOINT(clienteIdMaskedTextBox.Text);
                Clientes cliente = new Clientes();

                cliente = ClientesBLL.Buscar(p => p.ClienteId == id);

                if (cliente != null)
                {
                    nombresTextBox.Text = cliente.Nombres;
                    sexoComboBox.Text = cliente.Sexo;
                    fechaInscripcionDateTimePicker.Value = cliente.FechaInscripcion;
                    direccionTextBox.Text = cliente.Direccion;
                    numeroCelularMaskedTextBox.Text = cliente.NumeroCelular;
                    EmailtextBox.Text = cliente.Email;
                }
                else
                {
                    MessageBox.Show("El cliente no exite.");
                    Limpiar();
                }
            }
        }

        private void clienteIdMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                BuscarCliente();
            }
        }

        private void nombresTextBox_TextChanged(object sender, EventArgs e)
        {
            NombreerrorProvider.Clear();
        }

        private void sexoComboBox_TextChanged(object sender, EventArgs e)
        {
            SexoerrorProvider.Clear();
        }

        private void direccionTextBox_TextChanged(object sender, EventArgs e)
        {
            DireccionerrorProvider.Clear();
        }

        private void numeroCelularMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            NumeroCelularerrorProvider.Clear();
        }

        private void EmailtextBox_TextChanged(object sender, EventArgs e)
        {
            EmailerrorProvider.Clear();
        }
    }
}
