﻿////*********************************************************
//
//    <copyright file="Parametrosc.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 02 marzo 2015
//    </copyright>
//
////*********************************************************

namespace Datos.General
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Entities;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Parametrosc
    {
        public Parametrosc()
        {
        }

        public List<parametro> CargarDatosComprobante()
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.parametro.Where(par => (par.nombreparametro == "cueniniing" || par.nombreparametro == "cuenfining" || par.nombreparametro == "cueninicos"
                        || par.nombreparametro == "cuenfincos" || par.nombreparametro == "cuenuti" || par.nombreparametro == "codcomp" || par.nombreparametro == "descomp"));
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

        public bool GuardarDatosComprobante(List<parametro> param)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.parametro.Where(par => par.nombreparametro == "cueniniing").First();
                    query.valorparam = param[0].valorparam;
                    var query1 = bd.parametro.Where(par => par.nombreparametro == "cuenfining").First();
                    query1.valorparam = param[1].valorparam;
                    var query2 = bd.parametro.Where(par => par.nombreparametro == "cueninicos").First();
                    query2.valorparam = param[2].valorparam;
                    var query3 = bd.parametro.Where(par => par.nombreparametro == "cuenfincos").First();
                    query3.valorparam = param[3].valorparam;
                    var query4 = bd.parametro.Where(par => par.nombreparametro == "cuenuti").First();
                    query4.valorparam = param[4].valorparam;
                    var query5 = bd.parametro.Where(par => par.nombreparametro == "codcomp").First();
                    query5.valorparam = param[5].valorparam;
                    var query6 = bd.parametro.Where(par => par.nombreparametro == "descomp").First();
                    query6.valorparam = param[6].valorparam;
                    bd.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<parametro> CargarDatosAsiento()
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.parametro.Where(par => par.nombreparametro == "cuentacaja" || par.nombreparametro == "cuentarete" || par.nombreparametro == "cuentaica"
                        || par.nombreparametro == "cuentainteres" || par.nombreparametro == "cuentacomis" || par.nombreparametro == "cuentadto" || par.nombreparametro == "cuentacheq"
                        || par.nombreparametro == "2cheque" || par.nombreparametro == "2retenc" || par.nombreparametro == "cuentasocio");
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

        public bool GuardarDatosAsiento(List<parametro> param)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.parametro.Where(par => par.nombreparametro == "cuentacaja").First();
                    query.valorparam = param[0].valorparam;
                    var query1 = bd.parametro.Where(par => par.nombreparametro == "cuentarete").First();
                    query1.valorparam = param[1].valorparam;
                    var query2 = bd.parametro.Where(par => par.nombreparametro == "cuentaica").First();
                    query2.valorparam = param[2].valorparam;
                    var query3 = bd.parametro.Where(par => par.nombreparametro == "cuentainteres").First();
                    query3.valorparam = param[3].valorparam;
                    var query4 = bd.parametro.Where(par => par.nombreparametro == "cuentacomis").First();
                    query4.valorparam = param[4].valorparam;
                    var query5 = bd.parametro.Where(par => par.nombreparametro == "cuentadto").First();
                    query5.valorparam = param[5].valorparam;
                    var query6 = bd.parametro.Where(par => par.nombreparametro == "cuentacheq").First();
                    query6.valorparam = param[6].valorparam;
                    var query7 = bd.parametro.Where(par => par.nombreparametro == "2cheque").First();
                    query7.valorparam = param[7].valorparam;
                    var query8 = bd.parametro.Where(par => par.nombreparametro == "2retenc").First();
                    query8.valorparam = param[8].valorparam;
                    var query9 = bd.parametro.Where(par => par.nombreparametro == "cuentasocio").First();
                    query9.valorparam = param[9].valorparam;
                    bd.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public string ActualizarEnLinea()
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.parametro.Where(par => par.nombreparametro == "actlineaasiento");
                    if (query.Count() > 0)
                    {
                        return query.First().valorparam;
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

        public string AnioTrabajo()
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.parametro.Where(par => par.nombreparametro == "aniotrabajar");
                    if (query.Count() > 0)
                    {
                        return query.First().valorparam;
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

        public int MesTrabajo()
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.parametro.Where(par => par.nombreparametro == "mestrabajar");
                    if (query.Count() > 0)
                    {
                        return int.Parse(query.First().valorparam);
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

        public int ComprobanteCierre()
        {
            try
            {
                using (siimnEntities bd = new siimnEntities())
                {
                    var query = bd.parametro.Where(par => par.nombreparametro == "codcomp");
                    if (query.Count() > 0)
                    {
                        return Convert.ToInt32(query.First().valorparam);
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
