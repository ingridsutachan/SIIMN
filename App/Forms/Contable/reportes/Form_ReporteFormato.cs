﻿////*********************************************************
//
//    <copyright file="Form_ReporteFormato.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 26 febrero 2015
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

    public partial class Form_ReporteFormato : Form
    {
        private Form_Formatos formFormatos;

        private string tipofor;

        private Cuentan negocioCuenta;

        private Funciones funtions;

        private Empresan negocioEmpresa;

        private Formatosn negocioFormato;

        public Form_ReporteFormato()
        {
            this.InitializeComponent();
        }

        public Form_ReporteFormato(Form_Formatos form_Formatos, string tipo)
        {
            this.negocioCuenta = new Cuentan();
            this.funtions = new Funciones();
            this.negocioEmpresa = new Empresan();
            this.negocioFormato = new Formatosn();
            this.formFormatos = form_Formatos;
            this.tipofor = tipo;
            this.InitializeComponent();
            crystal_reportformato.ShowLogo = false;
            fecha_informecuenta.Focus();
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

        private void Form_ReportFormato_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.formFormatos.BotonesHabit();
        }

        #endregion

        #region BOTONES

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.formFormatos.BotonesHabit();
        }

        private void Btn_informe_ButtonClick(object sender, EventArgs e)
        {
            List<FormatoDataSourceShow> formato = new List<FormatoDataSourceShow>();
            formato = this.negocioFormato.CargarInforme(this.tipofor);
            EmpresaDataSource empresa = new EmpresaDataSource();
            empresa = this.negocioEmpresa.DevolverDatosEmpresa(Program.compa);
            List<FormatoDataSourceReport> formatoR = new List<FormatoDataSourceReport>();
            int idform = int.Parse(this.tipofor);
            string encabezado = this.negocioFormato.DevolverEncabezado(idform);
            foreach (FormatoDataSourceShow item in formato)
            {
                FormatoDataSourceReport formR = new FormatoDataSourceReport();
                formR.TipoFormato = this.tipofor.ToUpper();
                formR.NombreEmpresa = empresa.Nombrecia;
                formR.Encabezado = encabezado;
                formR.ClaseCuenta = item.ClaseCuenta;
                formR.NombreClase = this.negocioCuenta.DevolverNombre(item.ClaseCuenta);
                formR.Linea = item.Linea;
                formR.NombreLinea = this.negocioCuenta.DevolverNombre(item.ClaseCuenta + item.Linea);
                formR.Nombre = item.Nombre;
                formR.CuentaInicial = item.CuentaInicial;
                formR.CuentaFinal = item.CuentaFinal;
                formR.NombreCuentaIni = this.negocioCuenta.DevolverNombre(formR.CuentaInicial);
                formR.NombreCuentaFin = this.negocioCuenta.DevolverNombre(formR.CuentaFinal);
                formR.Fecha = fecha_informecuenta.Value.ToShortDateString();
                formatoR.Add(formR);
            }

            ReporteFormato reportformato = new ReporteFormato();
            reportformato.SetDataSource(formatoR);
            crystal_reportformato.ReportSource = reportformato;
            this.Size = new Size(1003, 583);
            crystal_reportformato.Size = new Size(987, 519);
            this.crystal_reportformato.Visible = true;
            lbl_fecha.Visible = false;
            fecha_informecuenta.Visible = false;
            this.CenterToScreen();
        }
        #endregion

        #region VALIDACIONES

        /*  private void Txt_cuentainiinforme_KeyUp(object sender, KeyEventArgs e)
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
        }*/

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
