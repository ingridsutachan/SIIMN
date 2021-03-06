﻿////*********************************************************
//
//    <copyright file="nitsn.cs" company="Marketing Software de Colombia LTDA">
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
    /// Clase Nits de Negocios
    /// </summary>
    public class Nitsn
    {
        /// <summary>
        /// instancia capa de datos
        /// </summary>
        private Nitsc persistencia;

        /// <summary>
        /// Initializes a new instance of the <see cref="Nitsn"/> class.
        /// </summary>
        public Nitsn()
        {
            this.persistencia = new Nitsc();
        }
        private maenits ConvertirDatatoBd(NitsDataSource nits)
        {
            maenits nit = new maenits();
            nit.idnit = nits.Idnit;
            nit.nit = nits.Nit;
            nit.digito = nits.Digito;
            nit.nombrenit = nits.Nombrenit;
            nit.idtiponit = this.persistencia.DevolverIdTipo(nits.Tiponit);
            nit.acteconomic = nits.ActividadEconomica;
            nit.idciudad = nits.Idciudad;
            nit.direccion = nits.Direccion;
            nit.telefono = nits.Telefono;
            nit.celular = nits.Celular;
            nit.email = nits.Email;
            return nit;
        }

        private NitsDataSource ConvertirBdtoData(maenits nites)
        {
            NitsDataSource nits = new NitsDataSource();
            nits.Idnit = nites.idnit;
            nits.Nit = nites.nit;
            nits.Digito = nites.digito;
            nits.Tiponit = nites.tiponit.codigtiponit;
            nits.ActividadEconomica = nites.acteconomic;
            nits.Idciudad = nites.idciudad;
            nits.Nombrenit = nites.nombrenit;
            nits.Direccion = nites.direccion;
            nits.Telefono = nites.telefono;
            nits.Celular = nites.celular;
            nits.Email = nites.email;
            return nits;
        }

        /// <summary>
        /// Carga los nits
        /// </summary>
        /// <returns>lista de nits</returns>
        public List<NitsDataSource> CargarNits()
        {
            List<NitsDataSource> nits = new List<NitsDataSource>();
            try
            {
                var items = this.persistencia.CargarNits();
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        NitsDataSource nds = new NitsDataSource();
                        nds.Idnit = item.idnit;
                        nds.Nit = item.nit;
                        nds.Digito = item.digito;
                        nds.Nombrenit = item.nombrenit;
                        nits.Add(nds);
                    }
                }
                else
                {
                    nits = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return nits;
        }

        /// <summary>
        /// Guarda nits.
        /// </summary>
        /// <param name="nits">Nit a guardar</param>
        public bool GuardarNits(NitsDataSource nits)
        {
            maenits nit = new maenits();
            nit = this.ConvertirDatatoBd(nits);
            try
            {
                return this.persistencia.GuardarNits(nit);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Devuelve  nits.
        /// </summary>
        /// <param name="idnit">entero con  idnit.</param>
        /// <returns>nit con el respectivo idnit</returns>
        public NitsDataSource DevolverNits(string nit)
        {
            try
            {
                var items = this.persistencia.DevolverNit(nit);
                if (items != null)
                {
                    return this.ConvertirBdtoData(items);
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

        /// <summary>
        /// Actualiza nits.
        /// </summary>
        /// <param name="nits">Nit a actualizar</param>
        public bool ActualizarNits(NitsDataSource nits)
        {
            maenits nit = new maenits();
            nit = this.ConvertirDatatoBd(nits);
            try
            {
                return this.persistencia.ActualizarNit(nit);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Verifica NIT
        /// </summary>
        /// <param name="nits">nit a verificar</param>
        /// <returns>booleano que dice si existe o no</returns>
        public bool ExisteNit(string nit)
        {
            try
            {
                return this.persistencia.ExisteNit(nit);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Eliminar  nit
        /// </summary>
        /// <param name="idnit">identificador de nit</param>
        /// <returns>booleano que rectifica si se ha eliminado el registro</returns>
        public bool EliminarNit(string idnit)
        {
            try
            {
                return this.persistencia.EliminarNit(idnit);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<NitsDataSourceShow> Busqueda(string tipo, string buscar)
        {
            List<NitsDataSourceShow> nits = new List<NitsDataSourceShow>();
            try
            {
                var items = this.persistencia.Busqueda(tipo, buscar);
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        NitsDataSourceShow nds = new NitsDataSourceShow();
                        nds.Nit = item.nit;
                        nds.Digito = item.digito;
                        nds.Nombrenit = item.nombrenit;
                        nds.Tiponit = item.tiponit.nombretipo;
                        nds.ActividadEconomica = item.acteconomic;
                        nds.Direccion = item.direccion;
                        nds.Telefono = item.telefono;
                        nds.Celular = item.celular;
                        nds.Email = item.email;
                        nds.NombrePais = item.ciudad.departamento.pais.nombrepais;
                        nds.NombreDepto = item.ciudad.departamento.nombredept;
                        nds.NombreCiudad = item.ciudad.nombreciudad;
                        nits.Add(nds);
                    }
                }
                else
                {
                    nits = this.NitsNull();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return nits;
        }

        private List<NitsDataSourceShow> NitsNull()
        {
            List<NitsDataSourceShow> nit = new List<NitsDataSourceShow>();
            NitsDataSourceShow ds = new NitsDataSourceShow();
            ds.Nit = null;
            ds.Digito = null;
            ds.Nombrenit = null;
            ds.Tiponit = null;
            ds.ActividadEconomica = null;
            ds.Direccion = null;
            ds.Telefono = null;
            ds.Celular = null;
            ds.Email = null;
            ds.NombrePais = null;
            ds.NombreDepto = null;
            ds.NombreCiudad = null;
            nit.Add(ds);

            return nit;
        }

        public string DevolverNombre(string idnit)
        {
            try
            {
                return this.persistencia.DevolverNombre(idnit);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public NitsDataSource DevolverNitsCompleto(string nit)
        {
            NitsDataSource nds = new NitsDataSource();
            try
            {
                var item = this.persistencia.DevolverNit(nit);
                if (item != null)
                {
                    nds.Nit = item.nit;
                    nds.Digito = item.digito;
                    nds.Nombrenit = item.nombrenit;
                    nds.Tiponit = item.tiponit.codigtiponit;
                    nds.ActividadEconomica = item.acteconomic;
                    nds.Direccion = item.direccion;
                    nds.Telefono = item.telefono;
                    nds.Celular = item.celular;
                    nds.Email = item.email;
                    nds.IdPais = item.ciudad.departamento.idpais;
                    nds.IdDepto = item.ciudad.codigodepto;
                    nds.Idciudad = item.idciudad;
                }
                else
                {
                    nds = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return nds;
        }

        public List<NitsDataSourceShow> CargarNitsReporteOrdNombre()
        {
            List<NitsDataSourceShow> nits = new List<NitsDataSourceShow>();
            try
            {
                var items = this.persistencia.CargarNitsReportesNombre();
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        NitsDataSourceShow nds = new NitsDataSourceShow();
                        nds.Nit = item.nit;
                        nds.Digito = item.digito;
                        nds.Nombrenit = item.nombrenit;
                        nds.Tiponit = item.tiponit.codigtiponit;
                        nds.ActividadEconomica = item.acteconomic;
                        nds.NombreCiudad = item.ciudad.codigociudad;
                        nds.NombrePais = item.ciudad.departamento.pais.codpais;
                        nds.NombreDepto = item.ciudad.departamento.codigodepto;
                        nds.Direccion = item.direccion;
                        nds.Telefono = item.telefono;
                        nds.Celular = item.celular;
                        nds.Email = item.email;
                        nits.Add(nds);
                    }
                }
                else
                {
                    nits = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return nits;
        }

        public List<NitsDataSourceShow> CargarNitsReporteOrdeNumero()
        {
            List<NitsDataSourceShow> nits = new List<NitsDataSourceShow>();
            try
            {
                var items = this.persistencia.CargarNitsReportesNumero();
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        NitsDataSourceShow nds = new NitsDataSourceShow();
                        nds.Nit = item.nit;
                        nds.Digito = item.digito;
                        nds.Nombrenit = item.nombrenit;
                        nds.Tiponit = item.tiponit.codigtiponit;
                        nds.ActividadEconomica = item.acteconomic;
                        nds.NombreCiudad = item.ciudad.codigociudad;
                        nds.NombrePais = item.ciudad.departamento.pais.codpais;
                        nds.NombreDepto = item.ciudad.departamento.codigodepto;
                        nds.Direccion = item.direccion;
                        nds.Telefono = item.telefono;
                        nds.Celular = item.celular;
                        nds.Email = item.email;
                        nits.Add(nds);
                    }
                }
                else
                {
                    nits = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return nits;
        }

        public int? DevolverId(string nit)
        {
            try
            {
                return this.persistencia.DevolverId(nit);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string DevolverNit(int? idnit)
        {
            try
            {
                return persistencia.DevuelveNit(idnit);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
