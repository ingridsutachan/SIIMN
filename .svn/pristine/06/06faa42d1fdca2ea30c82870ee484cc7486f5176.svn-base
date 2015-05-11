namespace App.Forms.Cartera
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Entities.Types;
    using Negocios.Cartera;
    using Negocios.Contable;

    public partial class Form_ConPago : Form
    {
                private ConceptoPagoN negocioConPago;

        private FormasPagoN negocioFormas;

        private string butonclick;

        private Cuentan negocioCuenta;

        private bool usrClose;

        private Funciones funtions;

        public Form_ConPago()
        {
            this.negocioConPago = new ConceptoPagoN();

            this.negocioFormas = new FormasPagoN();

            this.negocioCuenta = new Cuentan();

            this.funtions = new Funciones();

            this.InitializeComponent();

            this.CargarConPago();

            this.AutoCompletar();
        }

        #region VISUALIZACION

        private void CargarConPago()
        {
            List<ConceptoPagoDataSource> tablaconpago = new List<ConceptoPagoDataSource>();
            //tablaconpago = this.negocioConPago.CargarConcePago();
            dgv_conpago.DataSource = tablaconpago;
            this.NombresTabla();
            this.CargarComFormas();
        }

        private void NombresTabla()
        {
            dgv_conpago.Columns[0].HeaderText = "Código";
            dgv_conpago.Columns[1].HeaderText = "Nombre";
            dgv_conpago.Columns[2].HeaderText = "Cuenta";
            dgv_conpago.Columns[3].Visible = false;
            dgv_conpago.Columns[4].HeaderText = "Porcentaje";
            dgv_conpago.Columns[5].HeaderText = "Forma de Pago";
            dgv_conpago.Columns[6].Visible = false;
            dgv_conpago.Columns[0].Width = 60;
            dgv_conpago.Columns[1].Width = 150;
            dgv_conpago.Columns[2].Width = 90;
            dgv_conpago.Columns[4].Width = 70;
            dgv_conpago.Columns[5].Width = 140;
        }

        private void CargarComFormas()
        {
            try
            {
                combo_forma.DataSource = this.negocioFormas.CargarFormas();
                combo_forma.ValueMember = "CodigoFormas";
                combo_forma.DisplayMember = "NombreFormas";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un error. " + ex.Message);
            }
        }

        private void CamposActivos()
        {
            txt_codigo.Enabled = true;
            txt_nombre.Enabled = true;
            txt_cuenta.Enabled = true;
            txt_porcentaje.Enabled = true;
            combo_forma.Enabled = true;
        }

        private void CamposInactivos()
        {
            txt_codigo.Enabled = false;
            txt_nombre.Enabled = false;
            txt_cuenta.Enabled = false;
            txt_porcentaje.Enabled = false;
            combo_forma.Enabled = false;
            btn_guardar.Enabled = false;
        }

        private void CamposLimpios()
        {
            txt_codigo.Text = string.Empty;
            txt_nombre.Text = string.Empty;
            txt_cuenta.Text = string.Empty;
            txt_nombrecuenta.Text = string.Empty;
            txt_porcentaje.Text = string.Empty;
            combo_forma.Enabled = false;
        }

        private void AutoCompletar()
        {
            CuentaDataSource cuenta = new CuentaDataSource();
            var items = this.negocioCuenta.CargarCuenta();
            AutoCompleteStringCollection cuentas = new AutoCompleteStringCollection();
            foreach (var item in items)
            {
                cuentas.Add(item.Cuenta);
                cuentas.Add(item.Nombre);
            }

            txt_cuenta.AutoCompleteCustomSource = cuentas;
        }

        #endregion

        #region BOTONES CLICK

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            this.CamposLimpios();
            this.CamposActivos();
            btn_guardar.Enabled = true;
            this.butonclick = "agregar";
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            ConceptoPagoDataSource conpago = new ConceptoPagoDataSource();
            string id = dgv_conpago.CurrentRow.Cells[0].Value.ToString();
          //  conpago = this.negocioConPago.DevolverConPago(id);
            txt_codigo.Text = conpago.CodigoConPa;
            this.CamposActivos();
            txt_codigo.Enabled = false;
            txt_nombre.Text = conpago.NombreConPa;
            txt_cuenta.Text = conpago.Cuenta;
            txt_nombrecuenta.Text = conpago.NombreCuenta;
            combo_forma.SelectedValue = conpago.CodigoForma;
            txt_porcentaje.Text = Convert.ToString(conpago.Porcentaje);
            this.butonclick = "editar";
            btn_guardar.Enabled = true;
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            this.CamposInactivos();
            this.CamposLimpios();
            string id = dgv_conpago.CurrentRow.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar?", "ELIMINAR", MessageBoxButtons.YesNo);
            /*if (result == DialogResult.Yes)
            {
                try
                {
                    if (this.negocioConPago.EliminarConPa(id))
                    {
                        MessageBox.Show("Eliminado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se presento un error. " + ex.Message);
                }

                this.CargarConPago();
            }*/
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            List<ConceptoPagoDataSource> conpago = new List<ConceptoPagoDataSource>();
           /* try
            {
                conpago = this.negocioConPago.BuscarConPa(txt_buscar.Text);
                if (conpago.Count > 0)
                {
                    dgv_conpago.DataSource = conpago;
                    this.NombresTabla();
                }
                else
                {
                    MessageBox.Show("No se encuentra algún resultado", "BUSQUEDA", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un error. " + ex.Message);
            }*/
        }

        #endregion

        #region GUARDAR

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            bool validar = this.ValidarCampos();
            if (validar)
            {
                ConceptoPagoDataSource conpago = new ConceptoPagoDataSource();
                conpago.CodigoConPa = txt_codigo.Text;
                conpago.NombreConPa = txt_nombre.Text;
                int valor = 0;
                string cuenta = !int.TryParse(txt_cuenta.Text, out valor) ? txt_nombrecuenta.Text : txt_cuenta.Text;
                conpago.Cuenta = cuenta;
                conpago.CodigoForma = combo_forma.SelectedValue.ToString();
                conpago.Porcentaje = Convert.ToDecimal(txt_porcentaje.Text);

              /*  if (this.butonclick.Equals("agregar"))
                {
                    bool existe = this.negocioConPago.ExisteConPago(txt_codigo.Text);

                    if (!existe)
                    {
                        bool guardo = this.negocioConPago.GuardoConPago(conpago);
                        if (guardo)
                        {
                            MessageBox.Show("El concepto ha sido guardado", "GUARDAR", MessageBoxButtons.OK);
                            this.CamposInactivos();
                            this.CamposLimpios();
                            this.CargarConPago();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El concepto ya existe", "ERROR", MessageBoxButtons.OK);
                    }
                }
                else if (this.butonclick.Equals("editar"))
                {
                    bool guardo = this.negocioConPago.ActualizarConPago(conpago);
                    if (guardo)
                    {
                        MessageBox.Show("El concepto ha sido actualizado", "GUARDAR", MessageBoxButtons.OK);
                        this.CamposInactivos();
                        this.CamposLimpios();
                        this.CargarConPago();
                    }
                }*/
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los campos", "ERROR", MessageBoxButtons.OK);
            }
        }

        private bool ValidarCampos()
        {
            bool validar = false;

            if (!txt_codigo.Text.Equals(string.Empty) && !txt_nombre.Text.Equals(string.Empty) && !txt_cuenta.Text.Equals(string.Empty)
                && !txt_porcentaje.Text.Equals(string.Empty) && !(txt_nombrecuenta.Text.Equals("Cuenta General") || txt_nombrecuenta.Text.Equals("Cuenta no existente")))
            {
                validar = true;
            }
            else
            {
                validar = false;
            }

            return validar;
        }

        #endregion

        #region EVENTOS

        private void Dgv_conpago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_conpago.SelectedCells.Count > 0)
            {
                btn_editar.Enabled = true;
                btn_eliminar.Enabled = true;
            }
        }

        private void Txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                EventArgs eve = new EventArgs();
                this.Btn_buscar_Click(sender, eve);
                if (txt_buscar.Text.Equals(string.Empty))
                {
                    this.CargarConPago();
                }
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

        private void Txt_cuenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string result = this.funtions.ValidaCuentaoNombre(txt_cuenta.Text);
                txt_nombrecuenta.Text = result;
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

        private void Txt_porcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            else
            {
                e.Handled = this.funtions.ValidacionDecimal(e).Handled;
            }
        }

        #endregion

        #region SALIR FORMULARIO

        private void Form_ConPago_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Salircuent_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea salir?", "SALIR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.usrClose = true;
                this.Close();
            }
        }
        #endregion
    }
}
