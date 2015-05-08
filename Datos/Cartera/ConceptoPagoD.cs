// -----------------------------------------------------------------------
// <copyright file="ConceptoPagoD.cs" company="">
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
    public class ConceptoPagoD
    {
        public ConceptoPagoD()
        {
        }

        public List<conceptospagos> CargarConcePago()
        {
            List<conceptospagos> conpago = new List<conceptospagos>();
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.conceptospagos.Include("formaspago").Include("maeconta").ToList();
                conpago = query;
            }

            return conpago;
        }


      /*  public bool ExisteConPago(string codigo)
        {
            /*bool existe = false;
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.conceptospagos.Where(con => con.idconceptospago == codigo).Count();
                existe = query > 0 ? true : false;
            }

            return existe;
        }*/

        public bool GuardoConPago(conceptospagos conpa)
        {
            bool guardo = false;
            using (siimnEntities bd = new siimnEntities())
            {
                bd.conceptospagos.Add(conpa);
                bd.SaveChanges();
                guardo = true;
            }

            return guardo;
        }

        public bool ActualizarConPago(conceptospagos conpa)
        {
            bool guardo = false;
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.conceptospagos.Where(con => con.idconceptospago == conpa.idconceptospago).First();
                query.descripconcep= conpa.descripconcep;
                query.codformaspago = conpa.codformaspago;
                query.cuenta = conpa.cuenta;
                query.porcentaje = conpa.porcentaje;
                bd.SaveChanges();
                guardo = true;
            }

            return guardo;
        }

       /* public conceptospagos DevolverConPago(string id)
        {
            conceptospagos conpa = new conceptospagos();
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.conceptospagos.Include("formaspago").Include("maeconta").Where(con => con.idconceptospago == id).First();
                conpa = query;
            }

            return conpa;
        }*/

        /*public bool EliminaConPa(string id)
        {
            bool elimina = false;
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.conceptospagos.Where(con => con.idconceptospago == id).First();
                bd.conceptospagos.Remove(query);
                bd.SaveChanges();
                elimina = true;
            }

            return elimina;
        }*/

       /* public List<conceptospagos> BuscarConPa(string buscar)
        {
            List<conceptospagos> conpa = new List<conceptospagos>();
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.conceptospagos.Include("formaspago").Include("maeconta").Where(con => con.idconceptospago.Contains(buscar) || con.descripconcep.Contains(buscar));
                if (query.Count() > 0)
                {
                    conpa = query.ToList();
                }
            }

            return conpa;
        }*/
    }
}
