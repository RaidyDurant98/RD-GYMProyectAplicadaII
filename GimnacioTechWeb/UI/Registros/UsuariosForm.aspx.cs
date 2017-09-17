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


        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario = LlenarCampos();
            if (UsuariosBLL.Guardar(usuario))
            {
                UsuarioIdTextBox.Text = Convert.ToString(usuario.UsuarioId);
            }
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.TOINT(UsuarioIdTextBox.Text);
            Usuarios usuario = new Usuarios();
            usuario = UsuariosBLL.Buscar(p => p.UsuarioId == id);

            if (usuario != null)
            {
                NombresTextBox.Text = usuario.Nombres;
                NombreUsuarioTextBox.Text = usuario.NombreUsuario;
                ClaveTextBox.Text = usuario.Clave;
                ConfirmarClaveTextBox.Text = usuario.ConfirmarClave;
                FechaIngresoTextBox.Text = Convert.ToString(usuario.FechaIngreso);
                CargoDropDownList.Text = usuario.Cargo;               
            }
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.TOINT(UsuarioIdTextBox.Text);

            if(id != 0)
            {
                if (UsuariosBLL.Eliminar(UsuariosBLL.Buscar(p => p.UsuarioId == id)))
                {
                    Limpiar();
                }
            }
        }
    }
}