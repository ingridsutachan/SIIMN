////*********************************************************
//
//    <copyright file="frmcuenta.Designer.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 01 marzo 2014
//    </copyright>
//
////*********************************************************
namespace App.Forms.Contable
{
    /// <summary>
    /// clase formulario cuenta diseño
    /// </summary>
    partial class Frmcuenta
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
            this.dgvdatoscuenta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_nomcucierre = new System.Windows.Forms.TextBox();
            this.grupo_tipo = new System.Windows.Forms.GroupBox();
            this.radio_detalle = new System.Windows.Forms.RadioButton();
            this.radio_general = new System.Windows.Forms.RadioButton();
            this.check_cuentaret = new System.Windows.Forms.CheckBox();
            this.txt_nombrecuentacorre = new System.Windows.Forms.TextBox();
            this.check_centro = new System.Windows.Forms.CheckBox();
            this.txt_nombrecuentaajuste = new System.Windows.Forms.TextBox();
            this.txtconcerete = new System.Windows.Forms.TextBox();
            this.check_pidenit = new System.Windows.Forms.CheckBox();
            this.check_ajustes = new System.Windows.Forms.CheckBox();
            this.txtdoc = new System.Windows.Forms.TextBox();
            this.lblconrete = new System.Windows.Forms.Label();
            this.txtnumcu = new System.Windows.Forms.TextBox();
            this.lblporceret = new System.Windows.Forms.Label();
            this.txtporcrete = new System.Windows.Forms.TextBox();
            this.lblddoc = new System.Windows.Forms.Label();
            this.lblcuencierr = new System.Windows.Forms.Label();
            this.lblnumcue = new System.Windows.Forms.Label();
            this.txtcierre = new System.Windows.Forms.TextBox();
            this.txtcuncor = new System.Windows.Forms.TextBox();
            this.lblcuencor = new System.Windows.Forms.Label();
            this.txtcuenaju = new System.Windows.Forms.TextBox();
            this.lblajucuen = new System.Windows.Forms.Label();
            this.txtnitajus = new System.Windows.Forms.TextBox();
            this.lblnitaju = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.salircuent = new System.Windows.Forms.Button();
            this.panel_princip = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatoscuenta)).BeginInit();
            this.panel1.SuspendLayout();
            this.grupo_tipo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_princip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvdatoscuenta
            // 
            this.dgvdatoscuenta.AllowUserToAddRows = false;
            this.dgvdatoscuenta.AllowUserToDeleteRows = false;
            this.dgvdatoscuenta.AllowUserToResizeRows = false;
            this.dgvdatoscuenta.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdatoscuenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdatoscuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatoscuenta.Location = new System.Drawing.Point(10, 55);
            this.dgvdatoscuenta.MultiSelect = false;
            this.dgvdatoscuenta.Name = "dgvdatoscuenta";
            this.dgvdatoscuenta.ReadOnly = true;
            this.dgvdatoscuenta.RowHeadersVisible = false;
            this.dgvdatoscuenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdatoscuenta.Size = new System.Drawing.Size(1065, 257);
            this.dgvdatoscuenta.TabIndex = 1;
            this.dgvdatoscuenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvdatoscuenta_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(626, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nombre";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_nombre);
            this.panel1.Controls.Add(this.txt_nomcucierre);
            this.panel1.Controls.Add(this.grupo_tipo);
            this.panel1.Controls.Add(this.check_cuentaret);
            this.panel1.Controls.Add(this.txt_nombrecuentacorre);
            this.panel1.Controls.Add(this.check_centro);
            this.panel1.Controls.Add(this.txt_nombrecuentaajuste);
            this.panel1.Controls.Add(this.txtconcerete);
            this.panel1.Controls.Add(this.check_pidenit);
            this.panel1.Controls.Add(this.check_ajustes);
            this.panel1.Controls.Add(this.txtdoc);
            this.panel1.Controls.Add(this.lblconrete);
            this.panel1.Controls.Add(this.txtnumcu);
            this.panel1.Controls.Add(this.lblporceret);
            this.panel1.Controls.Add(this.txtporcrete);
            this.panel1.Controls.Add(this.lblddoc);
            this.panel1.Controls.Add(this.lblcuencierr);
            this.panel1.Controls.Add(this.lblnumcue);
            this.panel1.Controls.Add(this.txtcierre);
            this.panel1.Controls.Add(this.txtcuncor);
            this.panel1.Controls.Add(this.lblcuencor);
            this.panel1.Controls.Add(this.txtcuenaju);
            this.panel1.Controls.Add(this.lblajucuen);
            this.panel1.Controls.Add(this.txtnitajus);
            this.panel1.Controls.Add(this.lblnitaju);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtnombre);
            this.panel1.Location = new System.Drawing.Point(10, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 216);
            this.panel1.TabIndex = 7;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(243, 10);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.ReadOnly = true;
            this.txt_nombre.Size = new System.Drawing.Size(364, 20);
            this.txt_nombre.TabIndex = 203;
            // 
            // txt_nomcucierre
            // 
            this.txt_nomcucierre.Enabled = false;
            this.txt_nomcucierre.Location = new System.Drawing.Point(386, 175);
            this.txt_nomcucierre.Name = "txt_nomcucierre";
            this.txt_nomcucierre.ReadOnly = true;
            this.txt_nomcucierre.Size = new System.Drawing.Size(298, 20);
            this.txt_nomcucierre.TabIndex = 204;
            // 
            // grupo_tipo
            // 
            this.grupo_tipo.Controls.Add(this.radio_detalle);
            this.grupo_tipo.Controls.Add(this.radio_general);
            this.grupo_tipo.Location = new System.Drawing.Point(127, 29);
            this.grupo_tipo.Name = "grupo_tipo";
            this.grupo_tipo.Size = new System.Drawing.Size(154, 33);
            this.grupo_tipo.TabIndex = 5;
            this.grupo_tipo.TabStop = false;
            // 
            // radio_detalle
            // 
            this.radio_detalle.AutoSize = true;
            this.radio_detalle.Enabled = false;
            this.radio_detalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_detalle.Location = new System.Drawing.Point(87, 11);
            this.radio_detalle.Name = "radio_detalle";
            this.radio_detalle.Size = new System.Drawing.Size(66, 17);
            this.radio_detalle.TabIndex = 7;
            this.radio_detalle.TabStop = true;
            this.radio_detalle.Text = "Auxiliar";
            this.radio_detalle.UseVisualStyleBackColor = true;
            this.radio_detalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // radio_general
            // 
            this.radio_general.AutoSize = true;
            this.radio_general.Enabled = false;
            this.radio_general.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_general.Location = new System.Drawing.Point(12, 11);
            this.radio_general.Name = "radio_general";
            this.radio_general.Size = new System.Drawing.Size(59, 17);
            this.radio_general.TabIndex = 6;
            this.radio_general.TabStop = true;
            this.radio_general.Text = "Mayor";
            this.radio_general.UseVisualStyleBackColor = true;
            this.radio_general.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // check_cuentaret
            // 
            this.check_cuentaret.AutoSize = true;
            this.check_cuentaret.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.check_cuentaret.Enabled = false;
            this.check_cuentaret.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_cuentaret.Location = new System.Drawing.Point(6, 152);
            this.check_cuentaret.Name = "check_cuentaret";
            this.check_cuentaret.Size = new System.Drawing.Size(146, 17);
            this.check_cuentaret.TabIndex = 12;
            this.check_cuentaret.Text = "Cuenta de Retención";
            this.check_cuentaret.UseVisualStyleBackColor = true;
            this.check_cuentaret.CheckedChanged += new System.EventHandler(this.Check_cuentaret_CheckedChanged);
            this.check_cuentaret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // txt_nombrecuentacorre
            // 
            this.txt_nombrecuentacorre.Enabled = false;
            this.txt_nombrecuentacorre.Location = new System.Drawing.Point(270, 122);
            this.txt_nombrecuentacorre.Name = "txt_nombrecuentacorre";
            this.txt_nombrecuentacorre.ReadOnly = true;
            this.txt_nombrecuentacorre.Size = new System.Drawing.Size(408, 20);
            this.txt_nombrecuentacorre.TabIndex = 202;
            // 
            // check_centro
            // 
            this.check_centro.AutoSize = true;
            this.check_centro.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.check_centro.Enabled = false;
            this.check_centro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_centro.Location = new System.Drawing.Point(626, 37);
            this.check_centro.Name = "check_centro";
            this.check_centro.Size = new System.Drawing.Size(168, 17);
            this.check_centro.TabIndex = 9;
            this.check_centro.Text = "Maneja Centro de Costos";
            this.check_centro.UseVisualStyleBackColor = true;
            this.check_centro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // txt_nombrecuentaajuste
            // 
            this.txt_nombrecuentaajuste.Enabled = false;
            this.txt_nombrecuentaajuste.Location = new System.Drawing.Point(270, 92);
            this.txt_nombrecuentaajuste.Name = "txt_nombrecuentaajuste";
            this.txt_nombrecuentaajuste.ReadOnly = true;
            this.txt_nombrecuentaajuste.Size = new System.Drawing.Size(408, 20);
            this.txt_nombrecuentaajuste.TabIndex = 200;
            // 
            // txtconcerete
            // 
            this.txtconcerete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtconcerete.Enabled = false;
            this.txtconcerete.Location = new System.Drawing.Point(701, 150);
            this.txtconcerete.Name = "txtconcerete";
            this.txtconcerete.Size = new System.Drawing.Size(277, 20);
            this.txtconcerete.TabIndex = 14;
            this.txtconcerete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // check_pidenit
            // 
            this.check_pidenit.AutoSize = true;
            this.check_pidenit.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.check_pidenit.Enabled = false;
            this.check_pidenit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_pidenit.Location = new System.Drawing.Point(362, 37);
            this.check_pidenit.Name = "check_pidenit";
            this.check_pidenit.Size = new System.Drawing.Size(76, 17);
            this.check_pidenit.TabIndex = 8;
            this.check_pidenit.Text = "Pide NIT";
            this.check_pidenit.UseVisualStyleBackColor = true;
            this.check_pidenit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // check_ajustes
            // 
            this.check_ajustes.AutoSize = true;
            this.check_ajustes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.check_ajustes.Enabled = false;
            this.check_ajustes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_ajustes.Location = new System.Drawing.Point(6, 66);
            this.check_ajustes.Name = "check_ajustes";
            this.check_ajustes.Size = new System.Drawing.Size(163, 17);
            this.check_ajustes.TabIndex = 9;
            this.check_ajustes.Text = "Tiene Ajustes Integrales";
            this.check_ajustes.UseVisualStyleBackColor = true;
            this.check_ajustes.CheckedChanged += new System.EventHandler(this.Check_ajustes_CheckedChanged);
            this.check_ajustes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // txtdoc
            // 
            this.txtdoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdoc.Enabled = false;
            this.txtdoc.Location = new System.Drawing.Point(701, 64);
            this.txtdoc.MaxLength = 1;
            this.txtdoc.Name = "txtdoc";
            this.txtdoc.Size = new System.Drawing.Size(29, 20);
            this.txtdoc.TabIndex = 11;
            this.txtdoc.Text = "D";
            this.txtdoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtdoc_KeyPress);
            // 
            // lblconrete
            // 
            this.lblconrete.AutoSize = true;
            this.lblconrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconrete.Location = new System.Drawing.Point(550, 154);
            this.lblconrete.Name = "lblconrete";
            this.lblconrete.Size = new System.Drawing.Size(141, 13);
            this.lblconrete.TabIndex = 31;
            this.lblconrete.Text = "Concepto de Retención";
            // 
            // txtnumcu
            // 
            this.txtnumcu.Enabled = false;
            this.txtnumcu.Location = new System.Drawing.Point(127, 10);
            this.txtnumcu.MaxLength = 12;
            this.txtnumcu.Name = "txtnumcu";
            this.txtnumcu.Size = new System.Drawing.Size(110, 20);
            this.txtnumcu.TabIndex = 3;
            this.txtnumcu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaCuenta_KeyPress);
            this.txtnumcu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtnumcu_KeyUp);
            // 
            // lblporceret
            // 
            this.lblporceret.AutoSize = true;
            this.lblporceret.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblporceret.Location = new System.Drawing.Point(216, 154);
            this.lblporceret.Name = "lblporceret";
            this.lblporceret.Size = new System.Drawing.Size(152, 13);
            this.lblporceret.TabIndex = 30;
            this.lblporceret.Text = "Porcentaje de Retención ";
            // 
            // txtporcrete
            // 
            this.txtporcrete.Enabled = false;
            this.txtporcrete.Location = new System.Drawing.Point(385, 150);
            this.txtporcrete.MaxLength = 10;
            this.txtporcrete.Name = "txtporcrete";
            this.txtporcrete.Size = new System.Drawing.Size(100, 20);
            this.txtporcrete.TabIndex = 13;
            this.txtporcrete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtporcrete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterValidacion_KeyPress);
            // 
            // lblddoc
            // 
            this.lblddoc.AutoSize = true;
            this.lblddoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblddoc.Location = new System.Drawing.Point(623, 68);
            this.lblddoc.Name = "lblddoc";
            this.lblddoc.Size = new System.Drawing.Size(41, 13);
            this.lblddoc.TabIndex = 28;
            this.lblddoc.Text = "D O C";
            // 
            // lblcuencierr
            // 
            this.lblcuencierr.AutoSize = true;
            this.lblcuencierr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcuencierr.Location = new System.Drawing.Point(6, 182);
            this.lblcuencierr.Name = "lblcuencierr";
            this.lblcuencierr.Size = new System.Drawing.Size(184, 13);
            this.lblcuencierr.TabIndex = 32;
            this.lblcuencierr.Text = "Cuenta del Cierre de Impuestos";
            // 
            // lblnumcue
            // 
            this.lblnumcue.AutoSize = true;
            this.lblnumcue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumcue.Location = new System.Drawing.Point(6, 14);
            this.lblnumcue.Name = "lblnumcue";
            this.lblnumcue.Size = new System.Drawing.Size(116, 13);
            this.lblnumcue.TabIndex = 22;
            this.lblnumcue.Text = "Numero de Cuenta ";
            // 
            // txtcierre
            // 
            this.txtcierre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtcierre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtcierre.Enabled = false;
            this.txtcierre.Location = new System.Drawing.Point(225, 175);
            this.txtcierre.MaxLength = 12;
            this.txtcierre.Name = "txtcierre";
            this.txtcierre.Size = new System.Drawing.Size(136, 20);
            this.txtcierre.TabIndex = 15;
            this.txtcierre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValidaCuentaCierre_KeyDown);
            this.txtcierre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcierre_KeyPress);
            // 
            // txtcuncor
            // 
            this.txtcuncor.AcceptsTab = true;
            this.txtcuncor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtcuncor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtcuncor.Enabled = false;
            this.txtcuncor.Location = new System.Drawing.Point(142, 122);
            this.txtcuncor.MaxLength = 12;
            this.txtcuncor.Name = "txtcuncor";
            this.txtcuncor.Size = new System.Drawing.Size(100, 20);
            this.txtcuncor.TabIndex = 11;
            this.txtcuncor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValidaCuentaCorrec_KeyDown);
            this.txtcuncor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcuncor_KeyPress);
            // 
            // lblcuencor
            // 
            this.lblcuencor.AutoSize = true;
            this.lblcuencor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcuencor.Location = new System.Drawing.Point(6, 126);
            this.lblcuencor.Name = "lblcuencor";
            this.lblcuencor.Size = new System.Drawing.Size(123, 13);
            this.lblcuencor.TabIndex = 27;
            this.lblcuencor.Text = "Cuenta de Correción";
            // 
            // txtcuenaju
            // 
            this.txtcuenaju.AcceptsTab = true;
            this.txtcuenaju.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtcuenaju.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtcuenaju.Enabled = false;
            this.txtcuenaju.Location = new System.Drawing.Point(142, 92);
            this.txtcuenaju.MaxLength = 12;
            this.txtcuenaju.Name = "txtcuenaju";
            this.txtcuenaju.Size = new System.Drawing.Size(100, 20);
            this.txtcuenaju.TabIndex = 10;
            this.txtcuenaju.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValidaCuentaAjuste_KeyDown);
            this.txtcuenaju.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcuenaju_KeyPress);
            // 
            // lblajucuen
            // 
            this.lblajucuen.AutoSize = true;
            this.lblajucuen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblajucuen.Location = new System.Drawing.Point(6, 96);
            this.lblajucuen.Name = "lblajucuen";
            this.lblajucuen.Size = new System.Drawing.Size(123, 13);
            this.lblajucuen.TabIndex = 26;
            this.lblajucuen.Text = "Cuenta Ajuste PAAG";
            // 
            // txtnitajus
            // 
            this.txtnitajus.Enabled = false;
            this.txtnitajus.Location = new System.Drawing.Point(439, 64);
            this.txtnitajus.MaxLength = 12;
            this.txtnitajus.Name = "txtnitajus";
            this.txtnitajus.Size = new System.Drawing.Size(100, 20);
            this.txtnitajus.TabIndex = 10;
            this.txtnitajus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterValidacion_KeyPress);
            // 
            // lblnitaju
            // 
            this.lblnitaju.AutoSize = true;
            this.lblnitaju.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnitaju.Location = new System.Drawing.Point(270, 68);
            this.lblnitaju.Name = "lblnitaju";
            this.lblnitaju.Size = new System.Drawing.Size(153, 13);
            this.lblnitaju.TabIndex = 25;
            this.lblnitaju.Text = "NIT Para Acumular Ajuste";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tipo de Cuenta ";
            // 
            // txtnombre
            // 
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(696, 10);
            this.txtnombre.MaxLength = 65;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(360, 20);
            this.txtnombre.TabIndex = 4;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(871, 6);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(151, 20);
            this.txt_buscar.TabIndex = 12;
            this.txt_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_buscar_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_nuevo);
            this.panel3.Controls.Add(this.btn_editar);
            this.panel3.Controls.Add(this.btn_buscar);
            this.panel3.Controls.Add(this.btn_imprimir);
            this.panel3.Controls.Add(this.txt_buscar);
            this.panel3.Controls.Add(this.btn_eliminar);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1063, 34);
            this.panel3.TabIndex = 16;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_nuevo.Image = global::App.Properties.Resources.agregar1;
            this.btn_nuevo.Location = new System.Drawing.Point(3, 1);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(25, 28);
            this.btn_nuevo.TabIndex = 9;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Enabled = false;
            this.btn_editar.Image = global::App.Properties.Resources.editar;
            this.btn_editar.Location = new System.Drawing.Point(34, 2);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(24, 26);
            this.btn_editar.TabIndex = 10;
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = global::App.Properties.Resources.search;
            this.btn_buscar.Location = new System.Drawing.Point(1028, 3);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(28, 25);
            this.btn_buscar.TabIndex = 13;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Image = global::App.Properties.Resources.printer;
            this.btn_imprimir.Location = new System.Drawing.Point(98, 2);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(25, 26);
            this.btn_imprimir.TabIndex = 14;
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Enabled = false;
            this.btn_eliminar.Image = global::App.Properties.Resources.eliminar;
            this.btn_eliminar.Location = new System.Drawing.Point(64, 2);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(28, 26);
            this.btn_eliminar.TabIndex = 11;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_guardar);
            this.panel2.Controls.Add(this.salircuent);
            this.panel2.Location = new System.Drawing.Point(971, 552);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(104, 46);
            this.panel2.TabIndex = 13;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Enabled = false;
            this.btn_guardar.Image = global::App.Properties.Resources.Save;
            this.btn_guardar.Location = new System.Drawing.Point(3, 4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(35, 33);
            this.btn_guardar.TabIndex = 14;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // salircuent
            // 
            this.salircuent.Image = global::App.Properties.Resources.exit;
            this.salircuent.Location = new System.Drawing.Point(56, 4);
            this.salircuent.Name = "salircuent";
            this.salircuent.Size = new System.Drawing.Size(43, 32);
            this.salircuent.TabIndex = 15;
            this.salircuent.UseVisualStyleBackColor = true;
            this.salircuent.Click += new System.EventHandler(this.Salircuent_Click);
            // 
            // panel_princip
            // 
            this.panel_princip.AutoSize = true;
            this.panel_princip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_princip.Controls.Add(this.panel2);
            this.panel_princip.Controls.Add(this.dgvdatoscuenta);
            this.panel_princip.Controls.Add(this.panel3);
            this.panel_princip.Controls.Add(this.panel1);
            this.panel_princip.Location = new System.Drawing.Point(0, 5);
            this.panel_princip.Name = "panel_princip";
            this.panel_princip.Size = new System.Drawing.Size(1089, 606);
            this.panel_princip.TabIndex = 41;
            // 
            // Frmcuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1097, 615);
            this.Controls.Add(this.panel_princip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmcuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CUENTAS O PUC ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frmcuenta_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatoscuenta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grupo_tipo.ResumeLayout(false);
            this.grupo_tipo.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel_princip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salircuent;
        private System.Windows.Forms.DataGridView dgvdatoscuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.TextBox txtcuenaju;
        private System.Windows.Forms.Label lblajucuen;
        private System.Windows.Forms.TextBox txtnitajus;
        private System.Windows.Forms.Label lblnitaju;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtcuncor;
        private System.Windows.Forms.Label lblcuencor;
        private System.Windows.Forms.TextBox txtcierre;
        private System.Windows.Forms.Label lblcuencierr;
        private System.Windows.Forms.TextBox txtdoc;
        private System.Windows.Forms.Label lblddoc;
        private System.Windows.Forms.TextBox txtporcrete;
        private System.Windows.Forms.Label lblporceret;
        private System.Windows.Forms.TextBox txtconcerete;
        private System.Windows.Forms.Label lblconrete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtnumcu;
        private System.Windows.Forms.Label lblnumcue;
        private System.Windows.Forms.CheckBox check_pidenit;
        private System.Windows.Forms.CheckBox check_centro;
        private System.Windows.Forms.CheckBox check_ajustes;
        private System.Windows.Forms.CheckBox check_cuentaret;
        private System.Windows.Forms.Panel panel_princip;
        private System.Windows.Forms.TextBox txt_nombrecuentacorre;
        private System.Windows.Forms.TextBox txt_nombrecuentaajuste;
        private System.Windows.Forms.RadioButton radio_detalle;
        private System.Windows.Forms.RadioButton radio_general;
        private System.Windows.Forms.GroupBox grupo_tipo;
        private System.Windows.Forms.TextBox txt_nomcucierre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txtnombre;
    }
}