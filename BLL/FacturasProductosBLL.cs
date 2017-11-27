using DAL;
using Entidades;
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

        public static FacturasProductos Buscar(Expression<Func<FacturasProductos, bool>> criterio)
        {
            using (var context = new Respository<FacturasProductos>())
            {
                try
                {
                    return context.Buscar(criterio);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
