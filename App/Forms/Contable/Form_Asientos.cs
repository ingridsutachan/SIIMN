﻿////*********************************************************
//
//    <copyright file="Form_Asientos.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 24 de Marzo 2015
//    </copyright>
//
////*********************************************************
namespace App.Forms.Contable
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;
    using App.Forms.Contable.Reportes;
    using Entities.Types;
    using Negocios.Contable;
    using Negocios.General;

    public partial class Form_Asientos : Form
    {
        private Comprobantesn negocioComprobante;

        private Cuentan negocioCuenta;

        private Centron negocioCentro;

        private Nitsn negocioNit;

        private asientosn negocioAsiento;

        private Funciones funtions;

        private int rowclick;

        private bool usrClose;

        private Form_VisualContable frmguar;

        private Form_ReporteAsiento frmreporguar;

        private bool validasalida;

        private string estado;

        private Parametrosn negocioParametro;

        private bool busquedaF12;

        private bool clictabla;

        private string idasiento;

        private AsientoDataSourceFijo asientoedit;

        private bool editado;

        public Form_Asientos()
        {
            this.frmguar = new Form_VisualContable();
            this.frmreporguar = new Form_ReporteAsiento();
            this.asientoedit = new AsientoDataSourceFijo();
            this.negocioComprobante = new Comprobantesn();
            this.negocioCuenta = new Cuentan();
            this.negocioCentro = new Centron();
            this.negocioParametro = new Parametrosn();
            this.negocioNit = new Nitsn();
            this.negocioAsiento = new asientosn();
            this.funtions = new Funciones();
            this.InitializeComponent();
            this.validasalida = false;
            this.estado = "0";
            this.busquedaF12 = false;
            this.clictabla = false;
            this.idasiento = string.Empty;
            this.editado = false;
        }

        private void Form_Asientos_Load(object sender, EventArgs e)
        {
            this.CargarCombos();
            this.AutoCompletar();
        }

        #region METODOS PUBLICOS

        /// <summary>
        /// Habilita los botones 
        /// </summary>
        public void BotonesHabit()
        {
            btn_buscar.Enabled = true;
            btn_editar.Enabled = true;
            btn_eliminar.Enabled = true;
            btn_nuevo.Enabled = true;
            btn_imprimir.Enabled = true;
        }

        public void CargarCuenta(string cuenta)
        {
            this.SalidaForm();
            txt_cuenta.Text = cuenta;
            txt_cuenta.Focus();
        }

        public void SalirCuenta()
        {
            this.SalidaForm();
            txt_cuenta.Focus();
        }

        public void SalirCentro()
        {
            this.SalidaForm();
            txt_centro.Focus();
        }

        public void CargarCentro(string centro)
        {
            this.SalidaForm();
            txt_centro.Text = centro;
            txt_centro.Focus();
        }

        public void CargarNit(string nit)
        {
            this.SalidaForm();
            txt_nit.Text = nit;
            txt_nit.Focus();
        }

        public void SalirNit()
        {
            this.SalidaForm();
            txt_nit.Focus();
        }

        public void SalirAsientoFijo()
        {
            this.SalidaForm();
            txt_cuenta.Focus();
        }

        public void SalirAsiento()
        {
            this.SalidaForm();
            this.BotonesHabit();
            btn_cancelar.Enabled = false;
            menu_botones.Focus();
        }

       public void SalirReporteBorFij()
        {
            this.Enabled = true;
            this.BotonesHabit();
        }

        public void SalirReporteActual()
        {
            this.CamposInactivos();
            this.CamposVacios();
            this.Enabled = true;
            this.BotonesHabit();
        }

        public void CargarAsientoFijo(string valor)
        {
            this.SalidaForm();
            this.CamposVaciosAgregar();
            txt_detalle.Clear();
            txt_nit.Clear();
            txt_cuenta.Focus();
            List<AsientoDataSourceFijo> asientoFijo = new List<AsientoDataSourceFijo>();
            try
            {
                asientoFijo = this.negocioAsiento.CargarAsientoFijo(valor, Program.compa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRODUJO UN ERROR" + ex.Message, "ERROR", MessageBoxButtons.OK);
            }

            for (int i = 0; i < asientoFijo.Count(); i++)
            {
                string centro = asientoFijo[i].Idcentro != null ? Convert.ToString(asientoFijo[i].Idcentro) : string.Empty;
                string nit = asientoFijo[i].Nit != null ? asientoFijo[i].Nit : string.Empty;
                string referencia = asientoFijo[i].Cheque != null ? asientoFijo[i].Cheque : string.Empty;
                dgv_asientos.Rows.Add(asientoFijo[i].Cuenta, centro,
                   nit, referencia, asientoFijo[i].ValorDebito.ToString("0,0.00", CultureInfo.InvariantCulture), asientoFijo[i].ValorCredito.ToString("0,0.00", CultureInfo.InvariantCulture),
                   asientoFijo[i].Descripcion);
            }

            this.Totales();
            this.Totales();
            checked_asientofijo.Enabled = false;
        }

        public void CargarDatos(string comprobante, string documento)
        {
            this.validasalida = false;
            this.CamposActivos();
            this.BotonesInhabilitados();
            this.txt_anio.Focus();
            List<AsientoDataSourceDevuelve> asientoedit = new List<AsientoDataSourceDevuelve>();
            try
            {
                asientoedit = this.negocioAsiento.DevolverAsiento(documento, int.Parse(comprobante), Program.compa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRODUJO UN ERROR" + ex.Message, "ERROR", MessageBoxButtons.OK);
            }

            dgv_asientos.Enabled = false;
            this.idasiento = comprobante + documento;
            txt_numeroasiento.Text = asientoedit[0].Documento;
            this.CargarAsiento(asientoedit);
        }

        #endregion

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

                case Keys.Control | Keys.E:

                    if (btn_editar.Enabled == true)
                    {
                        this.btn_editar.ShowDropDown();
                        return true;
                    }

                    break;
                case Keys.Control | Keys.B:

                    if (btn_buscar.Enabled == true)
                    {
                        this.Btn_buscar_Click(sender, eve);
                        return true;
                    }

                    break;
                case Keys.Control | Keys.D:

                    if (btn_eliminar.Enabled == true)
                    {
                        this.btn_imprimir.ShowDropDown();
                        return true;
                    }

                    break;
                case Keys.Control | Keys.P:

                    if (btn_imprimir.Enabled == true)
                    {
                        this.btn_imprimir.ShowDropDown();
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
                case Keys.Control | Keys.Z:
                    if (btn_cancelar.Enabled == true)
                    {
                        this.Btn_cancelar_Click(sender, eve);
                        return true;
                    }

                    break;

                case Keys.Control | Keys.A:
                    if (btn_traerasiento.Enabled == true)
                    {
                        this.Btn_traerasiento_Click(sender, eve);
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

                case Keys.Control | Keys.T:
                    if (dgv_asientos.RowCount > 0)
                    {
                        this.clictabla = true;
                        dgv_asientos.Focus();
                    }

                    break;

                case Keys.F12:

                    this.busquedaF12 = true;

                    if (txt_cuenta.Focus())
                    {
                        this.validasalida = true;
                        this.Buscar("cuenta");
                        return true;
                    }
                    else if (txt_centro.Focus())
                    {
                        this.validasalida = true;
                        this.Buscar("centro");
                        return true;
                    }
                    else if (txt_nit.Focus())
                    {
                        this.validasalida = true;
                        this.Buscar("nit");
                        return true;
                    }

                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion

        #region VISUALIZACION

        /// <summary>
        /// Campos activos.
        /// </summary>
        private void CamposActivos()
        {
            txt_anio.Enabled = true;
            cbx_mes.Enabled = true;
            dtime_fecha.Enabled = true;
            cbx_comprobante.Enabled = true;
            txt_numeroasiento.Enabled = true;
            dgv_asientos.Enabled = true;
            txt_anio.Text = DateTime.Now.Year.ToString();
        }

        private void SalidaForm()
        {
            this.Enabled = true;
            this.validasalida = false;
            this.busquedaF12 = false;
            btn_cancelar.Enabled = true;
        }

        /// <summary>
        /// Campos activos.
        /// </summary>
        private void CamposActivosAsiento()
        {
            txt_detalle.Enabled = true;
            txt_cuenta.Enabled = true;
            txt_referencia.Enabled = true;
            txt_debito.Enabled = true;
            txt_credito.Enabled = true;
        }

        /// <summary>
        /// Campos inactivos.
        /// </summary>
        private void CamposInactivos()
        {
            txt_anio.Enabled = false;
            cbx_mes.Enabled = false;
            dtime_fecha.Enabled = false;
            cbx_comprobante.Enabled = false;
            txt_numeroasiento.Enabled = false;
            btn_guardar.Enabled = false;
            menu_botones.Focus();
            txt_detalle.Enabled = false;
            txt_centro.Enabled = false;
            txt_nit.Enabled = false;
            txt_referencia.Enabled = false;
            txt_credito.Enabled = false;
            txt_debito.Enabled = false;
            txt_cuenta.Enabled = false;
            checked_asientofijo.Enabled = false;
            dgv_asientos.Enabled = false;
            menu_botones.Focus();
        }

        private void CamposInactivosGeneral()
        {
            txt_anio.Enabled = false;
            cbx_mes.Enabled = false;
            dtime_fecha.Enabled = false;
            cbx_comprobante.Enabled = false;
            txt_numeroasiento.Enabled = false;
            checked_asientofijo.Enabled = false;
        }

        /// <summary>
        /// Campos vacios
        /// </summary>
        private void CamposVacios()
        {
            txt_anio.Clear();
            cbx_mes.SelectedIndex = DateTime.Now.Month;
            dtime_fecha.Value = DateTime.Today;
            cbx_comprobante.SelectedIndex = 0;
            txt_numeroasiento.Clear();
            txt_cuenta.Clear();
            txt_centro.Text = "0";
            txt_nit.Clear();
            txt_referencia.Clear();
            txt_detalle.Clear();
            txt_debito.Text = "00.00";
            txt_credito.Text = "00.00";
            txt_numeroasiento.Clear();
            checked_asientofijo.Checked = false;
            dgv_asientos.Rows.Clear();
            txt_detallefull.Clear();
            txt_totaldebito.Text = "00.00";
            txt_totalcredito.Text = "00.00";
            txt_descuadre.Text = "00.00";
        }

        private void CamposVaciosAgregar()
        {
            txt_detallefull.Clear();
            txt_cuenta.Clear();
            txt_centro.Clear();
            txt_referencia.Clear();
            txt_credito.Text = "00.00";
            txt_debito.Text = "00.00";
        }

        private void BotonesInhabilitados()
        {
            this.btn_editar.Enabled = false;
            this.btn_eliminar.Enabled = false;
            this.btn_imprimir.Enabled = false;
            this.btn_buscar.Enabled = false;
            this.btn_cancelar.Enabled = true;
            this.btn_nuevo.Enabled = false;
        }

        private void BotonesInhab()
        {
            btn_buscar.Enabled = false;
            btn_editar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_nuevo.Enabled = false;
            btn_cancelar.Enabled = false;
            btn_imprimir.Enabled = false;
        }

        private void CargarCombos()
        {
            List<ComprobantesDataSource> comprob = new List<ComprobantesDataSource>();
            List<MesesDataSource> meses = new List<MesesDataSource>();
            string[] mes1 = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            for (int i = 0; i <= 11; i++)
            {
                MesesDataSource mes = new MesesDataSource();
                mes.NumeroMes = Convert.ToString(i + 1);
                mes.NombreMes = mes1[i].ToUpper();
                meses.Add(mes);
            }

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
            cbx_mes.DataSource = meses;
            cbx_mes.ValueMember = "NumeroMes";
            cbx_mes.DisplayMember = "NombreMes";
            cbx_mes.SelectedIndex = DateTime.Now.Month - 1;
        }

        private void AutoCompletar()
        {
            List<CuentaDataSource> cuenta = new List<CuentaDataSource>();
            List<CentroDataSource> centro = new List<CentroDataSource>();
            List<NitsDataSource> nit = new List<NitsDataSource>();
            try
            {
                cuenta = this.negocioCuenta.CargarCuenta();
                centro = this.negocioCentro.CargarCentro();
                nit = this.negocioNit.CargarNits();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
            }

            AutoCompleteStringCollection nits = new AutoCompleteStringCollection();
            AutoCompleteStringCollection cuentas = new AutoCompleteStringCollection();
            AutoCompleteStringCollection centros = new AutoCompleteStringCollection();
            foreach (CuentaDataSource item in cuenta)
            {
                cuentas.Add(item.Cuenta);
            }

            txt_cuenta.AutoCompleteCustomSource = cuentas;

            foreach (CentroDataSource item in centro)
            {
                centros.Add(Convert.ToString(item.Codcentro));
            }

            txt_centro.AutoCompleteCustomSource = centros;

            foreach (NitsDataSource item in nit)
            {
                nits.Add(item.Nit);
            }

            txt_nit.AutoCompleteCustomSource = nits;
        }

        #endregion

        #region BOTONES CLICK

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            this.validasalida = false;
            this.CamposActivos();
            this.BotonesInhabilitados();
            this.txt_anio.Focus();
            txt_anio.ReadOnly = false;
        }

        private void Btn_editarfenumcomp_Click(object sender, EventArgs e)
        {
            Form_VisualContable frm = new Form_VisualContable("asiento", "editar", this);
            this.estado = "2";
            this.frmguar = frm;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Enabled = false;
            this.BotonesInhab();
        }

        private void Btn_eliminarasiento_Click(object sender, EventArgs e)
        {
            Form_VisualContable frm = new Form_VisualContable("asiento", "eliminar", this);
            this.frmguar = frm;
            frm.MdiParent = this.MdiParent;
            this.Enabled = false;
            frm.Show();
            this.BotonesInhab();
        }

        private void Btn_eliminarfijo_Click(object sender, EventArgs e)
        {
            Form_VisualContable frm = new Form_VisualContable("asientofijo", "eliminar", "0000", this);
            this.frmguar = frm;
            frm.MdiParent = this.MdiParent;
            this.Enabled = false;
            frm.Show();
            this.BotonesInhab();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            Form_VisualContable frm = new Form_VisualContable("asiento", "buscar", this);
            this.frmguar = frm;
            frm.MdiParent = this.MdiParent;
            this.Enabled = false;
            frm.Show();
            this.BotonesInhab();
        }

        private void Btn_imprasiact_Click(object sender, EventArgs e)
        {
            List<AsientoDataSource> asientos = new List<AsientoDataSource>();
            asientos = this.GuardarAsiento();
            if (!this.editado)
            {
                Form_ReporteAsiento frm = new Form_ReporteAsiento(this, "actual", asientos);
                this.frmreporguar = frm;
                frm.MdiParent = this.MdiParent;
                frm.Show();
                this.BotonesInhab();
                this.Enabled = false;
            }
            else
            {
                MessageBox.Show("DEBE GUARDAR EL ASIENTO", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void Btn_imprasiborrados_Click(object sender, EventArgs e)
        {
            Form_ReporteAsiento frm = new Form_ReporteAsiento(this, "borrados");
            this.frmreporguar = frm;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.BotonesInhab();
            this.Enabled = false;
        }

        private void Btn_imprasiefijos_Click(object sender, EventArgs e)
        {
            Form_ReporteAsiento frm = new Form_ReporteAsiento(this, "fijos");
            this.frmreporguar = frm;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.BotonesInhab();
            this.Enabled = false;
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (!this.ValidarGuardar())
            {
                List<AsientoDataSource> asientos = new List<AsientoDataSource>();
                asientos = this.GuardarAsiento();
                AsientoDevolverVal asientoguard = new AsientoDevolverVal();
                if (!"2".Equals(this.estado))
                {
                    try
                    {
                        asientoguard = this.negocioAsiento.GuardarAsiento(asientos, this.estado);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
                    }
                }
                else
                {
                    try
                    {
                        asientoguard.Guardo = this.negocioAsiento.ActualizarAsientoGeneral(asientos, this.idasiento, Program.compa);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
                    }
                }

                if (asientoguard.Guardo)
                {
                    if (!"2".Equals(this.estado))
                    {
                        MessageBox.Show("EL ASIENTO HA SIDO GUARDADO CON EL NUMERO : " + asientoguard.asientoguard, "GRABAR ASIENTO", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("EL ASIENTO FUE ACTUALIZADO", "GRABAR ASIENTO", MessageBoxButtons.OK);
                    }

                    this.CamposVacios();
                    this.CamposInactivos();
                    this.BotonesHabit();
                    btn_traerasiento.Enabled = false;
                    btn_cancelar.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("EL NUMERO DE DOCUMENTO YA EXISTE", "ERROR", MessageBoxButtons.OK);
                txt_numeroasiento.Enabled = true;
                txt_numeroasiento.Focus();
            }
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ESTA SEGURO QUE DESEA CANCELAR?", "CANCELAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.validasalida = true;
                this.CamposVacios();
                this.CamposInactivos();
                this.BotonesHabit();
                this.clictabla = false;
                btn_traerasiento.Enabled = false;
                this.btn_cancelar.Enabled = false;
                this.menu_botones.Focus();
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ESTA SEGURO QUE DESEA SALIR?", "SALIR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.usrClose = true;
                this.Close();
                this.frmguar.Close();
                this.frmreporguar.Close();
                this.validasalida = true;
            }
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            bool result = this.ValidarAgregar();
            if (result)
            {
                decimal credito = -1 * decimal.Parse(txt_credito.Text);
                string centro = !string.Empty.Equals(txt_centro.Text) ? txt_centro.Text : string.Empty;
                int? centroint = null;
                decimal debito = decimal.Parse(txt_debito.Text);
                if (!string.Empty.Equals(centro))
                {
                    centroint = int.Parse(centro);
                }

                string referencia = !string.Empty.Equals(txt_referencia.Text) ? txt_referencia.Text : string.Empty;
                string nit = !string.Empty.Equals(txt_nit.Text) ? txt_nit.Text : string.Empty;
                if (!this.clictabla)
                {
                    dgv_asientos.Rows.Add(txt_cuenta.Text, centro,
                   nit, referencia, txt_debito.Text, credito, txt_detalle.Text);
                }
                else
                {
                    if (!this.asientoedit.Cuenta.Equals(txt_cuenta.Text) || this.asientoedit.Idcentro != centroint || !nit.Equals(this.asientoedit.Nit)
                        || !referencia.Equals(this.asientoedit.Cheque) || debito != this.asientoedit.ValorDebito || credito != this.asientoedit.ValorCredito)
                    {
                        this.editado = true;
                    }

                    dgv_asientos.Rows[this.rowclick].Cells[0].Value = txt_cuenta.Text;
                    dgv_asientos.Rows[this.rowclick].Cells[1].Value = centro;
                    dgv_asientos.Rows[this.rowclick].Cells[2].Value = nit;
                    dgv_asientos.Rows[this.rowclick].Cells[3].Value = referencia;
                    dgv_asientos.Rows[this.rowclick].Cells[4].Value = txt_debito.Text;
                    dgv_asientos.Rows[this.rowclick].Cells[5].Value = credito;
                    dgv_asientos.Rows[this.rowclick].Cells[6].Value = txt_detalle.Text;
                    this.clictabla = false;
                }

                this.Totales();
                this.CamposVaciosAgregar();
                txt_cuenta.Focus();
            }
            else
            {
                MessageBox.Show("DEBE INGRESAR TODOS LOS CAMPOS", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void Btn_traerasiento_Click(object sender, EventArgs e)
        {
            Form_VisualContable frm = new Form_VisualContable("asientofijo", "buscar", cbx_comprobante.SelectedValue.ToString(), this);
            this.frmguar = frm;
            frm.MdiParent = this.MdiParent;
            this.Enabled = false;
            frm.Show();
            this.BotonesInhab();
        }

        #endregion

        #region GUARDAR DATOS

        private bool ValidarGuardar()
        {
            bool result = false;
            try
            {
                bool consec = this.negocioComprobante.EsConsecutivo(int.Parse(cbx_comprobante.SelectedValue.ToString()));
                if (!consec)
                {
                    if (this.estado.Equals("0") || this.estado.Equals("2"))
                    {
                        result = this.negocioAsiento.ExisteAsiento(txt_numeroasiento.Text, int.Parse(cbx_comprobante.SelectedValue.ToString()), Program.compa);
                    }
                    else
                    {
                        result = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
            }

            return result;
        }

        private List<AsientoDataSource> GuardarAsiento()
        {
            List<AsientoDataSource> asientos = new List<AsientoDataSource>();
            for (int i = 0; i < dgv_asientos.RowCount; i++)
            {
                AsientoDataSource asi = new AsientoDataSource();
                asi.Anio = txt_anio.Text;
                asi.Idmes = int.Parse(cbx_mes.SelectedValue.ToString());
                asi.Idcompania = Program.compa;
                asi.Fecha = dtime_fecha.Value;
                asi.Documento = txt_numeroasiento.Text;
                asi.IdModuloImprime = 7;
                asi.IdTipoDcto = null;
                asi.Codcompr = int.Parse(cbx_comprobante.SelectedValue.ToString());
                asi.Cuenta = dgv_asientos.Rows[i].Cells[0].Value.ToString();
                asi.Descripcion = dgv_asientos.Rows[i].Cells[6].Value.ToString();
                if (!string.Empty.Equals(dgv_asientos.Rows[i].Cells[1].Value.ToString()))
                {
                    asi.Idcentro = int.Parse(dgv_asientos.Rows[i].Cells[1].Value.ToString());
                }
                else
                {
                    asi.Idcentro = null;
                }

                if (!string.Empty.Equals(dgv_asientos.Rows[i].Cells[2].Value.ToString()))
                {
                    asi.IdNit = this.negocioNit.DevolverId(dgv_asientos.Rows[i].Cells[2].Value.ToString());
                }
                else
                {
                    asi.IdNit = null;
                }

                asi.Cheque = dgv_asientos.Rows[i].Cells[3].Value.ToString();
                asi.Valordebito = decimal.Parse(dgv_asientos.Rows[i].Cells[4].Value.ToString());
                asi.Valorcredito = decimal.Parse(dgv_asientos.Rows[i].Cells[5].Value.ToString());
                asi.Entrada = null;
                if (this.negocioCuenta.TieneRetencion(dgv_asientos.Rows[i].Cells[0].Value.ToString()))
                {
                    asi.BaseImpuesto = (asi.Valorcredito + asi.Valordebito) * -1;
                }
                else
                {
                    asi.BaseImpuesto = 0;
                }

                if (this.negocioCuenta.TieneReteIca(dgv_asientos.Rows[i].Cells[0].Value.ToString()))
                {
                    asi.ValorIca = asi.Valorcredito + asi.Valordebito;
                }
                else
                {
                    asi.ValorIca = 0;
                }

                asi.AsiFijo = checked_asientofijo.Checked;
                asi.Usuario = Program.iduser;
                asi.Fechagraba = DateTime.Now;
                string enlinea = this.negocioParametro.ActualizarEnLinea();
                if ("1".Equals(enlinea) && asi.AsiFijo == false)
                {
                    asi.Usuarioact = Program.iduser;
                    asi.Fechaactua = DateTime.Now;
                    asi.Actualizado = true;
                }
                else if ("0".Equals(enlinea) || asi.AsiFijo == true || ("1".Equals(enlinea) && asi.AsiFijo == true))
                {
                    asi.Usuarioact = null;
                    asi.Fechaactua = null;
                    asi.Actualizado = false;
                }

                asientos.Add(asi);
            }

            return asientos;
        }

        #endregion

        #region VALIDACIONES GENERAL ASIENTO

        private void Txt_anio_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (txt_anio.Text.Length != 4 || int.Parse(txt_anio.Text) < 1900 || int.Parse(txt_anio.Text) > 2100)
            {
                tb.Focus();
            }
            else
            {
                dtime_fecha.Value = Convert.ToDateTime("03/03/" + txt_anio.Text);
            }
        }

        private void Dtime_fecha_Leave(object sender, EventArgs e)
        {
            if (dtime_fecha.Value.Year != int.Parse(txt_anio.Text))
            {
                MessageBox.Show("EL AÑO DE LA FECHA ES DIFERENTE AL AÑO INGRESADO", "ERROR", MessageBoxButtons.OK);
                dtime_fecha.Focus();
            }

            if (dtime_fecha.Value.Month != int.Parse(cbx_mes.SelectedValue.ToString()))
            {
                MessageBox.Show("EL MES DE LA FECHA ES DIFERENTE AL MES INGRESADO", "ERROR", MessageBoxButtons.OK);
                dtime_fecha.Focus();
            }
        }

        private void Cbx_comprobante_SelectionChangeCommitted(object sender, EventArgs e)
        {
            bool consecutivo = false;
            try
            {
                consecutivo = this.negocioComprobante.EsConsecutivo(int.Parse(cbx_comprobante.SelectedValue.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
            }

            if (consecutivo)
            {
                txt_numeroasiento.Text = this.negocioAsiento.DevolverConsecutivo(int.Parse(cbx_comprobante.SelectedValue.ToString()), Program.compa);
            }
            else
            {
                txt_numeroasiento.Text = string.Empty;
            }
        }

        private void Cbx_comprobante_Leave(object sender, EventArgs e)
        {
            this.Cbx_comprobante_SelectionChangeCommitted(sender, e);
        }

        private void Txt_numeroasiento_Leave(object sender, EventArgs e)
        {
            if (!string.Empty.Equals(txt_numeroasiento.Text))
            {
                bool existe = false;
                try
                {
                    existe = this.negocioAsiento.ExisteAsiento(txt_numeroasiento.Text, int.Parse(cbx_comprobante.SelectedValue.ToString()), Program.compa);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
                }

                if (existe)
                {
                    List<AsientoDataSourceDevuelve> asiento = new List<AsientoDataSourceDevuelve>();
                    try
                    {
                        asiento = this.negocioAsiento.DevolverAsiento(txt_numeroasiento.Text, int.Parse(cbx_comprobante.SelectedValue.ToString()), Program.compa);
                        if (asiento[0].Actualizado)
                        {
                            string actlinea = this.negocioParametro.ActualizarEnLinea();
                            if ("1".Equals(actlinea))
                            {
                                if (dgv_asientos.RowCount == 0)
                                {
                                    this.estado = "1";
                                    this.CargarAsiento(asiento);
                                    this.CamposActivosAsiento();
                                    txt_cuenta.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("EL ASIENTO YA SE ENCUENTRA ACTUALIZADO", "ERROR", MessageBoxButtons.OK);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
                    }

                    checked_asientofijo.Enabled = false;
                    this.CamposInactivosGeneral();
                    txt_detalle.Enabled = true;
                }
                else
                {
                    this.estado = "0";
                    checked_asientofijo.Enabled = true;
                    this.CamposActivosAsiento();
                    checked_asientofijo.Focus();
                }

                cbx_comprobante.Enabled = false;
                txt_numeroasiento.Enabled = false;
            }
            else
            {
                if (!this.validasalida)
                {
                    txt_numeroasiento.Focus();
                }
            }
        }

        private void Cbx_comprobante_Enter(object sender, EventArgs e)
        {
            txt_anio.Enabled = false;
            cbx_mes.Enabled = false;
            dtime_fecha.Enabled = false;
            if (!this.validasalida)
            {
                dtime_fecha.Value = Convert.ToDateTime("01/" + cbx_mes.SelectedValue.ToString() + "/" + txt_anio.Text);
            }
        }

        private void Txt_numeroasiento_Enter(object sender, EventArgs e)
        {
            txt_anio.Enabled = false;
            cbx_mes.Enabled = false;
            dtime_fecha.Enabled = false;
            checked_asientofijo.Enabled = false;
            if (!this.validasalida)
            {
                dtime_fecha.Value = Convert.ToDateTime("01/" + cbx_mes.SelectedValue.ToString() + "/" + txt_anio.Text);
            }
        }

        private void Cbx_mes_Leave(object sender, EventArgs e)
        {
            dtime_fecha.Value = Convert.ToDateTime("01/" + cbx_mes.SelectedValue.ToString() + "/" + txt_anio.Text);
        }

        private void Txt_cuenta_KeyUp(object sender, KeyEventArgs e)
        {
            int tamanio = txt_cuenta.Text.Length;
            if (!txt_cuenta.Text.Equals(string.Empty) && (tamanio != 3 && tamanio != 5 && tamanio != 7 && tamanio != 11))
            {
                try
                {
                    txt_detallefull.Text = "CTA:  " + this.negocioCuenta.DevolverNombre(txt_cuenta.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
                }
            }
            else
            {
                txt_detallefull.Text = string.Empty;
            }
        }

        #endregion

        #region VALIDACIONES CAMPOS TAB

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

        private void EnterTab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void Decimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
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

        private void TxtAutocomplet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && this.validasalida == false)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private decimal QuitarPuntos(string valor)
        {
            if (valor.Contains("."))
            {
                valor = valor.Replace(".", ",");
            }

            decimal numero = default(decimal);
            bool bln = decimal.TryParse(valor, out numero);
            return numero;
        }

        #endregion

        #region VALIDACIONES ASIENTO DETALLE

        private void Txt_detalle_Enter(object sender, EventArgs e)
        {
            if (string.Empty.Equals(txt_cuenta.Text))
            {
                txt_cuenta.Focus();
            }
        }

        private void Txt_cuenta_Leave(object sender, EventArgs e)
        {
            if (!string.Empty.Equals(txt_cuenta.Text) && this.validasalida == false)
            {
                string mensaje = this.funtions.ValidarOtraCuenta(txt_cuenta.Text);

                if (!string.Empty.Equals(mensaje))
                {
                    if ("CUENTA NO EXISTENTE".Equals(mensaje))
                    {
                        DialogResult agregar = MessageBox.Show("CUENTA NO EXISTENTE, DESEA CREARLA?", "ERROR", MessageBoxButtons.YesNo);
                        if (agregar == DialogResult.Yes)
                        {
                            this.validasalida = true;
                            this.BotonesInhab();
                            btn_guardar.Enabled = false;
                            Form_Cuenta frm = new Form_Cuenta("asiento", txt_cuenta.Text, this);
                            this.Enabled = false;
                            frm.MdiParent = this.MdiParent;
                            frm.Show();
                        }
                        else
                        {
                            txt_cuenta.Focus();
                            this.validasalida = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK);
                        txt_cuenta.Focus();
                    }
                }
                else
                {
                    this.DetalleCuenta();
                }
            }
            else
            {
                if (this.clictabla == false)
                {
                    txt_cuenta.Focus();
                }
            }
        }

        private void Txt_cuenta_Enter(object sender, EventArgs e)
        {
            if (!this.estado.Equals("1"))
            {
                btn_traerasiento.Enabled = true;
            }

            txt_centro.Enabled = false;
            txt_nit.Enabled = false;
            checked_asientofijo.Enabled = false;
        }

        private void Txt_centro_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (!string.Empty.Equals(tb.Text) && this.validasalida == false)
            {
                bool result = false;
                try
                {
                    result = this.negocioCentro.ExisteCentro(int.Parse(txt_centro.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
                }

                if (!result && this.busquedaF12 == false)
                {
                    this.validasalida = true;
                    DialogResult agregar = MessageBox.Show("EL CENTRO NO EXISTE, DESEA CREARLO?", "NO EXISTE", MessageBoxButtons.YesNo);
                    if (agregar == DialogResult.Yes)
                    {
                        this.BotonesInhab();
                        btn_guardar.Enabled = false;
                        this.Enabled = false;
                        Frmcentro frmcen = new Frmcentro("asiento", txt_centro.Text, this);
                        frmcen.MdiParent = this.MdiParent;
                        frmcen.Show();
                    }
                    else
                    {
                        txt_centro.Focus();
                        this.validasalida = false;
                    }
                }

                if (this.busquedaF12)
                {
                    txt_centro.Focus();
                }
            }
            else
            {
                tb.Focus();
            }
        }

        private void Txt_centro_KeyUp(object sender, KeyEventArgs e)
        {
            string[] str = txt_detallefull.Text.Split('\n');
            txt_detallefull.Text = string.Empty;
            if (!string.Empty.Equals(txt_centro.Text))
            {
                try
                {
                    txt_detallefull.Text = str[0] + Environment.NewLine + "CENTRO:" + this.negocioCentro.DevolverNombre(int.Parse(txt_centro.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
                }
            }
            else
            {
                txt_detallefull.Text = str[0] + Environment.NewLine + string.Empty;
            }
        }

        private void Txt_nit_Leave(object sender, EventArgs e)
        {
            string[] str = txt_detallefull.Text.Split('\n');
            int cantidad = str.Count();
            txt_detallefull.Text = string.Empty;
            if (!string.Empty.Equals(txt_nit.Text) && this.validasalida == false)
            {
                bool result = false;
                try
                {
                    result = this.negocioNit.ExisteNit(txt_nit.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
                }

                if (result)
                {
                    try
                    {
                        if (cantidad == 2)
                        {
                            txt_detallefull.Text = str[0] + Environment.NewLine + str[1] + Environment.NewLine + "NIT : " + this.negocioNit.DevolverNombre(txt_nit.Text);
                        }
                        else
                        {
                            txt_detallefull.Text = str[0] + Environment.NewLine + "NIT : " + this.negocioNit.DevolverNombre(txt_nit.Text);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
                    }
                }
                else if (result && this.busquedaF12 == false)
                {
                    this.validasalida = true;
                    txt_detallefull.Text = str[0] + Environment.NewLine + str[1] + Environment.NewLine + string.Empty;
                    DialogResult agregar = MessageBox.Show("EL NIT NO EXISTE, DESEA CREARLO?", "NO EXISTE", MessageBoxButtons.YesNo);
                    if (agregar == DialogResult.Yes)
                    {
                        this.BotonesInhab();
                        btn_guardar.Enabled = false;
                        this.Enabled = false;
                        Frmnits frmnit = new Frmnits("asiento", txt_nit.Text, this);
                        frmnit.MdiParent = this.MdiParent;
                        frmnit.Show();
                    }
                    else
                    {
                        txt_nit.Focus();
                        this.validasalida = false;
                    }
                }

                if (this.busquedaF12)
                {
                    txt_nit.Focus();
                }
            }
            else
            {
                txt_nit.Focus();
                txt_detallefull.Text = str[0] + Environment.NewLine + str[1] + Environment.NewLine + string.Empty;
            }
        }

        private void Txt_debito_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            this.LeaveDecimales(tb);
            if (!txt_debito.Text.Equals("00,00") && !txt_debito.Text.Equals(string.Empty))
            {
                decimal numero = default(decimal);
                numero = 0;
                txt_credito.Text = string.Format("{0:00.00}", numero);
            }
        }

        private void Txt_credito_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            this.LeaveDecimales(tb);
            if (!txt_credito.Text.Equals("00,00") && !txt_credito.Text.Equals(string.Empty))
            {
                decimal numero = default(decimal);
                numero = 0;
                txt_debito.Text = string.Format("{0:00.00}", numero);
            }

            btn_agregar.Enabled = true;
            btn_agregar.Focus();
        }

        private void Txt_detalle_Leave(object sender, EventArgs e)
        {
            if (string.Empty.Equals(txt_detalle.Text) && this.validasalida == false)
            {
                txt_detalle.Focus();
            }
        }

        private void Txt_descuadre_TextChanged(object sender, EventArgs e)
        {
            if (txt_descuadre.Text.Equals("00,00"))
            {
                btn_guardar.Enabled = true;
                btn_imprasiact.Enabled = true;
                btn_imprimir.Enabled = true;
                btn_imprasiborrados.Enabled = false;
                btn_imprasiefijos.Enabled = false;
            }
            else
            {
                btn_guardar.Enabled = false;
                btn_imprasiact.Enabled = false;
                btn_imprimir.Enabled = false;
                btn_imprasiborrados.Enabled = true;
                btn_imprasiefijos.Enabled = true;
            }
        }

        # endregion

        #region VALIDACIONES DATAGRIDVIEW

        private void Dgv_asientos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_asientos.RowCount > 0)
            {
                this.EditarFila();
            }
        }

        private void Dgv_asientos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                if (dgv_asientos.RowCount > 0)
                {
                    this.EditarFila();
                }
            }
        }

        private void Dgv_asientos_Enter(object sender, EventArgs e)
        {
            this.clictabla = false;
        }
        #endregion

        #region DATOS
        private void CargarAsiento(List<AsientoDataSourceDevuelve> asiento)
        {
            txt_anio.Text = Convert.ToString(asiento[0].Anio);
            cbx_mes.SelectedIndex = asiento[0].Mes;
            dtime_fecha.Value = asiento[0].Fecha;
            txt_detalle.Text = asiento[0].Descripcion;
            for (int i = 0; i < asiento.Count(); i++)
            {
                string centro = asiento[i].Idcentro != null ? Convert.ToString(asiento[i].Idcentro) : string.Empty;
                string nit = asiento[i].Nit != null ? asiento[i].Nit : string.Empty;
                string referencia = asiento[i].Cheque != null ? asiento[i].Cheque : string.Empty;
                string debito = string.Format("{0:00.00}", asiento[i].Valordebito.ToString());
                string credito = string.Format("{0:00.00}", asiento[i].Valorcredito.ToString());
                dgv_asientos.Rows.Add(asiento[i].Cuenta, centro, nit, referencia, debito, credito, asiento[i].Descripcion);
            }

            this.Totales();
        }

        private bool ValidarAgregar()
        {
            if (!string.Empty.Equals(txt_cuenta.Text) && !string.Empty.Equals(txt_detalle.Text) && !string.Empty.Equals(txt_debito.Text)
                && !string.Empty.Equals(txt_credito.Text))
            {
                if (txt_centro.Enabled == true && txt_centro.Text.Equals(string.Empty))
                {
                    return false;
                }
                else if (txt_nit.Enabled == true && txt_nit.Text.Equals(string.Empty))
                {
                    return false;
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        private void DetalleCuenta()
        {
            CuentaDataSource cuentadev = new CuentaDataSource();
            try
            {
                cuentadev = this.negocioCuenta.DevolverDatos(txt_cuenta.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRESENTO UN ERROR." + ex.Message, "ERROR");
            }

            txt_centro.Enabled = cuentadev.Centro;
            txt_nit.Enabled = cuentadev.Pidenit;
            txt_nit.Text = cuentadev.Pidenit == false ? string.Empty : txt_nit.Text;
        }

        private void LeaveDecimales(TextBox tb)
        {
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
        }

        private void Totales()
        {
            decimal debito = 0;
            for (int i = 0; i < dgv_asientos.RowCount; i++)
            {
                debito = debito + this.QuitarPuntos(dgv_asientos.Rows[i].Cells[4].Value.ToString());
            }

            decimal credito = 0;
            for (int i = 0; i < dgv_asientos.RowCount; i++)
            {
                credito = credito + this.QuitarPuntos(dgv_asientos.Rows[i].Cells[5].Value.ToString());
            }

            txt_totaldebito.Text = string.Format("{0:00.00}", debito);
            txt_totalcredito.Text = string.Format("{0:00.00}", credito);
            decimal descuadre = debito + credito;
            txt_descuadre.Text = string.Format("{0:00.00}", descuadre);
        }

        private void EditarFila()
        {
            this.rowclick = dgv_asientos.CurrentCell.RowIndex;
            this.editado = false;
            txt_cuenta.Text = dgv_asientos.Rows[this.rowclick].Cells[0].Value.ToString();
            txt_centro.Text = dgv_asientos.Rows[this.rowclick].Cells[1].Value != null ? dgv_asientos.Rows[this.rowclick].Cells[1].Value.ToString() : string.Empty;
            txt_nit.Text = dgv_asientos.Rows[this.rowclick].Cells[2].Value != null ? dgv_asientos.Rows[this.rowclick].Cells[2].Value.ToString() : string.Empty;
            txt_referencia.Text = dgv_asientos.Rows[this.rowclick].Cells[3].Value != null ? dgv_asientos.Rows[this.rowclick].Cells[3].Value.ToString() : string.Empty;
            txt_debito.Text = dgv_asientos.Rows[this.rowclick].Cells[4].Value.ToString();
            txt_credito.Text = Convert.ToString(-1 * decimal.Parse(dgv_asientos.Rows[this.rowclick].Cells[5].Value.ToString()));
            txt_detalle.Text = dgv_asientos.Rows[this.rowclick].Cells[6].Value.ToString();
            this.asientoedit.Cuenta = txt_cuenta.Text;
            if (!string.Empty.Equals(txt_centro.Text))
            {
                this.asientoedit.Idcentro = int.Parse(txt_centro.Text);
            }
            else
            {
                this.asientoedit.Idcentro = null;
            }

            this.asientoedit.Nit = txt_nit.Text;
            this.asientoedit.Cheque = txt_referencia.Text;
            this.asientoedit.Descripcion = txt_detalle.Text;
            this.asientoedit.ValorDebito = decimal.Parse(txt_debito.Text);
            this.asientoedit.ValorCredito = decimal.Parse(txt_credito.Text);
            txt_cuenta.Focus();
            this.clictabla = true;
        }

        #endregion

        # region BUSQUEDAS
        private void Buscar(string busqueda)
        {
            if ("cuenta".Equals(busqueda))
            {
                Form_VisualContable frm = new Form_VisualContable("cuentaasiento", "buscar", this);
                this.frmguar = frm;
                frm.MdiParent = this.MdiParent;
                frm.Show();
                this.BotonesInhab();
                this.Enabled = false;
                this.validasalida = true;
            }
            else if ("centro".Equals(busqueda))
            {
                Form_VisualContable frm = new Form_VisualContable("centroasiento", "buscar", this);
                this.frmguar = frm;
                frm.MdiParent = this.MdiParent;
                frm.Show();
                this.BotonesInhab();
                this.Enabled = false;
                this.validasalida = true;
            }
            else if ("nit".Equals(busqueda))
            {
                Form_VisualContable frm = new Form_VisualContable("nitasiento", "buscar", this);
                this.frmguar = frm;
                frm.MdiParent = this.MdiParent;
                frm.Show();
                this.BotonesInhab();
                this.Enabled = false;
                this.validasalida = true;
            }
        }

        #endregion

        #region METODOS FORMULARIO

        private void Form_Asientos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.usrClose)
            {
                DialogResult result = MessageBox.Show("ESTA SEGURO QUE DESEA SALIR?", "SALIR", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                    this.validasalida = true;
                }
                else
                {
                    this.frmguar.Close();
                    this.frmreporguar.Close();
                }
            }
        }

        #endregion
  
    }
}