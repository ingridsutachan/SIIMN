////*********************************************************
//
//    <copyright file="tiponitc.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 01 marzo 2014
//    </copyright>
//
////*********************************************************
namespace Datos.Contable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entities;

    /// <summary>
    /// Clase tipo nit de capa de datos
    /// </summary>
    public class Tiponitc
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tiponitc"/> class.
        /// </summary>
        public Tiponitc()
        {
        }

        /// <summary>
        /// Devolver tipo nit
        /// </summary>
        /// <returns>lista de nits que existen en la tabla de la bd</returns>
        public List<tiponit> DevolverTipo()
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.tiponit;
                    if (query.Count() > 0)
                    {
                        return query.ToList();
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
        }
    }
}
