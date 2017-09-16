using BLL;
using Entidades;
using GimnasioTech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GimnacioTechWeb
{
    public partial class ClientesForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private Clientes LlenarCampos()
        {
            Clientes cliente = new Clientes();

            cliente.ClienteId = Utilidades.TOINT(ClienteIdTextBox.Text);
            cliente.Nombres = NombreClienteTextBox.Text;
            cliente.Sexo = SexoTextBox.Text;
            //cliente.FechaInscripcion = fechaInscripcionDateTimePicker.Value;
            cliente.Direccion = DireccionTextBox.Text;
            cliente.NumeroCelular = NumeroCelularTextBox.Text;
            cliente.Email = EmailTextBox.Text;

            return cliente;
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            //if (Validar())
            //{
                Clientes cliente = new Clientes();
                cliente = LlenarCampos();
                ClientesBLL.Guardar(cliente);

                /*if (validarEmail())
                {
                    if (ClientesBLL.Guardar(cliente))
                    {
                        clienteIdMaskedTextBox.Text = cliente.ClienteId.ToString();
                        MessageBox.Show("Guardado con exito.");
                    }
                    else
                        MessageBox.Show("Error! no se pudo guardar.");
                }
            }*/
        }
    }
}