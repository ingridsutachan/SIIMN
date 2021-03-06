﻿////*********************************************************
//
//    <copyright file="Form_MovsinAct.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 30 Marzo 2015
//    </copyright>
//
////*********************************************************
namespace App.Forms.Contable
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Windows.Forms;
    using App.Forms.Contable.Reportes;
    using Entities.Types;
    using Negocios.Contable;

    public partial class Form_MovsinAct : Form
    {
        private asientosn negocioAsiento;

        private bool usrClose;

        private Funciones funtions;

        public Form_MovsinAct()
        {
            this.negocioAsiento = new asientosn();
            this.funtions = new Funciones();
            this.InitializeComponent();
            this.CargarMeses();
            cbx_mes.Focus();
        }

        public void SalirReporte()
        {
            this.Enabled = true;
            this.Habilitar();
        }

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
                case Keys.Control | Keys.P:
                    if (btn_imprimir.Enabled == true)
                    {
                        this.Btn_imprimir_Click(sender, eve);
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

        private void CargarMeses()
        {
            txt_anio.Text = Convert.ToString(DateTime.Now.Year);
            List<MesesDataSource> meses = new List<MesesDataSource>();
            string[] mes1 = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            for (int i = 0; i <= 11; i++)
            {
                MesesDataSource mes = new MesesDataSource();
                mes.NumeroMes = Convert.ToString(i + 1);
                mes.NombreMes = mes1[i].ToUpper();
                meses.Add(mes);
            }
            cbx_mes.DataSource = meses;
            cbx_mes.ValueMember = "NumeroMes";
            cbx_mes.DisplayMember = "NombreMes";
            cbx_mes.SelectedIndex = DateTime.Now.Month - 1;
        }

        private void Deshabilitar()
        {
            cbx_mes.Enabled = false;
            txt_anio.Enabled = false;
            txt_compro.Enabled = false;
            txt_docin.Enabled = false;
            txt_docfin.Enabled = false;
            dtt_fecha.Enabled = false;
            check_encabe.Enabled = false;
            cbx_mes.SelectedIndex = DateTime.Now.Month - 1;
            txt_anio.Text = Convert.ToString(DateTime.Now.Year);
            txt_compro.Clear();
            txt_docfin.Clear();
            txt_docin.Clear();
            dtt_fecha.Value = DateTime.Now;
            check_encabe.Checked = true;
        }

        private void Habilitar()
        {
            cbx_mes.Enabled = true;
            txt_anio.Enabled = true;
            txt_compro.Enabled = true;
            txt_docin.Enabled = true;
            txt_docfin.Enabled = true;
            dtt_fecha.Enabled = true;
            check_encabe.Enabled = true;
            cbx_mes.Focus();
        }

        #endregion 

        #region BOTONES

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            List<AsientoDataSourceShow> asientosinact = new List<AsientoDataSourceShow>();
            if (this.ValidarCampos())
            {
                try
                {
                    asientosinact = this.negocioAsiento.CargarInformeSinActualizar(txt_anio.Text, int.Parse(cbx_mes.SelectedValue.ToString()), txt_compro.Text, txt_docin.Text, txt_docfin.Text, Program.compa);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SE PRESENTO UN ERROR : " + ex.Message, "ERROR", MessageBoxButtons.OK);
                }
                Form_ReporteAsiento frm = new Form_ReporteAsiento(this, "sinact", asientosinact,dtt_fecha.Value.ToShortDateString(),check_encabe.Checked);
                frm.MdiParent = this.MdiParent;
                frm.Show();
                this.Deshabilitar();
            }
        }

              private void Btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ESTA SEGURO QUE DESEA SALIR?", "SALIR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.usrClose = true;
                this.Close();
            }
        }

        #endregion

        #region CERRAR FORMULARIO

        private void Frm_MovsinAct_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.usrClose)
            {
                DialogResult result = MessageBox.Show("ESTA SEGURO QUE DESEA SALIR?", "SALIR", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        #endregion

        #region VALIDACIONES

        private bool ValidarCampos()
        {
            if (!string.Empty.Equals(txt_anio.Text) && !string.Empty.Equals(txt_compro.Text) && !string.Empty.Equals(txt_docin.Text)
                && !string.Empty.Equals(txt_docfin))
            {
                if (this.negocioAsiento.TienenMovimiento(txt_anio.Text, int.Parse(cbx_mes.SelectedValue.ToString()), txt_compro.Text, txt_docin.Text, txt_docfin.Text,Program.compa))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("EL ASIENTO NO TIENE MOVIMIENTO","ERROR",MessageBoxButtons.OK);
                    return false; 
                }
            }
            else
            {
                MessageBox.Show("POR FAVOR INGRESE TODOS LOS CAMPOS", "ERROR", MessageBoxButtons.OK);
                return false;
            }
        }

        private void ValidaNumerico_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txt_anio_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (txt_anio.Text.Length != 4 || int.Parse(txt_anio.Text) < 1900 || int.Parse(txt_anio.Text) > 2100)
            {
                tb.Focus();
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

        private void ValidaNumericoyPor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            else
            {
                e.Handled = this.funtions.ValidacionNumeroAsterisco(e).Handled;
            }
        }

        private void Asterisco_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Contains("*"))
            {
                tb.Text = "**";
            }
        }

        private void Asteriscodocumento_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Contains("*"))
            {
                tb.Text = "**";
                txt_docfin.Text = "**";
                txt_docfin.Enabled = false;
            }
        }

        #endregion

        }
}
