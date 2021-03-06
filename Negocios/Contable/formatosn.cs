﻿////*********************************************************
//
//    <copyright file="formatosn.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 26 febrero 2015
//    </copyright>
//
////*********************************************************

namespace Negocios.Contable
{
    using System;
    using System.Collections.Generic;
    using Datos.Contable;
    using Entities;
    using Entities.Types;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Formatosn
    {
        private Formatosc persistencia;

        private Cuentac persistenciaCuenta;

        public Formatosn()
        {
            this.persistencia = new Formatosc();
            this.persistenciaCuenta = new Cuentac();
        }

        public bool GuardarFormato(FormatoDataSource formato, string encabezado)
        {
            formatosbpyg forma = new formatosbpyg();
            forma.tipoformato = formato.TipoFormato;
            forma.nombref = formato.Nombre;
            forma.clasemayor = formato.ClaseCuenta;
            forma.linea = formato.Linea;
            forma.cuentaini = this.persistenciaCuenta.DevolverId(formato.CuentaInicial);
            forma.cuentafin = this.persistenciaCuenta.DevolverId(formato.CuentaFinal);
            try
            {
                return this.persistencia.Guardarformato(forma, encabezado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ExisteFormato(FormatoDataSource formato)
        {
            formatosbpyg forma = new formatosbpyg();
            forma.tipoformato = formato.TipoFormato;
            forma.nombref = formato.Nombre;
            forma.clasemayor = formato.ClaseCuenta;
            forma.linea = formato.Linea;
            forma.cuentaini = this.persistenciaCuenta.DevolverId(formato.CuentaInicial);
            forma.cuentafin = this.persistenciaCuenta.DevolverId(formato.CuentaFinal);
            try
            {
                return this.persistencia.ExisteFormato(forma);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public FormatoDataSource DevolverFormato(string tipo, string clase, string linea)
        {
            FormatoDataSource formato = new FormatoDataSource();
            try
            {
                var items = this.persistencia.DevolverFormato(tipo, clase, linea);
                if (items != null)
                {
                    formato.TipoFormato = items.tipoformato;
                    formato.ClaseCuenta = items.clasemayor;
                    formato.Linea = items.linea;
                    formato.Nombre = items.nombref;
                    formato.CuentaInicial = this.persistenciaCuenta.DevolverCuenta(items.cuentaini);
                    formato.CuentaFinal = this.persistenciaCuenta.DevolverCuenta(items.cuentafin);
                }
                else
                {
                    formato = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return formato;
        }

        public string DevolverEncabezado(int tipoencabezado)
        {
            try
            {
                return this.persistencia.DevolverEncabezado(tipoencabezado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ActualizarFormato(FormatoDataSource formato, string encabezado)
        {
            formatosbpyg forma = new formatosbpyg();
            forma.tipoformato = formato.TipoFormato;
            forma.nombref = formato.Nombre;
            forma.clasemayor = formato.ClaseCuenta;
            forma.linea = formato.Linea;
            forma.cuentaini = this.persistenciaCuenta.DevolverId(formato.CuentaInicial);
            forma.cuentafin = this.persistenciaCuenta.DevolverId(formato.CuentaFinal);
            try
            {
                return this.persistencia.ActualizarFormato(forma, encabezado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<FormatoDataSourceShow> Busqueda(string tipo, string buscar, string forma)
        {
            List<FormatoDataSourceShow> formato = new List<FormatoDataSourceShow>();
            try
            {
                var items = this.persistencia.Busqueda(tipo, buscar, forma);
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        FormatoDataSourceShow format = new FormatoDataSourceShow();
                        format.Nombre = item.nombref;
                        format.ClaseCuenta = item.clasemayor;
                        format.Linea = item.linea;
                        format.CuentaInicial =this.persistenciaCuenta.DevolverCuenta( item.cuentaini);
                        format.CuentaFinal = this.persistenciaCuenta.DevolverCuenta(item.cuentafin);
                        formato.Add(format);
                    }
                }
                else
                {
                    formato = this.FormatoNull();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return formato;
        }

        private List<FormatoDataSourceShow> FormatoNull()
        {
            List<FormatoDataSourceShow> cuenta = new List<FormatoDataSourceShow>();
            FormatoDataSourceShow ds = new FormatoDataSourceShow();
            ds.Nombre = null;
            ds.Linea = null;
            ds.ClaseCuenta = null;
            ds.CuentaFinal = null;
            ds.CuentaInicial = null;
            cuenta.Add(ds);
            return cuenta;
        }

        public bool EliminarFormato(string clase, string linea, string tipof)
        {
            try
            {
                return this.persistencia.EliminarFormato(clase, linea, tipof);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<FormatoDataSourceShow> CargarInforme(string tipofor)
        {
            List<FormatoDataSourceShow> formato = new List<FormatoDataSourceShow>();
            try
            {
                var items = this.persistencia.CargarInforme(tipofor);
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        FormatoDataSourceShow format = new FormatoDataSourceShow();
                        format.Nombre = item.nombref;
                        format.ClaseCuenta = item.clasemayor;
                        format.Linea = item.linea;
                        format.CuentaInicial = this.persistenciaCuenta.DevolverCuenta(item.cuentaini);
                        format.CuentaFinal = this.persistenciaCuenta.DevolverCuenta(item.cuentafin);
                        formato.Add(format);
                    }
                }
                else
                {
                    formato = this.FormatoNull();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return formato;
        }
    }
}
