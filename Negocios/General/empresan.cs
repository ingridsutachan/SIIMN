////*********************************************************
//
//    <copyright file="empresan.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 01 marzo 2014
//    </copyright>
//
////*********************************************************
namespace Negocios.General
{
    using System;
    using System.Collections.Generic;
    using Datos.General;
    using Entities;
    using Entities.Types;

    /// <summary>
    /// clase de empresa
    /// </summary>
    public class Empresan
    {
        /// <summary>
        /// instancia capa de datos
        /// </summary>
        private Empresac persistencia;

        /// <summary>
        /// Initializes a new instance of the <see cref="Empresan"/> class.
        /// </summary>
        public Empresan()
        {
            this.persistencia = new Empresac();
        }

        /// <summary>
        /// Cargar empresa.
        /// </summary>
        /// <returns>lista de las empresas que se encuentran en la tabla</returns>
        public List<EmpresaDataSource> CargarEmpresa()
        {
            List<EmpresaDataSource> empresa = new List<EmpresaDataSource>();
            try
            {
                var items = this.persistencia.CargarEmpresa();
                foreach (var item in items)
                {
                    EmpresaDataSource eds = new EmpresaDataSource();
                    eds.Idcompania = item.idcompania;
                    eds.Nombrecia = item.nombrecia;
                    empresa.Add(eds);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return empresa;
        }

        /// <summary>
        /// Verificar empresa.
        /// </summary>
        /// <param name="compa">la empresa a verificar</param>
        /// <returns>booleano que rectifica si la empresa existe o no</returns>
        public bool VerificarEmpresa(compania compa)
        {
            bool result = false;
            try
            {
                result = this.persistencia.ExisteEmpresa(compa.idcompania);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        /// <summary>
        /// guardar la empresa.
        /// </summary>
        /// <param name="compa">empresa a guardar</param>
        /// <returns>empresa que se ha guardado</returns>
        public EmpresaDataSource SaveEmpresa(compania compa)
        {
            EmpresaDataSource empresa = new EmpresaDataSource();
            try
            {
                var item = this.persistencia.CreateEmpresa(compa);
                empresa.Idcompania = item.idcompania;
                empresa.Nombrecia = item.nombrecia;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return empresa;
        }

        /// <summary>
        /// Devolver  empresa
        /// </summary>
        /// <param name="empresa">nombre de la empresa</param>
        /// <returns>id de la empresa que se esta buscando</returns>
        public int DevolverEmpresa(string empresa)
        {
            int idempresa;
            try
            {
                idempresa = this.persistencia.DevolverEmpresa(empresa);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return idempresa;
        }

        public string DevolverNombre(int empresa)
        {
            string nombre ;
            try
            {
                nombre = this.persistencia.DevolverNombre(empresa);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return nombre;
        }

        public EmpresaDataSource DevolverDatosEmpresa(int empresa)
        {
            EmpresaDataSource empresadev = new EmpresaDataSource();
            try
            {
                var item = this.persistencia.DevolverDatosEmpresa(empresa);
                empresadev.Idcompania = item.idsucursal;
                empresadev.Nombrecia = item.compania.nombrecia;
                empresadev.NombreSucursal = item.nombresucursal;
                empresadev.NitCia = item.compania.nit;
                empresadev.DigitoCia = item.compania.digito;
                empresadev.NombreCiudad = item.ciudad.nombreciudad;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return empresadev;
        }
    }
}
