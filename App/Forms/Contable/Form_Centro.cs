﻿////*********************************************************
//
//    <copyright file="Form_Centro.cs" company="Marketing Software de Colombia LTDA">
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
    using App.Forms.Contable.Reportes;

    /// <summary>
    /// Calse formulario centro
    /// </summary>
    public partial class Frmcentro : Form
    {
        /// <summary>
        /// instacia de la capa de negocios de centro de costos
        /// </summary>
        private Centron negociocentro;

        /// <summary>
        /// variable para manejar cierre de formulario
        /// </summary>
        private bool usrClose;

        private Form_VisualContable frmguar;

        private Form_ReporteCentro frmreporguar;

        private Funciones funtions;

        private Form_Asientos form_Asientos;

        private string tipoform;

        private bool estado;

        /// <summary>
        /// Initializes a new instance of the <see cref="Frmcentro"/> class.
        /// </summary>
        public Frmcentro()
        {
            this.frmguar = new Form_VisualContable();
            this.frmreporguar = new Form_ReporteCentro();
            this.InitializeComponent();
            this.negociocentro = new Centron();
            this.funtions = new Funciones();
        }

        public Frmcentro(string tipof, string centro, Form_Asientos form_Asientos)
        {
            this.tipoform = tipof;
            this.estado = false;
            this.form_Asientos = form_Asientos;
            this.InitializeComponent();
            txt_codigo.Focus();
            this.negociocentro = new Centron();
            this.funtions = new Funciones();
            this.AgregarCentro(centro);
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
            CentroDataSource compedit = new CentroDataSource();
            try
            {
                compedit = this.negociocentro.DevolverDatos(idcompro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un error. " + ex.Message);
            }

            txt_codigo.Text = Convert.ToString(compedit.Codcentro);
            txt_nombre.Text = compedit.Nombrecentro;
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
            txt_codigo.Enabled = true;
            txt_nombre.Enabled = true;
        }

        /// <summary>
        /// Campos inactivos.
        /// </summary>
        private void CamposInactivos()
        {
            txt_codigo.Enabled = false;
            txt_nombre.Enabled = false;
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

            Form_VisualContable frm = new Form_VisualContable("centro", "editar", this);
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
            Form_VisualContable frm = new Form_VisualContable("centro", "eliminar", this);
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
            Form_VisualContable frm = new Form_VisualContable("centro", "buscar", this);
            this.frmguar = frm;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.BotonesInhab();
        }


        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            Form_ReporteCentro frm = new Form_ReporteCentro(this);
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
                CentroDataSource cen = new CentroDataSource();
                cen = this.GuardarCampos();
                if (txt_codigo.ReadOnly == false)
                {
                    try
                    {
                        bool guardar = this.negociocentro.GuardarCentro(cen);
                        if (guardar)
                        {
                            if ("asiento".Equals(this.tipoform))
                            {
                                form_Asientos.CargarCentro(Convert.ToString(cen.Codcentro));
                                this.estado = true;
                                this.Close();
                            }

                            MessageBox.Show("EL CENTRO DE COSTOS HA SIDO GUARDADO", "GUARDAR", MessageBoxButtons.OK);
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
                        bool guardo = this.negociocentro.ActualizarCentro(cen);
                        if (guardo)
                        {
                            MessageBox.Show("EL CENTRO HA SIDO ACTUALIZADO", "ACTUALIZAR", MessageBoxButtons.OK);
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
                if ("asiento".Equals(this.tipoform))
                {
                    form_Asientos.SalirCentro();
                }
                else
                {
                    this.frmguar.Close();
                    this.frmreporguar.Close();
                }
                this.usrClose = true;
                this.Close();
            }
        }

        #endregion

        #region DATOS

        /// <summary>
        /// Guardar campos
        /// </summary>
        /// <returns>centro de costos con los campos a guardar</returns>
        private CentroDataSource GuardarCampos()
        {
            CentroDataSource cen = new CentroDataSource();
            cen.Codcentro = int.Parse(txt_codigo.Text);
            cen.Nombrecentro = txt_nombre.Text;
            return cen;
        }

        private void AgregarCentro(string centro)
        {
            EventArgs e = new EventArgs();
            object sender = new object();
            this.Btn_nuevo_Click(sender, e);
            txt_codigo.Text = centro;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = false;
            txt_codigo.Focus();
        }

        #endregion

        #region SALIR FORMULARIO

        /// <summary>
        /// Handles the FormClosing event of the Frmcentro control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void Frmcentro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.usrClose)
            {
                if (this.estado != true)
                {
                    DialogResult result = MessageBox.Show("ESTA SEGURO QUE DESEA SALIR?", "SALIR", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        if ("asiento".Equals(this.tipoform))
                        {
                            form_Asientos.SalirCentro();
                        }
                        this.frmguar.Close();
                        this.frmreporguar.Close();
                    }
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

        private bool ValidarGuardar()
        {
            bool result = false;
            if (!string.Empty.Equals(txt_codigo.Text) && !string.Empty.Equals(txt_nombre.Text))
            {
                if (!this.negociocentro.ExisteCentro(int.Parse(txt_codigo.Text)))
                {
                    result = true;
                }
                else
                {
                    if (txt_codigo.ReadOnly == false)
                    {
                        MessageBox.Show("EL CODIGO INGRESADO YA EXISTE", "ERROR", MessageBoxButtons.OK);
                        result = false;
                    }
                    else
                    {
                        result = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("POR FAVOR INGRESE TODOS LOS DATOS", "ERROR", MessageBoxButtons.OK);
                result = false;
            }

            return result;
        }

        #endregion
    }
}
