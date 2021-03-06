﻿////*********************************************************
//
//    <copyright file="ubicacionn.cs" company="Marketing Software de Colombia LTDA">
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
    using Entities.Types;

    /// <summary>
    /// Clase de Ubicacion
    /// </summary>
    public class Ubicacionn
    {
        /// <summary>
        /// instancia capa de datos
        /// </summary>
        private Ubicacionc persistencia;

        /// <summary>
        /// Initializes a new instance of the <see cref="Ubicacionn"/> class.
        /// </summary>
        public Ubicacionn()
        {
            this.persistencia = new Ubicacionc();
        }

        /// <summary>
        /// Cargars the pais.
        /// </summary>
        /// <returns>Lista Paises</returns>
        public List<PaisDataSource> CargarPais()
        {
            List<PaisDataSource> paises = new List<PaisDataSource>();
            try
            {
                var items = this.persistencia.CargarPais();
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        PaisDataSource pais = new PaisDataSource();
                        pais.Idpais = item.idpais;
                        pais.Nombrepais = item.nombrepais;
                        paises.Add(pais);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return paises;
        }

        /// <summary>
        /// Cargars the deptos.
        /// </summary>
        /// <param name="idpais">The idpais.</param>
        /// <returns>lista de departamentos</returns>
        public List<DeptoDataSource> CargarDeptos(int idpais)
        {
            List<DeptoDataSource> deptos = new List<DeptoDataSource>();
            try
            {
                var items = this.persistencia.CargarDpto(idpais);
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        DeptoDataSource depto = new DeptoDataSource();
                        depto.Idpais = item.idpais;
                        depto.CodigDedpto = item.codigodepto;
                        depto.Iddpto = item.iddept;
                        depto.Nombredpto = item.nombredept;
                        deptos.Add(depto);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return deptos;
        }

        /// <summary>
        /// load ciudad info
        /// </summary>
        /// <param name="iddepto">id departamento</param>
        /// <returns>list of cities</returns>
        public List<CiudadDataSource> CargarCiudad(int iddepto)
        {
            List<CiudadDataSource> ciudades = new List<CiudadDataSource>();
            try
            {
                var items = this.persistencia.CargarCiudad(iddepto);
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        CiudadDataSource ciuds = new CiudadDataSource();
                        ciuds.Idciudad = item.idciudad;
                        ciuds.Iddpto = item.codigodepto;
                        ciuds.CodigCiudad = item.codigociudad;
                        ciuds.Nombreciudad = item.nombreciudad;
                        ciudades.Add(ciuds);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ciudades;
        }

        public bool ValidaDepto(int iddepto, string idpais)
        {
            try
            {
                return this.persistencia.ValidaDepto(iddepto, idpais);
            }
            catch (Exception ex)
            {
                throw ex;  
            }
        }

        public bool ValidaCiudad(int ciudad, int depto)
        {
            try
            {
                return this.persistencia.ValidaCiudad(ciudad,depto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
