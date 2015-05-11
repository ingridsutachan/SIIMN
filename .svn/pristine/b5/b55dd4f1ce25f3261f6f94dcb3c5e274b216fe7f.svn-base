////*********************************************************
//
//    <copyright file="frmcuenta.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 01 marzo 2014
//    </copyright>
//
////*********************************************************
namespace App.Forms.Contable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using Entities.Types;
    using Negocios.Contable;

    /// <summary>
    /// Clase de formulario cuenta
    /// </summary>
    public partial class Frmcuenta : Form
    {
        #region INSTANCIAS DE OBJETOS

        /// <summary>
        /// instacia la cuenta de la capa negocios
        /// </summary>
        private Cuentan negocioCuenta;

        /// <summary>
        /// variable para manejar cierre de formulario
        /// </summary>
        private bool usrClose;

        /// <summary>
        /// Almacena boton da el usuario click
        /// </summary>
        private string botonclick;

        #endregion

        private Funciones funtions;

        private string cuentaedit;

        /// <summary>
        /// Initializes a new instance of the <see cref="Frmcuenta"/> class.
        /// </summary>
        public Frmcuenta()
        {
            this.usrClose = false;
            this.InitializeComponent();
            this.negocioCuenta = new Cuentan();
            this.funtions = new Funciones();
            this.CargarDatosCuenta();
        }

        #region EVENTOS COMBOBOX,DATAGRID

        /// <summary>
        /// Handles the CellClick event of the Dgvdatoscuenta control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void Dgvdatoscuenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdatoscuenta.SelectedCells.Count > 0)
            {
                btn_editar.Enabled = true;
                btn_eliminar.Enabled = true;
            }
        }
        #endregion

        #region BOTONES CLICK


        /// <summary>
        /// Handles the Click event of the Btn_buscar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            bool existe = this.negocioCuenta.ExisteBuscar(txt_buscar.Text);
            if (existe)
            {
                List<AsientosDataSource> datasSource = new List<AsientosDataSource>();
                datasSource = this.negocioCuenta.BuscarCuenta(txt_buscar.Text);
                if (datasSource.Count() > 0)
                {
                    this.NombresColumna();
                    dgvdatoscuenta.DataSource = datasSource;
                }
                else
                {
                    MessageBox.Show("No se encuentra ningun resultado", "BUSQUEDA", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("NO SE ENCUENTRA RESULTADO", "CUENTA", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Handles the Click event of the Btn_nuevo control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            this.CamposVacios();
            this.botonclick = "agregar";
            this.CamposActivos();
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            string cuenta = dgvdatoscuenta.CurrentRow.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar?", "ELIMINAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (this.negocioCuenta.EliminarCuenta(cuenta))
                    {
                        MessageBox.Show("La cuenta fue Eliminada", "ELIMINAR", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se presento un error. " + ex.Message);
                }

                this.CargarDatosCuenta();
            }
        }

        /// <summary>
        /// Handles the Click event of the Btn_editar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Btn_editar_Click(object sender, EventArgs e)
        {
            this.botonclick = "editar";
            string cuenta = dgvdatoscuenta.CurrentRow.Cells[0].Value.ToString();
            AsientosDataSource ds = new AsientosDataSource();
            try
            {
                ds = this.negocioCuenta.DevolverDatos(cuenta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un error. " + ex.Message);
            }

            this.CamposActivos();
            this.cuentaedit = ds.Cuenta;
            txtnumcu.Text = ds.Cuenta;
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
            btn_guardar.Enabled = true;
        }

        /// <summary>
        /// Handles the KeyPress event of the Txt_buscar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void Txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                EventArgs eve = new EventArgs();
                this.Btn_buscar_Click(sender, eve);
                if (txt_buscar.Text.Equals(string.Empty))
                {
                    this.CargarDatosCuenta();
                }
            }
        }
        #endregion

        #region RECIBE ENTER GENERA TAB
        private void EnterTab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = false;
                SendKeys.Send("{TAB}");
            }
        }

        private void EnterValidacion_KeyPress(object sender, KeyPressEventArgs e)
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

        /// <summary>
        /// Handles the KeyPress event of the Txtdoc control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
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
        #endregion

        #region VALIDAR CUENTAS

        private void ValidaCuentaAjuste_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string result = this.funtions.ValidaCuentaoNombre(txtcuenaju.Text);
                txt_nombrecuentaajuste.Text = result;
                if (result.Equals("Cuenta General") || result.Equals("Cuenta no Existente"))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                    SendKeys.Send("{TAB}");
                }
            }
        }

        private void ValidaCuentaCorrec_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string result = this.funtions.ValidaCuentaoNombre(txtcuncor.Text);
                txt_nombrecuentacorre.Text = result;
                if (result.Equals("Cuenta General") || result.Equals("Cuenta no Existente"))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                    SendKeys.Send("{TAB}");
                }
            }
        }

        private void ValidaCuentaCierre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string result = this.funtions.ValidaCuentaoNombre(txtcierre.Text);
                txt_nomcucierre.Text = result;
                if (result.Equals("Cuenta General") || result.Equals("Cuenta no Existente"))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                    SendKeys.Send("{TAB}");
                }
            }
        }

        #endregion

        #region CERRAR FORMULARIO

        /// <summary>
        /// Handles the Click event of the Salircuent control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Salircuent_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea salir?", "SALIR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.usrClose = true;
                this.Close();
            }
        }

        /// <summary>
        /// Handles the FormClosing event of the Frmcuenta control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void Frmcuenta_FormClosing(object sender, FormClosingEventArgs e)
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
        #endregion

        #region VISUALIZACION DE TABLA, COMBOBOX Y AUTOCOMPLETAR

        private void NombresColumna()
        {
            dgvdatoscuenta.Columns[0].HeaderText = "Cuenta";
            dgvdatoscuenta.Columns[1].Visible = false;
            dgvdatoscuenta.Columns[2].HeaderText = "Nombre";
            dgvdatoscuenta.Columns[3].HeaderText = "Tipo de Cuenta";
            dgvdatoscuenta.Columns[4].HeaderText = "Pide NIT";
            dgvdatoscuenta.Columns[5].HeaderText = "Centro de Costos";
            dgvdatoscuenta.Columns[6].HeaderText = "Ajustes Integrales";
            dgvdatoscuenta.Columns[7].HeaderText = "NIT Ajustes";
            dgvdatoscuenta.Columns[8].HeaderText = "Cuenta Ajustes";
            dgvdatoscuenta.Columns[9].HeaderText = "Cuenta Correción";
            dgvdatoscuenta.Columns[10].HeaderText = "D/C";
            dgvdatoscuenta.Columns[11].HeaderText = "Cuenta Retención";
            dgvdatoscuenta.Columns[12].HeaderText = "% Retención";
            dgvdatoscuenta.Columns[13].HeaderText = "Concepto de Retención";
            dgvdatoscuenta.Columns[14].HeaderText = "Cuenta Cierre Impuestos";
            dgvdatoscuenta.Columns[15].Visible = false;
            dgvdatoscuenta.Columns[16].Visible = false;
            dgvdatoscuenta.Columns[0].Width = 90;
            dgvdatoscuenta.Columns[2].Width = 250;
            dgvdatoscuenta.Columns[3].Width = 70;
            dgvdatoscuenta.Columns[4].Width = 70;
            dgvdatoscuenta.Columns[5].Width = 70;
            dgvdatoscuenta.Columns[6].Width = 70;
            dgvdatoscuenta.Columns[7].Width = 90;
            dgvdatoscuenta.Columns[8].Width = 90;
            dgvdatoscuenta.Columns[9].Width = 90;
            dgvdatoscuenta.Columns[10].Width = 50;
            dgvdatoscuenta.Columns[11].Width = 90;
            dgvdatoscuenta.Columns[12].Width = 70;
            dgvdatoscuenta.Columns[13].Width = 100;
            dgvdatoscuenta.Columns[14].Width = 90;
        }

        private void AutoCompletar()
        {
            AsientosDataSource cuenta = new AsientosDataSource();
            var items = this.negocioCuenta.CargarCuentaDetalle();
            AutoCompleteStringCollection cuentas = new AutoCompleteStringCollection();
            foreach (var item in items)
            {
                cuentas.Add(item.Cuenta);
            }

            txtcuenaju.AutoCompleteCustomSource = cuentas;
            txtcuncor.AutoCompleteCustomSource = cuentas;
            txtcierre.AutoCompleteCustomSource = cuentas;
        }

        /// <summary>
        /// Cargar lista de cuentas en datagriedview
        /// </summary>
        private void CargarDatosCuenta()
        {
            List<AsientosDataSource> datasSource = new List<AsientosDataSource>();
            try
            {
                datasSource = this.negocioCuenta.CargarCuenta();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un error. " + ex.Message);
            }

            dgvdatoscuenta.DataSource = datasSource;
            this.NombresColumna();
        }


        #endregion

        #region VALIDACIONES

        /// <summary>
        /// Validarguardars this instance.
        /// </summary>
        /// <returns>booleano si guarda o no guarda</returns>
        private bool Validarguardar()
        {
            bool result = false;
            if (!txtnumcu.Text.Equals(string.Empty) && !txtnombre.Text.Equals(string.Empty) &&
     (radio_general.Checked == true || radio_detalle.Checked == true))
            {
                if (check_ajustes.Checked == true)
                {
                    if (!txtnitajus.Text.Equals(string.Empty) && !txtcuenaju.Text.Equals(string.Empty) &&
                        !txtcuncor.Text.Equals(string.Empty))
                    {
                        if (check_cuentaret.Checked == true)
                        {
                            if (!txtporcrete.Text.Equals(string.Empty) &&
                                !txtconcerete.Text.Equals(string.Empty))
                            {
                                result = true;
                            }
                            else
                            {
                                result = false;
                                MessageBox.Show("Debe ingresar todos los datos", "Guardo", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            result = true;
                        }
                    }
                    else
                    {
                        result = false;
                        MessageBox.Show("Debe ingresar todos los datos", "Guardo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    result = true;
                }
            }
            else
            {
                result = false;
                MessageBox.Show("Debe ingresar todos los datos", "Guardo", MessageBoxButtons.OK);
            }

            return result;
        }
        #endregion

        #region GUARDAR DATOS

        private AsientosDataSource GuardarDatos()
        {
            AsientosDataSource cuenta = new AsientosDataSource();
            cuenta.Cuenta = txtnumcu.Text;
            cuenta.Cia = Program.compa;
            cuenta.Tipocta = radio_general.Checked == true ? "M" : "A";
            cuenta.Nombre = txtnombre.Text;
            cuenta.Pidenit = check_pidenit.Checked;
            cuenta.Centro = check_centro.Checked;
            cuenta.Ajusteinteg = check_ajustes.Checked;
            cuenta.Nitajustes = txtnitajus.Text;
            cuenta.Cueaju = txtcuenaju.Text;
            cuenta.Cuencorre = txtcuncor.Text;
            cuenta.Ajudoc = txtdoc.Text;
            cuenta.Cuentret = check_cuentaret.Checked;
            cuenta.Porete = txtporcrete.Text.Equals(string.Empty) ? 0 : int.Parse(txtporcrete.Text);
            cuenta.Concepret = txtconcerete.Text;
            cuenta.Cuentacierreimp = txtcierre.Text;
            return cuenta;
        }

        /// <summary>
        /// Handles the Click event of the Btn_guardar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (this.botonclick.Equals("agregar"))
            {
                bool result = this.Validarguardar();
                if (result)
                {
                    AsientosDataSource cuenta = new AsientosDataSource();
                    cuenta = this.GuardarDatos();
                    bool existe = true;
                    try
                    {
                        existe = this.negocioCuenta.VerificarCuenta(cuenta);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se presento un error. " + ex.Message);
                    }

                    if (!existe)
                    {
                        try
                        {
                            this.negocioCuenta.GuardarCuenta(cuenta);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Se presento un error. " + ex.Message);
                        }

                        MessageBox.Show("La cuenta fue guardada exitosamente", "Guardo", MessageBoxButtons.OK);
                        this.CargarDatosCuenta();
                        this.CamposVacios();
                        this.CamposInactivos();
                        btn_nuevo.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("La cuenta ya existe", "ERROR", MessageBoxButtons.OK);
                    }
                }
            }

            if (this.botonclick.Equals("editar"))
            {
                bool result = this.Validarguardar();
                if (result)
                {
                    AsientosDataSource cuenta = new AsientosDataSource();
                    cuenta = this.GuardarDatos();
                    if (this.cuentaedit == cuenta.Cuenta)
                    {
                        try
                        {
                            this.negocioCuenta.ActualizarCuenta(cuenta, this.cuentaedit);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Se presento un error. " + ex.Message);
                        }

                        MessageBox.Show("La cuenta fue actualizada exitosamente", "Guardo", MessageBoxButtons.OK);
                        this.CargarDatosCuenta();
                        this.CamposVacios();
                        this.CamposInactivos();
                    }
                    else
                    {
                        bool existe = true;
                        try
                        {
                            existe = this.negocioCuenta.VerificarCuenta(cuenta);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Se presento un error. " + ex.Message);
                        }
                        if (!existe)
                        {
                            try
                            {
                                this.negocioCuenta.ActualizarCuenta(cuenta, this.cuentaedit);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Se presento un error. " + ex.Message);
                            }

                            MessageBox.Show("La cuenta fue actualizada exitosamente", "Guardo", MessageBoxButtons.OK);
                            this.CargarDatosCuenta();
                            this.CamposVacios();
                            this.CamposInactivos();
                        }
                        else
                        {
                            MessageBox.Show("LA CUENTA YA EXISTE", "CUENTA", MessageBoxButtons.OK);
                        }

                    }
                }
            }
        }

        #endregion

        #region ACTIVACION,DESACTIVACION Y LIMPIEZA DE CAMPOS

        private void CamposVacios()
        {
            txtnumcu.Text = string.Empty;
            txtnombre.Text = string.Empty;
            check_pidenit.Checked = false;
            check_centro.Checked = false;
            check_ajustes.Checked = false;
            txtnitajus.Text = string.Empty;
            txtcuenaju.Text = string.Empty;
            txt_nombrecuentaajuste.Text = string.Empty;
            txt_nombrecuentacorre.Text = string.Empty;
            txtcuncor.Text = string.Empty;
            check_cuentaret.Checked = false;
            txtporcrete.Text = string.Empty;
            txtconcerete.Text = string.Empty;
            txtcierre.Text = string.Empty;
            txt_nomcucierre.Text = string.Empty;
        }

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
            if (this.botonclick.Equals("agregar"))
            {
                btn_editar.Enabled = false;
            }
            btn_guardar.Enabled = true;

            this.AutoCompletar();
        }

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
        }

        /// <summary>
        /// Handles the CheckedChanged event of the Check_cuentaret control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Check_cuentaret_CheckedChanged(object sender, EventArgs e)
        {
            if (check_cuentaret.Checked)
            {
                txtporcrete.Enabled = true;
                txtconcerete.Enabled = true;
                txtcierre.Enabled = true;
            }
            else
            {
                txtporcrete.Enabled = false;
                txtconcerete.Enabled = false;
                txtcierre.Enabled = false;
                txtporcrete.Text = string.Empty;
                txtconcerete.Text = string.Empty;
                txtcierre.Text = string.Empty;
                txt_nomcucierre.Text = string.Empty;
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of the Check_ajustes control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Check_ajustes_CheckedChanged(object sender, EventArgs e)
        {
            if (check_ajustes.Checked)
            {
                txtcuenaju.Enabled = true;
                txtnitajus.Enabled = true;
                txtcuncor.Enabled = true;
                txtdoc.Enabled = true;
            }
            else
            {
                txtcuenaju.Enabled = false;
                txtnitajus.Enabled = false;
                txtcuncor.Enabled = false;
                txtdoc.Enabled = false;
                txtcuenaju.Text = string.Empty;
                txtnitajus.Text = string.Empty;
                txtcuncor.Text = string.Empty;
                txtdoc.Text = string.Empty;
                txt_nombrecuentaajuste.Text = string.Empty;
                txt_nombrecuentacorre.Text = string.Empty;
            }
        }
        #endregion

        private void ValidaCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = this.funtions.ValidacionNumerico(e).Handled;
            }
        }

        private bool ValidarCuenta()
        {
            bool result = false;
            bool existe = false;
            existe = this.negocioCuenta.VerificarCuentaVal(txtnumcu.Text);
            if (existe == true)
            {
                txt_nombre.Text = "CUENTA EXISTENTE";
            }
            else
            {
                int tamanio = txtnumcu.Text.Length;
                if (tamanio == 3 || tamanio == 5 || tamanio == 7 || tamanio == 9 || tamanio == 11)
                {
                    txt_nombre.Text = "CUENTA NO ACEPTADA";
                    result = false;
                }
                else if (tamanio == 1)
                {
                    result = true;
                }
                else if (tamanio == 2)
                {
                    result = this.negocioCuenta.VerificarCuentaVal(txtnumcu.Text.Substring(0, 1));
                    if (result == false)
                    {
                        txt_nombre.Text = "CUENTA MAYOR NO EXISTE";
                    }
                }
                else if (tamanio == 4 || tamanio == 6 || tamanio == 8 || tamanio == 10 || tamanio == 12)
                {
                    result = this.negocioCuenta.VerificarCuentaVal(txtnumcu.Text.Substring(0, tamanio - 2));
                    if (result == false)
                    {
                        txt_nombre.Text = "CUENTA MAYOR NO EXISTE";
                    }
                }
            }
            return result;
        }

        private void txtnumcu_KeyUp(object sender, KeyEventArgs e)
        {
            int tamanio = txtnumcu.Text.Length;
            if (!txtnumcu.Text.Equals(string.Empty) && (tamanio != 3 && tamanio != 5 && tamanio != 7 && tamanio != 11))
            {
                txt_nombre.Text = this.negocioCuenta.DevolverNombre(txtnumcu.Text);
            }
            else
            {
                txt_nombre.Text = string.Empty;
            }
            if (e.KeyCode == Keys.Enter)
            {
                bool valida = this.ValidarCuenta();
                e.Handled = valida == false ? false : true;
                if (e.Handled == true)
                {
                    btn_guardar.Enabled = true;
                    SendKeys.Send("{TAB}");
                }
                else
                {
                    btn_guardar.Enabled = true;
                }
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            reportes.Form_reportecuentas frm = new reportes.Form_reportecuentas();
            frm.Show();
        }

        private void txtcuenaju_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = this.funtions.ValidacionNumerico(e).Handled;
            }
        }

        private void txtcuncor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = this.funtions.ValidacionNumerico(e).Handled;
            }
        }

        private void txtcierre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = this.funtions.ValidacionNumerico(e).Handled;
            }
        }
    }
}