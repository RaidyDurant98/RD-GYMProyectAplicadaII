using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class ProductosBLL
    {
        public static bool Guardar(Productos producto)
        {
            using (var context = new DAL.Respository<Entidades.Productos>())
            {
                try
                {
                    if (Buscar(p => p.ProductoId == producto.ProductoId) == null)
                    {
                        return context.Guardar(producto);
                    }
                    else
                    {
                        return context.Modificar(producto);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static bool Eliminar(Productos producto)
        {
            using (var context = new Respository<Productos>())
            {
                try
                {
                    return context.Eliminar(producto);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static bool Modificar(Productos producto)
        {
            using (var context = new Respository<Productos>())
            {
                try
                {
                    return context.Modificar(producto);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static List<Productos> GetList(Expression<Func<Productos, bool>> criterio)
        {
            using (var context = new Respository<Productos>())
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

        public static List<Productos> GetListAll()
        {
            using (var context = new Respository<Productos>())
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

        public static Productos Buscar(Expression<Func<Productos, bool>> criterio)
        {
            using (var context = new Respository<Productos>())
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

        public static Productos BuscarOtro(int id)
        {
            using (var context = new DAL.Respository<Entidades.Productos>())
            {
                try
                {
                    return context.BuscarOtro(id);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
