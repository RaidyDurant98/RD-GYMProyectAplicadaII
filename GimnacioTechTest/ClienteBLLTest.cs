using BLL;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnacioTechTest
{
    [TestClass]
    public class ClienteBLLTest
    {
        [TestMethod]
        public void Guardar()
        {
            Clientes cliente = new Clientes(0, "Raidy Duran Garcia", "Masculino", DateTime.Now.Date, 
                "San Francisco de Macoris", "8096739368", "Raidy@outlook.es");

            Assert.IsTrue(ClientesBLL.Guardar(cliente));
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
            Clientes cliente = new Clientes(0, "Raidy Duran Garcia", "Masculino", DateTime.Now.Date,
                "San Francisco de Macoris", "8096739368", "Raidy@outlook.es");

            ClientesBLL.Guardar(cliente);

            Assert.IsNull(ClientesBLL.Eliminar(cliente));
        }

        [TestMethod]
        public void Modificar()
        {
            Clientes cliente = new Clientes(0, "Raidy Duran Garcia", "Masculino", DateTime.Now.Date,
                "San Francisco de Macoris", "8096739368", "Raidy@outlook.es");

            ClientesBLL.Guardar(cliente);

            Assert.IsNull(ClientesBLL.Modificar(cliente));
        }
    }
}
