﻿////*********************************************************
//
//    <copyright file="Form_Comprobantes.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 01 marzo 2014
//    </copyright>
//
////*********************************************************
namespace App.Forms.Contable
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Windows.Forms;
    using Entities.Types;
    using Negocios.Contable;
    using Reportes;

    /// <summary>
    /// Clase formulario comprobantes 
    /// </summary>
    public partial class Frmcomprobantes : Form
    {
        /// <summary>
        /// instancia de comprobantes de la capa negocios
        /// </summary>
        private Comprobantesn negociocompro;

        /// <summary>
        /// variable para manejar cierre de formulario
        /// </summary>
        private bool usrClose;

        private Funciones funtions;

        private Form_VisualContable frmguar;

        private Form_ReporteComprobante frmreporguar;

        /// <summary>
        /// Initializes a new instance of the <see cref="Frmcomprobantes"/> class.
        /// </summary>
        public Frmcomprobantes()
        {
            this.frmguar = new Form_VisualContable();
            this.frmreporguar = new Form_ReporteComprobante();
            this.InitializeComponent();
            this.negociocompro = new Comprobantesn();
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

        public void CargarDatos(int idcompro)
        {
            ComprobantesDataSource compedit = new ComprobantesDataSource();
            try
            {
                compedit = this.negociocompro.DevolverDatos(idcompro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un error. " + ex.Message);
            }

            txt_codigo.Text = Convert.ToString(compedit.Codigo);
            txt_nombre.Text = compedit.Descricompro;
            check_consecutivo.Checked = compedit.Consecutivo;
            txt_numeroini.Text = Convert.ToString(compedit.Numerosigui);
            txt_conversi.Text = compedit.Codigootra;
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
        /// Campos activos.
        /// </summary>
        private void CamposActivos()
        {
            txt_codigo.Enabled = true;
            txt_nombre.Enabled = true;
            txt_numeroini.Enabled = true;
            check_consecutivo.Enabled = true;
            txt_conversi.Enabled = true;
        }

        /// <summary>
        /// Campos inactivos.
        /// </summary>
        private void CamposInactivos()
        {
            txt_codigo.Enabled = false;
            txt_nombre.Enabled = false;
            txt_numeroini.Enabled = false;
            check_consecutivo.Enabled = false;
            txt_conversi.Enabled = false;
            btn_guardar.Enabled = false;
            menu_botones.Focus();
        }

        /// <summary>
        /// Campos vacios
        /// </summary>
        private void CamposVacios()
        {
            txt_codigo.Clear();
            txt_nombre.Clear();
            txt_numeroini.Clear();
            check_consecutivo.Checked = false;
            txt_conversi.Clear();
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
            Form_VisualContable frm = new Form_VisualContable("comprobante", "editar", this);
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
            Form_VisualContable frm = new Form_VisualContable("comprobante", "eliminar", this);
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

        /// <summary>
        /// click en el boton imprimir
        /// </summary>
        /// <param name="sender">El origen del evento</param>
        /// <param name="e">The <see cref="EventArgs"/>  instancia que contiene los datos del evento</param>
        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            Form_ReporteComprobante frm = new Form_ReporteComprobante(this);
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
            if (this.ValidarGuardar())
            {
                ComprobantesDataSource compro = new ComprobantesDataSource();
                compro = this.GuardarCampos();
                if (txt_codigo.ReadOnly == false)
                {
                    try
                    {
                        this.negociocompro.GuardarComp(compro);
                        MessageBox.Show("EL COMPROBANTE HA SIDO GUARDADO", "GUARDAR", MessageBoxButtons.OK);
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
                        this.negociocompro.ActualizarCompro(compro);
                        MessageBox.Show("EL COMPROBANTE HA SIDO ACTUALIZADO", "ACTUALIZAR", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message, "ERROR");
                    }
                }
            }

            this.CamposVacios();
            this.CamposInactivos();
            this.BotonesHabit();
            btn_cancelar.Enabled = false;
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

        private bool ValidarGuardar()
        {
            if (!string.Empty.Equals(txt_codigo.Text) && !string.Empty.Equals(txt_nombre.Text) && !string.Empty.Equals(txt_conversi.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("POR FAVOR INGRESE TODOS LOS CAMPOS", "ERROR", MessageBoxButtons.OK);
                return false;
            }
        }

        /// <summary>
        /// Guardar campos
        /// </summary>
        /// <returns>tipo de comprobante a guardar</returns>
        private ComprobantesDataSource GuardarCampos()
        {
            ComprobantesDataSource comp = new ComprobantesDataSource();
            comp.Codigo = int.Parse(txt_codigo.Text);
            comp.Descricompro = txt_nombre.Text;
            comp.Consecutivo = check_consecutivo.Checked;
            comp.Numerosigui = int.Parse(txt_numeroini.Text);
            comp.Codigootra = txt_conversi.Text;
            return comp;
        }

        #endregion

        #region SALIR FORMULARIO

        /// <summary>
        /// Handles the FormClosing event of the Frmcomprobantes control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void Frmcomprobantes_FormClosing(object sender, FormClosingEventArgs e)
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

        private void EnterTab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void EnterTabVal_KeyPress(object sender, KeyPressEventArgs e)
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

        #endregion
    }
}
