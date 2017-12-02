using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using BLL;

namespace GymTest
{
    [TestClass]
    public class FacturaTest
    {
        [TestMethod]
        public void Guardar()
        {
            Facturas factura = new Facturas(0, "Jose", "pedro", DateTime.Now.Date, 20, 30, 10, "jjj", "Contado");

            Assert.IsTrue(FacturasBLL.Guardar(factura));
        }

        [TestMethod]
        public void Buscar()
        {
            var paso = FacturasBLL.Buscar(p => p.FacturaId == 1);

            Assert.IsNotNull(paso, null);
        }

        [TestMethod]
        public void Eliminar()
        {
            Facturas factura = new Facturas(0, "Jose", "pedro", DateTime.Now.Date, 20, 30, 10, "jjj", "Contado");

            FacturasBLL.Guardar(factura);

            Assert.IsTrue(FacturasBLL.Eliminar(factura));
        }
    }
}
