// -----------------------------------------------------------------------
// <copyright file="FormasPagoD.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Datos.Cartera
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Entities;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class FormasPagoD
    {
        public FormasPagoD()
        {
        }

        public List<formaspago> CargarFormas()
        {
            List<formaspago> formas = new List<formaspago>();
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.formaspago.ToList();
                formas = query;
            }

            return formas;
        }


        public bool GuardoFormas(formaspago formas)
        {
            bool guardo = false;
            using (siimnEntities bd = new siimnEntities())
            {
                bd.formaspago.Add(formas);
                bd.SaveChanges();
                guardo = true;
            }

            return guardo;
        }

        public bool ExisteFormas(string codigo)
        {
            bool existe = false;
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.formaspago.Where(fom => fom.codformaspago == codigo).Count();
                existe = query > 0 ? true : false;
            }

            return existe;
        }

        public bool ActualizarFormas(formaspago formas)
        {
            bool guardo = false;
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.formaspago.Where(fom => fom.codformaspago == formas.codformaspago).First();
                query.nombreforma = formas.nombreforma;
                query.sivence = formas.sivence;
                bd.SaveChanges();
                guardo = true;
            }

            return guardo;
        }

        public formaspago DevolverFormas(string id)
        {
            formaspago formas = new formaspago();
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.formaspago.Where(fom => fom.codformaspago == id).First();
                formas = query;
            }

            return formas;
        }

        public bool EliminaForma(string id)
        {
            bool elimina = false;
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.formaspago.Where(fom => fom.codformaspago == id).First();
                bd.formaspago.Remove(query);
                bd.SaveChanges();
                elimina = true;
            }

            return elimina;
        }

        public List<formaspago> BuscarFormas(string buscar)
        {
            List<formaspago> formas = new List<formaspago>();
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.formaspago.Where(fom => fom.nombreforma.Contains(buscar) || fom.codformaspago.Contains(buscar));
                if (query.Count() > 0)
                {
                    formas = query.ToList();
                }
            }

            return formas;
        }
    }
}
