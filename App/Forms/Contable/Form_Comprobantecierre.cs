////*********************************************************
//
//    <copyright file="Form_Comprobantecierre.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 02 marzo 2015
//    </copyright>
//
////*********************************************************
namespace App.Forms.Contable
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Entities.Types;
    using Negocios.Contable;
    using Negocios.General;

    public partial class Form_Comprobantecierre : Form
    {
        private Cuentan negocioCuenta;

        private Comprobantesn negocioComprobante;

        private Parametrosn negocioParametros;

        private int validaotrascuentas;

        private bool usrClose;

        private Funciones funtions;

        public Form_Comprobantecierre()
        {
            this.negocioCuenta = new Cuentan();
            this.negocioComprobante = new Comprobantesn();
            this.negocioParametros = new Parametrosn();
            this.funtions = new Funciones();
            this.InitializeComponent();
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
                case Keys.Control | Keys.N:
                    if (btn_nuevo.Enabled == true)
                    {
                        this.Btn_nuevo_Click(sender, eve);
                        return true;
                    }

                    break;

                case Keys.Control | Keys.G:
                    if (btn_guardar.Enabled == true)
                    {
                        this.Btn_guardar_Click(sender, eve);
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

        private void AutoCompletar()
        {
            List<CuentaDataSource> cuenta = new List<CuentaDataSource>();
            List<ComprobantesDataSource> compro = new List<ComprobantesDataSource>();
            try
            {
                cuenta = this.negocioCuenta.CargarCuenta();
                compro = this.negocioComprobante.CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message, "ERROR");
            }

            AutoCompleteStringCollection cuentas = new AutoCompleteStringCollection();
            AutoCompleteStringCollection comprob = new AutoCompleteStringCollection();
            foreach (CuentaDataSource item in cuenta)
            {
                cuentas.Add(item.Cuenta);
            }

            txt_cuentainiing.AutoCompleteCustomSource = cuentas;
            txt_cuentafining.AutoCompleteCustomSource = cuentas;
            txt_cuentainicos.AutoCompleteCustomSource = cuentas;
            txt_cuentafincos.AutoCompleteCustomSource = cuentas;
            txt_cuentauti.AutoCompleteCustomSource = cuentas;

            foreach (ComprobantesDataSource item in compro)
            {
                comprob.Add(Convert.ToString(item.Codigo));
            }

            txt_codcomp.AutoCompleteCustomSource = comprob;
        }

        private void CamposActivos()
        {
            txt_cuentainiing.Enabled = true;
            txt_cuentafining.Enabled = true;
            txt_cuentainicos.Enabled = true;
            txt_cuentafincos.Enabled = true;
            txt_cuentauti.Enabled = true;
            txt_detalle.Enabled = true;
            txt_codcomp.Enabled = true;
        }

        private void CamposInactivos()
        {
            txt_cuentainiing.Enabled = false;
            txt_cuentafining.Enabled = false;
            txt_cuentainicos.Enabled = false;
            txt_cuentafincos.Enabled = false;
            txt_cuentauti.Enabled = false;
            txt_detalle.Enabled = false;
            txt_codcomp.Enabled = false;
            btn_guardar.Enabled = false;
            menu_botones.Focus();
        }

        private void CamposVacios()
        {
            txt_cuentainiing.Clear();
            txt_cuentafining.Clear();
            txt_cuentainicos.Clear();
            txt_cuentafincos.Clear();
            txt_cuentauti.Clear();
            txt_detalle.Clear();
            txt_nomfincos.Clear();
            txt_nomfining.Clear();
            txt_nominicos.Clear();
            txt_nominiing.Clear();
            txt_nomutili.Clear();
            txt_codcomp.Clear();
        }

        #endregion

        #region BOTONES

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            this.CargarCampos();
            this.AutoCompletar();
            this.CamposActivos();
            btn_guardar.Enabled = true;
            txt_cuentainiing.Focus();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (this.ValidarCampos())
            {
                List<ParametrosDataSource> paramet = new List<ParametrosDataSource>();
                paramet = this.negocioParametros.CargarDatosComprobante();
                paramet[0].ValorParametro = txt_cuentainiing.Text;
                paramet[1].ValorParametro = txt_cuentafining.Text;
                paramet[2].ValorParametro = txt_cuentainicos.Text;
                paramet[3].ValorParametro = txt_cuentafincos.Text;
                paramet[4].ValorParametro = txt_cuentauti.Text;
                paramet[5].ValorParametro = txt_codcomp.Text;
                paramet[6].ValorParametro = txt_detalle.Text;
                bool guardo = false;
                try
                {
                    guardo = this.negocioParametros.GuardarDatosComprobante(paramet);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message, "ERROR");
                }

                if (guardo)
                {
                    MessageBox.Show("EL COMPROBANTE HA SIDO GUARDADO", "GUARDAR", MessageBoxButtons.OK);
                }

                this.CamposVacios();
                this.CamposInactivos();
                btn_nuevo.Enabled = true;
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

        #region DATOS

        private void CargarCampos()
        {
            List<ParametrosDataSource> paramet = new List<ParametrosDataSource>();
            try
            {
                paramet = this.negocioParametros.CargarDatosComprobante();
                txt_nominiing.Text = this.negocioCuenta.DevolverNombre(paramet[0].ValorParametro);
                txt_nomfining.Text = this.negocioCuenta.DevolverNombre(paramet[1].ValorParametro);
                txt_nominicos.Text = this.negocioCuenta.DevolverNombre(paramet[2].ValorParametro);
                txt_nomfincos.Text = this.negocioCuenta.DevolverNombre(paramet[3].ValorParametro);
                txt_nomutili.Text = this.negocioCuenta.DevolverNombre(paramet[4].ValorParametro);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            txt_cuentainiing.Text = paramet[0].ValorParametro;
            txt_cuentafining.Text = paramet[1].ValorParametro;
            txt_cuentainicos.Text = paramet[2].ValorParametro;
            txt_cuentafincos.Text = paramet[3].ValorParametro;
            txt_cuentauti.Text = paramet[4].ValorParametro;
            txt_codcomp.Text = paramet[5].ValorParametro;
            txt_detalle.Text = paramet[6].ValorParametro;
        }

        private bool ValidarCampos()
        {
            if (!txt_codcomp.Text.Equals(string.Empty) && !txt_cuentafincos.Text.Equals(string.Empty) && !txt_cuentafining.Text.Equals(string.Empty) &&
    !txt_cuentainicos.Text.Equals(string.Empty) && !txt_cuentainiing.Text.Equals(string.Empty) && !txt_cuentauti.Text.Equals(string.Empty) &&
    !txt_detalle.Text.Equals(string.Empty))
            {
                return true;
            }
            else
            {
                MessageBox.Show("POR FAVOR INGRESE TODOS LOS CAMPOS", "ERROR", MessageBoxButtons.OK);
                return false;
            }
        }

        #endregion

        #region CERRAR FORMULARIO

        private void Frm_comprobantecierre_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Txtcuenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = false;
                SendKeys.Send("{TAB}");
            }
        }

        private void Txtnumcuent_KeyUp(object sender, KeyEventArgs e)
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

        private void Txtnumcuent_Leave(object sender, EventArgs e)
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

        private void EnterValida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = this.funtions.ValidacionNumerico(e).Handled;
            }
        }

        private void EnterTab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void EnterVal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txt_codcomp_Leave(object sender, EventArgs e)
        {
            if (!string.Empty.Equals(txt_codcomp.Text))
            {
                try
                {
                    txt_nomcompro.Text = this.negocioComprobante.DevolverNombre(int.Parse(txt_codcomp.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SE PRESENTO UN ERROR " + ex.Message, "ERROR", MessageBoxButtons.OK);
                }
            }
        }

        #endregion

    }
}
