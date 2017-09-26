using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class CategoriaProductosBLL
    {
        public static bool Guardar(CategoriaProductos categoriaProducto)
        {
            using (var context = new Respository<CategoriaProductos>())
            {
                try
                {
                    if (Buscar(p => p.CategoriaId == categoriaProducto.CategoriaId) == null)
                    {
                        return context.Guardar(categoriaProducto);
                    }
                    else
                    {
                        return context.Modificar(categoriaProducto);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static bool Eliminar(CategoriaProductos categoriaProducto)
        {
            using (var context = new Respository<CategoriaProductos>())
            {
                try
                {
                    return context.Eliminar(categoriaProducto);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static bool Modificar(CategoriaProductos categoriaProducto)
        {
            using (var context = new Respository<CategoriaProductos>())
            {
                try
                {
                    return context.Modificar(categoriaProducto);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static List<CategoriaProductos> GetList(Expression<Func<CategoriaProductos, bool>> criterio)
        {
            using (var context = new Respository<CategoriaProductos>())
            {
                try
                {
                    return context.GetList(criterio);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static List<CategoriaProductos> GetListAll()
        {
            using (var context = new Respository<CategoriaProductos>())
            {
                try
                {
                    return context.GetListAll();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static CategoriaProductos Buscar(Expression<Func<CategoriaProductos, bool>> criterio)
        {
            using (var context = new Respository<CategoriaProductos>())
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
