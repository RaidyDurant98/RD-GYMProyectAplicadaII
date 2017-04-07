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

namespace GimnasioTech.UI.Registros
{
    public partial class UsuariosRegistroForm : Form
    {
        public UsuariosRegistroForm()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            usuarioIdMaskedTextBox.Clear();
            nombresTextBox.Clear();
            nombreUsuarioTextBox.Clear();
            claveTextBox.Clear();
            confirmarClaveTextBox.Clear();
            CargoscomboBox.Text = null;
        }

        private bool Validar()
        {
            bool interruptor = true;

            if (string.IsNullOrEmpty(nombresTextBox.Text))
            {
                NombreserrorProvider.SetError(nombresTextBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }
            if (string.IsNullOrEmpty(nombreUsuarioTextBox.Text))
            {
                NombreUsuarioerrorProvider.SetError(nombreUsuarioTextBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }
            if (string.IsNullOrEmpty(claveTextBox.Text))
            {
                ClaveerrorProvider.SetError(claveTextBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }
            if (string.IsNullOrEmpty(confirmarClaveTextBox.Text))
            {
                ConfirmarClaveerrorProvider.SetError(confirmarClaveTextBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }
            if (string.IsNullOrEmpty(CargoscomboBox.Text))
            {
                CargoerrorProvider.SetError(CargoscomboBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }

            return interruptor;
        }

        private Usuarios LlenarCampos()
        {
            Usuarios usuario = new Usuarios();

            usuario.UsuarioId = Utilidades.TOINT(usuarioIdMaskedTextBox.Text);
            usuario.Nombres = nombresTextBox.Text;
            usuario.NombreUsuario = nombreUsuarioTextBox.Text;
            usuario.Clave = claveTextBox.Text;
            usuario.ConfirmarClave = confirmarClaveTextBox.Text;
            usuario.Cargo = CargoscomboBox.Text;

            return usuario;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();

            if (!Validar())
            {
                MessageBox.Show("Por favor llenar los campos vacios.");
            }
            else
            {
                usuario = LlenarCampos();

                if (claveTextBox.Text == confirmarClaveTextBox.Text)
                {
                    if (UsuariosBLL.Guardar(usuario))
                    {
                        MessageBox.Show("Guardado con exito.");
                        Limpiar();
                    }
                    else
                        MessageBox.Show("Error! no se pudo guardar.");
                }
                else
                {
                    MessageBox.Show("La clave de confirmacion es incorrecta.");
                    confirmarClaveTextBox.Clear();
                    confirmarClaveTextBox.Focus();
                }
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            BuscarUsuario();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usuarioIdMaskedTextBox.Text))
            {
                MessageBox.Show("Por favor insertar el id del usuario que desea eliminar.");
                Limpiar();
            }
            else
            {
                int id = Utilidades.TOINT(usuarioIdMaskedTextBox.Text);

                if (id != 1)
                {
                    DialogResult eliminar = MessageBox.Show("¿Seguro desea eliminar el usuario seleccionado?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (eliminar == DialogResult.Yes)
                    {
                        if (UsuariosBLL.Eliminar(UsuariosBLL.Buscar(p => p.UsuarioId == id)))
                        {
                            Limpiar();
                        }
                        else
                            MessageBox.Show("No se pudo eliminar el usuario.");
                    }
                }
                else
                {
                    MessageBox.Show("No se puede eliminar el usuario porque es el pilar.");
                }
            }
        }

        private void BuscarUsuario()
        {
            if (string.IsNullOrEmpty(usuarioIdMaskedTextBox.Text))
            {
                MessageBox.Show("Por favor insertar el id que desea buscar.");
                Limpiar();
            }
            else
            {
                int id = Utilidades.TOINT(usuarioIdMaskedTextBox.Text);
                Usuarios usuario = new Usuarios();

                usuario = UsuariosBLL.Buscar(p => p.UsuarioId == id);

                if (usuario != null)
                {
                    nombresTextBox.Text = usuario.Nombres;
                    nombreUsuarioTextBox.Text = usuario.NombreUsuario;
                    claveTextBox.Text = usuario.Clave;
                    confirmarClaveTextBox.Text = usuario.ConfirmarClave;
                    CargoscomboBox.Text = usuario.Cargo;
                }
                else
                {
                    MessageBox.Show("El usuario no exite.");
                    Limpiar();
                }
            }
        }

        private void usuarioIdMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                BuscarUsuario();
            }
        }

        private void nombresTextBox_TextChanged(object sender, EventArgs e)
        {
            NombreserrorProvider.Clear();
        }

        private void nombreUsuarioTextBox_TextChanged(object sender, EventArgs e)
        {
            NombreUsuarioerrorProvider.Clear();
        }

        private void claveTextBox_TextChanged(object sender, EventArgs e)
        {
            ClaveerrorProvider.Clear();
        }

        private void CargoscomboBox_TextChanged(object sender, EventArgs e)
        {
            CargoerrorProvider.Clear();
        }

        private void confirmarClaveTextBox_TextChanged(object sender, EventArgs e)
        {
            ConfirmarClaveerrorProvider.Clear();
        }
    }
}
