﻿using BLL;
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
    public class CategoriaProductosTest
    {
        [TestMethod]
        public void Guardar()
        {
            CategoriaProductos cat = new CategoriaProductos(0, "Proteina");

            Assert.IsTrue(CategoriaProductosBLL.Guardar(cat));
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
            CategoriaProductos cat = new CategoriaProductos(0, "Proteina");

            CategoriaProductosBLL.Guardar(cat);

            Assert.IsNull(CategoriaProductosBLL.Eliminar(cat));
        }

        [TestMethod]
        public void Modificar()
        {
            CategoriaProductos cat = new CategoriaProductos(0, "Proteina");

            CategoriaProductosBLL.Guardar(cat);

            Assert.IsNull(CategoriaProductosBLL.Modificar(cat));
        }
    }
}
