using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class FacturasProductosBLL
    {
        public static bool Guardar(Entidades.FacturasProductos detalle)
        {
            using (var repositorio = new Respository<Entidades.FacturasProductos>())
            {

                return repositorio.Guardar(detalle);

            }
        }

        public static List<Entidades.FacturasProductos> GetList(Expression<Func<Entidades.FacturasProductos, bool>> criterioBusqueda)
        {
            using (var repositorio = new Respository<Entidades.FacturasProductos>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }
    }
}
