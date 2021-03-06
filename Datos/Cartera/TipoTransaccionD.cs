﻿// -----------------------------------------------------------------------
// <copyright file="TipoTransaccionD.cs" company="">
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
    public class TipoTransaccionD
    {
        public TipoTransaccionD()
        {
        }

        public List<maetrac> CargarTiposTrans()
        {
            List<maetrac> tipotrans = new List<maetrac>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    tipotrans = bd.maetrac.Include("comprobante").ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return tipotrans;
        }

        public bool GuardarDatos(maetrac tipotr)
        {
            bool result = false;
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    bd.maetrac.Add(tipotr);
                    bd.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                result = true;
            }

            return result;
        }

        public bool ActualizaDato(maetrac tipotr)
        {
            bool result = false;
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.maetrac.Where(ma => ma.codigotrac == tipotr.codigotrac).First();
                    query.nombretrac = tipotr.nombretrac;
                    query.afectasaldo = tipotr.afectasaldo;
                    query.afectaotro = tipotr.afectaotro;
                    query.generaasiento = tipotr.generaasiento;
                    query.consecutivo = tipotr.consecutivo;
                    query.numeroactual = tipotr.numeroactual;
                    query.codigcomp = tipotr.codigcomp ;
                    bd.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                result = true;
            }

            return result;
        }

        public bool EliminarTransac(string id)
        {
            bool result = false;
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.maetrac.Where(mae => mae.codigotrac == id).First();
                    bd.maetrac.Remove(query);
                    bd.SaveChanges();
                    result = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return result;
        }


        public maetrac DevolverDato(string id)
        {
            maetrac tipo = new maetrac();
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.maetrac.Include("comprobante").Where(mae => mae.codigotrac == id).First();
                tipo = query;
            }
            return tipo;
        }

        public bool ExisteDato(string codigo)
        {
            bool existe = true;
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.maetrac.Where(mae => mae.codigotrac == codigo).Count();
                existe = query > 0 ? true : false;
            }

            return existe;
        }

        public List<maetrac> BuscarTipo(string buscar)
        {
            List<maetrac> transa = new List<maetrac>();
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.maetrac.Include("comprobante").Where(mae => mae.codigotrac.Contains(buscar) || mae.nombretrac.Contains(buscar));
                if (query.Count() > 0)
                {
                    transa = query.ToList();
                }
            }

            return transa;
        }
    }
}
