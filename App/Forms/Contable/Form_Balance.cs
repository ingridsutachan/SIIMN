﻿namespace App.Forms.Contable
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Globalization;
    using System.Windows.Forms;
    using App.Forms.Contable.Reportes;
    using Entities.Types;
    using Negocios.Contable;
    using Negocios.General;

    public partial class Form_Balance : Form
    {
        private int tipoba;

        private asientosn negocioAsiento;

        private bool usrClose;

        private Funciones funtions;

        private Parametrosn negocioParametro;

        private Cuentan negocioCuenta;

        private int validaotrascuentas;

        public Form_Balance(int tipo)
        {
            this.negocioAsiento = new asientosn();
            this.negocioParametro = new Parametrosn();
            this.negocioCuenta = new Cuentan();
            this.funtions = new Funciones();
            this.InitializeComponent();
            this.tipoba = tipo;
            this.ValidarTipo(tipoba);
            this.CargarMeses();
        }

        public void SalirReporte(string tipo)
        {
            if ("mes".Equals(tipo))
            {
                this.HabilitarMes();
            }
            else if ("anual".Equals(tipo))
            {
                this.HabilitarAnual();
            }
            else if ("inventario".Equals(tipo))
            {
                this.HabilitarInventario();
            }
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
                    if (btn_imprimir.Enabled == true)
                    {
                        this.Btn_imprimir_Click(sender, eve);
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

        #region VISUALIZACION

        private void CargarMeses()
        {
            List<MesesDataSource> meses = new List<MesesDataSource>();
            List<MesesDataSource> meses2 = new List<MesesDataSource>();
            string[] mes1 = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            for (int i = 0; i <= 11; i++)
            {
                MesesDataSource mes = new MesesDataSource();
                mes.NumeroMes = Convert.ToString(i + 1);
                mes.NombreMes = Convert.ToString(i + 1) + " - " + mes1[i].ToUpper();
                meses.Add(mes);
                meses2.Add(mes);
            }
            if (this.tipoba == 1)
            {
                cbx_mesmes.DataSource = meses;
                cbx_mesmes.ValueMember = "NumeroMes";
                cbx_mesmes.DisplayMember = "NombreMes";
                cbx_mesmes.SelectedIndex = DateTime.Now.Month - 1;
            }
            else if (this.tipoba == 3)
            {
                cbx_mesinv.DataSource = meses;
                cbx_mesinv.ValueMember = "NumeroMes";
                cbx_mesinv.DisplayMember = "NombreMes";
                cbx_mesinv.SelectedIndex = DateTime.Now.Month - 1;
            }
        }

        private void AutoCompletar()
        {
            CuentaDataSource cuenta = new CuentaDataSource();
            AutoCompleteStringCollection cuentas = new AutoCompleteStringCollection();
            try
            {
                var items = this.negocioCuenta.CargarCuenta();

                foreach (var item in items)
                {
                    cuentas.Add(item.Cuenta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
            }
            if (this.tipoba == 1)
            {
                txt_cuentaini.AutoCompleteCustomSource = cuentas;
                txt_cuentafin.AutoCompleteCustomSource = cuentas;
            }
            else if (this.tipoba == 2)
            {
                txt_cuentainiaual.AutoCompleteCustomSource = cuentas;
                txt_cuentafinanual.AutoCompleteCustomSource = cuentas;
            }
        }

        private void DeshabilitarMes()
        {
            cbx_mesmes.Enabled = false;
            txt_cuentaini.Enabled = false;
            txt_cuentafin.Enabled = false;
            dt_fechames.Enabled = false;
            check_encabe.Enabled = false;
            check_terceros.Enabled = false;
            cbx_mesmes.SelectedIndex = DateTime.Now.Month - 1;
            txt_cuentaini.Text = "**";
            txt_cuentafin.Text = "**";
            dt_fechames.Value = DateTime.Now;
            check_encabe.Checked = true;
            check_terceros.Checked = false;
            this.Enabled = false;
        }

        private void HabilitarMes()
        {
            cbx_mesmes.Enabled = true;
            txt_cuentaini.Enabled = true;
            txt_cuentafin.Enabled = true;
            dt_fechames.Enabled = true;
            check_encabe.Enabled = true;
            check_terceros.Enabled = true;
            this.Enabled = true;
            cbx_mesmes.Focus();
        }

        private void DeshabilitarAnual()
        {
            txt_cuentainiaual.Enabled = false;
            txt_cuentafinanual.Enabled = false;
            check_encabe.Enabled = false;
            txt_cuentainiaual.Text = "**";
            txt_cuentafinanual.Text = "**";
            check_encabanual.Checked = true;
            this.Enabled = false;
        }

        private void HabilitarAnual()
        {

            txt_cuentainiaual.Enabled = true;
            txt_cuentafinanual.Enabled = true;
            check_encabanual.Enabled = true;
            this.Enabled = true;
            txt_cuentainiaual.Focus();
        }

        private void DeshabilitarInventario()
        {
            cbx_mesinv.Enabled = false;
            dt_inv.Enabled = false;
            check_encabinv.Enabled = false;
            check_lineas.Enabled = false;
            check_terceinv.Enabled = false;
            check_cuentasinv.Enabled = false;
            cbx_mesinv.SelectedIndex = DateTime.Now.Month - 1;
            dt_inv.Value = DateTime.Now;
            check_encabinv.Checked = true;
            check_lineas.Enabled = false;
            check_terceinv.Enabled = false;
            check_cuentasinv.Enabled = true;
            this.Enabled = false;
        }

        private void HabilitarInventario()
        {
            cbx_mesinv.Enabled = true;
            dt_inv.Enabled = true;
            check_encabinv.Enabled = true;
            check_lineas.Enabled = true;
            check_terceinv.Enabled = true;
            check_cuentasinv.Enabled = true;
            this.Enabled = true;
            cbx_mesinv.Focus();
        }

        private void ValidarTipo(int tipo)
        {

            if (tipo == 1)
            {
                panel_balanmes.Visible = true;
                this.Text = "IMPRESIÓN BALANCE DE PRUEBA DE UN MES";
                this.AutoCompletar();
            }
            if (tipo == 2)
            {
                panel_anual.Visible = true;
                this.Size = new Size(371, 262);
                progressbarAct.Location = new Point(6, 150);
                porcentaje.Location = new Point(281, 174);
                this.Text = "IMPRESIÓN BALANCE DE PRUEBA ANUAL";
                this.AutoCompletar();
            }

            if (tipo == 3)
            {
                panel_invbalance.Visible = true;
                this.Size = new Size(360, 275);
                progressbarAct.Location = new Point(6, 150);
                porcentaje.Location = new Point(281, 174);
                this.Text = "IMPRESIÓN INVENTARIOS Y BALANCES";
            }
        }

        #endregion

        #region BOTONES

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            List<SaldosCuentasDataSource> balance = new List<SaldosCuentasDataSource>();
            string anio = this.negocioParametro.AnioTrabajo();
            int mes = this.negocioParametro.MesTrabajo();
            if (this.ValidarCampos())
            {
                if (this.tipoba == 1)
                {
                    try
                    {
                        balance = this.negocioAsiento.CargarBalanceMes(int.Parse(cbx_mesmes.SelectedValue.ToString()), anio, txt_cuentaini.Text, txt_cuentafin.Text, Program.compa);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR : " + ex.Message, "ERROR", MessageBoxButtons.OK);
                    }
                    Form_ReporteBalance frm = new Form_ReporteBalance(this, "mes", balance, dt_fechames.Value.ToShortDateString(), check_encabe.Checked, check_terceros.Checked);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    this.DeshabilitarMes();
                }
                else if (this.tipoba == 2)
                {
                    List<SaldoAnualDataSource> saldosanual = new List<SaldoAnualDataSource>();
                    try
                    {
                        saldosanual = this.negocioAsiento.CargarInformeBalanceAnual(txt_cuentainiaual.Text, txt_cuentafinanual.Text, anio, mes, Program.compa);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR : " + ex.Message, "ERROR", MessageBoxButtons.OK);
                    }
                    Form_ReporteBalance frm = new Form_ReporteBalance(this, "anual", saldosanual, check_encabe.Checked);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    this.DeshabilitarAnual();
                }
                else if (this.tipoba == 3)
                {
                    List<SaldosCuentasDataSource> saldocuenta = new List<SaldosCuentasDataSource>();
                    try
                    {
                        saldocuenta = this.negocioAsiento.CargarInformeBalanceMes(int.Parse(cbx_mesinv.SelectedValue.ToString()), anio, Program.compa);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR : " + ex.Message, "ERROR", MessageBoxButtons.OK);
                    }
                    Form_ReporteBalance frm = new Form_ReporteBalance(this, "inventario", saldocuenta, dt_inv.Value.ToShortDateString(), check_encabinv.Checked, check_lineas.Checked, check_terceinv.Checked, check_cuentasinv.Checked);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    this.DeshabilitarInventario();
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ESTA SEGURO QUE DESEA CANCELAR?", "CANCELAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (this.tipoba == 1)
                {
                    this.DeshabilitarMes();
                    this.HabilitarMes();
                }
                else if (this.tipoba == 2)
                {
                    this.DeshabilitarAnual();
                    this.HabilitarAnual();
                }
                else if (this.tipoba == 3)
                {
                    this.DeshabilitarInventario();
                    this.HabilitarInventario();
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

        #endregion

        #region CERRAR FORMULARIO

        private void Frm_LibroDiario_FormClosing(object sender, FormClosingEventArgs e)
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

        #region VALIDACIONES

        private bool ValidarCampos()
        {
            string anio = this.negocioParametro.AnioTrabajo();
            string mensaje = string.Empty;
            bool dev = false;
            if (this.tipoba == 1)
            {
                if (!string.Empty.Equals(txt_cuentaini.Text) && !string.Empty.Equals(txt_cuentafin.Text))
                {
                    try
                    {
                        mensaje = this.negocioAsiento.TieneMovimientoCuentas(int.Parse(cbx_mesmes.SelectedValue.ToString()), anio, txt_cuentaini.Text, txt_cuentafin.Text, Program.compa);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR" + ex.Message, "ERROR", MessageBoxButtons.OK);
                    }
                    if (string.Empty.Equals(mensaje))
                    {
                        dev = true;
                    }
                    else
                    {
                        dev = false;
                    }
                }
                else
                {
                    mensaje = "ingresar";
                    dev = false;
                }
            }
            else if (this.tipoba == 2)
            {
                if (!string.Empty.Equals(txt_cuentainiaual.Text) && !string.Empty.Equals(txt_cuentafinanual.Text))
                {
                    try
                    {
                        mensaje = this.negocioAsiento.TienenMovimientoAnual(txt_cuentainiaual.Text, txt_cuentafinanual.Text, anio, Program.compa);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR" + ex.Message, "ERROR", MessageBoxButtons.OK);
                    }

                    if (string.Empty.Equals(mensaje))
                    {
                        dev = true;
                    }
                    else
                    {
                        dev = false;
                    }
                }
                else
                {
                    mensaje = "ingresar";
                    dev = false;
                }
            }
            else if (this.tipoba == 3)
            {
                try
                {
                    mensaje = this.negocioAsiento.TienenMovimientoMesMsj(int.Parse(cbx_mesinv.SelectedValue.ToString()), anio, Program.compa);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SE PRESENTO UN ERROR" + ex.Message, "ERROR", MessageBoxButtons.OK);
                }
                if (string.Empty.Equals(mensaje))
                {
                    dev = true;
                }
                else
                {
                    dev = false;
                }
            }

            if (!string.Empty.Equals(mensaje))
            {
                switch (mensaje)
                {
                    case "actualizar":
                        MessageBox.Show("DEBE ACTUALIZAR LOS ASIENTOS", "ERROR", MessageBoxButtons.OK);
                        break;
                    case "noexiste":
                        MessageBox.Show("NO EXISTEN MOVIMIENTOS", "ERROR", MessageBoxButtons.OK);
                        break;
                    case "ingresar":
                        MessageBox.Show("POR FAVOR INGRESE TODOS LOS CAMPOS", "ERROR", MessageBoxButtons.OK);
                        break;
                    case "nocuentas":
                        MessageBox.Show("NO HAY CUENTAS REGISTRADAS EN EL SISTEMA", "ERROR", MessageBoxButtons.OK);
                        break;
                }
            }


            return dev;
        }

        private void EnterTab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void EnterValidacionAsteris_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = this.funtions.ValidacionNumeroAsterisco(e).Handled;
            }
        }

        private void Txtcuenta_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (e.KeyCode != Keys.Enter && e.KeyCode != Keys.Tab)
            {
                this.validaotrascuentas = 0;
            }
            if ((!"CUENTA NO EXISTENTE".Equals(this.GetNextControl((Control)sender, true).Text) || this.validaotrascuentas == 0) && !tb.Text.Contains("*"))
            {
                int tamanio = tb.Text.Length;
                if (!tb.Text.Equals(string.Empty) && (tamanio != 3 && tamanio != 5 && tamanio != 7 && tamanio != 11) && !tb.Text.Contains("**"))
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

        private void Txt_Cuenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = false;
                SendKeys.Send("{TAB}");
            }
        }

        private void Txtcuentaini_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (!string.Empty.Equals(tb.Text) && !tb.Text.Contains("*"))
            {
                string mensaje = this.funtions.ValidarCuentaExista(tb.Text);

                if (!string.Empty.Equals(mensaje))
                {
                    this.GetNextControl((Control)sender, true).Text = mensaje;
                    this.validaotrascuentas++;
                    tb.Focus();
                }
                else
                {
                    if (this.tipoba == 1)
                    {
                        txt_cuentafin.Focus();
                        txt_cuentafin.Text = txt_cuentaini.Text;
                    }
                    else if (this.tipoba == 2)
                    {
                        txt_cuentafinanual.Focus();
                        txt_cuentafinanual.Text = txt_cuentainiaual.Text;
                    }
                }
            }
            else if (tb.Text.Contains("*"))
            {
                tb.Text = "**";
                if (this.tipoba == 1)
                {
                    txt_cuentafin.Text = "**";
                    txt_cuentafin.Enabled = false;
                    check_encabe.Focus();
                }
                else if (this.tipoba == 2)
                {
                    txt_cuentafinanual.Text = "**";
                    txt_cuentafinanual.Enabled = false;
                    check_encabanual.Focus();
                }
            }
            else
            {
                tb.Focus();
            }
        }

        private void Txtcuentafin_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (!string.Empty.Equals(tb.Text) || !tb.Text.Contains("**"))
            {
                string mensaje = this.funtions.ValidarCuentaExista(tb.Text);

                if (!string.Empty.Equals(mensaje))
                {
                    this.GetNextControl((Control)sender, true).Text = mensaje;
                    this.validaotrascuentas++;
                    tb.Focus();
                }
                else
                {
                    if (this.tipoba == 1)
                    {
                        check_encabe.Focus();
                    }
                    else if (this.tipoba == 2)
                    {
                        check_encabanual.Focus();
                    }
                }
            }
            else if (tb.Text.Contains("**"))
            {
                this.GetNextControl((Control)sender, true).Text = "CUENTA NO EXISTENTE";
                tb.Focus();
            }
            else
            {
                tb.Focus();
            }
        }

        private void Txt_cuentaini_Enter(object sender, EventArgs e)
        {
            if (this.tipoba == 1)
            {
                txt_cuentafin.Enabled = true;
            }
            else if (this.tipoba == 2)
            {
                txt_cuentafinanual.Enabled = false;
            }
        }

        #endregion
    }
}
