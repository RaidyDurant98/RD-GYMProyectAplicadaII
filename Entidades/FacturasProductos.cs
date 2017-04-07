using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class FacturasProductos
    {
        [Key]
        public int Id { get; set; }
        public int FacturaId { get; set; }
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal Cantidad { get; set; }
        
        public Entidades.Productos Producto { get; set; }

        public FacturasProductos()
        {

        }

        public FacturasProductos(int facturaId, int productoId, string descripcion,decimal precio, decimal cantidad)
        {
            this.FacturaId = facturaId;
            this.ProductoId = productoId;
            this.Precio = precio;
            this.Descripcion = descripcion;
            this.Cantidad = cantidad;
        }
    }
}
