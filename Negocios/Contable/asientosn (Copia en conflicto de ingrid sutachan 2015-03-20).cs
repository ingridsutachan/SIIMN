﻿// -----------------------------------------------------------------------
// <copyright file="asientosn.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Negocios.Contable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Datos.Contable;
    using Entities;
    using Entities.Types;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class asientosn
    {
        private asientosc persistencia;
        private Nitsc nitPersistencia;
        private Comprobantesn comprobantePersistencia;
        private Cuentac persistenciaCuenta;

        public asientosn()
        {
            this.persistencia = new asientosc();
            this.nitPersistencia = new Nitsc();
            this.comprobantePersistencia = new Comprobantesn();
            this.persistenciaCuenta = new Cuentac();
        }

        public bool ExisteAsiento(string documento, int codcompr)
        {
            try
            {
                return this.persistencia.ExisteAsiento(documento, codcompr);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string DevolverConsecutivo(int comprobante)
        {
            try
            {
                return this.persistencia.DevolverConsecutivo(comprobante);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<AsientoDataSourceDevuelve> DevolverAsiento(string documento, int codcompr)
        {
            List<AsientoDataSourceDevuelve> asientos = new List<AsientoDataSourceDevuelve>();
            try
            {
                var items = this.persistencia.DevolverAsiento(codcompr, documento);
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        AsientoDataSourceDevuelve asi = new AsientoDataSourceDevuelve();
                        asi.Anio = item.anio;
                        asi.Mes = item.mes;
                        asi.Fecha = item.fecha;
                        asi.Codcompr = item.codigcomprob;
                        asi.Documento = item.documento;
                        asi.Cuenta = item.maeconta.cuenta;
                        asi.Idcentro = item.idcentro;
                        asi.Nit = item.idnit != null ? item.maenits.nit : string.Empty;
                        asi.Cheque = item.referencia;
                        asi.Descripcion = item.detalle;
                        asi.Valorcredito = item.valorcredito;
                        asi.Valordebito = item.valordebito;
                        asi.Actualizado = item.actualizado;
                        asientos.Add(asi);
                    }
                }
                else
                {
                    asientos = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return asientos;
        }

        public List<AsientoDataSource> CargarAsiento(string documento)
        {
            List<AsientoDataSource> asientos = new List<AsientoDataSource>();
            try
            {
                var items = this.persistencia.CargarAsiento(documento);
                foreach (var item in items)
                {
                    AsientoDataSource asi = new AsientoDataSource();

                    asi.Fecha = item.fecha;
                    asi.Documento = item.documento;
                    asi.Codcompr = item.codigcomprob;
                    asi.Cuenta = item.maeconta.cuenta;
                    asi.Idcentro = item.idcentro;
                    //asi.idnit = item.idnit;
                    asi.Cheque = item.referencia;
                    asi.Descripcion = item.detalle;
                    asi.Valorcredito = item.valorcredito;
                    asi.Valordebito = item.valordebito;
                    asientos.Add(asi);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return asientos;
        }

        public AsientoDevolverVal GuardarAsiento(List<AsientoDataSource> asiento, bool estado)
        {
            List<movimi> lstMovimi = new List<movimi>();
            string done;
            string numeroasi;
            string idasiento;
            bool consec = this.comprobantePersistencia.EsConsecutivo(asiento[0].Codcompr);
            if (estado == false)
            {
                done = "guardar";
                if (consec)
                {
                    numeroasi = this.persistencia.DevolverConsecutivo(asiento[0].Codcompr);
                    idasiento = asiento[0].Codcompr + numeroasi;
                }
                else
                {
                    numeroasi = asiento[0].Documento;
                    idasiento = asiento[0].Codcompr + asiento[0].Documento;
                }
                if (asiento[0].AsiFijo == true)
                {
                    numeroasi = numeroasi + "fijo";
                    idasiento = idasiento + "fijo";
                }
            }
            else
            {
                numeroasi = asiento[0].Documento;
                idasiento = asiento[0].Codcompr + asiento[0].Documento;
                done = "update";
            }
            foreach (AsientoDataSource item in asiento)
            {
                movimi movimi = new movimi();
                movimi.idasiento = idasiento;
                movimi.idsucursal = item.Idcompania;
                movimi.anio = item.Anio;
                movimi.mes = item.Idmes;
                movimi.fecha = item.Fecha;
                movimi.codigcomprob = item.Codcompr;
                movimi.documento = numeroasi;
                movimi.idmoduloimprime = item.IdModuloImprime;
                if (item.IdTipoDcto != null)
                {
                    movimi.idtipodocumento = this.nitPersistencia.DevolverIdTipo(item.IdTipoDcto);
                }
                else
                {
                    movimi.idtipodocumento = null;
                }

                movimi.cuenta = this.persistenciaCuenta.DevolverId(item.Cuenta) ?? default(int);
                movimi.idcentro = item.Idcentro;
                movimi.idnit = item.IdNit;
                movimi.referencia = item.Cheque;
                movimi.detalle = item.Descripcion;
                movimi.valorcredito = item.Valorcredito;
                movimi.valordebito = item.Valordebito;
                movimi.baseimpuesto = item.BaseImpuesto;
                movimi.valorica = item.ValorIca;
                movimi.actualizado = item.Actualizado;
                movimi.idusuario = item.Usuario;
                movimi.fechagrabacion = item.Fechagraba;
                movimi.idusuarioact = item.Usuarioact;
                movimi.fechaact = item.Fechaactua;
                movimi.asientofijo = item.AsiFijo;
                if (item.Entrada != null)
                {
                    movimi.entrada = movimi.entrada;
                }
                else
                {
                    movimi.entrada = null;
                }
                lstMovimi.Add(movimi);
            }
            AsientoDevolverVal asidev = new AsientoDevolverVal();
            try
            {
                if ("guardar".Equals(done))
                {
                    asidev.Guardo = this.persistencia.GuardarAsiento(lstMovimi);
                    if (lstMovimi[0].asientofijo == false)
                    {
                        if (lstMovimi[0].actualizado)
                        {
                            asidev.Guardo = this.persistencia.ActualizarUnAsiento(lstMovimi);
                        }
                    }
                }
                else if ("update".Equals(done))
                {
                    List<movimi> movant = new List<movimi>();
                    movant = this.persistencia.UpdateUnAsiento(lstMovimi);
                    if (lstMovimi[0].actualizado)
                    {
                        this.persistencia.DesactualizarUnAsiento(movant);
                        asidev.Guardo = this.persistencia.ActualizarUnAsiento(lstMovimi);
                    }
                }
                asidev.asientoguard = numeroasi;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return asidev;
        }

        /*  public List<AsientoDataSource> CargarTodosAsientos()
          {
              List<AsientoDataSource> asientosfijo = new List<AsientoDataSource>();
              var items = this.persistencia.CargarTodosAsientos();
              string documento = string.Empty;
              foreach (var item in items)
              {
                  AsientoDataSource asi = new AsientoDataSource();
                  if (documento == item.documento)
                  {
                      asi.Documento = "";
                  }
                  else
                  {
                      documento = item.documento;
                      asi.Documento = item.documento;
                  }
                  asi.Codcompr = item.codigcomprob;
                  // asi.Cuenta = item.cuenta;
                  asi.Idcentro = item.idcentro;
                  // asi.idnit = item.idnit;
                  asi.Cheque = item.referencia;
                  asi.Descripcion = item.detalle;
                  asi.Valorcredito = item.valorcredito;
                  asi.Valordebito = item.valordebito;
                  // asi.nit = item.idnit != null ? item.maenits.nit + "-" + item.maenits.digito : null;
                  //asi.NombreCentro = item.idcentro != null ? item.centrocostos.nombrecentro : null;
                  // asi.Nombrecomprobante = item.comprobante.descripcomprob;
                  asientosfijo.Add(asi);
              }

              return asientosfijo;
          }

          public List<AsientoDataSource> CargarAsientoFijo(string documento)
          {
              List<AsientoDataSource> asientos = new List<AsientoDataSource>();
              try
              {
                  var items = this.persistencia.CargarAsientoFijo(documento);
                  foreach (var item in items)
                  {
                      AsientoDataSource asi = new AsientoDataSource();

                      asi.Fecha = item.fecha;
                      asi.Documento = item.documento;
                      asi.Codcompr = item.codigcomprob;
                      // asi.Cuenta = item.cuenta;
                      asi.Idcentro = item.idcentro;
                      //asi.idnit = item.idnit;
                      asi.Cheque = item.referencia;
                      asi.Descripcion = item.detalle;
                      asi.Valorcredito = item.valorcredito;
                      asi.Valordebito = item.valordebito;
                      //   asi.NombreCuenta = item.maeconta.nombre;
                      //  asi.nit = item.idnit != null ? item.maenits.nit + "-" + item.maenits.digito : null;
                      asientos.Add(asi);
                  }
              }
              catch (Exception ex)
              {
                  throw ex;
              }

              return asientos;
          }

                  public string DevolverNumeroAsientoFijo()
          {
              string numdoc = string.Empty;
              List<AsientoDataSource> asientos = new List<AsientoDataSource>();
              try
              {
                  var items = this.persistencia.DevolverNumeroAsientoFijo();
                  if (items.Count() > 0)
                  {
                      foreach (var item in items)
                      {
                          AsientoDataSource asi = new AsientoDataSource();
                          asi.Fecha = item.fecha;
                          asi.Documento = item.documento;
                          asi.Codcompr = item.codigcomprob;
                          // asi.Cuenta = item.cuenta;
                          asi.Idcentro = item.idcentro;
                          // asi.idnit = item.idnit;
                          asi.Cheque = item.referencia;
                          asi.Descripcion = item.detalle;
                          asi.Valorcredito = item.valorcredito;
                          asi.Valordebito = item.valordebito;
                          asientos.Add(asi);
                      }
                      numdoc = Convert.ToString(asientos.Max(asi => asi.Documento) + 1);
                  }
                  else
                  {
                      numdoc = "1";
                  }
              }
              catch (Exception ex)
              {
                  throw ex;
              }

              return numdoc;
          }

          public bool ExisteAsientoFijo(string documento)
          {
              bool result = false;
              try
              {
                  result = this.persistencia.ExisteAsientoFijo(documento);
              }
              catch (Exception ex)
              {
                  throw ex;
              }
              return result;
          }

          public int DevolverIdAsiento(string documento, int codcompr)
          {
              int idasiento = 0;
              try
              {
                  idasiento = this.persistencia.DevolverIdAsiento(documento, codcompr);
              }
              catch (Exception ex)
              {
                  throw ex;
              }

              return idasiento;

          }
  */
        /*
                public int DevolverIdAsientoCon()
                {
                    int idasi = 0;
                    try
                    {
                        idasi = this.persistencia.DevolverIdAsientoCon();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                    return idasi;
                }

                public int ActualizarTodosAsientos(DateTime fechade, DateTime fechahasta)
                {
                    int cantasiento = 0;
                    try
                    {
                        // cantasiento = this.persistencia.ActualizarTodosAsientos(fechade, fechahasta);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                    return cantasiento;
                }

                public bool ActualizarUnAsiento(int comprob, string numeroas)
                {
                    bool actualizar = false;
                    try
                    {
                        //  actualizar = this.persistencia.ActualizarUnAsiento(comprob, numeroas);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                    return actualizar;
                }

                /* public bool ExisMovimiSinAct(string anio, int mesde, int meshasta, int compro, int docde, int dochasta, bool todcom, bool toddoc)
                 {
                     bool existe = false;
                     try
                     {
                         existe = this.persistencia.ExMovimiSinAct(anio, mesde, meshasta, compro, docde, dochasta, todcom, toddoc);
                     }
                     catch (Exception ex)
                     {
                         throw ex;
                     }

                     return existe;
                 }

                 public List<AsientoDataSource> DevolverAsientoSinAct(string anio, int mesde, int meshasta, int compro, int docde, int dochasta, bool todcom, bool toddoc)
                 {
                     List<AsientoDataSource> asiento = new List<AsientoDataSource>();
                     try
                     {
                         var items = this.persistencia.DevolverAsientoSinAct(anio, mesde, meshasta, compro, docde, dochasta, todcom, toddoc);
                         foreach (var item in items)
                         {
                             AsientoDataSource asi = new AsientoDataSource();

                             asi.Fecha = item.fecha;
                             asi.anio = item.anio;
                             asi.Documento = item.documento;
                             asi.Codcompr = item.codicomp;
                             asi.Cuenta = item.cuenta;
                             asi.Idcentro = item.idcentro;
                             asi.idnit = item.idnit;
                             asi.Cheque = item.cheque;
                             asi.Descripcion = item.descrip;
                             asi.Valorcredito = item.valorcredito;
                             asi.Valordebito = item.valordebito;
                             asi.IdMovimi = item.idmovimi;
                             asi.IdAsiento = item.idasiento;
                             asi.NombreCompa = item.compania.nombrecia;
                             asi.Nombrecomprobante = item.comprobante.descomp;
                             asi.nit = item.maenits.nit + item.maenits.digito;
                             asiento.Add(asi);
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
