﻿using System;
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


namespace App.Forms.Contable
{
    public partial class Form_Saldocuenta : Form
    {
        private Cuentan negocioCuenta;

        private Funciones funtions;

        private int validaotrascuentas;

        private bool usrClose;

        private Parametrosn negocioParametro;

        public Form_Saldocuenta()
        {
            this.negocioCuenta = new Cuentan();
            this.negocioParametro = new Parametrosn();
            this.funtions = new Funciones();
            this.InitializeComponent();
            this.AutoCompletar();
        }

        #region TECLAS DE ACCESO

        /// <summary>
        /// Teclas de Acceso a los botones
        /// </summary>
        /// <param name="msg">A <see cref="T:System.Windows.Forms.Message" />mensaje del proceso</param>
        /// <param name="keyData">un <see cref="T:System.Windows.Forms.Keys" /> valor tecla que recibe.</param>
        /// <returns>
        /// true si las teclas correspondiente son ingresadas
        /// </returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            EventArgs eve = new EventArgs();
            object sender = new object();
            switch (keyData)
            {
                case Keys.Control | Keys.P:
                    if (btn_generar.Enabled == true)
                    {
                        this.Btn_generar_Click(sender, eve);
                        return true;
                    }

                    break;

                case Keys.Escape:

                    if (btn_salir.Enabled == true)
                    {
                        this.Btn_salir_Click(sender, eve);
                        return true;
                    }

                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion

        private void AutoCompletar()
        {
            List<CuentaDataSource> cuenta = new List<CuentaDataSource>();

            try
            {
                cuenta = this.negocioCuenta.CargarCuenta();

            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
            }

            AutoCompleteStringCollection cuentas = new AutoCompleteStringCollection();

            foreach (CuentaDataSource item in cuenta)
            {
                cuentas.Add(item.Cuenta);
            }

            txt_cuenta.AutoCompleteCustomSource = cuentas;


        }

        private void Txt_Cuenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EventArgs eve = new EventArgs();
                if (btn_generar.Enabled)
                {
                    Btn_generar_Click(sender, eve);
                }
            }
        }

        private void Txtcuenta_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (!string.Empty.Equals(tb.Text))
            {
                string mensaje = this.funtions.ValidarCuentaExista(tb.Text);

                if (!string.Empty.Equals(mensaje))
                {
                    this.GetNextControl((Control)sender, true).Text = mensaje;
                    this.validaotrascuentas++;
                    tb.Focus();
                }
            }
            else
            {
                tb.Focus();
            }
        }

        private void EnterValidacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = this.funtions.ValidacionNumerico(e).Handled;
            }
        }

        private void Txtcuenta_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (e.KeyCode != Keys.Enter && e.KeyCode != Keys.Tab)
            {
                this.validaotrascuentas = 0;
            }
            if (!"CUENTA NO EXISTENTE".Equals(this.GetNextControl((Control)sender, true).Text) || this.validaotrascuentas == 0)
            {
                int tamanio = tb.Text.Length;
                if (!tb.Text.Equals(string.Empty) && (tamanio != 3 && tamanio != 5 && tamanio != 7 && tamanio != 11))
                {
                    try
                    {
                        this.GetNextControl((Control)sender, true).Text = this.negocioCuenta.DevolverNombre(tb.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    this.GetNextControl((Control)sender, true).Text = string.Empty;
                }
            }
        }

        private void Btn_generar_Click(object sender, EventArgs e)
        {
            string mensaje = this.funtions.ValidarCuentaExista(txt_cuenta.Text);

            if (!string.Empty.Equals(mensaje))
            {
                MessageBox.Show("LA CUENTA NO EXISTE", "ERROR", MessageBoxButtons.OK);
            }
            else
            {
                string aniotrab = this.negocioParametro.AnioTrabajo();
                List<CuentaDataSourceSaldo> cuentasaldo = new List<CuentaDataSourceSaldo>();
                cuentasaldo = this.negocioCuenta.SaldoCuenta(txt_cuenta.Text, aniotrab, Program.compa);
                decimal saldoanterior = this.negocioCuenta.DevolverSaldoAnio(txt_cuenta.Text, Convert.ToString(int.Parse(aniotrab) - 1));
                txt_tipocuenta.Text = cuentasaldo[0].TipoCuenta.Equals("M") ? "MAYOR" : "AUXILIAR";
                txt_pidenit.Text = cuentasaldo[0].PideNit == true ? "SI" :"NO";
                txt_pidecentro.Text = cuentasaldo[0].PideCentro == true ? "SI" : "NO";
                txt_baseretenc.Text = cuentasaldo[0].PideRete == true ? "SI" : "NO";
                txt_porete.Text = Convert.ToString(cuentasaldo[0].Retencion);
                txt_cuentaaju.Text = cuentasaldo[0].CuentaAju;
                txt_doc.Text = cuentasaldo[0].Doc;
                txt_saldoanioant.Text = Convert.ToString(saldoanterior);
                int mestrabajo = this.negocioParametro.MesTrabajo();
                foreach (CuentaDataSourceSaldo cuentas in cuentasaldo)
                {
                    switch (cuentas.mes)
                    {
                        case 1:
                            txtenero.Text = Convert.ToString(cuentas.saldo);
                            break;

                        case 2:
                            txtfebrero.Text = Convert.ToString(cuentas.saldo);
                            break;

                        case 3:
                            txtmarzo.Text = Convert.ToString(cuentas.saldo);
                            break;

                        case 4:
                            txtabril.Text = Convert.ToString(cuentas.saldo);
                            break;

                        case 5:
                            txtmayo.Text = Convert.ToString(cuentas.saldo);
                            break;

                        case 6:
                            txtjunio.Text = Convert.ToString(cuentas.saldo);
                            break;

                        case 7:
                            txtjulio.Text = Convert.ToString(cuentas.saldo);
                            break;

                        case 8:
                            txtagosto.Text = Convert.ToString(cuentas.saldo);
                            break;

                        case 9:
                            txtsepti.Text = Convert.ToString(cuentas.saldo);
                            break;

                        case 10:
                            txtoctu.Text = Convert.ToString(cuentas.saldo);
                            break;

                        case 11:
                            txtnov.Text = Convert.ToString(cuentas.saldo);
                            break;

                        case 12:
                            txtdici.Text = Convert.ToString(cuentas.saldo);
                            break;
                    }
                    if (cuentas.mes == mestrabajo - 1)
                    {
                        txt_saldoant.Text = Convert.ToString(cuentas.saldo);
                    }
                    else if (cuentas.mes == mestrabajo)
                    {
                        txt_saldomes.Text = Convert.ToString(cuentas.saldo);
                        txt_debitos.Text = Convert.ToString(cuentas.debito);
                        txt_saldocreditos.Text = Convert.ToString(cuentas.credito);
                    }
                }
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ESTA SEGURO QUE DESEA SALIR?", "SALIR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.usrClose = true;
                this.Close();
            }
        }

        #region CERRAR FORMULARIO

        private void Frm_MovsinAct_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.usrClose)
            {
                DialogResult result = MessageBox.Show("ESTA SEGURO QUE DESEA SALIR?", "SALIR", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        #endregion
    }
}
