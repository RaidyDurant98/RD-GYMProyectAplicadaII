using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using Entidades;

namespace GymTest
{
    [TestClass]
    public class ProductosTest
    {
        [TestMethod]
        public void Guardar()
        {
            Productos producto = new Productos(0, "Whey 5 lbs", 10, 30, 40, DateTime.Now.Date, 1);

            Assert.IsTrue(ProductosBLL.Guardar(producto));
        }

        [TestMethod]
        public void Buscar()
        {
            var paso = ProductosBLL.Buscar(p => p.ProductoId == 1);

            Assert.IsNotNull(paso, null);
        }

        [TestMethod]
        public void Eliminar()
        {
            Productos producto = new Productos(0, "Whey 5 lbs", 10, 30, 40, DateTime.Now.Date, 1);

            ProductosBLL.Guardar(producto);
            Assert.IsTrue(ProductosBLL.Eliminar(producto));
        }

        [TestMethod]
        public void Modificar()
        {
            Productos producto = new Productos(0, "Whey 5 lbs", 10, 30, 40, DateTime.Now.Date, 1);

            ProductosBLL.Guardar(producto);

            Assert.IsTrue(ProductosBLL.Modificar(producto));
        }
    }
}
