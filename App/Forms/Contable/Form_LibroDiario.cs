﻿////*********************************************************
//
//    <copyright file="Form_LibroDiario.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 30 Marzo 2015
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
    using Negocios.Contable;
    using Entities.Types;
    using System.Globalization;
    using App.Forms.Contable.Reportes;
    using Negocios.General;

    public partial class Form_LibroDiario : Form
    {
        public int tipodi;

        private bool usrClose;

        private Funciones funtions;

        private Parametrosn negocioParametro;

        private asientosn negocioAsiento;

        public Form_LibroDiario(int tipo)
        {
            this.negocioAsiento = new asientosn();
            this.negocioParametro = new Parametrosn();
            this.funtions = new Funciones();
            this.InitializeComponent();
            this.tipodi = tipo;
            this.ValidarTipo(this.tipodi);
            this.CargarMeses();
        }

        private void ValidarTipo(int tipo)
        {
            if (tipo == 1)
            {
                pnl_detallado.Visible = true;
                this.Text = "LIBRO DIARIO DETALLADO";
            }
            if (tipo == 2)
            {
                pnl_resumido.Visible = true;
                this.Size = new Size(381, 203);
                this.Text = "LIBRO DIARIO RESUMIDO";
                progressbarAct.Location = new Point(19, 97);
                porcentaje.Location = new Point(294, 121);
            }
        }

        public void SalirReporte(int tipo)
        {
            this.tipodi = tipo;
            this.Enabled = true;
            if (this.tipodi == 1)
            {
                this.HabilitarDetallado();
            }
            else
            {
                this.HabilitarResumido();
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
            if (this.tipodi == 1)
            {
                cbx_mesdesde.DataSource = meses;
                cbx_mesdesde.ValueMember = "NumeroMes";
                cbx_mesdesde.DisplayMember = "NombreMes";
                cbx_mesdesde.SelectedIndex = 0;
                cbx_meshasta.DataSource = meses2;
                cbx_meshasta.ValueMember = "NumeroMes";
                cbx_meshasta.DisplayMember = "NombreMes";
                cbx_meshasta.SelectedIndex = DateTime.Now.Month - 1;
            }
            else if (this.tipodi == 2)
            {
                cbx_resumido.DataSource = meses;
                cbx_resumido.ValueMember = "NumeroMes";
                cbx_resumido.DisplayMember = "NombreMes";
                cbx_resumido.SelectedIndex = DateTime.Now.Month - 1;
            }
        }

        private void DeshabilitarDetallado()
        {
            cbx_mesdesde.Enabled = false;
            cbx_meshasta.Enabled = false;
            txt_compro.Enabled = false;
            txt_docin.Enabled = false;
            txt_docfin.Enabled = false;
            dtt_fecha.Enabled = false;
            check_encabe.Enabled = false;
            cbx_mesdesde.SelectedIndex = 0;
            cbx_meshasta.SelectedIndex = DateTime.Now.Month - 1;
            txt_compro.Clear();
            txt_docfin.Clear();
            txt_docin.Clear();
            dtt_fecha.Value = DateTime.Now;
            check_encabe.Checked = true;
        }

        private void HabilitarDetallado()
        {
            cbx_mesdesde.Enabled = true;
            cbx_meshasta.Enabled = true;
            txt_compro.Enabled = true;
            txt_docin.Enabled = true;
            txt_docfin.Enabled = true;
            dtt_fecha.Enabled = true;
            check_encabe.Enabled = true;
            cbx_mesdesde.Focus();
        }
        private void DeshabilitarResumido()
        {
            cbx_resumido.Enabled = false;
            dtt_fecha.Enabled = false;
            check_encabe.Enabled = false;
            cbx_resumido.SelectedIndex = DateTime.Now.Month - 1;
            dtt_fecha.Value = DateTime.Now;
            check_encabe.Checked = true;
        }

        private void HabilitarResumido()
        {
            cbx_resumido.Enabled = true;
            dtt_fecha.Enabled = true;
            check_encabe.Enabled = true;
            cbx_resumido.Focus();
        }

        #endregion

        #region BOTONES

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            List<AsientoDataSourceShow> asientolibrodiario = new List<AsientoDataSourceShow>();
            string aniotrabajo = this.negocioParametro.AnioTrabajo();
            if (this.ValidarCampos())
            {
                if (this.tipodi == 1)
                {
                    try
                    {
                        asientolibrodiario = this.negocioAsiento.CargarInformeLibroDiario(int.Parse(cbx_mesdesde.SelectedValue.ToString()), int.Parse(cbx_meshasta.SelectedValue.ToString()), aniotrabajo, txt_compro.Text, txt_docin.Text, txt_docfin.Text, Program.compa);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR : " + ex.Message, "ERROR", MessageBoxButtons.OK);
                    }
                    Form_ReporteAsiento frm = new Form_ReporteAsiento(this, "librodiario", asientolibrodiario, dtt_fecha.Value.ToShortDateString(), check_encabe.Checked);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    this.DeshabilitarDetallado();
                }
                else
                {
                    try
                    {
                        
                        asientolibrodiario = this.negocioAsiento.CargarInformeLibroResumido(int.Parse(cbx_resumido.SelectedValue.ToString()), aniotrabajo, Program.compa);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR : " + ex.Message, "ERROR", MessageBoxButtons.OK);
                    }
                    Form_ReporteAsiento frm = new Form_ReporteAsiento(this, "libroresumido", asientolibrodiario, dtt_fecha.Value.ToShortDateString(), check_encabe.Checked);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    this.DeshabilitarResumido();
                }
            }
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ESTA SEGURO QUE DESEA CANCELAR?", "CANCELAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (this.tipodi == 1)
                {
                    this.DeshabilitarDetallado();
                    this.HabilitarDetallado();
                }
                else if (this.tipodi == 2)
                {
                    this.DeshabilitarResumido();
                    this.HabilitarResumido();
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

        #region CERRAR FORMULARIO

        private void Frm_LibroDiario_FormClosing(object sender, FormClosingEventArgs e)
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
            string anio = this.negocioParametro.AnioTrabajo();
            if (this.tipodi == 1)
            {
                if (!string.Empty.Equals(txt_compro.Text) && !string.Empty.Equals(txt_docin.Text) && !string.Empty.Equals(txt_docfin))
                {
                    bool val = false;
                    List<AsientoDataSourceDevuelve> asientodev = new List<AsientoDataSourceDevuelve>();
                    try
                    {
                        asientodev = this.negocioAsiento.TienenMovimientoSinAnio(int.Parse(cbx_mesdesde.SelectedValue.ToString()), int.Parse(cbx_meshasta.SelectedValue.ToString()), anio, txt_compro.Text, txt_docin.Text, txt_docfin.Text, Program.compa);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR" + ex.Message, "ERROR", MessageBoxButtons.OK);
                    }
                    if (asientodev.Count() > 0)
                    {
                        val = this.negocioAsiento.TienenMovimientoSinAct(asientodev);
                        if (val)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("DEBE ACTUALIZAR LOS MOVIMIENTOS", "ERROR", MessageBoxButtons.OK);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("NO EXISTEN MOVIMIENTOS", "ERROR", MessageBoxButtons.OK);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("POR FAVOR INGRESE TODOS LOS CAMPOS", "ERROR", MessageBoxButtons.OK);
                    return false;
                }
            }
            else
            {
                bool val = false;
                List<AsientoDataSourceDevuelve> asiento = new List<AsientoDataSourceDevuelve>();
                try
                {
                    asiento = this.negocioAsiento.TienenMovimientoMes(int.Parse(cbx_resumido.SelectedValue.ToString()),anio, Program.compa);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SE PRESENTO UN ERROR" + ex.Message, "ERROR", MessageBoxButtons.OK);
                }

                if (asiento.Count() > 0)
                {
                    val = this.negocioAsiento.TienenMovimientoSinAct(asiento);
                    if (val)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("DEBE ACTUALIZAR LOS MOVIMIENTOS", "ERROR", MessageBoxButtons.OK);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("NO EXISTEN MOVIMIENTOS", "ERROR", MessageBoxButtons.OK);
                    return false;
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
