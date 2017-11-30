using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using Entidades;

namespace GiemnacioTechTest
{
    [TestClass]
    public class UsuariosBLLTest
    {
        [TestMethod]
        public void Guardar()
        {
            Usuarios usuario = new Usuarios(0,"Raidy Duran Garcia", "R", "1234", "Usuario", DateTime.Now.Date);

            var paso = UsuariosBLL.Guardar(usuario);

            Assert.IsNotNull(paso, null);
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
            Usuarios usuario = new Usuarios(0, "Raidy Duran Garcia", "R", "1234", "Usuario", DateTime.Now.Date);

            UsuariosBLL.Eliminar(usuario);

            Assert.IsNull(usuario, null);
        }
    }
}
