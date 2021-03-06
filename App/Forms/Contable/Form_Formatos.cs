﻿////*********************************************************
//
//    <copyright file="Form_Formatos.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 26 febrero 2015
//    </copyright>
//
////*********************************************************

namespace App.Forms.Contable
{
    using System;
    using System.Windows.Forms;
    using App.Forms.Contable.Reportes;
    using Entities.Types;
    using Negocios.Contable;

    public partial class Form_Formatos : Form
    {
        private Formatosn negocioFormato;

        private Cuentan negocioCuenta;

        private bool usrClose;

        private Funciones funtions;

        private Form_VisualContable frmguar;

        private Form_ReporteFormato frmreporguar;

        private int validaotrascuentas;

        public Form_Formatos()
        {
            this.InitializeComponent();
            this.frmguar = new Form_VisualContable();
            this.frmreporguar = new Form_ReporteFormato();
            this.negocioFormato = new Formatosn();
            this.negocioCuenta = new Cuentan();
            this.funtions = new Funciones();
        }

        #region METODOS PUBLICOS

        /// <summary>
        /// Habilita los botones 
        /// </summary>
        public void BotonesHabit()
        {
            btn_buscar.Enabled = true;
            btn_editar.Enabled = true;
            btn_eliminar.Enabled = true;
            btn_nuevo.Enabled = true;
            btn_imprimir.Enabled = true;
        }

        public void CargarDatos(string clase, string linea, string tipofor)
        {
            FormatoDataSource formatoedit = new FormatoDataSource();
            try
            {
                formatoedit = this.negocioFormato.DevolverFormato(tipofor, clase, linea);
                txt_encabezado.Text = this.negocioFormato.DevolverEncabezado(int.Parse(tipofor));
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
            }

            cbx_tipo.SelectedIndex = tipofor.Equals("1") ? 0 : 1;
            txt_clase.Text = formatoedit.ClaseCuenta;
            txt_linea.Text = formatoedit.Linea;
            txt_nombre.Text = formatoedit.Nombre;
            txt_cuentaini.Text = formatoedit.CuentaInicial;
            txt_cuentafin.Text = formatoedit.CuentaFinal;
            btn_guardar.Enabled = true;
            this.CamposActivos();
            txt_encabezado.Focus();
            cbx_tipo.Enabled = false;
            this.BotonesInhab();
            this.btn_cancelar.Enabled = true;
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
                        this.btn_editar.ShowDropDown();
                        return true;
                    }

                    break;

                case Keys.Control | Keys.B:

                    if (btn_buscar.Enabled == true)
                    {
                        this.btn_buscar.ShowDropDown();
                        return true;
                    }

                    break;

                case Keys.Control | Keys.D:

                    if (btn_eliminar.Enabled == true)
                    {
                        this.btn_eliminar.ShowDropDown();
                        return true;
                    }

                    break;

                case Keys.Control | Keys.P:

                    if (btn_imprimir.Enabled == true)
                    {
                        this.btn_imprimir.ShowDropDown();
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

            txt_cuentaini.AutoCompleteCustomSource = cuentas;
            txt_cuentafin.AutoCompleteCustomSource = cuentas;
        }

        private void BotonesInhabilitados()
        {
            this.btn_editar.Enabled = false;
            this.btn_eliminar.Enabled = false;
            this.btn_imprimir.Enabled = false;
            this.btn_buscar.Enabled = false;
            this.btn_cancelar.Enabled = true;
            this.btn_nuevo.Enabled = false;
        }

        private void BotonesInhab()
        {
            btn_buscar.Enabled = false;
            btn_editar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_nuevo.Enabled = false;
            btn_cancelar.Enabled = false;
            btn_imprimir.Enabled = false;
        }

        private void CamposActivos()
        {
            cbx_tipo.Enabled = true;
            txt_encabezado.Enabled = true;
            txt_clase.Enabled = true;
            txt_linea.Enabled = true;
            txt_nombre.Enabled = true;
            txt_cuentafin.Enabled = true;
            txt_cuentaini.Enabled = true;
        }

        private void CamposInactivos()
        {
            cbx_tipo.Enabled = false;
            txt_encabezado.Enabled = false;
            txt_clase.Enabled = false;
            txt_linea.Enabled = false;
            txt_nombre.Enabled = false;
            txt_cuentafin.Enabled = false;
            txt_cuentaini.Enabled = false;
            btn_guardar.Enabled = false;
            menu_botones.Focus();
        }

        private void CamposVacios()
        {
            cbx_tipo.ResetText();
            txt_encabezado.Clear();
            txt_clase.Clear();
            txt_linea.Clear();
            txt_nombre.Clear();
            txt_cuentafin.Clear();
            txt_cuentaini.Clear();
            txt_nombrecuentafin.Clear();
            txt_nombrecuentaini.Clear();
        }

        #endregion

        #region BOTONES CLICK

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            this.CamposActivos();
            this.BotonesInhabilitados();
            btn_guardar.Enabled = true;
            this.cbx_tipo.Focus();
            cbx_tipo.SelectedIndex = 0;
            this.AutoCompletar();
        }

        private void Btn_EditarBalance_Click(object sender, EventArgs e)
        {
            Form_VisualContable frm = new Form_VisualContable("formato", "editar", "1", this);
            this.frmguar = frm;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.BotonesInhab();
        }

        private void Btn_Editarpyg_Click(object sender, EventArgs e)
        {
            Form_VisualContable frm = new Form_VisualContable("formato", "editar", "2", this);
            this.frmguar = frm;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.BotonesInhab();
        }

        private void Btn_EliminarBalance_Click(object sender, EventArgs e)
        {
            Form_VisualContable frm = new Form_VisualContable("formato", "eliminar", "1", this);
            this.frmguar = frm;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.BotonesInhab();
            this.CamposVacios();
            this.CamposInactivos();
        }

        private void Btn_Eliminarpyg_Click(object sender, EventArgs e)
        {
            Form_VisualContable frm = new Form_VisualContable("formato", "eliminar", "2", this);
            this.frmguar = frm;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.BotonesInhab();
            this.CamposVacios();
            this.CamposInactivos();
        }

        private void Btn_buscarbalance_Click(object sender, EventArgs e)
        {
            Form_VisualContable frm = new Form_VisualContable("formato", "buscar", "1", this);
            this.frmguar = frm;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.BotonesInhab();
        }

        private void Btn_buscarpyg_Click(object sender, EventArgs e)
        {
            Form_VisualContable frm = new Form_VisualContable("formato", "buscar", "2", this);
            this.frmguar = frm;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.BotonesInhab();
        }

        private void Btn_imprimirbalance_Click(object sender, EventArgs e)
        {
            Form_ReporteFormato frm = new Form_ReporteFormato(this, "1");
            this.frmreporguar = frm;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.BotonesInhab();
        }

        private void Btn_imprimirpyg_Click(object sender, EventArgs e)
        {
            Form_ReporteFormato frm = new Form_ReporteFormato(this, "2");
            this.frmreporguar = frm;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.BotonesInhab();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            bool validar = this.ValidarGuardar();
            if (validar)
            {
                FormatoDataSource formato = new FormatoDataSource();
                formato = this.GuardarDatos();
                if (cbx_tipo.Enabled == true)
                {
                    try
                    {
                        bool guardar = this.negocioFormato.GuardarFormato(formato, txt_encabezado.Text);
                        if (guardar)
                        {
                            MessageBox.Show("EL FORMATO HA SIDO GUARDADO", "GUARDAR", MessageBoxButtons.OK);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message, "ERROR");
                    }
                }
                else
                {
                    try
                    {
                        bool guardar = this.negocioFormato.ActualizarFormato(formato, txt_encabezado.Text);
                        if (guardar)
                        {
                            MessageBox.Show("EL FROMATO HA SIDO ACTUALIZADO", "GUARDAR", MessageBoxButtons.OK);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message, "ERROR");
                    }
                }

                this.CamposVacios();
                this.CamposInactivos();
                this.BotonesHabit();
                btn_cancelar.Enabled = false;
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
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ESTA SEGURO QUE DESEA SALIR?", "SALIR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.usrClose = true;
                this.Close();
                this.frmguar.Close();
                this.frmreporguar.Close();
            }
        }

        #endregion

        #region   GUARDAR DATOS

        private FormatoDataSource GuardarDatos()
        {
            FormatoDataSource format = new FormatoDataSource();
            format.TipoFormato = cbx_tipo.SelectedItem.ToString() == "BALANCE GENERAL" ? "1" : "2";
            format.ClaseCuenta = txt_clase.Text;
            format.Linea = txt_linea.Text;
            format.Nombre = txt_nombre.Text;
            format.CuentaInicial = txt_cuentaini.Text;
            format.CuentaFinal = txt_cuentafin.Text;
            return format;
        }

        #endregion

        #region SAlIR FORMULARIO

        private void Frm_formatos_FormClosing(object sender, FormClosingEventArgs e)
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
                    this.frmreporguar.Close();
                }
            }
        }

        #endregion

        #region VALIDACIONES

        private bool ValidarGuardar()
        {
            bool result = false;
            if (!txt_encabezado.Text.Equals(string.Empty) && !txt_clase.Text.Equals(string.Empty) && !txt_linea.Text.Equals(string.Empty) && !txt_nombre.Text.Equals(string.Empty) &&
                !txt_cuentaini.Text.Equals(string.Empty) && !txt_cuentafin.Text.Equals(string.Empty))
            {
                bool existe = false;
                FormatoDataSource format = new FormatoDataSource();
                format = this.GuardarDatos();
                try
                {
                    existe = this.negocioFormato.ExisteFormato(format);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
                }

                if (!existe)
                {
                    result = true;
                }
                else
                {
                    if (cbx_tipo.Enabled == true)
                    {
                        result = false;
                        MessageBox.Show("EL FORMATO QUE DESEA INGRESAR YA EXISTE", "ERROR", MessageBoxButtons.OK);
                    }
                    else
                    {
                        result = true;
                    }
                }
            }
            else
            {
                result = false;
                MessageBox.Show("POR FAVOR INGRESE TODOS LOS CAMPOS", "ERROR", MessageBoxButtons.OK);
            }

            return result;
        }

        private void Cbx_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Cbx_tipo_Leave(object sender, EventArgs e)
        {
            int idformat = cbx_tipo.SelectedIndex == 0 ? 1 : 2;
            try
            {
                txt_encabezado.Text = this.negocioFormato.DevolverEncabezado(idformat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
            }
        }

        /// <summary>
        /// Evento que se genera al presionar una tecla y valida campo numerico
        /// </summary>
        /// <param name="sender">el origen del evento</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> contiene los datos de la tecla presionada</param>
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

        private void Txt_Cuenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = false;
                SendKeys.Send("{TAB}");
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

        private void TabVal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void EnterTab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void Cbx_tipo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        #endregion

        private void txt_encabezado_Enter(object sender, EventArgs e)
        {
            int idformat = cbx_tipo.SelectedIndex == 0 ? 1 : 2;
            try
            {
                txt_encabezado.Text = this.negocioFormato.DevolverEncabezado(idformat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
            }
        }
    }
}
