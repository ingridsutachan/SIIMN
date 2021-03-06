﻿////*********************************************************
//
//    <copyright file="Form_ReporteBalance.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 06 abril 2015
//    </copyright>
//
////*********************************************************
namespace App.Forms.Contable.Reportes
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using App.Forms.Contable.Reportes.Types;
    using Entities.Types;
    using Negocios.Contable;
    using Negocios.General;

    public partial class Form_ReporteBalance : Form
    {
        private Form_Balance form_Balance;

        private string tipo;

        private List<SaldosCuentasDataSource> balance;

        private string fecha;

        private bool terceros;

        private bool encabezado;

        private Empresan negocioEmpresa;

        private Cuentan negocioCuenta;

        private asientosn negocioAsiento;

        private Parametrosn negocioParametro;

        private List<SaldoAnualDataSource> saldoanual;

        private bool Lineas;

        private bool CuentaR;

        public Form_ReporteBalance()
        {
            this.InitializeComponent();
        }

        public Form_ReporteBalance(Form_Balance form_Balance, string tipo, List<SaldosCuentasDataSource> balance, string fecha, bool encabeza, bool terceros)
        {
            // TODO: Complete member initialization
            this.negocioCuenta = new Cuentan();
            this.negocioEmpresa = new Empresan();
            this.negocioAsiento = new asientosn();
            this.InitializeComponent();
            this.form_Balance = form_Balance;
            this.tipo = tipo;
            this.balance = balance;
            this.fecha = fecha;
            this.encabezado = encabeza;
            this.terceros = terceros;
            this.GenerarReporte(tipo);
        }

        public Form_ReporteBalance(Form_Balance form_Balance, string tipo, List<SaldoAnualDataSource> balancean, bool encabeza)
        {
            this.negocioCuenta = new Cuentan();
            this.negocioEmpresa = new Empresan();
            this.negocioAsiento = new asientosn();
            this.negocioParametro = new Parametrosn();
            this.InitializeComponent();
            this.form_Balance = form_Balance;
            this.tipo = tipo;
            this.saldoanual = balancean;
            this.encabezado = encabeza;
            this.GenerarReporte(tipo);
        }

        public Form_ReporteBalance(Form_Balance form_Balance, string tipo, List<SaldosCuentasDataSource> saldocuenta, string fecha, bool encabeza, bool lineas, bool terceros, bool cuentas)
        {
            // TODO: Complete member initialization
            this.negocioCuenta = new Cuentan();
            this.negocioEmpresa = new Empresan();
            this.negocioAsiento = new asientosn();
            this.InitializeComponent();
            this.form_Balance = form_Balance;
            this.tipo = tipo;
            this.balance = saldocuenta;
            this.fecha = fecha;
            this.encabezado = encabeza;
            this.terceros = terceros;
            this.CuentaR = cuentas;
            this.Lineas = lineas;
            this.GenerarReporte(tipo);
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

        private void Form_ReporteBalance_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.form_Balance.SalirReporte(this.tipo);
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
                case "mes":

                    this.Text = "BALANCE DE PRUEBA POR MES";
                    crystal_reportebalance.Visible = true;
                    List<BalanceDataSourceReports> balanceRe = new List<BalanceDataSourceReports>();
                    if (saldos.Count() > 0)
                    {
                        for (int i = 0; i < saldos.Count(); i++)
                        {
                            BalanceDataSourceReports balanceR = new BalanceDataSourceReports();
                            if (this.encabezado)
                            {
                                balanceR.MesyAnio = "MES : " + saldos[i].Mes + "   AÑO : " + saldos[i].Anio;
                                balanceR.CompaniayNit = empresa.Nombrecia + " - " + empresa.NombreSucursal + " - " + empresa.NitCia + " - " + empresa.DigitoCia;
                                balanceR.FechaAct = "FECHA DE IMPRESION DD/MM/YYYY: " + this.fecha;
                                balanceR.Titulo = "BALANCE DE PRUEBA A ";
                            }
                            else
                            {
                                balanceR.Titulo = null;
                            }

                            if (this.terceros)
                            {
                                List<SaldosNitsDataSource> nitssaldos = new List<SaldosNitsDataSource>();
                                balanceR.Cuenta = saldos[i].Cuenta;
                                try
                                {
                                    nitssaldos = this.negocioAsiento.SaldosNits(saldos[i].Cuenta, saldos[i].Anio, saldos[i].Mes, saldos[i].Sucursal);
                                    if (nitssaldos != null)
                                    {
                                        foreach (SaldosNitsDataSource nit in nitssaldos)
                                        {
                                            balanceR.TituloNit = "TERCEROS DE ESTA CUENTA:";
                                            balanceR.Nit = nit.Nit + "-" + nit.Digito + "-" + nit.Nombrenit;
                                            balanceR.SaldoAnteriorNit = nit.SaldoAnterioMes;
                                            balanceR.SaldoActualNit = nit.SaldoNit;
                                            balanceR.ValorCreditoNit = nit.CreditoNit;
                                            balanceR.ValorDebitoNit = nit.DebitoNit;
                                            balanceR.CuentaMayor = saldos[i].Cuenta.Substring(0, 4);
                                            balanceR.Cuenta = saldos[i].Cuenta + " " + saldos[i].NombreCuenta;
                                            balanceR.NombreCuentaMayor = this.negocioCuenta.DevolverNombre(balanceR.CuentaMayor);
                                            balanceR.SaldoAnterior = saldos[i].SaldoAnterior;
                                            balanceR.Valorcredito = saldos[i].ValorCredito;
                                            balanceR.Valordebito = saldos[i].ValorDebito;
                                            balanceR.SaldoActual = saldos[i].SaldoActual;
                                            balanceRe.Add(balanceR);

                                        }
                                    }
                                    else
                                    {
                                        balanceR.CuentaMayor = saldos[i].Cuenta.Substring(0, 4);
                                        balanceR.Cuenta = saldos[i].Cuenta + " " + saldos[i].NombreCuenta;
                                        balanceR.NombreCuentaMayor = this.negocioCuenta.DevolverNombre(balanceR.CuentaMayor);
                                        balanceR.SaldoAnterior = saldos[i].SaldoAnterior;
                                        balanceR.Valorcredito = saldos[i].ValorCredito;
                                        balanceR.Valordebito = saldos[i].ValorDebito;
                                        balanceR.SaldoActual = saldos[i].SaldoActual;
                                        balanceRe.Add(balanceR);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    throw ex;
                                }
                            }
                            else
                            {
                                balanceR.CuentaMayor = saldos[i].Cuenta.Substring(0, 4);
                                balanceR.Cuenta = saldos[i].Cuenta + " " + saldos[i].NombreCuenta;
                                balanceR.NombreCuentaMayor = this.negocioCuenta.DevolverNombre(balanceR.CuentaMayor);
                                balanceR.SaldoAnterior = saldos[i].SaldoAnterior;
                                balanceR.Valorcredito = saldos[i].ValorCredito;
                                balanceR.Valordebito = saldos[i].ValorDebito;
                                balanceR.SaldoActual = saldos[i].SaldoActual;
                                balanceRe.Add(balanceR);
                            }
                        }
                    }

                    ReporteBalance reportebalance = new ReporteBalance();
                    reportebalance.SetDataSource(balanceRe);
                    crystal_reportebalance.ReportSource = reportebalance;
                    this.Size = new Size(1003, 583);
                    crystal_reportebalance.Size = new Size(987, 519);
                    break;

                case "anual":

                    this.Text = "BALANCE DE PRUEBA ANUAL";
                    crystal_reporteanual.Visible = true;
                    List<SaldoAnualDataSource> salanual = new List<SaldoAnualDataSource>();
                    salanual = this.saldoanual;
                    List<SaldosAnualDataSourceReports> balananual = new List<SaldosAnualDataSourceReports>();
                    if (salanual.Count() > 0)
                    {
                        for (int i = 0; i < salanual.Count(); i++)
                        {
                            SaldosAnualDataSourceReports balanceR = new SaldosAnualDataSourceReports();
                            if (this.encabezado)
                            {
                                balanceR.CompaniayNit = empresa.Nombrecia + " - " + empresa.NombreSucursal + " - " + empresa.NitCia + " - " + empresa.DigitoCia;
                                balanceR.FechaAct = "FECHA DE IMPRESION DD/MM/YYYY: " + DateTime.Now.ToShortDateString();
                                string aniotraba = this.negocioParametro.AnioTrabajo();
                                balanceR.Titulo = "BALANCE DE PRUEBA AÑO:" + aniotraba;
                            }
                            else
                            {
                                balanceR.Titulo = null;
                            }

                            balanceR.CuentaMayor = salanual[i].Cuenta.Substring(0, 4);
                            balanceR.Cuenta = salanual[i].Cuenta + " " + salanual[i].NombreCuenta;
                            balanceR.NombreCuentaMayor = this.negocioCuenta.DevolverNombre(balanceR.CuentaMayor);
                            balanceR.SaldoEnero = salanual[i].SaldoEnero;
                            balanceR.SaldoFebrero = salanual[i].SaldoFebrero;
                            balanceR.SaldoMarzo = salanual[i].SaldoMarzo;
                            balanceR.SaldoAbril = salanual[i].SaldoAbril;
                            balanceR.SaldoMayo = salanual[i].SaldoMayo;
                            balanceR.SaldoJunio = salanual[i].SaldoJunio;
                            balanceR.SaldoJulio = salanual[i].SaldoJulio;
                            balanceR.SaldoAgosto = salanual[i].SaldoAgosto;
                            balanceR.SaldoSeptiembre = salanual[i].SaldoSeptiembre;
                            balanceR.SaldoOctubre = salanual[i].SaldoOctubre;
                            balanceR.SaldoNoviembre = salanual[i].SaldoNoviembre;
                            balanceR.SaldoDiciembre = salanual[i].SaldoDiciembre;
                            balananual.Add(balanceR);
                        }
                    }

                    ReporteBalanceAnual reportebalanceanual = new ReporteBalanceAnual();
                    reportebalanceanual.SetDataSource(balananual);
                    crystal_reporteanual.ReportSource = reportebalanceanual;
                    this.Size = new Size(1003, 583);
                    crystal_reporteanual.Size = new Size(987, 519);
                    break;

                case "inventario":
                    saldos = this.balance;
                    this.Text = "LIBRO DE INVENTARIOS Y BALANCES";
                    crystal_ReporteInv.Visible = true;
                    List<InventarioDataSourceReports> balanceRi = new List<InventarioDataSourceReports>();
                    if (saldos.Count() > 0)
                    {
                        for (int i = 0; i < saldos.Count(); i++)
                        {
                            InventarioDataSourceReports balanceR = new InventarioDataSourceReports();
                            if (this.encabezado)
                            {
                                balanceR.MesyAnio = "MES : " + saldos[i].Mes + "   AÑO : " + saldos[i].Anio;
                                balanceR.Compania = empresa.Nombrecia + " - " + empresa.NombreSucursal;
                                balanceR.Nit = empresa.NitCia + " - " + empresa.DigitoCia;
                                balanceR.FechaAct = this.fecha;
                                balanceR.Titulo = "LIBRO DE INVENTARIOS Y BALANCES A ";
                            }
                            else
                            {
                                balanceR.Titulo = null;
                            }

                            if (this.terceros)
                            {
                                List<SaldosNitsDataSource> nitssaldos = new List<SaldosNitsDataSource>();
                                balanceR.Cuenta = saldos[i].Cuenta;
                                try
                                {
                                    nitssaldos = this.negocioAsiento.SaldosNits(saldos[i].Cuenta, saldos[i].Anio, saldos[i].Mes, saldos[i].Sucursal);
                                    if (nitssaldos != null)
                                    {
                                        foreach (SaldosNitsDataSource nit in nitssaldos)
                                        {
                                            balanceR.TituloNit = "TERCEROS DE ESTA CUENTA:";
                                            balanceR.Nit = nit.Nit + "-" + nit.Digito + "-" + nit.Nombrenit;
                                            balanceR.SaldoActualNit = nit.SaldoNit;
                                            balanceR.CuentaMayor = saldos[i].Cuenta.Substring(0, 4);
                                            balanceR.Cuenta = saldos[i].Cuenta + " " + saldos[i].NombreCuenta;
                                            balanceR.NombreCuentaMayor = this.negocioCuenta.DevolverNombre(balanceR.CuentaMayor);
                                            balanceR.SaldoActual = saldos[i].SaldoActual;
                                            balanceRi.Add(balanceR);
                                        }
                                    }
                                    else
                                    {
                                        balanceR.CuentaMayor = saldos[i].Cuenta.Substring(0, 4);
                                        balanceR.Cuenta = saldos[i].Cuenta + " " + saldos[i].NombreCuenta;
                                        balanceR.NombreCuentaMayor = this.negocioCuenta.DevolverNombre(balanceR.CuentaMayor);
                                        balanceR.SaldoActual = saldos[i].SaldoActual;
                                        balanceRi.Add(balanceR);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    throw ex;
                                }
                            }
                            else
                            {
                                balanceR.CuentaMayor = saldos[i].Cuenta.Substring(0, 4);
                                balanceR.Cuenta = saldos[i].Cuenta + " " + saldos[i].NombreCuenta;
                                balanceR.NombreCuentaMayor = this.negocioCuenta.DevolverNombre(balanceR.CuentaMayor);
                                balanceR.SaldoActual = saldos[i].SaldoActual;
                                balanceRi.Add(balanceR);
                            }
                        }
                    }

                    ReporteInventarioBalance reporteinventario = new ReporteInventarioBalance();
                    reporteinventario.SetDataSource(balanceRi);
                    crystal_ReporteInv.ReportSource = reporteinventario;
                    this.Size = new Size(1003, 583);
                    crystal_ReporteInv.Size = new Size(987, 519);
                    break;
            }
        }
    }
}
