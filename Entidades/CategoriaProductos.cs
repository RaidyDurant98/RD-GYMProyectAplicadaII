using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class CategoriaProductos
    {
        [Key]
        public int CategoriaId { get; set; }
        public string Descripcion { get; set; }

        public CategoriaProductos()
        {

        }

        public CategoriaProductos(int categoriaId, string descripcion)
        {
            this.CategoriaId = categoriaId;
            this.Descripcion = descripcion;
        }
    }
}
