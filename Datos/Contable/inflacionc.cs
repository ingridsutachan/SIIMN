////*********************************************************
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

        public List<inflacion> CargarDatos(int idsucursal)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.inflacion.Where(inf => inf.idsucursal == idsucursal);
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

        public bool GuardarInflacion(List<inflacion> infla, int idsucursal)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    foreach (inflacion item in infla)
                    {
                        var query = bd.inflacion.Where(inf => inf.mes == item.mes && inf.idsucursal == idsucursal);
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
    }
}
