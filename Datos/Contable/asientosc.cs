﻿////*********************************************************
//
//    <copyright file="asientosc.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 30 Marzo 2015
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
    public class asientosc
    {
        public asientosc()
        {
        }

        public bool ExisteAsiento(string documento, int codcompr, int sucursal)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.movimi.Where(mov => mov.idsucursal == sucursal && mov.documento == documento && mov.asientofijo == false && mov.codigcomprob == codcompr && mov.eliminado == false);
                    if (query.Count() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<movimi> DevolverAsiento(int codcompr, string documento, string anio, int sucursal, bool act)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.movimi.Include("maenits").Include("maeconta").Where(mov => mov.idsucursal == sucursal && mov.documento == documento && mov.asientofijo == false && mov.codigcomprob == codcompr && mov.eliminado == false && mov.anio == anio && mov.actualizado == act);
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

        public bool GuardarAsiento(List<movimi> asiento)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    foreach (movimi item in asiento)
                    {
                        bd.movimi.Add(item);
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

        public List<movimi> UpdateUnAsiento(List<movimi> asiento)
        {
            List<movimi> asientoant = new List<movimi>();
            string idasiento = asiento[0].idasiento;
            int sucursal = asiento[0].idsucursal;
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.movimi.Where(mov => mov.idsucursal == sucursal && mov.idasiento == idasiento && mov.eliminado == false);
                    if (query.Count() > 0)
                    {
                        asientoant = query.ToList();
                        for (int i = 0; i < query.Count(); i++)
                        {
                            query.ToList()[i].cuenta = asiento[i].cuenta;
                            query.ToList()[i].detalle = asiento[i].detalle;
                            query.ToList()[i].idcentro = asiento[i].idcentro;
                            query.ToList()[i].idnit = asiento[i].idnit;
                            query.ToList()[i].referencia = asiento[i].referencia;
                            query.ToList()[i].valordebito = asiento[i].valordebito;
                            query.ToList()[i].valorcredito = asiento[i].valorcredito;
                            query.ToList()[i].baseimpuesto = asiento[i].baseimpuesto;
                            query.ToList()[i].valorica = asiento[i].valorica;
                            query.ToList()[i].entrada = asiento[i].entrada;
                            query.ToList()[i].idusuario = asiento[i].idusuario;
                            query.ToList()[i].fechagrabacion = asiento[i].fechagrabacion;
                            query.ToList()[i].idusuarioact = asiento[i].idusuarioact;
                            query.ToList()[i].fechaact = asiento[i].fechaact;
                        }

                        bd.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return asientoant;
        }

        public string DevolverConsecutivo(int codcomprobante, int sucursal)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.movimi.Where(mov => mov.idsucursal == sucursal && mov.codigcomprob == codcomprobante && mov.eliminado == false && mov.asientofijo == false);
                    if (query.Count() > 0)
                    {
                        int documento = int.Parse(query.ToList().Max(mov => mov.documento)) + 1;
                        return Convert.ToString(documento);
                    }
                    else
                    {
                        return "1";
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public int ActualizarUnAsiento(List<movimi> asiento)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    if (asiento.Count() > 0)
                    {
                        foreach (movimi item in asiento)
                        {
                            var querysaldoscuentas = bd.saldoscuentas.Where(sal => sal.idsucursal == item.idsucursal &&
                                      sal.cuenta == item.cuenta && sal.anio == item.anio && sal.mes == item.mes);
                            if (querysaldoscuentas.Count() > 0)
                            {
                                querysaldoscuentas.First().saldomes = querysaldoscuentas.First().saldomes + item.valordebito + item.valorcredito;
                                querysaldoscuentas.First().debimes = querysaldoscuentas.First().debimes + item.valordebito;
                                querysaldoscuentas.First().credimes = querysaldoscuentas.First().credimes + item.valorcredito;
                            }
                            else
                            {
                                for (int i = 1; i <= 12; i++)
                                {
                                    saldoscuentas saldos = new saldoscuentas();
                                    saldos.idsucursal = item.idsucursal;
                                    saldos.cuenta = item.cuenta;
                                    saldos.anio = item.anio;
                                    saldos.mes = i;
                                    if (item.mes == i)
                                    {
                                        saldos.saldomes = item.valorcredito + item.valordebito;
                                        saldos.debimes = item.valordebito;
                                        saldos.credimes = item.valorcredito;
                                    }
                                    else
                                    {
                                        saldos.saldomes = 0;
                                        saldos.debimes = 0;
                                        saldos.credimes = 0;
                                    }
                                    bd.saldoscuentas.Add(saldos);
                                }
                            }

                            if (item.idnit != null)
                            {
                                var querysaldosnits = bd.maepagos.Where(mae => mae.idsucursal == item.idsucursal && mae.cuenta == item.cuenta
                              && mae.idnit == item.idnit && mae.anio == item.anio && mae.mes == item.mes);
                                if (querysaldosnits.Count() > 0)
                                {
                                    querysaldosnits.First().saldomes = querysaldosnits.First().saldomes + item.valordebito + item.valorcredito;
                                    querysaldosnits.First().debimes = querysaldosnits.First().debimes + item.valordebito;
                                    querysaldosnits.First().credimes = querysaldosnits.First().credimes + item.valorcredito;
                                }
                                else
                                {
                                    for (int i = 1; i <= 12; i++)
                                    {
                                        maepagos pagos = new maepagos();
                                        pagos.idsucursal = item.idsucursal;
                                        pagos.cuenta = item.cuenta;
                                        pagos.idnit = item.idnit ?? default(int);
                                        pagos.anio = item.anio;
                                        pagos.mes = i;
                                        if (item.mes == i)
                                        {
                                            pagos.saldomes = item.valorcredito + item.valordebito;
                                            pagos.debimes = item.valordebito;
                                            pagos.credimes = item.valorcredito;
                                        }
                                        else
                                        {
                                            pagos.saldomes = 0;
                                            pagos.debimes = 0;
                                            pagos.credimes = 0;
                                        }
                                        bd.maepagos.Add(pagos);
                                    }
                                }
                            }

                            if (item.idcentro != null)
                            {

                                var querysaldoscentro = bd.acucentr.Where(acu => acu.idsucursal == item.idsucursal && acu.anio == item.anio && acu.mes == item.mes
                                && acu.idcentro == item.idcentro && acu.idcuenta == item.cuenta && acu.idnit == item.idnit);
                                if (querysaldoscentro.Count() > 0)
                                {
                                    querysaldoscentro.First().saldomes = querysaldoscentro.First().saldomes + item.valordebito + item.valorcredito;
                                    querysaldoscentro.First().debimes = querysaldoscentro.First().debimes + item.valordebito;
                                    querysaldoscentro.First().credimes = querysaldoscentro.First().credimes + item.valorcredito;
                                }
                            }
                            else
                            {
                                for (int i = 1; i <= 12; i++)
                                {
                                    acucentr salcentro = new acucentr();
                                    salcentro.idsucursal = item.idsucursal;
                                    salcentro.idcuenta = item.cuenta;
                                    salcentro.idnit = item.idnit ?? default(int);
                                    salcentro.idcentro = item.idcentro ?? default(int);
                                    salcentro.anio = item.anio;
                                    salcentro.mes = i;
                                    if (item.mes == i)
                                    {
                                        salcentro.saldomes = item.valorcredito + item.valordebito;
                                        salcentro.debimes = item.valordebito;
                                        salcentro.credimes = item.valorcredito;
                                    }
                                    else
                                    {
                                        salcentro.saldomes = 0;
                                        salcentro.debimes = 0;
                                        salcentro.credimes = 0;
                                    }
                                    bd.acucentr.Add(salcentro);
                                }
                            }
                        }

                        bd.SaveChanges();
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public int ActualizarTodosAsientos(DateTime desde, DateTime hasta, int sucursal, int usuarioact)
        {
            int cantasientos = 0;
            try
            {
                using (siimnEntities bd = new siimnEntities())
                {
                    var query = bd.movimi.AsEnumerable().Where(mov => mov.idsucursal == sucursal && mov.actualizado == false && mov.eliminado == false && mov.asientofijo == false && (mov.fecha.Date >= desde.Date && mov.fecha.Date <= hasta.Date));
                    if (query.Count() > 0)
                    {
                        string idasiento = string.Empty;
                        foreach (movimi item in query.ToList())
                        {
                            var saldosquery = bd.saldoscuentas.Where(sal => sal.idsucursal == item.idsucursal &&
                                                           sal.cuenta == item.cuenta && sal.anio == item.anio
                                                          && sal.mes == item.mes);
                            if (saldosquery.Count() > 0)
                            {
                                saldosquery.First().saldomes = saldosquery.First().saldomes + item.valordebito + item.valorcredito;
                                saldosquery.First().debimes = saldosquery.First().debimes + item.valordebito;
                                saldosquery.First().credimes = saldosquery.First().credimes + item.valorcredito;
                            }
                            else
                            {
                                for (int i = 1; i <= 12; i++)
                                {
                                    saldoscuentas saldos = new saldoscuentas();
                                    saldos.idsucursal = item.idsucursal;
                                    saldos.cuenta = item.cuenta;
                                    saldos.anio = item.anio;
                                    saldos.mes = i;
                                    if (item.mes == i)
                                    {
                                        saldos.saldomes = item.valorcredito + item.valordebito;
                                        saldos.debimes = item.valordebito;
                                        saldos.credimes = item.valorcredito;
                                    }
                                    else
                                    {
                                        saldos.saldomes = 0;
                                        saldos.debimes = 0;
                                        saldos.credimes = 0;
                                    }

                                    bd.saldoscuentas.Add(saldos);
                                }
                            }

                            if (item.idnit != null)
                            {
                                var itemquery = bd.maepagos.Where(mae => mae.idsucursal == item.idsucursal && mae.cuenta == item.cuenta
                               && mae.idnit == item.idnit && mae.anio == item.anio && mae.mes == item.mes);
                                if (itemquery.Count() > 0)
                                {
                                    itemquery.First().saldomes = itemquery.First().saldomes + item.valordebito + item.valorcredito;
                                    itemquery.First().debimes = itemquery.First().debimes + item.valordebito;
                                    itemquery.First().credimes = itemquery.First().credimes + item.valorcredito;
                                }
                                else
                                {
                                    for (int i = 1; i <= 12; i++)
                                    {
                                        maepagos pagos = new maepagos();
                                        pagos.idsucursal = item.idsucursal;
                                        pagos.cuenta = item.cuenta;
                                        pagos.idnit = item.idnit ?? default(int);
                                        pagos.anio = item.anio;
                                        pagos.mes = i;
                                        if (item.mes == i)
                                        {
                                            pagos.saldomes = item.valorcredito + item.valordebito;
                                            pagos.debimes = item.valordebito;
                                            pagos.credimes = item.valorcredito;
                                        }
                                        else
                                        {
                                            pagos.saldomes = 0;
                                            pagos.debimes = 0;
                                            pagos.credimes = 0;
                                        }

                                        bd.maepagos.Add(pagos);
                                    }
                                }
                            }

                            if (item.idcentro != null)
                            {
                                var costosquery = bd.acucentr.Where(acu => acu.idsucursal == item.idsucursal && acu.anio == item.anio && acu.mes == item.mes
    && acu.idcentro == item.idcentro && acu.idcuenta == item.cuenta && acu.idnit == item.idnit);
                                if (costosquery.Count() > 0)
                                {
                                    costosquery.First().saldomes = costosquery.First().saldomes + item.valordebito + item.valorcredito;
                                    costosquery.First().debimes = costosquery.First().debimes + item.valordebito;
                                    costosquery.First().credimes = costosquery.First().credimes + item.valorcredito;
                                }
                                else
                                {
                                    for (int i = 1; i <= 12; i++)
                                    {
                                        acucentr salcentro = new acucentr();
                                        salcentro.idsucursal = item.idsucursal;
                                        salcentro.idcuenta = item.cuenta;
                                        salcentro.idnit = item.idnit ?? default(int);
                                        salcentro.idcentro = item.idcentro ?? default(int);
                                        salcentro.anio = item.anio;
                                        salcentro.mes = i;
                                        if (item.mes == i)
                                        {
                                            salcentro.saldomes = item.valorcredito + item.valordebito;
                                            salcentro.debimes = item.valordebito;
                                            salcentro.credimes = item.valorcredito;
                                        }
                                        else
                                        {
                                            salcentro.saldomes = 0;
                                            salcentro.debimes = 0;
                                            salcentro.credimes = 0;
                                        }
                                        bd.acucentr.Add(salcentro);
                                    }
                                }
                            }

                            if (!idasiento.Equals(item.idasiento))
                            {
                                cantasientos++;
                            }

                            idasiento = item.idasiento;
                            //item.actualizado = true;
                            item.idusuarioact = usuarioact;
                            item.fechaact = DateTime.Now;
                            bd.SaveChanges();
                        }
                    }
                    else
                    {
                        cantasientos = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return cantasientos;
        }

        public bool DesactualizarUnAsiento(List<movimi> movant)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    foreach (movimi item in movant)
                    {
                        var query = bd.saldoscuentas.Where(sal => sal.idsucursal == item.idsucursal &&
                                                           sal.cuenta == item.cuenta && sal.anio == item.anio
                                                          && sal.mes == item.mes);
                        if (query.Count() > 0)
                        {
                            query.First().saldomes = query.First().saldomes - item.valordebito - item.valorcredito;
                            query.First().debimes = query.First().debimes - item.valordebito;
                            query.First().credimes = query.First().credimes - item.valorcredito;
                        }

                        if (item.idnit != null)
                        {
                            var query1 = bd.maepagos.Where(mae => mae.idsucursal == item.idsucursal && mae.cuenta == item.cuenta
                                                            && mae.idnit == item.idnit && mae.anio == item.anio && mae.mes == item.mes);
                            if (query1.Count() > 0)
                            {
                                query1.First().saldomes = query1.First().saldomes - item.valordebito - item.valorcredito;
                                query1.First().debimes = query1.First().debimes - item.valordebito;
                                query1.First().credimes = query1.First().credimes - item.valorcredito;
                            }
                        }

                        if (item.idcentro != null)
                        {
                            var query2 = bd.acucentr.Where(acu => acu.idsucursal == item.idsucursal && acu.anio == item.anio && acu.mes == item.mes
                                && acu.idcentro == item.idcentro && acu.idcuenta == item.cuenta && acu.idnit == item.idnit);
                            if (query2.Count() > 0)
                            {
                                query2.First().saldomes = query2.First().saldomes - item.valordebito - item.valorcredito;
                                query2.First().debimes = query2.First().debimes - item.valordebito;
                                query2.First().credimes = query2.First().credimes - item.valorcredito;
                            }
                        }
                        item.actualizado = false;
                        item.idusuarioact = null;
                        item.fechaact = null;
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

        public List<movimi> BusquedaFijo(string tipo, string buscar, int comprobante, int sucursal)
        {
            List<movimi> asientobus = new List<movimi>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    if (comprobante != 0)
                    {
                        switch (tipo)
                        {
                            case "cuenta":
                                var query = bd.movimi.Include("maeconta").Include("centrocostos").Include("maenits").OrderBy(mov => mov.idasiento)
                                    .Where(mov => mov.idsucursal == sucursal && mov.asientofijo == true && mov.eliminado == false && mov.codigcomprob == comprobante && mov.maeconta.cuenta.Contains(buscar));
                                asientobus = query.Count() > 0 ? query.ToList() : null;
                                break;

                            case "nit":
                                var query1 = bd.movimi.Include("maeconta").Include("centrocostos").Include("maenits").OrderBy(mov => mov.idasiento)
                                    .Where(mov => mov.idsucursal == sucursal && mov.asientofijo == true && mov.eliminado == false && mov.codigcomprob == comprobante && mov.maenits.nit.Contains(buscar));
                                asientobus = query1.Count() > 0 ? query1.ToList() : null;
                                break;

                            case "detalle":
                                var query2 = bd.movimi.Include("maeconta").Include("centrocostos").Include("maenits").OrderBy(mov => mov.idasiento)
                                    .Where(mov => mov.idsucursal == sucursal && mov.asientofijo == true && mov.eliminado == false && mov.codigcomprob == comprobante && mov.detalle.Contains(buscar));
                                asientobus = query2.Count() > 0 ? query2.ToList() : null;
                                break;

                            case "referencia":
                                var query3 = bd.movimi.Include("maeconta").Include("centrocostos").Include("maenits").OrderBy(mov => mov.idasiento)
                                    .Where(mov => mov.idsucursal == sucursal && mov.asientofijo == true && mov.eliminado == false && mov.codigcomprob == comprobante && mov.referencia.Contains(buscar));
                                asientobus = query3.Count() > 0 ? query3.ToList() : null;
                                break;

                            case "busqueda":
                                var query5 = bd.movimi.Include("maeconta").Include("centrocostos").Include("maenits").OrderBy(mov => mov.idasiento)
                                    .Where(mov => mov.idsucursal == sucursal && mov.asientofijo == true && mov.eliminado == false && mov.codigcomprob == comprobante && (mov.maeconta.cuenta.Contains(buscar) || mov.referencia.Contains(buscar)
                                        || mov.maenits.nit.Contains(buscar) || mov.detalle.Contains(buscar)));
                                asientobus = query5.Count() > 0 ? query5.ToList() : null;
                                break;

                            case "asientofijo":
                                var query4 = bd.movimi.Include("maeconta").Include("centrocostos").Include("maenits").OrderBy(mov => mov.idasiento).Where(mov => mov.idsucursal == sucursal && mov.asientofijo == true && mov.codigcomprob == comprobante && mov.eliminado == false);
                                asientobus = query4.Count() > 0 ? query4.ToList() : null;
                                break;

                            default:
                                asientobus = null;
                                break;
                        }
                    }
                    else
                    {
                        switch (tipo)
                        {
                            case "cuenta":
                                var query = bd.movimi.Include("maeconta").Include("centrocostos").Include("maenits").OrderBy(mov => mov.idasiento)
                                    .Where(mov => mov.idsucursal == sucursal && mov.asientofijo == true && mov.eliminado == false && mov.maeconta.cuenta.Contains(buscar));
                                asientobus = query.Count() > 0 ? query.ToList() : null;
                                break;

                            case "nit":
                                var query1 = bd.movimi.Include("maeconta").Include("centrocostos").Include("maenits").OrderBy(mov => mov.idasiento)
                                    .Where(mov => mov.idsucursal == sucursal && mov.asientofijo == true && mov.eliminado == false && mov.maenits.nit.Contains(buscar));
                                asientobus = query1.Count() > 0 ? query1.ToList() : null;
                                break;

                            case "detalle":
                                var query2 = bd.movimi.Include("maeconta").Include("centrocostos").Include("maenits").OrderBy(mov => mov.idasiento)
                                    .Where(mov => mov.idsucursal == sucursal && mov.asientofijo == true && mov.eliminado == false && mov.detalle.Contains(buscar));
                                asientobus = query2.Count() > 0 ? query2.ToList() : null;
                                break;

                            case "referencia":
                                var query3 = bd.movimi.Include("maeconta").Include("centrocostos").Include("maenits").OrderBy(mov => mov.idasiento)
                                    .Where(mov => mov.idsucursal == sucursal && mov.asientofijo == true && mov.eliminado == false && mov.referencia.Contains(buscar));
                                asientobus = query3.Count() > 0 ? query3.ToList() : null;
                                break;

                            case "busqueda":
                                var query5 = bd.movimi.Include("maeconta").Include("centrocostos").Include("maenits").OrderBy(mov => mov.idasiento)
                                    .Where(mov => mov.idsucursal == sucursal && mov.asientofijo == true && mov.eliminado == false && (mov.maeconta.cuenta.Contains(buscar) || mov.referencia.Contains(buscar)
                                        || mov.maenits.nit.Contains(buscar) || mov.detalle.Contains(buscar)));
                                asientobus = query5.Count() > 0 ? query5.ToList() : null;
                                break;

                            case "asientofijo":
                                var query4 = bd.movimi.Include("maeconta").Include("centrocostos").Include("maenits").OrderBy(mov => mov.idasiento).Where(mov => mov.idsucursal == sucursal && mov.asientofijo == true && mov.eliminado == false);
                                asientobus = query4.Count() > 0 ? query4.ToList() : null;
                                break;

                            default:
                                asientobus = null;
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return asientobus;
        }

        public List<movimi> CargarAsientoFijo(string documento, int sucursal)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.movimi.Include("maeconta").Include("maenits").Where(mov => mov.idsucursal == sucursal && mov.idasiento == documento && mov.eliminado == false);
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

        public List<movimi> Busqueda(string tipo, string buscar, bool actualizado, int sucursal)
        {
            List<movimi> asientobus = new List<movimi>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    switch (tipo)
                    {
                        case "año":
                            var query = bd.movimi.Include("comprobante").OrderBy(mov => new { mov.codigcomprob, mov.documento }).Where(mov => mov.idsucursal == sucursal && mov.comprobante.consecutivo == false && mov.eliminado == false
                                                                                    && mov.actualizado == actualizado && mov.anio.Contains(buscar));
                            asientobus = query.Count() > 0 ? query.ToList() : null;
                            break;

                        case "mes":
                            var query1 = bd.movimi.Include("comprobante").OrderBy(mov => new { mov.codigcomprob, mov.documento }).AsEnumerable().Where(mov => mov.idsucursal == sucursal && mov.comprobante.consecutivo == false && mov.eliminado == false
                                                                                    && mov.actualizado == actualizado && mov.mes.ToString().Contains(buscar));
                            asientobus = query1.Count() > 0 ? query1.ToList() : null;
                            break;

                        case "comprobante":
                            var query2 = bd.movimi.Include("comprobante").OrderBy(mov => new { mov.codigcomprob, mov.documento }).AsEnumerable().Where(mov => mov.idsucursal == sucursal && mov.comprobante.consecutivo == false && mov.eliminado == false
                                                                                    && mov.actualizado == actualizado && mov.codigcomprob.ToString().Contains(buscar));
                            asientobus = query2.Count() > 0 ? query2.ToList() : null;
                            break;

                        case "documento":
                            var query3 = bd.movimi.Include("comprobante").OrderBy(mov => new { mov.codigcomprob, mov.documento }).Where(mov => mov.idsucursal == sucursal && mov.comprobante.consecutivo == false && mov.eliminado == false
                                                                                    && mov.actualizado == actualizado && mov.documento.Contains(buscar));
                            asientobus = query3.Count() > 0 ? query3.ToList() : null;
                            break;

                        case "detalle":
                            var query4 = bd.movimi.Include("comprobante").OrderBy(mov => new { mov.codigcomprob, mov.documento }).Where(mov => mov.idsucursal == sucursal && mov.comprobante.consecutivo == false && mov.eliminado == false
                                                                                    && mov.actualizado == actualizado && mov.detalle.Contains(buscar));
                            asientobus = query4.Count() > 0 ? query4.ToList() : null;
                            break;

                        case "busqueda":
                            var query5 = bd.movimi.Include("comprobante").OrderBy(mov => new { mov.codigcomprob, mov.documento }).AsEnumerable().Where(mov => mov.idsucursal == sucursal && mov.comprobante.consecutivo == false && mov.eliminado == false
                                                                                    && mov.actualizado == actualizado && (mov.anio.Contains(buscar) || mov.mes.ToString().Contains(buscar) ||
                                                                                     mov.codigcomprob.ToString().Contains(buscar) || mov.documento.Contains(buscar) || mov.detalle.Contains(buscar)));
                            asientobus = query5.Count() > 0 ? query5.ToList() : null;
                            break;

                        case "todos":
                            var query6 = bd.movimi.Include("comprobante").OrderBy(mov => new { mov.codigcomprob, mov.documento }).Where(mov => mov.idsucursal == sucursal && mov.comprobante.consecutivo == false && mov.eliminado == false && mov.actualizado == actualizado);
                            asientobus = query6.Count() > 0 ? query6.ToList() : null;
                            break;

                        default:
                            asientobus = null;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return asientobus;
        }

        public bool ActualizarAsientoGeneral(List<movimi> lstMovimi, string idasiento, int sucursal)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.movimi.Where(mov => mov.idsucursal == sucursal && mov.idasiento == idasiento && mov.eliminado == false);
                    if (query.Count() > 0)
                    {
                        for (int i = 0; i < query.Count(); i++)
                        {
                            query.ToList()[i].idasiento = lstMovimi[i].idasiento;
                            query.ToList()[i].anio = lstMovimi[i].anio;
                            query.ToList()[i].mes = lstMovimi[i].mes;
                            query.ToList()[i].fecha = lstMovimi[i].fecha;
                            query.ToList()[i].codigcomprob = lstMovimi[i].codigcomprob;
                            query.ToList()[i].documento = lstMovimi[i].documento;
                        }

                        bd.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public bool EliminarAsiento(string idasiento, bool asientofijo, int sucursal)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.movimi.Where(mov => mov.idsucursal == sucursal && mov.idasiento == idasiento && mov.eliminado == false && mov.asientofijo == asientofijo);
                    if (query.Count() > 0)
                    {
                        foreach (var item in query.ToList())
                        {
                            item.eliminado = true;
                        }

                        bd.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public List<movimi> CargarInforme(string tipo, int sucursal)
        {
            List<movimi> asientodev = new List<movimi>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    switch (tipo)
                    {
                        case "borrados":
                            var query = bd.movimi.Include("maeconta").Include("maenits").Include("comprobante").Where(mov => mov.idsucursal == sucursal && mov.eliminado == true && mov.asientofijo == false);
                            asientodev = query.Count() > 0 ? query.ToList() : null;
                            break;

                        case "fijos":
                            var query1 = bd.movimi.Include("maeconta").Include("maenits").Include("comprobante").Where(mov => mov.idsucursal == sucursal && mov.eliminado == false && mov.asientofijo == true);
                            asientodev = query1.Count() > 0 ? query1.ToList() : null;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return asientodev;
            }
        }

        public List<movimi> DevolverAsientoXId(string idasiento, int sucursal)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.movimi.Include("maenits").Include("maeconta").Where(mov => mov.idsucursal == sucursal && mov.asientofijo == false && mov.idasiento == idasiento && mov.eliminado == false);
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


        public bool ExisteAsientoActualizar(int sucursal)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.movimi.Where(mov => mov.idsucursal == sucursal && mov.actualizado == false && mov.eliminado == false && mov.asientofijo == false);
                    if (query.Count() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public string ExisteAsientoenFecha(DateTime desde, DateTime hasta, int sucursal)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.movimi.AsEnumerable().Where(mov => mov.idsucursal == sucursal && mov.actualizado == false && mov.eliminado == false && mov.asientofijo == false && (mov.fecha.Date >= desde.Date && mov.fecha.Date <= hasta.Date));
                    if (query.Count() > 0)
                    {
                        var yaact = bd.movimi.AsEnumerable().Where(mov => mov.idsucursal == sucursal && mov.actualizado == true && mov.eliminado == false && mov.asientofijo == false && (mov.fecha.Date >= desde.Date && mov.fecha.Date <= hasta.Date));
                        if (yaact.Count() > 0)
                        {
                            return yaact.First().fecha.ToShortDateString();
                        }
                        else
                        {
                            return string.Empty;
                        }
                    }
                    else
                    {
                        return "noasientosact";
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public bool AsientoYaActualizado(string numeroasiento, int codcompro, int sucursal)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.movimi.Where(mov => mov.idsucursal == sucursal && mov.actualizado == true && mov.eliminado == false && mov.asientofijo == false && mov.documento == numeroasiento && mov.codigcomprob == codcompro);
                    if (query.Count() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<movimi> CargarInformeSinActualizar(string anio, int mes, string comprob, string docin, string docfin, int sucursal)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.movimi.Include("maeconta").Include("maenits").Include("comprobante").Where(mov => mov.idsucursal == sucursal && mov.eliminado == false && mov.asientofijo == false && mov.actualizado == false && mov.anio == anio && mov.mes == mes);
                    if ("**".Equals(comprob) && "**".Equals(docin))
                    {
                        query = query;
                    }
                    else if ("**".Equals(comprob) && !"**".Equals(docin))
                    {
                        query = query.Where(mov => mov.documento.CompareTo(docin) > 0 && mov.documento.CompareTo(docfin) < 0);
                    }
                    else if (!"**".Equals(comprob) && "**".Equals(docin))
                    {
                        int codco = Convert.ToInt32(comprob);
                        query = query.Where(mov => mov.codigcomprob == codco);

                    }
                    else if (!"**".Equals(comprob) && !"**".Equals(docin))
                    {
                        int codco = Convert.ToInt32(comprob);
                        query = query.Where(mov => mov.codigcomprob == codco && mov.documento.CompareTo(docin) > 0 && mov.documento.CompareTo(docfin) < 0);
                    }

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

        public bool TienenMovimiento(string anio, int mes, string comprob, string docin, string docfin, int sucursal)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.movimi.Include("maeconta").Include("maenits").Where(mov => mov.idsucursal == sucursal && mov.eliminado == false && mov.asientofijo == false && mov.anio == anio && mov.mes == mes);
                    if ("**".Equals(comprob) && "**".Equals(docin))
                    {
                        query = query;
                    }
                    else if ("**".Equals(comprob) && !"**".Equals(docin))
                    {
                        query = query.Where(mov => mov.documento.CompareTo(docin) > 0 && mov.documento.CompareTo(docfin) < 0);
                    }
                    else if (!"**".Equals(comprob) && "**".Equals(docin))
                    {
                        int codco = Convert.ToInt32(comprob);
                        query = query.Where(mov => mov.codigcomprob == codco);

                    }
                    else if (!"**".Equals(comprob) && !"**".Equals(docin))
                    {
                        int codco = Convert.ToInt32(comprob);
                        query = query.Where(mov => mov.codigcomprob == codco && mov.documento.CompareTo(docin) > 0 && mov.documento.CompareTo(docfin) < 0);
                    }

                    if (query.Count() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<movimi> TienenMovimientoSinAnio(int mesdesde, int meshasta, string anio, string comprob, string docin, string docfin, int sucursal)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.movimi.Include("maeconta").Include("maenits").Where(mov => mov.idsucursal == sucursal && mov.eliminado == false && mov.asientofijo == false && mov.mes >= mesdesde && mov.mes <= meshasta && mov.anio == anio);
                    if ("**".Equals(comprob) && "**".Equals(docin))
                    {
                        query = query;
                    }
                    else if ("**".Equals(comprob) && !"**".Equals(docin))
                    {
                        query = query.Where(mov => mov.documento.CompareTo(docin) > 0 && mov.documento.CompareTo(docfin) < 0);
                    }
                    else if (!"**".Equals(comprob) && "**".Equals(docin))
                    {
                        int codco = Convert.ToInt32(comprob);
                        query = query.Where(mov => mov.codigcomprob == codco);

                    }
                    else if (!"**".Equals(comprob) && !"**".Equals(docin))
                    {
                        int codco = Convert.ToInt32(comprob);
                        query = query.Where(mov => mov.codigcomprob == codco && mov.documento.CompareTo(docin) > 0 && mov.documento.CompareTo(docfin) < 0);
                    }

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

        public List<movimi> TienenMovimientoMes(int mes, string anio, int sucursal)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.movimi.Include("maeconta").Include("maenits").Where(mov => mov.idsucursal == sucursal && mov.eliminado == false && mov.asientofijo == false && mov.mes == mes && mov.anio == anio);
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

        public List<movimi> CargarInformeLibroDiario(int mesdesde, int meshasta, string anio, string comprob, string docin, string docfin, int sucursal)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.movimi.Include("maeconta").Include("maenits").Include("comprobante").Where(mov => mov.idsucursal == sucursal && mov.eliminado == false && mov.asientofijo == false && mov.actualizado == true && mov.mes >= mesdesde && mov.mes <= meshasta && mov.anio == anio);
                    if ("**".Equals(comprob) && "**".Equals(docin))
                    {
                        query = query;
                    }
                    else if ("**".Equals(comprob) && !"**".Equals(docin))
                    {
                        query = query.Where(mov => mov.documento.CompareTo(docin) > 0 && mov.documento.CompareTo(docfin) < 0);
                    }
                    else if (!"**".Equals(comprob) && "**".Equals(docin))
                    {
                        int codco = Convert.ToInt32(comprob);
                        query = query.Where(mov => mov.codigcomprob == codco);

                    }
                    else if (!"**".Equals(comprob) && !"**".Equals(docin))
                    {
                        int codco = Convert.ToInt32(comprob);
                        query = query.Where(mov => mov.codigcomprob == codco && mov.documento.CompareTo(docin) > 0 && mov.documento.CompareTo(docfin) < 0);
                    }

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

        public List<movimi> CargarInformeLibroResumido(int mes, string anio, int sucursal)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.movimi.Include("maeconta").Include("maenits").Include("comprobante").OrderBy(mov => new { mov.cuenta, mov.codigcomprob }).Where(mov => mov.idsucursal == sucursal && mov.eliminado == false && mov.asientofijo == false && mov.actualizado == true && mov.mes == mes && mov.anio == anio);
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

        public bool TienenMovimientoSinAnioSinAct(List<movimi> asiento)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = asiento.Where(asi => asi.actualizado == true);
                    if (query.Count() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public string TienenMovimientoCuentas(int mes, string anio, List<int> cuentaini, int sucursal)
        {
            string mensaje = string.Empty;
            List<movimi> movi = new List<movimi>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    foreach (int id in cuentaini)
                    {
                        var query = bd.movimi.Include("maeconta").Where(mov => mov.idsucursal == sucursal && mov.eliminado == false && mov.mes == mes && mov.anio == anio && mov.asientofijo == false && mov.cuenta == id);
                        if (query.Count() > 0)
                        {
                            foreach (var item in query.ToList())
                            {
                                movi.Add(item);
                            }
                        }
                    }
                    if (movi.Count() > 0)
                    {
                        var query2 = movi.Where(mov => mov.actualizado == true);
                        if (query2.Count() == 0)
                        {
                            mensaje = "actualizar";
                        }
                    }
                    else
                    {
                        mensaje = "noexiste";
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return mensaje;
        }

        public List<saldoscuentas> CargarBalanceMes(int mes, string anio, List<int> cuentafin, int sucursal)
        {
            List<saldoscuentas> saldos = new List<saldoscuentas>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    foreach (int cuent in cuentafin)
                    {
                        var query = bd.saldoscuentas.Include("maeconta").Where(sal => sal.mes == mes && sal.anio == anio && sal.cuenta == cuent && sal.idsucursal == sucursal);
                        if (query.Count() > 0)
                        {
                            foreach (var item in query.ToList())
                            {
                                saldos.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return saldos;
        }

        public List<maepagos> SaldosNits(int? idcuenta, string anio, int mes, int sucursal)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.maepagos.Include("maenits").Include("maeconta").Where(mae => mae.cuenta == idcuenta && mae.anio == anio && mae.mes == mes && mae.idsucursal == sucursal);
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

        public decimal SaldoNitAnterior(int idnit, int cuenta, int mes, string anio, int sucursal)
        {
            if (mes == 1)
            {
                mes = 12;
                anio = Convert.ToString(int.Parse(anio) - 1);
            }
            else
            {
                mes--;
            }
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.maepagos.Where(mae => mae.idnit == idnit && mae.mes == mes && mae.anio == anio && mae.cuenta == cuenta && mae.idsucursal == sucursal);
                    if (query.Count() > 0)
                    {
                        return query.First().saldomes;
                    }
                    else
                    {
                        return 0;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public decimal SaldoCuentaAnterior(int cuenta, int mes, string anio, int sucursal)
        {
            if (mes == 1)
            {
                mes = 12;
                anio = Convert.ToString(int.Parse(anio) - 1);
            }
            else
            {
                mes--;
            }
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.saldoscuentas.Where(mae => mae.cuenta == cuenta && mae.mes == mes && mae.anio == anio && mae.idsucursal == sucursal);
                    if (query.Count() > 0)
                    {
                        return query.First().saldomes;
                    }
                    else
                    {
                        return 0;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public string TienenMovimientoAnual(List<int> cuentasid, string anio, int sucursal)
        {
            string mensaje = string.Empty;
            List<movimi> movi = new List<movimi>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    foreach (int cuenta in cuentasid)
                    {
                        var query = bd.movimi.Where(mov => mov.cuenta == cuenta && mov.anio == anio && mov.idsucursal == sucursal && mov.asientofijo == false && mov.eliminado == false);
                        if (query.Count() > 0)
                        {
                            foreach (var item in query.ToList())
                            {
                                movi.Add(item);
                            }
                        }
                    }
                    if (movi.Count() > 0)
                    {
                        var query2 = movi.Where(mov => mov.actualizado == true);
                        if (query2.Count() == 0)
                        {
                            mensaje = "actualizar";
                        }
                    }
                    else
                    {
                        mensaje = "noexiste";
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return mensaje;
        }

        public List<saldoscuentas> CargarInformeBalanceAnual(List<int> cuentasid, string anio, int mes, int sucursal)
        {
            List<saldoscuentas> saldos = new List<saldoscuentas>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    foreach (int cuenta in cuentasid)
                    {
                        var query = bd.saldoscuentas.Include("maeconta").Where(sal => sal.cuenta == cuenta && sal.anio == anio && sal.idsucursal == sucursal);
                        if (query.Count() > 0)
                        {
                            foreach (var item in query.ToList())
                            {
                                saldos.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return saldos;
        }

        public string TienenMovimientoMesMsj(int mes, string anio, int sucursal)
        {
            string mensaje = string.Empty;
            List<movimi> movi = new List<movimi>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.movimi.Where(mov => mov.mes == mes && mov.anio == anio && mov.idsucursal == sucursal && mov.asientofijo == false && mov.eliminado == false);
                    if (query.Count() > 0)
                    {
                        foreach (var item in query.ToList())
                        {
                            movi.Add(item);
                        }
                    }

                    if (movi.Count() > 0)
                    {
                        var query2 = movi.Where(mov => mov.actualizado == true);
                        if (query2.Count() == 0)
                        {
                            mensaje = "actualizar";
                        }
                    }
                    else
                    {
                        mensaje = "noexiste";
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return mensaje;
        }

        public List<saldoscuentas> CargarInformeBalanceMes(int mes, string anio, int sucursal)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.saldoscuentas.Include("maeconta").Where(sal => sal.mes == mes && sal.anio == anio && sal.idsucursal == sucursal);
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

        public string TienenMovimientoFechaCuenta(DateTime fechaini, DateTime fechafin, List<int> cuentainiid, int sucursal)
        {
            string mensaje = string.Empty;
            List<movimi> movi = new List<movimi>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    foreach (int id in cuentainiid)
                    {
                        var query = bd.movimi.Include("maeconta").AsEnumerable().Where(mov => mov.idsucursal == sucursal && mov.eliminado == false && (mov.fecha.Date >= fechaini.Date && mov.fecha.Date <= fechafin.Date) && mov.asientofijo == false && mov.cuenta == id);
                        if (query.Count() > 0)
                        {
                            foreach (var item in query.ToList())
                            {
                                movi.Add(item);
                            }
                        }
                    }
                    if (movi.Count() > 0)
                    {
                        var query2 = movi.Where(mov => mov.actualizado == true);
                        if (query2.Count() == 0)
                        {
                            mensaje = "actualizar";
                        }
                    }
                    else
                    {
                        mensaje = "noexiste";
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return mensaje;
        }

        public List<movimi> CargarBalanceLibroAux(DateTime fechaini, DateTime fechafin, List<int> cuentasid, int sucursal, bool actual)
        {
            List<movimi> saldos = new List<movimi>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    foreach (int cuenta in cuentasid)
                    {
                        var query = bd.movimi.Include("maeconta").AsEnumerable().Where(mov => mov.idsucursal == sucursal && mov.eliminado == false && (mov.fecha.Date >= fechaini.Date && mov.fecha.Date <= fechafin.Date) && mov.asientofijo == false && mov.cuenta == cuenta && mov.actualizado == actual);
                        if (query.Count() > 0)
                        {
                            foreach (var item in query.ToList())
                            {
                                saldos.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return saldos;
        }

        public string TienenMovimientoFechaCuentaNit(DateTime fechaini, DateTime fechafin, List<int> cuentainiid, List<int> nitsid, int sucursal)
        {
            string mensaje = string.Empty;
            List<movimi> movi = new List<movimi>();
            List<movimi> movif = new List<movimi>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    foreach (int id in cuentainiid)
                    {
                        var query = bd.movimi.Include("maeconta").AsEnumerable().Where(mov => mov.idsucursal == sucursal && mov.eliminado == false && (mov.fecha.Date >= fechaini.Date && mov.fecha.Date <= fechafin.Date) && mov.asientofijo == false && mov.cuenta == id);
                        if (query.Count() > 0)
                        {
                            foreach (var item in query.ToList())
                            {
                                movi.Add(item);
                            }
                        }
                    }
                    if (movi.Count() > 0)
                    {
                        foreach (int id in nitsid)
                        {
                            var query = movi.AsEnumerable().Where(mov => mov.idsucursal == sucursal && mov.eliminado == false && mov.idnit == id);
                            if (query.Count() > 0)
                            {
                                foreach (var item in query.ToList())
                                {
                                    movif.Add(item);
                                }
                            }
                        }
                        if (movif.Count() > 0)
                        {
                            var query2 = movi.Where(mov => mov.actualizado == true);
                            if (query2.Count() == 0)
                            {
                                mensaje = "actualizar";
                            }
                        }
                        else
                        {
                            mensaje = "noexistenit";
                        }
                    }
                    else
                    {
                        mensaje = "noexiste";
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return mensaje;
        }

        public string TienenMovimientoFechaCuentaSinAct(DateTime fechaini, DateTime fechafin, List<int> cuentainiid, int sucursal)
        {
            string mensaje = string.Empty;
            List<movimi> movi = new List<movimi>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    foreach (int id in cuentainiid)
                    {
                        var query = bd.movimi.Include("maeconta").AsEnumerable().Where(mov => mov.idsucursal == sucursal && mov.eliminado == false && (mov.fecha.Date >= fechaini.Date && mov.fecha.Date <= fechafin.Date) && mov.asientofijo == false && mov.cuenta == id);
                        if (query.Count() > 0)
                        {
                            foreach (var item in query.ToList())
                            {
                                movi.Add(item);
                            }
                        }
                    }
                    if (movi.Count() > 0)
                    {
                        var query2 = movi.Where(mov => mov.actualizado == false);
                        if (query2.Count() == 0)
                        {
                            mensaje = "noexistesinact";
                        }
                    }
                    else
                    {
                        mensaje = "noexiste";
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return mensaje;
        }

        public List<movimi> CargarBalanceLibroAuxNit(DateTime fechaini, DateTime fechafin, List<int> cuentasid, List<int> nitsid, int sucursal)
        {
            List<movimi> saldos = new List<movimi>();
            List<movimi> saldosf = new List<movimi>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    foreach (int cuenta in cuentasid)
                    {
                        var query = bd.movimi.Include("maeconta").AsEnumerable().Where(mov => mov.idsucursal == sucursal && mov.eliminado == false && (mov.fecha.Date >= fechaini.Date && mov.fecha.Date <= fechafin.Date) && mov.asientofijo == false && mov.cuenta == cuenta && mov.actualizado == true);
                        if (query.Count() > 0)
                        {
                            foreach (var item in query.ToList())
                            {
                                saldos.Add(item);
                            }
                        }

                        if (saldos.Count() > 0)
                        {
                            foreach (int nit in nitsid)
                            {
                                var query2 = saldos.Where(mov => mov.idnit == nit);
                                if (query2.Count() > 0)
                                {
                                    foreach (var item in query2.ToList())
                                    {
                                        saldosf.Add(item);
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return saldosf;
        }

        public bool ExisteAsientoDesactualizar(int sucursal)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.movimi.Where(mov => mov.idsucursal == sucursal && mov.actualizado == true && mov.eliminado == false && mov.asientofijo == false);
                    if (query.Count() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ExisteAsientoenFechaAct(int desde, int hasta, int sucursal)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    /*var query = bd.movimi.AsEnumerable().Where(mov => mov.idsucursal == sucursal && mov.actualizado == true && mov.eliminado == false && mov.asientofijo == false && (mov.fecha.Date >= desde.Date && mov.fecha.Date <= hasta.Date));
                    if (query.Count() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }*/
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return true;
            }
        }

        public int DesactualizarTodosAsientos(int mesde, int meshasta, int sucursal)
        {
            int cantasientos = 0;
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query4 = bd.movimi.AsEnumerable().Where(mov => mov.idsucursal == sucursal && mov.actualizado == false && mov.eliminado == false && mov.asientofijo == false && (mov.mes >= mesde && mov.mes <= meshasta));
                    if (query4.Count() > 0)
                    {
                        string idasiento = string.Empty;
                        foreach (movimi item in query4.ToList())
                        {
                            var query = bd.saldoscuentas.Where(sal => sal.idsucursal == item.idsucursal &&
                                                  sal.cuenta == item.cuenta && sal.anio == item.anio
                                                 && sal.mes == item.mes);
                            if (query.Count() > 0)
                            {
                                query.First().saldomes = query.First().saldomes - item.valordebito - item.valorcredito;
                                query.First().debimes = query.First().debimes - item.valordebito;
                                query.First().credimes = query.First().credimes - item.valorcredito;
                            }

                            if (item.idnit != null)
                            {
                                var query1 = bd.maepagos.Where(mae => mae.idsucursal == item.idsucursal && mae.cuenta == item.cuenta
                                                            && mae.idnit == item.idnit && mae.anio == item.anio && mae.mes == item.mes);
                                if (query1.Count() > 0)
                                {
                                    query1.First().saldomes = query1.First().saldomes - item.valordebito - item.valorcredito;
                                    query1.First().debimes = query1.First().debimes - item.valordebito;
                                    query1.First().credimes = query1.First().credimes - item.valorcredito;
                                }
                            }

                            if (item.idcentro != null)
                            {
                                var query2 = bd.acucentr.Where(acu => acu.idsucursal == item.idsucursal && acu.anio == item.anio && acu.mes == item.mes
                                && acu.idcentro == item.idcentro && acu.idcuenta == item.cuenta && acu.idnit == item.idnit);
                                if (query2.Count() > 0)
                                {
                                    query2.First().saldomes = query2.First().saldomes - item.valordebito - item.valorcredito;
                                    query2.First().debimes = query2.First().debimes - item.valordebito;
                                    query2.First().credimes = query2.First().credimes - item.valorcredito;
                                }
                            }

                            if (!idasiento.Equals(item.idasiento))
                            {
                                cantasientos++;
                            }

                            idasiento = item.idasiento;
                            item.actualizado = false;
                            item.idusuarioact = null;
                            item.fechaact = null;
                            bd.SaveChanges();
                        }
                    }
                    else
                    {
                        cantasientos = 0;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return cantasientos;
        }

        public string TodosAsientosActoNo(string anio, int sucursal, bool actual)
        {
            try
            {
                using (siimnEntities bd = new siimnEntities())
                {
                    var query = bd.movimi.Where(mov => mov.anio == anio && mov.asientofijo == false && mov.eliminado == false && mov.actualizado == actual);
                    if (query.Count() > 0)
                    {
                        return query.First().fecha.ToShortDateString();
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void GenerarAsientoCierreEstado(List<int> cuentasiding, List<int> cuentasidcos, int? idutlidad, int comprob, string detalle, string anio, int sucursal, int usuario)
        {
            List<maepagos> saldos = new List<maepagos>();
            try
            {
                using (siimnEntities bd = new siimnEntities())
                {
                    foreach (var item in cuentasiding)
                    {
                        var query = bd.maepagos.Where(sal => sal.cuenta == item && sal.anio == anio && sal.idsucursal == sucursal);
                        if (query.Count() > 0)
                        {
                            var saldpa = query.GroupBy(que => que.idnit).Select(cl => new maepagos
                            {
                                anio = cl.First().anio,
                                credimes = cl.Sum(c => c.credimes),
                                idpagos = cl.First().idpagos,
                                cuenta = cl.First().cuenta,
                                debimes = cl.Sum(c => c.debimes),
                                idnit = cl.First().idnit,
                                idsucursal = cl.First().idsucursal,
                                mes = cl.First().mes,
                                saldomes = cl.Sum(c => c.saldomes)
                            }).ToList();
                            foreach (var sal in saldpa)
                            {
                                saldos.Add(sal);
                            }
                        }
                    }

                    foreach (var item in cuentasidcos)
                    {
                        var salcuentacos = bd.maepagos.Where(sal => sal.cuenta == item && sal.anio == anio && sal.idsucursal == sucursal);
                        if (salcuentacos.Count() > 0)
                        {
                            var saldpa = salcuentacos.GroupBy(que => que.idnit).Select(cl => new maepagos
                            {
                                anio = cl.First().anio,
                                credimes = cl.Sum(c => c.credimes),
                                idpagos = cl.First().idpagos,
                                cuenta = cl.First().cuenta,
                                debimes = cl.Sum(c => c.debimes),
                                idnit = cl.First().idnit,
                                idsucursal = cl.First().idsucursal,
                                mes = cl.First().mes,
                                saldomes = cl.Sum(c => c.saldomes)
                            }).ToList();
                            foreach (var sal in saldpa)
                            {
                                saldos.Add(sal);
                            }
                        }
                    }

                    decimal saldomesuti = 0;

                    foreach (var item in saldos.ToList())
                    {
                        movimi asiento = new movimi();
                        asiento.anio = anio;
                        asiento.asientofijo = false;
                        asiento.actualizado = false;
                        asiento.baseimpuesto = 0;
                        asiento.codigcomprob = comprob;
                        asiento.cuenta = item.cuenta;
                        asiento.detalle = detalle;
                        asiento.documento = "CIER12";
                        asiento.eliminado = false;
                        asiento.fecha = Convert.ToDateTime("12/30/" + anio);
                        asiento.fechagrabacion = DateTime.Now.Date;
                        asiento.idasiento = Convert.ToString(comprob) + "CIER12";
                        asiento.idnit = item.idnit;
                        asiento.idsucursal = sucursal;
                        asiento.idmoduloimprime = 7;
                        asiento.idusuario = usuario;
                        asiento.mes = item.mes;
                        asiento.valorcredito = item.saldomes > 0 ? item.saldomes * -1 : 0;
                        asiento.valordebito = item.saldomes < 0 ? item.saldomes * -1 : 0;
                        asiento.valorica = 0;
                        saldomesuti = saldomesuti + item.debimes;
                        bd.movimi.Add(asiento);
                    }

                    movimi asiecierre = new movimi();
                    asiecierre.anio = anio;
                    asiecierre.asientofijo = false;
                    asiecierre.actualizado = false;
                    asiecierre.baseimpuesto = 0;
                    asiecierre.codigcomprob = comprob;
                    asiecierre.cuenta = idutlidad ?? default(int);
                    asiecierre.detalle = detalle;
                    asiecierre.documento = "CIER12";
                    asiecierre.eliminado = false;
                    asiecierre.fecha = Convert.ToDateTime("12/30/" + anio);
                    asiecierre.fechagrabacion = DateTime.Now.Date;
                    asiecierre.idasiento = Convert.ToString(comprob) + "CIER12";
                    asiecierre.idsucursal = sucursal;
                    asiecierre.idmoduloimprime = 7;
                    asiecierre.idusuario = usuario;
                    asiecierre.mes = 12;
                    asiecierre.valorcredito = saldomesuti > 0 ? saldomesuti * -1 : 0;
                    asiecierre.valordebito = saldomesuti < 0 ? saldomesuti * -1 : 0;
                    asiecierre.valorica = 0;
                    bd.movimi.Add(asiecierre);

                    bd.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void GenerarAsientoCierreImpuestos(string anio, int sucursal, int usuario)
        {
            throw new NotImplementedException();
        }
    }
}
