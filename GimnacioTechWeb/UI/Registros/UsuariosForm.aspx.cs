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
        protected void Page_Load(object sender, EventArgs e)
        {
            AlertSuccessPanel.Visible = false;
            AlertInfoPanel.Visible = false;
            AlertDangerPanel.Visible = false;
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
            Usuarios usuario = new Usuarios();

            usuario.UsuarioId = Utilidades.TOINT(UsuarioIdTextBox.Text);
            usuario.Nombres = NombresTextBox.Text;
            usuario.NombreUsuario = NombreUsuarioTextBox.Text;
            usuario.Clave = ClaveTextBox.Text;
            usuario.ConfirmarClave = ConfirmarClaveTextBox.Text;
            usuario.Cargo = CargoDropDownList.Text;
            usuario.FechaIngreso = Convert.ToDateTime(FechaIngresoTextBox.Text);

            return usuario;
        }

        private void BuscarUsuario()
        {
            if (string.IsNullOrEmpty(UsuarioIdTextBox.Text))
            {
                AlertInfoLabel.Text = "Digite el id del usuario que desea buscar.";
                AlertInfoPanel.Visible = true;
            }
            else
            {
                int id = Utilidades.TOINT(UsuarioIdTextBox.Text);
                Usuarios usuario = new Usuarios();

                usuario = UsuariosBLL.Buscar(p => p.UsuarioId == id);

                if (usuario != null) {

                    NombresTextBox.Text = usuario.Nombres;
                    NombreUsuarioTextBox.Text = usuario.NombreUsuario;
                    ClaveTextBox.Text = usuario.Clave;
                    ConfirmarClaveTextBox.Text = usuario.ConfirmarClave;
                    FechaIngresoTextBox.Text = usuario.FechaIngreso.ToString();
                    CargoDropDownList.Text = usuario.Cargo;
                }
                else
                {
                    AlertInfoLabel.Text = "No existe usuario con ese id.";
                    AlertInfoPanel.Visible = true;
                }
            }
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Usuarios usuario = new Usuarios();
                usuario = LlenarCampos();

                if(usuario.UsuarioId != 0 || UsuariosBLL.Buscar(p => p.NombreUsuario == NombreUsuarioTextBox.Text) == null)
                {
                    if(ClaveTextBox.Text == ConfirmarClaveTextBox.Text)
                    {
                        if (UsuariosBLL.Guardar(usuario))
                        {
                            UsuarioIdTextBox.Text = Convert.ToString(usuario.UsuarioId);
                            AlertSuccessLabel.Text = "Usuario guardado con exito.";
                            AlertSuccessPanel.Visible = true;
                        }
                        else
                        {
                            AlertDangerLabel.Text = "No se pudo guardar el usuario.";
                            AlertDangerPanel.Visible = true;
                        }
                    }
                    else
                    {
                        AlertInfoLabel.Text = "Las clave de confirmacion es incorrecta.";
                        AlertInfoPanel.Visible = true;
                    }
                }
                else
                {
                    AlertInfoLabel.Text = "El Nombre de usuario insertado ya existe.";
                    AlertInfoPanel.Visible = true;
                }
            }
            else
            {
                AlertInfoLabel.Text = "Favor llenar los campos vacios.";
                AlertInfoPanel.Visible = true;
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
            if (string.IsNullOrEmpty(UsuarioIdTextBox.Text))
            {
                AlertInfoLabel.Text = "Ingresar id del cliente que desea eliminar";
                AlertInfoPanel.Visible = true;
            }
            else
            {
                int id = Utilidades.TOINT(UsuarioIdTextBox.Text);

                if (UsuariosBLL.Eliminar(UsuariosBLL.Buscar(p => p.UsuarioId == id)))
                {
                    Limpiar();
                    AlertSuccessLabel.Text = "Usuario eliminado con exito.";
                    AlertSuccessPanel.Visible = true;                  
                }
                else
                {
                    AlertDangerLabel.Text = "No se puedo eliminar el usuario.";
                    AlertDangerPanel.Visible = true;
                }
            }
        }
    }
}