﻿// -----------------------------------------------------------------------
// <copyright file="ConceptoPago.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Negocios.Cartera
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Datos.Cartera;
    using Entities;
    using Entities.Types;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ConceptoPagoN
    {
        private ConceptoPagoD persistencia;

        public ConceptoPagoN()
        {
            this.persistencia = new ConceptoPagoD();
        }

       /* public List<ConceptoPagoDataSource> CargarConcePago()
        {
            List<ConceptoPagoDataSource> conpa = new List<ConceptoPagoDataSource>();
            try
            {
                var items = this.persistencia.CargarConcePago();
                foreach (var item in items)
                {
                    ConceptoPagoDataSource conpago = new ConceptoPagoDataSource();
                    conpago.CodigoConPa = item.idconceptospago;
                    conpago.NombreConPa = item.descripconcep;
                    conpago.Cuenta = item.cuenta;
                    conpago.CodigoForma = item.codformaspago;
                    conpago.Porcentaje = item.porcentaje;
                    conpago.NombreForma = item.formaspago.nombreforma;
                    conpago.NombreCuenta = item.maeconta.nombre;
                    conpa.Add(conpago);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return conpa;
        }


       /* public bool ExisteConPago(string codigo)
        {
            bool existe = false;
            try
            {
                existe = this.persistencia.ExisteConPago(codigo);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return existe;
        }*/

       /* public bool GuardoConPago(ConceptoPagoDataSource conpago)
        {
            bool guardo = false;
            conceptospagos conpa = new conceptospagos();
            conpa.idconceptospago = conpago.CodigoConPa;
            conpa.descripconcep = conpago.NombreConPa;
            conpa.cuenta = conpago.Cuenta;
            conpa.codformaspago = conpago.CodigoForma;
            conpa.porcentaje = conpago.Porcentaje;

            try
            {
                guardo = this.persistencia.GuardoConPago(conpa);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return guardo;
        }*/

     /*   public bool ActualizarConPago(ConceptoPagoDataSource conpago)
        {
            bool guardo = false;
            conceptospagos conpa = new conceptospagos();
            conpa.idconceptospago = conpago.CodigoConPa;
            conpa.descripconcep = conpago.NombreConPa;
            conpa.cuenta = conpago.Cuenta;
            conpa.codformaspago = conpago.CodigoForma;
            conpa.porcentaje = conpago.Porcentaje;

            try
            {
                guardo = this.persistencia.ActualizarConPago(conpa);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return guardo;
        }*/

      /*  public ConceptoPagoDataSource DevolverConPago(string id)
        {
            ConceptoPagoDataSource conpago = new ConceptoPagoDataSource();
            try
            {
                var item = this.persistencia.DevolverConPago(id);
                conpago.CodigoConPa = item.idconceptospago;
                conpago.NombreConPa = item.descripconcep;
                conpago.Cuenta = item.cuenta;
                conpago.CodigoForma = item.codformaspago;
                conpago.Porcentaje = item.porcentaje;
                conpago.NombreForma = item.formaspago.nombreforma;
                conpago.NombreCuenta = item.maeconta.nombre;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return conpago;
        }

        public bool EliminarConPa(string id)
        {
            bool elimina = false;
            try
            {
                elimina = this.persistencia.EliminaConPa(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return elimina;
        }

        public List<ConceptoPagoDataSource> BuscarConPa(string buscar)
        {
            List<ConceptoPagoDataSource> conpa = new List<ConceptoPagoDataSource>();
            try
            {
                var items = this.persistencia.BuscarConPa(buscar);
                foreach (var item in items)
                {
                    ConceptoPagoDataSource conpago = new ConceptoPagoDataSource();
                    conpago.CodigoConPa = item.idconceptospago;
                    conpago.NombreConPa = item.descripconcep;
                    conpago.Cuenta = item.cuenta;
                    conpago.CodigoForma = item.codformaspago;
                    conpago.Porcentaje = item.porcentaje;
                    conpago.NombreForma = item.formaspago.nombreforma;
                    conpago.NombreCuenta = item.maeconta.nombre;
                    conpa.Add(conpago);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return conpa;
        }*/
    }
}
