﻿////*********************************************************
//
//    <copyright file="comprobantesn.cs" company="Marketing Software de Colombia LTDA">
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
    using Entities;
    using Entities.Types;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Comprobantesn
    {
        /// <summary>
        /// instancia para la capa de datos
        /// </summary>
        private Comprobantesc persistencia;

        /// <summary>
        /// Initializes a new instance of the <see cref="Comprobantesn"/> class.
        /// </summary>
        public Comprobantesn()
        {
            this.persistencia = new Comprobantesc();
        }

        private List<ComprobantesDataSource> ConvertirEntityaDataSource(List<comprobante> comprob)
        {
            List<ComprobantesDataSource> compro = new List<ComprobantesDataSource>();
            foreach (var item in comprob)
            {
                ComprobantesDataSource comp = new ComprobantesDataSource();
                comp.Codigo = item.codigcomprob;
                comp.Descricompro = item.descripcomprob;
                comp.Consecutivo = item.consecutivo;
                comp.Numerosigui = item.numsiguiente;
                comp.Codigootra = item.codigootra;
                compro.Add(comp);
            }
            return compro;
        }
        /// <summary>
        /// Cargar datos
        /// </summary>
        /// <returns>Lista de comprobantes que se encuentra en la tabla de la bd</returns>
        public List<ComprobantesDataSource> CargarDatos()
        {
            List<comprobante> items = new List<comprobante>();
            try
            {
                items = this.persistencia.CargarComprobantes();
                if (items.Count > 0)
                {
                    return this.ConvertirEntityaDataSource(items);
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
        /// Guardar comprobante 
        /// </summary>
        /// <param name="comprobante">el comprobante a guardar</param>
        public bool GuardarComp(ComprobantesDataSource comprobante)
        {
            comprobante compro = new comprobante();
            compro.codigcomprob = comprobante.Codigo;
            compro.descripcomprob = comprobante.Descricompro;
            compro.codigootra = comprobante.Codigootra;
            compro.consecutivo = comprobante.Consecutivo;
            compro.numsiguiente = comprobante.Numerosigui;
            try
            {
                return this.persistencia.GuardarComprob(compro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Devolver datos
        /// </summary>
        /// <param name="idcomp">identificador de comprobante</param>
        /// <returns>comprante respectivo</returns>
        public ComprobantesDataSource DevolverDatos(int idcomp)
        {
            ComprobantesDataSource compr = new ComprobantesDataSource();
            try
            {
                var item = this.persistencia.DevolverDatos(idcomp);
                if (item != null)
                {
                    compr.Codigo = item.codigcomprob;
                    compr.Descricompro = item.descripcomprob;
                    compr.Consecutivo = item.consecutivo;
                    compr.Numerosigui = item.numsiguiente;
                    compr.Codigootra = item.codigootra;
                }
                else
                {
                    compr = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return compr;
        }

        /// <summary>
        /// Actualizar comprobante
        /// </summary>
        /// <param name="comp">comprobante a actualizar</param>
        public bool ActualizarCompro(ComprobantesDataSource comprobante)
        {
            comprobante compro = new comprobante();
            compro.codigcomprob = comprobante.Codigo;
            compro.descripcomprob = comprobante.Descricompro;
            compro.codigootra = comprobante.Codigootra;
            compro.consecutivo = comprobante.Consecutivo;
            compro.numsiguiente = comprobante.Numerosigui;
            try
            {
                return this.persistencia.ActualizaCompr(compro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Eliminar comprobante
        /// </summary>
        /// <param name="idcompro">identificador del comprobante a eliminar</param>
        /// <returns>booleano que rectifica si se elimino el comprobante</returns>
        public bool EliminarCompro(int idcompro)
        {
            try
            {
                return this.persistencia.EliminarCompro(idcompro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ExisteComprobante(int id)
        {
            try
            {
                return this.persistencia.ExisteComprobante(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ComprobantesDataSourceShow> Busqueda(string tipo, string buscar)
        {
            try
            {
                var items = this.persistencia.Busqueda(tipo, buscar);
                if (items != null)
                {
                    List<ComprobantesDataSourceShow> compro = new List<ComprobantesDataSourceShow>();
                    foreach (var item in items)
                    {
                        ComprobantesDataSourceShow comp = new ComprobantesDataSourceShow();
                        comp.Codigo = item.codigcomprob;
                        comp.Descricompro = item.descripcomprob;
                        comp.Consecutivo = item.consecutivo;
                        comp.Numerosigui = item.numsiguiente;
                        comp.Codigootra = item.codigootra;
                        compro.Add(comp);
                    }
                    return compro;
                }
                else
                {
                    return this.ComprobanteNull();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<ComprobantesDataSourceShow> ComprobanteNull()
        {
            List<ComprobantesDataSourceShow> comproban = new List<ComprobantesDataSourceShow>();
            ComprobantesDataSourceShow ds = new ComprobantesDataSourceShow();
            ds.Codigo = null;
            ds.Descricompro = null;
            ds.Consecutivo = false;
            ds.Numerosigui = null;
            ds.Codigootra = null;
            comproban.Add(ds);
            return comproban;
        }

        public List<ComprobantesDataSourceShow> CargarInforme()
        {
            try
            {
                var items = this.persistencia.CargarInforme();
                if (items != null)
                {
                    List<ComprobantesDataSourceShow> compro = new List<ComprobantesDataSourceShow>();
                    foreach (var item in items)
                    {
                        ComprobantesDataSourceShow comp = new ComprobantesDataSourceShow();
                        comp.Codigo = item.codigcomprob;
                        comp.Descricompro = item.descripcomprob;
                        comp.Consecutivo = item.consecutivo;
                        comp.Numerosigui = item.numsiguiente;
                        comp.Codigootra = item.codigootra;
                        compro.Add(comp);
                    }
                    return compro;
                }
                else
                {
                    return this.ComprobanteNull();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string DevolverNombre(int codcomp)
        {
            try
            {
                return this.persistencia.DevolverNombre(codcomp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EsConsecutivo(int codigocomp)
        {
            try
            {
                return this.persistencia.EsConsecutivo(codigocomp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
