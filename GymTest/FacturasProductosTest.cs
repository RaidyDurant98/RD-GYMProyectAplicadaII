using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using BLL;

namespace GymTest
{
    [TestClass]
    public class FacturasProductosTest
    {
        [TestMethod]
        public void Guardar()
        {
            FacturasProductos detalle = new FacturasProductos(0, "Proteina", 2000, 5);

            Assert.IsTrue(FacturasProductosBLL.Guardar(detalle));
        }

        [TestMethod]
        public void Buscar()
        {
            var paso = FacturasProductosBLL.Buscar(p => p.Id == 1);

            Assert.IsNotNull(paso, null);
        }
    }
}
