﻿using BLL;
using Entidades;
using GimnasioTech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
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

            if (Consultas.UsuariosConsulta.Usuario != null)
            {
                usuario = Consultas.UsuariosConsulta.Usuario;
                DatosUsuario();
                Consultas.UsuariosConsulta.Usuario = null;
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

        private void DatosUsuario()
        {
            UsuarioIdTextBox.Text = usuario.UsuarioId.ToString();
            NombresTextBox.Text = usuario.Nombres;
            NombreUsuarioTextBox.Text = usuario.NombreUsuario;
            ClaveTextBox.Text = usuario.Clave;
            ConfirmarClaveTextBox.Text = usuario.Clave;
            FechaIngresoTextBox.Text = usuario.FechaIngreso.ToString("yyyy-MM-dd");
            CargoDropDownList.Text = usuario.Cargo;
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
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Digite el id del usuario que desea buscar');", addScriptTags: true);
            }
            else
            {
                int id = Utilidades.TOINT(UsuarioIdTextBox.Text);

                usuario = UsuariosBLL.Buscar(p => p.UsuarioId == id);

                if (usuario != null)
                {

                    DatosUsuario();
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('No existe usuario con ese id');", addScriptTags: true);
                }
            }
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
                        usuario = LlenarCampos();

                        if (UsuariosBLL.Guardar(usuario))
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
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Usuario eliminado con exito');", addScriptTags: true);

            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('No se puedo eliminar el usuario');", addScriptTags: true);
            }
        }

        protected void EnviarAlModalEliminarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsuarioIdTextBox.Text))
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Por favor ingresar el id del usuario que desea eliminar');", addScriptTags: true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "#ModalEliminar", "showModalEliminar();", true);
            }
        }

        protected void SingOutButton_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            System.Web.Security.FormsAuthentication.RedirectToLoginPage();
        }
    }
}