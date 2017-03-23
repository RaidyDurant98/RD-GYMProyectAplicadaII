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
                ConsultadataGridView.DataSource = BLL.UsuariosBLL.GetListAll();
            }
            else if (FiltrarcomboBox.SelectedIndex != 0)
            {
                if (string.IsNullOrEmpty(FiltrartextBox.Text))
                {
                    CampoVacioerrorProvider.SetError(FiltrartextBox, "Por favor llenar este campo.");
                }
                else
                {
                    if (FiltrarcomboBox.SelectedIndex == 1)
                    {
                        ConsultadataGridView.DataSource = BLL.UsuariosBLL.GetList(p => p.Nombres ==FiltrartextBox.Text);
                    }
                    if (FiltrarcomboBox.SelectedIndex == 2)
                    {
                        ConsultadataGridView.DataSource = BLL.UsuariosBLL.GetList(p => p.Cargo == FiltrartextBox.Text);
                    }
                }
            }
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
    }
}
