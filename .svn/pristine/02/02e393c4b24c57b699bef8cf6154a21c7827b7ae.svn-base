////*********************************************************
//
//    <copyright file="conexionc.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 01 marzo 2014
//    </copyright>
//
////*********************************************************
namespace Datos.General
{
    using System;
    using Entities;

    /// <summary>
    /// Clase Conexion de Datos
    /// </summary>
    public class Conexionc
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Conexionc"/> class.
        /// </summary>
        public Conexionc()
        {
        }

        /// <summary>
        /// Guarda conexion
        /// </summary>
        /// <param name="conex">conexion a guardar</param>
        /// <returns>conexion guardada</returns>
        public conexuser GuardarConexion(conexuser conex)
        {
            conexuser con = new conexuser();

            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    con.idusuario = conex.idusuario;
                    con.idcompania = conex.idcompania;
                    con.fechaconex = conex.fechaconex;
                    con.fechadescon = conex.fechadescon;
                    bd.conexuser.Add(con);
                    bd.SaveChanges();
                    return con;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
