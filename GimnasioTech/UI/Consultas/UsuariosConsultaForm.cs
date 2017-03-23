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

        private void Filtro()
        {
            if (ConsultarcomboBox.SelectedIndex == 0)
            {
                ConsultadataGridView.DataSource = BLL.UsuariosBLL.GetListAll();
            }
            else if (ConsultarcomboBox.SelectedIndex != 0)
            {
                if (string.IsNullOrEmpty(ConsultartextBox.Text))
                {
                    CampoVacioerrorProvider.SetError(ConsultartextBox, "Por favor llenar este campo.");
                }
                else
                {
                    if (ConsultarcomboBox.SelectedIndex == 1)
                    {
                        ConsultadataGridView.DataSource = BLL.UsuariosBLL.GetList(p => p.Nombres == ConsultartextBox.Text);
                    }
                    if (ConsultarcomboBox.SelectedIndex == 2)
                    {
                        ConsultadataGridView.DataSource = BLL.UsuariosBLL.GetList(p => p.Cargo == ConsultartextBox.Text);
                    }
                }
            }
        }

        private void UsuariosConsultaForm_Load(object sender, EventArgs e)
        {
            ConsultartextBox.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ConsultarcomboBox.SelectedIndex == 0)
            {
                ConsultartextBox.Clear();
                CampoVacioerrorProvider.Clear();
                ConsultartextBox.Enabled = false;
                Filtro();
            }
            else
            {
                ConsultartextBox.Enabled = true;
                ConsultartextBox.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Filtro();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CampoVacioerrorProvider.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(ConsultartextBox.Text))
                {
                    CampoVacioerrorProvider.Clear();
                }

                Filtro();
            }
        }
    }
}
