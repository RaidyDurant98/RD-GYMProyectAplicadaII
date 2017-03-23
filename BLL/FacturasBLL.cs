using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class FacturasBLL
    {
        public static bool Guardar(Facturas factura)
        {
            using (var context = new DAL.RD_GYMDb())
            {
                context.Factura.Add(factura);

                context.SaveChanges();
                return true;
                /*List<int> entero = new List<int>();
                bool existe = false;

                try
                {
                    foreach (var g in factura.Productos)
                    {
                        if(entero.Count > 0)
                        {
                            foreach (var id in entero)
                            {
                                if (id == g.ProductoId)
                                    existe = true;
                                break;
                            }
                        }
                        entero.Add(g.ProductoId);
                        if (existe)
                            continue;
                        context.Entry(g).State = System.Data.Entity.EntityState.Unchanged;
                    }

                    context.Factura.Add(factura);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    throw;
                }*/
            }
        }

        public static bool Eliminar(Facturas factura)
        {
            using (var context = new DAL.Respository<Entidades.Facturas>())
            {
                try
                {
                    /*context.Entry(factura).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                    return true;*/

                    return context.Eliminar(factura);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static List<Facturas> GetList(Expression<Func<Facturas, bool>> criterio)
        {
            using (var context = new Respository<Facturas>())
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

        public static List<Facturas> GetListAll()
        {
            using (var context = new Respository<Facturas>())
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

        public static Facturas Buscar(Expression<Func<Facturas, bool>> criterio)
        {
            Facturas factura = null;

            using (var context = new Respository<Facturas>())
            {
                try
                {
                    factura = context.Buscar(criterio);

                    if (factura != null)
                        factura.Relacion.Count();
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return factura;
        }
    }
}
