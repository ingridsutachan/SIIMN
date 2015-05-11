// -----------------------------------------------------------------------
// <copyright file="FormatorcD.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Datos.Cartera
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entities;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class FormatorcD
    {
        public FormatorcD()
        {
        }
        
        public bool ExisteFormato(int formato)
        {
            bool existe = false;
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.formato.Where(fom => fom.codigofor == formato).Count();
                existe = query > 0 ? true : false;
            }

            return existe;
        }

        public bool GuardoFormato(List<formato> formarc)
        {
            bool result = false;
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    foreach (formato item in formarc)
                    {
                        bd.formato.Add(item);
                        bd.SaveChanges();
                        result = true;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return result;
        }

        public List<formato> DevolverFormato(int format)
        {
            List<formato> formato = new List<formato>();
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.formato.Where(fom => fom.codigofor == format).ToList();
                formato = query;
            }

            return formato;
        }

       /* public bool ActualizoFormato(List<formato> formarc)
        {
            bool result = false;
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    foreach (formato item in formarc)
                    {
                        var query = bd.formato.Where(fom => fom.codigofor == item.codigofor && fom.nombrefor == item.nombrefor).First();
                        query.fila = item.fila;
                        query.columna = item.columna;
                        query.condensa = item.condensa;
                        query.presentacion = item.presentacion;
                        query.titulo = item.titulo;
                        bd.SaveChanges();
                        result = true;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return result;
        }*/
    }
}
