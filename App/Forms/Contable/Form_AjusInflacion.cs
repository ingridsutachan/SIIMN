////*********************************************************
//
//    <copyright file="Form_AjusInflacion.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 05 mayo 2015
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
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using Entities.Types;
    using Negocios.Contable;
    using System.Globalization;
    using Negocios.General;

    public partial class Form_AjusInflacion : Form
    {
        private Comprobantesn negocioComprobante;

        private Parametrosn negocioParametro;

        private inflacionn negocioInflacion;

        private asientosn negocioAsiento;

        private string aniotrabajo;

        private bool usrClose;

        private Funciones funtions;

        private bool existe;

        private bool Simsj;

        public Form_AjusInflacion()
        {
            this.negocioComprobante = new Comprobantesn();
            this.negocioParametro = new Parametrosn();
            this.negocioInflacion = new inflacionn();
            this.negocioAsiento = new asientosn();
            this.funtions = new Funciones();
            this.Simsj = false;
            this.InitializeComponent();
            this.CargarMeses();
            this.CargarComprobantes();
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
                    if (btn_generar.Enabled == true)
                    {
                        this.Btn_generar_Click(sender, eve);
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

        #region VISUAL

        private void CargarComprobantes()
        {
            List<ComprobantesDataSource> comprob = new List<ComprobantesDataSource>();
            try
            {
                comprob = this.negocioComprobante.CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
            }

            foreach (ComprobantesDataSource item in comprob)
            {
                item.Descricompro = Convert.ToString(item.Codigo) + "-" + item.Descricompro;
            }

            cbx_comprobante.DataSource = comprob;
            cbx_comprobante.ValueMember = "Codigo";
            cbx_comprobante.DisplayMember = "Descricompro";
        }

        private void CargarMeses()
        {
            List<MesesDataSource> meses = new List<MesesDataSource>();
            List<MesesDataSource> meses2 = new List<MesesDataSource>();
            string[] mes1 = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            for (int i = 0; i <= 11; i++)
            {
                MesesDataSource mes = new MesesDataSource();
                mes.NumeroMes = Convert.ToString(i + 1);
                mes.NombreMes = Convert.ToString(i + 1) + " - " + mes1[i].ToUpper();
                meses.Add(mes);
                meses2.Add(mes);
            }
            cbx_mes.DataSource = meses;
            cbx_mes.ValueMember = "NumeroMes";
            cbx_mes.DisplayMember = "NombreMes";
            cbx_mes.SelectedIndex = DateTime.Now.Month - 1;
        }


        private void VaciaryHabilitarCampos()
        {
            cbx_mes.SelectedIndex = DateTime.Now.Month - 1;
            lbl_fecha.Visible = false;
            txt_detalle.Clear();
            cbx_comprobante.SelectedIndex = 1;
            txt_numero.Clear();
            cbx_mes.Enabled = false;
            txt_detalle.Enabled = false;
            cbx_comprobante.Enabled = false;
            txt_numero.Enabled = false;
        }

        private void HabilitarCampos()
        {
            cbx_mes.Enabled = true;
            txt_detalle.Enabled = true;
            cbx_comprobante.Enabled = true;
            txt_numero.Enabled = true;
        }

        #endregion

        # region BOTONES

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                this.aniotrabajo = this.negocioParametro.AnioTrabajo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
            }

            this.HabilitarCampos();
            cbx_mes.Focus();
            btn_nuevo.Enabled = false;
            btn_generar.Enabled = true;
        }

        private void Btn_generar_Click(object sender, EventArgs e)
        {
            this.ValidarGenerar();
            if (existe)
            {
                btn_generar.Enabled = false;
                using (Form_ProgresBar fwait = new Form_ProgresBar())
                {
                    fwait.Title = "GENERAR AJUSTE DE INFLACIÓN";
                    fwait.Message = "ESPERE MIENTRAS SE REALIZA EL PROCESO";
                    fwait.Picture = Properties.Resources.siimn;
                    fwait.ActionToExecute = GenerarAsientoAjuste;
                    if (fwait.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        MessageBox.Show("ASIENTO GENERADO");
                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                    }
                }

                this.VaciaryHabilitarCampos();
            }
        }

        private void ValidarGenerar()
        {
            if (!string.Empty.Equals(txt_detalle.Text) && !string.Empty.Equals(txt_numero.Text))
            {
                try
                {
                    this.existe = this.negocioAsiento.ExisteAsiento(txt_numero.Text, int.Parse(cbx_comprobante.SelectedValue.ToString()), Program.compa);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
                }

                if (this.existe)
                {
                    MessageBox.Show("EL NUMERO DE ASIENTO YA EXISTE", "ERROR", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("DIGITE TODOS LOS DATOS", "ERROR", MessageBoxButtons.OK);
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

        #region EVENTOS FORMULARIO

        public void GenerarAsientoAjuste()
        {
        }

        private void Form_AjusInflacion_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Cbx_mes_Leave(object sender, EventArgs e)
        {
            lbl_fecha.Text = "01/" + cbx_mes.SelectedValue.ToString() + "/" + this.aniotrabajo;
            lbl_fecha.Visible = true;
            txt_detalle.Text = "PAAG   " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(int.Parse(cbx_mes.SelectedValue.ToString()));
            txt_detalle.Focus();
        }
        
        private void cbx_mes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lbl_fecha.Text = "01/" + cbx_mes.SelectedValue.ToString() + "/" + this.aniotrabajo;
            lbl_fecha.Visible = true;
            txt_detalle.Text = "PAAG   " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(int.Parse(cbx_mes.SelectedValue.ToString()));
            txt_detalle.Focus();
        }

        private void cbx_comprobante_Leave(object sender, EventArgs e)
        {
            if (this.Simsj == false)
            {
                try
                {
                    decimal tasa = this.negocioInflacion.ExisteInflacionMes(this.aniotrabajo, int.Parse(cbx_mes.SelectedValue.ToString()), Program.compa);
                    if (tasa != 0)
                    {
                        lbl_tasa.Text = lbl_tasa.Text + "  " + tasa.ToString();
                        txt_numero.Focus();
                    }
                    else
                    {
                        MessageBox.Show("NO SE DIGITO TASA PARA ESTE MES", "ERROR", MessageBoxButtons.OK);
                        this.Simsj = true;
                        cbx_mes.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
                }
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

        private void EnterTab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        #endregion

        private void cbx_comprobante_Enter(object sender, EventArgs e)
        {
            this.Simsj = false;
        }
    }
}
