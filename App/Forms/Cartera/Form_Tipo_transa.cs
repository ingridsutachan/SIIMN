﻿namespace App.Forms.Cartera
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Entities.Types;
    using Negocios.Cartera;
    using Negocios.Contable;

    public partial class Form_Tipo_transa : Form
    {
        private TipoTransaccionN negocioTipoTrans;

        private Comprobantesn negocioComprobante;

        private string botonclick;

        private Funciones funtions;

        private bool usrClose;

        public Form_Tipo_transa()
        {
            this.negocioTipoTrans = new TipoTransaccionN();
            this.negocioComprobante = new Comprobantesn();
            this.funtions = new Funciones();
            this.InitializeComponent();
            this.CargarTipoTrans();
            this.AutoCompletar();
        }

        #region VISUALIZACION

        private void CargarTipoTrans()
        {
            List<TipoTransacDataSource> tablaTipoTra = new List<TipoTransacDataSource>();
            tablaTipoTra = this.negocioTipoTrans.CargarTiposTrans();
            dgv_tipotransa.DataSource = tablaTipoTra;
            this.NombresTabla();
        }

        private void NombresTabla()
        {
            dgv_tipotransa.Columns[0].HeaderText = "Código";
            dgv_tipotransa.Columns[1].HeaderText = "Nombre";
            dgv_tipotransa.Columns[2].HeaderText = "Afecta Saldo";
            dgv_tipotransa.Columns[3].HeaderText = "Afecta otros";
            dgv_tipotransa.Columns[4].HeaderText = "Genera Asiento";
            dgv_tipotransa.Columns[5].HeaderText = "Consecutivo";
            dgv_tipotransa.Columns[6].HeaderText = "Número Actual";
            dgv_tipotransa.Columns[7].HeaderText = "Código Comprobante";
            dgv_tipotransa.Columns[8].HeaderText = "Nombre Comprobante";
            dgv_tipotransa.Columns[0].Width = 50;
            dgv_tipotransa.Columns[1].Width = 120;
            dgv_tipotransa.Columns[2].Width = 70;
            dgv_tipotransa.Columns[3].Width = 70;
            dgv_tipotransa.Columns[4].Width = 70;
            dgv_tipotransa.Columns[5].Width = 70;
            dgv_tipotransa.Columns[6].Width = 70;
            dgv_tipotransa.Columns[7].Width = 120;
        }

        private void CamposActivos()
        {
            txt_codigotipo.Enabled = true;
            txt_nombre.Enabled = true;
            radio_mas.Enabled = true;
            radio_menos.Enabled = true;
            check_otros.Enabled = true;
            check_genera.Enabled = true;
            check_consecutivo.Enabled = true;
            txt_compro.Enabled = true;
        }

        private void CamposInactivos()
        {
            txt_codigotipo.Enabled = false;
            txt_nombre.Enabled = false;
            radio_mas.Enabled = false;
            radio_menos.Enabled = false;
            check_otros.Enabled = false;
            check_genera.Enabled = false;
            check_consecutivo.Enabled = false;
            txt_numero.Enabled = false;
            txt_compro.Enabled = false;
        }

        private void CamposLimpios()
        {
            txt_codigotipo.Text = string.Empty;
            txt_nombre.Text = string.Empty;
            radio_mas.Checked = false;
            radio_menos.Checked = false;
            check_otros.Checked = false;
            check_genera.Checked = false;
            check_consecutivo.Checked = false;
            txt_numero.Text = string.Empty;
            txt_compro.Text = string.Empty;
            txt_nombrecom.Text = string.Empty;
        }

        private void AutoCompletar()
        {
            ComprobantesDataSource comprob = new ComprobantesDataSource();
            var items = this.negocioComprobante.CargarDatos();
            AutoCompleteStringCollection compros = new AutoCompleteStringCollection();
            foreach (var item in items)
            {
                compros.Add(Convert.ToString(item.Codigo));
                compros.Add(item.Descricompro);
            }

            txt_compro.AutoCompleteCustomSource = compros;
        }

        #endregion

        #region BOTONEES CLICK

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            this.CamposActivos();
            this.botonclick = "agregar";
            this.btn_guardar.Enabled = true;
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            this.CamposActivos();
            this.botonclick = "editar";
            this.btn_guardar.Enabled = true;
            TipoTransacDataSource tipotran = new TipoTransacDataSource();
            string id = dgv_tipotransa.CurrentRow.Cells[0].Value.ToString();
            tipotran = this.negocioTipoTrans.DevolverDato(id);
            txt_codigotipo.Text = tipotran.CodigoTransac;
            txt_codigotipo.ReadOnly = true;
            txt_nombre.Text = tipotran.NombreTransac;
            radio_mas.Checked = tipotran.AfectaSaldo == "+" ? true : false;
            radio_menos.Checked = tipotran.AfectaSaldo == "-" ? true : false;
            check_otros.Checked = tipotran.AfectaOtros;
            check_genera.Checked = tipotran.GeneraAsiento;
            check_consecutivo.Checked = tipotran.Consecutivo;
            txt_numero.Text = Convert.ToString(tipotran.NumeroActual);
            txt_compro.Text = Convert.ToString(tipotran.CodigoComprobante);
            txt_nombrecom.Text = tipotran.NombreComprobante;
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            this.CamposLimpios();
            this.CamposInactivos();
            string idtransac_eliminar = dgv_tipotransa.CurrentRow.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar?", "ELIMINAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (this.negocioTipoTrans.EliminarTransacc(idtransac_eliminar))
                    {
                        MessageBox.Show("Eliminado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se presento un error. " + ex.Message);
                }

                this.CargarTipoTrans();
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            List<TipoTransacDataSource> tipot = new List<TipoTransacDataSource>();
            try
            {
                tipot = this.negocioTipoTrans.BuscarTipo(txt_buscar.Text);
                if (tipot.Count > 0)
                {
                    dgv_tipotransa.DataSource = tipot;
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
            }
        }

        #endregion

        #region GUARDAR DATOS

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            bool valida = this.ValidarCampos();
            if (valida)
            {
                TipoTransacDataSource tipot = new TipoTransacDataSource();
                tipot = this.GuardarDatos();
                if (this.botonclick.Equals("agregar"))
                {
                    bool existe = this.negocioTipoTrans.ExisteDato(tipot.CodigoTransac);
                    if (!existe)
                    {
                        bool guardo = this.negocioTipoTrans.GuardarDatos(tipot);
                        if (guardo)
                        {
                            MessageBox.Show("El tipo de transacción ha sido guardado", "GUARDAR", MessageBoxButtons.OK);
                            this.CargarTipoTrans();
                            this.CamposLimpios();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El tipo de transacción ya se encuentra registrado", "ERROR", MessageBoxButtons.OK);
                    }
                }

                if (this.botonclick.Equals("editar"))
                {
                    bool actualiza = this.negocioTipoTrans.ActualizarDato(tipot);
                    if (actualiza)
                    {
                        MessageBox.Show("El tipo de transacción ha sido actualizado", "ACTUALIZAR", MessageBoxButtons.OK);
                        this.CargarTipoTrans();
                        this.CamposLimpios();
                    }
                }
            }
        }

        private bool ValidarCampos()
        {
            bool result = false;
            if (!txt_codigotipo.Text.Equals(string.Empty) && !txt_nombre.Text.Equals(string.Empty) && (radio_mas.Checked == true || radio_menos.Checked == true)
                && !txt_compro.Text.Equals(string.Empty) && !txt_nombrecom.Text.Equals("No existe"))
            {
                if (check_consecutivo.Checked == true)
                {
                    if (!txt_numero.Text.Equals(string.Empty))
                    {
                        result = true;
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar todos los campos", "ERROR", MessageBoxButtons.OK);
                        result = false;
                    }
                }
                else
                {
                    result = true;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los campos", "ERROR", MessageBoxButtons.OK);
                result = false;
            }

            return result;
        }

        private TipoTransacDataSource GuardarDatos()
        {
            TipoTransacDataSource tipotran = new TipoTransacDataSource();
            tipotran.CodigoTransac = txt_codigotipo.Text;
            tipotran.NombreTransac = txt_nombre.Text;
            tipotran.AfectaSaldo = radio_mas.Checked == true ? "+" : "-";
            tipotran.AfectaOtros = check_otros.Checked;
            tipotran.GeneraAsiento = check_genera.Checked;
            tipotran.Consecutivo = check_consecutivo.Checked;
            tipotran.NumeroActual = txt_numero.Enabled == true ? int.Parse(txt_numero.Text) : 0;
            int valor = 0;
            string comprobante = !int.TryParse(txt_compro.Text, out valor) ? txt_nombrecom.Text : txt_compro.Text;
            tipotran.CodigoComprobante = int.Parse(comprobante);
            return tipotran;
        }

        #endregion

        #region EVENTOS

        private void Check_consecutivo_CheckedChanged(object sender, EventArgs e)
        {
            txt_numero.Enabled = check_consecutivo.Checked == true ? true : false;
        }

        private void Dgv_tipotransa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_tipotransa.SelectedCells.Count > 0)
            {
                btn_editar.Enabled = true;
                btn_eliminar.Enabled = true;
            }
        }

        #endregion

        #region ENTERTAB

        private void EnterTab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void Txt_numero_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txt_compro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int valor = 0;
                if (!int.TryParse(txt_compro.Text, out valor))
                {
                    bool existe = this.negocioComprobante.ExisteComprobante(int.Parse(txt_compro.Text));
                    if (existe)
                    {
                       // int id = this.negocioComprobante.Devolvern(txt_compro.Text);
                      //  txt_nombrecom.Text = Convert.ToString(id);
                        e.Handled = false;
                        SendKeys.Send("{TAB}");
                    }
                    else
                    {
                        e.Handled = true;
                        txt_nombrecom.Text = "No existe";
                    }
                }
                else
                {
                    bool existe = this.negocioComprobante.ExisteComprobante(int.Parse(txt_compro.Text));
                    if (existe)
                    {
                        ComprobantesDataSource compro = new ComprobantesDataSource();
                        compro = this.negocioComprobante.DevolverDatos(int.Parse(txt_compro.Text));
                        txt_nombrecom.Text = compro.Descricompro;
                        e.Handled = false;
                        SendKeys.Send("{TAB}");
                    }
                    else
                    {
                        e.Handled = true;
                        txt_nombrecom.Text = "No existe";
                    }
                }
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
                    this.CargarTipoTrans();
                }
            }
        }

        #endregion

        #region SALIR FORMULARIO

        private void Form_Tipo_transa_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Btn_salir_Click(object sender, EventArgs e)
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
