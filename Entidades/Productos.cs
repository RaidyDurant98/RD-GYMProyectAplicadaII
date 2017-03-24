using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaVencimiento { get; set; }

        public virtual ICollection<FacturasProductos> Relacion { get; set; }

        public Productos()
        {
            Relacion = new HashSet<FacturasProductos>();
        }

        public Productos(int productoId, string descripcion, int cantidad, decimal costo, decimal precio, DateTime fechaIngreso, DateTime fechaVencimiento)
        {
            this.ProductoId = productoId;
            this.Descripcion = descripcion;
            this.Cantidad = cantidad;
            this.Costo = costo;
            this.Precio = precio;
            this.FechaIngreso = fechaIngreso;
            this.FechaVencimiento = fechaVencimiento;

            Relacion = new HashSet<FacturasProductos>();
        }
    }
}
