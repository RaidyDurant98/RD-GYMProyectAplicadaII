using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Facturas
    {
        [Key]
        public int FacturaId { get; set; }
        public string NombreCliente { get; set; }
        public string NombreUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public decimal DineroPagado { get; set; }
        public decimal Devuelta { get; set; }
        public string Comentario { get; set; }
        public string FormaPago { get; set; }

        public virtual ICollection<FacturasProductos> Relacion { get; set; }

        public Facturas()
        {
            this.Relacion = new HashSet<FacturasProductos>();
        }

        public Facturas(int id, string nombreCliente, string nombreUsuario, DateTime fecha, decimal monto,
            decimal dineroPagado, decimal devuelta, string comentario, string formaPago)
        {
            this.FacturaId = id;
            this.NombreCliente = nombreCliente;
            this.NombreUsuario = NombreUsuario;
            this.Fecha = fecha;
            this.Monto = monto;
            this.DineroPagado = dineroPagado;
            this.Devuelta = devuelta;
            this.Comentario = comentario;
            this.FormaPago = formaPago;
        }
    }
}
