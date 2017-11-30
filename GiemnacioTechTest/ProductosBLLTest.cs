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
    class ProductosBLLTest
    {
        [TestMethod]
        public void Guardar()
        {
            Productos producto = new Productos(1, "Proteina", 1, 34, 50, DateTime.Now.Date, 1);

            var paso = ProductosBLL.Guardar(producto);

            Assert.IsNotNull(paso, null);
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
            Productos producto = new Productos(1, "Proteina", 1, 34, 50, DateTime.Now.Date, 1);

            var paso = ProductosBLL.Guardar(producto);

            Assert.IsNull(paso, null);
        }
    }
}
