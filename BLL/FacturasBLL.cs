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
            }
        }

        public static bool Eliminar(Facturas factura)
        {
            using (var context = new DAL.Respository<Entidades.Facturas>())
            {
                try
                {
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
