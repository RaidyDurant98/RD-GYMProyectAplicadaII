using BLL;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiemnacioTechTest
{
    class ClienteBLLTest
    {
        [TestMethod]
        public void Guardar()
        {
            Clientes cliente = new Clientes(0, "Raidy Duran Garcia", "R", DateTime.Now.Date, "1234", "Usuario", "ww");

            var paso = ClientesBLL.Guardar(cliente);

            Assert.IsNotNull(paso, null);
        }

        [TestMethod]
        public void Buscar()
        {
            var paso = ClientesBLL.Buscar(p => p.ClienteId == 1);

            Assert.IsNotNull(paso, null);
        }

        [TestMethod]
        public void Eliminar()
        {
            Clientes cliente = new Clientes(0, "Raidy Duran Garcia", "R", DateTime.Now.Date, "1234", "Usuario", "ww");

            ClientesBLL.Eliminar(cliente);

            Assert.IsNull(cliente, null);
        }
    }
}
