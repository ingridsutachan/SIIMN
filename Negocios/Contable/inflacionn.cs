﻿////*********************************************************
//
//    <copyright file="inflacionn.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 26 febrero 2015
//    </copyright>
//
////*********************************************************

namespace Negocios.Contable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Datos.Contable;
    using Entities.Types;
    using Entities;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class inflacionn
    {
        private Inflacionc persistencia;

        public inflacionn()
        {
            this.persistencia = new Inflacionc();
        }

        public List<InflacionDataSource> CargarDatos(int idsucursal)
        {
            List<InflacionDataSource> inflas = new List<InflacionDataSource>();
            try
            {
                var items = this.persistencia.CargarDatos(idsucursal);
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        InflacionDataSource infla = new InflacionDataSource();
                        infla.IdSucursal = item.idsucursal;
                        infla.Mes = item.mes;
                        infla.inflacion = item.inflamensual;
                        inflas.Add(infla);
                    }
                }
                else
                {
                    for (int i = 0; i <= 11; i++)
                    {
                        InflacionDataSource infla = new InflacionDataSource();
                        infla.IdSucursal = idsucursal;
                        infla.Mes = Convert.ToString(i+1);
                        infla.inflacion = 0;
                        inflas.Add(infla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return inflas;
        }

        public bool GuardarInflacion(List<InflacionDataSource> infla, int idsucursal)
        {
            List<inflacion> inflaciones = new List<inflacion>();
            foreach (InflacionDataSource item in infla)
            {
                inflacion inf = new inflacion();
                inf.mes = item.Mes;
                inf.idsucursal = item.IdSucursal;
                inf.inflamensual = item.inflacion;
                inflaciones.Add(inf);
            }
            return this.persistencia.GuardarInflacion(inflaciones, idsucursal);
        }
    }
}