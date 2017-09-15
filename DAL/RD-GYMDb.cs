using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DAL
{
    public class RD_GYMDb : DbContext
    {
        public RD_GYMDb() : base("ConStr1")
        {

        }

        public DbSet<Clientes> Cliente { get; set; }
        public DbSet<Productos> Producto { get; set; }
        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<Facturas> Factura { get; set; }
    }
}
