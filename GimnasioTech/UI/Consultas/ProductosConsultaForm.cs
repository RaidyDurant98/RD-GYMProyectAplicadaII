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
    public partial class ProductosConsultaForm : Form
    {
        public List<Entidades.Productos> Lista { get; set; }

        public ProductosConsultaForm()
        {
            InitializeComponent();
        }

        private void ProductosConsultaForm_Load(object sender, EventArgs e)
        {
            ConsultartextBox.Enabled = false;
            DesdedateTimePicker.Enabled = false;
            HastadateTimePicker.Enabled = false;
        }

        private void Filtro()
        {
            if (ConsultarcomboBox.SelectedIndex == 0)
            {
                ConsultadataGridView.DataSource = BLL.ProductosBLL.GetListAll();
            }
            if (ConsultarcomboBox.SelectedIndex == 3)
            {
                ConsultadataGridView.DataSource = BLL.ProductosBLL.GetList(p => p.FechaIngreso >= DesdedateTimePicker.Value.Date && p.FechaIngreso <= HastadateTimePicker.Value.Date);

            }
            else if (ConsultarcomboBox.SelectedIndex != 0 && ConsultarcomboBox.SelectedIndex != 3)
            {
                if (string.IsNullOrEmpty(ConsultartextBox.Text))
                {
                    CampoVacioerrorProvider.SetError(ConsultartextBox, "Por favor llenar este campo.");
                }
                else
                {
                    if (ConsultarcomboBox.SelectedIndex == 2)
                    {
                        ConsultadataGridView.DataSource = BLL.ProductosBLL.GetList(p => p.Descripcion == ConsultartextBox.Text);
                    }
                    if (ConsultarcomboBox.SelectedIndex == 1)
                    {
                        int id = Utilidades.TOINT(ConsultartextBox.Text);
                        ConsultadataGridView.DataSource = BLL.ProductosBLL.GetList(p => p.ProductoId == id);
                    }
                }
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Filtro();
        }

        private void ConsultarcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ConsultarcomboBox.SelectedIndex == 0)
            {
                DesdedateTimePicker.Value = DateTime.Now;
                HastadateTimePicker.Value = DateTime.Now;
                ConsultartextBox.Clear();
                CampoVacioerrorProvider.Clear();
                ConsultartextBox.Enabled = false;
                DesdedateTimePicker.Enabled = false;
                HastadateTimePicker.Enabled = false;
                Filtro();
            }
            else if (ConsultarcomboBox.SelectedIndex == 3)
            {
                DesdedateTimePicker.Value = DateTime.Now;
                HastadateTimePicker.Value = DateTime.Now;
                ConsultartextBox.Enabled = false;
                ConsultartextBox.Clear();
                ConsultadataGridView.DataSource = null;
                DesdedateTimePicker.Enabled = true;
                DesdedateTimePicker.Focus();
                HastadateTimePicker.Enabled = true;
                CampoVacioerrorProvider.Clear();
            }
            else
            {
                DesdedateTimePicker.Value = DateTime.Now;
                HastadateTimePicker.Value = DateTime.Now;
                ConsultartextBox.Clear();
                ConsultadataGridView.DataSource = null;
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
            new UI.Reportes.ProductosReporteForm(Lista).Show();
            new UI.Reportes.ProductosReporteForm(Lista).Activate();
        }
    }
}
