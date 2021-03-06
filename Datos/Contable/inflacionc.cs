﻿////*********************************************************
//
//    <copyright file="inflacionc.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 26 febrero 2015
//    </copyright>
//
////*********************************************************

namespace Datos.Contable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Entities;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Inflacionc
    {
        public Inflacionc()
        {
        }

        public List<inflacion> CargarDatos(int idsucursal, string anio)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.inflacion.Where(inf => inf.idsucursal == idsucursal && inf.anio == anio);
                    if (query.Count() > 0)
                    {
                        return query.ToList();
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool GuardarInflacion(List<inflacion> infla, int idsucursal, string anio)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    foreach (inflacion item in infla)
                    {
                        var query = bd.inflacion.Where(inf => inf.mes == item.mes && inf.idsucursal == idsucursal&& inf.anio == anio);
                        if (query.Count() > 0)
                        {
                            query.First().inflamensual = item.inflamensual;
                        }
                        else
                        {
                            bd.inflacion.Add(item);
                        }
                    }

                    bd.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public decimal ExisteInflacionMes(string anio, int mes, int sucursal)
        {
            try
            {
                using (siimnEntities bd = new siimnEntities())
                {
                    var query = bd.inflacion.AsEnumerable().Where(inf => inf.anio == anio && inf.idsucursal == sucursal && inf.inflamensual != 0 && inf.mes == mes);
                    if (query.Count() > 0)
                    {
                        return query.First().inflamensual;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
