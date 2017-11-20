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
            AlertSuccessPanel.Visible = false;
            AlertInfoPanel.Visible = false;
            AlertDangerPanel.Visible = false;

            if (UI.CategoriaProductosConsulta.Categoria != null)
            {
                categoria = UI.CategoriaProductosConsulta.Categoria;
                CargarDatosCategoria();
                UI.CategoriaProductosConsulta.Categoria = null;
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
            CategoriaIdTextBox.Text = "";
            DescripcionTextBox.Text = "";

            AlertSuccessPanel.Visible = false;
            AlertInfoPanel.Visible = false;
            AlertDangerPanel.Visible = false;
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
                AsignarTextoAlertaInfo("Digite el id de la categoria.");
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
                    AsignarTextoAlertaInfo("No existe categoria con ese id.");
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
                    AsignarTextoAlertaSuccess("Categoria guardada con exito.");
                }
                else
                {
                    AsignarTextoAlertaDanger("No se pudo guardar la categoria.");
                }
            }
            else
            {
                AsignarTextoAlertaInfo("Por favor introducir la descripcion de la categoria");
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
                AsignarTextoAlertaSuccess("Categoria eliminado con exito.");
            }
            else
            {
                AsignarTextoAlertaDanger("No se puedo eliminar la categoria.");
            }
        }
    }
}