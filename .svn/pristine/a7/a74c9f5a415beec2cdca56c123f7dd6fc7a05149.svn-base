////*********************************************************
//
//    <copyright file="Form_Pyg.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 20 Abril 2015
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
    using Negocios.General;
    using App.Forms.Contable.Reportes;

    public partial class Form_Pyg : Form
    {
        private int tipopyg;

        private string clasepyg;

        private asientosn negocioAsiento;

        private bool usrClose;

        private Parametrosn negocioParametro;

        private Cuentan negocioCuenta;

        public Form_Pyg(int tipo, string clase)
        {
            this.negocioAsiento = new asientosn();
            this.negocioParametro = new Parametrosn();
            this.negocioCuenta = new Cuentan();
            InitializeComponent();
            this.tipopyg = tipo;
            this.clasepyg = clase;
            this.CargarMeses();
            this.ValidarTipo();
        }

        public void SalirReporte(string tipo)
        {
            if (tipo.Equals("uno"))
            {
                this.HabilitarUno();
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
            }
            if (this.tipopyg == 1)
            {
                cbx_mesuno.DataSource = meses;
                cbx_mesuno.ValueMember = "NumeroMes";
                cbx_mesuno.DisplayMember = "NombreMes";
                cbx_mesuno.SelectedIndex = DateTime.Now.Month - 1;
            }
        }

        private void ValidarTipo()
        {
            if (this.tipopyg == 1)
            {
                pan_uno.Visible = true;

                this.Size = new Size(355, 317);
            }
            if (this.tipopyg == 2)
            {
                pan_dos.Visible = true;
                this.Size = new Size(298, 234);
            }

            if (this.tipopyg == 3)
            {
                pan_tres.Visible = true;
            }
        }

        private void DeshabilitarUno()
        {
            cbx_mesuno.Enabled = false;
            check_impcodig.Enabled = false;
            check_terceros.Enabled = false;
            cbx_nivel.Enabled = false;
            check_terceros.Enabled = false;
            radio_inflacion.Enabled = false;
            radio_sinajuste.Enabled = false;
            check_porcentual.Enabled = false;
            check_centro.Enabled = false;
            cbx_mesuno.SelectedIndex = DateTime.Now.Month - 1;
            check_impcodig.Checked = false;
            check_terceros.Checked = false;
            cbx_nivel.SelectedIndex = 1;
            radio_inflacion.Checked = true;
            radio_sinajuste.Checked = false;
            check_porcentual.Checked = false;
            check_centro.Checked = false;
            this.Enabled = false;
        }

        private void HabilitarUno()
        {
            cbx_mesuno.Enabled = true;
            check_impcodig.Enabled = true;
            check_terceros.Enabled = true;
            cbx_nivel.Enabled = true;
            check_terceros.Enabled = true;
            radio_inflacion.Enabled = true;
            radio_sinajuste.Enabled = true;
            check_porcentual.Enabled = true;
            check_centro.Enabled = true;
            this.Enabled = true;
            cbx_mesuno.Focus();
        }

        #endregion

        #region BOTONES

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            string anio;
            int mes;
            List<SaldosCuentasDataSource> balance = new List<SaldosCuentasDataSource>();
            try
            {
                anio = this.negocioParametro.AnioTrabajo();
                mes = this.negocioParametro.MesTrabajo();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            /*if (this.ValidarCampos())
            {
                if (this.tipopyg == 1)
                {
                  /*  try
                    {
                      /*  if (cbx_nivel.SelectedItem.Equals("MAYOR"))
                        {
                            balance = this.negocioAsiento.CargarInformePyg(int.Parse(cbx_mesuno.SelectedValue.ToString()), anio, Program.compa);
                        }
                        else
                        {
                            balance = this.negocioAsiento.CargarInformePyg(int.Parse(cbx_mesuno.SelectedValue.ToString()), anio, Program.compa);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR : " + ex.Message, "ERROR", MessageBoxButtons.OK);
                    }

                    //Form_ReportePyg frm = new Form_ReportePyg(this, "mayor", balance, dt_fecha.Value.ToShortDateString(), check_encab.Checked);
                    //frm.MdiParent = this.MdiParent;
                   // frm.Show();
                  //  this.DeshabilitarUno();
                }
            }*/
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ESTA SEGURO QUE DESEA CANCELAR?", "CANCELAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (this.tipopyg == 1)
                {
                    this.DeshabilitarUno();
                    this.HabilitarUno();
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
            string mensaje = string.Empty;
            bool dev = false;
            try
            {
                mensaje = this.negocioAsiento.TienenMovimientoMesMsj(int.Parse(cbx_mesuno.SelectedValue.ToString()), anio, Program.compa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRESENTO UN ERROR" + ex.Message, "ERROR", MessageBoxButtons.OK);
            }

            if (string.Empty.Equals(mensaje))
            {
                dev = true;
            }
            else
            {
                dev = false;
            }

            if (!string.Empty.Equals(mensaje))
            {
                switch (mensaje)
                {
                    case "actualizar":
                        MessageBox.Show("DEBE ACTUALIZAR LOS ASIENTOS", "ERROR", MessageBoxButtons.OK);
                        break;
                    case "noexiste":
                        MessageBox.Show("NO EXISTEN MOVIMIENTOS", "ERROR", MessageBoxButtons.OK);
                        break;
                    case "nocuentas":
                        MessageBox.Show("NO HAY CUENTAS REGISTRADAS EN EL SISTEMA", "ERROR", MessageBoxButtons.OK);
                        break;
                }
            }

            return dev;
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
   }
}
