﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GimnasioTech.UI.Consultas
{
    public partial class FacturasConsultaForm : Form
    {
        public List<Entidades.Facturas> Lista { get; set; }

        public FacturasConsultaForm()
        {
            InitializeComponent();
           
        }

        private void FacturasConsultaForm_Load(object sender, EventArgs e)
        {
            ConsultartextBox.Enabled = false;
            DesdedateTimePicker.Enabled = false;
            HastadateTimePicker.Enabled = false;
        }

        private void Filtro()
        {
            if (ConsultarcomboBox.SelectedIndex == 0)
            {
                Lista = BLL.FacturasBLL.GetListAll();
            }
            if (ConsultarcomboBox.SelectedIndex == 3)
            {
                if (DesdedateTimePicker.Value.Date > HastadateTimePicker.Value.Date)
                {
                    CampoVacioerrorProvider.SetError(DesdedateTimePicker, "La fecha no puede ser mayor que el rango maximo.");
                }
                else if(HastadateTimePicker.Value.Date < DesdedateTimePicker.Value.Date)
                {
                    CampoVacioerrorProvider.SetError(DesdedateTimePicker, "La fecha no puede ser menor que el rango minimo.");
                }
                else
                {
                    Lista = BLL.FacturasBLL.GetList(p => p.Fecha >= DesdedateTimePicker.Value.Date && p.Fecha <= HastadateTimePicker.Value.Date);
                }               
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
                        Lista = BLL.FacturasBLL.GetList(p => p.NombreCliente == ConsultartextBox.Text);
                    }
                    if (ConsultarcomboBox.SelectedIndex == 1)
                    {
                        int id = Utilidades.TOINT(ConsultartextBox.Text);
                        Lista = BLL.FacturasBLL.GetList(p => p.FacturaId == id);
                    }
                    if (ConsultarcomboBox.SelectedIndex == 4)
                    {
                        Lista = BLL.FacturasBLL.GetList(p => p.NombreUsuario == ConsultartextBox.Text);
                    }
                }
            }

            ConsultadataGridView.DataSource = Lista;
            this.ConsultadataGridView.Columns["Relacion"].Visible = false;
            LlenarLabel();
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
                Montolabel.Text = "0.0";
                Filtro();
            }
            else if (ConsultarcomboBox.SelectedIndex == 3)
            {
                DesdedateTimePicker.Value = DateTime.Now;
                HastadateTimePicker.Value = DateTime.Now;
                ConsultartextBox.Clear();
                ConsultadataGridView.DataSource = null;
                CampoVacioerrorProvider.Clear();
                DesdedateTimePicker.Enabled = true;
                DesdedateTimePicker.Focus();
                HastadateTimePicker.Enabled = true;
                ConsultartextBox.Enabled = false;
                Montolabel.Text = "0.0";
            }
            else
            {
                DesdedateTimePicker.Value = DateTime.Now;
                HastadateTimePicker.Value = DateTime.Now;
                ConsultadataGridView.DataSource = null;
                ConsultartextBox.Clear();
                DesdedateTimePicker.Enabled = false;
                HastadateTimePicker.Enabled = false;
                ConsultartextBox.Enabled = true;
                ConsultartextBox.Focus();
                Montolabel.Text = "0.0";
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
            new UI.Reportes.FacturasReporteForm(Lista).Show();
            new UI.Reportes.FacturasReporteForm(Lista).Activate();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Filtro();
        }

        private void LlenarLabel()
        {
            decimal monto = 0;
            foreach (DataGridViewRow producto in ConsultadataGridView.Rows)
            {
                monto += Convert.ToDecimal(producto.Cells[4].Value);
            }

            Montolabel.Text = monto.ToString();
        }

        private void Montolabel_Click(object sender, EventArgs e)
        {

        }
    }
}
