﻿////*********************************************************
//
//    <copyright file="cuentan.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 01 marzo 2014
//    </copyright>
//
////*********************************************************
namespace Negocios.Contable
{
    using System;
    using System.Collections.Generic;
    using Datos.Contable;
    using System.Linq;
    using Entities;
    using Entities.Types;

    /// <summary>
    /// Clase de Cuenta
    /// </summary>
    public class Cuentan
    {
        /// <summary>
        /// instancia capa de datosinstancia capa de datos
        /// </summary>
        private Cuentac persistencia;
        private Nitsc persistenciaN;
        private FormatoMediosc persistenciaFormato;

        /// <summary>
        /// Initializes a new instance of the <see cref="Cuentan"/> class.
        /// </summary>
        public Cuentan()
        {
            this.persistencia = new Cuentac();
            this.persistenciaN = new Nitsc();
            this.persistenciaFormato = new FormatoMediosc();
        }

        /// <summary>
        /// Cargar  cuenta.
        /// </summary>
        /// <returns>Lista de todas las cuentas</returns>
        public List<CuentaDataSource> CargarCuenta()
        {
            List<CuentaDataSource> cuenta = new List<CuentaDataSource>();
            try
            {
                var items = this.persistencia.CargarCuenta();
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        CuentaDataSource ds = new CuentaDataSource();
                        ds.Cuenta = item.cuenta;
                        ds.Tipocta = item.tipocta;
                        ds.Nombre = item.nombre;
                        cuenta.Add(ds);
                    }
                }
                else
                {
                    cuenta = this.CuentaNull();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return cuenta;
        }

        /// <summary>
        /// Verifica cuenta.
        /// </summary>
        /// <param name="cuenta">cuenta que se verificara</param>
        /// <returns>booleano que rectifica si existe o no la cuenta</returns>
        public bool ExisteCuenta(string cuenta)
        {
            try
            {
                return this.persistencia.ExisteCuenta(cuenta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Devolvuelve the datos.
        /// </summary>
        /// <param name="id">identificador de la cuenta</param>
        /// <returns>cuenta respectiva al identificador</returns>
        public CuentaDataSource DevolverDatos(string id)
        {
            CuentaDataSource datos = new CuentaDataSource();
            try
            {
                var item = this.persistencia.DevuelveDatos(id);
                if (item != null)
                {
                    datos.Cuenta = item.cuenta;
                    datos.Tipocta = item.tipocta == "M" ? "MAYOR" : "AUXILIAR";
                    datos.Nombre = item.nombre;
                    datos.Pidenit = item.pidenit;
                    datos.Centro = item.centro;
                    datos.Ajusteinteg = item.ajustesinteg;
                    datos.Nitajustes = item.idnitajustes == null ? string.Empty : item.maenits.nit;
                    datos.Ajudoc = item.ajudoc;
                    datos.Cueaju = this.persistencia.DevolverCuenta(item.cueaju);
                    datos.Cuencorre = this.persistencia.DevolverCuenta(item.cuencorre);
                    datos.Porete = item.porete;
                    datos.Concepret = item.conceprete;
                    datos.Cuentret = item.retencion;
                    datos.Cuentacierreimp = this.persistencia.DevolverCuenta(item.cuentacierre);
                    datos.ReteIca = item.reteica;
                    datos.PoreteIca = item.poreteica;
                    datos.ConcepReteIca = item.concepreteica;
                    datos.FormatoMedios = item.codformatomedios != null ? item.formatomedios.numeroformatos : string.Empty;
                }
                else
                {
                    datos.Cuenta = null;
                    datos.Tipocta = null;
                    datos.Nombre = null;
                    datos.Pidenit = false;
                    datos.Centro = false;
                    datos.Ajusteinteg = false;
                    datos.Nitajustes = null;
                    datos.Cueaju = null;
                    datos.Cuencorre = null;
                    datos.Ajudoc = null;
                    datos.Porete = null;
                    datos.Cuentret = false;
                    datos.Concepret = null;
                    datos.Cuentacierreimp = null;
                    datos.ReteIca = false;
                    datos.FormatoMedios = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return datos;
        }

        /// <summary>
        /// Guardar cuenta.
        /// </summary>
        /// <param name="cuenta">Cuenta a guardar</param>
        /// <returns>cuenta que fue guardada</returns>
        public bool GuardarCuenta(CuentaDataSource cuenta)
        {
            maeconta campo = new maeconta();
            try
            {
                campo.cuenta = cuenta.Cuenta;
                campo.tipocta = cuenta.Tipocta;
                campo.nombre = cuenta.Nombre;
                campo.pidenit = cuenta.Pidenit;
                campo.centro = cuenta.Centro;
                campo.ajustesinteg = cuenta.Ajusteinteg;
                campo.idnitajustes = this.persistenciaN.DevolverId(cuenta.Nitajustes);
                campo.ajudoc = cuenta.Ajudoc;
                campo.cueaju = this.persistencia.DevolverId(cuenta.Cueaju);
                campo.cuencorre = this.persistencia.DevolverId(cuenta.Cuencorre);
                campo.porete = cuenta.Porete;
                campo.conceprete = cuenta.Concepret;
                campo.reteica = cuenta.ReteIca;
                campo.poreteica = cuenta.PoreteIca;
                campo.concepreteica = cuenta.ConcepReteIca;
                campo.codformatomedios = this.persistenciaFormato.DevolverId(cuenta.FormatoMedios);
                campo.cuentacierre = this.persistencia.DevolverId(cuenta.Cuentacierreimp);
                return this.persistencia.GuardarCuenta(campo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Actualizar  cuenta.
        /// </summary>
        /// <param name="cuenta">cuenta a actualizar</param>
        /// <returns>cuenta que fue actualizada</returns>
        public bool ActualizarCuenta(CuentaDataSource cuenta)
        {
            maeconta campo = new maeconta();
            try
            {
                campo.cuenta = cuenta.Cuenta;
                campo.tipocta = cuenta.Tipocta;
                campo.nombre = cuenta.Nombre;
                campo.pidenit = cuenta.Pidenit;
                campo.centro = cuenta.Centro;
                campo.ajustesinteg = cuenta.Ajusteinteg;
                campo.idnitajustes = this.persistenciaN.DevolverId(cuenta.Nitajustes);
                campo.ajudoc = cuenta.Ajudoc;
                campo.cueaju = this.persistencia.DevolverId(cuenta.Cueaju);
                campo.cuencorre = this.persistencia.DevolverId(cuenta.Cuencorre);
                campo.porete = cuenta.Porete;
                campo.conceprete = cuenta.Concepret;
                campo.cuentacierre = this.persistencia.DevolverId(cuenta.Cuentacierreimp);
                campo.reteica = cuenta.ReteIca;
                campo.poreteica = cuenta.PoreteIca;
                campo.concepreteica = cuenta.ConcepReteIca;
                campo.codformatomedios = this.persistenciaFormato.DevolverId(cuenta.FormatoMedios);
                return this.persistencia.ActualizarCuenta(campo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Eliminar cuenta.
        /// </summary>
        /// <param name="id">Identificador de cuenta a eliminar</param>
        /// <returns>booleano que rectifica si la cuenta fue eliminada</returns>
        public bool EliminarCuenta(string id)
        {
            try
            {
                return this.persistencia.EliminarCuenta(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string DevolverNombre(string codigo)
        {
            try
            {
                return this.persistencia.DevolverNombre(codigo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CuentaDataSource> Busqueda(string tipo, string buscar)
        {
            List<CuentaDataSource> cuentadev = new List<CuentaDataSource>();
            try
            {
                var items = this.persistencia.Busqueda(tipo, buscar);
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        CuentaDataSource ds = new CuentaDataSource();
                        ds.Cuenta = item.cuenta;
                        ds.Tipocta = item.tipocta;
                        ds.Nombre = item.nombre;
                        ds.Pidenit = item.pidenit;
                        ds.Centro = item.centro;
                        ds.Ajusteinteg = item.ajustesinteg;
                        ds.Nitajustes = item.idnitajustes != null ? item.maenits.nit : string.Empty;
                        ds.Cueaju = item.cueaju != null ? item.maeconta2.cuenta : string.Empty;
                        ds.Cuencorre = item.cuencorre != null ? item.maeconta4.cuenta : string.Empty;
                        ds.Ajudoc = item.ajudoc;
                        if (item.retencion)
                        {
                            ds.Cuentret = item.retencion;
                            ds.Porete = item.porete;
                            ds.Concepret = item.conceprete;
                        }
                        else if (item.reteica)
                        {
                            ds.Cuentret = item.reteica;
                            ds.Porete = item.poreteica;
                            ds.Concepret = item.concepreteica;
                        }
                        else
                        {
                            ds.Cuentret = false;
                            ds.Porete = 0;
                            ds.ConcepReteIca = string.Empty;
                        }

                        ds.Cuentacierreimp = item.cuentacierre != null ? item.maeconta3.cuenta : string.Empty;
                        ds.ReteIca = item.reteica;
                        ds.FormatoMedios = item.codformatomedios != null ? item.formatomedios.numeroformatos : string.Empty;
                        cuentadev.Add(ds);
                    }
                }
                else
                {
                    cuentadev = this.CuentaNull();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return cuentadev;
        }

        public List<CuentaDataSource> CargarInforme(string cuentainicial, string cuentafinal)
        {
            List<CuentaDataSource> informe = new List<CuentaDataSource>();
            try
            {
                var items = this.persistencia.CargarInforme(cuentainicial, cuentafinal);
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        CuentaDataSource infor = new CuentaDataSource();
                        infor.Cuenta = item.cuenta;
                        infor.Nombre = item.nombre;
                        infor.Tipocta = item.tipocta;
                        infor.Pidenit = item.pidenit;
                        infor.Centro = item.centro;
                        infor.Cueaju = this.persistencia.DevolverCuenta(item.cueaju);
                        infor.Ajudoc = item.ajudoc;
                        if (item.retencion)
                        {
                            infor.Porete = item.porete;
                        }
                        else if (item.reteica)
                        {
                            infor.Porete = item.poreteica;
                        }
                        else
                        {
                            infor.Porete = 0;
                        }

                        informe.Add(infor);
                    }
                }
                else
                {
                    informe = this.CuentaNull();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return informe;
        }

        public string DevuelveTipoCuenta(string cuenta)
        {
            try
            {
                return this.persistencia.DevolverTipoCuenta(cuenta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<CuentaDataSource> CuentaNull()
        {
            List<CuentaDataSource> cuenta = new List<CuentaDataSource>();
            CuentaDataSource ds = new CuentaDataSource();
            ds.Cuenta = null;
            ds.Tipocta = null;
            ds.Nombre = null;
            ds.Pidenit = false;
            ds.Centro = false;
            ds.Ajusteinteg = false;
            ds.Nitajustes = null;
            ds.Cueaju = null;
            ds.Cuencorre = null;
            ds.Ajudoc = null;
            ds.Porete = null;
            ds.Cuentret = false;
            ds.Concepret = null;
            ds.Cuentacierreimp = null;
            ds.ReteIca = false;
            ds.FormatoMedios = null;
            cuenta.Add(ds);
            return cuenta;
        }

        public bool TieneRetencion(string cuenta)
        {
            try
            {
                return this.persistencia.TieneRetencion(cuenta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool TieneReteIca(string cuenta)
        {
            try
            {
                return this.persistencia.TieneReteIca(cuenta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CuentaDataSourceSaldo> SaldoCuenta(string cuenta, string aniotrabajo, int idsucursal)
        {
            List<CuentaDataSourceSaldo> cuentasal = new List<CuentaDataSourceSaldo>();
            try
            {
                var cuentadev = this.persistencia.DevuelveDatos(cuenta);
                decimal retencion = 0;
                bool piderete = false;
                if (cuentadev != null)
                {
                    if (cuentadev.retencion)
                    {
                        piderete = cuentadev.retencion;
                        retencion = cuentadev.porete ?? default(decimal);
                    }
                    else if (cuentadev.reteica)
                    {
                        piderete = cuentadev.reteica;
                        retencion = cuentadev.poreteica ?? default(decimal);
                    }
                    else
                    {
                        piderete = false;
                        retencion = 0;
                    }
                }
                var ids = this.persistencia.DevolverIds(cuenta);
                var saldos = this.persistencia.DevolverSaldos(ids, aniotrabajo, idsucursal);
                if (saldos != null)
                {
                    for (int i = 0; i < saldos.Count; i++)
                    {
                        CuentaDataSourceSaldo cuentas = new CuentaDataSourceSaldo();
                        cuentas.TipoCuenta = cuentadev.tipocta;
                        cuentas.PideNit = cuentadev.pidenit;
                        cuentas.PideCentro = cuentadev.centro;
                        cuentas.PideRete = piderete;
                        cuentas.Retencion = retencion;
                        cuentas.CuentaAju = cuentadev.cueaju!= null ? cuentadev.maeconta2.cuenta: string.Empty;
                        cuentas.Doc = cuentadev.ajudoc;
                        cuentas.mes = saldos[i].mes;
                        cuentas.saldo = saldos[i].saldomes;
                        cuentas.credito = saldos[i].credimes;
                        cuentas.debito = saldos[i].debimes;
                        cuentasal.Add(cuentas);
                    }

                    if (saldos.Count < 12)
                    {
                        for (int i =1; i <= 12; i++)
                        {
                            var cuet = cuentasal.Where(cue => cue.mes == i );
                            if (cuet.Count() == 0)
                            {
                                CuentaDataSourceSaldo cuentas = new CuentaDataSourceSaldo();
                                cuentas.TipoCuenta = cuentadev.tipocta;
                                cuentas.PideNit = cuentadev.pidenit;
                                cuentas.PideCentro = cuentadev.centro;
                                cuentas.PideRete = piderete;
                                cuentas.Retencion = retencion;
                                cuentas.CuentaAju = cuentadev.cueaju != null ? cuentadev.maeconta2.cuenta : string.Empty;
                                cuentas.Doc = cuentadev.ajudoc;
                                cuentas.mes = i;
                                cuentas.saldo = saldos[saldos.Count-1].saldomes;
                                cuentas.credito = saldos[saldos.Count-1].credimes;
                                cuentas.debito = saldos[saldos.Count-1].debimes;
                                cuentasal.Add(cuentas);
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return cuentasal;
        }

        public decimal DevolverSaldoAnio(string cuenta, string anio)
        {
            decimal saldo = 0;
            try
            {
                int? idcuenta = this.persistencia.DevolverId(cuenta);
                var items = this.persistencia.DevolverSaldoAnio(idcuenta, anio);
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        saldo = saldo + item.saldomes;
                    }
                    return saldo;
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
}
