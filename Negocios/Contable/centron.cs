////*********************************************************
//
//    <copyright file="centron.cs" company="Marketing Software de Colombia LTDA">
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
    /// Clase centro capa de negocios
    /// </summary>
    public class Centron
    {
        /// <summary>
        /// instacia la capa de datos 
        /// </summary>
        private Centroc persistencia;

        /// <summary>
        /// Initializes a new instance of the <see cref="Centron"/> class.
        /// </summary>
        public Centron()
        {
            this.persistencia = new Centroc();
        }

        /// <summary>
        /// Cargar centro
        /// </summary>
        /// <returns>lista de los centro de costos encontrados en la tabla de la db</returns>
        public List<CentroDataSource> CargarCentro()
        {
            List<CentroDataSource> centro = new List<CentroDataSource>();
            try
            {
                var items = this.persistencia.CargarCentro();
                if (items.Count > 0)
                {
                    foreach (var item in items)
                    {
                        CentroDataSource cen = new CentroDataSource();
                        cen.Codcentro = item.idcentro;
                        cen.Nombrecentro = item.nombrecentro;
                        centro.Add(cen);
                    }
                }
                else
                {
                    centro = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return centro;
        }

        /// <summary>
        /// Guardar centro.
        /// </summary>
        /// <param name="cent">centro de costos a guardar</param>
        public bool GuardarCentro(CentroDataSource cent)
        {
            centrocostos centro = new centrocostos();
            centro.idcentro = cent.Codcentro;
            centro.nombrecentro = cent.Nombrecentro;
            try
            {
                return this.persistencia.GuardarCentro(centro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Devolver datos
        /// </summary>
        /// <param name="idcentro">identificador de centro a devolver datos</param>
        /// <returns>centro respectivo al identificador de centro</returns>
        public CentroDataSource DevolverDatos(int idcentro)
        {
            CentroDataSource centr = new CentroDataSource();
            try
            {
                var item = this.persistencia.DevolverDatos(idcentro);
                if (item != null)
                {
                    centr.Codcentro = item.idcentro;
                    centr.Nombrecentro = item.nombrecentro;
                }
                else
                {
                    centr = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return centr;
        }

        /// <summary>
        /// Actualizar centro
        /// </summary>
        /// <param name="cent">centro de costos a actualizar</param>
        public bool ActualizarCentro(CentroDataSource cent)
        {
            centrocostos centro = new centrocostos();
            centro.idcentro = cent.Codcentro;
            centro.nombrecentro = cent.Nombrecentro;
            try
            {
                return this.persistencia.ActualizarCentro(centro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Eliminar centro
        /// </summary>
        /// <param name="idcentro">identificador de centro de costos a eliminar</param>
        /// <returns>booleano que rectifica si se elimino el centro</returns>
        public bool EliminarCentro(int idcentro)
        {
            try
            {
                return this.persistencia.EliminarCentro(idcentro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ExisteCentro(int campo)
        {
            try
            {
                return this.persistencia.ExisteCentro(campo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string DevolverNombre(int codcentro)
        {
            try
            {
                return this.persistencia.DevolverNombre(codcentro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CentroDataSourceShow> Busqueda(string tipo, string buscar)
        {
            List<CentroDataSourceShow> centro = new List<CentroDataSourceShow>();
            try
            {
                var items = this.persistencia.Busqueda(tipo, buscar);
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        CentroDataSourceShow centr = new CentroDataSourceShow();
                        centr.Codcentro = item.idcentro;
                        centr.Nombrecentro = item.nombrecentro;
                        centro.Add(centr);
                    }
                }
                else
                {
                    CentroDataSourceShow centr = new CentroDataSourceShow();
                    centr.Codcentro = null;
                    centr.Nombrecentro = null;
                    centro.Add(centr);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return centro;
        }

             public List<CentroDataSourceShow> CargarInforme()
        {
            List<CentroDataSourceShow> centro = new List<CentroDataSourceShow>();
            try
            {
                var items = this.persistencia.CargarInforme();
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        CentroDataSourceShow centr = new CentroDataSourceShow();
                        centr.Codcentro = item.idcentro;
                        centr.Nombrecentro = item.nombrecentro;
                        centro.Add(centr);
                    }
                }
                else
                {
                    CentroDataSourceShow centr = new CentroDataSourceShow();
                    centr.Codcentro = null;
                    centr.Nombrecentro = null;
                    centro.Add(centr);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return centro;
        }
    }
}
