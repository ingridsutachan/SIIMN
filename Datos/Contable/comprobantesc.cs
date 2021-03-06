﻿////*********************************************************
//
//    <copyright file="comprobantesc.cs" company="Marketing Software de Colombia LTDA">
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
    using System.Text;
    using Entities;
    using System.Data.Entity.Infrastructure;

    /// <summary>
    /// Clase de comprobantes capa datos
    /// </summary>
    public class Comprobantesc
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Comprobantesc"/> class.
        /// </summary>
        public Comprobantesc()
        {
        }

        /// <summary>
        /// Cargar comprobantes.
        /// </summary>
        /// <returns>lista de los comprobantes en la tabla de la bd</returns>
        public List<comprobante> CargarComprobantes()
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.comprobante;
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
        /// Guardar comprobante
        /// </summary>
        /// <param name="comprob">comprovante a guardar</param>
        public bool GuardarComprob(comprobante comprob)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                comprobante com = new comprobante();
                try
                {
                    com.codigcomprob = comprob.codigcomprob;
                    com.descripcomprob = comprob.descripcomprob;
                    com.consecutivo = comprob.consecutivo;
                    com.numsiguiente = comprob.numsiguiente;
                    com.codigootra = comprob.codigootra;
                    bd.comprobante.Add(com);
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
        /// Devolver datos
        /// </summary>
        /// <param name="idcomp">identificador del comprobante</param>
        /// <returns>comprobante respectivo al identificador</returns>
        public comprobante DevolverDatos(int idcomp)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.comprobante.Where(tip => tip.codigcomprob == idcomp);
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

        /// <summary>
        /// Actualiza el comprobante
        /// </summary>
        /// <param name="comp">comprobante a actualizar</param>
        public bool ActualizaCompr(comprobante comp)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.comprobante.Where(tip => tip.codigcomprob == comp.codigcomprob);
                    if (query.Count() > 0)
                    {
                        query.First().descripcomprob = comp.descripcomprob;
                        query.First().consecutivo = comp.consecutivo;
                        query.First().numsiguiente = comp.numsiguiente;
                        query.First().codigootra = comp.codigootra;
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

        /// <summary>
        /// Eliminar el comprobante
        /// </summary>
        /// <param name="idcompro">identificador de comprobante</param>
        /// <returns>booleano que rectifica si se elimina el compreobante</returns>
        public bool EliminarCompro(int idcompro)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.comprobante.Where(tip => tip.codigcomprob == idcompro);
                    if (query.Count() > 0)
                    {
                        bd.comprobante.Remove(query.First());
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

        public bool ExisteComprobante(int id)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.comprobante.Where(com => com.codigcomprob == id);
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

        public List<comprobante> Busqueda(string tipo, string buscar)
        {
            List<comprobante> comprobusque = new List<comprobante>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    switch (tipo)
                    {
                        case "codigo":
                            var query = bd.comprobante.OrderBy(com => com.codigcomprob).AsEnumerable().Where(com => com.codigcomprob.ToString().Contains(buscar));
                            comprobusque = query.Count() > 0 ? query.ToList() : null;
                            break;

                        case "nombre":
                            var query1 = bd.comprobante.OrderBy(com => com.codigcomprob).Where(com => com.descripcomprob.Contains(buscar));
                            comprobusque = query1.Count() > 0 ? query1.ToList() : null;
                            break;

                        case "busqueda":
                            var query3 = bd.comprobante.AsEnumerable().OrderBy(com => com.codigcomprob).Where(com => com.codigcomprob.ToString().Contains(buscar) || com.descripcomprob.Contains(buscar));
                            comprobusque = query3.Count() > 0 ? query3.ToList() : null;
                            break;

                        case "todos":
                            comprobusque = bd.comprobante.Count() > 0 ? bd.comprobante.AsEnumerable().OrderBy(com => com.codigcomprob).ToList() : null;
                            break;

                        default:
                            comprobusque = null;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return comprobusque;
        }

        public List<comprobante> CargarInforme()
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.comprobante;
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

        public string DevolverNombre(int codcompr)
        {
            using (siimnEntities bd = new siimnEntities())
                try
                {
                    var query = bd.comprobante.Where(com => com.codigcomprob == codcompr);
                    if (query.Count() > 0)
                    {
                        return query.First().descripcomprob;
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

        public bool EsConsecutivo(int codigocomp)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.comprobante.Where(com => com.codigcomprob == codigocomp);
                    if (query.Count() > 0)
                    {
                        return query.First().consecutivo;
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
