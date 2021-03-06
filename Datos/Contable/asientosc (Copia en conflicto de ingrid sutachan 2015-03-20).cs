﻿// -----------------------------------------------------------------------
// <copyright file="asientosc.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

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

        public bool ExisteAsiento(string documento, int codcompr)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.movimi.Where(mov => mov.documento == documento && mov.asientofijo == false && mov.codigcomprob == codcompr);
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

        public List<movimi> DevolverAsiento(int codcompr, string documento)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.movimi.Include("maenits").Include("maeconta").Where(mov => mov.documento == documento && mov.asientofijo == false && mov.codigcomprob == codcompr);
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

        public List<movimi> CargarAsiento(string documento)
        {
            List<movimi> asiento = new List<movimi>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    asiento = bd.movimi.Include("centro").Include("comprobante").Include("maeconta").Where(mov => mov.documento == documento).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return asiento;
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
            int cantidad = 0;
            string idasiento =asiento[0].idasiento;
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.movimi.Where(mov => mov.idasiento == idasiento);
                    if (query.Count() > 0)
                    {
                        asientoant = query.ToList();
                        cantidad = query.Count()-1;
                        foreach (movimi item in query.ToList())
                        {
                            item.cuenta = asiento[cantidad].cuenta;
                            item.detalle = asiento[cantidad].detalle;
                            item.idcentro = asiento[cantidad].idcentro;
                            item.idnit = asiento[cantidad].idnit;
                            item.referencia = asiento[cantidad].referencia;
                            item.valordebito = asiento[cantidad].valordebito;
                            item.valorcredito = asiento[cantidad].valorcredito;
                            item.baseimpuesto = asiento[cantidad].baseimpuesto;
                            item.valorica = asiento[cantidad].valorica;
                            item.entrada = asiento[cantidad].entrada;
                            item.idusuario = asiento[cantidad].idusuario;
                            item.fechagrabacion = asiento[cantidad].fechagrabacion;
                            item.idusuarioact = asiento[cantidad].idusuarioact;
                            item.fechaact = asiento[cantidad].fechaact;
                            cantidad--;
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

        public string DevolverConsecutivo(int codcomprobante)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.movimi.Where(mov => mov.codigcomprob == codcomprobante);
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

        public bool ActualizarUnAsiento(List<movimi> lstMovimi)
        {
            bool result = false;
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    foreach (movimi item in lstMovimi)
                    {
                        var query = bd.saldoscuentas.Where(sal => sal.idsucursal == item.idsucursal &&
                                                           sal.cuenta == item.cuenta && sal.anio == item.anio
                                                          && sal.mes == item.mes);
                        if (query.Count() > 0)
                        {
                            query.First().saldomes = query.First().saldomes + item.valordebito + item.valorcredito;
                            query.First().debimes = query.First().debimes + item.valordebito;
                            query.First().credimes = query.First().credimes + item.valorcredito;
                        }
                        else
                        {
                            saldoscuentas saldos = new saldoscuentas();
                            saldos.idsucursal = item.idsucursal;
                            saldos.cuenta = item.cuenta;
                            saldos.anio = item.anio;
                            saldos.mes = item.mes;
                            saldos.saldomes = item.valorcredito + item.valordebito;
                            saldos.debimes = item.valordebito;
                            saldos.credimes = item.valorcredito;
                            bd.saldoscuentas.Add(saldos);
                        }

                        if (item.idnit != null)
                        {
                            var query1 = bd.maepagos.Where(mae => mae.idsucursal == item.idsucursal && mae.cuenta == item.cuenta
                                                            && mae.idnit == item.idnit && mae.anio == item.anio && mae.mes == item.mes);
                            if (query1.Count() > 0)
                            {
                                query1.First().saldomes = query.First().saldomes + item.valordebito + item.valorcredito;
                                query1.First().debimes = query.First().debimes + item.valordebito;
                                query1.First().credimes = query.First().credimes + item.valorcredito;
                            }
                            else
                            {
                                maepagos pagos = new maepagos();
                                pagos.idsucursal = item.idsucursal;
                                pagos.cuenta = item.cuenta;
                                pagos.idnit = item.idnit ?? default(int);
                                pagos.anio = item.anio;
                                pagos.mes = item.mes;
                                pagos.saldomes = item.valorcredito + item.valordebito;
                                pagos.debimes = item.valordebito;
                                pagos.credimes = item.valorcredito;
                                bd.maepagos.Add(pagos);
                            }
                        }

                        if (item.idcentro != null)
                        {
                            var query2 = bd.acucentr.Where(acu => acu.idsucursal == item.idsucursal && acu.anio == item.anio && acu.mes == item.mes
                                && acu.idcentro == item.idcentro && acu.idcuenta == item.cuenta && acu.idnit == item.idnit);
                            if (query2.Count() > 0)
                            {
                                query2.First().saldomes = query.First().saldomes + item.valordebito + item.valorcredito;
                                query2.First().debimes = query.First().debimes + item.valordebito;
                                query2.First().credimes = query.First().credimes + item.valorcredito;
                            }
                            else
                            {
                                acucentr salcentro = new acucentr();
                                salcentro.idsucursal = item.idsucursal;
                                salcentro.idcuenta = item.cuenta;
                                salcentro.idnit = item.idnit ?? default(int);
                                salcentro.idcentro = item.idcentro ?? default(int);
                                salcentro.anio = item.anio;
                                salcentro.mes = item.mes;
                                salcentro.saldomes = item.valorcredito + item.valordebito;
                                salcentro.debimes = item.valordebito;
                                salcentro.credimes = item.valorcredito;
                                bd.acucentr.Add(salcentro);
                            }
                        }
                    }
                    bd.SaveChanges();
                    result = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return result;
        }

        public void DesactualizarUnAsiento(List<movimi> movant)
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
                                query1.First().saldomes = query.First().saldomes - item.valordebito - item.valorcredito;
                                query1.First().debimes = query.First().debimes - item.valordebito;
                                query1.First().credimes = query.First().credimes - item.valorcredito;
                            }
                        }

                        if (item.idcentro != null)
                        {
                            var query2 = bd.acucentr.Where(acu => acu.idsucursal == item.idsucursal && acu.anio == item.anio && acu.mes == item.mes
                                && acu.idcentro == item.idcentro && acu.idcuenta == item.cuenta && acu.idnit == item.idnit);
                            if (query2.Count() > 0)
                            {
                                query2.First().saldomes = query.First().saldomes - item.valordebito - item.valorcredito;
                                query2.First().debimes = query.First().debimes - item.valordebito;
                                query2.First().credimes = query.First().credimes - item.valorcredito;
                            }
                       }
                    }

                    bd.SaveChanges();
       
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        /*public List<movimi> CargarTodosAsientos()
        {
            List<movimi> AsiFijo = new List<movimi>();
            try
            {
                using (siimnEntities bd = new siimnEntities())
                {
                    var query = bd.movimi.Include("centro").Include("maenits").Include("maeconta").Include("comprobante").
                        Where(mov => mov.asientofijo == true).OrderBy(mov => mov.idmovimiento).ToList();
                    AsiFijo = query;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return AsiFijo;
        }

        public List<movimi> CargarAsientoFijo(string documento)
        {
            List<movimi> asiento = new List<movimi>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    asiento = bd.movimi.Include("centro").Include("comprobante").Include("maeconta").Include("maenits").Where(mov => mov.documento == documento && mov.asientofijo == true).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return asiento;
        }

        public List<movimi> DevolverNumeroAsientoFijo()
        {
            List<movimi> asientos = new List<movimi>();
            using (siimnEntities bd = new siimnEntities())
            {
                var query1 = bd.movimi.Where(mov => mov.asientofijo == true).Count();
                if (query1 > 0)
                {
                    asientos = bd.movimi.Where(mov => mov.asientofijo == true).ToList();
                }
            }

            return asientos;
        }

        public bool ExisteAsientoFijo(string documento)
        {
            bool result = false;
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.movimi.Where(mov => mov.documento == documento && mov.asientofijo == true).Count();
                result = query > 0 ? true : false;
            }

            return result;
        }

        public int DevolverIdAsiento(string documento, int codcompr)
        {
            int idasiento = 1;
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.movimi.Where(mov => mov.documento == documento && mov.codigcomprob == codcompr).First();
                // idasiento = query.idasiento;
            }

            return idasiento;
        }

        public int DevolverIdAsientoCon()
        {
            int idasi = 0;
            using (siimnEntities bd = new siimnEntities())
            {
                // idasi = bd.movimi.ToList().Max(mov => mov.idasiento);
            }

            return idasi;
        }

        /*  public List<mes> CargarMeses()
          {
              List<mes> meses = new List<mes>();
              using (siimnEntities bd = new siimnEntities())
              {
                  meses = bd.mes.ToList();
              }

              return meses;
          }*/

        /*  public int ActualizarTodosAsientos(DateTime fechade, DateTime fechahasta)
          {
             /* int cantasientos = 0;
              using (siimnEntities bd = new siimnEntities())
              {
                  try
                  {
                      var items = bd.movimi.Where(mov => mov.actualizado == false && (mov.fecha.Year >= fechade.Year && mov.fecha.Month >= fechade.Month && mov.fecha.Day >=
                          fechade.Day && mov.fecha.Year <= fechahasta.Year && mov.fecha.Month <= fechahasta.Month && mov.fecha.Day <= fechahasta.Day)).ToList();
                      foreach (var item in items)
                      {
                          saldoscuentas saldos = new saldoscuentas();
                          var query = bd.saldoscuentas.Where(sal => sal.cuenta == item.cuenta && sal.anio.Equals(item.anio) && sal.mes == item.mes).Count();
                          if (query > 0)
                          {
                              var query1 = bd.saldoscuentas.Where(sal => sal.cuenta == item.cuenta && sal.anio.Equals(item.anio) && sal.mes == item.mes).First();
                              query1.saldocuenta = item.valordebito + item.valorcredito;
                              bd.SaveChanges();
                          }
                          else
                          {
                              saldos.cuenta = item.cuenta;
                              saldos.anio = short.Parse(item.anio);
                              saldos.mes = item.mes;
                              saldos.saldocuenta = item.valordebito + item.valorcredito;
                              bd.saldoscuentas.Add(saldos);
                              bd.SaveChanges();
                          }

                          cantasientos++;
                          item.actualizado = true;
                      }
                  }
                  catch (Exception ex)
                  {
                      throw ex;
                  }
              }

              return cantasientos;
          }*/

        /*public bool ExMovimiSinAct(short anio, int mesde, int meshasta, int compro, int docde, int dochasta, bool todcom, bool toddoc)
 {
     bool existe = false;
     try
     {
         using (siimnEntities bd = new siimnEntities())
         {
             int cant = 0;
             if (todcom == false && toddoc == false)
             {
                 cant = bd.movimi.Where(mov => mov.anio == anio && mov.mes >= mesde && mov.mes <= meshasta
                          && mov.codigcomprob == compro && mov.documento >= docde && mov.documento <= dochasta && mov.actualizado == false).Count();
             }
             else if (todcom == true && toddoc == false)
             {
                 cant = bd.movimi.Where(mov => mov.anio == anio && mov.idmes >= mesde && mov.idmes <= meshasta
                         && mov.documento >= docde && mov.documento <= dochasta && mov.actualizado == false).Count();
             }
             else if (todcom == false && toddoc == true)
             {
                 cant = bd.movimi.Where(mov => mov.anio == anio && mov.idmes >= mesde && mov.idmes <= meshasta
                         && mov.codicomp == compro && mov.actualizado == false).Count();
             }
             else if (todcom == true && toddoc == true)
             {
                 cant = bd.movimi.Where(mov => mov.anio == anio && mov.idmes >= mesde && mov.idmes <= meshasta && mov.actualizado == false).Count();
             }

             if (cant > 0)
             {
                 existe = true;
             }

         }
     }
     catch (Exception ex)
     {
         throw ex;
     }
            
     return existe;
 }*/

        /* public List<movimi> DevolverAsientoSinAct(string anio, int mesde, int meshasta, int compro, int docde, int dochasta, bool todcom, bool toddoc)
         {
             List<movimi> asiento = new List<movimi>();
             try
             {
                 using (siimnEntities bd = new siimnEntities())
                 {
                     if (todcom == false && toddoc == false)
                     {
                         asiento = bd.movimi.Include("compania").Include("comprobante").Include("maenits").Where(mov => mov.anio == anio && mov.idmes >= mesde && mov.idmes <= meshasta
                                  && mov.codicomp == compro && mov.documento >= docde && mov.documento <= dochasta && mov.actualizado == false).ToList();
                     }
                     else if (todcom == true && toddoc == false)
                     {
                         asiento = bd.movimi.Include("compania").Include("comprobante").Include("maenits").Where(mov => mov.anio == anio && mov.idmes >= mesde && mov.idmes <= meshasta
                                 && mov.documento >= docde && mov.documento <= dochasta && mov.actualizado == false).ToList();
                     }
                     else if (todcom == false && toddoc == true)
                     {
                         asiento = bd.movimi.Include("compania").Include("comprobante").Include("maenits").Where(mov => mov.anio == anio && mov.idmes >= mesde && mov.idmes <= meshasta
                                 && mov.codicomp == compro && mov.actualizado == false).ToList();
                     }
                     else if (todcom == true && toddoc == true)
                     {
                         asiento = bd.movimi.Include("compania").Include("comprobante").Include("maenits").Where(mov => mov.anio == anio && mov.idmes >= mesde && mov.idmes <= meshasta && mov.actualizado == false).ToList();
                     }
                 }
             }
             catch (Exception ex)
             {
                 throw ex;
             }

             return asiento;
         }*/

    }
}
