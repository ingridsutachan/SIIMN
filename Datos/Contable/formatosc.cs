﻿////*********************************************************
//
//    <copyright file="formatosc.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 26 febrero 2015
//    </copyright>
//
////*********************************************************

namespace Datos.Contable
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Text;
    using Entities;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Formatosc
    {
        public Formatosc()
        {
        }

        public bool Guardarformato(formatosbpyg format, string encabezado)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    if (format.tipoformato.Equals("1"))
                    {
                        var query = bd.formatosbpyg.Where(frm => frm.idformato == 1);
                        if (query.Count() > 0)
                        {
                            query.First().nombref = encabezado;
                        }
                    }
                    else
                    {
                        var query = bd.formatosbpyg.Where(frm => frm.idformato == 2);
                        if (query.Count() > 0)
                        {
                            query.First().nombref = encabezado;
                        }
                    }

                    bd.formatosbpyg.Add(format);
                    bd.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ExisteFormato(formatosbpyg format)
        {
                        using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.formatosbpyg.Where(frm => frm.tipoformato == format.tipoformato && frm.clasemayor == format.clasemayor && frm.linea == format.linea);
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

        public formatosbpyg DevolverFormato(string tipo, string clase, string linea)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.formatosbpyg.Include("maeconta").Where(frm => frm.tipoformato == tipo && frm.clasemayor == clase && frm.linea == linea);
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

        public string DevolverEncabezado(int tipo)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.formatosbpyg.Where(frm => frm.idformato == tipo);
                    if (query.Count() > 0)
                    {
                        return query.First().nombref;
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

        public bool ActualizarFormato(formatosbpyg format, string encabezado)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    if (format.tipoformato.Equals("1"))
                    {
                        var query = bd.formatosbpyg.Where(frm => frm.idformato == 1);
                        if (query.Count() > 0)
                        {
                            query.First().nombref = encabezado;
                        }
                    }

                    if (format.tipoformato.Equals("2"))
                    {
                        var query = bd.formatosbpyg.Where(frm => frm.idformato == 2);
                        if (query.Count() > 0)
                        {
                            query.First().nombref = encabezado;
                        }
                    }

                    var query1 = bd.formatosbpyg.Where(frm => frm.clasemayor == format.clasemayor && frm.linea == format.linea && frm.tipoformato == format.tipoformato);
                    if (query1.Count() > 0)
                    {
                        query1.First().nombref = format.nombref;
                        query1.First().cuentaini = format.cuentaini;
                        query1.First().cuentafin = format.cuentafin;
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

        public List<formatosbpyg> Busqueda(string tipo, string buscar, string forma)
        {
                 int idformato = int.Parse(forma);
            List<formatosbpyg> formabusq = new List<formatosbpyg>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    switch (tipo)
                    {
                        case "nombre":
                            var query = bd.formatosbpyg.OrderBy(frm => new { frm.clasemayor, frm.linea }).Where(frm => frm.tipoformato == forma
                                           && frm.idformato != idformato && frm.nombref.Contains(buscar));
                            formabusq = query.Count() > 0 ? query.ToList() : null;
                            break;

                        case "busqueda":
                            var query3 = bd.formatosbpyg.OrderBy(frm => new { frm.clasemayor, frm.linea }).Where(frm => frm.tipoformato == forma
                                                           && frm.idformato != idformato && frm.nombref.Contains(buscar));
                            formabusq = query3.Count() > 0 ? query3.ToList() : null;
                            break;

                        case "todos":
                            var query1 = bd.formatosbpyg.Where(frm => frm.tipoformato == forma && frm.idformato != idformato);
                            if (query1.Count() > 0)
                            {
                                formabusq = query1.OrderBy(frm => new { frm.clasemayor, frm.linea }).ToList();
                            }
                            else
                            {
                                formabusq = null;
                            }

                            break;

                        default:
                            formabusq = null;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return formabusq;
        }

        public List<formatosbpyg> CargarInforme(string tipofor)
        {
                int idformato = int.Parse(tipofor);
            List<formatosbpyg> formabusq = new List<formatosbpyg>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.formatosbpyg.Where(frm => frm.tipoformato == tipofor && frm.idformato != idformato);
                    if (query.Count() > 0)
                    {
                        formabusq = query.ToList();
                    }
                    else
                    {
                        formabusq = null;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return formabusq;
        }

        public bool EliminarFormato(string clase, string linea, string tipof)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.formatosbpyg.Where(frm => frm.clasemayor == clase && frm.linea == linea && frm.tipoformato == tipof);
                    if (query.Count() > 0)
                    {
                        bd.formatosbpyg.Remove(query.First());
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
    }
}
