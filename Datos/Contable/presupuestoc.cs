﻿////*********************************************************
//
//    <copyright file="presupuestoc.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 01 marzo 2014
//    </copyright>
//
////*********************************************************
namespace Datos.Contable
{
    using System;
    using System.Collections.Generic;
    using System.Data.Objects.SqlClient;
    using System.Linq;
    using Entities;

    /// <summary>
    /// Clase presupuesto de capa de datos
    /// </summary>
    public class Presupuestoc
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Presupuestoc"/> class.
        /// </summary>
        public Presupuestoc()
        {
        }

        /// <summary>
        /// Devuelve el presupuesto
        /// </summary>
        /// <param name="anio">año de presupuesto</param>
        /// <param name="cuenta">cuenta de presupuesto</param>
        /// <returns>lista de presupuesto respectivo al año y a la cuenta</returns>
        public List<presupuesto> DevuelvePres(string anio, string cuenta, int centro, int idsucursal)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.presupuesto.Include("maeconta").Include("centrocostos")
                                               .Where(pre => pre.anio == anio && pre.maeconta.cuenta == cuenta
                                                            && pre.idcentro == centro && pre.idsucursal == idsucursal);
                    if (query.Count() > 0)
                    {
                        return query.OrderBy(pre => pre.mes).ToList();
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
        /// Guardar presupuesto
        /// </summary>
        /// <param name="presu">presupuesto a guardar</param>
        public bool GuardarPre(List<presupuesto> presu)
        {
            bool result = false;
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    foreach (presupuesto item in presu)
                    {
                        bd.presupuesto.Add(item);
                        bd.SaveChanges();
                        result = true;
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
        /// Actualiza presupuesto
        /// </summary>
        /// <param name="presu">presupuesto a actualizar</param>
        public bool UpdatePresup(List<presupuesto> presu)
        {
            bool result = false;
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    foreach (presupuesto item in presu)
                    {
                        var query = bd.presupuesto.Where(pre => pre.anio == item.anio && pre.cuenta == item.cuenta && pre.mes == item.mes &&
                                                                 pre.idsucursal == item.idsucursal && pre.idcentro == item.idcentro);
                        if (query.Count() > 0)
                        {
                            query.First().cantidad = item.cantidad;
                            bd.SaveChanges();
                            result = true;
                        }
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
        /// Eliminar presupuesto
        /// </summary>
        /// <param name="anio">año de presupuesto</param>
        /// <param name="cuenta">cuenta de presupuesto</param>
        /// <returns>booleano si se elimina el presupuesto</returns>
        public bool EliminarPresu(string anio, string cuenta, int idcentro, int idsucursal)
        {
            bool result = false;
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.presupuesto.Where(pre => pre.anio == anio && pre.maeconta.cuenta
                                                    == cuenta && pre.idcentro == idcentro && pre.idsucursal == idsucursal);
                    if (query.Count() > 0)
                    {
                        foreach (var item in query.ToList())
                        {
                            bd.presupuesto.Remove(item);
                        }
                    }

                    bd.SaveChanges();
                    result = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return result;
        }

        public bool ExistePresupuesto(string anio, string cuenta, int centro, int idsucursal)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.presupuesto.Where(pre => pre.anio == anio && pre.maeconta.cuenta
                                                            == cuenta && pre.idcentro == centro && pre.idsucursal == idsucursal);
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

        public List<presupuesto> Busqueda(string tipo, string buscar)
        {
            List<presupuesto> presupbus = new List<presupuesto>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    switch (tipo)
                    {
                        case "año":
                            var query = bd.presupuesto.Include("maeconta").OrderBy(pre => new { pre.cuenta, pre.anio, pre.idcentro, pre.mes }).Where(pre => pre.anio.Contains(buscar));
                            presupbus = query.Count() > 0 ? query.ToList() : null;
                            break;

                        case "cuenta":
                            var query1 = bd.presupuesto.Include("maeconta").OrderBy(pre => new { pre.cuenta, pre.anio, pre.idcentro, pre.mes }).Where(pre => pre.maeconta.cuenta.Contains(buscar));
                            presupbus = query1.Count() > 0 ? query1.ToList() : null;
                            break;

                        case "centro":
                            var query2 = bd.presupuesto.Include("maeconta").OrderBy(pre => new { pre.cuenta, pre.anio, pre.idcentro, pre.mes }).AsEnumerable().Where(pre => pre.idcentro.ToString().Contains(buscar));
                            presupbus = query2.Count() > 0 ? query2.ToList() : null;
                            break;

                        case "busqueda":
                            var query3 = bd.presupuesto.Include("maeconta").OrderBy(pre => new { pre.cuenta, pre.anio, pre.idcentro, pre.mes }).AsEnumerable().Where(pre => pre.anio.Contains(buscar) || pre.maeconta.cuenta.Contains(buscar) || pre.idcentro.ToString().Contains(buscar));
                            if (query3.Count() > 0)
                            {
                                presupbus = query3.ToList();
                            }
                            else
                            {
                                presupbus = null;
                            }

                            break;

                        case "todos":
                            presupbus = bd.presupuesto.Count() > 0 ? bd.presupuesto.Include("maeconta").OrderBy(pre => new { pre.cuenta, pre.anio, pre.idcentro, pre.mes }).ToList() : null;
                            break;

                        default:
                            presupbus = null;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return presupbus;
        }
    }
}
