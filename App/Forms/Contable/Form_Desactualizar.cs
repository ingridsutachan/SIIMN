﻿////*********************************************************
//
//    <copyright file="Form_Desactualizar.cs" company="Marketing Software de Colombia LTDA">
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
    using Entities.Types;
    using Negocios.Contable;
    using Negocios.General;
    using System.Globalization;

    public partial class Form_Desactualizar : Form
    {
        public int tipodes;

        private bool usrClose;

        private Comprobantesn negocioComprobante;

        private asientosn negocioAsiento;

        private Parametrosn negocioParametros;

        private Funciones funtions;

        private bool existe;

        private int cantasi;

        public Form_Desactualizar(int tipo)
        {
            this.negocioComprobante = new Comprobantesn();
            this.negocioAsiento = new asientosn();
            this.negocioParametros = new Parametrosn();
            this.funtions =new Funciones();
            this.InitializeComponent();
            this.tipodes = tipo;
            this.ValidarTipo(tipodes);
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
                case Keys.Control | Keys.A:
                    if (btn_actualizar.Enabled == true)
                    {
                        this.Btn_actualizar_Click(sender, eve);
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

        private void ValidarTipo(int tipo)
        {
            if (tipo == 1)
            {
                panel_todos.Visible = true;
                this.CargarMeses();
            }
            if (tipo == 2)
            {
                pan_uno.Visible = true;
                this.CargarComprobantes();
            }
        }

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
            cbx_mes1.DataSource = meses;
            cbx_mes1.ValueMember = "NumeroMes";
            cbx_mes1.DisplayMember = "NombreMes";
            cbx_mes1.SelectedIndex = DateTime.Now.Month - 1;
            cbx_mes2.DataSource = meses2;
            cbx_mes2.ValueMember = "NumeroMes";
            cbx_mes2.DisplayMember = "NombreMes";
            cbx_mes2.SelectedIndex = DateTime.Now.Month - 1;
        }

        #endregion

        #region BOTONES

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            this.ValidarDesactualizar();
            if (existe)
            {
                btn_actualizar.Enabled = false;
                using (Form_ProgresBar fwait = new Form_ProgresBar())
                {
                    fwait.Title = "DESACTUALIZANDO ASIENTOS";
                    fwait.Message = "ESPERE MIENTRAS SE REALIZA EL PROCESO";
                    fwait.Picture = Properties.Resources.siimn;
                    fwait.ActionToExecute = DesactualizarAsiento;
                    if (fwait.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        MessageBox.Show(this.cantasi + "   ASIENTOS FUERON DESACTUALIZADOS ");
                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                    }
                    if (this.tipodes == 1)
                    {
                        cbx_mes1.SelectedIndex = 1;
                        cbx_mes2.SelectedIndex = DateTime.Now.Month;
                    }
                    else
                    {
                        cbx_comprobante.SelectedValue = 1;
                        txt_numeroasiento.Clear();
                    }

                    btn_actualizar.Enabled = true;
                }
            }
        }

        private void DesactualizarAsiento()
        {
            try
            {
                if (this.tipodes == 1)
                {
                    this.cantasi = this.negocioAsiento.DesactualizarTodosAsientos(int.Parse(cbx_mes1.SelectedValue.ToString()), int.Parse(cbx_mes2.SelectedValue.ToString()), Program.compa);
                }
                else
                {
                    string anio = this.negocioParametros.AnioTrabajo();
                    bool actualiza = this.negocioAsiento.DesactualizarUnAsiento(int.Parse(cbx_comprobante.SelectedValue.ToString()), txt_numeroasiento.Text, anio, Program.compa);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
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

        #region VALIDACIONES

        private void ValidarDesactualizar()
        {
            if (this.tipodes == 1)
            {
                existe = this.negocioAsiento.ExisteAsientoenFechaAct(int.Parse(cbx_mes1.SelectedValue.ToString()), int.Parse(cbx_mes2.SelectedValue.ToString()), Program.compa);
                if (!existe)
                {
                    MessageBox.Show("NO HAY ASIENTOS EN ESA FECHA PARA DESACTUALIZAR", "ERROR", MessageBoxButtons.OK);
                }
            }
            else
            {
                existe = this.negocioAsiento.ExisteAsiento(txt_numeroasiento.Text, int.Parse(cbx_comprobante.SelectedValue.ToString()), Program.compa);
                if (existe)
                {
                    existe = this.negocioAsiento.AsientoYaActualizado(txt_numeroasiento.Text, int.Parse(cbx_comprobante.SelectedValue.ToString()), Program.compa);
                    if (!existe)
                    {
                        MessageBox.Show("EL ASIENTO YA SE ENCUENTRA DESACTUALIZADO", "ERROR", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("EL ASIENTO NO EXISTE", "ERROR", MessageBoxButtons.OK);
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

        private void ValidarNumerico_KeyPress(object sender, KeyPressEventArgs e)
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

        #endregion

        #region EVENTOS FORMULARIO

        private void Form_Desactualizar_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
