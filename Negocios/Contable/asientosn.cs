﻿////*********************************************************
//
//    <copyright file="asientosn.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 30 Marzo 2015
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
    using Entities;
    using Entities.Types;
    using Datos.General;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class asientosn
    {
        private asientosc persistencia;
        private Nitsc persistenciaNit;
        private Comprobantesn comprobantePersistencia;
        private Cuentac persistenciaCuenta;
        private Parametrosc persistenciaParametro;


        public asientosn()
        {
            this.persistencia = new asientosc();
            this.persistenciaNit = new Nitsc();
            this.comprobantePersistencia = new Comprobantesn();
            this.persistenciaCuenta = new Cuentac();
            this.persistenciaParametro = new Parametrosc();
        }

        public bool ExisteAsiento(string documento, int codcompr, int sucursal)
        {
            try
            {
                return this.persistencia.ExisteAsiento(documento, codcompr, sucursal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string DevolverConsecutivo(int comprobante, int sucursal)
        {
            try
            {
                return this.persistencia.DevolverConsecutivo(comprobante, sucursal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<AsientoDataSourceDevuelve> DevolverAsiento(string documento, int codcompr, int sucursal)
        {
            List<AsientoDataSourceDevuelve> asientos = new List<AsientoDataSourceDevuelve>();
            try
            {
                var items = this.persistencia.DevolverAsiento(codcompr, documento, "pru", sucursal, false);
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

        public AsientoDevolverVal GuardarAsiento(List<AsientoDataSource> asiento, string estado)
        {
            List<movimi> lstMovimi = new List<movimi>();
            string done = string.Empty;
            string numeroasi = string.Empty;
            string idasiento = string.Empty;
            bool consec = this.comprobantePersistencia.EsConsecutivo(asiento[0].Codcompr);
            if (estado.Equals("0"))
            {
                done = "guardar";
                if (consec)
                {
                    numeroasi = this.persistencia.DevolverConsecutivo(asiento[0].Codcompr, asiento[0].Idcompania);
                    idasiento = asiento[0].Codcompr + numeroasi;
                }
                else
                {
                    numeroasi = asiento[0].Documento;
                    idasiento = asiento[0].Codcompr + asiento[0].Documento;
                }
                if (asiento[0].AsiFijo == true)
                {
                    numeroasi = numeroasi + " FIJO";
                    idasiento = idasiento + " FIJO";
                }
            }
            else if (estado.Equals("1"))
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
                    movimi.idtipodocumento = this.persistenciaNit.DevolverIdTipo(item.IdTipoDcto);
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
                            int cant = this.persistencia.ActualizarUnAsiento(lstMovimi);
                            asidev.Guardo = cant > 0 ? true : false;
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
                        int cant = this.persistencia.ActualizarUnAsiento(lstMovimi);
                        asidev.Guardo = cant > 0 ? true : false;
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


        public List<AsientoDataSourceFijo> BusquedaFijo(string tipo, string buscar, int comprobante, int sucursal)
        {
            List<AsientoDataSourceFijo> asientodev = new List<AsientoDataSourceFijo>();
            try
            {
                var items = this.persistencia.BusquedaFijo(tipo, buscar, comprobante, sucursal);
                if (items != null)
                {
                    if (comprobante != 0)
                    {
                        foreach (var item in items)
                        {
                            AsientoDataSourceFijo ds = new AsientoDataSourceFijo();
                            ds.NumeroAsiento = item.idasiento.Replace("FIJO", string.Empty);
                            ds.Cuenta = item.maeconta.cuenta;
                            ds.Idcentro = item.idcentro;
                            ds.Nit = item.idnit != null ? item.maenits.nit : null;
                            ds.Cheque = item.referencia;
                            ds.Descripcion = item.detalle;
                            asientodev.Add(ds);
                        }
                    }
                    else
                    {
                        string asiento = string.Empty;
                        foreach (var item in items)
                        {
                            AsientoDataSourceFijo ds = new AsientoDataSourceFijo();
                            ds.NumeroAsiento = item.idasiento.Replace("FIJO", string.Empty);
                            ds.Cuenta = item.maeconta.cuenta;
                            ds.Idcentro = item.idcentro;
                            ds.Nit = item.idnit != null ? item.maenits.nit : null;
                            ds.Cheque = item.referencia;
                            ds.Descripcion = item.detalle;
                            if (!asiento.Equals(ds.NumeroAsiento))
                            {
                                asientodev.Add(ds);
                            }
                            asiento = ds.NumeroAsiento;
                        }
                    }
                }
                else
                {
                    asientodev = this.AsientoNull();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return asientodev;
        }

        private List<AsientoDataSourceFijo> AsientoNull()
        {
            List<AsientoDataSourceFijo> asientodev = new List<AsientoDataSourceFijo>();
            AsientoDataSourceFijo ds = new AsientoDataSourceFijo();
            ds.NumeroAsiento = null;
            ds.Cuenta = null;
            ds.Idcentro = null;
            ds.Nit = null;
            ds.Cheque = null;
            ds.Descripcion = null;
            asientodev.Add(ds);
            return asientodev;
        }

        public List<AsientoDataSourceFijo> CargarAsientoFijo(string documento, int sucursal)
        {
            List<AsientoDataSourceFijo> asientodev = new List<AsientoDataSourceFijo>();
            try
            {
                var items = this.persistencia.CargarAsientoFijo(documento + "FIJO", sucursal);
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        AsientoDataSourceFijo ds = new AsientoDataSourceFijo();
                        ds.NumeroAsiento = item.idasiento.Replace("FIJO", string.Empty);
                        ds.Cuenta = item.maeconta.cuenta;
                        ds.Idcentro = item.idcentro;
                        ds.Nit = item.idnit != null ? item.maenits.nit : null;
                        ds.Cheque = item.referencia;
                        ds.Descripcion = item.detalle;
                        ds.ValorDebito = item.valordebito;
                        ds.ValorCredito = item.valorcredito;
                        asientodev.Add(ds);
                    }
                }
                else
                {

                    asientodev = this.AsientoNull();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return asientodev;
        }

        public List<AsientoDataSourceView> Busqueda(string tipo, string buscar, int sucursal)
        {
            List<movimi> items = new List<movimi>();
            List<AsientoDataSourceView> asientodev = new List<AsientoDataSourceView>();
            try
            {
                string actlinea = this.persistenciaParametro.ActualizarEnLinea();
                if ("1".Equals(actlinea))
                {
                    items = this.persistencia.Busqueda(tipo, buscar, true, sucursal);
                }
                else
                {
                    items = this.persistencia.Busqueda(tipo, buscar, false, sucursal);
                }

                if (items != null)
                {
                    string compro = string.Empty;
                    string docum = string.Empty;
                    foreach (var item in items)
                    {
                        AsientoDataSourceView ds = new AsientoDataSourceView();
                        ds.Anio = item.anio;
                        ds.Mes = Convert.ToString(item.mes);
                        ds.Comprobante = Convert.ToString(item.codigcomprob);
                        ds.Fecha = item.fecha.ToShortDateString();
                        ds.Documento = item.documento;
                        ds.Detalle = item.detalle;
                        if (!ds.Comprobante.Equals(compro) || !ds.Documento.Equals(docum))
                        {
                            asientodev.Add(ds);
                        }
                        compro = ds.Comprobante;
                        docum = ds.Documento;
                    }
                }
                else
                {
                    AsientoDataSourceView ds = new AsientoDataSourceView();
                    ds.Anio = null;
                    ds.Mes = null;
                    ds.Fecha = null;
                    ds.Comprobante = null;
                    ds.Documento = null;
                    ds.Detalle = null;
                    asientodev.Add(ds);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return asientodev;
        }


        public bool EliminarAsiento(string idasiento, bool asientofijo, int sucursal)
        {
            bool elimina = false;
            List<movimi> asientodev = new List<movimi>();
            try
            {
                if (asientofijo == true)
                {
                    idasiento = idasiento + "FIJO";
                }
                else
                {
                    asientodev = this.persistencia.DevolverAsientoXId(idasiento, sucursal);
                }
                elimina = this.persistencia.EliminarAsiento(idasiento, asientofijo, sucursal);
                if (asientofijo == false)
                {
                    this.persistencia.DesactualizarUnAsiento(asientodev);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return elimina;
        }

        public bool ActualizarAsientoGeneral(List<AsientoDataSource> asientos, string idasiento, int sucursal)
        {
            List<movimi> lstMovimi = new List<movimi>();
            foreach (AsientoDataSource item in asientos)
            {
                movimi movimi = new movimi();
                movimi.idasiento = item.Codcompr + item.Documento;
                movimi.anio = item.Anio;
                movimi.mes = item.Idmes;
                movimi.fecha = item.Fecha;
                movimi.codigcomprob = item.Codcompr;
                movimi.documento = item.Documento;
                lstMovimi.Add(movimi);
            }
            try
            {
                return this.persistencia.ActualizarAsientoGeneral(lstMovimi, idasiento, sucursal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<AsientoDataSourceShow> CargarInforme(string tipo, int sucursal)
        {
            List<AsientoDataSourceShow> asiento = new List<AsientoDataSourceShow>();
            try
            {
                var items = this.persistencia.CargarInforme(tipo, sucursal);
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        AsientoDataSourceShow asi = new AsientoDataSourceShow();
                        asi.IdAsiento = item.idasiento;
                        asi.Fecha = item.fecha.ToShortDateString();
                        asi.Comproban = Convert.ToString(item.codigcomprob) + " - " + item.comprobante.descripcomprob;
                        asi.Documento = item.documento;
                        asi.Cuenta = item.maeconta.cuenta;
                        asi.Idcentro = item.idcentro;
                        asi.IdNit = item.idnit != null ? item.maenits.nit : string.Empty;
                        asi.Descripcion = item.detalle;
                        asi.Cheque = item.referencia;
                        asi.Valordebito = item.valordebito;
                        asi.Valorcredito = item.valorcredito;
                        asiento.Add(asi);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return asiento;
        }

        public int ActualizarTodosAsientos(DateTime desde, DateTime hasta, int sucursal, int usuarioact)
        {
            try
            {
                return this.persistencia.ActualizarTodosAsientos(desde, hasta, sucursal, usuarioact);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ActualizarUnAsiento(int compro, string asiento, string anio, int sucursal)
        {
            List<movimi> asientoact = new List<movimi>();
            try
            {
                asientoact = this.persistencia.DevolverAsiento(compro, asiento, anio, sucursal, false);
                if (asientoact != null)
                {
                    return this.persistencia.ActualizarUnAsiento(asientoact);
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

        public bool ExisteAsientoActualizar(int sucursal)
        {
            try
            {
                return this.persistencia.ExisteAsientoActualizar(sucursal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ExisteAsientoenFecha(DateTime desde, DateTime hasta, int sucursal)
        {
            List<AsientoDataSourceAct> asientos = new List<AsientoDataSourceAct>();
            try
            {
                return this.persistencia.ExisteAsientoenFecha(desde, hasta, sucursal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool AsientoYaActualizado(string numeroasiento, int codcompro, int sucursal)
        {
            try
            {
                return this.persistencia.AsientoYaActualizado(numeroasiento, codcompro, sucursal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<AsientoDataSourceShow> CargarInformeSinActualizar(string anio, int mes, string comprob, string docin, string docfin, int sucursal)
        {
            List<AsientoDataSourceShow> asiento = new List<AsientoDataSourceShow>();
            try
            {
                var items = this.persistencia.CargarInformeSinActualizar(anio, mes, comprob, docin, docfin, sucursal);
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        AsientoDataSourceShow asi = new AsientoDataSourceShow();
                        asi.IdAsiento = item.idasiento;
                        asi.Fecha = item.fecha.ToShortDateString();
                        asi.Comproban = Convert.ToString(item.codigcomprob) + " - " + item.comprobante.descripcomprob;
                        asi.Documento = item.documento;
                        asi.Cuenta = item.maeconta.cuenta;
                        asi.Idcentro = item.idcentro;
                        asi.IdNit = item.idnit != null ? item.maenits.nit : string.Empty;
                        asi.Descripcion = item.detalle;
                        asi.Cheque = item.referencia;
                        asi.Valordebito = item.valordebito;
                        asi.Valorcredito = item.valorcredito;
                        asiento.Add(asi);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return asiento;
        }


        public bool TienenMovimiento(string anio, int mes, string comprob, string docin, string docfin, int sucursal)
        {
            try
            {
                return this.persistencia.TienenMovimiento(anio, mes, comprob, docin, docfin, sucursal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<AsientoDataSourceDevuelve> TienenMovimientoSinAnio(int mesdesde, int meshasta, string anio, string comprob, string docin, string docfin, int sucursal)
        {
            List<AsientoDataSourceDevuelve> asiento = new List<AsientoDataSourceDevuelve>();
            try
            {
                var items = this.persistencia.TienenMovimientoSinAnio(mesdesde, meshasta, anio, comprob, docin, docfin, sucursal);
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        AsientoDataSourceDevuelve asi = new AsientoDataSourceDevuelve();
                        asi.Codcompr = item.codigcomprob;
                        asi.Documento = item.documento;
                        asi.Actualizado = item.actualizado;
                        asiento.Add(asi);
                    }
                }
                else
                {
                    asiento = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return asiento;
        }

        public List<AsientoDataSourceDevuelve> TienenMovimientoMes(int mes, string anio, int sucursal)
        {
            List<AsientoDataSourceDevuelve> asientod = new List<AsientoDataSourceDevuelve>();
            try
            {
                var items = this.persistencia.TienenMovimientoMes(mes, anio, sucursal);
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        AsientoDataSourceDevuelve asi = new AsientoDataSourceDevuelve();
                        asi.Codcompr = item.codigcomprob;
                        asi.Documento = item.documento;
                        asi.Actualizado = item.actualizado;
                        asientod.Add(asi);
                    }
                }
                else
                {
                    asientod = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return asientod;
        }

        public List<AsientoDataSourceShow> CargarInformeLibroDiario(int mesdesde, int meshasta, string anio, string comprob, string docin, string docfin, int sucursal)
        {
            List<AsientoDataSourceShow> asiento = new List<AsientoDataSourceShow>();
            try
            {
                var items = this.persistencia.CargarInformeLibroDiario(mesdesde, meshasta, anio, comprob, docin, docfin, sucursal);
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        AsientoDataSourceShow asi = new AsientoDataSourceShow();
                        asi.IdAsiento = item.idasiento;
                        asi.Fecha = item.fecha.ToShortDateString();
                        asi.Comproban = Convert.ToString(item.codigcomprob) + " - " + item.comprobante.descripcomprob;
                        asi.Documento = item.documento;
                        asi.Cuenta = item.maeconta.cuenta;
                        asi.Idcentro = item.idcentro;
                        asi.IdNit = item.idnit != null ? item.maenits.nit : string.Empty;
                        asi.Descripcion = item.detalle;
                        asi.Cheque = item.referencia;
                        asi.Valordebito = item.valordebito;
                        asi.Valorcredito = item.valorcredito;
                        asiento.Add(asi);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return asiento;
        }

        public List<AsientoDataSourceShow> CargarInformeLibroResumido(int mes, string anio, int sucursal)
        {
            List<AsientoDataSourceShow> asiento = new List<AsientoDataSourceShow>();
            try
            {
                var items = this.persistencia.CargarInformeLibroResumido(mes, anio, sucursal);
                if (items != null)
                {
                    int codgcomp = 0;
                    int cuenta = 0;
                    foreach (var item in items)
                    {
                        if (codgcomp != item.codigcomprob || cuenta != item.cuenta)
                        {
                            AsientoDataSourceShow asi = new AsientoDataSourceShow();
                            asi.IdAsiento = item.idasiento;
                            asi.Fecha = item.fecha.ToShortDateString();
                            asi.Comproban = Convert.ToString(item.codigcomprob) + " - " + item.comprobante.descripcomprob;
                            asi.Documento = item.documento;
                            asi.Cuenta = item.maeconta.cuenta + " - " + item.maeconta.nombre;
                            asi.Idcentro = item.idcentro;
                            asi.IdNit = item.idnit != null ? item.maenits.nit : string.Empty;
                            asi.Descripcion = item.detalle;
                            asi.Cheque = item.referencia;
                            asi.Valordebito = asi.Valordebito + item.valordebito;
                            asi.Valorcredito = asi.Valorcredito + item.valorcredito;
                            asiento.Add(asi);
                            codgcomp = item.codigcomprob;
                            cuenta = item.cuenta;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return asiento;
        }

        public bool TienenMovimientoSinAct(List<AsientoDataSourceDevuelve> asientodev)
        {
            List<movimi> asiento = new List<movimi>();
            try
            {
                foreach (AsientoDataSourceDevuelve item in asientodev)
                {
                    movimi asi = new movimi();
                    asi.codigcomprob = item.Codcompr;
                    asi.documento = item.Documento;
                    asi.actualizado = item.Actualizado;
                    asiento.Add(asi);
                }

                return this.persistencia.TienenMovimientoSinAnioSinAct(asiento);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public string TieneMovimientoCuentas(int mes, string anio, string cuentaini, string cuentafin, int sucursal)
        {
            try
            {
                List<int> cuentainiid = new List<int>();
                if (!cuentaini.Equals("**"))
                {
                    cuentainiid = this.persistenciaCuenta.DevolverIdsEntre(cuentaini, cuentafin);
                }
                else
                {
                    cuentainiid = this.persistenciaCuenta.DevolverTodosIds();
                }

                if (cuentainiid != null)
                {
                    return this.persistencia.TienenMovimientoCuentas(mes, anio, cuentainiid, sucursal);

                }
                else
                {
                    return "nocuentas";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SaldosCuentasDataSource> CargarBalanceMes(int mes, string anio, string cuentaini, string cuentafin, int sucursal)
        {
            List<SaldosCuentasDataSource> balan = new List<SaldosCuentasDataSource>();
            try
            {
                List<int> cuentaid = new List<int>();
                if (!cuentaini.Equals("**"))
                {
                    cuentaid = this.persistenciaCuenta.DevolverIdsEntre(cuentaini, cuentafin);
                }
                else
                {
                    cuentaid = this.persistenciaCuenta.DevolverTodosIds();
                }

                if (cuentaid != null)
                {
                    var items = this.persistencia.CargarBalanceMes(mes, anio, cuentaid, sucursal);
                    if (items != null)
                    {
                        int cuenta = 0;
                        foreach (var item in items)
                        {
                            decimal SaldoAnterior = this.persistencia.SaldoCuentaAnterior(item.cuenta, item.mes, item.anio, item.idsucursal);
                            if (cuenta != item.cuenta)
                            {
                                SaldosCuentasDataSource sal = new SaldosCuentasDataSource();
                                sal.IdCuenta = item.cuenta;
                                sal.SaldoAnterior = SaldoAnterior;
                                sal.Sucursal = item.idsucursal;
                                sal.Anio = item.anio;
                                sal.Cuenta = item.maeconta.cuenta;
                                sal.Mes = item.mes;
                                sal.NombreCuenta = item.maeconta.nombre;
                                sal.SaldoActual = item.saldomes;
                                sal.ValorCredito = item.credimes;
                                sal.ValorDebito = item.debimes;
                                balan.Add(sal);
                            }
                            else
                            {
                                foreach (var itbal in balan)
                                {
                                    if (itbal.IdCuenta == item.cuenta)
                                    {
                                        itbal.SaldoAnterior = itbal.SaldoAnterior + SaldoAnterior;
                                        itbal.ValorDebito = itbal.ValorDebito + item.debimes;
                                        itbal.ValorCredito = itbal.ValorCredito + item.credimes;
                                        itbal.SaldoActual = itbal.SaldoActual + item.saldomes;
                                    }
                                }
                            }
                            cuenta = item.cuenta;
                        }
                    }
                    else
                    {
                        balan = null;
                    }
                }
                else
                {
                    balan = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return balan;
        }

        public List<SaldosNitsDataSource> SaldosNits(string cuenta, string anio, int mes, int sucursal)
        {
            List<SaldosNitsDataSource> nitsaldos = new List<SaldosNitsDataSource>();
            try
            {
                int? idcuenta = this.persistenciaCuenta.DevolverId(cuenta);
                var items = this.persistencia.SaldosNits(idcuenta, anio, mes, sucursal);
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        SaldosNitsDataSource nits = new SaldosNitsDataSource();
                        nits.SaldoAnterioMes = this.persistencia.SaldoNitAnterior(item.idnit, item.cuenta, item.mes, item.anio, item.idsucursal);
                        nits.Cuenta = item.maeconta.cuenta;
                        nits.Nit = item.maenits.nit;
                        nits.Digito = item.maenits.digito;
                        nits.Nombrenit = item.maenits.nombrenit;
                        nits.DebitoNit = item.debimes;
                        nits.CreditoNit = item.credimes;
                        nits.SaldoNit = item.saldomes;
                        nitsaldos.Add(nits);
                    }
                }
                else
                {
                    nitsaldos = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return nitsaldos;
        }

        public string TienenMovimientoAnual(string cuentaini, string cuentafin, string anio, int sucursal)
        {
            try
            {
                List<int> cuentasid = new List<int>();
                if (!cuentaini.Equals("**"))
                {
                    cuentasid = this.persistenciaCuenta.DevolverIdsEntre(cuentaini, cuentafin);
                }
                else
                {
                    cuentasid = this.persistenciaCuenta.DevolverTodosIds();
                }
                return this.persistencia.TienenMovimientoAnual(cuentasid, anio, sucursal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SaldoAnualDataSource> CargarInformeBalanceAnual(string cuentaini, string cuentafin, string anio, int mes, int sucursal)
        {
            List<SaldoAnualDataSource> saldos = new List<SaldoAnualDataSource>();
            try
            {
                List<int> cuentasid = new List<int>();
                if (!cuentaini.Equals("**"))
                {
                    cuentasid = this.persistenciaCuenta.DevolverIdsEntre(cuentaini, cuentafin);
                }
                else
                {
                    cuentasid = this.persistenciaCuenta.DevolverTodosIds();
                }

                var items = this.persistencia.CargarInformeBalanceAnual(cuentasid, anio, mes, sucursal);
                if (items != null)
                {
                    string cuenta = string.Empty;
                    string nombrecuenta = string.Empty;
                    decimal? enero = null, febrero = null, marzo = null, abril = null, mayo = null, junio = null, julio = null, agosto = null, septiembre = null, octubre = null, noviembre = null, diciembre = null;
                    foreach (var item in items)
                    {
                        SaldoAnualDataSource sald = new SaldoAnualDataSource();

                        if (item.mes == 1)
                        {
                            enero = item.saldomes;
                        }
                        else if (item.mes == 2)
                        {
                            febrero = item.saldomes;
                        }
                        else if (item.mes == 3)
                        {
                            marzo = item.saldomes;
                        }
                        else if (item.mes == 4)
                        {
                            abril = item.saldomes;
                        }
                        else if (item.mes == 5)
                        {
                            mayo = item.saldomes;
                        }
                        else if (item.mes == 6)
                        {
                            junio = item.saldomes;
                        }
                        else if (item.mes == 7)
                        {
                            julio = item.saldomes;
                        }
                        else if (item.mes == 8)
                        {
                            agosto = item.saldomes;
                        }
                        else if (item.mes == 9)
                        {
                            septiembre = item.saldomes;
                        }
                        else if (item.mes == 10)
                        {
                            octubre = item.saldomes;
                        }
                        else if (item.mes == 11)
                        {
                            noviembre = item.saldomes;
                        }
                        else if (item.mes == 12)
                        {
                            diciembre = item.saldomes;
                        }

                        if (diciembre != null)
                        {
                            sald.Cuenta = cuenta;
                            sald.NombreCuenta = nombrecuenta;
                            sald.SaldoEnero = enero ?? default(int);
                            sald.SaldoFebrero = febrero ?? default(int);
                            sald.SaldoMarzo = marzo ?? default(int);
                            sald.SaldoAbril = abril ?? default(int);
                            sald.SaldoMayo = mayo ?? default(int);
                            sald.SaldoJunio = junio ?? default(int);
                            sald.SaldoJulio = julio ?? default(int);
                            sald.SaldoAgosto = agosto ?? default(int);
                            sald.SaldoSeptiembre = septiembre ?? default(int);
                            sald.SaldoOctubre = octubre ?? default(int);
                            sald.SaldoNoviembre = noviembre ?? default(int);
                            sald.SaldoDiciembre = diciembre ?? default(int);
                            enero = null;
                            febrero = null;
                            marzo = null;
                            abril = null;
                            mayo = null;
                            junio = null;
                            julio = null;
                            agosto = null;
                            septiembre = null;
                            octubre = null;
                            noviembre = null;
                            diciembre = null;
                            saldos.Add(sald);
                        }

                        cuenta = item.maeconta.cuenta;
                        nombrecuenta = item.maeconta.nombre;
                    }
                }
                else
                {
                    saldos = null;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return saldos;
        }

        public string TienenMovimientoMesMsj(int mes, string anio, int sucursal)
        {
            try
            {
                return this.persistencia.TienenMovimientoMesMsj(mes, anio, sucursal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SaldosCuentasDataSource> CargarInformeBalanceMes(int mes, string anio, int sucursal)
        {
            List<SaldosCuentasDataSource> balan = new List<SaldosCuentasDataSource>();
            try
            {
                var items = this.persistencia.CargarInformeBalanceMes(mes, anio, sucursal);
                if (items != null)
                {
                    int cuenta = 0;
                    foreach (var item in items)
                    {
                        if (cuenta != item.cuenta)
                        {
                            SaldosCuentasDataSource sal = new SaldosCuentasDataSource();
                            sal.IdCuenta = item.cuenta;
                            sal.Sucursal = item.idsucursal;
                            sal.Anio = item.anio;
                            sal.Cuenta = item.maeconta.cuenta;
                            sal.Mes = item.mes;
                            sal.NombreCuenta = item.maeconta.nombre;
                            sal.SaldoActual = item.saldomes;
                            balan.Add(sal);
                        }
                        else
                        {
                            foreach (var itbal in balan)
                            {
                                if (itbal.IdCuenta == item.cuenta)
                                {
                                    itbal.SaldoActual = itbal.SaldoActual + item.saldomes;
                                }
                            }
                        }

                        cuenta = item.cuenta;
                    }
                }
                else
                {
                    balan = null;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return balan;
        }

        public List<SaldosCuentasDataSource> CargarLibroMayor(int mes, string anio, int sucursal)
        {
            List<SaldosCuentasDataSource> balan = new List<SaldosCuentasDataSource>();
            try
            {

                var items = this.persistencia.CargarInformeBalanceMes(mes, anio, sucursal);
                if (items != null)
                {
                    string cuenta = string.Empty;
                    foreach (var item in items)
                    {
                        decimal SaldoAnterior = this.persistencia.SaldoCuentaAnterior(item.cuenta, item.mes, item.anio, item.idsucursal);
                        if (cuenta != item.maeconta.cuenta.Substring(0, 4))
                        {
                            SaldosCuentasDataSource sal = new SaldosCuentasDataSource();
                            sal.SaldoAnterior = SaldoAnterior;
                            sal.Sucursal = item.idsucursal;
                            sal.Anio = item.anio;
                            sal.Cuenta = item.maeconta.cuenta.Substring(0, 4);
                            sal.Mes = item.mes;
                            sal.NombreCuenta = this.persistenciaCuenta.DevolverNombre(item.maeconta.cuenta.Substring(0, 4));
                            sal.SaldoActual = item.saldomes;
                            sal.ValorCredito = item.credimes;
                            sal.ValorDebito = item.debimes;
                            balan.Add(sal);
                        }
                        else
                        {
                            foreach (var itbal in balan)
                            {
                                if (itbal.Cuenta.Substring(0, 4) == item.maeconta.cuenta.Substring(0, 4))
                                {
                                    itbal.SaldoAnterior = itbal.SaldoAnterior + SaldoAnterior;
                                    itbal.ValorDebito = itbal.ValorDebito + item.debimes;
                                    itbal.ValorCredito = itbal.ValorCredito + item.credimes;
                                    itbal.SaldoActual = itbal.SaldoActual + item.saldomes;
                                }
                            }
                        }
                        cuenta = item.maeconta.cuenta.Substring(0, 4);
                    }
                }
                else
                {
                    balan = null;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return balan;
        }

        public List<SaldosCuentasDataSource> CargarLibroMayorGrupo(int mes, string anio, int sucursal)
        {
            List<SaldosCuentasDataSource> balan = new List<SaldosCuentasDataSource>();
            try
            {
                var items = this.persistencia.CargarInformeBalanceMes(mes, anio, sucursal);
                if (items != null)
                {
                    string cuenta = string.Empty;
                    foreach (var item in items)
                    {
                        decimal SaldoAnterior = this.persistencia.SaldoCuentaAnterior(item.cuenta, item.mes, item.anio, item.idsucursal);
                        if (cuenta != item.maeconta.cuenta.Substring(0, 2))
                        {
                            SaldosCuentasDataSource sal = new SaldosCuentasDataSource();
                            sal.SaldoAnterior = SaldoAnterior;
                            sal.Sucursal = item.idsucursal;
                            sal.Anio = item.anio;
                            sal.Cuenta = item.maeconta.cuenta.Substring(0, 2);
                            sal.Mes = item.mes;
                            sal.NombreCuenta = this.persistenciaCuenta.DevolverNombre(item.maeconta.cuenta.Substring(0, 2));
                            sal.SaldoActual = item.saldomes;
                            sal.ValorCredito = item.credimes;
                            sal.ValorDebito = item.debimes;
                            balan.Add(sal);
                        }
                        else
                        {
                            foreach (var itbal in balan)
                            {
                                if (itbal.Cuenta.Substring(0, 2) == item.maeconta.cuenta.Substring(0, 2))
                                {
                                    itbal.SaldoAnterior = itbal.SaldoAnterior + SaldoAnterior;
                                    itbal.ValorDebito = itbal.ValorDebito + item.debimes;
                                    itbal.ValorCredito = itbal.ValorCredito + item.credimes;
                                    itbal.SaldoActual = itbal.SaldoActual + item.saldomes;
                                }
                            }
                        }
                        cuenta = item.maeconta.cuenta.Substring(0, 2);
                    }
                }
                else
                {
                    balan = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return balan;
        }

        public string TieneMovimientoFechaCuenta(DateTime fechaini, DateTime fechafin, string cuentaini, string cuentafin, int sucursal)
        {
            try
            {
                List<int> cuentainiid = new List<int>();
                if (!cuentaini.Equals("**"))
                {
                    cuentainiid = this.persistenciaCuenta.DevolverIdsEntre(cuentaini, cuentafin);
                }
                else
                {
                    cuentainiid = this.persistenciaCuenta.DevolverTodosIds();
                }

                if (cuentainiid != null)
                {
                    return this.persistencia.TienenMovimientoFechaCuenta(fechaini, fechafin, cuentainiid, sucursal);
                }
                else
                {
                    return "nocuentas";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<LibroAuxiliarDataSource> CargarBalanceLibroAux(DateTime fechaini, DateTime fechafin, string cuentaini, string cuentafin, string ordenado, int sucursal, bool actual)
        {
            List<LibroAuxiliarDataSource> balan = new List<LibroAuxiliarDataSource>();
            try
            {
                List<int> cuentaid = new List<int>();
                if (!cuentaini.Equals("**"))
                {
                    cuentaid = this.persistenciaCuenta.DevolverIdsEntre(cuentaini, cuentafin);
                }
                else
                {
                    cuentaid = this.persistenciaCuenta.DevolverTodosIds();
                }

                if (cuentaid != null)
                {
                    var items = this.persistencia.CargarBalanceLibroAux(fechaini, fechafin, cuentaid, sucursal, actual);
                    if (items != null)
                    {
                        foreach (var item in items)
                        {

                            LibroAuxiliarDataSource sal = new LibroAuxiliarDataSource();
                            sal.Fecha = item.fecha;
                            sal.Anio = item.anio;
                            sal.Mes = item.mes;
                            sal.Sucursal = item.idsucursal;
                            sal.Idcentro = item.idcentro ?? default(int);
                            sal.Comproban = Convert.ToString(item.codigcomprob);
                            sal.Documento = item.documento;
                            sal.Cuenta = item.maeconta.cuenta;
                            sal.NombreCuenta = item.maeconta.nombre;
                            sal.Descripcion = item.detalle;
                            sal.Valorcredito = item.valorcredito;
                            sal.Valordebito = item.valordebito;
                            balan.Add(sal);
                        }
                        if (ordenado == "FECHA")
                        {
                            balan.OrderBy(bal => bal.Fecha);
                        }
                        else if (ordenado == "DOCUMENTO")
                        {
                            balan.OrderBy(bal => bal.Documento);
                        }
                    }
                    else
                    {
                        balan = null;
                    }
                }
                else
                {
                    balan = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return balan;
        }

        public string TieneMovimientoFechaCuentayNit(DateTime fechaini, DateTime fechafin, string cuentaini, string cuentafin, string nitini, string nitfin, int sucursal)
        {
            try
            {
                List<int> cuentainiid = new List<int>();
                List<int> nitsid = new List<int>();
                if (!cuentaini.Equals("**"))
                {
                    cuentainiid = this.persistenciaCuenta.DevolverIdsEntre(cuentaini, cuentafin);
                }
                else
                {
                    cuentainiid = this.persistenciaCuenta.DevolverTodosIds();
                }

                if (cuentainiid != null)
                {
                    if (!nitini.Equals("**"))
                    {
                        nitsid = this.persistenciaNit.DevolverIdsEntre(nitini, nitfin);
                    }
                    else
                    {
                        nitsid = this.persistenciaNit.DevolverTodosIds();
                    }

                    if (nitsid != null)
                    {
                        return this.persistencia.TienenMovimientoFechaCuentaNit(fechaini, fechafin, cuentainiid, nitsid, sucursal);
                    }
                    else
                    {
                        return "nonits";
                    }
                }
                else
                {
                    return "nocuentas";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string TieneMovimientoFechaCuentaSinAct(DateTime fechaini, DateTime fechafin, string cuentaini, string cuentafin, int sucursal)
        {
            try
            {
                List<int> cuentainiid = new List<int>();
                if (!cuentaini.Equals("**"))
                {
                    cuentainiid = this.persistenciaCuenta.DevolverIdsEntre(cuentaini, cuentafin);
                }
                else
                {
                    cuentainiid = this.persistenciaCuenta.DevolverTodosIds();
                }

                if (cuentainiid != null)
                {
                    return this.persistencia.TienenMovimientoFechaCuentaSinAct(fechaini, fechafin, cuentainiid, sucursal);
                }
                else
                {
                    return "nocuentas";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<LibroAuxiliarDataSource> CargarBalanceLibroAuxNit(DateTime fechaini, DateTime fechafin, string cuentaini, string cuentafin, string nitini, string nitfin, string ordenado, int sucursal)
        {
            List<LibroAuxiliarDataSource> balan = new List<LibroAuxiliarDataSource>();
            try
            {
                List<int> cuentainiid = new List<int>();
                List<int> nitsid = new List<int>();
                if (!cuentaini.Equals("**"))
                {
                    cuentainiid = this.persistenciaCuenta.DevolverIdsEntre(cuentaini, cuentafin);
                }
                else
                {
                    cuentainiid = this.persistenciaCuenta.DevolverTodosIds();
                }

                if (cuentainiid != null)
                {
                    if (!nitini.Equals("**"))
                    {
                        nitsid = this.persistenciaNit.DevolverIdsEntre(nitini, nitfin);
                    }
                    else
                    {
                        nitsid = this.persistenciaNit.DevolverTodosIds();
                    }

                    if (nitsid != null)
                    {
                        var items = this.persistencia.CargarBalanceLibroAuxNit(fechaini, fechafin, cuentainiid, nitsid, sucursal);
                        if (items != null)
                        {
                            foreach (var item in items)
                            {

                                LibroAuxiliarDataSource sal = new LibroAuxiliarDataSource();
                                sal.Fecha = item.fecha;
                                sal.Anio = item.anio;
                                sal.Mes = item.mes;
                                sal.Sucursal = item.idsucursal;
                                sal.Idcentro = item.idcentro ?? default(int);
                                sal.Comproban = Convert.ToString(item.codigcomprob);
                                sal.Documento = item.documento;
                                sal.Cuenta = item.maeconta.cuenta;
                                sal.NombreCuenta = item.maeconta.nombre;
                                sal.Descripcion = item.detalle;
                                sal.Valorcredito = item.valorcredito;
                                sal.Valordebito = item.valordebito;
                                balan.Add(sal);
                            }
                            if (ordenado == "FECHA")
                            {
                                balan.OrderBy(bal => bal.Fecha);
                            }
                            else if (ordenado == "DOCUMENTO")
                            {
                                balan.OrderBy(bal => bal.Documento);
                            }
                        }
                        else
                        {
                            balan = null;
                        }
                    }
                    else
                    {
                        balan = null;
                    }
                }
                else
                {
                    balan = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return balan;
        }

        public bool ExisteAsientoDesactualizar(int sucursal)
        {
            try
            {
                return this.persistencia.ExisteAsientoDesactualizar(sucursal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ExisteAsientoenFechaAct(int mesdesde, int meshasta, int sucursal)
        {
            try
            {
                return this.persistencia.ExisteAsientoenFechaAct(mesdesde, meshasta, sucursal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DesactualizarTodosAsientos(int mesde, int meshasta, int sucursal)
        {
            int cantasiento = 0;
            try
            {
                cantasiento = this.persistencia.DesactualizarTodosAsientos(mesde, meshasta, sucursal);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return cantasiento;
        }

        public bool DesactualizarUnAsiento(int comprobante, string asiento, string anio, int sucursal)
        {
            List<movimi> asientoact = new List<movimi>();
            try
            {
                asientoact = this.persistencia.DevolverAsiento(comprobante, asiento, anio, sucursal, true);
                if (asientoact != null)
                {
                    return this.persistencia.DesactualizarUnAsiento(asientoact);
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

        public int DevolverCantidadAsi()
        {
            throw new NotImplementedException();
        }

        public string TodosAsientosActoNo(string anio, int sucursal, bool actual)
        {
            try
            {
                return this.persistencia.TodosAsientosActoNo(anio, sucursal, actual);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void GenerarAsientoCierreEstado(string anio, int sucursal, int usuario)
        {
            CierreCuentasEstadoDataSource cierrecuenta = new CierreCuentasEstadoDataSource();
            List<int> cuentasiding = new List<int>();
            List<int> cuentasidcos = new List<int>();
            try
            {
                var items = this.persistenciaParametro.CargarDatosComprobante();
                cierrecuenta.Cuentainiing = items[0].valorparam;
                cierrecuenta.Cuentafining = items[1].valorparam;
                cierrecuenta.Cuentainicos = items[2].valorparam;
                cierrecuenta.Cuentafincos = items[3].valorparam;
                cierrecuenta.Cuentauti = items[4].valorparam;
                cierrecuenta.Codcompro = items[5].valorparam;
                cierrecuenta.Detalle = items[6].valorparam;
                cuentasiding = this.persistenciaCuenta.DevolverIdsEntre(cierrecuenta.Cuentainiing, cierrecuenta.Cuentafining);
                cuentasidcos = this.persistenciaCuenta.DevolverIdsEntre(cierrecuenta.Cuentainicos, cierrecuenta.Cuentafincos);
                int? idutili = this.persistenciaCuenta.DevolverId(cierrecuenta.Cuentauti);
                this.persistencia.GenerarAsientoCierreEstado(cuentasiding, cuentasidcos,idutili,int.Parse(cierrecuenta.Codcompro),cierrecuenta.Detalle, anio, sucursal, usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void GenerarAsientoCierreImpuestos(string anio, int sucursal, int usuario)
        {
            try
            {
                this.persistencia.GenerarAsientoCierreImpuestos(anio, sucursal, usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void GenerarAsientoAjuste(int mes,DateTime fecha, string detalle, int comprobante, decimal tasa, string documento, string anio, int sucursal, int usuario)
        {
            try
            {
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
