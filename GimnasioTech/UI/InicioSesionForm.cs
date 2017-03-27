using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GimnasioTech
{
    public partial class InicioSesionForm : Form
    {
        private static Usuarios Usuario = null;

        public InicioSesionForm()
        {
            InitializeComponent();
        }

        private bool Validar()
        {
            bool interruptor = true;

            if (string.IsNullOrEmpty(UsuariotextBox.Text))
            {
                UsuarioerrorProvider.SetError(UsuariotextBox, "Por favor llenar el campo vacios.");
                UsuariotextBox.Focus();
                interruptor = false;
            }
            if (string.IsNullOrEmpty(ClavetextBox.Text))
            {
                ClaveerrorProvider.SetError(ClavetextBox, "Por favor llenar el campo vacios.");
                ClavetextBox.Focus();
                interruptor = false;
            }

            return interruptor;
        }

        private void Salirbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static Entidades.Usuarios GetUsuario()
        {
            return Usuario;
        }

        private bool ValidarSesion()
        {
            if (UsuariotextBox.Text == "Admin" && Usuario == null)
            {
                Usuario = new Entidades.Usuarios(1, "Raidy Duran Garcia", "Admin", "1234", "1234", "Administrador");
                UsuariosBLL.Guardar(Usuario);

                var cliente = new Entidades.Clientes(1, "Raidy Duran Garcia", "Masculino", DateTime.Now, "San Francisco de Macoris", "8096739368", "Raidy@outlook.es");
                ClientesBLL.Guardar(cliente);

                var producto = new Entidades.Productos(1, "Proteina", 5, 400, 500, DateTime.Now);
                ProductosBLL.Guardar(producto);

                var p = new Entidades.Productos(2, "Vitamina", 4, 30, 40, DateTime.Now);
                ProductosBLL.Guardar(p);
            }
            else
            {
                Usuario = BLL.UsuariosBLL.Buscar(p => p.NombreUsuario == UsuariotextBox.Text);
            }

            if (Usuario != null)
            {
                if (ClavetextBox.Text == Usuario.Clave)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("La clave no coinside con el usuario.");
                    ClavetextBox.Clear();
                    ClavetextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("El usuario digitado no existe.");
                UsuariotextBox.Clear();
                UsuariotextBox.Focus();
            }

            return false;
        }

        private void IniciarSesion()
        {
            if (!Validar())
            {
                MessageBox.Show("Por favor llenar los campos vacios");
            }
            else
            {
                if (ValidarSesion())
                {
                    new UI.MenuPrincipalForm().Show();
                    this.Hide();
                }
            }
        }

        private void IniciarSesionbutton_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void UsuariotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                ClavetextBox.Focus();
            }
        }

        private void ClavetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                IniciarSesion();
            }
        }

        private void UsuariotextBox_TextChanged(object sender, EventArgs e)
        {
            UsuarioerrorProvider.Clear();
        }

        private void ClavetextBox_TextChanged(object sender, EventArgs e)
        {
            ClaveerrorProvider.Clear();
        }
    }
}
