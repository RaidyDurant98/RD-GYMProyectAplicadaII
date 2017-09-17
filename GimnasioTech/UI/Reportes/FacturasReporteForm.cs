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
    public partial class FacturasReporteForm : Form
    {
        public List<Entidades.Facturas> Lista { get; set; }

        public FacturasReporteForm(List<Entidades.Facturas> lista)
        {
            InitializeComponent();
            Lista = lista;
        }

        private void FacturasReporteForm_Load(object sender, EventArgs e)
        {

        }
    }
}
