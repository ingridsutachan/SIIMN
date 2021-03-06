﻿////*********************************************************
//
//    <copyright file="cuentac.cs" company="Marketing Software de Colombia LTDA">
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
    using MySql.Data.MySqlClient;
    using System.Data.Entity.Infrastructure;

    /// <summary>
    /// Clase cuenta de capa de datos
    /// </summary>
    public class Cuentac
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cuentac"/> class.
        /// </summary>
        public Cuentac()
        {
        }

        /// <summary>
        /// Cargar cuenta
        /// </summary>
        /// <returns>lista de las cuentas que se encuentran en la tabla cuenta</returns>
        public List<maeconta> CargarCuenta()
        {
            using (siimnEntities bd = new siimnEntities())
            {
                List<maeconta> cuenta = new List<maeconta>();
                try
                {
                    var query = bd.maeconta.Include("maenits").Include("formatomedios");
                    if (query.Count() > 0)
                    {
                        cuenta = query.ToList();
                    }
                    else
                    {
                        cuenta = null;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return cuenta;
            }
        }

        /// <summary>
        /// Existe cuenta
        /// </summary>
        /// <param name="id">identificador de cuenta</param>
        /// <returns>booleano que rectifica si la cuenta existe</returns>
        public bool ExisteCuenta(string id)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.maeconta.Where(cue => cue.cuenta == id);
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
        /// Devuelve datos
        /// </summary>
        /// <param name="id">identificador de la cuenta</param>
        /// <returns>devuelve la cuenta que es respetiva al identificador</returns>
        public maeconta DevuelveDatos(string id)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                maeconta datos = new maeconta();
                try
                {
                    var query = bd.maeconta.Include("maenits").Include("formatomedios").Include("maeconta2").Where(cue => cue.cuenta == id);
                    if (query.Count() > 0)
                    {
                        datos = query.First();
                    }
                    else
                    {
                        datos = null;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return datos;
            }
        }

        /// <summary>
        /// Crea  cuenta
        /// </summary>
        /// <param name="cuenta">cuenta a crear</param>
        /// <returns>cuenta que ha sido creada</returns>
        public bool GuardarCuenta(maeconta cuenta)
        {
            try
            {
                using (siimnEntities bd = new siimnEntities())
                {
                    bd.maeconta.Add(cuenta);
                    bd.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Actualiza la cuenta.
        /// </summary>
        /// <param name="cuenta">cuenta a actualizar</param>
        /// <returns>cuenta que ha sido actualizada </returns>
        public bool ActualizarCuenta(maeconta cuenta)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.maeconta.Where(cue => cue.cuenta == cuenta.cuenta);
                    if (query.Count() > 0)
                    {
                        query.First().tipocta = cuenta.tipocta;
                        query.First().nombre = cuenta.nombre;
                        query.First().pidenit = cuenta.pidenit;
                        query.First().centro = cuenta.centro;
                        query.First().ajustesinteg = cuenta.ajustesinteg;
                        query.First().idnitajustes = cuenta.idnitajustes;
                        query.First().cueaju = cuenta.cueaju;
                        query.First().cuencorre = cuenta.cuencorre;
                        query.First().ajudoc = cuenta.ajudoc;
                        query.First().retencion = cuenta.retencion;
                        query.First().porete = cuenta.porete;
                        query.First().conceprete = cuenta.conceprete;
                        query.First().reteica = cuenta.reteica;
                        query.First().poreteica = cuenta.poreteica;
                        query.First().concepreteica = cuenta.concepreteica;
                        query.First().formatomedios = cuenta.formatomedios;
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
        /// Elimina cuenta
        /// </summary>
        /// <param name="id">identificador de la cuenta</param>
        /// <returns>booleano que rectifica si la cuenta ha sido eliminada</returns>
        public bool EliminarCuenta(string id)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.maeconta.Where(mae => mae.cuenta == id);
                    if (query.Count() > 0)
                    {
                        bd.maeconta.Remove(query.First());
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

        public string DevolverNombre(string codigo)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                string nombre;
                try
                {
                    var query = bd.maeconta.Where(mae => mae.cuenta == codigo);
                    if (query.Count() > 0)
                    {
                        nombre = query.First().nombre;
                    }
                    else
                    {
                        nombre = string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return nombre;
            }
        }

        public string DevolverTipoCuenta(string cuenta)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                string tipo;
                try
                {
                    var query = bd.maeconta.Where(mae => mae.cuenta == cuenta);
                    if (query.Count() > 0)
                    {
                        tipo = query.First().tipocta;
                    }
                    else
                    {
                        tipo = string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return tipo;
            }
        }

        public List<maeconta> Busqueda(string tipo, string buscar)
        {
            List<maeconta> cuentabus = new List<maeconta>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    switch (tipo)
                    {
                        case "numero cuenta":
                            var query = bd.maeconta.Include("maenits").Include("formatomedios").Include("maeconta2")
                                                    .Include("maeconta3").Include("maeconta4").OrderBy(ved => ved.cuenta).Where(ved => ved.cuenta.Contains(buscar));
                            cuentabus = query.Count() > 0 ? query.ToList() : null;
                            break;

                        case "nombre":
                            var query1 = bd.maeconta.Include("maenits").Include("formatomedios").Include("maeconta2")
                                        .Include("maeconta3").Include("maeconta4").OrderBy(ved => ved.cuenta).Where(ved => ved.nombre.Contains(buscar));
                            cuentabus = query1.Count() > 0 ? query1.ToList() : null;
                            break;

                        case "tipo cuenta":
                            var query2 = bd.maeconta.Include("maenits").Include("formatomedios").Include("maeconta2")
                                .Include("maeconta3").Include("maeconta4").OrderBy(ved => ved.cuenta).Where(ved => ved.tipocta.Contains(buscar));
                            cuentabus = query2.Count() > 0 ? query2.ToList() : null;
                            break;

                        case "busqueda":
                            var query3 = bd.maeconta.Include("maenits").Include("formatomedios").Include("maeconta2")
                                         .Include("maeconta3").Include("maeconta4").OrderBy(ved => ved.cuenta).Where(ved => ved.cuenta.Contains(buscar) || ved.nombre.Contains(buscar) || ved.tipocta.Contains(buscar));
                            cuentabus = query3.Count() > 0 ? query3.ToList() : null;
                            break;

                        case "todos":
                            cuentabus = bd.maeconta.Count() > 0 ? bd.maeconta.Include("maenits").Include("formatomedios").Include("maeconta2")
                                        .Include("maeconta3").Include("maeconta4").OrderBy(ved => ved.cuenta).ToList() : null;
                            break;

                        case "auxiliar":
                            var query4 = bd.maeconta.Include("maenits").Include("formatomedios").Include("maeconta2")
                                 .Include("maeconta3").Include("maeconta4").OrderBy(ved => ved.cuenta).Where(ved => ved.tipocta == "A");
                            cuentabus = query4.Count() > 0 ? query4.ToList() : null;
                            break;

                        case "busquedaaux":
                            var query5 = bd.maeconta.Include("maenits").Include("formatomedios").Include("maeconta2")
                                         .Include("maeconta3").Include("maeconta4").OrderBy(ved => ved.cuenta).Where(ved => ved.tipocta == "A" && (ved.cuenta.Contains(buscar) || ved.nombre.Contains(buscar) || ved.tipocta.Contains(buscar)));
                            cuentabus = query5.Count() > 0 ? query5.ToList() : null;
                            break;

                        case "numero cuentaaux":
                            var query6 = bd.maeconta.Include("maenits").Include("formatomedios").Include("maeconta2")
                                                    .Include("maeconta3").Include("maeconta4").OrderBy(ved => ved.cuenta).Where(ved => ved.tipocta == "A" && ved.cuenta.Contains(buscar));
                            cuentabus = query6.Count() > 0 ? query6.ToList() : null;
                            break;

                        case "nombreaux":
                            var query7 = bd.maeconta.Include("maenits").Include("formatomedios").Include("maeconta2")
                                        .Include("maeconta3").Include("maeconta4").OrderBy(ved => ved.cuenta).Where(ved => ved.tipocta == "A" && ved.nombre.Contains(buscar));
                            cuentabus = query7.Count() > 0 ? query7.ToList() : null;
                            break;

                        case "tipo cuentaaux":
                            var query8 = bd.maeconta.Include("maenits").Include("formatomedios").Include("maeconta2")
                                .Include("maeconta3").Include("maeconta4").OrderBy(ved => ved.cuenta).Where(ved => ved.tipocta == "A" && ved.tipocta.Contains(buscar));
                            cuentabus = query8.Count() > 0 ? query8.ToList() : null;
                            break;

                        default:
                            cuentabus = null;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return cuentabus;
        }

        public List<maeconta> CargarInforme(string cuentainicial, string cuentafinal)
        {
            List<maeconta> informe = new List<maeconta>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    if ("**".Equals(cuentainicial) && "**".Equals(cuentafinal))
                    {
                        var query = bd.maeconta.Include("maenits");
                        if (query.Count() > 0)
                        {
                            informe = query.ToList();
                        }
                        else
                        {
                            informe = null;
                        }
                    }
                    else
                    {
                        var query = bd.maeconta.Include("maenits").Where(mae => string.Compare(mae.cuenta, cuentainicial) >= 0 && string.Compare(mae.cuenta, cuentafinal) <= 0);
                        if (query.Count() > 0)
                        {
                            informe = query.ToList();
                        }
                        else
                        {
                            informe = null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return informe;
        }

        public bool TieneRetencion(string cuenta)
        {
            bool result = false;
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.maeconta.Where(mae => mae.cuenta == cuenta);
                    if (query.Count() > 0)
                    {
                        result = query.First().retencion;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return result;
        }

        public bool TieneReteIca(string cuenta)
        {
            bool result = false;
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.maeconta.Where(mae => mae.cuenta == cuenta);
                    if (query.Count() > 0)
                    {
                        result = query.First().reteica;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return result;
        }

        public int? DevolverId(string cuenta)
        {
            try
            {
                using (siimnEntities bd = new siimnEntities())
                {
                    var query = bd.maeconta.Where(mae => mae.cuenta == cuenta);
                    if (query.Count() > 0)
                    {
                        return query.First().idcuenta;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string DevolverCuenta(int? idcuenta)
        {
            try
            {
                using (siimnEntities bd = new siimnEntities())
                {
                    var query = bd.maeconta.Where(mae => mae.idcuenta == idcuenta);
                    if (query.Count() > 0)
                    {
                        return query.First().cuenta;
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<saldoscuentas> DevolverSaldos(List<int> idcuenta, string aniotrabajo, int idsucursal)
        {
            List<saldoscuentas> cuentatot = new List<saldoscuentas>();
            List<saldoscuentas> cuentauno = new List<saldoscuentas>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    foreach (int item in idcuenta)
                    {
                        var query = bd.saldoscuentas.Where(sal => sal.cuenta == item && sal.anio == aniotrabajo && sal.idsucursal == idsucursal);
                        if (query.Count() > 0)
                        {

                            foreach (var queryun in query.ToList())
                            {
                                saldoscuentas sald = new saldoscuentas();
                                sald.anio = queryun.anio;
                                sald.credimes = queryun.credimes;
                                sald.cuenta = queryun.cuenta;
                                sald.debimes = queryun.debimes;
                                sald.idsaldoscuentas = queryun.idsaldoscuentas;
                                sald.idsucursal = queryun.idsucursal;
                                sald.mes = queryun.mes;
                                sald.saldomes = queryun.saldomes;
                                cuentauno.Add(sald);
                            }
                        }
                    }
                    if (cuentauno.Count() > 0)
                    {
                        foreach (saldoscuentas item in cuentauno.OrderBy(dev => dev.cuenta).ToList())
                        {
                            saldoscuentas salcuenta = new saldoscuentas();

                            var cuenta2 = cuentatot.Where(cue => cue.mes == item.mes);
                            if (cuenta2.Count() > 0)
                            {
                                cuenta2.First().saldomes = cuenta2.First().saldomes + item.saldomes;
                                cuenta2.First().credimes = cuenta2.First().credimes + item.credimes;
                                cuenta2.First().debimes = cuenta2.First().debimes + item.debimes;
                            }
                            else
                            {
                                salcuenta.anio = item.anio;
                                salcuenta.mes = item.mes;
                                salcuenta.cuenta = item.cuenta;
                                salcuenta.saldomes = salcuenta.saldomes + item.saldomes;
                                salcuenta.credimes = salcuenta.credimes + item.credimes;
                                salcuenta.debimes = salcuenta.debimes + item.debimes;
                                cuentatot.Add(salcuenta);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return cuentatot;
            }
        }

        public List<saldoscuentas> DevolverSaldoAnio(int? cuenta, string anio)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.saldoscuentas.Where(sal => sal.cuenta == cuenta && sal.anio == anio);
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

        public List<int> DevolverIds(string cuenta)
        {
            List<int> ids = new List<int>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.maeconta.Where(mae => mae.cuenta.Contains(cuenta));
                    if (query.Count() > 0)
                    {

                        foreach (var item in query)
                        {
                            ids.Add(item.idcuenta);
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

                return ids;
            }
        }

        public List<int> DevolverIdsEntre(string cuentaini, string cuentafin)
        {
            List<int> ids = new List<int>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.maeconta.Where(mae => mae.cuenta.CompareTo(cuentaini) >= 0 && mae.cuenta.CompareTo(cuentafin) < 0);
                    if (query.Count() > 0)
                    {
                        foreach (var item in query)
                        {
                            int id = new int();
                            id = item.idcuenta;
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
                    var query = bd.maeconta;
                    if (query.Count() > 0)
                    {
                        foreach (var item in query.ToList())
                        {
                            int id = new int();
                            id = item.idcuenta;
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
