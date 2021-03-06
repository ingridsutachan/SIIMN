﻿////*********************************************************
//
//    <copyright file="tributariosc.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 26 febrero 2015
//    </copyright>
//
////*********************************************************
namespace Datos.Contable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Entities;
    using System.Data.Entity.Infrastructure;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Tributariosc
    {
        public Tributariosc()
        {
        }

        public List<maetribut> CargarTributario()
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.maetribut;
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

        public bool GuardarTribut(maetribut tribut)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    bd.maetribut.Add(tribut);
                    bd.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public maetribut DevolverDatos(string codigo)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.maetribut.Where(tip => tip.codigotrib == codigo);
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

        public bool ActualizarTribut(maetribut tribut)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.maetribut.Where(mae => mae.codigotrib == tribut.codigotrib);
                    if (query.Count() > 0)
                    {
                        query.First().codigotrib = tribut.codigotrib;
                        query.First().nombre = tribut.nombre;
                        query.First().tope = tribut.tope;
                        query.First().idnittope = tribut.idnittope;
                        bd.SaveChanges();
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

        public bool EliminarTributario(string codigo)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.maetribut.Where(mae => mae.codigotrib == codigo);
                    if (query.Count() > 0)
                    {
                        bd.maetribut.Remove(query.First());
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

        public bool ExisteTributario(string codigtrib)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.maetribut.Where(mat => mat.codigotrib == codigtrib);
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

        public List<maetribut> Busqueda(string tipo, string buscar)
        {
            List<maetribut> tributbusque = new List<maetribut>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    switch (tipo)
                    {
                        case "codigo":
                            var query = bd.maetribut.Include("maenits").OrderBy(mat => mat.codigotrib).Where(mat => mat.codigotrib.Contains(buscar));
                            tributbusque = query.Count() > 0 ? query.ToList() : null;
                            break;

                        case "nombre":
                            var query1 = bd.maetribut.Include("maenits").OrderBy(mat => mat.codigotrib).Where(mat => mat.nombre.Contains(buscar));
                            tributbusque = query1.Count() > 0 ? query1.ToList() : null;
                            break;

                        case "busqueda":
                            var query3 = bd.maetribut.Include("maenits").OrderBy(mat => mat.codigotrib).Where(mat => mat.codigotrib.Contains(buscar) || mat.nombre.Contains(buscar));
                            tributbusque = query3.Count() > 0 ? query3.ToList() : null;
                            break;

                        case "todos":
                            var query4 = bd.maetribut.Include("maenits");
                            if (query4.Count() > 0)
                            {
                                tributbusque = query4.OrderBy(mat => mat.codigotrib).ToList();
                            }
                            break;

                        default:
                            tributbusque = null;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return tributbusque;
        }

        public List<maetribut> CargarInforme()
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.maetribut;
                    if (query.Count() > 0)
                    {
                        return query.Include("maenits").ToList();
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
