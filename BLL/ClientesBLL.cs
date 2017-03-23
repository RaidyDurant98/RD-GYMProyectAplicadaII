using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class ClientesBLL
    {
        public static bool Guardar(Clientes cliente)
        {
            using (var context = new Respository<Clientes>())
            {
                try
                {
                    if (Buscar(p => p.ClienteId == cliente.ClienteId) == null)
                    {
                        return context.Guardar(cliente);
                    }
                    else
                    {
                        return context.Modificar(cliente);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static bool Eliminar(Clientes cliente)
        {
            using (var context = new Respository<Clientes>())
            {
                try
                {
                    return context.Eliminar(cliente);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static List<Clientes> GetList(Expression<Func<Clientes, bool>> criterio)
        {
            using (var context = new Respository<Clientes>())
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

        public static List<Clientes> GetListAll()
        {
            using (var context = new Respository<Clientes>())
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

        public static Clientes Buscar(Expression<Func<Clientes, bool>> criterio)
        {
            using (var context = new Respository<Clientes>())
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
