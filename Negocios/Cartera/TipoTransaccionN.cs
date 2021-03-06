﻿// -----------------------------------------------------------------------
// <copyright file="TipoTransaccionN.cs" company="">
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
    public class TipoTransaccionN
    {
        private TipoTransaccionD persistencia;

        public TipoTransaccionN()
        {
            this.persistencia = new TipoTransaccionD();
        }

        public List<TipoTransacDataSource> CargarTiposTrans()
        {
            List<TipoTransacDataSource> tipotransacs = new List<TipoTransacDataSource>();
            var items = this.persistencia.CargarTiposTrans();
            foreach (var item in items)
            {
                TipoTransacDataSource tipo = new TipoTransacDataSource();
                tipo.CodigoTransac = item.codigotrac;
                tipo.NombreTransac = item.nombretrac;
                tipo.AfectaSaldo = item.afectasaldo;
                tipo.AfectaOtros = item.afectaotro;
                tipo.GeneraAsiento = item.generaasiento;
                tipo.Consecutivo = item.consecutivo;
                tipo.NumeroActual = item.numeroactual;
                tipo.CodigoComprobante = item.codigcomp;
                tipo.NombreComprobante = item.comprobante.descripcomprob;
                tipotransacs.Add(tipo);
            }

            return tipotransacs;
        }

        public bool GuardarDatos(TipoTransacDataSource tipot)
        {
            bool result = false;
            maetrac tipotr = new maetrac();
            tipotr.codigotrac = tipot.CodigoTransac;
            tipotr.nombretrac = tipot.NombreTransac;
            tipotr.afectasaldo = tipot.AfectaSaldo;
            tipotr.afectaotro = tipot.AfectaOtros;
            tipotr.generaasiento = tipot.GeneraAsiento;
            tipotr.consecutivo = tipot.Consecutivo;
            tipotr.numeroactual = tipot.NumeroActual;
            tipotr.codigcomp = tipot.CodigoComprobante;
            try
            {
                result = this.persistencia.GuardarDatos(tipotr);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public bool ActualizarDato(TipoTransacDataSource tipot)
        {
            bool result = false;
            maetrac tipotr = new maetrac();
            tipotr.codigotrac = tipot.CodigoTransac;
            tipotr.nombretrac = tipot.NombreTransac;
            tipotr.afectasaldo = tipot.AfectaSaldo;
            tipotr.afectaotro = tipot.AfectaOtros;
            tipotr.generaasiento = tipot.GeneraAsiento;
            tipotr.consecutivo = tipot.Consecutivo;
            tipotr.numeroactual = tipot.NumeroActual;
            tipotr.codigcomp = tipot.CodigoComprobante;
            try
            {
                result = this.persistencia.ActualizaDato(tipotr);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public bool EliminarTransacc(string id)
        {
            bool result = false;
            try
            {
                result = this.persistencia.EliminarTransac(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public TipoTransacDataSource DevolverDato(string id)
        {
            TipoTransacDataSource tipo = new TipoTransacDataSource();
            maetrac item = new maetrac();
            try
            {
                item = this.persistencia.DevolverDato(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            tipo.CodigoTransac = item.codigotrac;
            tipo.NombreTransac = item.nombretrac;
            tipo.AfectaSaldo = item.afectasaldo;
            tipo.AfectaOtros = item.afectaotro;
            tipo.GeneraAsiento = item.generaasiento;
            tipo.Consecutivo = item.consecutivo;
            tipo.NumeroActual = item.numeroactual;
            tipo.CodigoComprobante = item.codigcomp;
            tipo.NombreComprobante = item.comprobante.descripcomprob;
            return tipo;
        }

        public bool ExisteDato(string codigo)
        {
            bool existe = true;
            try
            {
                existe = this.persistencia.ExisteDato(codigo);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return existe;
        }

        public List<TipoTransacDataSource> BuscarTipo(string buscar)
        {
            List<TipoTransacDataSource> tipotransacs = new List<TipoTransacDataSource>();
            var items = this.persistencia.BuscarTipo(buscar);
            foreach (var item in items)
            {
                TipoTransacDataSource tipo = new TipoTransacDataSource();
                tipo.CodigoTransac = item.codigotrac;
                tipo.NombreTransac = item.nombretrac;
                tipo.AfectaSaldo = item.afectasaldo;
                tipo.AfectaOtros = item.afectaotro;
                tipo.GeneraAsiento = item.generaasiento;
                tipo.Consecutivo = item.consecutivo;
                tipo.NumeroActual = item.numeroactual;
                tipo.CodigoComprobante = item.codigcomp;
                tipo.NombreComprobante = item.comprobante.descripcomprob;
                tipotransacs.Add(tipo);
            }

            return tipotransacs;
        }
    }
}
