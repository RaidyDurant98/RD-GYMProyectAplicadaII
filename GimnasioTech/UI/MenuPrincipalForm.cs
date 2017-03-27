using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GimnasioTech.UI
{
    public partial class MenuPrincipalForm : Form
    {
        public UI.Consultas.ClientesConsultaForm consultaCliente { set; get; }

        private UI.Registros.ClientesRegistroForm registroCliente { get; set; }

        private UI.Registros.ProductosRegistroForm registroProducto { get; set; }

        private UI.Registros.UsuariosRegistroForm registroUsuario { get; set; }

        private UI.Consultas.UsuariosConsultaForm consultaUsuario { get; set; }

        private UI.Consultas.ProductosConsultaForm consultaProducto { get; set; }

        public UI.FacturasForm factura { get; set; }

        public UI.Consultas.FacturasConsultaForm consultaFactura { get; set; }

        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (registroUsuario != null)
            {
                registroUsuario.Close();
            }

            registroUsuario = new UI.Registros.UsuariosRegistroForm();
            registroUsuario.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (registroCliente != null)
            {
                registroCliente.Close();
            }

            registroCliente = new UI.Registros.ClientesRegistroForm();
            registroCliente.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (registroProducto != null)
            {
                registroProducto.Close();
            }

            registroProducto = new UI.Registros.ProductosRegistroForm();
            registroProducto.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (consultaUsuario != null)
            {
                consultaUsuario.Close();
            }

            consultaUsuario = new UI.Consultas.UsuariosConsultaForm();
            consultaUsuario.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (consultaCliente != null)
            {
                consultaCliente.Close();
            }

            consultaCliente = new UI.Consultas.ClientesConsultaForm();
            consultaCliente.Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (consultaProducto != null)
            {
                consultaProducto.Close();
            }

            consultaProducto = new UI.Consultas.ProductosConsultaForm();
            consultaProducto.Show();
        }

        private void CambiarusuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InicioSesionForm().Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuPrincipalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Permisos()
        {
            if (InicioSesionForm.GetUsuario().Cargo != "Administrador")
            {
                usuariosToolStripMenuItem1.Enabled = false;
            }
            else
            {
                usuariosToolStripMenuItem1.Enabled = true;
            }
        }

        private void MenuPrincipalForm_VisibleChanged(object sender, EventArgs e)
        {
            Permisos();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (factura != null)
            {
                factura.Close();
            }

            factura = new UI.FacturasForm();
            factura.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (consultaFactura != null)
            {
                consultaFactura.Close();
            }

            consultaFactura = new UI.Consultas.FacturasConsultaForm();
            consultaFactura.Show();
        }
    }
}
