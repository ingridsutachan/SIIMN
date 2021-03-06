﻿////*********************************************************
//
//    <copyright file="presupueston.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 01 marzo 2014
//    </copyright>
//
////*********************************************************
namespace Negocios.Contable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Datos.Contable;
    using Entities;
    using Entities.Types;

    /// <summary>
    /// Clase de Presupuesto Negocios
    /// </summary>
    public class Presupueston
    {
        /// <summary>
        ///  Instancia de Capa de Datos
        /// </summary>
        private Presupuestoc persistencia;

        private Cuentac persistenciaCuenta;

        /// <summary>
        /// Initializes a new instance of the <see cref="Presupueston" /> class.
        /// </summary>
        public Presupueston()
        {
            this.persistencia = new Presupuestoc();
            this.persistenciaCuenta = new Cuentac();
        }

        /// <summary>
        /// Devolvers the presu.
        /// </summary>
        /// <param name="anio">Año de presupuesto</param>
        /// <param name="cuenta">la cuenta de presupuesto</param>
        /// <returns>lista de presupuesto respectivo al año y a la cuenta</returns>
        public List<PresupDataSource> DevolverPresu(string anio, string cuenta, int centro, int idsucursal)
        {
            List<PresupDataSource> datasSource = new List<PresupDataSource>();
            try
            {
                var items = this.persistencia.DevuelvePres(anio, cuenta, centro, idsucursal).OrderBy(m => m.mes);
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        PresupDataSource ds = new PresupDataSource();
                        ds.Anio = item.anio;
                        ds.Cuenta = item.maeconta.cuenta;
                        ds.NombreCuenta = item.maeconta.nombre;
                        ds.IdMes = item.mes;
                        ds.IdCentro = item.idcentro;
                        ds.NombreCentro = item.centrocostos.nombrecentro;
                        ds.Presupuesto = item.cantidad;
                        datasSource.Add(ds);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return datasSource;
        }

        /// <summary>
        /// Guarda presupuesto
        /// </summary>
        /// <param name="pres">Presupuesto a guardar</param>
        public bool GuardarPresup(List<PresupDataSource> presup)
        {
            bool result = false;
            try
            {
                List<presupuesto> presu = new List<presupuesto>();
                if (presup != null)
                {
                    foreach (PresupDataSource item in presup)
                    {
                        presupuesto pres = new presupuesto();
                        pres.anio = item.Anio;
                        pres.mes = item.IdMes;
                        pres.cuenta = this.persistenciaCuenta.DevolverId(item.Cuenta) ?? default(int);
                        pres.cantidad = item.Presupuesto;
                        pres.idcentro = item.IdCentro;
                        pres.idsucursal = item.IdSucursal;
                        presu.Add(pres);
                    }
                }
                result = this.persistencia.GuardarPre(presu);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        /// <summary>
        /// Actualiza el presupuesto
        /// </summary>
        /// <param name="presup">presupuesto a actualizar</param>
        public bool UpdatePresupuesto(List<PresupDataSource> presup)
        {
            bool result = false;
            try
            {
                List<presupuesto> presu = new List<presupuesto>();
                if (presup != null)
                {
                    foreach (PresupDataSource item in presup)
                    {
                        presupuesto pres = new presupuesto();
                        pres.anio = item.Anio;
                        pres.mes = item.IdMes;
                        pres.cuenta = this.persistenciaCuenta.DevolverId(item.Cuenta) ?? default(int);
                        pres.cantidad = item.Presupuesto;
                        pres.idcentro = item.IdCentro;
                        pres.idsucursal = item.IdSucursal;
                        presu.Add(pres);
                    }
                }

                result = this.persistencia.UpdatePresup(presu);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        /// <summary>
        /// Eliminars the cuenta.
        /// </summary>
        /// <param name="anio">Anio a eliminar</param>
        /// <param name="cuenta">Cuenta a eliminar.</param>
        /// <returns>Booleano si la cuenta se elimino </returns>
        public bool EliminarPresupuesto(string anio, string cuenta, int idcentro, int idsucursal)
        {
            bool result = false;
            try
            {
                result = this.persistencia.EliminarPresu(anio, cuenta, idcentro, idsucursal);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public bool ExistePresupuesto(string anio, string cuenta, int centro, int sucursalid)
        {
            try
            {
                return this.persistencia.ExistePresupuesto(anio, cuenta, centro, sucursalid);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<PresupShowDataSource> Busqueda(string tipo, string buscar)
        {
            List<PresupShowDataSource> presupdev = new List<PresupShowDataSource>();
            try
            {
                var items = this.persistencia.Busqueda(tipo, buscar);
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        PresupShowDataSource ds = new PresupShowDataSource();
                        ds.Anio = item.anio;
                        ds.IdMes = item.mes;
                        ds.Cuenta = item.maeconta.cuenta;
                        ds.IdCentro = item.idcentro;
                        ds.Presupuesto = item.cantidad;
                        presupdev.Add(ds);
                    }
                }
                else
                {
                    presupdev = this.PresupuestoNull();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return presupdev;
        }

        private List<PresupShowDataSource> PresupuestoNull()
        {
            List<PresupShowDataSource> presup = new List<PresupShowDataSource>();
            PresupShowDataSource ds = new PresupShowDataSource();
            ds.Anio = null;
            ds.IdMes = null;
            ds.Cuenta = null;
            ds.IdCentro = null;
            ds.Presupuesto = null;
            presup.Add(ds);
            return presup;
        }
    }
}
