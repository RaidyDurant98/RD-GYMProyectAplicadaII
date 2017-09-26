using BLL;
using Entidades;
using GimnasioTech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GimnacioTechWeb.UI.Registros
{
    public partial class CategoriaProductosForm : System.Web.UI.Page
    {
        public CategoriaProductos categoria;

        protected void Page_Load(object sender, EventArgs e)
        {
            categoria = new CategoriaProductos();
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

        private CategoriaProductos LlenarCampos()
        {
            categoria.CategoriaId = Utilidades.TOINT(CategoriaIdTextBox.Text);
            categoria.Descripcion = DescripcionTextBox.Text;

            return categoria;
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                categoria = LlenarCampos();

                if (CategoriaProductosBLL.Guardar(categoria))
                {
                    CategoriaIdTextBox.Text = Convert.ToString(categoria.CategoriaId);
                    AsignarTextoAlertaSuccess("Categoria guardada con exito.");
                }
                else
                {
                    AsignarTextoAlertaDanger("No se pudo guardar la categoria.");
                }
            }
        }
    }
}