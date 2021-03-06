﻿////*********************************************************
//
//    <copyright file="Form_ReportCuenta.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 11 febrero 2015
//    </copyright>
//
////*********************************************************
namespace App.Forms.Contable.Reportes
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using App.Forms.Contable.Reportes.Types;
    using Entities.Types;
    using Negocios.Contable;
    using Negocios.General;

    public partial class Form_ReportCuenta : Form
    {
        private Cuentan negocioCuenta;

        private Funciones funtions;

        private Empresan negocioEmpresa;

        private Form_Cuenta formcuenta;


        public Form_ReportCuenta(Form_Cuenta form_Cuenta)
        {
            this.negocioCuenta = new Cuentan();
            this.funtions = new Funciones();
            this.negocioEmpresa = new Empresan();
            this.formcuenta = form_Cuenta;
            this.InitializeComponent();
            txt_cuentainiinforme.Focus();
            crystal_reportecuenta.ShowLogo = false;
        }

        public Form_ReportCuenta()
        {
            // TODO: Complete member initialization
        }


        #region EVENTOS FORMULARIO

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.P))
            {
                EventArgs eve = new EventArgs();
                object sender = new object();
                if (btn_informe.Enabled == true)
                {
                    this.Btn_informe_ButtonClick(sender, eve);
                    return true;
                }
            }

            if (keyData == Keys.Escape)
            {
                EventArgs eve = new EventArgs();
                object sender = new object();
                if (btn_salir.Enabled == true)
                {
                    this.Btn_salir_Click(sender, eve);
                    return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form_ReportCuenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.formcuenta.BotonesHabit();
        }

        #endregion

        #region BOTONES

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.formcuenta.BotonesHabit();
        }

        private void Btn_informe_ButtonClick(object sender, EventArgs e)
        {
            List<CuentaDataSource> cuentas = new List<CuentaDataSource>();
            cuentas = this.negocioCuenta.CargarInforme(txt_cuentainiinforme.Text, txt_cuentafininforme.Text);
            EmpresaDataSource empresa = new EmpresaDataSource();
            empresa = this.negocioEmpresa.DevolverDatosEmpresa(Program.compa);
            List<CuentaDataSourceReports> cuentasR = new List<CuentaDataSourceReports>();
            foreach (CuentaDataSource item in cuentas)
            {
                CuentaDataSourceReports cuentaR = new CuentaDataSourceReports();
                cuentaR.Cuenta = item.Cuenta;
                cuentaR.Nombre = item.Nombre;
                cuentaR.Pidenit = item.Pidenit == true ? "SI" : "NO";
                cuentaR.Tipocta = item.Tipocta;
                cuentaR.Centro = item.Centro == true ? "SI" : "NO";
                cuentaR.Cueaju = item.Cueaju;
                cuentaR.Ajudoc = item.Ajudoc;
                cuentaR.NombreCia = empresa.Nombrecia;
                cuentaR.NombreSucursal = empresa.NombreSucursal;
                cuentaR.NitCia = empresa.NitCia+" - " + empresa.DigitoCia;                
                cuentaR.Porete = item.Porete ?? default(decimal);
                cuentaR.Fecha = fecha_informecuenta.Value.ToShortDateString();
                cuentasR.Add(cuentaR);
            }

            ReporteCuentas reportcuenta = new ReporteCuentas();
            reportcuenta.SetDataSource(cuentasR);
            crystal_reportecuenta.ReportSource = reportcuenta;
            this.Size = new Size(1003, 583);
            crystal_reportecuenta.Size = new Size(987, 519);
            this.crystal_reportecuenta.Visible = true;
            this.lbl_cuentafinal.Visible = false;
            this.lbl_cuentainicial.Visible = false;
            this.txt_cuentainiinforme.Visible = false;
            this.txt_nombrecuentafin.Visible = false;
            this.txt_nombrecuentaini.Visible = false;
            txt_cuentafininforme.Visible = false;
            lbl_fecha.Visible = false;
            fecha_informecuenta.Visible = false;
            this.CenterToScreen();
        }
        #endregion

        #region VALIDACIONES

        private void Txt_cuentainiinforme_KeyUp(object sender, KeyEventArgs e)
        {
            int tamanio = txt_cuentainiinforme.Text.Length;
            if (!string.Empty.Equals(txt_cuentainiinforme.Text) && (tamanio != 3 && tamanio != 5 && tamanio != 7 && tamanio != 11) && !txt_cuentainiinforme.Text.Contains("*"))
            {
                try
                {
                    txt_nombrecuentaini.Text = this.negocioCuenta.DevolverNombre(txt_cuentainiinforme.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                }
            }
            else
            {
                txt_nombrecuentaini.Text = string.Empty;
            }

            if (e.KeyCode == Keys.Enter)
            {
                string cuenta;

                if (txt_cuentainiinforme.Text.Contains("*"))
                {
                    cuenta = "**";
                    txt_cuentainiinforme.Text = cuenta;
                }
                else
                {
                    cuenta = txt_cuentainiinforme.Text;
                }

                if (!"**".Equals(cuenta))
                {
                    string mensaje = this.funtions.ValidarCuentaExista(cuenta);
                    if (!string.Empty.Equals(mensaje))
                    {
                        e.Handled = true;
                        txt_nombrecuentaini.Text = mensaje;
                    }
                    else
                    {
                        e.Handled = false;
                        SendKeys.Send("{TAB}");
                        txt_cuentafininforme.Enabled = true;
                    }
                }
                else
                {
                    e.Handled = false;
                    SendKeys.Send("{TAB}");
                }
            }
        }

        private void Txt_cuentafininforme_KeyUp(object sender, KeyEventArgs e)
        {
            int tamanio = txt_cuentafininforme.Text.Length;
            if (!string.Empty.Equals(txt_cuentafininforme.Text) && (tamanio != 3 && tamanio != 5 && tamanio != 7 && tamanio != 11) && !txt_cuentafininforme.Text.Contains("*"))
            {
                try
                {
                    txt_nombrecuentafin.Text = this.negocioCuenta.DevolverNombre(txt_cuentafininforme.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                }
            }
            else
            {
                txt_nombrecuentafin.Text = string.Empty;
            }

            if (e.KeyCode == Keys.Enter)
            {
                string cuenta;
                if (txt_cuentafininforme.Text.Contains("*"))
                {
                    cuenta = "**";
                    txt_cuentafininforme.Text = cuenta;
                    txt_cuentainiinforme.Text = cuenta;
                }
                else
                {
                    cuenta = txt_cuentafininforme.Text;
                }

                if (!"**".Equals(cuenta))
                {
                    string mensaje = this.funtions.ValidarCuentaExista(cuenta);
                    if (!string.Empty.Equals(mensaje))
                    {
                        e.Handled = true;
                        txt_nombrecuentafin.Text = mensaje;
                    }
                    else
                    {
                        e.Handled = false;
                        SendKeys.Send("{TAB}");
                    }
                }
                else
                {
                    e.Handled = false;
                    SendKeys.Send("{TAB}");
                }
            }
        }

        private void Validacion_Keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = false;
                SendKeys.Send("{TAB}");
            }
            else
            {
                e.Handled = this.funtions.ValidacionNumeroAsterisco(e).Handled;
            }
        }

        #endregion
    }
}
