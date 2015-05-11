////*********************************************************
//
//    <copyright file="ubicacionc.cs" company="Marketing Software de Colombia LTDA">
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
    /// Clase de ubicacion en capa de datos
    /// </summary>
    public class Ubicacionc
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ubicacionc"/> class.
        /// </summary>
        public Ubicacionc()
        {
        }

        /// <summary>
        /// Cargar pais.
        /// </summary>
        /// <returns>lista de paises que se encuentran en la tabla pais de la bd</returns>
        public List<pais> CargarPais()
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.pais;
                    if (query.Count() > 0)
                    {
                        return query.OrderBy(p => p.nombrepais).ToList();
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

        /// <summary>
        /// Cargar los departamentos respectivos al identificador del pais
        /// </summary>
        /// <param name="idpais">identificador del pais</param>
        /// <returns>lista de departamentos que se encuentran en la tabla pais de la bd</returns>
        public List<departamento> CargarDpto(int idpais)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.departamento.Where(dep => dep.pais.idpais == idpais);
                    if (query.Count() > 0)
                    {
                        return query.OrderBy(d => d.nombredept).ToList();
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

        /// <summary>
        /// Cargar ciudad
        /// </summary>
        /// <param name="iddepto">identificador del departamento</param>
        /// <returns>lista de departamentos que se encuentran en la tabla pais de la bd</returns>
        public List<ciudad> CargarCiudad(int iddepto)
        {
                       using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.ciudad.Where(ciu => ciu.codigodepto == iddepto);
                    if (query.Count() > 0)
                    {
                        return query.OrderBy(c => c.nombreciudad).ToList();
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

        public bool ValidaDepto(int iddepto,string idpais)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.departamento.Where(dep => dep.pais.codpais == idpais && dep.iddept == iddepto);
                    if (query.Count() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ValidaCiudad(int ciudad, int depto)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.ciudad.Where(dep => dep.idciudad == ciudad && dep.codigodepto == depto);
                    if (query.Count() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
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
