﻿////*********************************************************
//
//    <copyright file="nitsc.cs" company="Marketing Software de Colombia LTDA">
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
    using System.Data.Entity.Infrastructure;

    /// <summary>
    /// Clase de nits en capa de datos
    /// </summary>
    public class Nitsc
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Nitsc"/> class.
        /// </summary>
        public Nitsc()
        {
        }

        /// <summary>
        /// Cargar nits
        /// </summary>
        /// <returns>lista de nits que se encuentra en la bd</returns>
        public List<maenits> CargarNits()
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.maenits.Include("tiponit").Include("ciudad");
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

        /// <summary>
        /// Guardar nits
        /// </summary>
        /// <param name="nits">nit a guardar</param>
        public bool GuardarNits(maenits nits)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    maenits nit = new maenits();
                    nit.nit = nits.nit;
                    nit.digito = nits.digito;
                    nit.idtiponit = nits.idtiponit;
                    nit.nombrenit = nits.nombrenit;
                    nit.acteconomic = nits.acteconomic;
                    nit.idciudad = nits.idciudad;
                    nit.direccion = nits.direccion;
                    nit.telefono = nits.telefono;
                    nit.celular = nits.celular;
                    nit.email = nits.email;
                    bd.maenits.Add(nit);
                    bd.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        /// Devolver nit
        /// </summary>
        /// <param name="idnit">identificador del nit</param>
        /// <returns>nit respectivo al identificador</returns>
        public maenits DevolverNit(string nit)
        {
            maenits nits = new maenits();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.maenits.Include("tiponit").Include("ciudad")
                        .Include("ciudad.departamento.pais").Include("ciudad.departamento")
                        .Where(mae => mae.nit == nit);
                    if (query.Count() > 0)
                    {
                        nits = query.First();
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
            }

            return nits;
        }

        /// <summary>
        /// Actualizar nit
        /// </summary>
        /// <param name="nit">nit a actualizar</param>
        public bool ActualizarNit(maenits nit)
        {
            bool result = false;
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.maenits.Where(mae => mae.nit == nit.nit);
                    if (query.Count() > 0)
                    {
                        query.First().digito = nit.digito;
                        query.First().nombrenit = nit.nombrenit;
                        query.First().acteconomic = nit.acteconomic;
                        query.First().idciudad = nit.idciudad;
                        query.First().direccion = nit.direccion;
                        query.First().telefono = nit.telefono;
                        query.First().celular = nit.celular;
                        query.First().email = nit.email;
                        bd.SaveChanges();
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return result;
        }

        /// <summary>
        /// Existe nit
        /// </summary>
        /// <param name="nits">nit a actualizar</param>
        /// <returns>booleano que rectifia si existe el nit</returns>
        public bool ExisteNit(string nits)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.maenits.Where(nit => nit.nit == nits);
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

        /// <summary>
        /// Eliminar nit
        /// </summary>
        /// <param name="idnit">el identificador del nit</param>
        /// <returns>booleano que rectifica si se elimina el registro</returns>
        public bool EliminarNit(string nit)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.maenits.Where(mae => mae.nit == nit);
                    if (query.Count() > 0)
                    {
                        bd.maenits.Remove(query.First());
                        bd.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                catch (DbUpdateException ex)
                {
                    throw new SystemException("ESTA OPERACION NO SE PUDO REALIZAR", ex.InnerException);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public string DevolverNombre(string idnit)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.maenits.Where(mae => mae.nit == idnit);
                    if (query.Count() > 0)
                    {
                        return query.First().nombrenit;
                    }
                    else
                        return string.Empty;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public int? DevolverId(string nit)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.maenits.Where(mae => mae.nit == nit);
                    if (query.Count() > 0)
                    {
                        return query.First().idnit;
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
        /// Buscar nit
        /// </summary>
        /// <param name="buscar">texto a buscar dentro de la tabla nit</param>
        /// <returns>registros que contienen el texto a buscar</returns>
        public List<maenits> BuscarNit(string buscar)
        {
            List<maenits> nits = new List<maenits>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.maenits.Include("tiponit")
                                           .Include("pais")
                                           .Include("departamento")
                                           .Include("ciudad")
                                           .Where(mae => mae.nit.Contains(buscar)
                                                              || mae.nombrenit.Contains(buscar));
                    if (query.Count() > 0)
                    {
                        nits = query.ToList();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return nits;
        }

        public List<maenits> Busqueda(string tipo, string buscar)
        {
            List<maenits> nits = new List<maenits>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    switch (tipo)
                    {
                        case "nit":
                            var query = bd.maenits.Include("tiponit").Include("ciudad.departamento.pais").Include("ciudad.departamento").Include("ciudad")
                                                   .OrderBy(mae => mae.nit).Where(mae => mae.nit.Contains(buscar));
                            nits = query.Count() > 0 ? query.ToList() : null;
                            break;

                        case "nombre":
                            var query1 = bd.maenits.Include("tiponit").Include("ciudad.departamento.pais").Include("ciudad.departamento").Include("ciudad")
                                                    .OrderBy(mae => mae.nit).Where(mae => mae.nombrenit.Contains(buscar));
                            nits = query1.Count() > 0 ? query1.ToList() : null;
                            break;

                        case "pais":
                            var query2 = bd.maenits.Include("tiponit").Include("ciudad.departamento.pais").Include("ciudad.departamento").Include("ciudad")
                                                    .OrderBy(mae => mae.nit).Where(mae => mae.ciudad.departamento.pais.nombrepais.Contains(buscar));
                            nits = query2.Count() > 0 ? query2.ToList() : null;
                            break;

                        case "departamento":
                            var query3 = bd.maenits.Include("tiponit").Include("ciudad.departamento.pais").Include("ciudad.departamento").Include("ciudad")
                                                    .OrderBy(mae => mae.nit).Where(mae => mae.ciudad.departamento.nombredept.Contains(buscar));
                            nits = query3.Count() > 0 ? query3.ToList() : null;
                            break;

                        case "ciudad":
                            var query4 = bd.maenits.Include("tiponit").Include("ciudad.departamento.pais").Include("ciudad.departamento").Include("ciudad")
                                                    .OrderBy(mae => mae.nit).Where(mae => mae.ciudad.nombreciudad.Contains(buscar));
                            nits = query4.Count() > 0 ? query4.ToList() : null;
                            break;

                        case "busqueda":
                            var query5 = bd.maenits.Include("tiponit").Include("ciudad.departamento.pais").Include("ciudad.departamento").Include("ciudad")
                                                    .OrderBy(mae => mae.nit).Where(mae => mae.nit.Contains(buscar) || mae.nombrenit.Contains(buscar)
                                                                            || mae.ciudad.departamento.pais.nombrepais.Contains(buscar) || mae.ciudad.departamento.nombredept.Contains(buscar)
                                                                            || mae.ciudad.nombreciudad.Contains(buscar));
                            nits = query5.Count() > 0 ? query5.ToList() : null;
                            break;

                        case "todos":
                            nits = bd.maenits.Count() > 0 ? bd.maenits.Include("tiponit").Include("ciudad.departamento.pais").Include("ciudad.departamento").Include("ciudad").OrderBy(mae => mae.nit).ToList() : null;
                            break;

                        default:
                            nits = null;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return nits;
            }
        }

        public List<maenits> CargarNitsReportesNombre()
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.maenits.Include("tiponit").Include("ciudad").Include("ciudad.departamento").Include("ciudad.departamento.pais");
                    if (query.Count() > 0)
                    {
                        return query.OrderBy(mae => mae.nombrenit).ToList();
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

        public List<maenits> CargarNitsReportesNumero()
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.maenits.Include("tiponit").Include("ciudad").Include("ciudad.departamento").Include("ciudad.departamento.pais");
                    if (query.Count() > 0)
                    {
                        return query.OrderBy(mae => mae.nit).ToList();
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

        public int DevolverIdTipo(string codigotipo)
        {
            
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.tiponit.Where(tip => tip.codigtiponit == codigotipo);
                    if (query.Count() > 0)
                    {
                        return query.First().idtiponit;
                    }
                    else
                    {
                        return 0;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public string DevuelveNit(int? idnit)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.maenits.Where(mae => mae.idnit == idnit);
                    if (query.Count() > 0)
                    {
                        return query.First().nit;
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<int> DevolverIdsEntre(string nitini, string nitfin)
        {
            List<int> ids = new List<int>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.maenits.Where(mae => mae.nit.CompareTo(nitini) >= 0 && mae.nit.CompareTo(nitfin) < 0);
                    if (query.Count() > 0)
                    {
                        foreach (var item in query)
                        {
                            int id = new int();
                            id = item.idnit;
                            ids.Add(id);
                        }
                    }
                    else
                    {
                        ids = null;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return ids;
        }

        public List<int> DevolverTodosIds()
        {
            List<int> ids = new List<int>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.maenits;
                    if (query.Count() > 0)
                    {
                        foreach (var item in query.ToList())
                        {
                            int id = new int();
                            id = item.idnit;
                            ids.Add(id);
                        }
                    }
                    else
                    {
                        ids = null;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return ids;
        }
    }

}
