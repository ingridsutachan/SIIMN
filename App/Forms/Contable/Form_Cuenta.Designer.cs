﻿////*********************************************************
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
    partial class Form_Cuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cuenta));
            this.menu_botones = new System.Windows.Forms.ToolStrip();
            this.btn_nuevo = new System.Windows.Forms.ToolStripButton();
            this.btn_editar = new System.Windows.Forms.ToolStripButton();
            this.btn_eliminar = new System.Windows.Forms.ToolStripButton();
            this.btn_buscar = new System.Windows.Forms.ToolStripButton();
            this.btn_imprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.btn_cancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.txt_nombrecuenta = new System.Windows.Forms.TextBox();
            this.grupo_tipo = new System.Windows.Forms.GroupBox();
            this.radio_detalle = new System.Windows.Forms.RadioButton();
            this.radio_general = new System.Windows.Forms.RadioButton();
            this.check_cuentaret = new System.Windows.Forms.CheckBox();
            this.txtnumcu = new System.Windows.Forms.TextBox();
            this.lblporceret = new System.Windows.Forms.Label();
            this.txtporcrete = new System.Windows.Forms.TextBox();
            this.lblnumcue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.gb_ajustes = new System.Windows.Forms.GroupBox();
            this.txt_nombrenit = new System.Windows.Forms.TextBox();
            this.check_ajustes = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombrecuentaajuste = new System.Windows.Forms.TextBox();
            this.txtnitajus = new System.Windows.Forms.TextBox();
            this.txtdoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nombrecuentacorre = new System.Windows.Forms.TextBox();
            this.txtcuenaju = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcuncor = new System.Windows.Forms.TextBox();
            this.gb_check = new System.Windows.Forms.GroupBox();
            this.check_centro = new System.Windows.Forms.CheckBox();
            this.check_pidenit = new System.Windows.Forms.CheckBox();
            this.gb_retencion = new System.Windows.Forms.GroupBox();
            this.lblconrete = new System.Windows.Forms.Label();
            this.txtconcerete = new System.Windows.Forms.TextBox();
            this.check_reteica = new System.Windows.Forms.CheckBox();
            this.txt_mediosmag = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_poreteica = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_conreteica = new System.Windows.Forms.TextBox();
            this.txtcierre = new System.Windows.Forms.TextBox();
            this.lblcuencierr = new System.Windows.Forms.Label();
            this.txt_nomcucierre = new System.Windows.Forms.TextBox();
            this.menu_botones.SuspendLayout();
            this.grupo_tipo.SuspendLayout();
            this.gb_ajustes.SuspendLayout();
            this.gb_check.SuspendLayout();
            this.gb_retencion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.btn_guardar,
            this.btn_cancelar,
            this.toolStripSeparator2,
            this.btn_salir});
            this.menu_botones.Location = new System.Drawing.Point(0, 0);
            this.menu_botones.Name = "menu_botones";
            this.menu_botones.Size = new System.Drawing.Size(949, 31);
            this.menu_botones.TabIndex = 64;
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
            this.btn_editar.Image = global::App.Properties.Resources.edit24;
            this.btn_editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(28, 28);
            this.btn_editar.Text = "Editar";
            this.btn_editar.ToolTipText = "Editar(Ctrl+E)";
            this.btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_eliminar.Image = global::App.Properties.Resources.delete24;
            this.btn_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(28, 28);
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.ToolTipText = "Eliminar(Ctrl+D)";
            this.btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
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
            this.btn_imprimir.Image = global::App.Properties.Resources.printer24;
            this.btn_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(28, 28);
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.ToolTipText = "Imprimir (Ctrl+P)";
            this.btn_imprimir.Click += new System.EventHandler(this.Btn_imprimir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
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
            // txt_nombrecuenta
            // 
            this.txt_nombrecuenta.Enabled = false;
            this.txt_nombrecuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombrecuenta.Location = new System.Drawing.Point(265, 41);
            this.txt_nombrecuenta.Name = "txt_nombrecuenta";
            this.txt_nombrecuenta.ReadOnly = true;
            this.txt_nombrecuenta.Size = new System.Drawing.Size(364, 20);
            this.txt_nombrecuenta.TabIndex = 2;
            // 
            // grupo_tipo
            // 
            this.grupo_tipo.Controls.Add(this.radio_detalle);
            this.grupo_tipo.Controls.Add(this.radio_general);
            this.grupo_tipo.Location = new System.Drawing.Point(127, 90);
            this.grupo_tipo.Name = "grupo_tipo";
            this.grupo_tipo.Size = new System.Drawing.Size(176, 33);
            this.grupo_tipo.TabIndex = 4;
            this.grupo_tipo.TabStop = false;
            this.grupo_tipo.Leave += new System.EventHandler(this.TipoCuenta_Leave);
            // 
            // radio_detalle
            // 
            this.radio_detalle.AutoSize = true;
            this.radio_detalle.Enabled = false;
            this.radio_detalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_detalle.Location = new System.Drawing.Point(87, 11);
            this.radio_detalle.Name = "radio_detalle";
            this.radio_detalle.Size = new System.Drawing.Size(82, 17);
            this.radio_detalle.TabIndex = 6;
            this.radio_detalle.TabStop = true;
            this.radio_detalle.Text = "AUXILIAR";
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
            this.radio_general.Size = new System.Drawing.Size(69, 17);
            this.radio_general.TabIndex = 5;
            this.radio_general.TabStop = true;
            this.radio_general.Text = "MAYOR";
            this.radio_general.UseVisualStyleBackColor = true;
            this.radio_general.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // check_cuentaret
            // 
            this.check_cuentaret.AutoSize = true;
            this.check_cuentaret.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.check_cuentaret.Enabled = false;
            this.check_cuentaret.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_cuentaret.Location = new System.Drawing.Point(9, 19);
            this.check_cuentaret.Name = "check_cuentaret";
            this.check_cuentaret.Size = new System.Drawing.Size(173, 17);
            this.check_cuentaret.TabIndex = 20;
            this.check_cuentaret.Text = "CUENTA DE RETENCION";
            this.check_cuentaret.UseVisualStyleBackColor = true;
            this.check_cuentaret.CheckedChanged += new System.EventHandler(this.Check_cuentaret_CheckedChanged);
            this.check_cuentaret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // txtnumcu
            // 
            this.txtnumcu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtnumcu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtnumcu.Enabled = false;
            this.txtnumcu.Location = new System.Drawing.Point(149, 41);
            this.txtnumcu.MaxLength = 10;
            this.txtnumcu.Name = "txtnumcu";
            this.txtnumcu.Size = new System.Drawing.Size(110, 20);
            this.txtnumcu.TabIndex = 1;
            this.txtnumcu.Enter += new System.EventHandler(this.Txt_cuenta_Enter);
            this.txtnumcu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtnumcu_KeyDown);
            this.txtnumcu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterValidacion_KeyPress);
            this.txtnumcu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtnumcu_KeyUp);
            this.txtnumcu.Leave += new System.EventHandler(this.TxtNumcu_Leave);
            // 
            // lblporceret
            // 
            this.lblporceret.AutoSize = true;
            this.lblporceret.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblporceret.Location = new System.Drawing.Point(9, 50);
            this.lblporceret.Name = "lblporceret";
            this.lblporceret.Size = new System.Drawing.Size(185, 13);
            this.lblporceret.TabIndex = 36;
            this.lblporceret.Text = "PORCENTAJE DE RETENCION";
            // 
            // txtporcrete
            // 
            this.txtporcrete.Enabled = false;
            this.txtporcrete.Location = new System.Drawing.Point(200, 46);
            this.txtporcrete.MaxLength = 5;
            this.txtporcrete.Name = "txtporcrete";
            this.txtporcrete.Size = new System.Drawing.Size(100, 20);
            this.txtporcrete.TabIndex = 21;
            this.txtporcrete.Text = "00,00";
            this.txtporcrete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtporcrete.Enter += new System.EventHandler(this.Txtporcrete_Enter);
            this.txtporcrete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtporcrete_KeyPress);
            this.txtporcrete.Leave += new System.EventHandler(this.Txtporcrete_Leave);
            // 
            // lblnumcue
            // 
            this.lblnumcue.AutoSize = true;
            this.lblnumcue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumcue.Location = new System.Drawing.Point(7, 45);
            this.lblnumcue.Name = "lblnumcue";
            this.lblnumcue.Size = new System.Drawing.Size(140, 13);
            this.lblnumcue.TabIndex = 29;
            this.lblnumcue.Text = "NUMERO DE CUENTA ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "TIPO DE CUENTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "NOMBRE";
            // 
            // txtnombre
            // 
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(74, 69);
            this.txtnombre.MaxLength = 70;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(457, 20);
            this.txtnombre.TabIndex = 3;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            this.txtnombre.Leave += new System.EventHandler(this.ValidaVacio_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, -49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "ADICION DE CUENTAS:  ";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(159, -49);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(60, 13);
            this.lbl_nombre.TabIndex = 28;
            this.lbl_nombre.Text = "NOMBRE";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(949, 456);
            this.shapeContainer1.TabIndex = 235;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -28;
            this.lineShape1.X2 = 1097;
            this.lineShape1.Y1 = 130;
            this.lineShape1.Y2 = 128;
            // 
            // gb_ajustes
            // 
            this.gb_ajustes.Controls.Add(this.txt_nombrenit);
            this.gb_ajustes.Controls.Add(this.check_ajustes);
            this.gb_ajustes.Controls.Add(this.label4);
            this.gb_ajustes.Controls.Add(this.txt_nombrecuentaajuste);
            this.gb_ajustes.Controls.Add(this.txtnitajus);
            this.gb_ajustes.Controls.Add(this.txtdoc);
            this.gb_ajustes.Controls.Add(this.label5);
            this.gb_ajustes.Controls.Add(this.txt_nombrecuentacorre);
            this.gb_ajustes.Controls.Add(this.txtcuenaju);
            this.gb_ajustes.Controls.Add(this.label7);
            this.gb_ajustes.Controls.Add(this.label6);
            this.gb_ajustes.Controls.Add(this.txtcuncor);
            this.gb_ajustes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_ajustes.Location = new System.Drawing.Point(6, 140);
            this.gb_ajustes.Name = "gb_ajustes";
            this.gb_ajustes.Size = new System.Drawing.Size(459, 236);
            this.gb_ajustes.TabIndex = 10;
            this.gb_ajustes.TabStop = false;
            this.gb_ajustes.Text = "AJUSTES INTEGRALES";
            // 
            // txt_nombrenit
            // 
            this.txt_nombrenit.Enabled = false;
            this.txt_nombrenit.Location = new System.Drawing.Point(6, 84);
            this.txt_nombrenit.Name = "txt_nombrenit";
            this.txt_nombrenit.ReadOnly = true;
            this.txt_nombrenit.Size = new System.Drawing.Size(408, 20);
            this.txt_nombrenit.TabIndex = 14;
            // 
            // check_ajustes
            // 
            this.check_ajustes.AutoSize = true;
            this.check_ajustes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.check_ajustes.Enabled = false;
            this.check_ajustes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_ajustes.Location = new System.Drawing.Point(6, 30);
            this.check_ajustes.Name = "check_ajustes";
            this.check_ajustes.Size = new System.Drawing.Size(204, 17);
            this.check_ajustes.TabIndex = 11;
            this.check_ajustes.Text = "TIENE AJUSTES INTEGRALES";
            this.check_ajustes.UseVisualStyleBackColor = true;
            this.check_ajustes.CheckedChanged += new System.EventHandler(this.Check_ajustes_CheckedChanged);
            this.check_ajustes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "NIT PARA ACUMULAR AJUSTE";
            // 
            // txt_nombrecuentaajuste
            // 
            this.txt_nombrecuentaajuste.Enabled = false;
            this.txt_nombrecuentaajuste.Location = new System.Drawing.Point(6, 139);
            this.txt_nombrecuentaajuste.Name = "txt_nombrecuentaajuste";
            this.txt_nombrecuentaajuste.ReadOnly = true;
            this.txt_nombrecuentaajuste.Size = new System.Drawing.Size(408, 20);
            this.txt_nombrecuentaajuste.TabIndex = 16;
            // 
            // txtnitajus
            // 
            this.txtnitajus.Enabled = false;
            this.txtnitajus.Location = new System.Drawing.Point(200, 56);
            this.txtnitajus.MaxLength = 12;
            this.txtnitajus.Name = "txtnitajus";
            this.txtnitajus.Size = new System.Drawing.Size(100, 20);
            this.txtnitajus.TabIndex = 12;
            this.txtnitajus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidacionNumerico_KeyPress);
            this.txtnitajus.Leave += new System.EventHandler(this.Txtnitajus_Leave);
            // 
            // txtdoc
            // 
            this.txtdoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdoc.Enabled = false;
            this.txtdoc.Location = new System.Drawing.Point(385, 53);
            this.txtdoc.MaxLength = 1;
            this.txtdoc.Name = "txtdoc";
            this.txtdoc.Size = new System.Drawing.Size(29, 20);
            this.txtdoc.TabIndex = 13;
            this.txtdoc.Text = "D";
            this.txtdoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtdoc_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "CUENTA AJUSTE PAAG";
            // 
            // txt_nombrecuentacorre
            // 
            this.txt_nombrecuentacorre.Enabled = false;
            this.txt_nombrecuentacorre.Location = new System.Drawing.Point(6, 202);
            this.txt_nombrecuentacorre.Name = "txt_nombrecuentacorre";
            this.txt_nombrecuentacorre.ReadOnly = true;
            this.txt_nombrecuentacorre.Size = new System.Drawing.Size(408, 20);
            this.txt_nombrecuentacorre.TabIndex = 18;
            // 
            // txtcuenaju
            // 
            this.txtcuenaju.AcceptsTab = true;
            this.txtcuenaju.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtcuenaju.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtcuenaju.Enabled = false;
            this.txtcuenaju.Location = new System.Drawing.Point(167, 110);
            this.txtcuenaju.MaxLength = 10;
            this.txtcuenaju.Name = "txtcuenaju";
            this.txtcuenaju.Size = new System.Drawing.Size(100, 20);
            this.txtcuenaju.TabIndex = 15;
            this.txtcuenaju.Enter += new System.EventHandler(this.Txt_cuenta_Enter);
            this.txtcuenaju.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtcuenta_KeyDown);
            this.txtcuenaju.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterValidacion_KeyPress);
            this.txtcuenaju.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtcuenta_KeyUp);
            this.txtcuenaju.Leave += new System.EventHandler(this.Txtcuenta_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(325, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "D O C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "CUENTA DE CORRECION";
            // 
            // txtcuncor
            // 
            this.txtcuncor.AcceptsTab = true;
            this.txtcuncor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtcuncor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtcuncor.Enabled = false;
            this.txtcuncor.Location = new System.Drawing.Point(167, 173);
            this.txtcuncor.MaxLength = 10;
            this.txtcuncor.Name = "txtcuncor";
            this.txtcuncor.Size = new System.Drawing.Size(100, 20);
            this.txtcuncor.TabIndex = 17;
            this.txtcuncor.Enter += new System.EventHandler(this.Txt_cuenta_Enter);
            this.txtcuncor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtcuenta_KeyDown);
            this.txtcuncor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterValidacion_KeyPress);
            this.txtcuncor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtcuenta_KeyUp);
            this.txtcuncor.Leave += new System.EventHandler(this.Txtcuenta_Leave);
            // 
            // gb_check
            // 
            this.gb_check.Controls.Add(this.check_centro);
            this.gb_check.Controls.Add(this.check_pidenit);
            this.gb_check.Location = new System.Drawing.Point(704, 34);
            this.gb_check.Name = "gb_check";
            this.gb_check.Size = new System.Drawing.Size(233, 84);
            this.gb_check.TabIndex = 7;
            this.gb_check.TabStop = false;
            // 
            // check_centro
            // 
            this.check_centro.AutoSize = true;
            this.check_centro.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.check_centro.Enabled = false;
            this.check_centro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_centro.Location = new System.Drawing.Point(6, 50);
            this.check_centro.Name = "check_centro";
            this.check_centro.Size = new System.Drawing.Size(205, 17);
            this.check_centro.TabIndex = 9;
            this.check_centro.Text = "MANEJA CENTRO DE COSTOS";
            this.check_centro.UseVisualStyleBackColor = true;
            this.check_centro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // check_pidenit
            // 
            this.check_pidenit.AutoSize = true;
            this.check_pidenit.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.check_pidenit.Enabled = false;
            this.check_pidenit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_pidenit.Location = new System.Drawing.Point(6, 19);
            this.check_pidenit.Name = "check_pidenit";
            this.check_pidenit.Size = new System.Drawing.Size(80, 17);
            this.check_pidenit.TabIndex = 8;
            this.check_pidenit.Text = "PIDE NIT";
            this.check_pidenit.UseVisualStyleBackColor = true;
            this.check_pidenit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // gb_retencion
            // 
            this.gb_retencion.Controls.Add(this.lblconrete);
            this.gb_retencion.Controls.Add(this.txtconcerete);
            this.gb_retencion.Controls.Add(this.check_cuentaret);
            this.gb_retencion.Controls.Add(this.txtporcrete);
            this.gb_retencion.Controls.Add(this.lblporceret);
            this.gb_retencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_retencion.Location = new System.Drawing.Point(471, 140);
            this.gb_retencion.Name = "gb_retencion";
            this.gb_retencion.Size = new System.Drawing.Size(475, 104);
            this.gb_retencion.TabIndex = 19;
            this.gb_retencion.TabStop = false;
            this.gb_retencion.Text = "RETENCIÓN";
            // 
            // lblconrete
            // 
            this.lblconrete.AutoSize = true;
            this.lblconrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconrete.Location = new System.Drawing.Point(9, 79);
            this.lblconrete.Name = "lblconrete";
            this.lblconrete.Size = new System.Drawing.Size(171, 13);
            this.lblconrete.TabIndex = 242;
            this.lblconrete.Text = "CONCEPTO DE RETENCION";
            // 
            // txtconcerete
            // 
            this.txtconcerete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtconcerete.Enabled = false;
            this.txtconcerete.Location = new System.Drawing.Point(200, 75);
            this.txtconcerete.MaxLength = 70;
            this.txtconcerete.Name = "txtconcerete";
            this.txtconcerete.Size = new System.Drawing.Size(260, 20);
            this.txtconcerete.TabIndex = 22;
            this.txtconcerete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            this.txtconcerete.Leave += new System.EventHandler(this.ValidaVacio_Leave);
            // 
            // check_reteica
            // 
            this.check_reteica.AutoSize = true;
            this.check_reteica.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.check_reteica.Enabled = false;
            this.check_reteica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_reteica.Location = new System.Drawing.Point(9, 29);
            this.check_reteica.Name = "check_reteica";
            this.check_reteica.Size = new System.Drawing.Size(79, 17);
            this.check_reteica.TabIndex = 24;
            this.check_reteica.Text = "RETEICA";
            this.check_reteica.UseVisualStyleBackColor = true;
            this.check_reteica.CheckedChanged += new System.EventHandler(this.Check_reteica_CheckedChanged);
            this.check_reteica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // txt_mediosmag
            // 
            this.txt_mediosmag.Enabled = false;
            this.txt_mediosmag.Location = new System.Drawing.Point(284, 382);
            this.txt_mediosmag.MaxLength = 6;
            this.txt_mediosmag.Name = "txt_mediosmag";
            this.txt_mediosmag.Size = new System.Drawing.Size(136, 20);
            this.txt_mediosmag.TabIndex = 27;
            this.txt_mediosmag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidacionNumerico_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "FORMATO DE MEDIOS MAGNETICOS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.check_reteica);
            this.groupBox1.Controls.Add(this.txt_poreteica);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_conreteica);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(471, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 126);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RETEICA";
            // 
            // txt_poreteica
            // 
            this.txt_poreteica.Enabled = false;
            this.txt_poreteica.Location = new System.Drawing.Point(194, 52);
            this.txt_poreteica.MaxLength = 5;
            this.txt_poreteica.Name = "txt_poreteica";
            this.txt_poreteica.Size = new System.Drawing.Size(100, 20);
            this.txt_poreteica.TabIndex = 25;
            this.txt_poreteica.Text = "00,00";
            this.txt_poreteica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_poreteica.Enter += new System.EventHandler(this.Txtporcrete_Enter);
            this.txt_poreteica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtporcrete_KeyPress);
            this.txt_poreteica.Leave += new System.EventHandler(this.Txtporcrete_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "TANTO X MIL A RETENER";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "CONCEPTO DE RETENCION";
            // 
            // txt_conreteica
            // 
            this.txt_conreteica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_conreteica.Enabled = false;
            this.txt_conreteica.Location = new System.Drawing.Point(194, 82);
            this.txt_conreteica.MaxLength = 70;
            this.txt_conreteica.Name = "txt_conreteica";
            this.txt_conreteica.Size = new System.Drawing.Size(260, 20);
            this.txt_conreteica.TabIndex = 26;
            this.txt_conreteica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            this.txt_conreteica.Leave += new System.EventHandler(this.ValidaVacio_Leave);
            // 
            // txtcierre
            // 
            this.txtcierre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtcierre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtcierre.Enabled = false;
            this.txtcierre.Location = new System.Drawing.Point(284, 417);
            this.txtcierre.MaxLength = 10;
            this.txtcierre.Name = "txtcierre";
            this.txtcierre.Size = new System.Drawing.Size(136, 20);
            this.txtcierre.TabIndex = 28;
            // 
            // lblcuencierr
            // 
            this.lblcuencierr.AutoSize = true;
            this.lblcuencierr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcuencierr.Location = new System.Drawing.Point(9, 421);
            this.lblcuencierr.Name = "lblcuencierr";
            this.lblcuencierr.Size = new System.Drawing.Size(232, 13);
            this.lblcuencierr.TabIndex = 241;
            this.lblcuencierr.Text = "CUENTA DEL CIERRE DE IMPUESTOS";
            // 
            // txt_nomcucierre
            // 
            this.txt_nomcucierre.Enabled = false;
            this.txt_nomcucierre.Location = new System.Drawing.Point(436, 417);
            this.txt_nomcucierre.Name = "txt_nomcucierre";
            this.txt_nomcucierre.ReadOnly = true;
            this.txt_nomcucierre.Size = new System.Drawing.Size(329, 20);
            this.txt_nomcucierre.TabIndex = 239;
            // 
            // Form_Cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(949, 456);
            this.Controls.Add(this.txtcierre);
            this.Controls.Add(this.lblcuencierr);
            this.Controls.Add(this.txt_nomcucierre);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_mediosmag);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gb_check);
            this.Controls.Add(this.gb_retencion);
            this.Controls.Add(this.gb_ajustes);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombrecuenta);
            this.Controls.Add(this.grupo_tipo);
            this.Controls.Add(this.txtnumcu);
            this.Controls.Add(this.lblnumcue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.menu_botones);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Cuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CUENTAS O PUC ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frmcuenta_FormClosing);
            this.menu_botones.ResumeLayout(false);
            this.menu_botones.PerformLayout();
            this.grupo_tipo.ResumeLayout(false);
            this.grupo_tipo.PerformLayout();
            this.gb_ajustes.ResumeLayout(false);
            this.gb_ajustes.PerformLayout();
            this.gb_check.ResumeLayout(false);
            this.gb_check.PerformLayout();
            this.gb_retencion.ResumeLayout(false);
            this.gb_retencion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menu_botones;
        private System.Windows.Forms.ToolStripButton btn_nuevo;
        private System.Windows.Forms.ToolStripButton btn_editar;
        private System.Windows.Forms.ToolStripButton btn_eliminar;
        private System.Windows.Forms.ToolStripButton btn_buscar;
        private System.Windows.Forms.ToolStripButton btn_imprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_guardar;
        private System.Windows.Forms.ToolStripButton btn_cancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private System.Windows.Forms.TextBox txt_nombrecuenta;
        private System.Windows.Forms.GroupBox grupo_tipo;
        private System.Windows.Forms.RadioButton radio_detalle;
        private System.Windows.Forms.RadioButton radio_general;
        private System.Windows.Forms.CheckBox check_cuentaret;
        private System.Windows.Forms.TextBox txtnumcu;
        private System.Windows.Forms.Label lblporceret;
        private System.Windows.Forms.TextBox txtporcrete;
        private System.Windows.Forms.Label lblnumcue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_nombre;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.GroupBox gb_ajustes;
        private System.Windows.Forms.CheckBox check_ajustes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombrecuentaajuste;
        private System.Windows.Forms.TextBox txtnitajus;
        private System.Windows.Forms.TextBox txtdoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nombrecuentacorre;
        private System.Windows.Forms.TextBox txtcuenaju;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcuncor;
        private System.Windows.Forms.GroupBox gb_check;
        private System.Windows.Forms.CheckBox check_centro;
        private System.Windows.Forms.CheckBox check_pidenit;
        private System.Windows.Forms.GroupBox gb_retencion;
        private System.Windows.Forms.TextBox txt_mediosmag;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox check_reteica;
        private System.Windows.Forms.TextBox txt_nombrenit;
        private System.Windows.Forms.Label lblconrete;
        private System.Windows.Forms.TextBox txtconcerete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_poreteica;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_conreteica;
        private System.Windows.Forms.TextBox txtcierre;
        private System.Windows.Forms.Label lblcuencierr;
        private System.Windows.Forms.TextBox txt_nomcucierre;
    }
}