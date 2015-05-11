////*********************************************************
//
//    <copyright file="empresac.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 01 marzo 2014
//    </copyright>
//
////*********************************************************
namespace Datos.General
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entities;

    /// <summary>
    /// Clase empresa capa Datos
    /// </summary>
    public class Empresac
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Empresac"/> class.
        /// </summary>
        public Empresac()
        {
        }

        /// <summary>
        /// Cargar empresa
        /// </summary>
        /// <returns>lista de las empresas que se encuentran en la tabla</returns>
        public List<compania> CargarEmpresa()
        {
            using (siimnEntities bd = new siimnEntities())
            {
                List<compania> compania = new List<compania>();
                try
                {
                    compania = bd.compania.ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return compania;
            }
        }

        /// <summary>
        /// Existe empresa
        /// </summary>
        /// <param name="id">identificador de la empresa</param>
        /// <returns>booleano que rectifica si existe o no la empresa</returns>
        public bool ExisteEmpresa(int id)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                var query = 0;
                bool result;
                try
                {
                    query = bd.compania.Where(com => com.idcompania == id).Count();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                if (query == 0)
                {
                    result = false;
                }
                else
                {
                    result = true;
                }

                return result;
            }
        }

        /// <summary>
        /// crear la empresa
        /// </summary>
        /// <param name="compa">empresa a crear</param>
        /// <returns>empresa que ha sido creada</returns>
        public compania CreateEmpresa(compania compa)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    compania co = new compania();
                    co.idcompania = compa.idcompania;
                    co.nombrecia = compa.nombrecia;
                    bd.compania.Add(co);
                    bd.SaveChanges();
                    compa.idcompania = co.idcompania;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return compa;
        }

        /// <summary>
        /// actualiza la empresa.
        /// </summary>
        /// <param name="compa">empresa a actualizar</param>
        /// <returns>empresa que ha sido actualizada</returns>
        public compania UpdateEmpresa(compania compa)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.compania.Where(com => com.idcompania == compa.idcompania).First();
                    query.idcompania = compa.idcompania;
                    query.nombrecia = compa.nombrecia;
                    bd.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return compa;
        }

        /// <summary>
        /// Devolver empresa
        /// </summary>
        /// <param name="empresa">nombre de empresa</param>
        /// <returns>identificador de la empresa</returns>
        public int DevolverEmpresa(string empresa)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                int idcompa;
                try
                {
                    var query = bd.compania.Where(com => com.nombrecia == empresa).First();
                    idcompa = query.idcompania;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return idcompa;
            }
        }

        public string DevolverNombre(int empresa)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                string nombre;
                try
                {
                    var query = bd.compania.Where(com => com.idcompania == empresa).Count();
                    if (query > 0)
                    {
                        var query2 = bd.compania.Where(com => com.idcompania == empresa).First();
                        nombre = query2.nombrecia;
                    }
                    else
                    {
                        nombre = "MARKETING SOFTWARE DE COLOMBIA LTDA";
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return nombre;
            }
        }

        public sucursal DevolverDatosEmpresa(int empresa)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.sucursal.Include("compania").Include("ciudad").Where(suc => suc.idsucursal == empresa);
                    if (query.Count() > 0)
                    {
                        return query.First();
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
