namespace App.Forms.Contable
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using Negocios.Contable;
    using Negocios.General;
    using Entities.Types;
    using App.Forms.Contable.Reportes;

    public partial class Form_Auxiliar : Form
    {
        public int tipoaux;

        private asientosn negocioAsiento;

        private bool usrClose;

        private Funciones funtions;

        private Parametrosn negocioParametro;

        private Cuentan negocioCuenta;

        private int validaotrascuentas;

        private Nitsn negocioNit;

        private bool cuentainiyfin;

        public Form_Auxiliar(int tipo)
        {
            this.negocioAsiento = new asientosn();
            this.negocioParametro = new Parametrosn();
            this.negocioCuenta = new Cuentan();
            this.negocioNit = new Nitsn();
            this.funtions = new Funciones();
            this.InitializeComponent();
            this.tipoaux = tipo;
            this.ValidarTipo(tipoaux);
        }

        public void SalirReporte(string tipo)
        {
            if ("anio".Equals(tipo))
            {
                this.HabilitarAnio();
            }
            else if ("nit".Equals(tipo))
            {
                this.HabilitarNit();
            }
            else if ("sinact".Equals(tipo))
            {
                this.HabilitarSinActualizar();
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
            if (this.tipoaux == 1)
            {
                txt_cuentaini.AutoCompleteCustomSource = cuentas;
                txt_cuentafin.AutoCompleteCustomSource = cuentas;
            }
            else if (this.tipoaux == 2)
            {
                txt_cuentaininit.AutoCompleteCustomSource = cuentas;
                txt_cuentafinnit.AutoCompleteCustomSource = cuentas;
            }
            else if (this.tipoaux == 3)
            {
                txt_cueninisinact.AutoCompleteCustomSource = cuentas;
                txt_cuefinsinact.AutoCompleteCustomSource = cuentas;
                NitsDataSource nit = new NitsDataSource();
                AutoCompleteStringCollection nits = new AutoCompleteStringCollection();
                try
                {
                    var items = this.negocioNit.CargarNits();

                    foreach (var item in items)
                    {
                        nits.Add(item.Nit);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
                }

                txt_nitininit.AutoCompleteCustomSource = nits;
                txt_nitfinnit.AutoCompleteCustomSource = nits;
            }
        }

        private void DeshabilitarAnio()
        {
            check_centro.Enabled = false;
            combo_ordenado.Enabled = false;
            check_nit.Enabled = false;
            check_totales.Enabled = false;
            dt_fechaini.Enabled = false;
            dt_fechafin.Enabled = false;
            txt_cuentaini.Enabled = false;
            txt_cuentafin.Enabled = false;
            check_centro.Checked = false;
            combo_ordenado.SelectedIndex = 0;
            check_nit.Checked = true;
            check_totales.Checked = false;
            dt_fechaini.Value = DateTime.Now;
            dt_fechafin.Value = DateTime.Now;
            txt_cuentaini.Text = string.Empty;
            txt_cuentafin.Text = string.Empty;
            this.Enabled = false;
        }

        private void HabilitarAnio()
        {
            check_centro.Enabled = true;
            combo_ordenado.Enabled = true;
            check_nit.Enabled = true;
            check_totales.Enabled = true;
            dt_fechaini.Enabled = true;
            dt_fechafin.Enabled = true;
            txt_cuentaini.Enabled = true;
            txt_cuentafin.Enabled = true;
            this.Enabled = true;
            check_centro.Focus();
        }

        private void DeshabilitarNit()
        {
            cbx_ordennit.Enabled = false;
            check_nitnit.Enabled = false;
            check_totalnit.Enabled = false;
            dt_fechaininit.Enabled = false;
            dt_fechafinnit.Enabled = false;
            txt_cuentaininit.Enabled = false;
            txt_cuentafinnit.Enabled = false;
            txt_nitininit.Enabled = false;
            txt_nitfinnit.Enabled = false;
            cbx_ordennit.SelectedIndex = 0;
            check_nitnit.Checked = true;
            check_totalnit.Checked = false;
            dt_fechaininit.Value = DateTime.Now;
            dt_fechafinnit.Value = DateTime.Now;
            txt_cuentaininit.Text = string.Empty;
            txt_cuentafinnit.Text = string.Empty;
            txt_nitininit.Text = string.Empty;
            txt_nitfinnit.Text = string.Empty;
            this.Enabled = false;
        }

        private void HabilitarNit()
        {
            cbx_ordennit.Enabled = true;
            check_nitnit.Enabled = true;
            check_totalnit.Enabled = true;
            dt_fechaininit.Enabled = true;
            dt_fechafinnit.Enabled = true;
            txt_cuentaininit.Enabled = true;
            txt_cuentafinnit.Enabled = true;
            txt_nitininit.Enabled = true;
            txt_nitfinnit.Enabled = true;
            this.Enabled = true;
            check_centro.Focus();
        }

        private void DeshabilitarSinActualizar()
        {
            combo_ordenado.Enabled = false;
            check_nit.Enabled = false;
            check_totales.Enabled = false;
            dt_fechaini.Enabled = false;
            dt_fechafin.Enabled = false;
            txt_cuentaini.Enabled = false;
            txt_cuentafin.Enabled = false;
            check_centro.Checked = false;
            combo_ordenado.SelectedIndex = 0;
            check_totales.Checked = false;
            dt_fechaini.Value = DateTime.Now;
            dt_fechafin.Value = DateTime.Now;
            txt_cuentaini.Text = string.Empty;
            txt_cuentafin.Text = string.Empty;
            this.Enabled = false;
        }

        private void HabilitarSinActualizar()
        {
            combo_ordenado.Enabled = true;
            check_nit.Enabled = true;
            check_totales.Enabled = true;
            dt_fechaini.Enabled = true;
            dt_fechafin.Enabled = true;
            txt_cuentaini.Enabled = true;
            txt_cuentafin.Enabled = true;
            this.Enabled = true;
            check_centro.Focus();
        }

        private void ValidarTipo(int tipo)
        {
            this.AutoCompletar();
            if (tipo == 1)
            {
                combo_ordenado.SelectedIndex = 0;
                pan_auxanio.Visible = true;
                this.Text = "IMPRESIÓN LIBRO AUXILIAR DEL AÑO";
            }
            if (tipo == 2)
            {
                pan_auxanual.Visible = true;
                //this.Size = new Size(342, 320);
                this.Text = "IMPRESIÓN LIBRO AUXILIAR DEL AÑO";
            }
            if (tipo == 3)
            {
                pan_auxasi.Visible = true;
                // this.Size = new Size(353, 303);
                this.Text = "IMPRESIÓN AUXILIAR ASIENTOS SIN ACTUALIZAR";
            }
        }

        #endregion

        #region BOTONES

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            List<LibroAuxiliarDataSource> balance = new List<LibroAuxiliarDataSource>();
            string anio = this.negocioParametro.AnioTrabajo();
            int mes = this.negocioParametro.MesTrabajo();
            if (this.ValidarCampos())
            {
                if (this.tipoaux == 1)
                {
                    try
                    {
                        balance = this.negocioAsiento.CargarBalanceLibroAux(dt_fechaini.Value, dt_fechafin.Value, txt_cuentaini.Text, txt_cuentafin.Text, combo_ordenado.SelectedItem.ToString(), Program.compa,true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR : " + ex.Message, "ERROR", MessageBoxButtons.OK);
                    }
                    Form_ReporteLibros frm = new Form_ReporteLibros(this, "anio", balance, dt_fechaini.Value, dt_fechafin.Value, check_centro.Checked, check_nit.Checked, check_totales.Checked);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    this.DeshabilitarAnio();
                }
                else if (this.tipoaux == 2)
                {
                    List<LibroAuxiliarDataSource> movimientonit = new List<LibroAuxiliarDataSource>();
                    try
                    {
                        movimientonit = this.negocioAsiento.CargarBalanceLibroAuxNit(dt_fechaininit.Value, dt_fechafinnit.Value, txt_cuentaininit.Text, txt_cuentafinnit.Text, txt_nitininit.Text, txt_nitininit.Text, cbx_ordennit.SelectedItem.ToString(), Program.compa);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR : " + ex.Message, "ERROR", MessageBoxButtons.OK);
                    }
                    Form_ReporteLibros frm = new Form_ReporteLibros(this, "nit", movimientonit, dt_fechaini.Value, dt_fechafin.Value, check_centro.Checked, check_nit.Checked, check_totales.Checked);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    this.DeshabilitarNit();
                }
                else if (this.tipoaux == 3)
                {
                    List<LibroAuxiliarDataSource> movimientosinact = new List<LibroAuxiliarDataSource>();
                    try
                    {
                        movimientosinact = this.negocioAsiento.CargarBalanceLibroAux(dt_fechainisinact.Value, dt_fechafinsinact.Value, txt_cueninisinact.Text, txt_cuefinsinact.Text, cbx_ordenadosinact.SelectedItem.ToString(), Program.compa,false);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR : " + ex.Message, "ERROR", MessageBoxButtons.OK);
                    }
                    Form_ReporteLibros frm = new Form_ReporteLibros(this, "sinact", movimientosinact, dt_fechaini.Value, dt_fechafin.Value, check_centro.Checked, check_nit.Checked, check_totales.Checked);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    this.DeshabilitarSinActualizar();
                }
            }
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ESTA SEGURO QUE DESEA CANCELAR?", "CANCELAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (this.tipoaux == 1)
                {
                    this.DeshabilitarAnio();
                    this.HabilitarAnio();
                }
                else if (this.tipoaux == 2)
                {
                    this.DeshabilitarNit();
                    this.HabilitarNit();
                }
                else if (this.tipoaux == 3)
                {
                    this.DeshabilitarSinActualizar();
                    this.HabilitarSinActualizar();
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

        private void Frm_LibroAuxiliar_FormClosing(object sender, FormClosingEventArgs e)
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
            if (this.tipoaux == 1)
            {
                if (!string.Empty.Equals(txt_cuentaini.Text) && !string.Empty.Equals(txt_cuentafin.Text))
                {
                    try
                    {
                        mensaje = this.negocioAsiento.TieneMovimientoFechaCuenta(dt_fechaini.Value, dt_fechafin.Value, txt_cuentaini.Text, txt_cuentafin.Text, Program.compa);
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
            else if (this.tipoaux == 2)
            {
                if (!string.Empty.Equals(txt_cuentaininit.Text) && !string.Empty.Equals(txt_cuentafinnit.Text) && !string.Empty.Equals(txt_nitininit.Text) && !string.Empty.Equals(txt_nitfinnit.Text))
                {
                    try
                    {
                        mensaje = this.negocioAsiento.TieneMovimientoFechaCuentayNit(dt_fechaininit.Value, dt_fechafinnit.Value, txt_cuentaininit.Text, txt_cuentafin.Text, txt_nitininit.Text, txt_nitfinnit.Text, Program.compa);
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
            else if (this.tipoaux == 3)
            {
                try
                {
                    mensaje = this.negocioAsiento.TieneMovimientoFechaCuentaSinAct(dt_fechainisinact.Value, dt_fechafinsinact.Value, txt_cueninisinact.Text, txt_cuefinsinact.Text, Program.compa);
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
                        MessageBox.Show("NO EXISTEN CUENTAS EN EL SISTEMA ", "ERROR", MessageBoxButtons.OK);
                        break;
                    case "noexistesinact":
                        MessageBox.Show("NO EXISTEN MOVIMIENTOS SIN ACTUALIZAR", "ERROR", MessageBoxButtons.OK);
                        break;
                    case "nonits":
                        MessageBox.Show("NO EXISTEN NITS EN EL SISTEMA", "ERROR", MessageBoxButtons.OK);
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
                this.cuentainiyfin = true;
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
                    if (this.tipoaux == 1)
                    {
                        txt_cuentafin.Focus();
                        txt_cuentafin.Text = txt_cuentaini.Text;
                    }
                    else if (this.tipoaux == 2)
                    {
                        txt_cuentafinnit.Focus();
                        txt_cuentafinnit.Text = txt_cuentaininit.Text;
                    }
                    else if (this.tipoaux == 3)
                    {
                        txt_cuefinsinact.Focus();
                        txt_cuefinsinact.Text = txt_cueninisinact.Text;
                    }
                    this.cuentainiyfin = true;
                }
            }
            else if (tb.Text.Contains("*"))
            {
                tb.Text = "**";
                if (this.tipoaux == 1)
                {
                    txt_cuentafin.Text = "**";
                    txt_cuentafin.Enabled = false;
                    menu_botones.Focus();
                }
                else if (this.tipoaux == 2)
                {
                    txt_cuentafinnit.Text = "**";
                    txt_cuentafinnit.Enabled = false;
                    txt_nitininit.Focus();
                }
                else if (this.tipoaux == 3)
                {
                    txt_cuefinsinact.Text = "**";
                    txt_cuefinsinact.Enabled = false;
                    menu_botones.Focus();
                }

                this.cuentainiyfin = true;
            }
            else
            {
                menu_botones.Focus();
                this.cuentainiyfin = true;
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
                    if (this.tipoaux == 1 || this.tipoaux == 3)
                    {
                        menu_botones.Focus();
                    }
                    else if (this.tipoaux == 2)
                    {
                        txt_nitininit.Focus();
                    }

                    this.cuentainiyfin = true;
                }
            }
            else if (tb.Text.Contains("**"))
            {
                this.GetNextControl((Control)sender, true).Text = "CUENTA NO EXISTENTE";
                tb.Focus();
            }
        }

        private void Txt_cuentaini_Enter(object sender, EventArgs e)
        {
            if (this.tipoaux == 1 && this.cuentainiyfin == false)
            {
                txt_cuentafin.Enabled = true;
            }
            else if (this.tipoaux == 2)
            {
                txt_cuentafinnit.Enabled = true;
            }
            else if (this.tipoaux == 3)
            {
                txt_cuefinsinact.Enabled = true;
            }
            else
            {
                this.cuentainiyfin = false;
            }
        }

        private void Txt_cuentaini_TextChanged(object sender, EventArgs e)
        {
            if (this.cuentainiyfin == false)
            {
                if (this.tipoaux == 1)
                {
                    txt_cuentafin.Enabled = true;
                    txt_cuentafin.Text = string.Empty;
                }
                else if (this.tipoaux == 2)
                {
                    txt_cuentafinnit.Enabled = true;
                    txt_cuentafinnit.Text = string.Empty;
                }
                else if (this.tipoaux == 3)
                {
                    txt_cuefinsinact.Enabled = true;
                    txt_cuefinsinact.Text = string.Empty;
                }
            }
            else
            {
                this.cuentainiyfin = false;
            }
        }

        private void ValidacionNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = false;
                SendKeys.Send("{TAB}");
            }
            else
            {
                e.Handled = this.funtions.ValidacionNumerico(e).Handled;
            }
        }

        private void Txtnitini_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (!string.Empty.Equals(tb.Text) && !tb.Text.Contains("*"))
            {
                bool existenit = false;
                try
                {
                    existenit = this.negocioNit.ExisteNit(tb.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                }

                if (existenit)
                {
                    try
                    {
                        this.GetNextControl((Control)sender, true).Text = this.negocioNit.DevolverNombre(tb.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                    }
                    txt_nitfinnit.Text = tb.Text;
                    txt_nitfinnit.Focus();
                }
                else
                {
                    this.GetNextControl((Control)sender, true).Text = "NIT NO EXISTENTE";
                    tb.Focus();
                }
            }
            else if (tb.Text.Contains("*"))
            {
                tb.Text = "**";
                txt_nitfinnit.Text = "**";
                txt_nitfinnit.Enabled = false;
                menu_botones.Focus();
            }
            else
            {
                tb.Focus();
            }
        }

                private void Txt_nitininit_Enter(object sender, EventArgs e)
        {
            txt_nitfinnit.Enabled = true;
        }

        private void Txt_nitininit_TextChanged(object sender, EventArgs e)
        {
            txt_nitfinnit.Enabled = true;
            txt_nitfinnit.Text = string.Empty;
        }

        private void Txt_nitfinnit_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (!string.Empty.Equals(tb.Text) && !tb.Text.Contains("*"))
            {
                bool existenit = false;
                try
                {
                    existenit = this.negocioNit.ExisteNit(tb.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                }

                if (existenit)
                {
                    try
                    {
                        this.GetNextControl((Control)sender, true).Text = this.negocioNit.DevolverNombre(tb.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                    }
                    menu_botones.Focus();
                }
                else
                {
                    this.GetNextControl((Control)sender, true).Text = "NIT NO EXISTENTE";
                    tb.Focus();
                }
            }
            else if (tb.Text.Contains("*"))
            {
                this.GetNextControl((Control)sender, true).Text = "CUENTA NO EXISTENTE";
                tb.Focus();
            }
            else
            {
                tb.Focus();
            }
        }

        #endregion
    }
}
