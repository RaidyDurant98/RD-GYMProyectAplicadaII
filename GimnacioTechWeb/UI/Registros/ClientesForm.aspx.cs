﻿using BLL;
using Entidades;
using GimnasioTech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GimnacioTechWeb
{
    public partial class ClientesForm : System.Web.UI.Page
    {
        public Entidades.Clientes cliente;

        protected void Page_Load(object sender, EventArgs e)
        {
            cliente = new Clientes();
            AlertSuccessPanel.Visible = false;
            AlertInfoPanel.Visible = false;
            AlertDangerPanel.Visible = false;


            if (Consultas.ClientesConsulta.Cliente != null)
            {
                cliente = Consultas.ClientesConsulta.Cliente;
                DatosCliente();
                Consultas.ClientesConsulta.Cliente = null;
            }
        }

        private void AsignarTextoAlertaInfo(string texto)
        {
            AlertInfoLabel.Text = texto;
            AlertInfoPanel.Visible = true;
        }

        private void AsignarTextoAlertaSuccess(string texto)
        {
            AlertSuccessLabel.Text = texto;
            AlertSuccessPanel.Visible = true;
        }

        private void AsignarTextoAlertaWarning(string texto)
        {
            AlertWarningLabel.Text = texto;
            AlertWarningPanel.Visible = true;
        }

        private void AsignarTextoAlertaDanger(string texto)
        {
            AlertDangerLabel.Text = texto;
            AlertDangerPanel.Visible = true;
        }

        private void Limpiar()
        {
            ClienteIdTextBox.Text = "";
            NombresTextBox.Text = "";
            DireccionTextBox.Text = "";
            NumeroCelularTextBox.Text = "";
            EmailTextBox.Text = "";
            FechaInscripcionTextBox.Text = "";
            MasculinoRadioButton.Checked = false;
            FemeninoRadioButton.Checked = false;

            AlertSuccessPanel.Visible = false;
            AlertInfoPanel.Visible = false;
            AlertDangerPanel.Visible = false;
        }

        private bool Validar()
        {
            bool interruptor = true;

            if (string.IsNullOrEmpty(NombresTextBox.Text))
            {
                interruptor = false;
            }
            if (string.IsNullOrEmpty(DireccionTextBox.Text))
            {
                interruptor = false;
            }
            if (string.IsNullOrEmpty(EmailTextBox.Text))
            {
                interruptor = false;
            }
            if (string.IsNullOrEmpty(NumeroCelularTextBox.Text))
            {
                interruptor = false;
            }
            if (string.IsNullOrEmpty(FechaInscripcionTextBox.Text))
            {
                interruptor = false;
            }
            if (MasculinoRadioButton.Checked == false && FemeninoRadioButton.Checked == false)
            {
                interruptor = false;
            }

            return interruptor;
        }

        private void DatosCliente()
        {
            ClienteIdTextBox.Text = cliente.ClienteId.ToString();
            NombresTextBox.Text = cliente.Nombres;
            DireccionTextBox.Text = cliente.Direccion;
            NumeroCelularTextBox.Text = cliente.NumeroCelular;
            EmailTextBox.Text = cliente.Email;
            FechaInscripcionTextBox.Text = cliente.FechaInscripcion.ToString("yyyy-MM-dd");
            if (cliente.Sexo == "Masculino")
            {
                MasculinoRadioButton.Checked = true;
            }
            else
            {
                FemeninoRadioButton.Checked = true;
            }
        }

        private void BuscarCliente()
        {
            if (string.IsNullOrEmpty(ClienteIdTextBox.Text))
            {
                AsignarTextoAlertaInfo("Digite el id del cliente que desea buscar.");
            }
            else
            {
                int id = Utilidades.TOINT(ClienteIdTextBox.Text);

                cliente = ClientesBLL.Buscar(p => p.ClienteId == id);

                if (cliente != null)
                {
                    DatosCliente();
                }
                else
                {
                    AsignarTextoAlertaInfo("No existe cliente con ese id.");
                }
            }
        }

        private Clientes LlenarCampos()
        {
            cliente.ClienteId = Utilidades.TOINT(ClienteIdTextBox.Text);
            cliente.Nombres = NombresTextBox.Text;
            cliente.FechaInscripcion = Convert.ToDateTime(FechaInscripcionTextBox.Text); ;
            cliente.Direccion = DireccionTextBox.Text;
            cliente.NumeroCelular = NumeroCelularTextBox.Text;
            cliente.Email = EmailTextBox.Text;

            if (MasculinoRadioButton.Checked == true)
            {
                cliente.Sexo = "Masculino";
            }
            else
            {
                cliente.Sexo = "Femenino";
            }

            return cliente;
        }

        private bool ValidarEmail()
        {
            bool interruptor = true;
            Regex regEmail = new Regex(@"^(([^<>()[\]\\.,;:\s@\""]+"
                           + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                           + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}"
                           + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                           + @"[a-zA-Z]{2,}))$",
                           RegexOptions.Compiled);

            if (EmailTextBox.Text != "")
            {
                if (!regEmail.IsMatch(EmailTextBox.Text))
                {
                    interruptor = false;
                }
            }

            return interruptor;
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (ValidarEmail())
                {
                    cliente = LlenarCampos();

                    if (ClientesBLL.Guardar(cliente))
                    {
                        ClienteIdTextBox.Text = Convert.ToString(cliente.ClienteId);
                        AsignarTextoAlertaSuccess("Cliente guardado con exito.");
                    }
                    else
                    {
                        AsignarTextoAlertaDanger("No se pudo guardar el cliente.");
                    }
                }
                else
                {
                    AsignarTextoAlertaInfo("El email ingresado no es valido.");
                }
            }
            else
            {
                AsignarTextoAlertaInfo("Favor llenar los campos vacios.");
            }
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        protected void EnviarAlModalEliminarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ClienteIdTextBox.Text))
            {
                AsignarTextoAlertaInfo("Ingresar el id del cliente que desea eliminar.");
            }
            else
            {
                int id = Utilidades.TOINT(ClienteIdTextBox.Text);

                cliente = ClientesBLL.Buscar(p => p.ClienteId == id);

                if (cliente != null)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "#ModalEliminar", "showModalEliminar();", true);
                }
                else
                {
                    AsignarTextoAlertaInfo("no existe cliente con ese id.");
                }
            }

        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.TOINT(ClienteIdTextBox.Text);

            if (ClientesBLL.Eliminar(ClientesBLL.Buscar(p => p.ClienteId == id)))
            {
                Limpiar();
                AsignarTextoAlertaSuccess("Cliente eliminado con exito.");
            }
            else
            {
                AsignarTextoAlertaDanger("No se pudo eliminar el cliente.");
            }
        }

        protected void SingOutButton_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            System.Web.Security.FormsAuthentication.RedirectToLoginPage();
        }
    }
}