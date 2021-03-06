﻿////*********************************************************
//
//    <copyright file="centroc.cs" company="Marketing Software de Colombia LTDA">
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
    /// Clase centro capa de datos
    /// </summary>
    public class Centroc
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Centroc"/> class.
        /// </summary>
        public Centroc()
        {
        }

        /// <summary>
        /// Cargar centro
        /// </summary>
        /// <returns>Lista de registros que se encuentran en la tabla de la db</returns>
        public List<centrocostos> CargarCentro()
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.centrocostos;
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
        /// Guardar centro
        /// </summary>
        /// <param name="cent">centro de costos a guardar</param>
        public bool GuardarCentro(centrocostos cent)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    bd.centrocostos.Add(cent);
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
        /// <param name="idcentro">identificador de centro </param>
        /// <returns>centro respectivo al identificador</returns>
        public centrocostos DevolverDatos(int idcentro)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.centrocostos.Where(cen => cen.idcentro == idcentro);
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
        /// Actualizar centro
        /// </summary>
        /// <param name="cent">centro de costos a actualizar</param>
        public bool ActualizarCentro(centrocostos cent)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.centrocostos.Where(cen => cen.idcentro == cent.idcentro);
                    if (query.Count() > 0)
                    {
                        query.First().nombrecentro = cent.nombrecentro;
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
        /// Eliminar centro
        /// </summary>
        /// <param name="idcentro">identificador de centro a eliminar</param>
        /// <returns>booleano que rectifica si se elimina el centro</returns>
        public bool EliminarCentro(int idcentro)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.centrocostos.Where(cen => cen.idcentro == idcentro);
                    if (query.Count() > 0)
                    {
                        bd.centrocostos.Remove(query.First());
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

        public bool ExisteCentro(int campo)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.centrocostos.Where(cen => cen.idcentro == campo);
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

        public string DevolverNombre(int codcentro)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.centrocostos.Where(cen => cen.idcentro == codcentro);
                    if (query.Count() > 0)
                    {
                        return query.First().nombrecentro;
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

        public List<centrocostos> Busqueda(string tipo, string buscar)
        {
            List<centrocostos> centrobusq = new List<centrocostos>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    switch (tipo)
                    {
                        case "codigo":
                            var query = bd.centrocostos.OrderBy(com => com.idcentro).AsEnumerable().Where(cen => cen.idcentro.ToString().Contains(buscar));
                            centrobusq = query.Count() > 0 ? query.ToList() : null;
                            break;

                        case "nombre":
                            var query1 = bd.centrocostos.OrderBy(com => com.idcentro).Where(cen => cen.nombrecentro.Contains(buscar));
                            centrobusq = query1.Count() > 0 ? query1.ToList() : null;
                            break;

                        case "busqueda":
                            var query3 = bd.centrocostos.AsEnumerable().OrderBy(cen => cen.idcentro).Where(cen => cen.idcentro.ToString().Contains(buscar) || cen.nombrecentro.Contains(buscar));
                            centrobusq = query3.Count() > 0 ? query3.ToList() : null;
                            break;

                        case "todos":
                            centrobusq = bd.centrocostos.Count() > 0 ? bd.centrocostos.AsEnumerable().OrderBy(com => com.idcentro).ToList() : null;
                            break;

                        default:
                            centrobusq = null;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return centrobusq;
        }

        public bool ValidarComproEliminar(int idcentro)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.movimi.Where(mov => mov.idcentro == idcentro);
                    var query2 = bd.acucentr.Where(acu => acu.idcentro == idcentro);
                    var query3 = bd.presupuesto.Where(pre => pre.idcentro == idcentro);
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

        public List<centrocostos> CargarInforme()
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.centrocostos;
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
