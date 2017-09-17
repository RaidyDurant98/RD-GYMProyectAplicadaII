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
    public partial class UsuariosReporteForm : Form
    {
        public List<Entidades.Usuarios> Lista { get; set; }

        public UsuariosReporteForm(List<Entidades.Usuarios> lista)
        {
            InitializeComponent();
            Lista = lista;
        }

        private void UsuariosReporteForm_Load(object sender, EventArgs e)
        {

        }
    }
}
