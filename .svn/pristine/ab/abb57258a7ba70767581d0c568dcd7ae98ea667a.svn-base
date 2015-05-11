// -----------------------------------------------------------------------
// <copyright file="ConceptosN.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Negocios.Cartera
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Datos.Cartera;
    using Entities.Types;
    using Entities;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ConceptosN
    {
        private ConceptosD persistencia;

        public ConceptosN()
        {
            this.persistencia = new ConceptosD();
        }
        public List<ConceptosDataSource> CargarConceptos()
        {
            List<ConceptosDataSource> concep = new List<ConceptosDataSource>();
            try
            {
                var items = this.persistencia.CargarConceptos();
                foreach (var item in items)
                {
                    ConceptosDataSource concepto = new ConceptosDataSource();
                    concepto.CodigoConcepto = item.idconcepto;
                    concepto.NombreConcepto = item.descripconcepto;
                    concep.Add(concepto);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return concep;
        }

        public bool ExisteConcepto(int codigo)
        {
            bool existe = false;
            try
            {
                existe = this.persistencia.ExisteConcepto(codigo);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return existe;
        }

        public bool GuardoConcepto(ConceptosDataSource concepto)
        {
            bool guardo = false;
            maeconcc concep = new maeconcc();
            concep.idconcepto = concepto.CodigoConcepto;
            concep.descripconcepto = concepto.NombreConcepto;

            try
            {
                guardo = this.persistencia.GuardoConcepto(concep);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return guardo;
        }

        public bool ActualizarConcepto(ConceptosDataSource concepto)
        {
            bool guardo = false;
            maeconcc concep = new maeconcc();
            concep.idconcepto = concepto.CodigoConcepto;
            concep.descripconcepto = concepto.NombreConcepto;

            try
            {
                guardo = this.persistencia.ActualizarConcepto(concep);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return guardo;
        }

        public ConceptosDataSource DevolverConcepto(int id)
        {
            ConceptosDataSource concep = new ConceptosDataSource();
            try
            {
                var item = this.persistencia.DevolverConcepto(id);
                concep.CodigoConcepto = item.idconcepto;
                concep.NombreConcepto = item.descripconcepto;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return concep;
        }

        public bool EliminarConcepto(int id)
        {
            bool elimina = false;
            try
            {
                elimina = this.persistencia.EliminaConcepto(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return elimina;
        }

        public List<ConceptosDataSource> BuscarConcepto(string buscar)
        {
            List<ConceptosDataSource> concep = new List<ConceptosDataSource>();
            try
            {
                var items = this.persistencia.BuscarConcepto(buscar);
                foreach (var item in items)
                {
                    ConceptosDataSource concepto = new ConceptosDataSource();
                    concepto.CodigoConcepto = item.idconcepto;
                    concepto.NombreConcepto = item.descripconcepto;
                    concep.Add(concepto);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return concep;
        }
    }
}
