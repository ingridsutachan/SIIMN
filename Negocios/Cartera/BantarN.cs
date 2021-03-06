﻿// -----------------------------------------------------------------------
// <copyright file="BantarN.cs" company="">
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
    using Entities;
    using Entities.Types;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class BantarN
    {
        private BantarD persistencia;

        public BantarN()
        {
            this.persistencia = new BantarD();
        }

        public List<BantarDataSource> CargarBantar()
        {
            List<BantarDataSource> bantarj = new List<BantarDataSource>();
            try
            {
                var items = this.persistencia.CargarBantar();
                foreach (var item in items)
                {
                    BantarDataSource bantar = new BantarDataSource();
                    bantar.CodigoBantar = item.codigobanta;
                    bantar.NombreBantar = item.nombrebanta;
                    bantar.TipoBantar = item.tipobanta == "B" ? "BANCO" : "TARJETA";
                    bantarj.Add(bantar);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return bantarj;
        }

        public bool ExisteBantar(string codigo)
        {
            bool existe = false;
            try
            {
                existe = this.persistencia.ExisteBantar(codigo);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return existe;
        }

        public bool GuardoBantar(BantarDataSource bantar)
        {
            bool guardo = false;
            maebanta banctar = new maebanta();
            banctar.codigobanta = bantar.CodigoBantar;
            banctar.nombrebanta = bantar.NombreBantar;
            banctar.tipobanta = bantar.TipoBantar;

            try
            {
                guardo = this.persistencia.GuardoBantar(banctar);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return guardo;
        }

        public bool ActualizarBantar(BantarDataSource bantar)
        {
            bool guardo = false;
            maebanta banctar = new maebanta();
            banctar.codigobanta = bantar.CodigoBantar;
            banctar.nombrebanta = bantar.NombreBantar;
            banctar.tipobanta = bantar.TipoBantar;

            try
            {
                guardo = this.persistencia.ActualizarBantar(banctar);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return guardo;
        }

        public BantarDataSource DevolverBantar(string id)
        {
            BantarDataSource bantar = new BantarDataSource();
           
            try
            {
                var item = this.persistencia.DevolverBantar(id);
                bantar.CodigoBantar = item.codigobanta;
                bantar.NombreBantar = item.nombrebanta;
                bantar.TipoBantar = item.tipobanta;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return bantar;

        }

        public bool EliminarBantar(string id)
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

        public List<BantarDataSource> BuscarBantar(string buscar)
        {
            List<BantarDataSource> bantarj = new List<BantarDataSource>();
            try
            {
                var items = this.persistencia.BuscarBantar(buscar);
                foreach (var item in items)
                {
                    BantarDataSource bantar = new BantarDataSource();
                    bantar.CodigoBantar = item.codigobanta;
                    bantar.NombreBantar = item.nombrebanta;
                    bantar.TipoBantar = item.tipobanta == "B" ? "BANCO" : "TARJETA";
                    bantarj.Add(bantar);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return bantarj;
        }
    }
}
