////*********************************************************
//
//    <copyright file="conexionn.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 01 marzo 2014
//    </copyright>
//
////*********************************************************
namespace Negocios.General
{
    using System;
    using Datos.General;
    using Entities;
    using Entities.Types;

    /// <summary>
    /// Clase conexion
    /// </summary>
    public class Conexionn
    {
        /// <summary>
        /// instancia capa de datos
        /// </summary>
        private Conexionc persistencia;

        /// <summary>
        /// Initializes a new instance of the <see cref="Conexionn"/> class.
        /// </summary>
        public Conexionn()
        {
            this.persistencia = new Conexionc();
        }

        /// <summary>
        /// Guardar la conexion
        /// </summary>
        /// <param name="conexi">la conexion a guardar</param>
        /// <returns>la conexion guardada </returns>
        public ConexionDataSource GuardarConexion(conexuser conexi)
        {
            ConexionDataSource conusu = new ConexionDataSource();
            try
            {
                var item = this.persistencia.GuardarConexion(conexi);
                conusu.Iduser = item.idusuario;
                conusu.Compania = item.idcompania;
                conusu.Fechacon = item.fechaconex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return conusu;
        }
    }
}
