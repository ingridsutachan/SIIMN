////*********************************************************
//
//    <copyright file="Parametrosn.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 02 marzo 2015
//    </copyright>
//
////*********************************************************

namespace Negocios.General
{
    using System.Collections.Generic;
    using Datos.General;
    using Entities;
    using Entities.Types;
    using System;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Parametrosn
    {
        private Parametrosc persistencia;

        public Parametrosn()
        {
            this.persistencia = new Parametrosc();
        }

        public List<ParametrosDataSource> CargarDatosComprobante()
        {
            List<ParametrosDataSource> parame = new List<ParametrosDataSource>();
            List<parametro> items = new List<parametro>();
            try
            {
                items = this.persistencia.CargarDatosComprobante();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (items != null)
            {
                foreach (parametro item in items)
                {
                    ParametrosDataSource param = new ParametrosDataSource();
                    param.IdParametro = item.idparametro;
                    param.NombreParametro = item.nombreparametro;
                    param.DescripParametro = item.descriparam;
                    param.ValorParametro = item.valorparam;
                    parame.Add(param);
                }
            }

            return parame;
        }

        public bool GuardarDatosComprobante(List<ParametrosDataSource> items)
        {
            List<parametro> parame = new List<parametro>();
            foreach (var item in items)
            {
                parametro param = new parametro();
                param.idparametro = item.IdParametro;
                param.nombreparametro = item.NombreParametro;
                param.descriparam = item.DescripParametro;
                param.valorparam = item.ValorParametro;
                parame.Add(param);
            }
            try
            {
                return this.persistencia.GuardarDatosComprobante(parame);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ParametrosDataSource> CargarDatosAsiento()
        {
            List<ParametrosDataSource> parame = new List<ParametrosDataSource>();
            var items = this.persistencia.CargarDatosAsiento();
            foreach (var item in items)
            {
                ParametrosDataSource param = new ParametrosDataSource();
                param.IdParametro = item.idparametro;
                param.NombreParametro = item.nombreparametro;
                param.DescripParametro = item.descriparam;
                param.ValorParametro = item.valorparam;
                parame.Add(param);
            }

            return parame;
        }

        public bool GuardarDatosAsiento(List<ParametrosDataSource> items)
        {
            List<parametro> parame = new List<parametro>();
            foreach (var item in items)
            {
                parametro param = new parametro();
                param.idparametro = item.IdParametro;
                param.nombreparametro = item.NombreParametro;
                param.descriparam = item.DescripParametro;
                param.valorparam = item.ValorParametro;
                parame.Add(param);
            }

            return this.persistencia.GuardarDatosAsiento(parame);
        }

        public string ActualizarEnLinea()
        {
            try
            {
                return this.persistencia.ActualizarEnLinea();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string AnioTrabajo()
        {
            try
            {
                return this.persistencia.AnioTrabajo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int MesTrabajo()
        {
            try
            {
                return this.persistencia.MesTrabajo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ComprobanteCierre()
        {
            try
            {
                return this.persistencia.ComprobanteCierre();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
