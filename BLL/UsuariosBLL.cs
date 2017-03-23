using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class UsuariosBLL
    {
        public static bool Guardar(Usuarios usuario)
        {
            using (var context = new Respository<Usuarios>())
            {
                try
                {
                    if (Buscar(p => p.UsuarioId == usuario.UsuarioId) == null)
                    {
                        return context.Guardar(usuario);
                    }
                    else
                    {
                        return context.Modificar(usuario);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static bool Eliminar(Usuarios usuario)
        {
            using (var context = new Respository<Usuarios>())
            {
                try
                {
                    return context.Eliminar(usuario);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static bool Modificar(Usuarios usuario)
        {
            using (var context = new Respository<Usuarios>())
            {
                try
                {
                    return context.Modificar(usuario);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static List<Usuarios> GetList(Expression<Func<Usuarios, bool>> criterio)
        {
            using (var context = new Respository<Usuarios>())
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

        public static List<Usuarios> GetListAll()
        {
            using (var context = new Respository<Usuarios>())
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

        public static Usuarios Buscar(Expression<Func<Usuarios, bool>> criterio)
        {
            using (var context = new Respository<Usuarios>())
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
