﻿////*********************************************************
//
//    <copyright file="Form_Cuenta.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 01 marzo 2014
//    </copyright>
//
////*********************************************************
namespace App.Forms.Contable
{
    using System;
    using System.Windows.Forms;
    using Entities.Types;
    using Negocios.Contable;
    using Negocios.General;
    using Reportes;

    /// <summary>
    /// Clase de formulario cuenta
    /// </summary>
    public partial class Form_Cuenta : Form
    {
        #region INSTANCIAS DE OBJETOS

        /// <summary>
        /// instacia la cuenta de la capa negocios
        /// </summary>
        private Cuentan negocioCuenta;

        /// <summary>
        /// El negocio empresa de la capa negocios
        /// </summary>
        private Empresan negocioEmpresa;

        /// <summary>
        /// El negocio nits de la capa negocios
        /// </summary>
        private Nitsn negocioNits;

        /// <summary>
        /// variable para manejar cierre de formulario
        /// </summary>
        private bool usrClose;

        /// <summary>
        /// Funciones generales
        /// </summary>
        private Funciones funtions;

        private int validanumcuenta;

        private int validaotrascuentas;

        private bool estado;

        private Form_VisualContable frmguar;

        private Form_ReportCuenta frmreporguar;

        private string menub;

        private Form_Asientos form_Asientos;

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="Form_Cuenta"/> class.
        /// </summary>
        public Form_Cuenta()
        {
            this.usrClose = false;
            this.InitializeComponent();
            this.negocioCuenta = new Cuentan();
            this.negocioNits = new Nitsn();
            this.funtions = new Funciones();
            this.negocioEmpresa = new Empresan();
            this.frmguar = new Form_VisualContable();
            this.frmreporguar = new Form_ReportCuenta();
            this.NombreEmpresa();
        }

        public Form_Cuenta(string menu, string cuenta, Form_Asientos form_Asientos)
        {
            // TODO: Complete member initialization
            this.menub = menu;
            this.usrClose = false;
            this.estado = false;
            this.InitializeComponent();
            this.form_Asientos = form_Asientos;
            this.negocioCuenta = new Cuentan();
            this.negocioNits = new Nitsn();
            this.funtions = new Funciones();
            this.negocioEmpresa = new Empresan();
            this.frmguar = new Form_VisualContable();
            this.frmreporguar = new Form_ReportCuenta();
            this.NombreEmpresa();
            this.AgregarOtro(cuenta);
            this.validaotrascuentas = 1;

        }

        #region PUBLIC METODOS RETORNA DATOS

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

        /// <summary>
        /// Cargar datos de la cuenta en los campos del formulario
        /// </summary>
        /// <param name="cuenta">Numero de Cuenta.</param>
        public void CargarDatos(string cuenta)
        {
            CuentaDataSource ds = new CuentaDataSource();
            try
            {
                ds = this.negocioCuenta.DevolverDatos(cuenta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message, "ERROR");
            }

            this.CamposActivos();
            txtnumcu.Text = ds.Cuenta;
            txtnumcu.ReadOnly = true;
            txtnombre.Text = ds.Nombre;
            check_pidenit.Checked = ds.Pidenit;
            check_centro.Checked = ds.Centro;
            check_ajustes.Checked = ds.Ajusteinteg;
            check_cuentaret.Checked = ds.Cuentret;
            txtdoc.Text = ds.Ajudoc;
            txtnitajus.Text = ds.Nitajustes;
            txtcuenaju.Text = ds.Cueaju;
            txtcuncor.Text = ds.Cuencorre;
            txtporcrete.Text = Convert.ToString(ds.Porete);
            txtconcerete.Text = ds.Concepret;
            txtcierre.Text = ds.Cuentacierreimp;
            radio_general.Checked = ds.Tipocta == "MAYOR" ? true : false;
            radio_detalle.Checked = ds.Tipocta == "AUXILIAR" ? true : false;
            txt_poreteica.Text = Convert.ToString(ds.PoreteIca);
            txt_conreteica.Text = ds.ConcepReteIca;
            btn_guardar.Enabled = true;
            check_reteica.Checked = ds.ReteIca;
            txt_mediosmag.Text = Convert.ToString(ds.FormatoMedios);
            txtnombre.Focus();
            this.BotonesInhab();
            this.btn_cancelar.Enabled = true;
        }

        /// <summary>
        /// Devuelve numero de cuenta a los textbox con cuenta
        /// </summary>
        /// <param name="codig">numero de cuenta</param>
        public void DevolverCuenta(string codig)
        {
            if (txtnumcu.ContainsFocus)
            {
                txtnumcu.Text = codig;
            }
            else if (txtcuenaju.ContainsFocus)
            {
                txtcuenaju.Text = codig;
            }
            else if (txtcuncor.ContainsFocus)
            {
                txtcuncor.Text = codig;
            }
            else if (txtcierre.ContainsFocus)
            {
                txtcierre.Text = codig;
            }
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

        #region BOTONES CLICK

        /// <summary>
        /// click en el boton nuevo
        /// </summary>
        /// <param name="sender">El origen del evento </param>
        /// <param name="e">The <see cref="EventArgs"/> instancia que contiene los datos del evento</param>
        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            this.CamposVacios();
            this.CamposActivos();
            this.AutoCompletar();
            this.BotonesInhabilitados();
            this.btn_guardar.Enabled = true;
            this.txtnumcu.Focus();
            txtnumcu.ReadOnly = false;
        }

        /// <summary>
        /// click en el boton editar
        /// </summary>
        /// <param name="sender">El origen del evento.</param>
        /// <param name="e">The <see cref="EventArgs"/> instancia que contiene los datos del evento</param>
        private void Btn_editar_Click(object sender, EventArgs e)
        {
            Form_VisualContable frm = new Form_VisualContable("cuenta", "editar", this);
            this.frmguar = frm;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.BotonesInhab();
        }

        /// <summary>
        /// click en el boton eliminar
        /// </summary>
        /// <param name="sender">El origen del evento.</param>
        /// <param name="e">The <see cref="EventArgs"/> instancia que contiene los datos del evento</param>
        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            Form_VisualContable frm = new Form_VisualContable("cuenta", "eliminar", this);
            this.frmguar = frm;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.BotonesInhab();
        }

        /// <summary>
        /// click en el boton buscar
        /// </summary>
        /// <param name="sender">El origen del evento</param>
        /// <param name="e">The <see cref="EventArgs"/> instancia que contiene los datos del evento</param>
        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            Form_VisualContable frm = new Form_VisualContable("cuenta", "buscar", this);
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
            Form_ReportCuenta frm = new Form_ReportCuenta(this);
            this.frmreporguar = frm;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.BotonesInhab();
        }

        /// <summary>
        /// click en el boton guardar
        /// </summary>
        /// <param name="sender">El origen del evento</param>
        /// <param name="e">The <see cref="EventArgs"/>  instancia que contiene los datos del evento</param>
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (this.Validarguardar())
            {
                CuentaDataSource cuenta = new CuentaDataSource();
                cuenta = this.GuardarDatos();
                bool guardo = false;
                if (txtnumcu.ReadOnly == false)
                {
                    try
                    {
                        guardo = this.negocioCuenta.GuardarCuenta(cuenta);
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
                        guardo = this.negocioCuenta.ActualizarCuenta(cuenta);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message, "ERROR");
                    }
                }

                if (guardo)
                {
                    this.CamposVacios();
                    this.CamposInactivos();
                    MessageBox.Show("LA CUENTA FUE GUARDADA EXITOSAMENTE", "GUARDAR", MessageBoxButtons.OK);
                    if ("asiento".Equals(this.menub))
                    {
                        form_Asientos.CargarCuenta(cuenta.Cuenta);
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

        /// <summary>
        /// click en el boton cancelar
        /// </summary>
        /// <param name="sender">El origen del evento</param>
        /// <param name="e">The <see cref="EventArgs"/>  instancia que contiene los datos del evento</param>
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
        /// click en el boton salir
        /// </summary>
        /// <param name="sender">El origen del evento</param>
        /// <param name="e">The <see cref="EventArgs"/>instancia que contiene los datos del evento.</param>
        private void Btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ESTA SEGURO QUE DESEA SALIR?", "SALIR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if ("asiento".Equals(this.menub))
                {
                    form_Asientos.SalirCuenta();
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

        #region RECIBE ENTER GENERA TAB

        /// <summary>
        /// Evento que se genera al presionar una tecla y genera entertab
        /// </summary>
        /// <param name="sender">el origen del evento</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> contiene los datos de la tecla presionada</param>
        private void EnterTab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = false;
                SendKeys.Send("{TAB}");
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

        /// <summary>
        /// evento que  valida tecla presionada en porcentaje
        /// </summary>
        /// <param name="sender">el origen del evento</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> contiene datos de la tecla presionada</param>
        private void Txtporcrete_KeyPress(object sender, KeyPressEventArgs e)
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
        /// evento que valida d o c
        /// </summary>
        /// <param name="sender">el orgien del evento</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/>instancia contiene datos de la tecla presionada</param>
        private void Txtdoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

            if (e.Handled = char.IsLetter(e.KeyChar))
            {
                e.Handled = e.KeyChar == (char)67 ? false : e.KeyChar == (char)68 ? false : e.KeyChar == (char)99 ? false : e.KeyChar == (char)100 ? false : true;
            }
            else
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// evento cuando una tecla es presionada en el textbox txtnumcu
        /// </summary>
        /// <param name="sender">el orgien del evento</param>
        /// <param name="e">The <see cref="KeyEventArgs"/> instancia contiene datos de la tecla presionada</param>
        private void Txtnumcu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter && e.KeyCode != Keys.Tab)
            {
                this.validanumcuenta = 0;
            }
            if ((!"CUENTA EXISTENTE".Equals(txt_nombrecuenta.Text) && !"CUENTA NO ACEPTADA".Equals(txt_nombrecuenta.Text)
     && !"CUENTA MAYOR NO EXISTE".Equals(txt_nombrecuenta.Text)) || this.validanumcuenta == 0)
            {
                int tamanio = txtnumcu.Text.Length;

                if (!txtnumcu.Text.Equals(string.Empty) && (tamanio != 3 && tamanio != 5 && tamanio != 7 && tamanio != 11))
                {
                    try
                    {
                        txt_nombrecuenta.Text = this.negocioCuenta.DevolverNombre(txtnumcu.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message, "ERROR");
                    }
                }
                else
                {
                    txt_nombrecuenta.Text = string.Empty;
                }
                if (txtnumcu.Text.Equals(string.Empty))
                {
                    txt_nombrecuenta.Text = string.Empty;
                }
            }
        }

        private void Txtcuenta_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (e.KeyCode != Keys.Enter && e.KeyCode != Keys.Tab)
            {
                this.validaotrascuentas = 0;
            }
            if (((!"CUENTA MAYOR".Equals(this.GetNextControl((Control)sender, true).Text)
                && !"CUENTA NO EXISTENTE".Equals(this.GetNextControl((Control)sender, true).Text))) || this.validaotrascuentas == 0)
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

        private void Txtcuenta_KeyDown(object sender, KeyEventArgs e)
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
                string mensaje = this.funtions.ValidarOtraCuenta(tb.Text);

                if (!string.Empty.Equals(mensaje))
                {
                    this.GetNextControl((Control)sender, true).Text = mensaje;
                    this.validanumcuenta++;
                    tb.Focus();
                }
                else
                {
                    btn_buscar.Enabled = false;
                }
            }
            else
            {
                tb.Focus();
            }
        }

        private void Txtnumcu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = false;
                SendKeys.Send("{TAB}");
            }
        }

        #endregion

        #region VALIDACIONES

        /// <summary>
        /// validaciones de los campos antes de guardar
        /// </summary>
        /// <returns>booleano si guarda o no guarda</returns>
        private bool Validarguardar()
        {
            bool result = false;
            if (!txtnumcu.Text.Equals(string.Empty) && !txtnombre.Text.Equals(string.Empty) &&
                     (radio_general.Checked == true || radio_detalle.Checked == true)
                && ((check_ajustes.Checked == true && !txtnitajus.Text.Equals(string.Empty) &&
                !txtcuenaju.Text.Equals(string.Empty) && !txtcuncor.Text.Equals(string.Empty)&& 
                !string.Empty.Equals(txtdoc.Text) && ("D".Equals(txtdoc.Text)||"C".Equals(txtdoc.Text))) ||
                (check_ajustes.Checked == false && txtnitajus.Text.Equals(string.Empty) &&
                txtcuenaju.Text.Equals(string.Empty) && txtcuncor.Text.Equals(string.Empty))) &&
                ((check_cuentaret.Checked == true && !txtporcrete.Text.Equals(string.Empty) &&
                !txtconcerete.Text.Equals(string.Empty)) ||
                (check_cuentaret.Checked == false && txtporcrete.Text.Equals("00,00") &&
                    txtconcerete.Text.Equals(string.Empty))) && ((check_reteica.Checked == true &&
                    !string.Empty.Equals(txt_poreteica.Text) && !string.Empty.Equals(txt_conreteica.Text))
                    || (check_reteica.Checked == false && "00,00".Equals(txt_poreteica.Text)
                    && string.Empty.Equals(txt_conreteica.Text))))
            {
                bool cuentaexiste = false;
                try
                {
                    cuentaexiste = this.negocioCuenta.ExisteCuenta(txtnumcu.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message, "ERROR");
                }

                if (!cuentaexiste)
                {
                    string mensaje = this.ValidarCuenta();
                    if (!mensaje.Equals(string.Empty))
                    {
                        MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK);
                        result = false;
                    }
                    else
                    {
                        result = true;
                    }
                }
                else
                {
                    if (txtnumcu.ReadOnly == false)
                    {
                        MessageBox.Show("LA CUENTA INGRESADO YA EXISTE", "ERROR", MessageBoxButtons.OK);
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
                MessageBox.Show("DEBE INGRESAR TODOS LOS DATOS", "ERROR", MessageBoxButtons.OK);
            }

            if (result)
            {
                string mensaje = string.Empty;
                string[] mensajes = new string[4];
                if (!string.Empty.Equals(txtcuenaju.Text))
                {
                    mensaje = this.funtions.ValidarOtraCuenta(txtcuenaju.Text);
                    mensajes[0] = mensaje;
                }

                if (!string.Empty.Equals(txtcuncor.Text))
                {
                    mensaje = this.funtions.ValidarOtraCuenta(txtcuncor.Text);
                    mensajes[1] = mensaje;
                }

                if (!string.Empty.Equals(txtcierre.Text))
                {
                    mensaje = this.funtions.ValidarOtraCuenta(txtcierre.Text);
                    mensajes[2] = mensaje;
                }

                if (!string.Empty.Equals(txtnitajus.Text))
                {
                    bool existenit = false;
                    try
                    {
                        existenit = this.negocioNits.ExisteNit(txtnitajus.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                    }

                    if (existenit)
                    {
                        mensajes[3] = string.Empty;
                    }
                    else
                    {
                        mensajes[3] = "NIT NO EXISTE";
                    }
                }

                for (int i = 0; i <= 3; i++)
                {
                    if (!string.Empty.Equals(mensajes[i]) && mensajes[i] != null)
                    {
                        MessageBox.Show(mensajes[i], "ERROR", MessageBoxButtons.OK);
                        result = false;
                        break;
                    }
                    else
                    {
                        result = true;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// evento que valida solo numeros en cuenta
        /// </summary>
        /// <param name="sender">el origen del evento.</param>
        /// <param name="e">The <see cref="EventArgs"/> instancia contiene datos del evento</param>
        private void ValidaCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = this.funtions.ValidacionNumerico(e).Handled;
            }
        }

        /// <summary>
        /// Valida la cuenta a grabar
        /// </summary>
        /// <returns>mensaje dependiendo del error o no error</returns>
        private string ValidarCuenta()
        {
            string mensaje = string.Empty;
            bool existe = false;
            try
            {
                existe = this.negocioCuenta.ExisteCuenta(txtnumcu.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }

            if (existe == true)
            {
                mensaje = "CUENTA EXISTENTE";
            }
            else
            {
                int tamanio = txtnumcu.Text.Length;
                if (tamanio == 3 || tamanio == 5 || tamanio == 7 || tamanio == 9 || tamanio == 11)
                {
                    mensaje = "CUENTA NO ACEPTADA";
                }
                else if (tamanio == 1)
                {
                    mensaje = string.Empty;
                }
                else if (tamanio == 2)
                {
                    try
                    {
                        existe = this.negocioCuenta.ExisteCuenta(txtnumcu.Text.Substring(0, 1));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                    }

                    if (existe == false)
                    {
                        mensaje = "CUENTA MAYOR NO EXISTE";
                    }
                }
                else if (tamanio == 4 || tamanio == 6 || tamanio == 8 || tamanio == 10 || tamanio == 12)
                {
                    try
                    {
                        existe = this.negocioCuenta.ExisteCuenta(txtnumcu.Text.Substring(0, tamanio - 2));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                    }

                    if (existe == false)
                    {
                        mensaje = "CUENTA MAYOR NO EXISTE";
                    }
                }
            }

            return mensaje;
        }

        /// <summary>
        /// evento cuando entra al textbox porcentaje de retencion
        /// </summary>
        /// <param name="sender">el origen del evento</param>
        /// <param name="e">The <see cref="EventArgs"/> instancia contiene datos del evento</param>
        private void Txtporcrete_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = Convert.ToString(tb.Tag);
        }

        /// <summary>
        /// evento cuando sale al textbox porcentaje de retencion
        /// </summary>
        /// <param name="sender">el origen del evento</param>
        /// <param name="e">The <see cref="EventArgs"/> instancia contiene datos del evento</param>
        private void Txtporcrete_Leave(object sender, EventArgs e)
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
            if ("00,00".Equals(tb.Text) || string.Empty.Equals(tb.Text))
            {
                tb.Focus();
                MessageBox.Show("INGRESE UN PORCENTAJE VALIDO", "ERROR", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Evento cuando la cuenta tiene el foco
        /// </summary>
        /// <param name="sender">el origen del evento.</param>
        /// <param name="e">The <see cref="EventArgs"/> instancia contiene datos del evento</param>
        private void Txt_cuenta_Enter(object sender, EventArgs e)
        {
            grupo_tipo.Enabled = true;
            this.btn_buscar.Enabled = true;
        }

        /// <summary>
        /// Evento cuando la cuenta pierde el foco
        /// </summary>
        /// <param name="sender">el origen del evento.</param>
        /// <param name="e">The <see cref="EventArgs"/> instancia contiene datos del evento</param>
        private void TxtNumcu_Leave(object sender, EventArgs e)
        {
            if (!string.Empty.Equals(txtnumcu.Text))
            {
                string mensaje = this.ValidarCuenta();
                if (!mensaje.Equals(string.Empty))
                {
                    txt_nombrecuenta.Text = mensaje;
                    this.validanumcuenta++;
                    txtnumcu.Focus();
                }
                else
                {
                    txt_nombrecuenta.Text = string.Empty;
                    if (txtnumcu.Text.Length <= 4)
                    {
                        radio_general.Checked = true;
                        grupo_tipo.Enabled = false;
                    }
                    this.btn_buscar.Enabled = false;
                }
            }
            else
            {
                txtnumcu.Focus();
            }
        }

        /// <summary>
        /// evento que valida si existe el nit
        /// </summary>
        /// <param name="sender">el origen del evento</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> contiene los datos de la tecla presionada</param>
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

        private void Txtnitajus_Leave(object sender, EventArgs e)
        {
            if (!string.Empty.Equals(txtnitajus.Text))
            {
                bool existenit = false;
                try
                {
                    existenit = this.negocioNits.ExisteNit(txtnitajus.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                }

                if (existenit)
                {
                    try
                    {
                        txt_nombrenit.Text = this.negocioNits.DevolverNombre(txtnitajus.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    txt_nombrenit.Text = "NIT NO EXISTENTE";
                    txtnitajus.Focus();
                }
            }
            else
            {
                txtnitajus.Focus();
            }
        }

        private void ValidaVacio_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (string.Empty.Equals(tb.Text))
            {
                tb.Focus();
            }
        }

        private void TipoCuenta_Leave(object sender, EventArgs e)
        {
            if (radio_detalle.Checked == false && radio_general.Checked == false)
            {
                radio_general.Focus();
            }
        }

        #endregion

        #region EVENTOS FORMULARIO

        /// <summary>
        /// evento se genera cuando se da click en salir
        /// </summary>
        /// <param name="sender">el origen del evento</param>
        /// <param name="e">The <see cref="EventArgs"/> instacia que contiene los datos del evento.</param>
        private void Frmcuenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.usrClose)
            {
                if (estado != true)
                {
                    DialogResult result = MessageBox.Show("ESTA SEGURO QUE DESEA SALIR?", "SALIR", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        if ("asiento".Equals(this.menub))
                        {
                            form_Asientos.SalirCuenta();
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

        #region DATOS

        /// <summary>
        /// Autocompleta campos de las cuentas
        /// </summary>
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

            txtcuenaju.AutoCompleteCustomSource = cuentas;
            txtcuncor.AutoCompleteCustomSource = cuentas;
            txtcierre.AutoCompleteCustomSource = cuentas;
            txtnumcu.AutoCompleteCustomSource = cuentas;
        }

        /// <summary>
        /// Devuelve el nombre de la empresa que se esta trabajando
        /// </summary>
        private void NombreEmpresa()
        {
            try
            {
                lbl_nombre.Text = this.negocioEmpresa.DevolverNombre(Program.compa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
            }
        }

        /// <summary>
        /// guarda los datos en el datasource desde los campos en el formulario
        /// </summary>
        /// <returns>el data source de la cuenta </returns>
        private CuentaDataSource GuardarDatos()
        {
            CuentaDataSource cuenta = new CuentaDataSource();
            cuenta.Cuenta = txtnumcu.Text;
            cuenta.Tipocta = radio_general.Checked == true ? "M" : "A";
            cuenta.Nombre = txtnombre.Text;
            cuenta.Pidenit = check_pidenit.Checked;
            cuenta.Centro = check_centro.Checked;
            cuenta.Ajusteinteg = check_ajustes.Checked;
            if (check_ajustes.Checked == false)
            {
                cuenta.Nitajustes = null;
                cuenta.Cueaju = null;
                cuenta.Cuencorre = null;
                cuenta.Ajudoc = null;
            }
            else
            {
                cuenta.Nitajustes = txtnitajus.Text;
                cuenta.Cueaju = txtcuenaju.Text;
                cuenta.Cuencorre = txtcuncor.Text;
                cuenta.Ajudoc = txtdoc.Text;
            }

            cuenta.Cuentret = check_cuentaret.Checked;
            if (check_cuentaret.Checked == false)
            {
                cuenta.Porete = 0;
                cuenta.Concepret = null;
            }
            else
            {
                cuenta.Porete = decimal.Parse(txtporcrete.Text);
                cuenta.Concepret = txtconcerete.Text;
            }

            cuenta.ReteIca = check_reteica.Checked;
            if (check_reteica.Checked == false)
            {
                cuenta.PoreteIca = 0;
                cuenta.ConcepReteIca = null;
            }
            else
            {
                cuenta.PoreteIca = decimal.Parse(txt_poreteica.Text);
                cuenta.ConcepReteIca = txt_conreteica.Text;
            }
            cuenta.FormatoMedios = string.Empty.Equals(txt_mediosmag.Text) ? null : txt_mediosmag.Text;
            cuenta.Cuentacierreimp = string.Empty.Equals(txtcierre.Text) ? null : txtcierre.Text;
            return cuenta;
        }

        private void AgregarOtro(string cuenta)
        {
            EventArgs e = new EventArgs();
            object sender = new object();
            this.Btn_nuevo_Click(sender, e);
            txtnumcu.Text = cuenta;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = false;
        }

        #endregion

        #region ACTIVACION,DESACTIVACION Y LIMPIEZA DE CAMPOS

        /// <summary>
        /// Vacia los campos en el formulario
        /// </summary>
        private void CamposVacios()
        {
            txtnumcu.Clear();
            txtnombre.Clear();
            txt_nombrecuenta.Clear();
            check_pidenit.Checked = false;
            check_centro.Checked = false;
            check_ajustes.Checked = false;
            txtnitajus.Clear();
            txtcuenaju.Clear();
            txt_nombrecuentaajuste.Clear();
            txt_nombrecuentacorre.Clear();
            txt_nombrenit.Clear();
            txtcuncor.Clear();
            check_cuentaret.Checked = false;
            txtporcrete.Text = "00,00";
            txtconcerete.Clear();
            txtcierre.Clear();
            txt_nomcucierre.Clear();
            txt_mediosmag.Clear();
            check_reteica.Checked = false;
            radio_detalle.Checked = false;
            radio_general.Checked = false;
            txt_poreteica.Text = "00,00";
            txt_conreteica.Clear();
            this.validaotrascuentas = 0;
            this.validanumcuenta = 0;
        }

        /// <summary>
        /// Activa los campos del formulario
        /// </summary>
        private void CamposActivos()
        {
            txtnombre.Enabled = true;
            radio_general.Enabled = true;
            radio_detalle.Enabled = true;
            check_pidenit.Enabled = true;
            check_centro.Enabled = true;
            check_ajustes.Enabled = true;
            check_cuentaret.Enabled = true;
            txtnumcu.Enabled = true;
            txt_mediosmag.Enabled = true;
            check_reteica.Enabled = true;
            txtcierre.Enabled = true;
        }

        /// <summary>
        /// Inactiva los campos en el formulario
        /// </summary>
        private void CamposInactivos()
        {
            txtnumcu.Enabled = false;
            txtnombre.Enabled = false;
            check_pidenit.Enabled = false;
            check_centro.Enabled = false;
            check_ajustes.Enabled = false;
            txtnitajus.Enabled = false;
            txtcuenaju.Enabled = false;
            txt_nombrecuentaajuste.Enabled = false;
            txt_nombrecuentacorre.Enabled = false;
            txtcuncor.Enabled = false;
            check_cuentaret.Enabled = false;
            txtporcrete.Enabled = false;
            txtconcerete.Enabled = false;
            txtcierre.Enabled = false;
            txt_nomcucierre.Enabled = false;
            txt_mediosmag.Enabled = false;
            radio_detalle.Enabled = false;
            radio_general.Enabled = false;
            btn_guardar.Enabled = false;
            check_reteica.Enabled = false;
            txt_poreteica.Enabled = false;
            txt_conreteica.Enabled = false;
            menu_botones.Focus();
        }

        /// <summary>
        /// evento que habilita campos al checkear retencion
        /// </summary>
        /// <param name="sender">el origen del evento</param>
        /// <param name="e">The <see cref="EventArgs"/> contiene los datos del evento</param>
        private void Check_cuentaret_CheckedChanged(object sender, EventArgs e)
        {
            if (check_cuentaret.Checked)
            {
                this.RetencionHabit();
                this.ReteicaInhabit();
                check_reteica.Enabled = false;

            }
            else
            {
                this.RetencionInhabit();
                check_reteica.Enabled = true;
            }
        }

        /// <summary>
        /// evento que habilita campos cuando es checkeado ajustes integrales
        /// </summary>
        /// <param name="sender">el origen del evento</param>
        /// <param name="e">The <see cref="EventArgs"/> instancia contiene datos del evento</param>
        private void Check_ajustes_CheckedChanged(object sender, EventArgs e)
        {
            if (check_ajustes.Checked)
            {
                txtcuenaju.Enabled = true;
                txtnitajus.Enabled = true;
                txtcuncor.Enabled = true;
                txtdoc.Enabled = true;
                txtdoc.Text = "D";
            }
            else
            {
                txtcuenaju.Enabled = false;
                txtnitajus.Enabled = false;
                txtcuncor.Enabled = false;
                txtdoc.Enabled = false;
                txtcuenaju.Clear();
                txtnitajus.Clear();
                txtcuncor.Clear();
                txtdoc.Clear();
                txt_nombrecuentaajuste.Clear();
                txt_nombrecuentacorre.Clear();
                txt_nombrenit.Clear();
            }
        }

        private void Check_reteica_CheckedChanged(object sender, EventArgs e)
        {
            if (check_reteica.Checked)
            {
                this.ReteicaHabit();
                this.RetencionInhabit();
                check_cuentaret.Enabled = false;
            }
            else
            {
                this.ReteicaInhabit();
                check_cuentaret.Enabled = true;
            }
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
        }

        private void RetencionHabit()
        {
            txtporcrete.Enabled = true;
            txtconcerete.Enabled = true;
            txtporcrete.Text = "00,00";
        }
        private void RetencionInhabit()
        {
            txtporcrete.Enabled = false;
            txtconcerete.Enabled = false;
            txtporcrete.Text = "00,00";
            txtconcerete.Clear();
            check_cuentaret.Checked = false;
        }
        private void ReteicaHabit()
        {
            txt_poreteica.Enabled = true;
            txt_poreteica.Text = "00,00";
            txt_conreteica.Enabled = true;
        }

        private void ReteicaInhabit()
        {
            txt_poreteica.Enabled = false;
            txt_poreteica.Text = "00,00";
            txt_conreteica.Clear();
            txt_conreteica.Enabled = false;
            check_reteica.Checked = false;
        }

        #endregion
    }
}
