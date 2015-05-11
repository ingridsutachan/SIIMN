////*********************************************************
//
//    <copyright file="Form_CierreCuentas.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 27 de Abril 2015
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
    using Negocios.General;

    public partial class Form_CierreCuentas : Form
    {
        private bool usrClose;

        private int tipo;

        private bool existe;

        private asientosn negocioAsiento;

        private Parametrosn negocioParametro;

        private string anio;

        public Form_CierreCuentas(int tipoc)
        {
            this.negocioAsiento = new asientosn();
            this.negocioParametro = new Parametrosn();
            this.InitializeComponent();
            this.tipo = tipoc;
            this.titulo();
            btn_no.Focus();
        }

        private void titulo()
        {
            try
            {
                this.anio = this.negocioParametro.AnioTrabajo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
            }
            if (this.tipo == 1)
            {
                this.Text = "CIERRE CUENTAS DE RESULTADO";
                int codcomp = this.negocioParametro.ComprobanteCierre();
                bool asientocier = this.negocioAsiento.ExisteAsiento("CIER12", codcomp, Program.compa);
                if (!asientocier)
                {
                    this.existe = true;
                }
                else
                {
                    this.existe = false;
                    MessageBox.Show("YA SE REALIZO CIERRE DE CUENTAS DE RESULTADO", "ERROR", MessageBoxButtons.OK);
                }
            }
            else
            {
                this.Text = "CIERRE CUENTAS DE IMPUESTOS";
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

        #region BOTONES

        private void Btn_Generar_Click(object sender, EventArgs e)
        {
            this.ValidarGenerar();
            if (existe)
            {
                this.Enabled = false;
                using (Form_ProgresBar fwait = new Form_ProgresBar())
                {
                    fwait.Title = "GENERANDO CIERRE DE CUENTAS";
                    fwait.Message = "ESPERE MIENTRAS SE REALIZA EL PROCESO";
                    fwait.Picture = Properties.Resources.siimn;
                    fwait.ActionToExecute = GenerarCierreCuentasEstado;
                    if (fwait.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        MessageBox.Show("   FUE GENERADO EL ASIENTO ");
                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                    }
                }
            }
        }

        #endregion

        #region PROCESOS

        private void GenerarCierreCuentasEstado()
        {
            try
            {
                if (this.tipo == 1)
                {
                    this.negocioAsiento.GenerarAsientoCierreEstado(this.anio, Program.compa, Program.iduser);
                }
                else
                {
                    this.negocioAsiento.GenerarAsientoCierreImpuestos(this.anio, Program.compa, Program.iduser);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
            }
        }

        private void ValidarGenerar()
        {
            try
            {
                string anio = this.negocioParametro.AnioTrabajo();
                string fecha = this.negocioAsiento.TodosAsientosActoNo(anio, Program.compa, false);
                if (string.Empty.Equals(fecha))
                {
                    this.existe = true;
                }
                else
                {
                    this.existe = false;
                    MessageBox.Show("HAY ASIENTOS POR ACTUALIZAR EN LA FECHA: " + fecha, "ERROR", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRODUJO UN ERROR" + ex.Message, "ERROR", MessageBoxButtons.OK);
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

        private void Form_Actualizar_FormClosing(object sender, FormClosingEventArgs e)
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
