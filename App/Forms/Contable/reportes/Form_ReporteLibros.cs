﻿////*********************************************************
//
//    <copyright file="Form_ReporteLibros.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 14 abril 2015
//    </copyright>
//
////*********************************************************
namespace App.Forms.Contable.Reportes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using Entities.Types;
    using Negocios.Contable;
    using Negocios.General;
    using App.Forms.Contable.Reportes.Types;

    public partial class Form_ReporteLibros : Form
    {
        private Form_LibroMayor form_LibroMayor;

        private string tipo;

        private List<SaldosCuentasDataSource> balance;

        private string fecha;

        private bool encabezado;

        private Empresan negocioEmpresa;

        private Cuentan negocioCuenta;

        private asientosn negocioAsiento;

        private Parametrosn negocioParametro;

        private Form_Auxiliar form_Auxiliar;

        private List<LibroAuxiliarDataSource> libro;

        private bool centro;

        private bool nit;

        private bool totales;

        private DateTime fechai;

        private DateTime fechaf;

        public Form_ReporteLibros()
        {
            InitializeComponent();
        }

        public Form_ReporteLibros(Form_LibroMayor form_LibroMayor, string tipol, List<SaldosCuentasDataSource> balance, string fechal, bool enca)
        {
            // TODO: Complete member initialization
            this.negocioCuenta = new Cuentan();
            this.negocioEmpresa = new Empresan();
            this.negocioAsiento = new asientosn();
            this.negocioParametro = new Parametrosn();
            this.form_LibroMayor = form_LibroMayor;
            this.tipo = tipol;
            this.balance = balance;
            this.fecha = fechal;
            this.encabezado = enca;
            this.InitializeComponent();
            this.GenerarReporte(this.tipo);
        }

        public Form_ReporteLibros(Form_Auxiliar form_Auxiliar, string tipol, List<LibroAuxiliarDataSource> balance, DateTime fechaini, DateTime fechafin, bool centrol, bool nitl, bool totalesl)
        {
            // TODO: Complete member initialization
            this.negocioCuenta = new Cuentan();
            this.negocioEmpresa = new Empresan();
            this.negocioAsiento = new asientosn();
            this.negocioParametro = new Parametrosn();
            this.form_Auxiliar = form_Auxiliar;
            this.tipo = tipol;
            this.libro = balance;
            this.centro = centrol;
            this.nit = nitl;
            this.totales = totalesl;
            this.fechai = fechaini;
            this.fechaf = fechafin;
            this.InitializeComponent();
            this.GenerarReporte(this.tipo);
        }

        #region EVENTOS FORMULARIO

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form_ReporteLibros_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.tipo.Equals("mayor"))
            {
                this.form_LibroMayor.SalirReporte();
            }
        }

        #endregion

        private void GenerarReporte(string cualasi)
        {
            EmpresaDataSource empresa = new EmpresaDataSource();
            List<CuentaDataSource> cuenta = new List<CuentaDataSource>();
            List<SaldosCuentasDataSource> saldos = new List<SaldosCuentasDataSource>();
            saldos = this.balance;
            try
            {
                empresa = this.negocioEmpresa.DevolverDatosEmpresa(Program.compa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRESENTO UN ERROR" + ex.Message, "ERROR", MessageBoxButtons.OK);
            }

            switch (cualasi)
            {
                case "mayor":

                    this.Text = "LIBRO MAYOR";
                    crystal_ReporteInv.Visible = true;
                    List<LibroDiarioDataSourceReports> balanceRe = new List<LibroDiarioDataSourceReports>();
                    if (saldos.Count() > 0)
                    {
                        for (int i = 0; i < saldos.Count(); i++)
                        {
                            LibroDiarioDataSourceReports balanceR = new LibroDiarioDataSourceReports();
                            if (this.encabezado)
                            {
                                balanceR.MesyAnio = "MES : " + saldos[i].Mes + "   AÑO : " + saldos[i].Anio;
                                balanceR.Compania = empresa.Nombrecia + " - " + empresa.NombreSucursal;
                                balanceR.FechaAct = "FECHA: " + this.fecha;
                                balanceR.Titulo = "LIBRO MAYOR ";
                            }
                            else
                            {
                                balanceR.Titulo = null;
                            }

                            balanceR.Cuenta = saldos[i].Cuenta + " " + saldos[i].NombreCuenta;
                            balanceR.SaldoAnteriorDebito = saldos[i].SaldoAnterior > 0 ? saldos[i].SaldoAnterior : 0;
                            balanceR.SaldoAnteriorCredito = saldos[i].SaldoAnterior < 0 ? saldos[i].SaldoAnterior : 0;
                            balanceR.Valorcredito = saldos[i].ValorCredito;
                            balanceR.Valordebito = saldos[i].ValorDebito;
                            balanceR.SaldoActualCredito = saldos[i].SaldoActual < 0 ? saldos[i].SaldoActual : 0;
                            balanceR.SaldoActualDebito = saldos[i].SaldoActual > 0 ? saldos[i].SaldoActual : 0;
                            balanceRe.Add(balanceR);
                        }
                    }

                    ReporteLibroMayor reportelibro = new ReporteLibroMayor();
                    reportelibro.SetDataSource(balanceRe);
                    crystal_ReporteInv.ReportSource = reportelibro;
                    this.Size = new Size(1003, 583);
                    crystal_ReporteInv.Size = new Size(987, 519);
                    break;

                case "anio":

                    List<LibroAuxiliarDataSource> saldos1 = new List<LibroAuxiliarDataSource>();
                    saldos1 = this.libro;
                    this.Text = "LIBRO MAYOR";
                    crystal_ReporteInv.Visible = true;
                    List<LibroAuxiliarDataSourceReports> balanceRl = new List<LibroAuxiliarDataSourceReports>();
                    if (saldos1.Count() > 0)
                    {
                        for (int i = 0; i < saldos1.Count(); i++)
                        {
                            LibroAuxiliarDataSourceReports balanceR = new LibroAuxiliarDataSourceReports();
                            balanceR.Compania = empresa.Nombrecia + " - " + empresa.NombreSucursal;
                            balanceR.FechayHoraAct = "HORA HH:MM:SS " + DateTime.Now.ToShortTimeString() + "   FECHA DE IMPRESIÓN: " + DateTime.Now.ToShortDateString();
                            balanceR.Titulo = "LIBRO AUXILIAR ";
                            balanceR.NitCia = "NIT  " + empresa.NitCia + "-" + empresa.DigitoCia;
                            balanceR.FechasEntre = "DEL DD/MM/YYY : " + fechai.ToString() + "AL  " + fechaf.ToString();
                            balanceR.Totales = this.totales == true ? null : "NOTOTALES";
                            if (this.nit)
                            {
                                List<SaldosNitsDataSource> nitssaldos = new List<SaldosNitsDataSource>();
                                balanceR.Cuenta = saldos1[i].Cuenta;
                                try
                                {
                                    nitssaldos = this.negocioAsiento.SaldosNits(saldos1[i].Cuenta, saldos1[i].Anio, saldos1[i].Mes, saldos1[i].Sucursal);
                                    if (nitssaldos != null)
                                    {
                                        foreach (SaldosNitsDataSource nit in nitssaldos)
                                        {
                                            balanceR.Nit = "NIT: " + nit.Nit + "-" + nit.Digito + "-" + nit.Nombrenit;
                                            balanceR.SaldoAnteriorNit = nit.SaldoAnterioMes;
                                            balanceR.SaldoActual = nit.SaldoNit;
                                            balanceR.ValorCreditoNit = nit.CreditoNit;
                                            balanceR.ValorDebitoNit = nit.DebitoNit;
                                            balanceR.CuentaMayor = saldos1[i].Cuenta.Substring(0, 4) + "   " + this.negocioCuenta.DevolverNombre(saldos1[i].Cuenta.Substring(0, 4));
                                            balanceR.Cuenta = saldos1[i].Cuenta + " " + saldos1[i].NombreCuenta;
                                            balanceR.FechaCompr = saldos1[i].Fecha.ToShortDateString();
                                            balanceR.CentroCosto = Convert.ToString(saldos1[1].Idcentro);
                                            balanceR.Comprobante = saldos1[i].Comproban;
                                            balanceR.Asiento = saldos1[i].Documento;
                                            balanceR.Descriptransa = saldos1[i].Descripcion;
                                            balanceR.Valorcredito = saldos1[i].Valorcredito;
                                            balanceR.Valordebito = saldos1[i].Valordebito;
                                            balanceRl.Add(balanceR);

                                        }
                                    }
                                    else
                                    {
                                        balanceR.CuentaMayor = saldos1[i].Cuenta.Substring(0, 4) + "   " + this.negocioCuenta.DevolverNombre(saldos1[i].Cuenta.Substring(0, 4));
                                        balanceR.Cuenta = saldos1[i].Cuenta + " " + saldos1[i].NombreCuenta;
                                        balanceR.FechaCompr = saldos1[i].Fecha.ToShortDateString();
                                        balanceR.CentroCosto = Convert.ToString(saldos1[1].Idcentro);
                                        balanceR.Comprobante = saldos1[i].Comproban;
                                        balanceR.Asiento = saldos1[i].Documento;
                                        balanceR.Descriptransa = saldos1[i].Descripcion;
                                        balanceR.Valorcredito = saldos1[i].Valorcredito;
                                        balanceR.Valordebito = saldos1[i].Valordebito;
                                        balanceRl.Add(balanceR);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    throw ex;
                                }
                            }
                            else
                            {
                                balanceR.CuentaMayor = saldos1[i].Cuenta.Substring(0, 4) + "   " + this.negocioCuenta.DevolverNombre(saldos1[i].Cuenta.Substring(0, 4));
                                balanceR.Cuenta = saldos1[i].Cuenta + " " + saldos1[i].NombreCuenta;
                                balanceR.FechaCompr = saldos1[i].Fecha.ToShortDateString();
                                balanceR.CentroCosto = Convert.ToString(saldos1[1].Idcentro);
                                balanceR.Comprobante = saldos1[i].Comproban;
                                balanceR.Asiento = saldos1[i].Documento;
                                balanceR.Descriptransa = saldos1[i].Descripcion;
                                balanceR.Valorcredito = saldos1[i].Valorcredito;
                                balanceR.Valordebito = saldos1[i].Valordebito;
                                balanceRl.Add(balanceR);
                            }
                        }
                    }
                    ReporteLibroAuxiliar reporteaux = new ReporteLibroAuxiliar();
                    reporteaux.SetDataSource(balanceRl);
                    crystal_ReportAux.ReportSource = reporteaux;
                    this.Size = new Size(1003, 583);
                    crystal_ReportAux.Size = new Size(987, 519);
                    break;
            }
        }
    }
}
