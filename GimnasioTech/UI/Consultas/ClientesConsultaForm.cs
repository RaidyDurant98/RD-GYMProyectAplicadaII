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
    public partial class ClientesConsultaForm : Form
    {
        public List<Entidades.Clientes> Lista { get; set; }

        public ClientesConsultaForm()
        {
            InitializeComponent();
        }

        private void ClientesConsultaForm_Load(object sender, EventArgs e)
        {
            ConsultartextBox.Enabled = false;
            DesdedateTimePicker.Enabled = false;
            HastadateTimePicker.Enabled = false;
        }

        private void Filtro()
        {
            if (ConsultarcomboBox.SelectedIndex == 0)
            {
                Lista = BLL.ClientesBLL.GetListAll();
            }
            if (ConsultarcomboBox.SelectedIndex == 4)
            {
                Lista = BLL.ClientesBLL.GetList(p => p.FechaInscripcion >= DesdedateTimePicker.Value.Date && p.FechaInscripcion <= HastadateTimePicker.Value.Date);
            }
            else if (ConsultarcomboBox.SelectedIndex != 0 && ConsultarcomboBox.SelectedIndex != 4)
            {
                if (string.IsNullOrEmpty(ConsultartextBox.Text))
                {
                    CampoVacioerrorProvider.SetError(ConsultartextBox, "Por favor llenar este campo.");
                }
                else
                {
                    if (ConsultarcomboBox.SelectedIndex == 2)
                    {
                        Lista = BLL.ClientesBLL.GetList(p => p.Nombres == ConsultartextBox.Text);
                    }
                    if (ConsultarcomboBox.SelectedIndex == 3)
                    {
                        Lista = BLL.ClientesBLL.GetList(p => p.Sexo == ConsultartextBox.Text);
                    }
                    if (ConsultarcomboBox.SelectedIndex == 5)
                    {
                        Lista = BLL.ClientesBLL.GetList(p => p.Direccion == ConsultartextBox.Text);
                    }
                    if (ConsultarcomboBox.SelectedIndex == 1)
                    {
                        int id = Utilidades.TOINT(ConsultartextBox.Text);
                        Lista = BLL.ClientesBLL.GetList(p => p.ClienteId == id);
                    }
                }
            }

            ConsultadataGridView.DataSource = Lista;
        }

        private void ConsultarcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ConsultarcomboBox.SelectedIndex == 0)
            {
                ConsultartextBox.Clear();
                CampoVacioerrorProvider.Clear();
                ConsultartextBox.Enabled = false;
                DesdedateTimePicker.Enabled = false;
                HastadateTimePicker.Enabled = false;
                Filtro();
            }
            else if (ConsultarcomboBox.SelectedIndex == 4)
            {
                CampoVacioerrorProvider.Clear();
                DesdedateTimePicker.Enabled = true;
                DesdedateTimePicker.Focus();
                HastadateTimePicker.Enabled = true;
                ConsultartextBox.Enabled = false;
            }
            else
            {
                DesdedateTimePicker.Enabled = false;
                HastadateTimePicker.Enabled = false;
                ConsultartextBox.Enabled = true;
                ConsultartextBox.Focus();
            }
        }

        private void ConsultartextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ConsultartextBox_TextChanged(object sender, EventArgs e)
        {
            CampoVacioerrorProvider.Clear();
        }

        private void DesdedateTimePicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                HastadateTimePicker.Focus();
            }
        }

        private void HastadateTimePicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                Filtro();
            }
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            new UI.Reportes.ClientesReporteForm(Lista).Show();
            new UI.Reportes.ClientesReporteForm(Lista).Activate();
        }
    }
}
