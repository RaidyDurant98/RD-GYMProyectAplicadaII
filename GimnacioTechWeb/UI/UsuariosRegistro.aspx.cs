using BLL;
using Entidades;
using GimnacioTechWeb.Consultas;
using GimnasioTech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GimnacioTechWeb.UI.Registros
{
    public partial class UsuariosRegistro : System.Web.UI.Page
    {
        public Usuarios usuario;

        protected void Page_Load(object sender, EventArgs e)
        {
            usuario = new Usuarios();

            if (UI.UsuariosConsulta.Usuario != null)
            {
                usuario = UI.UsuariosConsulta.Usuario;
                CargarDatosUsuario();
                UI.UsuariosConsulta.Usuario = null;
            }
        }

        private void Limpiar()
        {
            UsuarioIdTextBox.Text = "";
            NombresTextBox.Text = "";
            NombreUsuarioTextBox.Text = "";
            ClaveTextBox.Text = "";
            ConfirmarClaveTextBox.Text = "";
            CargoDropDownList.Text = "Usuario";
            FechaIngresoTextBox.Text = "";
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
            if (string.IsNullOrEmpty(FechaIngresoTextBox.Text))
            {
                interruptor = false;
            }

            return interruptor;
        }

        private void CargarDatosUsuario()
        {
            UsuarioIdTextBox.Text = usuario.UsuarioId.ToString();
            NombresTextBox.Text = usuario.Nombres;
            NombreUsuarioTextBox.Text = usuario.NombreUsuario;
            ClaveTextBox.Text = usuario.Clave;
            ConfirmarClaveTextBox.Text = usuario.Clave;
            FechaIngresoTextBox.Text = usuario.FechaIngreso.ToString("yyyy-MM-dd");
            CargoDropDownList.Text = usuario.Cargo;
        }

        private Usuarios LlenarInstanciaUsuario()
        {
            usuario.UsuarioId = Utilidades.TOINT(UsuarioIdTextBox.Text);
            usuario.Nombres = NombresTextBox.Text;
            usuario.NombreUsuario = NombreUsuarioTextBox.Text;
            usuario.Clave = ClaveTextBox.Text;
            usuario.Cargo = CargoDropDownList.Text;
            usuario.FechaIngreso = Convert.ToDateTime(FechaIngresoTextBox.Text);

            return usuario;
        }

        private bool VerificarExistenciaUsuario()
        {
            if (string.IsNullOrEmpty(UsuarioIdTextBox.Text))
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Por favor digite el id del usuario');", addScriptTags: true);
            }
            else
            {
                int id = Utilidades.TOINT(UsuarioIdTextBox.Text);

                usuario = UsuariosBLL.Buscar(p => p.UsuarioId == id);

                if (usuario != null)
                {
                    return true;
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('No existe usuario con ese id');", addScriptTags: true);
                }
            }

            return false;
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            Entidades.Usuarios CompararNombreUsuario = UsuariosBLL.Buscar(p => p.NombreUsuario == NombreUsuarioTextBox.Text);

            if (Validar())
            {
                if (UsuariosBLL.Buscar(p => p.NombreUsuario == NombreUsuarioTextBox.Text) == null || UsuarioIdTextBox.Text == CompararNombreUsuario.UsuarioId.ToString())
                {
                    if (ClaveTextBox.Text == ConfirmarClaveTextBox.Text)
                    {
                        if (UsuariosBLL.Guardar(LlenarInstanciaUsuario()))
                        {
                            UsuarioIdTextBox.Text = Convert.ToString(usuario.UsuarioId);
                            ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Usuario guardado con exito');", addScriptTags: true);
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('No se pudo guardar el usuario');", addScriptTags: true);
                        }
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Las clave de confirmacion es incorrecta');", addScriptTags: true);
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('El Nombre de usuario insertado ya existe');", addScriptTags: true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Por favor llenar los campos vacios.');", addScriptTags: true);
            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            if (VerificarExistenciaUsuario())
            {
                CargarDatosUsuario();
            }
        }

        protected void EnviarAlModalEliminarButton_Click(object sender, EventArgs e)
        {
            if (VerificarExistenciaUsuario())
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "#ModalEliminar", "showModalEliminar();", true);               
            }
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.TOINT(UsuarioIdTextBox.Text);

            if (UsuarioIdTextBox.Text != "1")
            {
                if (UsuariosBLL.Eliminar(UsuariosBLL.Buscar(p => p.UsuarioId == id)))
                {
                    Limpiar();
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Usuario eliminado con exito');", addScriptTags: true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('No se puedo eliminar el usuario');", addScriptTags: true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('No puede eliminar el usuario maestro');", addScriptTags: true);
            }
        }
    }
}