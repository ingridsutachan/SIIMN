namespace App.Forms.Contable
{
    partial class Form_Asientos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Asientos));
            this.dgv_asientos = new System.Windows.Forms.DataGridView();
            this.cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debitos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_comprobante = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_numeroasiento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_totaldebito = new System.Windows.Forms.TextBox();
            this.txt_totalcredito = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_descuadre = new System.Windows.Forms.TextBox();
            this.dtime_fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_debito = new System.Windows.Forms.TextBox();
            this.txt_referencia = new System.Windows.Forms.TextBox();
            this.txt_nit = new System.Windows.Forms.TextBox();
            this.txt_centro = new System.Windows.Forms.TextBox();
            this.txt_cuenta = new System.Windows.Forms.TextBox();
            this.txt_credito = new System.Windows.Forms.TextBox();
            this.txt_detalle = new System.Windows.Forms.TextBox();
            this.lbl_cuenta = new System.Windows.Forms.Label();
            this.checked_asientofijo = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_anio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_mes = new System.Windows.Forms.ComboBox();
            this.menu_botones = new System.Windows.Forms.ToolStrip();
            this.btn_nuevo = new System.Windows.Forms.ToolStripButton();
            this.btn_editar = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_editarfenumcomp = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_eliminar = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_eliminarasiento = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_eliminarfijo = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_buscar = new System.Windows.Forms.ToolStripButton();
            this.btn_imprimir = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_imprasiact = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_imprasiborrados = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_imprasiefijos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_traerasiento = new System.Windows.Forms.ToolStripButton();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.btn_cancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_detallefull = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asientos)).BeginInit();
            this.menu_botones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_asientos
            // 
            this.dgv_asientos.AllowUserToAddRows = false;
            this.dgv_asientos.AllowUserToDeleteRows = false;
            this.dgv_asientos.AllowUserToResizeRows = false;
            this.dgv_asientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_asientos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_asientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_asientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_asientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuenta,
            this.centro,
            this.NIT,
            this.referencia,
            this.debitos,
            this.creditos,
            this.detalle});
            this.dgv_asientos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_asientos.Location = new System.Drawing.Point(21, 285);
            this.dgv_asientos.Name = "dgv_asientos";
            this.dgv_asientos.ReadOnly = true;
            this.dgv_asientos.RowHeadersVisible = false;
            this.dgv_asientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_asientos.Size = new System.Drawing.Size(674, 216);
            this.dgv_asientos.TabIndex = 0;
            this.dgv_asientos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_asientos_CellDoubleClick);
            this.dgv_asientos.Enter += new System.EventHandler(this.Dgv_asientos_Enter);
            this.dgv_asientos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv_asientos_KeyDown);
            // 
            // cuenta
            // 
            this.cuenta.HeaderText = "CUENTA";
            this.cuenta.MaxInputLength = 10;
            this.cuenta.Name = "cuenta";
            this.cuenta.ReadOnly = true;
            // 
            // centro
            // 
            this.centro.HeaderText = "CENTRO";
            this.centro.Name = "centro";
            this.centro.ReadOnly = true;
            // 
            // NIT
            // 
            this.NIT.HeaderText = "NIT";
            this.NIT.Name = "NIT";
            this.NIT.ReadOnly = true;
            // 
            // referencia
            // 
            this.referencia.HeaderText = "REFERENCIA";
            this.referencia.Name = "referencia";
            this.referencia.ReadOnly = true;
            // 
            // debitos
            // 
            this.debitos.HeaderText = "DEBITOS";
            this.debitos.Name = "debitos";
            this.debitos.ReadOnly = true;
            // 
            // creditos
            // 
            this.creditos.HeaderText = "CREDITOS";
            this.creditos.Name = "creditos";
            this.creditos.ReadOnly = true;
            // 
            // detalle
            // 
            this.detalle.HeaderText = "DETALLE";
            this.detalle.Name = "detalle";
            this.detalle.ReadOnly = true;
            this.detalle.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(513, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "FECHA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "COMPROBANTE";
            // 
            // cbx_comprobante
            // 
            this.cbx_comprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_comprobante.Enabled = false;
            this.cbx_comprobante.FormattingEnabled = true;
            this.cbx_comprobante.Location = new System.Drawing.Point(123, 41);
            this.cbx_comprobante.Name = "cbx_comprobante";
            this.cbx_comprobante.Size = new System.Drawing.Size(213, 21);
            this.cbx_comprobante.TabIndex = 4;
            this.cbx_comprobante.SelectionChangeCommitted += new System.EventHandler(this.Cbx_comprobante_SelectionChangeCommitted);
            this.cbx_comprobante.Enter += new System.EventHandler(this.Cbx_comprobante_Enter);
            this.cbx_comprobante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            this.cbx_comprobante.Leave += new System.EventHandler(this.Cbx_comprobante_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(351, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "NUMERO";
            // 
            // txt_numeroasiento
            // 
            this.txt_numeroasiento.Enabled = false;
            this.txt_numeroasiento.Location = new System.Drawing.Point(418, 44);
            this.txt_numeroasiento.MaxLength = 10;
            this.txt_numeroasiento.Name = "txt_numeroasiento";
            this.txt_numeroasiento.Size = new System.Drawing.Size(139, 20);
            this.txt_numeroasiento.TabIndex = 5;
            this.txt_numeroasiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_numeroasiento.Enter += new System.EventHandler(this.Txt_numeroasiento_Enter);
            this.txt_numeroasiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            this.txt_numeroasiento.Leave += new System.EventHandler(this.Txt_numeroasiento_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(404, 515);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "TOTALES";
            // 
            // txt_totaldebito
            // 
            this.txt_totaldebito.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_totaldebito.Location = new System.Drawing.Point(483, 511);
            this.txt_totaldebito.MaxLength = 20;
            this.txt_totaldebito.Name = "txt_totaldebito";
            this.txt_totaldebito.ReadOnly = true;
            this.txt_totaldebito.Size = new System.Drawing.Size(100, 20);
            this.txt_totaldebito.TabIndex = 31;
            this.txt_totaldebito.TabStop = false;
            // 
            // txt_totalcredito
            // 
            this.txt_totalcredito.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_totalcredito.Location = new System.Drawing.Point(592, 511);
            this.txt_totalcredito.MaxLength = 20;
            this.txt_totalcredito.Name = "txt_totalcredito";
            this.txt_totalcredito.ReadOnly = true;
            this.txt_totalcredito.Size = new System.Drawing.Size(100, 20);
            this.txt_totalcredito.TabIndex = 32;
            this.txt_totalcredito.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(500, 542);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "DESCUADRE";
            // 
            // txt_descuadre
            // 
            this.txt_descuadre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_descuadre.Location = new System.Drawing.Point(592, 539);
            this.txt_descuadre.MaxLength = 20;
            this.txt_descuadre.Name = "txt_descuadre";
            this.txt_descuadre.ReadOnly = true;
            this.txt_descuadre.Size = new System.Drawing.Size(100, 20);
            this.txt_descuadre.TabIndex = 33;
            this.txt_descuadre.TabStop = false;
            this.txt_descuadre.TextChanged += new System.EventHandler(this.Txt_descuadre_TextChanged);
            // 
            // dtime_fecha
            // 
            this.dtime_fecha.Enabled = false;
            this.dtime_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtime_fecha.Location = new System.Drawing.Point(581, 14);
            this.dtime_fecha.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtime_fecha.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtime_fecha.Name = "dtime_fecha";
            this.dtime_fecha.Size = new System.Drawing.Size(99, 20);
            this.dtime_fecha.TabIndex = 3;
            this.dtime_fecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            this.dtime_fecha.Leave += new System.EventHandler(this.Dtime_fecha_Leave);
            // 
            // txt_debito
            // 
            this.txt_debito.Enabled = false;
            this.txt_debito.Location = new System.Drawing.Point(443, 119);
            this.txt_debito.MaxLength = 11;
            this.txt_debito.Name = "txt_debito";
            this.txt_debito.Size = new System.Drawing.Size(111, 20);
            this.txt_debito.TabIndex = 12;
            this.txt_debito.Text = "0.00";
            this.txt_debito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
            this.txt_debito.Leave += new System.EventHandler(this.Txt_debito_Leave);
            // 
            // txt_referencia
            // 
            this.txt_referencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_referencia.Enabled = false;
            this.txt_referencia.Location = new System.Drawing.Point(322, 119);
            this.txt_referencia.MaxLength = 8;
            this.txt_referencia.Name = "txt_referencia";
            this.txt_referencia.Size = new System.Drawing.Size(110, 20);
            this.txt_referencia.TabIndex = 11;
            this.txt_referencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // txt_nit
            // 
            this.txt_nit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_nit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_nit.Enabled = false;
            this.txt_nit.Location = new System.Drawing.Point(193, 119);
            this.txt_nit.MaxLength = 45;
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(117, 20);
            this.txt_nit.TabIndex = 10;
            this.txt_nit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtAutocomplet_KeyDown);
            this.txt_nit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaNumerico_KeyPress);
            this.txt_nit.Leave += new System.EventHandler(this.Txt_nit_Leave);
            // 
            // txt_centro
            // 
            this.txt_centro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_centro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_centro.Enabled = false;
            this.txt_centro.Location = new System.Drawing.Point(124, 119);
            this.txt_centro.MaxLength = 30;
            this.txt_centro.Name = "txt_centro";
            this.txt_centro.Size = new System.Drawing.Size(63, 20);
            this.txt_centro.TabIndex = 9;
            this.txt_centro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtAutocomplet_KeyDown);
            this.txt_centro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaNumerico_KeyPress);
            this.txt_centro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_centro_KeyUp);
            this.txt_centro.Leave += new System.EventHandler(this.Txt_centro_Leave);
            // 
            // txt_cuenta
            // 
            this.txt_cuenta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_cuenta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_cuenta.Enabled = false;
            this.txt_cuenta.Location = new System.Drawing.Point(8, 117);
            this.txt_cuenta.MaxLength = 45;
            this.txt_cuenta.Name = "txt_cuenta";
            this.txt_cuenta.Size = new System.Drawing.Size(110, 20);
            this.txt_cuenta.TabIndex = 7;
            this.txt_cuenta.Enter += new System.EventHandler(this.Txt_cuenta_Enter);
            this.txt_cuenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtAutocomplet_KeyDown);
            this.txt_cuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaNumerico_KeyPress);
            this.txt_cuenta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_cuenta_KeyUp);
            this.txt_cuenta.Leave += new System.EventHandler(this.Txt_cuenta_Leave);
            // 
            // txt_credito
            // 
            this.txt_credito.Enabled = false;
            this.txt_credito.Location = new System.Drawing.Point(560, 119);
            this.txt_credito.MaxLength = 11;
            this.txt_credito.Name = "txt_credito";
            this.txt_credito.Size = new System.Drawing.Size(119, 20);
            this.txt_credito.TabIndex = 13;
            this.txt_credito.Text = "0.00";
            this.txt_credito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
            this.txt_credito.Leave += new System.EventHandler(this.Txt_credito_Leave);
            // 
            // txt_detalle
            // 
            this.txt_detalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_detalle.Enabled = false;
            this.txt_detalle.Location = new System.Drawing.Point(75, 18);
            this.txt_detalle.MaxLength = 55;
            this.txt_detalle.Name = "txt_detalle";
            this.txt_detalle.Size = new System.Drawing.Size(451, 20);
            this.txt_detalle.TabIndex = 8;
            this.txt_detalle.Enter += new System.EventHandler(this.Txt_detalle_Enter);
            this.txt_detalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            this.txt_detalle.Leave += new System.EventHandler(this.Txt_detalle_Leave);
            // 
            // lbl_cuenta
            // 
            this.lbl_cuenta.AutoSize = true;
            this.lbl_cuenta.Location = new System.Drawing.Point(96, 127);
            this.lbl_cuenta.Name = "lbl_cuenta";
            this.lbl_cuenta.Size = new System.Drawing.Size(0, 13);
            this.lbl_cuenta.TabIndex = 57;
            // 
            // checked_asientofijo
            // 
            this.checked_asientofijo.AutoSize = true;
            this.checked_asientofijo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checked_asientofijo.Enabled = false;
            this.checked_asientofijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checked_asientofijo.Location = new System.Drawing.Point(573, 40);
            this.checked_asientofijo.Name = "checked_asientofijo";
            this.checked_asientofijo.Size = new System.Drawing.Size(110, 17);
            this.checked_asientofijo.TabIndex = 6;
            this.checked_asientofijo.Text = "ASIENTO FIJO";
            this.checked_asientofijo.UseVisualStyleBackColor = true;
            this.checked_asientofijo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "AÑO";
            // 
            // txt_anio
            // 
            this.txt_anio.Enabled = false;
            this.txt_anio.Location = new System.Drawing.Point(59, 14);
            this.txt_anio.MaxLength = 4;
            this.txt_anio.Name = "txt_anio";
            this.txt_anio.Size = new System.Drawing.Size(91, 20);
            this.txt_anio.TabIndex = 1;
            this.txt_anio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaNumerico_KeyPress);
            this.txt_anio.Leave += new System.EventHandler(this.Txt_anio_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(256, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "MES";
            // 
            // cbx_mes
            // 
            this.cbx_mes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbx_mes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_mes.Enabled = false;
            this.cbx_mes.FormattingEnabled = true;
            this.cbx_mes.Location = new System.Drawing.Point(323, 14);
            this.cbx_mes.Name = "cbx_mes";
            this.cbx_mes.Size = new System.Drawing.Size(133, 21);
            this.cbx_mes.TabIndex = 2;
            this.cbx_mes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            this.cbx_mes.Leave += new System.EventHandler(this.Cbx_mes_Leave);
            // 
            // menu_botones
            // 
            this.menu_botones.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu_botones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_nuevo,
            this.btn_editar,
            this.btn_eliminar,
            this.btn_buscar,
            this.btn_imprimir,
            this.toolStripSeparator1,
            this.btn_traerasiento,
            this.btn_guardar,
            this.btn_cancelar,
            this.toolStripSeparator2,
            this.btn_salir});
            this.menu_botones.Location = new System.Drawing.Point(0, 0);
            this.menu_botones.Name = "menu_botones";
            this.menu_botones.Size = new System.Drawing.Size(729, 31);
            this.menu_botones.TabIndex = 65;
            this.menu_botones.Text = "toolStrip1";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_nuevo.Image = global::App.Properties.Resources.new24;
            this.btn_nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(28, 28);
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.ToolTipText = "Nuevo(Ctrl+N)";
            this.btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_editar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_editarfenumcomp});
            this.btn_editar.Image = global::App.Properties.Resources.edit24;
            this.btn_editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(37, 28);
            this.btn_editar.Text = "Editar";
            this.btn_editar.ToolTipText = "Editar(Ctrl+E)";
            // 
            // btn_editarfenumcomp
            // 
            this.btn_editarfenumcomp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editarfenumcomp.Name = "btn_editarfenumcomp";
            this.btn_editarfenumcomp.Size = new System.Drawing.Size(343, 22);
            this.btn_editarfenumcomp.Text = "1. MODIFICAR FECHA/NUMERO/COMPROBANTE";
            this.btn_editarfenumcomp.Click += new System.EventHandler(this.Btn_editarfenumcomp_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_eliminar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_eliminarasiento,
            this.btn_eliminarfijo});
            this.btn_eliminar.Image = global::App.Properties.Resources.delete24;
            this.btn_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(37, 28);
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.ToolTipText = "Eliminar(Ctrl+D)";
            // 
            // btn_eliminarasiento
            // 
            this.btn_eliminarasiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarasiento.Name = "btn_eliminarasiento";
            this.btn_eliminarasiento.Size = new System.Drawing.Size(244, 22);
            this.btn_eliminarasiento.Text = "1. ELIMINAR UN ASIENTO";
            this.btn_eliminarasiento.Click += new System.EventHandler(this.Btn_eliminarasiento_Click);
            // 
            // btn_eliminarfijo
            // 
            this.btn_eliminarfijo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarfijo.Name = "btn_eliminarfijo";
            this.btn_eliminarfijo.Size = new System.Drawing.Size(244, 22);
            this.btn_eliminarfijo.Text = "2. ELIMINAR UN ASIENTO FIJO";
            this.btn_eliminarfijo.Click += new System.EventHandler(this.Btn_eliminarfijo_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_buscar.Image = global::App.Properties.Resources.search24;
            this.btn_buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(28, 28);
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.ToolTipText = "Buscar(Ctrl+B)";
            this.btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_imprimir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_imprasiact,
            this.btn_imprasiborrados,
            this.btn_imprasiefijos});
            this.btn_imprimir.Image = global::App.Properties.Resources.printer24;
            this.btn_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(37, 28);
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.ToolTipText = "Imprimir (Ctrl+P)";
            // 
            // btn_imprasiact
            // 
            this.btn_imprasiact.Enabled = false;
            this.btn_imprasiact.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprasiact.Name = "btn_imprasiact";
            this.btn_imprasiact.Size = new System.Drawing.Size(284, 22);
            this.btn_imprasiact.Text = "1. IMPRIMIR ASIENTO ACTUAL";
            this.btn_imprasiact.Click += new System.EventHandler(this.Btn_imprasiact_Click);
            // 
            // btn_imprasiborrados
            // 
            this.btn_imprasiborrados.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprasiborrados.Name = "btn_imprasiborrados";
            this.btn_imprasiborrados.Size = new System.Drawing.Size(284, 22);
            this.btn_imprasiborrados.Text = "2. LISTADO DE ASIENTOS BORRADOS";
            this.btn_imprasiborrados.Click += new System.EventHandler(this.Btn_imprasiborrados_Click);
            // 
            // btn_imprasiefijos
            // 
            this.btn_imprasiefijos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprasiefijos.Name = "btn_imprasiefijos";
            this.btn_imprasiefijos.Size = new System.Drawing.Size(284, 22);
            this.btn_imprasiefijos.Text = "3. LISTADO DE ASIENTOS FIJOS";
            this.btn_imprasiefijos.Click += new System.EventHandler(this.Btn_imprasiefijos_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btn_traerasiento
            // 
            this.btn_traerasiento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_traerasiento.Enabled = false;
            this.btn_traerasiento.Image = ((System.Drawing.Image)(resources.GetObject("btn_traerasiento.Image")));
            this.btn_traerasiento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_traerasiento.Name = "btn_traerasiento";
            this.btn_traerasiento.Size = new System.Drawing.Size(28, 28);
            this.btn_traerasiento.Text = "toolStripButton1";
            this.btn_traerasiento.Click += new System.EventHandler(this.Btn_traerasiento_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_guardar.Enabled = false;
            this.btn_guardar.Image = global::App.Properties.Resources.save24;
            this.btn_guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(28, 28);
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.ToolTipText = "Guardar(Ctrl+G)";
            this.btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Image = global::App.Properties.Resources.cancel24;
            this.btn_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(28, 28);
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.ToolTipText = "Cancelar(Ctrl+Z)";
            this.btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // btn_salir
            // 
            this.btn_salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_salir.Image = global::App.Properties.Resources.salir24;
            this.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(28, 28);
            this.btn_salir.Text = "Salir";
            this.btn_salir.ToolTipText = "Salir(Esc)";
            this.btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtime_fecha);
            this.groupBox1.Controls.Add(this.txt_anio);
            this.groupBox1.Controls.Add(this.checked_asientofijo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_numeroasiento);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbx_comprobante);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbx_mes);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(21, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 70);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_agregar);
            this.groupBox2.Controls.Add(this.txt_detallefull);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_credito);
            this.groupBox2.Controls.Add(this.txt_centro);
            this.groupBox2.Controls.Add(this.txt_detalle);
            this.groupBox2.Controls.Add(this.txt_nit);
            this.groupBox2.Controls.Add(this.txt_referencia);
            this.groupBox2.Controls.Add(this.txt_cuenta);
            this.groupBox2.Controls.Add(this.txt_debito);
            this.groupBox2.Location = new System.Drawing.Point(13, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(708, 149);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Enabled = false;
            this.btn_agregar.Image = global::App.Properties.Resources.add;
            this.btn_agregar.Location = new System.Drawing.Point(681, 115);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(23, 23);
            this.btn_agregar.TabIndex = 27;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // txt_detallefull
            // 
            this.txt_detallefull.Location = new System.Drawing.Point(10, 45);
            this.txt_detallefull.Name = "txt_detallefull";
            this.txt_detallefull.ReadOnly = true;
            this.txt_detallefull.Size = new System.Drawing.Size(669, 66);
            this.txt_detallefull.TabIndex = 30;
            this.txt_detallefull.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "DETALLE";
            // 
            // Form_Asientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 613);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_asientos);
            this.Controls.Add(this.menu_botones);
            this.Controls.Add(this.lbl_cuenta);
            this.Controls.Add(this.txt_descuadre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_totalcredito);
            this.Controls.Add(this.txt_totaldebito);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Asientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASIENTOS CONTABLES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Asientos_FormClosing);
            this.Load += new System.EventHandler(this.Form_Asientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asientos)).EndInit();
            this.menu_botones.ResumeLayout(false);
            this.menu_botones.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_asientos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_comprobante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_numeroasiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_totaldebito;
        private System.Windows.Forms.TextBox txt_totalcredito;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_descuadre;
        private System.Windows.Forms.DateTimePicker dtime_fecha;
        private System.Windows.Forms.TextBox txt_debito;
        private System.Windows.Forms.TextBox txt_referencia;
        private System.Windows.Forms.TextBox txt_nit;
        private System.Windows.Forms.TextBox txt_centro;
        private System.Windows.Forms.TextBox txt_cuenta;
        private System.Windows.Forms.TextBox txt_credito;
        private System.Windows.Forms.TextBox txt_detalle;
        private System.Windows.Forms.Label lbl_cuenta;
        private System.Windows.Forms.CheckBox checked_asientofijo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_anio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_mes;
        private System.Windows.Forms.ToolStrip menu_botones;
        private System.Windows.Forms.ToolStripButton btn_nuevo;
        private System.Windows.Forms.ToolStripButton btn_buscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_guardar;
        private System.Windows.Forms.ToolStripButton btn_cancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripDropDownButton btn_editar;
        private System.Windows.Forms.ToolStripMenuItem btn_editarfenumcomp;
        private System.Windows.Forms.ToolStripDropDownButton btn_imprimir;
        private System.Windows.Forms.ToolStripMenuItem btn_imprasiborrados;
        private System.Windows.Forms.ToolStripMenuItem btn_imprasiefijos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txt_detallefull;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn centro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn debitos;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditos;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.ToolStripButton btn_traerasiento;
        private System.Windows.Forms.ToolStripDropDownButton btn_eliminar;
        private System.Windows.Forms.ToolStripMenuItem btn_eliminarasiento;
        private System.Windows.Forms.ToolStripMenuItem btn_eliminarfijo;
        private System.Windows.Forms.ToolStripMenuItem btn_imprasiact;
    }
}