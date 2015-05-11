namespace App.Forms.Cartera
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Entities.Types;
    using Negocios.Contable;
    using Negocios.General;

    public partial class Form_AsientoRec : Form
    {
        private Cuentan negocioCuenta;

        private Parametrosn negocioParametro;

        private bool usrClose;

        public Form_AsientoRec()
        {
            this.negocioCuenta = new Cuentan();
            this.negocioParametro = new Parametrosn();
            this.InitializeComponent();
            this.AutoCompletar();
            this.CargarCampos();
        }

        #region VISUALIZACION

        private void AutoCompletar()
        {
            List<CuentaDataSource> cuenta = new List<CuentaDataSource>();
            cuenta = this.negocioCuenta.CargarCuenta();
            AutoCompleteStringCollection cuentas = new AutoCompleteStringCollection();
            foreach (CuentaDataSource item in cuenta)
            {
                cuentas.Add(item.Cuenta);
                cuentas.Add(item.Nombre);
            }

            txt_cuentacaja.AutoCompleteCustomSource = cuentas;
            txt_cuentarete.AutoCompleteCustomSource = cuentas;
            txt_cuentaica.AutoCompleteCustomSource = cuentas;
            txt_cuentainteres.AutoCompleteCustomSource = cuentas;
            txt_cuentacomis.AutoCompleteCustomSource = cuentas;
            txt_cuentadto.AutoCompleteCustomSource = cuentas;
            txt_cuentacheq.AutoCompleteCustomSource = cuentas;
            txt_2cheq.AutoCompleteCustomSource = cuentas;
            txt_2reten.AutoCompleteCustomSource = cuentas;
            txt_cuentasoc.AutoCompleteCustomSource = cuentas;
        }

        private void CargarCampos()
        {
            List<ParametrosDataSource> paramet = new List<ParametrosDataSource>();
            paramet = this.negocioParametro.CargarDatosAsiento();
            txt_cuentacaja.Text = paramet[0].ValorParametro;
            txt_cuentarete.Text = paramet[1].ValorParametro;
            txt_cuentaica.Text = paramet[2].ValorParametro;
            txt_cuentainteres.Text = paramet[3].ValorParametro;
            txt_cuentacomis.Text = paramet[4].ValorParametro;
            txt_cuentadto.Text = paramet[5].ValorParametro;
            txt_cuentacheq.Text = paramet[6].ValorParametro;
            txt_2cheq.Text = paramet[7].ValorParametro;
            txt_2reten.Text = paramet[8].ValorParametro;
            txt_cuentasoc.Text = paramet[9].ValorParametro;
        }

        #endregion

        #region  GUARDAR DATOS

        private bool ValidarCampos()
        {
            bool result = false;
            if (!txt_cuentacaja.Text.Equals(string.Empty) && !txt_cuentarete.Text.Equals(string.Empty) && !txt_cuentaica.Text.Equals(string.Empty) &&
                !txt_cuentainteres.Text.Equals(string.Empty) && !txt_cuentacomis.Text.Equals(string.Empty) && !txt_cuentadto.Text.Equals(string.Empty) &&
                !txt_cuentacheq.Text.Equals(string.Empty) && !txt_2cheq.Text.Equals(string.Empty) && !txt_2reten.Text.Equals(string.Empty) &&
                !txt_cuentasoc.Text.Equals(string.Empty))
            {
                if (!txt_cuentacaja.Text.Equals("Cuenta General") && !txt_cuentacaja.Text.Equals("Cuenta no Existente") &&
                !txt_cuentarete.Text.Equals("Cuenta General") && !txt_cuentarete.Text.Equals("Cuenta no Existente") && !txt_cuentaica.Text.Equals("Cuenta General") &&
                !txt_cuentaica.Text.Equals("Cuenta no Existente") && !txt_cuentainteres.Text.Equals("Cuenta General") && !txt_cuentainteres.Text.Equals("Cuenta no Existente") &&
                !txt_cuentacomis.Text.Equals("Cuenta General") && !txt_cuentacomis.Text.Equals("Cuenta no Existente") && !txt_cuentadto.Text.Equals("Cuenta General") &&
                !txt_cuentadto.Text.Equals("Cuenta no Existente") && !txt_cuentacheq.Text.Equals("Cuenta General") && !txt_cuentacheq.Text.Equals("Cuenta no Existente")
                    && !txt_2cheq.Text.Equals("Cuenta General") && !txt_2reten.Text.Equals("Cuenta no Existente") && !txt_2reten.Text.Equals("Cuenta General") && !txt_2reten.Text.Equals("Cuenta no Existente")
                    && !txt_cuentasoc.Text.Equals("Cuenta General") && !txt_cuentasoc.Text.Equals("Cuenta no Existente"))
                {
                    result = true;
                }
                else
                {
                    result = false;
                    MessageBox.Show("Alguna de las cuentas no es valida ", "ERROR", MessageBoxButtons.OK);
                }
            }
            else
            {
                result = false;
                MessageBox.Show("Debe ingresar todos los campos", "ERROR", MessageBoxButtons.OK);
            }

            return result;
        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            if (this.ValidarCampos())
            {
                List<ParametrosDataSource> paramet = new List<ParametrosDataSource>();
                paramet = this.negocioParametro.CargarDatosAsiento();
                paramet[0].ValorParametro = txt_cuentacaja.Text;
                paramet[1].ValorParametro = txt_cuentarete.Text;
                paramet[2].ValorParametro = txt_cuentaica.Text;
                paramet[3].ValorParametro = txt_cuentainteres.Text;
                paramet[4].ValorParametro = txt_cuentacomis.Text;
                paramet[5].ValorParametro = txt_cuentadto.Text;
                paramet[6].ValorParametro = txt_cuentacheq.Text;
                paramet[7].ValorParametro = txt_2cheq.Text;
                paramet[8].ValorParametro = txt_2reten.Text;
                paramet[9].ValorParametro = txt_cuentasoc.Text;
                if (this.negocioParametro.GuardarDatosAsiento(paramet))
                {
                    MessageBox.Show("El comprobante ha sido guardado", "GUARDAR", MessageBoxButtons.OK);
                }
            }
        }

        #endregion

        #region CERRAR FORMULARIO

        private void Form_AsientoRec_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.usrClose)
            {
                DialogResult result = MessageBox.Show("Esta seguro que desea salir?", "SALIR", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void Salircuent_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea salir?", "SALIR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.usrClose = true;
                this.Close();
            }
        }

        #endregion

        #region ENTER TAB

        private void EnterTab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        #endregion
    }
}
