﻿////*********************************************************
//
//    <copyright file="Form_ReportePresupuesto.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 18 febrero 2015
//    </copyright>
//
////*********************************************************
namespace App.Forms.Contable.Reportes
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Globalization;
    using System.Windows.Forms;
    using App.Forms.Contable.Reportes.Types;
    using Entities.Types;
    using Negocios.Contable;
    using Negocios.General;

    public partial class Form_ReportePresupuesto : Form
    {
        private Presupueston negocioPresupuesto;

        private Empresan negocioEmpresa;

        private Cuentan negocioCuenta;

        private Centron negocioCentro;

        private Funciones funtions;

        private int validacuenta;

        private int validacentro;

        private Frmpresupuesto frmpresupuesto;

        public Form_ReportePresupuesto(Frmpresupuesto frm_presupuesto)
        {
            this.negocioPresupuesto = new Presupueston();
            this.negocioEmpresa = new Empresan();
            this.negocioCuenta = new Cuentan();
            this.negocioCentro = new Centron();
            this.funtions = new Funciones();
            this.frmpresupuesto = frm_presupuesto;
            this.InitializeComponent();
            crystal_Presupuesto.ShowLogo = false;
        }

        public Form_ReportePresupuesto()
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

        private void Form_ReportePresupuesto_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.frmpresupuesto.BotonesHabit();
        }

        private void CamposVacios()
        {
            txt_anio.Clear();
            txt_cuenta.Clear();
            txt_nombrecuenta.Clear();
            txt_centro.Clear();
            txt_descripcentro.Clear();
        }

        #endregion

        #region BOTONES CLICK

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.frmpresupuesto.BotonesHabit();
            this.Close();
        }

        private void Btn_informe_ButtonClick(object sender, EventArgs e)
        {
            if (this.ValidarGuardar())
            {
                List<PresupDataSource> presupuesto = new List<PresupDataSource>();
                presupuesto = this.negocioPresupuesto.DevolverPresu(txt_anio.Text, txt_cuenta.Text, int.Parse(txt_centro.Text), Program.compa);
                EmpresaDataSource empresa = new EmpresaDataSource();
                empresa = this.negocioEmpresa.DevolverDatosEmpresa(Program.compa);
                List<PresupShowDataSourceReporte> presupR = new List<PresupShowDataSourceReporte>();
                foreach (PresupDataSource item in presupuesto)
                {
                    PresupShowDataSourceReporte presupDev = new PresupShowDataSourceReporte();
                    presupDev.Anio = item.Anio;
                    presupDev.NombreMes = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(item.IdMes).ToUpper();
                    presupDev.Cuenta = item.Cuenta + " - " + item.NombreCuenta;
                    presupDev.IdCentro = Convert.ToString(item.IdCentro) + " - " + item.NombreCentro;
                    presupDev.Presupuesto = item.Presupuesto;
                    presupDev.NombreEmpresa = empresa.Nombrecia + " - " + empresa.NombreSucursal;
                    presupDev.NitEmpresa = empresa.NitCia + " - " + empresa.DigitoCia;
                    presupDev.Fecha = fecha_informepres.Value.ToShortDateString();
                    presupR.Add(presupDev);
                }

                ReportePresupuesto reportpresup = new ReportePresupuesto();
                reportpresup.SetDataSource(presupR);
                crystal_Presupuesto.ReportSource = reportpresup;
                this.Size = new Size(1003, 583);
                crystal_Presupuesto.Size = new Size(987, 519);
                this.crystal_Presupuesto.Visible = true;
                this.lbl_cuenta.Visible = false;
                this.lbl_anio.Visible = false;
                this.txt_anio.Visible = false;
                this.txt_descripcentro.Visible = false;
                this.txt_nombrecuenta.Visible = false;
                txt_cuenta.Visible = false;
                lbl_centro.Visible = false;
                txt_centro.Visible = false;
                lbl_fecha.Visible = false;
                fecha_informepres.Visible = false;
                this.CenterToScreen();
            }
        }

        #endregion

        #region VALIDACIONES

        private void EnterAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            else
            {
                e.Handled = this.funtions.ValidacionNumerico(e).Handled;
            }
        }

        private void Txtanio_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (txt_anio.Text.Length != 4 || int.Parse(txt_anio.Text) < 1900 || int.Parse(txt_anio.Text) > 2100)
            {
                tb.Focus();
            }
        }

        private void EnterValidar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = this.funtions.ValidacionNumerico(e).Handled;
            }
        }

        private void Txtnumcuent_KeyUp(object sender, KeyEventArgs e)
        {
            this.validacentro = 1;
            TextBox tb = (TextBox)sender;
            if ((!"CUENTA MAYOR".Equals(this.GetNextControl((Control)sender, true).Text)
               && !"CUENTA NO EXISTENTE".Equals(this.GetNextControl((Control)sender, true).Text)) || this.validacuenta == 0)
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
            else if (this.validacuenta == 1)
            {
                this.validacuenta = 0;
            }

            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = false;
                SendKeys.Send("{TAB}");
            }
        }

        private void Txtnumcuent_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (!string.Empty.Equals(tb.Text))
            {
                string mensaje = this.funtions.ValidarOtraCuenta(tb.Text);
                if (!string.Empty.Equals(mensaje))
                {
                    tb.Focus();
                    this.GetNextControl((Control)sender, true).Text = mensaje;
                    this.validacuenta = 1;
                }
            }
            else if (this.validacentro != 0)
            {
                tb.Focus();
            }
        }

        private void Txt_centro_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (!string.Empty.Equals(tb.Text))
            {
                if (!this.ExisteCentro())
                {
                    txt_descripcentro.Text = "CENTRO NO EXISTE";
                    this.validacentro = 1;
                    tb.Focus();
                }
                else
                {
                    if (!this.ExistePresupuesto())
                    {
                        MessageBox.Show("EL PRESUPUESTO NO EXISTE", "ERROR", MessageBoxButtons.OK);
                        this.validacentro = 1;
                    }
                    else
                    {
                        fecha_informepres.Focus();
                    }
                }
            }
            else if (this.validacuenta != 0)
            {
                tb.Focus();
            }
        }

        private bool ExisteCentro()
        {
            bool result = false;
            try
            {
                result = this.negocioCentro.ExisteCentro(int.Parse(txt_centro.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }

            return result;
        }

        private bool ExistePresupuesto()
        {
            bool validapresupuesto = true;
            try
            {
                validapresupuesto = this.negocioPresupuesto.ExistePresupuesto(txt_anio.Text, txt_cuenta.Text, int.Parse(txt_centro.Text), Program.compa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }

            return validapresupuesto;
        }

        private bool ValidarGuardar()
        {
            bool result = false;
            if (!string.Empty.EndsWith(txt_anio.Text) && !string.Empty.Equals(txt_cuenta.Text) && !string.Empty.Equals(txt_centro.Text))
            {
                bool existecuenta = false;
                bool existecentro = false;
                bool validoanio = int.Parse(txt_anio.Text) > 1900 && int.Parse(txt_anio.Text) < 2100;
                try
                {
                    existecuenta = this.negocioCuenta.ExisteCuenta(txt_cuenta.Text);
                    existecentro = this.negocioCentro.ExisteCentro(int.Parse(txt_centro.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                }

                if (existecuenta && existecentro && validoanio)
                {
                    bool existepres = false;
                    try
                    {
                        existepres = this.negocioPresupuesto.ExistePresupuesto(txt_anio.Text, txt_cuenta.Text, int.Parse(txt_centro.Text), Program.compa);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                    }

                    if (existepres)
                    {
                        result = true;
                    }
                    else
                    {
                        MessageBox.Show("EL PRESUPUESTO NO EXISTE", "ERROR", MessageBoxButtons.OK);
                        this.CamposVacios();
                        result = false;
                    }
                }
                else
                {
                    if (!existecuenta)
                    {
                        MessageBox.Show("LA CUENTA NO EXISTE", "ERROR", MessageBoxButtons.OK);
                        result = false;
                    }
                    else if (!existecentro)
                    {
                        MessageBox.Show("EL CENTRO NO EXISTE", "ERROR", MessageBoxButtons.OK);
                        result = false;
                    }
                    else if (!validoanio)
                    {
                        MessageBox.Show("EL AÑO NO ES VALIDO", "ERROR", MessageBoxButtons.OK);
                        result = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("INGRESE  TODOS LOS DATOS", "ERROR", MessageBoxButtons.OK);
                result = false;
            }

            return result;
        }

        private void Txt_centro_KeyUp(object sender, KeyEventArgs e)
        {
            this.validacuenta = 1;
            if ((!"CENTRO NO EXISTE".Equals(txt_descripcentro.Text)
                  && !"EL PRESUPUESTO NO EXISTE".Equals(txt_descripcentro.Text)) || this.validacentro == 0)
            {
                int tamanio = txt_centro.Text.Length;
                if (tamanio != 0)
                {
                    try
                    {
                        txt_descripcentro.Text = this.negocioCentro.DevolverNombre(int.Parse(txt_centro.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    txt_descripcentro.Text = string.Empty;
                }
            }
            else if (this.validacentro == 1)
            {
                this.validacentro = 0;
            }

            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = false;
                this.Txt_centro_Leave(sender, e);
            }
        }

        #endregion
    }
}
