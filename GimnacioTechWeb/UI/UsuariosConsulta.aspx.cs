﻿using GimnasioTech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GimnacioTechWeb.UI
{
    public partial class UsuariosConsulta : System.Web.UI.Page
    {
        public static List<Entidades.Usuarios> Lista { get; set; }
        public static Entidades.Usuarios Usuario = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario = null;

            if (!Page.IsPostBack)
            {
                Lista = BLL.UsuariosBLL.GetListAll();
                CargarListaUsuario();
            }
            BotonImprimirVisibleSiHayListas();
            VisibleInvisibleFechas();
        }

        private void VisibleInvisibleFechas()
        {
            if (FiltrarFechaCheckBox.Checked == true)
            {
                FechaDesdeTextBox.Visible = true;
                FechaHastaTextBox.Visible = true;
                DesdeLabel.Visible = true;
                HastaLabel.Visible = true;
            }
            else
            {
                FechaDesdeTextBox.Visible = false;
                FechaHastaTextBox.Visible = false;
                DesdeLabel.Visible = false;
                HastaLabel.Visible = false;
                FechaDesdeTextBox.Text = "";
                FechaHastaTextBox.Text = "";

            }
        }

        private void Limpiar()
        {
            FiltrarDropDownList.SelectedIndex = 0;
            FiltroTextBox.Text = "";
            FechaDesdeTextBox.Text = "";
            FechaHastaTextBox.Text = "";     
        }

        private void CargarListaUsuario()
        {
            UsuariosConsultaGridView.DataSource = Lista;
            UsuariosConsultaGridView.DataBind();
        }

        private void BotonImprimirVisibleSiHayListas()
        {
            if (Lista == null || Lista.Count() == 0)
            {
                ImprimirButton.Visible = false;
            }
            else
            {
                ImprimirButton.Visible = true;
            }
        }

        private void Filtrar()
        {
            DateTime FechaDesde = new DateTime();
            DateTime FechaHasta = new DateTime();

            if (FiltrarFechaCheckBox.Checked)
            {
                FechaDesde = Convert.ToDateTime(FechaDesdeTextBox.Text);
                FechaHasta = Convert.ToDateTime(FechaHastaTextBox.Text);
            }

            if (FiltrarDropDownList.SelectedIndex == 0)
            {
                if (FiltrarFechaCheckBox.Checked)
                {
                    Lista = BLL.UsuariosBLL.GetList(p =>  p.FechaIngreso >= FechaDesde.Date && p.FechaIngreso <= FechaHasta.Date);
                }
                else
                {
                    Lista = BLL.UsuariosBLL.GetListAll();
                }
            }
            else if (FiltrarDropDownList.SelectedIndex != 0)
            {
                if (FiltrarDropDownList.SelectedIndex == 2)
                {
                    if (FiltrarFechaCheckBox.Checked)
                    {
                        Lista = BLL.UsuariosBLL.GetList(p => p.Nombres == FiltroTextBox.Text && p.FechaIngreso >= FechaDesde.Date && p.FechaIngreso <= FechaHasta.Date);
                    }
                    else
                    {
                        Lista = BLL.UsuariosBLL.GetList(p => p.Nombres == FiltroTextBox.Text);
                    }             
                }
                if (FiltrarDropDownList.SelectedIndex == 3)
                {
                    if (FiltrarFechaCheckBox.Checked)
                    {
                        Lista = BLL.UsuariosBLL.GetList(p => p.NombreUsuario == FiltroTextBox.Text && p.FechaIngreso >= FechaDesde.Date && p.FechaIngreso <= FechaHasta.Date);
                    }
                    else
                    {
                        Lista = BLL.UsuariosBLL.GetList(p => p.NombreUsuario == FiltroTextBox.Text);
                    }
                }
                if (FiltrarDropDownList.SelectedIndex == 4)
                {
                    if (FiltrarFechaCheckBox.Checked)
                    {
                        Lista = BLL.UsuariosBLL.GetList(p => p.Cargo == FiltroTextBox.Text && p.FechaIngreso >= FechaDesde.Date && p.FechaIngreso <= FechaHasta.Date);
                    }
                    else
                    {
                        Lista = BLL.UsuariosBLL.GetList(p => p.Cargo == FiltroTextBox.Text);
                    }
                }
                if (FiltrarDropDownList.SelectedIndex == 1)
                {
                    int id = Utilidades.TOINT(FiltroTextBox.Text);
                    if (FiltrarFechaCheckBox.Checked)
                    {
                        Lista = BLL.UsuariosBLL.GetList(p => p.UsuarioId == id && p.FechaIngreso >= FechaDesde.Date && p.FechaIngreso <= FechaHasta.Date);
                    }
                    else
                    {
                        Lista = BLL.UsuariosBLL.GetList(p => p.UsuarioId == id);
                    }
                }
            }
            CargarListaUsuario();
            if (Lista.Count() == 0)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('No existe usuario');", addScriptTags: true);
                ImprimirButton.Visible = false;
            }
        }

        protected void FiltroButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FiltroTextBox.Text) && FiltrarDropDownList.SelectedIndex != 0)
            {
                UsuariosConsultaGridView.DataBind();
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Por favor digite el dato del filtro');", addScriptTags: true);
                ImprimirButton.Visible = false;
            }
            else if (FiltrarFechaCheckBox.Checked)
            {
                if (string.IsNullOrEmpty(FechaDesdeTextBox.Text) || string.IsNullOrEmpty(FechaHastaTextBox.Text))
                {
                    UsuariosConsultaGridView.DataBind();
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Por favor elige el rango de la fecha');", addScriptTags: true);
                    ImprimirButton.Visible = false;
                }
                else
                {
                    Filtrar();
                    BotonImprimirVisibleSiHayListas();
                }
            }
            else
            {
                ImprimirButton.Visible = false;
                Filtrar();
                BotonImprimirVisibleSiHayListas();
            }
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            //
            // Se obtiene la fila seleccionada del gridview
            //
            GridViewRow row = UsuariosConsultaGridView.SelectedRow;

            //
            // Obtengo el id de la entidad que se esta editando
            // en este caso de la entidad Usuario
            //
            int id = Convert.ToInt32(UsuariosConsultaGridView.DataKeys[row.RowIndex].Value);

            Usuario = BLL.UsuariosBLL.Buscar(U => U.UsuarioId == id);
            if (Usuario != null)
            {
                if (Usuario.UsuarioId != 1)
                {
                    if (BLL.UsuariosBLL.Eliminar(Usuario))
                    {
                        Limpiar();

                        ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Usuario eliminado con exito');", addScriptTags: true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('No se pudo eliminar el usuario');", addScriptTags: true);
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('No se puedo eliminar el usuario maestro');", addScriptTags: true);
                }
            }

            Usuario = null;
            Lista = BLL.UsuariosBLL.GetListAll();
            CargarListaUsuario();
            BotonImprimirVisibleSiHayListas();
        }

        protected void ImprimirButton_Click(object sender, EventArgs e)
        {
            Filtrar();
            Server.Transfer("Reportes/UsuariosReporte.aspx");
        }

        protected void EnviarAlModalEliminarButton_Click(object sender, EventArgs e)
        {
            ImprimirButton.Visible = true;

            ScriptManager.RegisterStartupScript(this, this.GetType(), "#ModalEliminar", "showModalEliminar();", true);
        }

        protected void CancelarEliminacionButton_Click(object sender, EventArgs e)
        {
            ImprimirButton.Visible = true;
        }

        protected void EnviarAlModalModificarButton_Click(object sender, EventArgs e)
        {
            ImprimirButton.Visible = true;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "#ModalModificar", "showModalModificar();", true);
        }

        protected void ModificarButton_Click(object sender, EventArgs e)
        {
            //
            // Se obtiene la fila seleccionada del gridview
            //
            GridViewRow row = UsuariosConsultaGridView.SelectedRow;

            //
            // Obtengo el id de la entidad que se esta editando
            // en este caso de la entidad Usuario
            //
            int id = Convert.ToInt32(UsuariosConsultaGridView.DataKeys[row.RowIndex].Value);
            Usuario = BLL.UsuariosBLL.Buscar(U => U.UsuarioId == id);

            Response.Redirect("UsuariosRegistro.aspx");
        }

        protected void CancelarModificacionButton_Click(object sender, EventArgs e)
        {
            ImprimirButton.Visible = true;
        }
    }
}