﻿////*********************************************************
//
//    <copyright file="Form_Presupuesto.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 01 marzo 2014
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
    using Reportes;

    /// <summary>
    /// Clase formulario presupuesto
    /// </summary>
    public partial class Frmpresupuesto : Form
    {
        /// <summary>
        /// instacia el presupuesto de la capa negocios
        /// </summary>
        private Presupueston negocioPresupuesto;

        /// <summary>
        /// instacia la cuenta de la capa negocios
        /// </summary>
        private Cuentan negocioCuenta;

        /// <summary>
        /// instacia la cuenta de la capa negocios
        /// </summary>
        private Centron negocioCentro;

        /// <summary>
        /// variable para manejar cierre de formulario
        /// </summary>
        private bool usrClose;

        private Funciones funtions;

        private int validacuenta;

        private int validacentro;

        private Form_VisualContable frmguar;

        private Form_ReportePresupuesto frmguarreport;

        /// <summary>
        /// Initializes a new instance of the <see cref="Frmpresupuesto"/> class.
        /// </summary>
        public Frmpresupuesto()
        {
            this.negocioPresupuesto = new Presupueston();
            this.negocioCuenta = new Cuentan();
            this.negocioCentro = new Centron();
            this.funtions = new Funciones();
            this.frmguar = new Form_VisualContable();
            this.frmguarreport = new Form_ReportePresupuesto();
            this.InitializeComponent();
            this.AutoCompletar();
        }

        #region PUBLIC METODOS

        /// <summary>
        /// Habilita los botones 
        /// </summary>
        public void BotonesHabit()
        {
            btn_buscar.Enabled = true;
            btn_editar.Enabled = true;
            btn_eliminar.Enabled = true;
            btn_nuevo.Enabled = true;
            btn_generar.Enabled = false;
            btn_imprimir.Enabled = true;
        }

        public void CargarDatos(string anio, string cuenta, int centro)
        {
            List<PresupDataSource> datasSource = new List<PresupDataSource>();
            try
            {
                datasSource = this.negocioPresupuesto.DevolverPresu(anio, cuenta, centro, Program.compa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message, "ERROR");
            }

            this.CamposActivos();
            this.MesesActivos();
            txtanio.ReadOnly = true;
            txtnumcuent.ReadOnly = true;
            txt_centro.ReadOnly = true;
            txtanio.Text = datasSource[0].Anio;
            txtnumcuent.Text = datasSource[0].Cuenta;
            txtnomcue.Text = datasSource[0].NombreCuenta;
            txt_centro.Text = Convert.ToString(datasSource[0].IdCentro);
            txt_descripcentro.Text = datasSource[0].NombreCentro;
            txtenero.Text = this.DevuelvePresupusto(datasSource[0].Presupuesto);
            txtfebrero.Text = this.DevuelvePresupusto(datasSource[1].Presupuesto);
            txtmarzo.Text = this.DevuelvePresupusto(datasSource[2].Presupuesto);
            txtabril.Text = this.DevuelvePresupusto(datasSource[3].Presupuesto);
            txtmayo.Text = this.DevuelvePresupusto(datasSource[4].Presupuesto);
            txtjunio.Text = this.DevuelvePresupusto(datasSource[5].Presupuesto);
            txtjulio.Text = this.DevuelvePresupusto(datasSource[6].Presupuesto);
            txtagosto.Text = this.DevuelvePresupusto(datasSource[7].Presupuesto);
            txtsepti.Text = this.DevuelvePresupusto(datasSource[8].Presupuesto);
            txtoctu.Text = this.DevuelvePresupusto(datasSource[9].Presupuesto);
            txtnov.Text = this.DevuelvePresupusto(datasSource[10].Presupuesto);
            txtdici.Text = this.DevuelvePresupusto(datasSource[11].Presupuesto);
            this.BotonesInhab();
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
            txtenero.Focus();
        }

        #endregion

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

                case Keys.Control | Keys.E:

                    if (btn_editar.Enabled == true)
                    {
                        this.Btn_editar_Click(sender, eve);
                        return true;
                    }

                    break;
                case Keys.Control | Keys.B:

                    if (btn_buscar.Enabled == true)
                    {
                        this.Btn_buscar_Click(sender, eve);
                        return true;
                    }

                    break;
                case Keys.Control | Keys.D:

                    if (btn_eliminar.Enabled == true)
                    {
                        this.Btn_eliminar_Click(sender, eve);
                        return true;
                    }

                    break;
                case Keys.Control | Keys.P:

                    if (btn_imprimir.Enabled == true)
                    {
                        this.Btn_imprimir_Click(sender, eve);
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
                case Keys.Control | Keys.Z:
                    if (btn_cancelar.Enabled == true)
                    {
                        this.Btn_cancelar_Click(sender, eve);
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

        #region VISALIZACION

        /// <summary>
        /// campos y nombres de Meses visibles
        /// </summary>
        private void MesesActivos()
        {
            txtenero.Enabled = true;
            txtfebrero.Enabled = true;
            txtmarzo.Enabled = true;
            txtabril.Enabled = true;
            txtmayo.Enabled = true;
            txtjunio.Enabled = true;
            txtjulio.Enabled = true;
            txtagosto.Enabled = true;
            txtsepti.Enabled = true;
            txtoctu.Enabled = true;
            txtnov.Enabled = true;
            txtdici.Enabled = true;
        }

        private void MesesInactivos()
        {
            txtenero.Enabled = false;
            txtfebrero.Enabled = false;
            txtmarzo.Enabled = false;
            txtabril.Enabled = false;
            txtmayo.Enabled = false;
            txtjunio.Enabled = false;
            txtjulio.Enabled = false;
            txtagosto.Enabled = false;
            txtsepti.Enabled = false;
            txtoctu.Enabled = false;
            txtnov.Enabled = false;
            txtdici.Enabled = false;
        }


        /// <summary>
        /// Campos vacios 
        /// </summary>
        private void CamposVacios()
        {
            txtanio.Clear();
            txtnumcuent.Clear();
            txtnomcue.Clear();
            txt_centro.Clear();
            txt_descripcentro.Clear();
            txtenero.Text = "00.00";
            txtfebrero.Text = "00.00";
            txtmarzo.Text = "00.00";
            txtabril.Text = "00.00";
            txtmayo.Text = "00.00";
            txtjunio.Text = "00.00";
            txtjulio.Text = "00.00";
            txtagosto.Text = "00.00";
            txtsepti.Text = "00.00";
            txtoctu.Text = "00.00";
            txtnov.Text = "00.00";
            txtdici.Text = "00.00";
            this.validacentro = 0;
            this.validacuenta = 0;
        }

        private void CamposActivos()
        {
            txtanio.Enabled = true;
            txtnumcuent.Enabled = true;
            txt_centro.Enabled = true;
        }

        private void AutoCompletar()
        {
            var items = this.negocioCuenta.CargarCuenta();
            AutoCompleteStringCollection cuentas = new AutoCompleteStringCollection();
            foreach (var item in items)
            {
                cuentas.Add(item.Cuenta);
            }

            txtnumcuent.AutoCompleteCustomSource = cuentas;

            var itemsc = this.negocioCentro.CargarCentro();
            AutoCompleteStringCollection centro = new AutoCompleteStringCollection();
            foreach (var item in itemsc)
            {
                centro.Add(Convert.ToString(item.Codcentro));
            }

            txt_centro.AutoCompleteCustomSource = centro;
        }

        /// <summary>
        /// Botones inhabilitados
        /// </summary>
        private void BotonesInhab()
        {
            btn_buscar.Enabled = false;
            btn_editar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_nuevo.Enabled = false;
            btn_cancelar.Enabled = false;
            btn_imprimir.Enabled = false;
        }


        private void BotonesInhabilitados()
        {
            this.btn_guardar.Enabled = false;
            this.btn_editar.Enabled = false;
            this.btn_eliminar.Enabled = false;
            this.btn_imprimir.Enabled = false;
            this.btn_buscar.Enabled = false;
            this.btn_cancelar.Enabled = true;
            this.btn_nuevo.Enabled = false;
            this.btn_generar.Enabled = true;
        }

        private void CamposInactivos()
        {
            txtanio.Enabled = false;
            txtnumcuent.Enabled = false;
            txtnomcue.Enabled = false;
            txt_centro.Enabled = false;
            txt_descripcentro.Enabled = false;
            txtenero.Enabled = false;
            txtfebrero.Enabled = false;
            txtmarzo.Enabled = false;
            txtabril.Enabled = false;
            txtmayo.Enabled = false;
            txtjunio.Enabled = false;
            txtjulio.Enabled = false;
            txtagosto.Enabled = false;
            txtsepti.Enabled = false;
            txtoctu.Enabled = false;
            txtnov.Enabled = false;
            txtdici.Enabled = false;
            menu_botones.Focus();
        }

        #endregion

        #region BOTONES CLICK

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            this.CamposVacios();
            this.CamposActivos();
            this.BotonesInhabilitados();
            this.txtanio.Focus();
            txtanio.ReadOnly = false;
            txtnumcuent.ReadOnly = false;
            txt_centro.ReadOnly = false;
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            Form_VisualContable frm = new Form_VisualContable("presupuesto", "editar", this);
            frm.MdiParent = this.MdiParent;
            this.frmguar = frm;
            frm.Show();
            this.BotonesInhab();
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            Form_VisualContable frm = new Form_VisualContable("presupuesto", "eliminar", this);
            frm.MdiParent = this.MdiParent;
            this.frmguar = frm;
            frm.Show();
            this.BotonesInhab();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            Form_VisualContable frm = new Form_VisualContable("presupuesto", "buscar", this);
            frm.MdiParent = this.MdiParent;
            this.frmguar = frm;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.BotonesInhab();
        }

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            Reportes.Form_ReportePresupuesto frm = new Reportes.Form_ReportePresupuesto(this);
            frm.MdiParent = this.MdiParent;
            this.frmguarreport = frm;
            frm.Show();
            this.BotonesInhab();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (this.ValidarGuardar())
            {
                List<PresupDataSource> presupus = new List<PresupDataSource>();
                presupus = this.GuardarDatos();
                if (txtanio.ReadOnly != true)
                {
                    try
                    {
                        bool guardo = this.negocioPresupuesto.GuardarPresup(presupus);
                        if (guardo)
                        {
                            MessageBox.Show("EL PRESUPUESTO HA SIDO GUARDADO", "GUARDAR", MessageBoxButtons.OK);
                            this.BotonesHabit();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR . " + ex.Message, "ERROR", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    try
                    {
                        bool guardo = this.negocioPresupuesto.UpdatePresupuesto(presupus);
                        MessageBox.Show("EL PRESUPUESTO HA SIDO ACTUALIZADO", "ACTUALIZAR", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR . " + ex.Message, "ERROR", MessageBoxButtons.OK);
                    }
                }

                this.CamposVacios();
                this.CamposInactivos();
            }
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ESTA SEGURO QUE DESEA CANCELAR?", "CANCELAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.CamposVacios();
                this.CamposInactivos();
                this.BotonesHabit();
                this.btn_cancelar.Enabled = false;
                this.Focus();
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ESTA SEGURO QUE DESEA SALIR?", "SALIR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.usrClose = true;
                this.frmguar.Close();
                this.frmguarreport.Close();
                this.Close();
            }
        }

        private void Btn_generar_Click(object sender, EventArgs e)
        {
            if (this.ValidarGuardar())
            {
                this.MesesActivos();
                txtenero.Focus();
                btn_generar.Enabled = false;
            }
        }

        #endregion

        #region EVENTOS TEXTBOX

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
            if (txtanio.Text.Length != 4 || int.Parse(txtanio.Text) < 1900 || int.Parse(txtanio.Text) > 2100)
            {
                tb.Focus();
            }
        }

        private void Txtnumcuent_KeyDown(object sender, KeyEventArgs e)
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
                this.validacuenta = 0;
            }
            if (((!"CUENTA MAYOR".Equals(this.GetNextControl((Control)sender, true).Text)
                && !"CUENTA NO EXISTENTE".Equals(this.GetNextControl((Control)sender, true).Text))) || this.validacuenta == 0)
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
                        MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
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
                string mensaje = this.funtions.ValidarOtraCuenta(tb.Text);

                if (!string.Empty.Equals(mensaje))
                {
                    this.GetNextControl((Control)sender, true).Text = mensaje;
                    this.validacuenta++;
                    tb.Focus();
                }
            }
            else
            {
                tb.Focus();
            }
        }

        private void Txt_centro_KeyUp(object sender, KeyEventArgs e)
        {
            this.validacuenta = 1;
            if ((!"CENTRO NO EXISTE".Equals(txt_descripcentro.Text)
                  && !"EL PRESUPUESTO YA EXISTE".Equals(txt_descripcentro.Text)) || this.validacentro == 0)
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
                        MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
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
                        this.MesesActivos();
                        this.txtenero.Focus();
                        btn_generar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("EL PRESUPUESTO YA EXISTE", "ERROR", MessageBoxButtons.OK);
                        this.CamposVacios();
                        this.validacentro = 1;
                        SendKeys.Send("{TAB}");
                    }
                }
            }
            else if (this.validacuenta != 0)
            {
                tb.Focus();
            }
        }

        private void Txt_centro_Enter(object sender, EventArgs e)
        {
            this.btn_generar.Enabled = true;
        }

        private void TabEnter_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            else
            {
                if (tb.Text.Contains(".") || tb.Text.Contains(","))
                {
                    if (e.KeyChar == 44 || e.KeyChar == 46)
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = this.funtions.ValidacionDecimal(e).Handled;
                    }
                }
                else
                {
                    e.Handled = this.funtions.ValidacionDecimal(e).Handled;
                }
            }
        }

        private void TabEnterDic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = this.funtions.ValidacionDecimal(e).Handled;
            }
        }

        private void Decimal_Leave(object sender, EventArgs e)
        {

            TextBox tb = (TextBox)sender;
            string texto;
            if (tb.Text.Contains("."))
            {
                texto = tb.Text.Replace(".", ",");
            }
            else
            {
                texto = tb.Text;
            }
            decimal numero = default(decimal);
            bool bln = decimal.TryParse(texto, out numero);
            tb.Tag = numero;
            tb.Text = string.Format("{0:00.00}", numero);
        }

        private void Txt_centro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = this.funtions.ValidacionNumerico(e).Handled;
            }
        }

        private void EnterValidar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = this.funtions.ValidacionNumerico(e).Handled;
            }
        }

        #endregion

        #region CERRAR FORMULARIO
        /// <summary>
        /// Handles the FormClosing event of the Frmpresupuesto control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void Frmpresupuesto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.usrClose)
            {
                DialogResult result = MessageBox.Show("ESTA SEGURO QUE DESEA SALIR?", "SALIR", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    this.frmguar.Close();
                    this.frmguarreport.Close();
                }
            }
        }

        #endregion

        #region DATOS

        private List<PresupDataSource> GuardarDatos()
        {
            List<string> meses = new List<string>();
            meses.Add(!txtenero.Text.Equals(string.Empty) ? txtenero.Text : "0");
            meses.Add(!txtfebrero.Text.Equals(string.Empty) ? txtfebrero.Text : "0");
            meses.Add(!txtmarzo.Text.Equals(string.Empty) ? txtmarzo.Text : "0");
            meses.Add(!txtabril.Text.Equals(string.Empty) ? txtabril.Text : "0");
            meses.Add(!txtmayo.Text.Equals(string.Empty) ? txtmayo.Text : "0");
            meses.Add(!txtjunio.Text.Equals(string.Empty) ? txtjunio.Text : "0");
            meses.Add(!txtjulio.Text.Equals(string.Empty) ? txtjulio.Text : "0");
            meses.Add(!txtagosto.Text.Equals(string.Empty) ? txtagosto.Text : "0");
            meses.Add(!txtsepti.Text.Equals(string.Empty) ? txtsepti.Text : "0");
            meses.Add(!txtoctu.Text.Equals(string.Empty) ? txtoctu.Text : "0");
            meses.Add(!txtnov.Text.Equals(string.Empty) ? txtnov.Text : "0");
            meses.Add(!txtdici.Text.Equals(string.Empty) ? txtdici.Text : "0");
            List<PresupDataSource> presupuesto = new List<PresupDataSource>();
            for (int i = 1; i <= 12; i++)
            {
                PresupDataSource presup = new PresupDataSource();
                presup.Anio = txtanio.Text;
                presup.Cuenta = txtnumcuent.Text;
                presup.IdMes = i;
                presup.IdCentro = int.Parse(txt_centro.Text);
                presup.Presupuesto = decimal.Parse(meses[i - 1]);
                presup.IdSucursal = Program.compa;
                presupuesto.Add(presup);
            }

            return presupuesto;
        }

        #endregion

        #region VALIDACIONES

        private bool ExisteCentro()
        {
            bool result = false;
            try
            {
                result = this.negocioCentro.ExisteCentro(int.Parse(txt_centro.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
            }

            return result;
        }

        private bool ExistePresupuesto()
        {
            bool validapresupuesto = true;
            try
            {
                validapresupuesto = this.negocioPresupuesto.ExistePresupuesto(txtanio.Text, txtnumcuent.Text, int.Parse(txt_centro.Text), Program.compa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
            }

            return validapresupuesto;
        }

        private bool ValidarGuardar()
        {
            bool result = false;
            if (!string.Empty.EndsWith(txtanio.Text) && !string.Empty.Equals(txtnumcuent.Text) && !string.Empty.Equals(txt_centro.Text))
            {
                bool existecuenta = false;
                bool existecentro = false;
                bool validoanio = int.Parse(txtanio.Text) > 1900 && int.Parse(txtanio.Text) < 2100;
                try
                {
                    existecuenta = this.negocioCuenta.ExisteCuenta(txtnumcuent.Text);
                    existecentro = this.negocioCentro.ExisteCentro(int.Parse(txt_centro.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
                }

                if (existecuenta && existecentro && validoanio)
                {
                    bool existepres = false;
                    try
                    {
                        existepres = this.negocioPresupuesto.ExistePresupuesto(txtanio.Text, txtnumcuent.Text, int.Parse(txt_centro.Text), Program.compa);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
                    }

                    if (!existepres || txtanio.ReadOnly)
                    {
                        result = true;
                    }
                    else
                    {
                        MessageBox.Show("EL PRESUPUESTO YA EXISTE", "ERROR", MessageBoxButtons.OK);
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

        #endregion

        #region  METODOS BOTONES

        /// <summary>
        /// Devuelve presupusto
        /// </summary>
        /// <param name="cantidad">cantidad de presupuesto</param>
        /// <returns>la cantidad de presupuesto en string</returns>
        private string DevuelvePresupusto(decimal cantidad)
        {
            string cant = !cantidad.Equals(0) ? Convert.ToString(cantidad) : "0";
            return cant;
        }

        #endregion
    }
}