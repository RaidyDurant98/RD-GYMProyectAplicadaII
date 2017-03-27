using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GimnasioTech.UI.Reportes
{
    public partial class ProductosReporteForm : Form
    {
        public List<Entidades.Productos> Lista { get; set; }

        public ProductosReporteForm(List<Entidades.Productos> lista)
        {
            InitializeComponent();
            Lista = lista;
        }

        private void ProductosReporteForm_Load_1(object sender, EventArgs e)
        {
            foreach (var producto in Lista)
            {
                ProductosBindingSource.Add(producto);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
