// -----------------------------------------------------------------------
// <copyright file="FormasPagoN.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Negocios.Cartera
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Entities;
    using Entities.Types;
    using Datos.Cartera;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class FormasPagoN
    {
        private FormasPagoD persistencia;             

        public FormasPagoN()
        {
            this.persistencia = new FormasPagoD();
        }

        public List<FormasPagoDataSource> CargarFormas()
        {
            List<FormasPagoDataSource> formas = new List<FormasPagoDataSource>();
            try
            {
                var items = this.persistencia.CargarFormas();
                foreach (var item in items)
                {
                    FormasPagoDataSource forma = new FormasPagoDataSource();
                    forma.CodigoFormas = item.codformaspago;
                    forma.NombreFormas = item.nombreforma;
                    forma.PideVencimiento = item.sivence;
                    formas.Add(forma);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return formas;
        }

        public bool GuardoForma(FormasPagoDataSource formas)
        {
            bool guardo = false;
            formaspago formap = new formaspago();
            formap.codformaspago = formas.CodigoFormas;
            formap.nombreforma = formas.NombreFormas;
            formap.sivence = formas.PideVencimiento;

            try
            {
                guardo = this.persistencia.GuardoFormas(formap);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return guardo;
        }

        public bool ExisteFormas(string codigo)
        {
            bool existe = false;
            try
            {
                existe = this.persistencia.ExisteFormas(codigo);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return existe;
        }

        public bool ActualizarForma(FormasPagoDataSource formas)
        {
            bool guardo = false;
            formaspago formap = new formaspago();
            formap.codformaspago = formas.CodigoFormas;
            formap.nombreforma = formas.NombreFormas;
            formap.sivence = formas.PideVencimiento;

            try
            {
                guardo = this.persistencia.ActualizarFormas(formap);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return guardo;
        }

        public FormasPagoDataSource DevolverFomras(string id)
        {
            FormasPagoDataSource formas = new FormasPagoDataSource();
            try
            {
                var item = this.persistencia.DevolverFormas(id);
                formas.CodigoFormas = item.codformaspago;
                formas.NombreFormas = item.nombreforma;
                formas.PideVencimiento = item.sivence;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return formas;
        }

        public bool EliminarForma(string id)
        {
            bool elimina = false;
            try
            {
                elimina = this.persistencia.EliminaForma(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return elimina;
        }

        public List<FormasPagoDataSource> BuscarFormas(string buscar)
        {
            List<FormasPagoDataSource> formas = new List<FormasPagoDataSource>();
            try
            {
                var items = this.persistencia.BuscarFormas(buscar);
                foreach (var item in items)
                {
                    FormasPagoDataSource forma = new FormasPagoDataSource();
                    forma.CodigoFormas = item.codformaspago;
                    forma.NombreFormas = item.nombreforma;
                    forma.PideVencimiento = item.sivence;
                    formas.Add(forma);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return formas;
        }
    }
}
