////*********************************************************
//
//    <copyright file="Form_Actualizar.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 27 de Marzo 2015
//    </copyright>
//
////*********************************************************
namespace App.Forms.Contable
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Windows.Forms;
    using Entities.Types;
    using Negocios.Contable;
    using Negocios.General;
    using System.Threading;

    public partial class Form_Actualizar : Form
    {
        private asientosn negocioAsiento;

        private Comprobantesn negocioComprobante;

        private int tipoact;

        private bool usrClose;

        private bool existe;

        private string anio;

        private Parametrosn negocioParametros;

        private Funciones funtions;

        private int cantasi;

        public Form_Actualizar(int tipo)
        {
            this.negocioAsiento = new asientosn();
            this.negocioParametros = new Parametrosn();
            this.negocioComprobante = new Comprobantesn();
            this.funtions = new Funciones();
            this.InitializeComponent();
            tipoact = tipo;
            this.ValidarTipo(tipoact);
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
            try
            {
                anio = this.negocioParametros.AnioTrabajo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRESENTO UN ERROR:  " + ex.Message, "ERROR", MessageBoxButtons.OK);
            }
            if (tipo == 1)
            {
                panel_acttodos.Visible = true;
                dt_desde.Focus();
            }
            if (tipo == 2)
            {
                panel_actuno.Visible = true;
                this.CargarComprobantes();
                cbx_comprobante.Focus();
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

        #endregion

        #region BOTONES

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            this.ValidarActualizar();
            if (existe)
            {
                btn_actualizar.Enabled = false;
                using (Form_ProgresBar fwait = new Form_ProgresBar())
                {
                    fwait.Title = "ACTUALIZANDO ASIENTOS";
                    fwait.Message = "ESPERE MIENTRAS SE REALIZA EL PROCESO";
                    fwait.Picture = Properties.Resources.siimn;
                    fwait.ActionToExecute = ActualizarAsiento;
                    if (fwait.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        MessageBox.Show(this.cantasi + "   ASIENTOS FUERON ACTUALIZADOS ");
                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                    }
                    if (this.tipoact == 1)
                    {
                        dt_desde.Value = DateTime.Today;
                        dt_hasta.Value = DateTime.Today;
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

        #region PROCESOS

        private void ActualizarAsiento()
        {
            try
            {
                if (this.tipoact == 1)
                {
                    this.cantasi = this.negocioAsiento.ActualizarTodosAsientos(dt_desde.Value, dt_hasta.Value, Program.compa, Program.iduser);
                }
                else
                {
                    this.cantasi = this.negocioAsiento.ActualizarUnAsiento(int.Parse(cbx_comprobante.SelectedValue.ToString()), txt_numeroasiento.Text, anio, Program.compa);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
            }
        }

        private void ValidarActualizar()
        {
            if (this.tipoact == 1)
            {
                if (dt_desde.Value.Year.ToString().Equals(this.anio) && dt_hasta.Value.Year.ToString().Equals(this.anio))
                {
                    string fecha = this.negocioAsiento.ExisteAsientoenFecha(dt_desde.Value, dt_hasta.Value, Program.compa);
                    if (!string.Empty.Equals(fecha))
                    {
                        if (fecha.Equals("noasientosact"))
                        {
                            this.existe = false;
                            MessageBox.Show("NO HAY ASIENTOS PARA ACTUALIZAR", "ERROR", MessageBoxButtons.OK);
                        }
                        else
                        {
                            this.existe = false;
                            MessageBox.Show("HAY UN ASIENTO YA ACTUALIZADO EN LA FECHA:" + fecha, "ERROR", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        this.existe = true;
                    }
                }
                else
                {
                    this.existe = false;
                    MessageBox.Show("DIGITE EL AÑO:" + anio, "ERROR", MessageBoxButtons.OK);
                }
            }
            else
            {
                existe = this.negocioAsiento.ExisteAsiento(txt_numeroasiento.Text, int.Parse(cbx_comprobante.SelectedValue.ToString()), Program.compa);
                if (existe)
                {
                    existe = this.negocioAsiento.AsientoYaActualizado(txt_numeroasiento.Text, int.Parse(cbx_comprobante.SelectedValue.ToString()), Program.compa);
                    if (existe)
                    {
                        MessageBox.Show("EL ASIENTO YA SE ENCUENTRA ACTUALIZADO", "ERROR", MessageBoxButtons.OK);
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

        private void Datetime_Leave(object sender, EventArgs e)
        {
            DateTimePicker date = (DateTimePicker)sender;
            if (!date.Value.Year.ToString().Equals(this.anio))
            {
                MessageBox.Show("DIGITE EL AÑO:" + anio, "ERROR", MessageBoxButtons.OK);
                date.Focus();
            }
        }

        #endregion
  
    }
}
