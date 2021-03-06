﻿////*********************************************************
//
//    <copyright file="Form_inflacion.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 26 febrero 2015
//    </copyright>
//
////*********************************************************
namespace App.Forms.Contable
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using Entities.Types;
    using Negocios.Contable;
    using Negocios.General;

    public partial class Form_Inflacion : Form
    {
        private inflacionn negocioInflacion;

        private Parametrosn negocioParametro;

        private bool usrClose;

        private Funciones funtions;

        string aniotrabajo;

        public Form_Inflacion()
        {
            this.InitializeComponent();
            this.negocioInflacion = new inflacionn();
            this.negocioParametro = new Parametrosn();
            this.funtions = new Funciones();
            menu_botones.Focus();
            this.CargarAnio();
        }

        private void CargarAnio()
        {
            try
            {
                this.aniotrabajo = this.negocioParametro.AnioTrabajo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message, "ERROR");
            }
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
                case Keys.Control | Keys.N:
                    if (btn_nuevo.Enabled == true)
                    {
                        this.Btn_nuevo_Click(sender, eve);
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

        private void CamposActivos()
        {
            txtenero.Enabled = true;
            txtfebrero.Enabled = true;
            txtmarzo.Enabled = true;
            txtabril.Enabled = true;
            txtmayo.Enabled = true;
            txtjunio.Enabled = true;
            txtjulio.Enabled = true;
            txtagosto.Enabled = true;
            txtsepti.Enabled = true;
            txtoctu.Enabled = true;
            txtnov.Enabled = true;
            txtdici.Enabled = true;
            txt_acumulado.Enabled = true;
        }

        private void CamposInactivos()
        {
            txtenero.Enabled = false;
            txtfebrero.Enabled = false;
            txtmarzo.Enabled = false;
            txtabril.Enabled = false;
            txtmayo.Enabled = false;
            txtjunio.Enabled = false;
            txtjulio.Enabled = false;
            txtagosto.Enabled = false;
            txtsepti.Enabled = false;
            txtoctu.Enabled = false;
            txtnov.Enabled = false;
            txtdici.Enabled = false;
            txt_acumulado.Enabled = false;
            btn_guardar.Enabled = false;
            menu_botones.Focus();
        }

        private void CamposVacios()
        {
            txtenero.Text = "0,00";
            txtfebrero.Text = "0,00";
            txtmarzo.Text = "0,00";
            txtabril.Text = "0,00";
            txtmayo.Text = "0,00";
            txtjunio.Text = "0,00";
            txtjulio.Text = "0,00";
            txtagosto.Text = "0,00";
            txtsepti.Text = "0,00";
            txtoctu.Text = "0,00";
            txtnov.Text = "0,00";
            txtdici.Text = "0,00";
            txt_acumulado.Text = "0,00";
        }

        #endregion

        #region BOTONES

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            this.CamposActivos();
            btn_guardar.Enabled = true;
            this.CargarCampos();
            txtenero.Focus();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            bool guardar = this.ValidarCampos();
            if (guardar)
            {
                List<InflacionDataSource> inflac = new List<InflacionDataSource>();
                try
                {
                    inflac = this.negocioInflacion.CargarDatos(Program.compa,this.aniotrabajo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message, "ERROR");
                }
                inflac[0].inflacion = decimal.Parse(txtenero.Text);
                inflac[1].inflacion = decimal.Parse(txtfebrero.Text);
                inflac[2].inflacion = decimal.Parse(txtmarzo.Text);
                inflac[3].inflacion = decimal.Parse(txtabril.Text);
                inflac[4].inflacion = decimal.Parse(txtmayo.Text);
                inflac[5].inflacion = decimal.Parse(txtjunio.Text);
                inflac[6].inflacion = decimal.Parse(txtjulio.Text);
                inflac[7].inflacion = decimal.Parse(txtagosto.Text);
                inflac[8].inflacion = decimal.Parse(txtsepti.Text);
                inflac[9].inflacion = decimal.Parse(txtoctu.Text);
                inflac[10].inflacion = decimal.Parse(txtnov.Text);
                inflac[11].inflacion = decimal.Parse(txtdici.Text);
                bool guardo = false;
                try
                {
                    guardo = this.negocioInflacion.GuardarInflacion(inflac, Program.compa, this.aniotrabajo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message, "ERROR");
                }
                if (guardo)
                {
                    MessageBox.Show("LOS AJUSTES HAN SIDO GUARDADOS", "GUARDAR", MessageBoxButtons.OK);
                    this.CamposInactivos();
                    this.CamposVacios();
                }
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

        #region DATOS

        private void CargarCampos()
        {
            List<InflacionDataSource> inflac = new List<InflacionDataSource>();
            try
            {
                inflac = this.negocioInflacion.CargarDatos(Program.compa, this.aniotrabajo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message, "ERROR");
            }
            txtenero.Text = Convert.ToString(inflac[0].inflacion);
            txtfebrero.Text = Convert.ToString(inflac[1].inflacion);
            txtmarzo.Text = Convert.ToString(inflac[2].inflacion);
            txtabril.Text = Convert.ToString(inflac[3].inflacion);
            txtmayo.Text = Convert.ToString(inflac[4].inflacion);
            txtjunio.Text = Convert.ToString(inflac[5].inflacion);
            txtjulio.Text = Convert.ToString(inflac[6].inflacion);
            txtagosto.Text = Convert.ToString(inflac[7].inflacion);
            txtsepti.Text = Convert.ToString(inflac[8].inflacion);
            txtoctu.Text = Convert.ToString(inflac[9].inflacion);
            txtnov.Text = Convert.ToString(inflac[10].inflacion);
            txtdici.Text = Convert.ToString(inflac[11].inflacion);
            this.Sumar();
        }

        private void Sumar()
        {
            decimal acumulado = decimal.Parse(txtenero.Text) + decimal.Parse(txtfebrero.Text) + decimal.Parse(txtmarzo.Text) + decimal.Parse(txtabril.Text)
                + decimal.Parse(txtmayo.Text) + decimal.Parse(txtjunio.Text) + decimal.Parse(txtjulio.Text) + decimal.Parse(txtagosto.Text)
                + decimal.Parse(txtsepti.Text) + decimal.Parse(txtoctu.Text) + decimal.Parse(txtnov.Text) + decimal.Parse(txtdici.Text);
            txt_acumulado.Text = Convert.ToString(acumulado);
        }

        #endregion

        #region CERRAR FORMULARIO

        private void Frm_inflacion_FormClosing(object sender, FormClosingEventArgs e)
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

        private void ValidaDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
                this.Sumar();
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
            this.Sumar();
        }

        private bool ValidarCampos()
        {
            if (!txtenero.Text.Equals(string.Empty) && !txtfebrero.Text.Equals(string.Empty) && !txtmarzo.Text.Equals(string.Empty)
            && !txtmayo.Text.Equals(string.Empty) && !txtjunio.Text.Equals(string.Empty) && !txtjulio.Text.Equals(string.Empty)
            && !txtagosto.Text.Equals(string.Empty) && !txtsepti.Text.Equals(string.Empty) && !txtoctu.Text.Equals(string.Empty)
            && !txtnov.Text.Equals(string.Empty) && !txtdici.Text.Equals(string.Empty))
            {
                return true;
            }
            else
            {
                MessageBox.Show("POR FAVOR INGRESE TODOS LOS CAMPOS", "ERROR", MessageBoxButtons.OK);
                return false;
            }
        }

        #endregion
    }
}
