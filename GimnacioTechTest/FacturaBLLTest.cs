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
    public class FacturaBLLTest
    {
        [TestMethod]
        public void Guardar()
        {
            Facturas factura = new Facturas(0,"Jose", "pedro", DateTime.Now.Date, 20,30,10,"jjj", "Contado");

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

            Assert.IsNull(FacturasBLL.Eliminar(factura));
        }
    }
}
