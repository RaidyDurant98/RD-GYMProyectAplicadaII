using BLL;
using Entidades;
using GimnasioTech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GimnacioTechWeb.Formularios
{
    public partial class UsuariosForm : System.Web.UI.Page
    {
        public Usuarios usuario;

        protected void Page_Load(object sender, EventArgs e)
        {
            usuario = new Usuarios();
            AlertSuccessPanel.Visible = false;
            AlertInfoPanel.Visible = false;
            AlertDangerPanel.Visible = false;
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
            UsuarioIdTextBox.Text = "";
            NombresTextBox.Text = "";
            NombreUsuarioTextBox.Text = "";
            ClaveTextBox.Text = "";
            ConfirmarClaveTextBox.Text = "";
            CargoDropDownList.Text = "";
            FechaIngresoTextBox.Text = "";

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
            if (string.IsNullOrEmpty(NombreUsuarioTextBox.Text))
            {
                interruptor = false;
            }
            if (string.IsNullOrEmpty(ClaveTextBox.Text))
            {
                interruptor = false;
            }
            if (string.IsNullOrEmpty(ConfirmarClaveTextBox.Text))
            {
                interruptor = false;
            }
            if (string.IsNullOrEmpty(CargoDropDownList.Text))
            {
                interruptor = false;
            }
            if(string.IsNullOrEmpty(FechaIngresoTextBox.Text))
            {
                interruptor = false;
            }

            return interruptor;
        }

        private Usuarios LlenarCampos()
        {
            usuario.UsuarioId = Utilidades.TOINT(UsuarioIdTextBox.Text);
            usuario.Nombres = NombresTextBox.Text;
            usuario.NombreUsuario = NombreUsuarioTextBox.Text;
            usuario.Clave = ClaveTextBox.Text;
            //usuario.ConfirmarClave = ConfirmarClaveTextBox.Text;
            usuario.Cargo = CargoDropDownList.Text;
            usuario.FechaIngreso = Convert.ToDateTime(FechaIngresoTextBox.Text);

            return usuario;
        }

        private void BuscarUsuario()
        {
            if (string.IsNullOrEmpty(UsuarioIdTextBox.Text))
            {
                AsignarTextoAlertaInfo("Digite el id del usuario que desea buscar.");
            }
            else
            {
                int id = Utilidades.TOINT(UsuarioIdTextBox.Text);

                usuario = UsuariosBLL.Buscar(p => p.UsuarioId == id);

                if (usuario != null) {

                    NombresTextBox.Text = usuario.Nombres;
                    NombreUsuarioTextBox.Text = usuario.NombreUsuario;
                    //ClaveTextBox.Text = usuario.Clave;
                    //ConfirmarClaveTextBox.Text = usuario.ConfirmarClave;
                    FechaIngresoTextBox.Text = (usuario.FechaIngreso.Year +"/"+ usuario.FechaIngreso.Month +"/"+ usuario.FechaIngreso.Day); 
                    CargoDropDownList.Text = usuario.Cargo;
                }
                else
                {
                    AsignarTextoAlertaInfo("No existe usuario con ese id.");
                }
            }
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                usuario = LlenarCampos();

                if(usuario.UsuarioId != 0 || UsuariosBLL.Buscar(p => p.NombreUsuario == NombreUsuarioTextBox.Text) == null)
                {
                    if(ClaveTextBox.Text == ConfirmarClaveTextBox.Text)
                    {
                        if (UsuariosBLL.Guardar(usuario))
                        {
                            UsuarioIdTextBox.Text = Convert.ToString(usuario.UsuarioId);
                            AsignarTextoAlertaSuccess("Usuario guardado con exito.");
                        }
                        else
                        {
                            AsignarTextoAlertaDanger("No se pudo guardar el usuario.");
                        }
                    }
                    else
                    {
                        AsignarTextoAlertaInfo("Las clave de confirmacion es incorrecta.");
                    }
                }
                else
                {
                    AsignarTextoAlertaInfo("El Nombre de usuario insertado ya existe.");
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
            BuscarUsuario();
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
                int id = Utilidades.TOINT(UsuarioIdTextBox.Text);

                if (UsuariosBLL.Eliminar(UsuariosBLL.Buscar(p => p.UsuarioId == id)))
                {
                    Limpiar();
                    AsignarTextoAlertaSuccess("Usuario eliminado con exito.");                
                }
                else
                {
                    AsignarTextoAlertaDanger("No se puedo eliminar el usuario.");
                }
        }

        protected void EnviarAlModalEliminarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsuarioIdTextBox.Text))
            {
                AsignarTextoAlertaInfo("Ingresar el id del usuario que desea eliminar.");
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "showModal();", true);
            }
        }
    }
}