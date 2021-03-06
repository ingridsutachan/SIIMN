﻿////*********************************************************
//
//    <copyright file="Form_CodigoTributario.cs" company="Marketing Software de Colombia LTDA">
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

    /// <summary>
    /// Formulario codigo tributario
    /// </summary>
    public partial class FrmTributario : Form
    {
        /// <summary>
        /// persistencia para el negocio de codigo tributario
        /// </summary>
        private tributariosn negociotributario;

        private Nitsn negocioNits;

        /// <summary>
        /// variable para manejar cierre de formulario
        /// </summary>
        private bool usrClose;

        private Funciones funtions;

        private Form_VisualContable frmguar;

        private Form_ReporteTributario frmreporguar;

        private int validanit;

        /// <summary>
        /// Initializes a new instance of the <see cref="FrmTributario"/> class.
        /// </summary>
        public FrmTributario()
        {
            this.frmguar = new Form_VisualContable();

            this.frmreporguar = new Form_ReporteTributario();

            this.InitializeComponent();

            this.negociotributario = new tributariosn();

            this.negocioNits = new Nitsn();

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

        public void CargarDatos(string codigtrib)
        {
            TributarioDataSource tributedit = new TributarioDataSource();
            try
            {
                tributedit = this.negociotributario.DevolverDatos(codigtrib);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un error. " + ex.Message);
            }

            txt_codigo.Text = tributedit.Codigo;
            txt_nombre.Text = tributedit.NombreTrib;
            txt_tope.Text = Convert.ToString(tributedit.Tope);
            txt_nittope.Text = Convert.ToString(tributedit.IdNitTope);
            btn_guardar.Enabled = true;
            this.CamposActivos();
            txt_nombre.Focus();
            txt_codigo.ReadOnly = true;
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

        #region VISUALIZACION

        /// <summary>
        /// Camposes the activos.
        /// </summary>
        private void CamposActivos()
        {
            txt_codigo.Enabled = true;
            txt_nombre.Enabled = true;
            txt_tope.Enabled = true;
            txt_nittope.Enabled = true;
        }

        /// <summary>
        /// Camposes the inactivos.
        /// </summary>
        private void CamposInactivos()
        {
            txt_codigo.Enabled = false;
            txt_nombre.Enabled = false;
            txt_tope.Enabled = false;
            txt_nittope.Enabled = false;
            btn_guardar.Enabled = false;
            menu_botones.Focus();
        }

        /// <summary>
        /// Camposes the vacios.
        /// </summary>
        private void CamposVacios()
        {
            txt_codigo.Clear();
            txt_nombre.Clear();
            txt_tope.Clear();
            txt_nittope.Clear();
            txt_nombrenito.Clear();
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

        #endregion

        #region BOTONES CLICK

        /// <summary>
        /// Handles the Click event of the Btn_nuevo control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            this.CamposActivos();
            this.BotonesInhabilitados();
            btn_guardar.Enabled = true;
            this.txt_codigo.Focus();
            txt_codigo.ReadOnly = false;
        }

        /// <summary>
        /// Handles the Click event of the Btn_editar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Btn_editar_Click(object sender, EventArgs e)
        {
            Form_VisualContable frm = new Form_VisualContable("tributario", "editar", this);
            this.frmguar = frm;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.BotonesInhab();
        }

        /// <summary>
        /// Handles the Click event of the Btn_eliminar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            Form_VisualContable frm = new Form_VisualContable("tributario", "eliminar", this);
            this.frmguar = frm;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.BotonesInhab();
            this.CamposVacios();
            this.CamposInactivos();
        }

        /// <summary>
        /// Handles the Click event of the Btn_buscar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            Form_VisualContable frm = new Form_VisualContable("comprobante", "buscar", this);
            this.frmguar = frm;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.BotonesInhab();
        }

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            Form_ReporteTributario frm = new Form_ReporteTributario(this);
            this.frmreporguar = frm;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.BotonesInhab();
        }

        /// <summary>
        /// Handles the Click event of the Btn_guardar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            bool guardar = this.ValidarGuardar();
            if (guardar)
            {
                TributarioDataSource tribut = new TributarioDataSource();
                tribut = this.GuardarCampos();

                if (txt_codigo.ReadOnly == false)
                {
                    try
                    {
                        bool guardarg = this.negociotributario.GuardarTribut(tribut);
                        if (guardarg)
                        {
                            MessageBox.Show("El CODIGO TRIBUTARIO HA SIDO GUARDARDO", "GUARDAR", MessageBoxButtons.OK);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR    " + ex.Message, "ERROR", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    try
                    {
                        bool guardara = this.negociotributario.ActualizarTribut(tribut);
                        if (guardara)
                        {
                            MessageBox.Show("El CODIGO TRIBUTARIO HA SIDO ACTUALIZADO", "ACTUALIZAR", MessageBoxButtons.OK);
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

        /// <summary>
        /// Handles the Click event of the Salircuent control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        #region GUARDAR DATOS

        /// <summary>
        /// Guardars the campos.
        /// </summary>
        /// <returns>tipo de tabla codigo tributario campos guardados</returns>
        private TributarioDataSource GuardarCampos()
        {
            TributarioDataSource trib = new TributarioDataSource();
            trib.Codigo = txt_codigo.Text;
            trib.NombreTrib = txt_nombre.Text;
            trib.Tope = !string.Empty.Equals(txt_tope.Text) ? decimal.Parse(txt_tope.Text) : 0;
            trib.IdNitTope = !string.Empty.Equals(txt_nittope.Text) ? this.negocioNits.DevolverId(txt_nittope.Text) : null;
            return trib;
        }

        /// <summary>
        /// Validars the guardar.
        /// </summary>
        /// <returns>booleano si guarda o no</returns>
        private bool ValidarGuardar()
        {
            bool result = false;
            if (!txt_codigo.Text.Equals(string.Empty) && !txt_nombre.Text.Equals(string.Empty))
            {
                if (!this.negociotributario.ExisteTributario(txt_codigo.Text))
                {
                    result = true;
                }
                else
                {
                    if (txt_codigo.ReadOnly == false)
                    {
                        result = false;
                        MessageBox.Show("EL CODIGO QUE DESEA INGRESAR YA EXISTE", "ERROR", MessageBoxButtons.OK);
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

        #endregion

        #region SALIR FORMULARIO

        /// <summary>
        /// Handles the FormClosing event of the FrmTributario control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void FrmTributario_FormClosing(object sender, FormClosingEventArgs e)
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

        private void EnterValida_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Decimal_KeyPress(object sender, KeyPressEventArgs e)
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

        /// <summary>
        /// evento cuando sale al textbox porcentaje de retencion
        /// </summary>
        /// <param name="sender">el origen del evento</param>
        /// <param name="e">The <see cref="EventArgs"/> instancia contiene datos del evento</param>
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

        private void Txt_nittope_Leave(object sender, EventArgs e)
        {
            if (!string.Empty.Equals(txt_nittope.Text))
            {
                bool existenit = false;
                try
                {
                    existenit = this.negocioNits.ExisteNit(txt_nittope.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                }

                if (existenit)
                {
                    try
                    {
                        txt_nombrenito.Text = this.negocioNits.DevolverNombre(txt_nittope.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR    " + ex.Message, "ERROR", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    txt_nombrenito.Text = "NIT NO EXISTENTE";
                    this.validanit = 1;
                    txt_nittope.Focus();
                }
            }
            else
            {
                if (this.validanit != 0)
                {
                    txt_nittope.Focus();
                }
            }
        }

        #endregion
    }
}
