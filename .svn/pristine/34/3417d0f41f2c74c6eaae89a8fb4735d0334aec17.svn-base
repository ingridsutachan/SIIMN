// -----------------------------------------------------------------------
// <copyright file="ConceptosD.cs" company="">
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
    public class ConceptosD
    {
        public ConceptosD()
        {
        }

        public List<maeconcc> CargarConceptos()
        {
            List<maeconcc> concep = new List<maeconcc>();
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.maeconcc.ToList();
                concep = query;
            }
            return concep;
        }

        public bool ExisteConcepto(int codigo)
        {
            bool existe = false;
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.maeconcc.Where(mae => mae.idconcepto == codigo).Count();
                existe = query > 0 ? true : false;
            }

            return existe;
        }

        public bool GuardoConcepto(maeconcc concepto)
        {
            bool guardo = false;
            using (siimnEntities bd = new siimnEntities())
            {
                bd.maeconcc.Add(concepto);
                bd.SaveChanges();
                guardo = true;
            }

            return guardo;
        }

        public maeconcc DevolverConcepto(int id)
        {
            maeconcc concep = new maeconcc();
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.maeconcc.Where(mae => mae.idconcepto == id).First();
                concep = query;
            }

            return concep;

        }

        public bool ActualizarConcepto(maeconcc concep)
        {
            bool guardo = false;
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.maeconcc.Where(mae => mae.idconcepto == concep.idconcepto).First();
                query.descripconcepto = concep.descripconcepto;
                bd.SaveChanges();
                guardo = true;
            }

            return guardo;
        }

        public bool EliminaConcepto(int id)
        {
            bool elimina = false;
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.maeconcc.Where(mae => mae.idconcepto == id).First();
                bd.maeconcc.Remove(query);
                bd.SaveChanges();
                elimina = true;
            }

            return elimina;
        }

        public List<maeconcc> BuscarConcepto(string buscar)
        {
            List<maeconcc> concepto = new List<maeconcc>();
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.maeconcc.Where(mae => mae.descripconcepto.Contains(buscar));
                if (query.Count() > 0)
                {
                    concepto = query.ToList();
                }
            }

            return concepto;
        }
    }
}
