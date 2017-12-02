using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using Entidades;

namespace GymTest
{
    [TestClass]
    public class UsuariosTest
    {
        [TestMethod]
        public void Guardar()
        {
            Usuarios usuario = new Usuarios(0, "Raidy Duran Garcia", "R", "1234", "Usuario", DateTime.Now.Date);

            Assert.IsTrue(UsuariosBLL.Guardar(usuario));
        }

        [TestMethod]
        public void Buscar()
        {
            var paso = UsuariosBLL.Buscar(p => p.UsuarioId == 1);

            Assert.IsNotNull(paso, null);
        }

        [TestMethod]
        public void Eliminar()
        {
            Usuarios usuario = new Usuarios(0, "Raidy Duran Garcia", "Roo", "1234", "Usuario", DateTime.Now.Date);

            UsuariosBLL.Guardar(usuario);
            Assert.IsTrue(UsuariosBLL.Eliminar(usuario));
        }

        [TestMethod]
        public void Modificar()
        {
            Usuarios usuario = new Usuarios(0, "Raidy Duran Garcia", "Roo", "1234", "Usuario", DateTime.Now.Date);

            UsuariosBLL.Guardar(usuario);

            Assert.IsTrue(UsuariosBLL.Modificar(usuario));
        }
    }
}
