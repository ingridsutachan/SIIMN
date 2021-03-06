﻿////*********************************************************
//
//    <copyright file="Form_LibroMayor.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 20 Abril 2015
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
    using Negocios.General;

    public partial class Form_LibroMayor : Form
    {
        private asientosn negocioAsiento;

        private bool usrClose;

        private Parametrosn negocioParametro;

        private Cuentan negocioCuenta;

        public Form_LibroMayor()
        {
            this.negocioAsiento = new asientosn();
            this.negocioParametro = new Parametrosn();
            this.negocioCuenta = new Cuentan();
            this.InitializeComponent();
            this.CargarMeses();
        }

        public void SalirReporte()
        {
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
            cbx_mes.DataSource = meses;
            cbx_mes.ValueMember = "NumeroMes";
            cbx_mes.DisplayMember = "NombreMes";
            cbx_mes.SelectedIndex = DateTime.Now.Month - 1;
        }

        private void Deshabilitar()
        {
            cbx_mes.Enabled = false;

            dt_fecha.Enabled = false;
            check_grupos.Enabled = false;
            check_encab.Enabled = false;
            cbx_mes.SelectedIndex = DateTime.Now.Month - 1;
            dt_fecha.Value = DateTime.Now;
            check_grupos.Checked = false;
            check_encab.Checked = true;
            this.Enabled = false;
        }

        private void Habilitar()
        {
            cbx_mes.Enabled = true;
            dt_fecha.Enabled = true;
            check_grupos.Enabled = true;
            check_encab.Enabled = true;
            this.Enabled = true;
            cbx_mes.Focus();
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

            if (this.ValidarCampos())
            {
                try
                {
                    if (check_grupos.Checked)
                    {
                        balance = this.negocioAsiento.CargarLibroMayorGrupo(int.Parse(cbx_mes.SelectedValue.ToString()), anio, Program.compa);
                    }
                    else
                    {
                        balance = this.negocioAsiento.CargarLibroMayor(int.Parse(cbx_mes.SelectedValue.ToString()), anio, Program.compa);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SE PRESENTO UN ERROR : " + ex.Message, "ERROR", MessageBoxButtons.OK);
                }

                Form_ReporteLibros frm = new Form_ReporteLibros(this, "mayor", balance, dt_fecha.Value.ToShortDateString(), check_encab.Checked);
                frm.MdiParent = this.MdiParent;
                frm.Show();
                this.Deshabilitar();
            }
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ESTA SEGURO QUE DESEA CANCELAR?", "CANCELAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Deshabilitar();
                this.Habilitar();
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
                mensaje = this.negocioAsiento.TienenMovimientoMesMsj(int.Parse(cbx_mes.SelectedValue.ToString()), anio, Program.compa);
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
