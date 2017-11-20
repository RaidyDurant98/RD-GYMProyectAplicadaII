using BLL;
using Entidades;
using GimnasioTech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GimnacioTechWeb.UI
{
    public partial class CategoriaProductosRegistro : System.Web.UI.Page
    {
        public CategoriaProductos categoria;

        protected void Page_Load(object sender, EventArgs e)
        {
            categoria = new CategoriaProductos();

            if (UI.CategoriaProductosConsulta.Categoria != null)
            {
                categoria = UI.CategoriaProductosConsulta.Categoria;
                CargarDatosCategoria();
                UI.CategoriaProductosConsulta.Categoria = null;
            }
        }

        private void Limpiar()
        {
            CategoriaIdTextBox.Text = "";
            DescripcionTextBox.Text = "";
        }

        private bool Validar()
        {
            bool interruptor = true;

            if (string.IsNullOrEmpty(DescripcionTextBox.Text))
            {
                interruptor = false;
            }

            return interruptor;
        }

        private void CargarDatosCategoria()
        {
            CategoriaIdTextBox.Text = categoria.CategoriaId.ToString();
            DescripcionTextBox.Text = categoria.Descripcion;
        }

        private bool VerificarExistenciaCategoria()
        {
            if (string.IsNullOrEmpty(CategoriaIdTextBox.Text))
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Digite el id de la categoria');", addScriptTags: true);
            }
            else
            {
                int id = Utilidades.TOINT(CategoriaIdTextBox.Text);

                categoria = CategoriaProductosBLL.Buscar(p => p.CategoriaId == id);

                if (categoria != null)
                {
                    return true;
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('no existe categoria con ese id');", addScriptTags: true);
                }
            }

            return false;
        }

        private CategoriaProductos LlenarInstanciaCategoria()
        {
            categoria.CategoriaId = Utilidades.TOINT(CategoriaIdTextBox.Text);
            categoria.Descripcion = DescripcionTextBox.Text;

            return categoria;
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (CategoriaProductosBLL.Guardar(LlenarInstanciaCategoria()))
                {
                    CategoriaIdTextBox.Text = Convert.ToString(categoria.CategoriaId);
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Categoria guardada con exito');", addScriptTags: true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('No se pudo guardar la categoria');", addScriptTags: true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Por favor llenar los campos vacios');", addScriptTags: true);
            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            if (VerificarExistenciaCategoria())
            {
                CargarDatosCategoria();
            }
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void EnviarAlModalEliminarButton_Click(object sender, EventArgs e)
        {
            if (VerificarExistenciaCategoria())
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "#ModalEliminar", "showModalEliminar();", true);
            }
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.TOINT(CategoriaIdTextBox.Text);

            if (CategoriaProductosBLL.Eliminar(CategoriaProductosBLL.Buscar(p => p.CategoriaId == id)))
            {
                Limpiar();
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Categoria eliminada con exito');", addScriptTags: true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('No se pudo eliminar la categoria');", addScriptTags: true);
            }
        }
    }
}