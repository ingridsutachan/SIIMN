// -----------------------------------------------------------------------
// <copyright file="FormatorcN.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Negocios.Cartera
{
    using System;
    using System.Collections.Generic;
    using Datos.Cartera;
    using Entities;
    using Entities.Types;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class FormatorcN
    {
        private FormatorcD persistencia;

        public FormatorcN()
        {
            this.persistencia = new FormatorcD();
        }

        public bool ExisteFormato(int formato)
        {
            bool existe = false;
            try
            {
                existe = this.persistencia.ExisteFormato(formato);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return existe;
        }

        public bool GuardoFormato(List<FormatorcDataSource> formato)
        {
            bool guardo = false;
            try
            {
                List<formato> formarc = new List<formato>();
                foreach (FormatorcDataSource item in formato)
                {
                    formato formar = new formato();
                    formar.codigofor = item.CodigoFormato;
                    //formar.nombrefor = item.NombreFormato;
                    formar.fila = item.Fila;
                    formar.columna = item.Columna;
                    formar.condensa = item.Condensa;
                    formar.presentacion = item.Presentacion;
                    formar.titulo = item.Titulo;
                    formarc.Add(formar);
                }

                guardo = this.persistencia.GuardoFormato(formarc);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return guardo;
        }

        public List<FormatorcDataSource> DevolverFormato(int format)
        {
            List<FormatorcDataSource> formato = new List<FormatorcDataSource>();
            try
            {
                var items = this.persistencia.DevolverFormato(format);
                foreach (var item in items)
                {
                    FormatorcDataSource form = new FormatorcDataSource();
                    form.CodigoFormato = item.codigofor;
                   // form.NombreFormato = item.nombrefor;
                    form.Fila = item.fila;
                    form.Columna = item.columna;
                    form.Condensa = item.condensa;
                    form.Presentacion = item.presentacion;
                    form.Titulo = item.titulo;
                    formato.Add(form);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return formato;
        }

        public bool ActualizoFormato(List<FormatorcDataSource> formato)
        {
            bool guardo = false;
            try
            {
                List<formato> formarc = new List<formato>();
                foreach (FormatorcDataSource item in formato)
                {
                    formato formar = new formato();
                    formar.codigofor = item.CodigoFormato;
                    //formar.nombrefor = item.NombreFormato;
                    formar.fila = item.Fila;
                    formar.columna = item.Columna;
                    formar.condensa = item.Condensa;
                    formar.presentacion = item.Presentacion;
                    formar.titulo = item.Titulo;
                    formarc.Add(formar);
                }

                //guardo = this.persistencia.ActualizoFormato(formarc);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return guardo;
        }
    }
}
