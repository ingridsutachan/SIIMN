﻿////*********************************************************
//
//    <copyright file="Form_Nits.cs" company="Marketing Software de Colombia LTDA">
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
    /// Clase de formulario de nits
    /// </summary>
    public partial class Frmnits : Form
    {
        /// <summary>
        /// instacia nit de la capa negocios
        /// </summary>
        private Nitsn negocioNit;

        /// <summary>
        /// instacia tipos de nit de la capa negocios
        /// </summary>
        private Tiponitn negocioTipos;

        /// <summary>
        /// instacia ubicacion de la capa negocios
        /// </summary>
        private Ubicacionn negociosUbicacion;

        /// <summary>
        /// variable para manejar cierre de formulario
        /// </summary>
        private bool usrClose;

        private Funciones funtions;

        private Form_VisualContable frmguar;

        private Form_ReporteNits frmreporguar;

        private string tipoform;

        private Form_Asientos form_Asientos;

        private bool estado;

        /// <summary>
        /// Initializes a new instance of the <see cref="Frmnits"/> class.
        /// </summary>
        public Frmnits()
        {
            this.negocioNit = new Nitsn();
            this.negocioTipos = new Tiponitn();
            this.negociosUbicacion = new Ubicacionn();
            this.funtions = new Funciones();
            this.frmguar = new Form_VisualContable();
            this.frmreporguar = new Form_ReporteNits();
            this.InitializeComponent();
        }

        public Frmnits(string tipof, string nit, Form_Asientos form_Asientos)
        {
            // TODO: Complete member initialization
            this.tipoform = tipof;
            this.form_Asientos = form_Asientos;
            this.negocioNit = new Nitsn();
            this.negocioTipos = new Tiponitn();
            this.negociosUbicacion = new Ubicacionn();
            this.funtions = new Funciones();
            this.InitializeComponent();
            this.AgregarOtro(nit);
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

        public void CargarDatos(string nit)
        {
            NitsDataSource nits = new NitsDataSource();
            btn_guardar.Enabled = true;

            try
            {
                nits = this.negocioNit.DevolverNitsCompleto(nit);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un error. " + ex.Message);
            }

            this.CamposActivos();
            this.CargarCombos();
            combo_tipo.SelectedValue = nits.Tiponit;
            this.CargarDeptos(nits.IdPais);
            this.CargarCiudades(nits.IdDepto);
            combo_pais.SelectedValue = nits.IdPais;
            combo_dpto.SelectedValue = nits.IdDepto;
            combo_ciudad.SelectedValue = nits.Idciudad;
            txt_numeronit.Text = nits.Nit;
            txt_digito.Text = nits.Digito;
            txt_nombre.Text = nits.Nombrenit;
            txt_actividad.Text = nits.ActividadEconomica;
            txt_direccion.Text = nits.Direccion;
            txt_telefono.Text = nits.Telefono;
            txt_celular.Text = nits.Celular;
            txt_email.Text = nits.Email;
            txt_digito.Focus();
            txt_numeronit.ReadOnly = true;
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

        /// <summary>
        /// Cargar los paises en el combobox
        /// </summary>
        private void CargarCombos()
        {
            List<PaisDataSource> pais = new List<PaisDataSource>();
            List<TiposNitsDataSource> tiponit = new List<TiposNitsDataSource>();
            try
            {
                pais = this.negociosUbicacion.CargarPais();
                tiponit = this.negocioTipos.CargarTipos();
                if (pais.Count > 0)
                {
                    combo_pais.DataSource = pais;
                    combo_pais.ValueMember = "idpais";
                    combo_pais.DisplayMember = "nombrepais";
                }

                if (tiponit.Count > 0)
                {
                    combo_tipo.DataSource = tiponit;
                    combo_tipo.ValueMember = "idtipo";
                    combo_tipo.DisplayMember = "nombretipo";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
            }
        }

        /// <summary>
        /// Cargar los departamentos en el combobox
        /// </summary>
        /// <param name="idpais">The idpais.</param>
        private bool CargarDeptos(int idpais)
        {
            List<DeptoDataSource> depto = new List<DeptoDataSource>();
            bool result = false;
            try
            {
                depto = this.negociosUbicacion.CargarDeptos(idpais);
                if (depto.Count > 0)
                {
                    combo_dpto.DataSource = depto;
                    combo_dpto.ValueMember = "iddpto";
                    combo_dpto.DisplayMember = "nombredpto";
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
            }

            return result;
        }

        /// <summary>
        /// Cargar las ciudades en el combobox
        /// </summary>
        /// <param name="iddepto">The iddepto.</param>
        private bool CargarCiudades(int iddepto)
        {
            List<CiudadDataSource> ciud = new List<CiudadDataSource>();
            bool result = false;
            try
            {
                ciud = this.negociosUbicacion.CargarCiudad(iddepto);
                if (ciud.Count > 0)
                {
                    combo_ciudad.DataSource = ciud;
                    combo_ciudad.ValueMember = "idciudad";
                    combo_ciudad.DisplayMember = "nombreciudad";
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
            }

            return result;
        }

        /// <summary>
        /// Campos limpios
        /// </summary>
        private void CamposLimpios()
        {
            txt_numeronit.Clear();
            txt_digito.Clear();
            txt_nombre.Clear();
            txt_actividad.Clear();
            txt_direccion.Clear();
            combo_pais.ResetText();
            combo_dpto.ResetText();
            combo_tipo.ResetText();
            combo_ciudad.ResetText();
            txt_telefono.Clear();
            txt_celular.Clear();
            txt_email.Clear();
        }

        /// <summary>
        /// Campos activos.
        /// </summary>
        private void CamposActivos()
        {
            txt_numeronit.Enabled = true;
            txt_digito.Enabled = true;
            txt_nombre.Enabled = true;
            txt_actividad.Enabled = true;
            txt_direccion.Enabled = true;
            combo_tipo.Enabled = true;
            combo_pais.Enabled = true;
            combo_dpto.Enabled = true;
            combo_ciudad.Enabled = true;
            txt_telefono.Enabled = true;
            txt_celular.Enabled = true;
            txt_email.Enabled = true;
        }

        /// <summary>
        /// Campos desactivos.
        /// </summary>
        private void CamposInactivos()
        {
            txt_numeronit.Enabled = false;
            txt_digito.Enabled = false;
            txt_nombre.Enabled = false;
            txt_actividad.Enabled = false;
            txt_direccion.Enabled = false;
            combo_tipo.Enabled = false;
            combo_pais.Enabled = false;
            combo_dpto.Enabled = false;
            combo_ciudad.Enabled = false;
            txt_telefono.Enabled = false;
            txt_celular.Enabled = false;
            txt_email.Enabled = false;
            btn_guardar.Enabled = false;
            menu_botones.Focus();
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

        private void BotonesInhabilitados()
        {
            this.btn_editar.Enabled = false;
            this.btn_eliminar.Enabled = false;
            this.btn_imprimir.Enabled = false;
            this.btn_buscar.Enabled = false;
            this.btn_cancelar.Enabled = true;
            this.btn_nuevo.Enabled = false;
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
            this.txt_numeronit.Focus();
            txt_numeronit.ReadOnly = false;
            this.CargarCombos();
            combo_tipo.SelectedIndex = 0;
            combo_pais.SelectedIndex = 0;
        }

        /// <summary>
        /// Handles the Click event of the Btn_editar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Btn_editar_Click(object sender, EventArgs e)
        {
            Form_VisualContable frm = new Form_VisualContable("nit", "editar", this);
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
            Form_VisualContable frm = new Form_VisualContable("nit", "eliminar", this);
            this.frmguar = frm;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.BotonesInhab();
            this.CamposLimpios();
            this.CamposInactivos();
        }

        /// <summary>
        /// Handles the Click event of the Btn_buscar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            Form_VisualContable frm = new Form_VisualContable("nit", "buscar", this);
            this.frmguar = frm;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.BotonesInhab();
        }
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (this.Validarguardar())
            {
                NitsDataSource nits = new NitsDataSource();
                nits = this.GuardarDatos();
                bool guardo = false;
                if (txt_numeronit.ReadOnly == false)
                {
                    try
                    {
                        guardo = this.negocioNit.GuardarNits(nits);
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
                        guardo = this.negocioNit.ActualizarNits(nits);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message, "ERROR");
                    }
                }

                if (guardo)
                {
                    this.CamposLimpios();
                    this.CamposInactivos();
                    MessageBox.Show("EL NIT FUE GUARDADO EXITOSAMENTE", "GUARDAR", MessageBoxButtons.OK);
                    if ("asiento".Equals(this.tipoform))
                    {
                        form_Asientos.CargarNit(nits.Nit);
                        this.estado = true;
                        this.Close();
                    }
                    else
                    {
                        this.BotonesHabit();
                        btn_cancelar.Enabled = false;
                    }
                }
            }
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ESTA SEGURO QUE DESEA CANCELAR?", "CANCELAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.CamposLimpios();
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
                if ("asiento".Equals(this.tipoform))
                {
                    form_Asientos.SalirNit();
                }
                else
                {
                    this.usrClose = true;
                    this.Close();
                }
                this.frmguar.Close();
                this.frmreporguar.Close();
            }
        }

        private void Btn_ordenadonumero_Click(object sender, EventArgs e)
        {
            Form_ReporteNits frm = new Form_ReporteNits(this, "numero");
            this.frmreporguar = frm;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.BotonesInhab();
        }

        private void Btn_ordenadonombre_Click(object sender, EventArgs e)
        {
            Form_ReporteNits frm = new Form_ReporteNits(this, "nombre");
            this.frmreporguar = frm;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.BotonesInhab();
        }

        #endregion

        #region VALIDACIONES

        /// <summary>
        /// Existe nit.
        /// </summary>
        /// <param name="nits">nit a verificar</param>
        /// <returns>booleano que rectifica si existe nit</returns>
        private bool ExisteNit()
        {
            bool existe = false;
            try
            {
                existe = this.negocioNit.ExisteNit(txt_numeronit.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message, "ERROR");
            }

            return existe;
        }

        private bool Validarguardar()
        {
            bool result = false;
            if (!txt_numeronit.Text.Equals(string.Empty) && !txt_digito.Text.Equals(string.Empty)
                && !txt_nombre.Text.Equals(string.Empty) && !txt_actividad.Text.Equals(string.Empty) && !txt_celular.Text.Equals(string.Empty))
            {
                if (combo_pais.SelectedItem != null && combo_dpto.SelectedItem != null
                && combo_ciudad.SelectedItem != null && combo_tipo.SelectedItem != null)
                {
                    if (txt_numeronit.Text.Length >= 9)
                    {
                        if (!txt_email.Text.Equals(string.Empty))
                        {
                            if (txt_email.Text.Contains(".") && txt_email.Text.Contains("@"))
                            {
                                if (!this.ExisteNit())
                                {
                                    result = true;
                                }
                                else
                                {
                                    if (txt_numeronit.ReadOnly == false)
                                    {
                                        result = false;
                                        MessageBox.Show("EL NIT YA EXISTE", "ERROR", MessageBoxButtons.OK);
                                    }
                                    else
                                    {
                                        result = true;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("LA CUENTA DE CORREO NO ES VALIDA", "ERROR", MessageBoxButtons.OK);
                                result = false;
                            }
                        }
                        else
                        {
                            if (!this.ExisteNit())
                            {
                                result = true;
                            }
                            else
                            {
                                if (txt_numeronit.ReadOnly == false)
                                {
                                    result = false;
                                    MessageBox.Show("EL NIT YA EXISTE", "ERROR", MessageBoxButtons.OK);
                                }
                                else
                                {
                                    result = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        result = false;
                        MessageBox.Show("EL NIT INGRESADO NO ES VALIDO", "ERROR", MessageBoxButtons.OK);
                    }
                }

                else
                {
                    result = false;
                    MessageBox.Show("LOS DATOS NO SON VALIDOS", "ERROR", MessageBoxButtons.OK);

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

        #region EVENTOS TEXTBOX COMBOS

        private void Combo_pais_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (combo_pais.SelectedValue != null)
            {
                int idpais = int.Parse(combo_pais.SelectedValue.ToString());
                bool cargodeptos = this.CargarDeptos(idpais);
                if (!cargodeptos)
                {
                    combo_dpto.DataSource = null;
                    combo_ciudad.DataSource = null;
                }
            }
        }

        private void Combo_pais_Leave(object sender, EventArgs e)
        {
            if (combo_pais.SelectedValue != null)
            {
                if (combo_dpto.SelectedValue != null)
                {
                    bool validept = this.negociosUbicacion.ValidaDepto(int.Parse(combo_dpto.SelectedValue.ToString()), combo_pais.SelectedValue.ToString());
                    if (!validept)
                    {
                        int idpais = int.Parse(combo_pais.SelectedValue.ToString());
                        bool cargodeptos = this.CargarDeptos(idpais);
                        if (!cargodeptos)
                        {
                            combo_dpto.DataSource = null;
                            combo_ciudad.DataSource = null;
                        }
                    }
                }
                else
                {
                    int idpais = int.Parse(combo_pais.SelectedValue.ToString());
                    bool cargodeptos = this.CargarDeptos(idpais);
                    if (!cargodeptos)
                    {
                        combo_dpto.DataSource = null;
                        combo_ciudad.DataSource = null;
                    }
                }
            }
        }

        private void Combo_dpto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (combo_dpto.SelectedValue != null)
            {
                if (combo_ciudad.SelectedValue != null)
                {
                    bool validciud = this.negociosUbicacion.ValidaCiudad(int.Parse(combo_ciudad.SelectedValue.ToString()), int.Parse(combo_dpto.SelectedValue.ToString()));
                    if (!validciud)
                    {
                        int idepto = int.Parse(combo_dpto.SelectedValue.ToString());
                        bool cargociudad = this.CargarCiudades(idepto);
                        if (!cargociudad)
                        {
                            combo_ciudad.DataSource = null;
                        }
                    }
                }
                else
                {
                    int idepto = int.Parse(combo_dpto.SelectedValue.ToString());
                    bool cargociudad = this.CargarCiudades(idepto);
                    if (!cargociudad)
                    {
                        combo_ciudad.DataSource = null;
                    }
                }
            }
        }

        private void Combo_dpto_Leave(object sender, EventArgs e)
        {
            if (combo_dpto.SelectedValue != null)
            {
                int idepto = int.Parse(combo_dpto.SelectedValue.ToString());
                bool cargociudad = this.CargarCiudades(idepto);
                if (!cargociudad)
                {
                    combo_ciudad.DataSource = null;
                }
            }
        }

        #endregion

        #region SALIR FORMULARIO

        /// <summary>
        /// Handles the FormClosing event of the Frmnits control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void Frmnits_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.estado == false)
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
                        if ("asiento".Equals(this.tipoform))
                        {
                            form_Asientos.SalirNit();
                        }
                        else
                        {
                            this.frmguar.Close();
                            this.frmreporguar.Close();
                        }
                    }
                }
            }
        }

        #endregion

        #region ENTER TAB

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

        private void EnterTab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void EnterTab_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        #endregion

        #region DATOS

        /// <summary>
        /// Guardar datos en nits
        /// </summary>
        /// <returns>nit guardado</returns>
        private NitsDataSource GuardarDatos()
        {
            NitsDataSource nits = new NitsDataSource();
            nits.Nit = txt_numeronit.Text;
            nits.Digito = txt_digito.Text;
            nits.Tiponit = combo_tipo.SelectedValue.ToString();
            nits.Nombrenit = txt_nombre.Text;
            nits.ActividadEconomica = txt_actividad.Text;
            nits.Idciudad = int.Parse(combo_ciudad.SelectedValue.ToString());
            nits.Direccion = txt_direccion.Text;
            nits.Telefono = txt_telefono.Text;
            nits.Celular = txt_celular.Text;
            nits.Email = txt_email.Text;
            return nits;
        }

        private void AgregarOtro(string nit)
        {
            EventArgs e = new EventArgs();
            object sender = new object();
            this.Btn_nuevo_Click(sender, e);
            txt_numeronit.Text = nit;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = false;
        }

        #endregion
    }
}
