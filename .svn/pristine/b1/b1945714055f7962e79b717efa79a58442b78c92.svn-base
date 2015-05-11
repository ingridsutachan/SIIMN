////*********************************************************
//
//    <copyright file="Form_VisualContable.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 11 febrero 2015
//    </copyright>
//
////*********************************************************

namespace App.Forms.Contable
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using Entities.Types;
    using Negocios.Contable;

    public partial class Form_VisualContable : Form
    {
        private Cuentan negocioCuenta;

        private Presupueston negocioPresupuesto;

        private Nitsn negocioNits;

        private string busqueda;

        private string menub;

        private string tipof;

        private string comprobanasi;

        private Form_Cuenta formcuenta;

        private Frmpresupuesto frmpresupuesto;

        private Frmnits frmnits;

        private Comprobantesn negocioComprobante;

        private Frmcomprobantes frmcomprobantes;

        private Frmcentro frmcentro;

        private Centron negocioCentro;

        private Form_Formatos formFormatos;

        private Formatosn negocioFormato;

        private FrmTributario frmTributario;

        private tributariosn negocioTributario;

        private Form_Asientos formAsientos;

        private asientosn negocioAsiento;

        public Form_VisualContable(string buscar, string menu, Form_Cuenta formcuenta)
        {
            this.negocioCuenta = new Cuentan();
            this.InitializeComponent();
            this.busqueda = buscar;
            this.menub = menu;
            this.formcuenta = formcuenta;
            this.Visual();
        }

        public Form_VisualContable(string buscar, string menu, Frmpresupuesto frmpresupuesto)
        {
            // TODO: Complete member initialization
            this.negocioPresupuesto = new Presupueston();
            this.InitializeComponent();
            this.busqueda = buscar;
            this.menub = menu;
            this.frmpresupuesto = frmpresupuesto;
            this.Visual();
        }

        public Form_VisualContable()
        {
            // TODO: Complete member initialization
        }

        public Form_VisualContable(string buscar, string menu, Frmnits frmnits)
        {
            this.negocioNits = new Nitsn();
            this.busqueda = buscar;
            this.menub = menu;
            this.frmnits = frmnits;
            this.InitializeComponent();
            this.Visual();
        }

        public Form_VisualContable(string buscar, string menu, Frmcomprobantes frmcomprobantes)
        {
            this.negocioComprobante = new Comprobantesn();
            this.busqueda = buscar;
            this.menub = menu;
            this.frmcomprobantes = frmcomprobantes;
            this.InitializeComponent();
            this.Visual();
        }

        public Form_VisualContable(string buscar, string menu, Frmcentro frmcentro)
        {
            this.negocioCentro = new Centron();
            this.busqueda = buscar;
            this.menub = menu;
            this.frmcentro = frmcentro;
            this.InitializeComponent();
            this.Visual();
        }

        public Form_VisualContable(string buscar, string menu, string tipo, Form_Formatos form_Formatos)
        {
            this.negocioFormato = new Formatosn();
            this.busqueda = buscar;
            this.menub = menu;
            this.tipof = tipo;
            this.formFormatos = form_Formatos;
            this.InitializeComponent();
            this.Visual();
        }

        public Form_VisualContable(string buscar, string menu, FrmTributario frmTributario)
        {
            this.negocioTributario = new tributariosn();
            this.busqueda = buscar;
            this.menub = menu;
            this.frmTributario = frmTributario;
            this.InitializeComponent();
            this.Visual();
        }

        public Form_VisualContable(string buscar, string menu, Form_Asientos form_Asientos)
        {
            this.negocioCuenta = new Cuentan();
            this.negocioCentro = new Centron();
            this.negocioNits = new Nitsn();
            this.negocioAsiento = new asientosn();
            this.InitializeComponent();
            this.busqueda = buscar;
            this.menub = menu;
            this.Visual();
            this.formAsientos = form_Asientos;
        }

        public Form_VisualContable(string buscar, string menu, string comprobante, Form_Asientos form_Asientos)
        {
            this.negocioCuenta = new Cuentan();
            this.negocioCentro = new Centron();
            this.negocioNits = new Nitsn();
            this.negocioAsiento = new asientosn();
            this.InitializeComponent();
            this.busqueda = buscar;
            this.menub = menu;
            this.comprobanasi = comprobante;
            this.Visual();
            this.formAsientos = form_Asientos;
        }

        #region TECLAS DE ACCESO

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.B))
            {
                ts_buscar.ShowDropDown();
                return true;
            }

            if (keyData == Keys.Escape)
            {
                EventArgs eve = new EventArgs();
                object sender = new object();
                if (btn_salir.Enabled == true)
                {
                    this.Btn_salir_Click(sender, eve);
                    return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion

        #region NOMBRES COLUMNAS

        private void NombresColumnaCuenta()
        {
            dgv_busqueda.Columns[0].HeaderText = "CUENTA";
            dgv_busqueda.Columns[1].HeaderText = "NOMBRE";
            dgv_busqueda.Columns[2].HeaderText = "TIPO DE CUENTA";
            dgv_busqueda.Columns[3].HeaderText = "PIDE NIT";
            dgv_busqueda.Columns[4].HeaderText = "CENTRO COSTOS";
            dgv_busqueda.Columns[5].HeaderText = "AJUSTES INTEGRALES";
            dgv_busqueda.Columns[6].HeaderText = "NIT AJUSTES";
            dgv_busqueda.Columns[7].HeaderText = "CUENTA AJUSTES";
            dgv_busqueda.Columns[8].HeaderText = "CUENTA CORRECION";
            dgv_busqueda.Columns[9].HeaderText = "D/C";
            dgv_busqueda.Columns[10].HeaderText = "RETENCION";
            dgv_busqueda.Columns[11].HeaderText = "% RETENCION";
            dgv_busqueda.Columns[12].HeaderText = "CONCEP. RETENCION";
            dgv_busqueda.Columns[16].HeaderText = "CUENTA CIERRE IMP";
            dgv_busqueda.Columns[17].HeaderText = "FORMATO MEDIOS";
            dgv_busqueda.Columns[13].Visible = false;
            dgv_busqueda.Columns[14].Visible = false;
            dgv_busqueda.Columns[15].Visible = false;
            dgv_busqueda.Columns[0].Width = 90;
            dgv_busqueda.Columns[1].Width = 250;
            dgv_busqueda.Columns[2].Width = 70;
            dgv_busqueda.Columns[3].Width = 70;
            dgv_busqueda.Columns[4].Width = 70;
            dgv_busqueda.Columns[5].Width = 70;
            dgv_busqueda.Columns[6].Width = 90;
            dgv_busqueda.Columns[7].Width = 90;
            dgv_busqueda.Columns[8].Width = 90;
            dgv_busqueda.Columns[9].Width = 50;
            dgv_busqueda.Columns[10].Width = 90;
            dgv_busqueda.Columns[11].Width = 90;
            dgv_busqueda.Columns[12].Width = 120;
            dgv_busqueda.Columns[16].Width = 90;
            dgv_busqueda.Columns[17].Width = 90;
            dgv_busqueda.Size = new Size(980, 410);
        }

        private void NombresColumnaPresupuesto()
        {
            dgv_busqueda.Columns[0].HeaderText = "AÑO";
            dgv_busqueda.Columns[1].HeaderText = "MES";
            dgv_busqueda.Columns[2].HeaderText = "CUENTA";
            dgv_busqueda.Columns[3].HeaderText = "CENTRO";
            dgv_busqueda.Columns[4].HeaderText = "PRESUPUESTO";
            dgv_busqueda.Size = new Size(400, 470);
            dgv_busqueda.Columns[3].Width = 120;
        }

        /// <summary>
        /// Nombres la tabla de nits datagridview
        /// </summary>
        private void NombresColumnasNits()
        {
            dgv_busqueda.Columns[0].HeaderText = "NIT";
            dgv_busqueda.Columns[1].HeaderText = "DIGITO";
            dgv_busqueda.Columns[2].HeaderText = "TIPO NIT";
            dgv_busqueda.Columns[3].HeaderText = "NOMBRE";
            dgv_busqueda.Columns[4].HeaderText = "ACT. ECONOMICA";
            dgv_busqueda.Columns[5].HeaderText = "PAIS";
            dgv_busqueda.Columns[6].HeaderText = "DEPTO";
            dgv_busqueda.Columns[7].HeaderText = "CIUDAD";
            dgv_busqueda.Columns[8].HeaderText = "DIRECCION";
            dgv_busqueda.Columns[9].HeaderText = "TELEFONO";
            dgv_busqueda.Columns[10].HeaderText = "CELULAR";
            dgv_busqueda.Columns[11].HeaderText = "EMAIL";
            dgv_busqueda.Columns[1].Width = 70;
            dgv_busqueda.Columns[3].Width = 200;
            dgv_busqueda.Columns[8].Width = 150;
        }

        /// <summary>
        /// Nombre tablas
        /// </summary>
        private void NombresColumnasComprobantes()
        {
            dgv_busqueda.Columns[0].HeaderText = "CODIGO";
            dgv_busqueda.Columns[1].HeaderText = "NOMBRE";
            dgv_busqueda.Columns[2].HeaderText = "CONSECUTIVO";
            dgv_busqueda.Columns[3].HeaderText = "NUMERO ACTUAL";
            dgv_busqueda.Columns[4].HeaderText = "CODIGO CONVERSION";
            dgv_busqueda.Columns[1].Width = 200;
        }

        private void NombresColumnasCentro()
        {
            dgv_busqueda.Columns[0].HeaderText = "CODIGO";
            dgv_busqueda.Columns[1].HeaderText = "NOMBRE";
            dgv_busqueda.Columns[0].Width = 100;
            dgv_busqueda.Columns[1].Width = 250;
        }

        private void NombreColumnasFormato()
        {
            dgv_busqueda.Columns[0].HeaderText = "CLASE";
            dgv_busqueda.Columns[1].HeaderText = "LINEA";
            dgv_busqueda.Columns[2].HeaderText = "NOMBRE";
            dgv_busqueda.Columns[3].HeaderText = "CUENTA INICIAL";
            dgv_busqueda.Columns[4].HeaderText = "CUENTA FINAL";
            dgv_busqueda.Columns[2].Width = 170;
        }

        private void NombreColumnasCodTributario()
        {
            dgv_busqueda.Columns[0].HeaderText = "CODIGO";
            dgv_busqueda.Columns[1].HeaderText = "NOMBRE";
            dgv_busqueda.Columns[2].HeaderText = "TOPE";
            dgv_busqueda.Columns[3].HeaderText = "NIT TOPE";
            dgv_busqueda.Columns[4].HeaderText = "NOMBRE NIT";
            dgv_busqueda.Columns[0].Width = 70;
            dgv_busqueda.Columns[1].Width = 200;
            dgv_busqueda.Columns[2].Width = 70;
            dgv_busqueda.Columns[3].Width = 100;
            dgv_busqueda.Columns[4].Width = 200;
        }

        private void NombreColumnasAsientoFijo()
        {
            dgv_busqueda.Columns[0].HeaderText = "DOCUMENTO";
            dgv_busqueda.Columns[1].HeaderText = "CUENTA";
            dgv_busqueda.Columns[2].HeaderText = "CENTRO";
            dgv_busqueda.Columns[3].HeaderText = "NIT";
            dgv_busqueda.Columns[4].HeaderText = "REFERENCIA";
            dgv_busqueda.Columns[5].HeaderText = "DETALLE";
            dgv_busqueda.Columns[6].Visible = false;
            dgv_busqueda.Columns[7].Visible = false;
            dgv_busqueda.Columns[0].Width = 100;
            dgv_busqueda.Columns[1].Width = 120;
            dgv_busqueda.Columns[2].Width = 70;
            dgv_busqueda.Columns[3].Width = 120;
            dgv_busqueda.Columns[4].Width = 100;
            dgv_busqueda.Columns[5].Width = 300;
        }

        private void NombresColumnasAsiento()
        {
            dgv_busqueda.Columns[0].HeaderText = "AÑO";
            dgv_busqueda.Columns[1].HeaderText = "MES";
            dgv_busqueda.Columns[2].HeaderText = "FECHA";
            dgv_busqueda.Columns[3].HeaderText = "COMPROBANTE";
            dgv_busqueda.Columns[4].HeaderText = "DOCUMENTO";
            dgv_busqueda.Columns[5].HeaderText = "DETALLE";
            dgv_busqueda.Columns[0].Width = 70;
            dgv_busqueda.Columns[1].Width = 70;
            dgv_busqueda.Columns[2].Width = 120;
            dgv_busqueda.Columns[3].Width = 110;
            dgv_busqueda.Columns[4].Width = 120;
            dgv_busqueda.Columns[5].Width = 240;
        }

        #endregion

        #region VISUAL

        private void Visual()
        {
            switch (this.busqueda)
            {
                case "cuenta":

                    this.Text = "CUENTAS";
                    ts_buscar1.Text = "NUMERO DE CUENTA";
                    ts_buscar2.Text = "NOMBRE";
                    ts_buscar3.Text = "TIPO CUENTA";
                    ts_buscar4.Visible = false;
                    ts_buscar5.Visible = false;
                    List<CuentaDataSource> tablacuentas = new List<CuentaDataSource>();
                    try
                    {
                        tablacuentas = this.negocioCuenta.Busqueda("todos", "todos");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message);
                    }

                    dgv_busqueda.DataSource = tablacuentas;
                    this.NombresColumnaCuenta();
                    break;

                case "cuentaasiento":

                    this.Text = "CUENTAS";
                    ts_buscar1.Text = "NUMERO DE CUENTA";
                    ts_buscar2.Text = "NOMBRE";
                    ts_buscar3.Text = "TIPO CUENTA";
                    ts_buscar4.Visible = false;
                    ts_buscar5.Visible = false;
                    List<CuentaDataSource> tablacuentasde = new List<CuentaDataSource>();
                    try
                    {
                        tablacuentasde = this.negocioCuenta.Busqueda("auxiliar", "todos");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message);
                    }

                    dgv_busqueda.DataSource = tablacuentasde;
                    this.NombresColumnaCuenta();
                    break;

                case "presupuesto":

                    this.Size = new Size(465, 600);
                    txt_busqueda.Size = new Size(285, 20);
                    this.Text = "PRESUPUESTO";
                    ts_buscar1.Text = "AÑO";
                    ts_buscar2.Text = "CUENTA";
                    ts_buscar3.Text = "CENTRO";
                    ts_buscar4.Visible = false;
                    ts_buscar5.Visible = false;
                    List<PresupShowDataSource> tablapresupuesto = new List<PresupShowDataSource>();
                    try
                    {
                        tablapresupuesto = this.negocioPresupuesto.Busqueda("todos", "todos");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message);
                    }

                    dgv_busqueda.DataSource = tablapresupuesto;
                    this.NombresColumnaPresupuesto();
                    break;

                case "nit":
                case "nitasiento":

                    this.Size = new Size(900, 530);
                    txt_busqueda.Size = new Size(300, 20);
                    this.Text = "NITS O TERCEROS";
                    ts_buscar1.Text = "NIT";
                    ts_buscar2.Text = "NOMBRE";
                    ts_buscar3.Text = "PAIS";
                    ts_buscar4.Text = "DEPARTAMENTO";
                    ts_buscar5.Text = "CIUDAD";
                    List<NitsDataSourceShow> tablanit = new List<NitsDataSourceShow>();
                    try
                    {
                        tablanit = this.negocioNits.Busqueda("todos", "todos");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message);
                    }

                    dgv_busqueda.DataSource = tablanit;
                    this.NombresColumnasNits();
                    break;

                case "comprobante":

                    this.Size = new Size(525, 530);
                    txt_busqueda.Size = new Size(250, 20);
                    this.Text = "TIPOS DE COMPROBANTES";
                    ts_buscar1.Text = "CODIGO";
                    ts_buscar2.Text = "NOMBRE";
                    ts_buscar3.Visible = false;
                    ts_buscar4.Visible = false;
                    ts_buscar5.Visible = false;
                    List<ComprobantesDataSourceShow> tablacomprobantes = new List<ComprobantesDataSourceShow>();
                    try
                    {
                        tablacomprobantes = this.negocioComprobante.Busqueda("todos", "todos");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message);
                    }

                    dgv_busqueda.DataSource = tablacomprobantes;
                    this.NombresColumnasComprobantes();
                    break;

                case "centro":
                case "centroasiento":

                    this.Size = new Size(310, 530);
                    txt_busqueda.Location = new Point(98, 44);
                    txt_busqueda.Size = new Size(200, 20);
                    this.Text = "CENTRO DE COSTOS";
                    ts_buscar1.Text = "CODIGO";
                    ts_buscar2.Text = "NOMBRE";
                    ts_buscar3.Visible = false;
                    ts_buscar4.Visible = false;
                    ts_buscar5.Visible = false;
                    List<CentroDataSourceShow> tablacentro = new List<CentroDataSourceShow>();
                    try
                    {
                        tablacentro = this.negocioCentro.Busqueda("todos", "todos");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message);
                    }

                    dgv_busqueda.DataSource = tablacentro;
                    this.NombresColumnasCentro();
                    break;

                case "formato":

                    this.Size = new Size(500, 530);
                    string titulo = this.tipof.Equals("1") ? "BALANCE GENERAL" : "ESTADO DE PERDIDAS Y GANACIAS";
                    this.Text = "REPORTE FORMATO  " + titulo;
                    txt_busqueda.Location = new Point(160, 44);
                    txt_busqueda.Size = new Size(250, 20);
                    ts_buscar1.Text = "NOMBRE";
                    ts_buscar2.Visible = false;
                    ts_buscar3.Visible = false;
                    ts_buscar4.Visible = false;
                    ts_buscar5.Visible = false;
                    List<FormatoDataSourceShow> tablaformato = new List<FormatoDataSourceShow>();
                    try
                    {
                        tablaformato = this.negocioFormato.Busqueda("todos", "todos", this.tipof);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message);
                    }

                    dgv_busqueda.DataSource = tablaformato;
                    this.NombreColumnasFormato();
                    break;

                case "tributario":

                    this.Size = new Size(555, 530);
                    txt_busqueda.Size = new Size(350, 20);
                    this.Text = "CODIGO TRIBUTARIO";
                    ts_buscar1.Text = "CODIGO";
                    ts_buscar2.Text = "NOMBRE";
                    ts_buscar3.Visible = false;
                    ts_buscar4.Visible = false;
                    ts_buscar5.Visible = false;
                    List<TributarioDataSourceShow> tablatributario = new List<TributarioDataSourceShow>();
                    try
                    {
                        tablatributario = this.negocioTributario.Busqueda("todos", "todos");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message);
                    }

                    dgv_busqueda.DataSource = tablatributario;
                    this.NombreColumnasCodTributario();
                    break;

                case "asientofijo":
                    this.Size = new Size(708, 530);
                    txt_busqueda.Size = new Size(400, 20);
                    this.Text = "ASIENTOS FIJOS";
                    ts_buscar1.Text = "CUENTA";
                    ts_buscar2.Text = "NIT";
                    ts_buscar3.Text = "DETALLE";
                    ts_buscar4.Text = "REFERENCIA";
                    ts_buscar5.Visible = false;
                    List<AsientoDataSourceFijo> asientosfijos = new List<AsientoDataSourceFijo>();
                    try
                    {
                        asientosfijos = this.negocioAsiento.BusquedaFijo("asientofijo", "todos", int.Parse(this.comprobanasi), Program.compa);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message);
                    }

                    dgv_busqueda.DataSource = asientosfijos;
                    this.NombreColumnasAsientoFijo();
                    break;

                case "asiento":
                    this.Size = new Size(638, 530);
                    txt_busqueda.Location = new Point(130, 44);
                    txt_busqueda.Size = new Size(300, 20);
                    this.Text = "ASIENTOS";
                    ts_buscar1.Text = "AÑO";
                    ts_buscar2.Text = "MES";
                    ts_buscar3.Text = "COMPROBANTE";
                    ts_buscar4.Text = "DOCUMENTO";
                    ts_buscar5.Text = "DETALLE";
                    List<AsientoDataSourceView> asiento = new List<AsientoDataSourceView>();
                    try
                    {
                        asiento = this.negocioAsiento.Busqueda("todos", "todos", Program.compa);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message);
                    }

                    dgv_busqueda.DataSource = asiento;
                    this.NombresColumnasAsiento();
                    break;
            }
        }

        private void Ts_buscar_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tb = (ToolStripMenuItem)sender;
            lbl_buscar.Text = tb.Text;
        }

        #endregion

        #region EVENTOS FORMULARIO

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            switch (this.busqueda)
            {
                case "cuenta":
                    this.formcuenta.BotonesHabit();
                    break;

                case "presupuesto":
                    this.frmpresupuesto.BotonesHabit();
                    break;

                case "nit":
                    this.frmnits.BotonesHabit();
                    break;

                case "comprobante":
                    this.frmcomprobantes.BotonesHabit();
                    break;

                case "centro":
                    this.frmcentro.BotonesHabit();
                    break;

                case "formato":
                    this.formFormatos.BotonesHabit();
                    break;

                case "tributario":
                    this.frmTributario.BotonesHabit();
                    break;

                case "cuentaasiento":
                    this.formAsientos.SalirCuenta();
                    break;

                case "centroasiento":
                    this.formAsientos.SalirCentro();
                    break;

                case "nitasiento":
                    this.formAsientos.SalirNit();
                    break;

                case "asientofijo":
                    if (!"0000".Equals(this.comprobanasi))
                    {
                        this.formAsientos.SalirAsientoFijo();
                    }
                    else
                    {
                        this.formAsientos.SalirAsiento();
                    }
                    break;

                case "asiento":
                    this.formAsientos.SalirAsiento();
                    break;
            }
        }

        private void Form_VisualContable_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (this.busqueda)
            {
                case "cuenta":
                    this.formcuenta.BotonesHabit();
                    break;

                case "presupuesto":
                    this.frmpresupuesto.BotonesHabit();
                    break;

                case "nit":
                    this.frmnits.BotonesHabit();
                    break;

                case "comprobante":
                    this.frmcomprobantes.BotonesHabit();
                    break;

                case "centro":
                    this.frmcentro.BotonesHabit();
                    break;

                case "formato":
                    this.formFormatos.BotonesHabit();
                    break;

                case "tributario":
                    this.frmTributario.BotonesHabit();
                    break;

                case "cuentaasiento":
                    this.formAsientos.SalirCuenta();
                    break;

                case "centroasiento":
                    this.formAsientos.SalirCentro();
                    break;

                case "nitasiento":
                    this.formAsientos.SalirNit();
                    break;

                case "asientofijo":
                    if (!"0000".Equals(this.comprobanasi))
                    {
                        this.formAsientos.SalirAsientoFijo();
                    }
                    else
                    {
                        this.formAsientos.SalirAsiento();
                    }
                    break;

                case "asiento":
                    this.formAsientos.SalirAsiento();
                    break;
            }
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            this.Visual();
        }

        private void Txt_busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Down)
            {
                e.Handled = false;
                SendKeys.Send("{TAB}");
                dgv_busqueda.Focus();
            }
        }

        private void Txt_busqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = false;
                SendKeys.Send("{TAB}");
                dgv_busqueda.Focus();
            }

            switch (this.busqueda)
            {
                case "cuenta":

                    List<CuentaDataSource> buscarcuenta = new List<CuentaDataSource>();
                    try
                    {
                        buscarcuenta = this.negocioCuenta.Busqueda(lbl_buscar.Text.ToLower(), txt_busqueda.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message, "ERROR");
                    }

                    dgv_busqueda.DataSource = buscarcuenta;
                    this.NombresColumnaCuenta();
                    break;

                case "cuentaasiento":

                    List<CuentaDataSource> buscarcuentaaux = new List<CuentaDataSource>();
                    try
                    {
                        buscarcuentaaux = this.negocioCuenta.Busqueda(lbl_buscar.Text.ToLower() + "aux", txt_busqueda.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message, "ERROR");
                    }

                    dgv_busqueda.DataSource = buscarcuentaaux;
                    this.NombresColumnaCuenta();
                    break;

                case "presupuesto":

                    List<PresupShowDataSource> buscarpresu = new List<PresupShowDataSource>();
                    try
                    {
                        buscarpresu = this.negocioPresupuesto.Busqueda(lbl_buscar.Text.ToLower(), txt_busqueda.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message, "ERROR");
                    }

                    dgv_busqueda.DataSource = buscarpresu;
                    this.NombresColumnaPresupuesto();
                    break;

                case "nit":
                case "nitasiento":

                    List<NitsDataSourceShow> buscarnit = new List<NitsDataSourceShow>();
                    try
                    {
                        buscarnit = this.negocioNits.Busqueda(lbl_buscar.Text.ToLower(), txt_busqueda.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message, "ERROR");
                    }

                    dgv_busqueda.DataSource = buscarnit;
                    this.NombresColumnasNits();
                    break;

                case "comprobante":

                    List<ComprobantesDataSourceShow> buscarcompr = new List<ComprobantesDataSourceShow>();
                    try
                    {
                        buscarcompr = this.negocioComprobante.Busqueda(lbl_buscar.Text.ToLower(), txt_busqueda.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message, "ERROR");
                    }

                    dgv_busqueda.DataSource = buscarcompr;
                    this.NombresColumnasComprobantes();
                    break;

                case "centro":
                case "centroasiento":

                    List<CentroDataSourceShow> buscarcentro = new List<CentroDataSourceShow>();
                    try
                    {
                        buscarcentro = this.negocioCentro.Busqueda(lbl_buscar.Text.ToLower(), txt_busqueda.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message, "ERROR");
                    }

                    dgv_busqueda.DataSource = buscarcentro;
                    this.NombresColumnasCentro();
                    break;

                case "formato":
                    List<FormatoDataSourceShow> buscarformato = new List<FormatoDataSourceShow>();
                    try
                    {
                        buscarformato = this.negocioFormato.Busqueda(lbl_buscar.Text.ToLower(), txt_busqueda.Text, this.tipof);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message, "ERROR");
                    }

                    dgv_busqueda.DataSource = buscarformato;
                    this.NombreColumnasFormato();
                    break;

                case "tributario":

                    List<TributarioDataSourceShow> buscartrib = new List<TributarioDataSourceShow>();
                    try
                    {
                        buscartrib = this.negocioTributario.Busqueda(lbl_buscar.Text.ToLower(), txt_busqueda.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message, "ERROR");
                    }

                    dgv_busqueda.DataSource = buscartrib;
                    this.NombreColumnasCodTributario();
                    break;

                case "asientofijo":

                    List<AsientoDataSourceFijo> buscarasientofijo = new List<AsientoDataSourceFijo>();
                    try
                    {
                        buscarasientofijo = this.negocioAsiento.BusquedaFijo(lbl_buscar.Text.ToLower(), txt_busqueda.Text, int.Parse(this.comprobanasi), Program.compa);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message, "ERROR");
                    }

                    dgv_busqueda.DataSource = buscarasientofijo;
                    this.NombreColumnasAsientoFijo();
                    break;

                case "asiento":

                    List<AsientoDataSourceView> buscarasiento = new List<AsientoDataSourceView>();
                    try
                    {
                        buscarasiento = this.negocioAsiento.Busqueda(lbl_buscar.Text.ToLower(), txt_busqueda.Text, Program.compa);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message, "ERROR");
                    }

                    dgv_busqueda.DataSource = buscarasiento;
                    this.NombresColumnasAsiento();
                    break;
            }
        }

        #endregion

        #region EVENTOS DATAGRIDVIEX

        private void Dgv_busqueda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_busqueda.CurrentRow.Cells[0].Value != null)
            {
                if ("cuenta".Equals(this.busqueda) || "nit".Equals(this.busqueda) || "comprobante".Equals(this.busqueda) || "centro".Equals(this.busqueda)
                    || "tributario".Equals(this.busqueda) || "cuentaasiento".Equals(this.busqueda) ||
                    "centroasiento".Equals(this.busqueda) || "nitasiento".Equals(this.busqueda) || "asientofijo".Equals(this.busqueda))
                {
                    this.EventosTabla(dgv_busqueda.CurrentRow.Cells[0].Value.ToString());
                }
                else if ("presupuesto".Equals(this.busqueda))
                {
                    this.EventosTablaPresupus(dgv_busqueda.CurrentRow.Cells[0].Value.ToString(),
                                                dgv_busqueda.CurrentRow.Cells[2].Value.ToString(), int.Parse(dgv_busqueda.CurrentRow.Cells[3].Value.ToString()));
                }
                else if ("formato".Equals(this.busqueda))
                {
                    this.EventosTablaFormato(dgv_busqueda.CurrentRow.Cells[0].Value.ToString(), dgv_busqueda.CurrentRow.Cells[1].Value.ToString());
                }
                else if ("asiento".Equals(this.busqueda))
                {
                    this.EventosAsiento(dgv_busqueda.CurrentRow.Cells[3].Value.ToString(), dgv_busqueda.CurrentRow.Cells[4].Value.ToString());
                }
            }
        }

        private void Dgv_busqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                if (dgv_busqueda.CurrentRow.Cells[0].Value != null)
                {
                    if ("cuenta".Equals(this.busqueda) || "nit".Equals(this.busqueda) || "comprobante".Equals(this.busqueda) || "centro".Equals(this.busqueda)
                   || "tributario".Equals(this.busqueda) || "cuentaasiento".Equals(this.busqueda) ||
                    "centroasiento".Equals(this.busqueda) || "nitasiento".Equals(this.busqueda) || "asientofijo".Equals(this.busqueda))
                    {
                        this.EventosTabla(dgv_busqueda.CurrentRow.Cells[0].Value.ToString());
                    }
                    else if ("presupuesto".Equals(this.busqueda))
                    {
                        this.EventosTablaPresupus(dgv_busqueda.CurrentRow.Cells[0].Value.ToString(),
                                                    dgv_busqueda.CurrentRow.Cells[2].Value.ToString(), int.Parse(dgv_busqueda.CurrentRow.Cells[3].Value.ToString()));
                    }
                    else if ("formato".Equals(this.busqueda))
                    {
                        this.EventosTablaFormato(dgv_busqueda.CurrentRow.Cells[0].Value.ToString(), dgv_busqueda.CurrentRow.Cells[1].Value.ToString());
                    }
                    else if ("asiento".Equals(this.busqueda))
                    {
                        this.EventosAsiento(dgv_busqueda.CurrentRow.Cells[3].Value.ToString(), dgv_busqueda.CurrentRow.Cells[4].Value.ToString());
                    }
                }
            }

            if (e.KeyCode == Keys.Up)
            {
                if (dgv_busqueda.CurrentRow.Index == 0)
                {
                    txt_busqueda.Focus();
                }
            }
        }

        private void EventosTabla(string valor)
        {
            switch (this.busqueda)
            {
                case "cuenta":
                    switch (this.menub)
                    {
                        case "editar":
                            this.Close();
                            this.formcuenta.CargarDatos(valor);
                            this.formcuenta.Show();
                            break;

                        case "eliminar":

                            DialogResult result = MessageBox.Show("ESTA SEGURO QUE DESEA ELIMINAR?", "ELIMINAR", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                bool val = false;
                                try
                                {
                                    val = this.negocioCuenta.EliminarCuenta(valor);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("LA CUENTA NO PUEDE SER ELIMINADA. " + ex.Message, "ERROR");
                                }

                                if (val)
                                {
                                    MessageBox.Show("ESTE REGISTRO FUE ELIMINADO", "ELIMINAR", MessageBoxButtons.OK);
                                    this.Visual();
                                }
                            }

                            break;

                        case "buscar":
                            this.Close();
                            this.formcuenta.DevolverCuenta(valor);
                            break;
                    }

                    break;

                case "nit":

                    switch (this.menub)
                    {
                        case "editar":
                            this.Close();
                            this.frmnits.CargarDatos(valor);
                            this.frmnits.Show();
                            break;

                        case "eliminar":

                            DialogResult result = MessageBox.Show("ESTA SEGURO QUE DESEA ELIMINAR?", "ELIMINAR", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                bool val = false;
                                try
                                {
                                    val = this.negocioNits.EliminarNit(valor);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("ESTE NIT NO PUEDE SER ELIMINADO. " + ex.Message, "ERROR");
                                }

                                if (val)
                                {
                                    MessageBox.Show("ESTE REGISTRO FUE ELIMINADO", "ELIMINAR", MessageBoxButtons.OK);
                                    this.Visual();
                                }
                            }

                            break;
                    }

                    break;

                case "comprobante":

                    switch (this.menub)
                    {
                        case "editar":
                            this.Close();
                            this.frmcomprobantes.CargarDatos(int.Parse(valor));
                            this.frmcomprobantes.Show();
                            break;

                        case "eliminar":

                            DialogResult result = MessageBox.Show("ESTA SEGURO QUE DESEA ELIMINAR?", "ELIMINAR", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                bool val = false;
                                try
                                {
                                    val = this.negocioComprobante.EliminarCompro(int.Parse(valor));
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("ESTE COMPROBANTE NO PUEDE SER ELIMINADO. " + ex.Message, "ERROR");
                                }

                                if (val)
                                {
                                    MessageBox.Show("ESTE REGISTRO FUE ELIMINADO", "ELIMINAR", MessageBoxButtons.OK);
                                    this.Visual();
                                }
                            }

                            break;
                    }

                    break;

                case "centro":

                    switch (this.menub)
                    {
                        case "editar":
                            this.Close();
                            this.frmcentro.CargarDatos(int.Parse(valor));
                            this.frmcentro.Show();
                            break;

                        case "eliminar":

                            DialogResult result = MessageBox.Show("ESTA SEGURO QUE DESEA ELIMINAR?", "ELIMINAR", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                bool val = false;
                                try
                                {
                                    val = this.negocioCentro.EliminarCentro(int.Parse(valor));
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message, "ERROR");
                                }

                                if (val)
                                {
                                    MessageBox.Show("ESTE REGISTRO FUE ELIMINADO", "ELIMINAR", MessageBoxButtons.OK);
                                    this.Visual();
                                }
                            }

                            break;
                    }

                    break;

                case "tributario":

                    switch (this.menub)
                    {
                        case "editar":
                            this.Close();
                            this.frmTributario.CargarDatos(valor);
                            this.frmTributario.Show();
                            break;

                        case "eliminar":

                            DialogResult result = MessageBox.Show("ESTA SEGURO QUE DESEA ELIMINAR?", "ELIMINAR", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                bool val = false;
                                try
                                {
                                    val = this.negocioTributario.EliminarTribut(valor);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("ESTE CODIGO TRIBUTARIO NO PUEDE SER ELIMINADO. " + ex.Message, "ERROR");
                                }

                                if (val)
                                {
                                    MessageBox.Show("ESTE REGISTRO FUE ELIMINADO", "ELIMINAR", MessageBoxButtons.OK);
                                    this.Visual();
                                }
                            }

                            break;
                    }

                    break;

                case "cuentaasiento":

                    if ("buscar".Equals(this.menub))
                    {
                        this.Close();
                        this.formAsientos.CargarCuenta(valor);
                    }

                    break;

                case "centroasiento":

                    if ("buscar".Equals(this.menub))
                    {
                        this.Close();
                        this.formAsientos.CargarCentro(valor);
                    }

                    break;

                case "nitasiento":
                    if ("buscar".Equals(this.menub))
                    {
                        this.Close();
                        this.formAsientos.CargarNit(valor);
                    }

                    break;

                case "asientofijo":

                    if ("buscar".Equals(this.menub))
                    {
                        this.Close();
                        this.formAsientos.CargarAsientoFijo(valor);
                    }
                    else if ("eliminar".Equals(this.menub))
                    {

                        DialogResult result = MessageBox.Show("ESTA SEGURO QUE DESEA ELIMINAR?", "ELIMINAR", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            bool val = false;
                            try
                            {
                                val = this.negocioAsiento.EliminarAsiento(valor, true, Program.compa);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("ESTE ASIENTO NO PUEDE SER ELIMINADO. " + ex.Message, "ERROR");
                            }

                            if (val)
                            {
                                MessageBox.Show("ESTE ASIENTO FUE ELIMINADO", "ELIMINAR", MessageBoxButtons.OK);
                                this.Visual();
                            }
                        }
                    }

                    break;
            }
        }

        private void EventosAsiento(string comprobante, string documento)
        {
            switch (this.menub)
            {
                case "editar":
                    this.Close();
                    this.formAsientos.CargarDatos(comprobante, documento);
                    this.formAsientos.Show();
                    break;

                case "eliminar":

                    DialogResult result = MessageBox.Show("ESTA SEGURO QUE DESEA ELIMINAR?", "ELIMINAR", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        bool val = false;
                        try
                        {
                            val = this.negocioAsiento.EliminarAsiento(comprobante + documento, false, Program.compa);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ESTE ASIENTO NO PUEDE SER ELIMINADO. " + ex.Message, "ERROR");
                        }

                        if (val)
                        {
                            MessageBox.Show("ESTE ASIENTO FUE ELIMINADO", "ELIMINAR", MessageBoxButtons.OK);
                            this.Visual();
                        }
                    }

                    break;
            }
        }

        private void EventosTablaFormato(string clase, string linea)
        {
            switch (this.menub)
            {
                case "editar":
                    this.Close();
                    this.formFormatos.CargarDatos(clase, linea, this.tipof);
                    this.formFormatos.Show();
                    break;

                case "eliminar":

                    DialogResult result = MessageBox.Show("ESTA SEGURO QUE DESEA ELIMINAR EL FORMATO?", "ELIMINAR", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        bool val = false;
                        try
                        {
                            val = this.negocioFormato.EliminarFormato(clase, linea, this.tipof);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message, "ERROR");
                        }

                        if (val)
                        {
                            MessageBox.Show("ESTE FORMATO FUE ELIMINADO", "ELIMINAR", MessageBoxButtons.OK);
                            this.Visual();
                        }
                    }

                    break;
            }
        }

        private void EventosTablaPresupus(string anio, string cuenta, int centro)
        {
            switch (this.menub)
            {
                case "editar":
                    this.Close();
                    this.frmpresupuesto.CargarDatos(anio, cuenta, centro);
                    this.frmpresupuesto.Show();
                    break;

                case "eliminar":

                    DialogResult result = MessageBox.Show("ESTA SEGURO QUE DESEA ELIMINAR EL PRESUPUESTO\nAÑO:   "
                        + anio + "      CUENTA:  " + cuenta + "     CENTRO:     " + centro + "?", "ELIMINAR", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        bool val = false;
                        try
                        {
                            val = this.negocioPresupuesto.EliminarPresupuesto(anio, cuenta, centro, Program.compa);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("SE PRESENTO UN ERROR. " + ex.Message, "ERROR");
                        }

                        if (val)
                        {
                            MessageBox.Show("ESTE PRESUPUESTO FUE ELIMINADO", "ELIMINAR", MessageBoxButtons.OK);
                            this.Visual();
                        }
                    }

                    break;
            }
        }

        #endregion
    }
}
