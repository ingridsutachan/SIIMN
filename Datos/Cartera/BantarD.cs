﻿// -----------------------------------------------------------------------
// <copyright file="BantarD.cs" company="">
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
    public class BantarD
    {
        public BantarD()
        {
        }

        public List<maebanta> CargarBantar()
        {
            List<maebanta> banta = new List<maebanta>();
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.maebanta.ToList();
                banta = query;
            }

            return banta;
        }

        public bool ExisteBantar(string codigo)
        {
            bool existe = false;
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.maebanta.Where(mae => mae.codigobanta == codigo).Count();
                existe = query > 0 ? true : false;
            }

            return existe;
        }

        public bool GuardoBantar(maebanta banctar)
        {
            bool guardo = false;
            using (siimnEntities bd = new siimnEntities())
            {
                bd.maebanta.Add(banctar);
                bd.SaveChanges();
                guardo = true;
            }

            return guardo;
        }

        public bool ActualizarBantar(maebanta banctar)
        {
            bool guardo = false;
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.maebanta.Where(mae => mae.codigobanta == banctar.codigobanta).First();
                query.nombrebanta = banctar.nombrebanta;
                query.tipobanta = banctar.tipobanta;
                bd.SaveChanges();
                guardo = true;
            }

            return guardo;
        }

        public maebanta DevolverBantar(string id)
        {
            maebanta bantar = new maebanta();
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.maebanta.Where(mae => mae.codigobanta == id).First();
                bantar = query;
            }

            return bantar;
        }

        public bool EliminaForma(string id)
        {
            bool elimina = false;
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.maebanta.Where(mae => mae.codigobanta == id).First();
                bd.maebanta.Remove(query);
                bd.SaveChanges();
                elimina = true;
            }

            return elimina;
        }

        public List<maebanta> BuscarBantar(string buscar)
        {
            List<maebanta> bantar = new List<maebanta>();
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.maebanta.Where(mae => mae.nombrebanta.Contains(buscar) || mae.codigobanta.Contains(buscar));
                if (query.Count() > 0)
                {
                    bantar = query.ToList();
                }
            }

            return bantar;
        }
    }
}
