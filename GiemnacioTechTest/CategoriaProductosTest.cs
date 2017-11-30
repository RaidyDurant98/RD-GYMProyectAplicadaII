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
    class CategoriaProductosTest
    {
        [TestMethod]
        public void Guardar()
        {
            CategoriaProductos cat = new CategoriaProductos();
            cat.CategoriaId = 1;
            cat.Descripcion = "jj";

            var paso = CategoriaProductosBLL.Guardar(cat);

            Assert.IsNotNull(paso, null);
        }

        [TestMethod]
        public void Buscar()
        {
            var paso = CategoriaProductosBLL.Buscar(p => p.CategoriaId == 1);

            Assert.IsNotNull(paso, null);
        }

        [TestMethod]
        public void Eliminar()
        {
            CategoriaProductos cat = new CategoriaProductos();
            cat.CategoriaId = 1;
            cat.Descripcion = "jj";

            var paso = CategoriaProductosBLL.Guardar(cat);

            Assert.IsNull(paso, null);
        }
    }
}
