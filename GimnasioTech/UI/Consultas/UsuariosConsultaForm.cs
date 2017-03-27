using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GimnasioTech.UI.Consultas
{
    public partial class UsuariosConsultaForm : Form
    {
        public List<Entidades.Usuarios> Lista { get; set; }

        public UsuariosConsultaForm()
        {
            InitializeComponent();
        }

        private void UsuariosConsultaForm_Load(object sender, EventArgs e)
        {
            FiltrartextBox.Enabled = false;
        }

        private void Filtrar()
        {
            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                Lista = BLL.UsuariosBLL.GetListAll();
            }
            else if (FiltrarcomboBox.SelectedIndex != 0)
            {
                if (string.IsNullOrEmpty(FiltrartextBox.Text))
                {
                    CampoVacioerrorProvider.SetError(FiltrartextBox, "Por favor llenar este campo.");
                }
                else
                {
                    if (FiltrarcomboBox.SelectedIndex == 2)
                    {
                       Lista = BLL.UsuariosBLL.GetList(p => p.Nombres ==FiltrartextBox.Text);
                    }
                    if (FiltrarcomboBox.SelectedIndex == 3)
                    {
                        Lista = BLL.UsuariosBLL.GetList(p => p.Cargo == FiltrartextBox.Text);
                    }
                    if (FiltrarcomboBox.SelectedIndex == 1)
                    {
                        int id = Utilidades.TOINT(FiltrartextBox.Text);
                        Lista = BLL.UsuariosBLL.GetList(p => p.UsuarioId == id);
                    }
                }
            }

            ConsultadataGridView.DataSource = Lista;
        }

        private void FiltrarcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                FiltrartextBox.Clear();
                CampoVacioerrorProvider.Clear();
                FiltrartextBox.Enabled = false;
                Filtrar();
            }
            else
            {
                FiltrartextBox.Enabled = true;
                FiltrartextBox.Focus();
            }
        }

        private void Filtrarbutton_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void FiltrartextBox_TextChanged(object sender, EventArgs e)
        {
            CampoVacioerrorProvider.Clear();
        }

        private void FiltrartextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(FiltrartextBox.Text))
                {
                    CampoVacioerrorProvider.Clear();
                }

                Filtrar();
            }
        }

        private void Imprimibutton_Click(object sender, EventArgs e)
        {
            new UI.Reportes.UsuariosReporteForm(Lista).Show();
            new UI.Reportes.UsuariosReporteForm(Lista).Activate();
        }
    }
}
