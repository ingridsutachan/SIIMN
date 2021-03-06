﻿////*********************************************************
//
//    <copyright file="frmpresupuesto.Designer.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 01 marzo 2014
//    </copyright>
//
////*********************************************************
namespace App.Forms.Contable
{
    /// <summary>
    /// Clase Formulario presupuesto de diseño
    /// </summary>
    partial class Frmpresupuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmpresupuesto));
            this.lblano = new System.Windows.Forms.Label();
            this.lblnumc = new System.Windows.Forms.Label();
            this.txtanio = new System.Windows.Forms.TextBox();
            this.txtnumcuent = new System.Windows.Forms.TextBox();
            this.lblnomb = new System.Windows.Forms.Label();
            this.txtnomcue = new System.Windows.Forms.TextBox();
            this.lblenero = new System.Windows.Forms.Label();
            this.lblfebrero = new System.Windows.Forms.Label();
            this.lblmarzo = new System.Windows.Forms.Label();
            this.lblabril = new System.Windows.Forms.Label();
            this.lblmayo = new System.Windows.Forms.Label();
            this.lbljunio = new System.Windows.Forms.Label();
            this.lbljulio = new System.Windows.Forms.Label();
            this.lbldici = new System.Windows.Forms.Label();
            this.lblnovi = new System.Windows.Forms.Label();
            this.lbloctu = new System.Windows.Forms.Label();
            this.lblsepti = new System.Windows.Forms.Label();
            this.lblagosto = new System.Windows.Forms.Label();
            this.txtenero = new System.Windows.Forms.TextBox();
            this.txtabril = new System.Windows.Forms.TextBox();
            this.txtmayo = new System.Windows.Forms.TextBox();
            this.txtjunio = new System.Windows.Forms.TextBox();
            this.txtjulio = new System.Windows.Forms.TextBox();
            this.txtagosto = new System.Windows.Forms.TextBox();
            this.txtsepti = new System.Windows.Forms.TextBox();
            this.txtoctu = new System.Windows.Forms.TextBox();
            this.txtnov = new System.Windows.Forms.TextBox();
            this.txtmarzo = new System.Windows.Forms.TextBox();
            this.txtfebrero = new System.Windows.Forms.TextBox();
            this.txtdici = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPresupuesto = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_centro = new System.Windows.Forms.TextBox();
            this.txt_descripcentro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menu_botones = new System.Windows.Forms.ToolStrip();
            this.btn_nuevo = new System.Windows.Forms.ToolStripButton();
            this.btn_generar = new System.Windows.Forms.ToolStripButton();
            this.btn_editar = new System.Windows.Forms.ToolStripButton();
            this.btn_eliminar = new System.Windows.Forms.ToolStripButton();
            this.btn_buscar = new System.Windows.Forms.ToolStripButton();
            this.btn_imprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.btn_cancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pnlPresupuesto.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menu_botones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblano
            // 
            this.lblano.AutoSize = true;
            this.lblano.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblano.Location = new System.Drawing.Point(14, 26);
            this.lblano.Name = "lblano";
            this.lblano.Size = new System.Drawing.Size(150, 13);
            this.lblano.TabIndex = 25;
            this.lblano.Text = "AÑO DE PRESUPUESTO";
            // 
            // lblnumc
            // 
            this.lblnumc.AutoSize = true;
            this.lblnumc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblnumc.Location = new System.Drawing.Point(14, 59);
            this.lblnumc.Name = "lblnumc";
            this.lblnumc.Size = new System.Drawing.Size(57, 13);
            this.lblnumc.TabIndex = 26;
            this.lblnumc.Text = "CUENTA";
            // 
            // txtanio
            // 
            this.txtanio.AcceptsTab = true;
            this.txtanio.Enabled = false;
            this.txtanio.Location = new System.Drawing.Point(187, 19);
            this.txtanio.MaxLength = 4;
            this.txtanio.Name = "txtanio";
            this.txtanio.Size = new System.Drawing.Size(57, 20);
            this.txtanio.TabIndex = 1;
            this.txtanio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterAnio_KeyPress);
            this.txtanio.Leave += new System.EventHandler(this.Txtanio_Leave);
            // 
            // txtnumcuent
            // 
            this.txtnumcuent.AcceptsTab = true;
            this.txtnumcuent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtnumcuent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtnumcuent.Enabled = false;
            this.txtnumcuent.Location = new System.Drawing.Point(187, 52);
            this.txtnumcuent.MaxLength = 10;
            this.txtnumcuent.Name = "txtnumcuent";
            this.txtnumcuent.Size = new System.Drawing.Size(214, 20);
            this.txtnumcuent.TabIndex = 2;
            this.txtnumcuent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtnumcuent_KeyDown);
            this.txtnumcuent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterValidar_KeyPress);
            this.txtnumcuent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtnumcuent_KeyUp);
            this.txtnumcuent.Leave += new System.EventHandler(this.Txtnumcuent_Leave);
            // 
            // lblnomb
            // 
            this.lblnomb.AutoSize = true;
            this.lblnomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblnomb.Location = new System.Drawing.Point(14, 90);
            this.lblnomb.Name = "lblnomb";
            this.lblnomb.Size = new System.Drawing.Size(166, 13);
            this.lblnomb.TabIndex = 29;
            this.lblnomb.Text = "DESCRIPCION DE CUENTA";
            // 
            // txtnomcue
            // 
            this.txtnomcue.AcceptsTab = true;
            this.txtnomcue.Enabled = false;
            this.txtnomcue.Location = new System.Drawing.Point(187, 83);
            this.txtnomcue.Name = "txtnomcue";
            this.txtnomcue.ReadOnly = true;
            this.txtnomcue.Size = new System.Drawing.Size(268, 20);
            this.txtnomcue.TabIndex = 3;
            // 
            // lblenero
            // 
            this.lblenero.AutoSize = true;
            this.lblenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenero.Location = new System.Drawing.Point(26, 300);
            this.lblenero.Name = "lblenero";
            this.lblenero.Size = new System.Drawing.Size(50, 13);
            this.lblenero.TabIndex = 31;
            this.lblenero.Text = "ENERO";
            // 
            // lblfebrero
            // 
            this.lblfebrero.AutoSize = true;
            this.lblfebrero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfebrero.Location = new System.Drawing.Point(26, 322);
            this.lblfebrero.Name = "lblfebrero";
            this.lblfebrero.Size = new System.Drawing.Size(65, 13);
            this.lblfebrero.TabIndex = 32;
            this.lblfebrero.Text = "FEBRERO";
            // 
            // lblmarzo
            // 
            this.lblmarzo.AutoSize = true;
            this.lblmarzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmarzo.Location = new System.Drawing.Point(26, 344);
            this.lblmarzo.Name = "lblmarzo";
            this.lblmarzo.Size = new System.Drawing.Size(51, 13);
            this.lblmarzo.TabIndex = 34;
            this.lblmarzo.Text = "MARZO";
            // 
            // lblabril
            // 
            this.lblabril.AutoSize = true;
            this.lblabril.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblabril.Location = new System.Drawing.Point(26, 366);
            this.lblabril.Name = "lblabril";
            this.lblabril.Size = new System.Drawing.Size(43, 13);
            this.lblabril.TabIndex = 33;
            this.lblabril.Text = "ABRIL";
            // 
            // lblmayo
            // 
            this.lblmayo.AutoSize = true;
            this.lblmayo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmayo.Location = new System.Drawing.Point(26, 389);
            this.lblmayo.Name = "lblmayo";
            this.lblmayo.Size = new System.Drawing.Size(42, 13);
            this.lblmayo.TabIndex = 36;
            this.lblmayo.Text = "MAYO";
            // 
            // lbljunio
            // 
            this.lbljunio.AutoSize = true;
            this.lbljunio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljunio.Location = new System.Drawing.Point(26, 413);
            this.lbljunio.Name = "lbljunio";
            this.lbljunio.Size = new System.Drawing.Size(44, 13);
            this.lbljunio.TabIndex = 35;
            this.lbljunio.Text = "JUNIO";
            // 
            // lbljulio
            // 
            this.lbljulio.AutoSize = true;
            this.lbljulio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljulio.Location = new System.Drawing.Point(26, 438);
            this.lbljulio.Name = "lbljulio";
            this.lbljulio.Size = new System.Drawing.Size(42, 13);
            this.lbljulio.TabIndex = 37;
            this.lbljulio.Text = "JULIO";
            // 
            // lbldici
            // 
            this.lbldici.AutoSize = true;
            this.lbldici.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldici.Location = new System.Drawing.Point(26, 563);
            this.lbldici.Name = "lbldici";
            this.lbldici.Size = new System.Drawing.Size(75, 13);
            this.lbldici.TabIndex = 38;
            this.lbldici.Text = "DICIEMBRE";
            // 
            // lblnovi
            // 
            this.lblnovi.AutoSize = true;
            this.lblnovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnovi.Location = new System.Drawing.Point(26, 540);
            this.lblnovi.Name = "lblnovi";
            this.lblnovi.Size = new System.Drawing.Size(80, 13);
            this.lblnovi.TabIndex = 39;
            this.lblnovi.Text = "NOVIEMBRE";
            // 
            // lbloctu
            // 
            this.lbloctu.AutoSize = true;
            this.lbloctu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloctu.Location = new System.Drawing.Point(26, 513);
            this.lbloctu.Name = "lbloctu";
            this.lbloctu.Size = new System.Drawing.Size(66, 13);
            this.lbloctu.TabIndex = 40;
            this.lbloctu.Text = "OCTUBRE";
            // 
            // lblsepti
            // 
            this.lblsepti.AutoSize = true;
            this.lblsepti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsepti.Location = new System.Drawing.Point(26, 488);
            this.lblsepti.Name = "lblsepti";
            this.lblsepti.Size = new System.Drawing.Size(86, 13);
            this.lblsepti.TabIndex = 41;
            this.lblsepti.Text = "SEPTIEMBRE";
            // 
            // lblagosto
            // 
            this.lblagosto.AutoSize = true;
            this.lblagosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblagosto.Location = new System.Drawing.Point(26, 463);
            this.lblagosto.Name = "lblagosto";
            this.lblagosto.Size = new System.Drawing.Size(58, 13);
            this.lblagosto.TabIndex = 42;
            this.lblagosto.Text = "AGOSTO";
            // 
            // txtenero
            // 
            this.txtenero.AcceptsTab = true;
            this.txtenero.Enabled = false;
            this.txtenero.Location = new System.Drawing.Point(118, 293);
            this.txtenero.MaxLength = 17;
            this.txtenero.Name = "txtenero";
            this.txtenero.Size = new System.Drawing.Size(100, 20);
            this.txtenero.TabIndex = 6;
            this.txtenero.Tag = "";
            this.txtenero.Text = "0.0";
            this.txtenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TabEnter_KeyPress);
            this.txtenero.Leave += new System.EventHandler(this.Decimal_Leave);
            // 
            // txtabril
            // 
            this.txtabril.Enabled = false;
            this.txtabril.Location = new System.Drawing.Point(118, 359);
            this.txtabril.MaxLength = 17;
            this.txtabril.Name = "txtabril";
            this.txtabril.Size = new System.Drawing.Size(100, 20);
            this.txtabril.TabIndex = 8;
            this.txtabril.Text = "0.0";
            this.txtabril.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TabEnter_KeyPress);
            this.txtabril.Leave += new System.EventHandler(this.Decimal_Leave);
            // 
            // txtmayo
            // 
            this.txtmayo.Enabled = false;
            this.txtmayo.Location = new System.Drawing.Point(118, 382);
            this.txtmayo.MaxLength = 17;
            this.txtmayo.Name = "txtmayo";
            this.txtmayo.Size = new System.Drawing.Size(100, 20);
            this.txtmayo.TabIndex = 9;
            this.txtmayo.Text = "0.0";
            this.txtmayo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TabEnter_KeyPress);
            this.txtmayo.Leave += new System.EventHandler(this.Decimal_Leave);
            // 
            // txtjunio
            // 
            this.txtjunio.Enabled = false;
            this.txtjunio.Location = new System.Drawing.Point(118, 406);
            this.txtjunio.MaxLength = 17;
            this.txtjunio.Name = "txtjunio";
            this.txtjunio.Size = new System.Drawing.Size(100, 20);
            this.txtjunio.TabIndex = 10;
            this.txtjunio.Text = "0.0";
            this.txtjunio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TabEnter_KeyPress);
            this.txtjunio.Leave += new System.EventHandler(this.Decimal_Leave);
            // 
            // txtjulio
            // 
            this.txtjulio.Enabled = false;
            this.txtjulio.Location = new System.Drawing.Point(118, 431);
            this.txtjulio.MaxLength = 17;
            this.txtjulio.Name = "txtjulio";
            this.txtjulio.Size = new System.Drawing.Size(100, 20);
            this.txtjulio.TabIndex = 11;
            this.txtjulio.Text = "0.0";
            this.txtjulio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TabEnter_KeyPress);
            this.txtjulio.Leave += new System.EventHandler(this.Decimal_Leave);
            // 
            // txtagosto
            // 
            this.txtagosto.Enabled = false;
            this.txtagosto.Location = new System.Drawing.Point(118, 456);
            this.txtagosto.MaxLength = 17;
            this.txtagosto.Name = "txtagosto";
            this.txtagosto.Size = new System.Drawing.Size(100, 20);
            this.txtagosto.TabIndex = 12;
            this.txtagosto.Text = "0.0";
            this.txtagosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TabEnter_KeyPress);
            this.txtagosto.Leave += new System.EventHandler(this.Decimal_Leave);
            // 
            // txtsepti
            // 
            this.txtsepti.Enabled = false;
            this.txtsepti.Location = new System.Drawing.Point(118, 481);
            this.txtsepti.MaxLength = 17;
            this.txtsepti.Name = "txtsepti";
            this.txtsepti.Size = new System.Drawing.Size(100, 20);
            this.txtsepti.TabIndex = 13;
            this.txtsepti.Text = "0.0";
            this.txtsepti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TabEnter_KeyPress);
            this.txtsepti.Leave += new System.EventHandler(this.Decimal_Leave);
            // 
            // txtoctu
            // 
            this.txtoctu.Enabled = false;
            this.txtoctu.Location = new System.Drawing.Point(118, 508);
            this.txtoctu.MaxLength = 17;
            this.txtoctu.Name = "txtoctu";
            this.txtoctu.Size = new System.Drawing.Size(100, 20);
            this.txtoctu.TabIndex = 14;
            this.txtoctu.Text = "0.0";
            this.txtoctu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TabEnter_KeyPress);
            this.txtoctu.Leave += new System.EventHandler(this.Decimal_Leave);
            // 
            // txtnov
            // 
            this.txtnov.Enabled = false;
            this.txtnov.Location = new System.Drawing.Point(118, 533);
            this.txtnov.MaxLength = 17;
            this.txtnov.Name = "txtnov";
            this.txtnov.Size = new System.Drawing.Size(100, 20);
            this.txtnov.TabIndex = 15;
            this.txtnov.Text = "0.0";
            this.txtnov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TabEnter_KeyPress);
            this.txtnov.Leave += new System.EventHandler(this.Decimal_Leave);
            // 
            // txtmarzo
            // 
            this.txtmarzo.Enabled = false;
            this.txtmarzo.Location = new System.Drawing.Point(118, 337);
            this.txtmarzo.MaxLength = 17;
            this.txtmarzo.Name = "txtmarzo";
            this.txtmarzo.Size = new System.Drawing.Size(100, 20);
            this.txtmarzo.TabIndex = 8;
            this.txtmarzo.Text = "0.0";
            this.txtmarzo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TabEnter_KeyPress);
            this.txtmarzo.Leave += new System.EventHandler(this.Decimal_Leave);
            // 
            // txtfebrero
            // 
            this.txtfebrero.Enabled = false;
            this.txtfebrero.Location = new System.Drawing.Point(118, 315);
            this.txtfebrero.MaxLength = 17;
            this.txtfebrero.Name = "txtfebrero";
            this.txtfebrero.Size = new System.Drawing.Size(100, 20);
            this.txtfebrero.TabIndex = 7;
            this.txtfebrero.Text = "0.0";
            this.txtfebrero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TabEnter_KeyPress);
            this.txtfebrero.Leave += new System.EventHandler(this.Decimal_Leave);
            // 
            // txtdici
            // 
            this.txtdici.Enabled = false;
            this.txtdici.Location = new System.Drawing.Point(118, 558);
            this.txtdici.MaxLength = 17;
            this.txtdici.Name = "txtdici";
            this.txtdici.Size = new System.Drawing.Size(100, 20);
            this.txtdici.TabIndex = 16;
            this.txtdici.Text = "0.0";
            this.txtdici.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TabEnterDic_KeyPress);
            this.txtdici.Leave += new System.EventHandler(this.Decimal_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIGITE EL RESPECTIVO PRESUPUESTO:";
            // 
            // pnlPresupuesto
            // 
            this.pnlPresupuesto.Controls.Add(this.groupBox1);
            this.pnlPresupuesto.Controls.Add(this.label1);
            this.pnlPresupuesto.Controls.Add(this.menu_botones);
            this.pnlPresupuesto.Controls.Add(this.txtenero);
            this.pnlPresupuesto.Controls.Add(this.lblenero);
            this.pnlPresupuesto.Controls.Add(this.lblfebrero);
            this.pnlPresupuesto.Controls.Add(this.lblabril);
            this.pnlPresupuesto.Controls.Add(this.lblmarzo);
            this.pnlPresupuesto.Controls.Add(this.lbljunio);
            this.pnlPresupuesto.Controls.Add(this.lblmayo);
            this.pnlPresupuesto.Controls.Add(this.lbljulio);
            this.pnlPresupuesto.Controls.Add(this.txtdici);
            this.pnlPresupuesto.Controls.Add(this.lbldici);
            this.pnlPresupuesto.Controls.Add(this.txtfebrero);
            this.pnlPresupuesto.Controls.Add(this.lblnovi);
            this.pnlPresupuesto.Controls.Add(this.txtmarzo);
            this.pnlPresupuesto.Controls.Add(this.lbloctu);
            this.pnlPresupuesto.Controls.Add(this.txtnov);
            this.pnlPresupuesto.Controls.Add(this.lblsepti);
            this.pnlPresupuesto.Controls.Add(this.txtoctu);
            this.pnlPresupuesto.Controls.Add(this.lblagosto);
            this.pnlPresupuesto.Controls.Add(this.txtsepti);
            this.pnlPresupuesto.Controls.Add(this.txtabril);
            this.pnlPresupuesto.Controls.Add(this.txtagosto);
            this.pnlPresupuesto.Controls.Add(this.txtmayo);
            this.pnlPresupuesto.Controls.Add(this.txtjulio);
            this.pnlPresupuesto.Controls.Add(this.txtjunio);
            this.pnlPresupuesto.Controls.Add(this.shapeContainer1);
            this.pnlPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPresupuesto.Location = new System.Drawing.Point(0, 0);
            this.pnlPresupuesto.Name = "pnlPresupuesto";
            this.pnlPresupuesto.Size = new System.Drawing.Size(519, 591);
            this.pnlPresupuesto.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblano);
            this.groupBox1.Controls.Add(this.lblnumc);
            this.groupBox1.Controls.Add(this.txt_centro);
            this.groupBox1.Controls.Add(this.lblnomb);
            this.groupBox1.Controls.Add(this.txt_descripcentro);
            this.groupBox1.Controls.Add(this.txtnomcue);
            this.groupBox1.Controls.Add(this.txtnumcuent);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtanio);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 191);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(14, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "DESCRIPCION CENTRO";
            // 
            // txt_centro
            // 
            this.txt_centro.AcceptsTab = true;
            this.txt_centro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_centro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_centro.Enabled = false;
            this.txt_centro.Location = new System.Drawing.Point(187, 117);
            this.txt_centro.MaxLength = 2;
            this.txt_centro.Name = "txt_centro";
            this.txt_centro.Size = new System.Drawing.Size(57, 20);
            this.txt_centro.TabIndex = 4;
            this.txt_centro.Enter += new System.EventHandler(this.Txt_centro_Enter);
            this.txt_centro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterValidar_KeyPress);
            this.txt_centro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_centro_KeyUp);
            this.txt_centro.Leave += new System.EventHandler(this.Txt_centro_Leave);
            // 
            // txt_descripcentro
            // 
            this.txt_descripcentro.AcceptsTab = true;
            this.txt_descripcentro.Enabled = false;
            this.txt_descripcentro.Location = new System.Drawing.Point(187, 149);
            this.txt_descripcentro.Name = "txt_descripcentro";
            this.txt_descripcentro.ReadOnly = true;
            this.txt_descripcentro.Size = new System.Drawing.Size(268, 20);
            this.txt_descripcentro.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(14, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "CENTRO DE COSTOS";
            // 
            // menu_botones
            // 
            this.menu_botones.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu_botones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_nuevo,
            this.btn_generar,
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
            this.menu_botones.Size = new System.Drawing.Size(519, 31);
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
            // btn_generar
            // 
            this.btn_generar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_generar.Enabled = false;
            this.btn_generar.Image = global::App.Properties.Resources.update;
            this.btn_generar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(28, 28);
            this.btn_generar.Text = "Generar";
            this.btn_generar.ToolTipText = "Generar(Ctrl+R)";
            this.btn_generar.Click += new System.EventHandler(this.Btn_generar_Click);
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
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(519, 591);
            this.shapeContainer1.TabIndex = 67;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -6;
            this.lineShape1.X2 = 806;
            this.lineShape1.Y1 = 254;
            this.lineShape1.Y2 = 253;
            // 
            // Frmpresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(519, 591);
            this.Controls.Add(this.pnlPresupuesto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmpresupuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRESUPUESTO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frmpresupuesto_FormClosing);
            this.pnlPresupuesto.ResumeLayout(false);
            this.pnlPresupuesto.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menu_botones.ResumeLayout(false);
            this.menu_botones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblano;
        private System.Windows.Forms.Label lblnumc;
        private System.Windows.Forms.TextBox txtanio;
        private System.Windows.Forms.TextBox txtnumcuent;
        private System.Windows.Forms.Label lblnomb;
        private System.Windows.Forms.TextBox txtnomcue;
        private System.Windows.Forms.Label lblenero;
        private System.Windows.Forms.Label lblfebrero;
        private System.Windows.Forms.Label lblmarzo;
        private System.Windows.Forms.Label lblabril;
        private System.Windows.Forms.Label lblmayo;
        private System.Windows.Forms.Label lbljunio;
        private System.Windows.Forms.Label lbljulio;
        private System.Windows.Forms.Label lbldici;
        private System.Windows.Forms.Label lblnovi;
        private System.Windows.Forms.Label lbloctu;
        private System.Windows.Forms.Label lblsepti;
        private System.Windows.Forms.Label lblagosto;
        private System.Windows.Forms.TextBox txtenero;
        private System.Windows.Forms.TextBox txtabril;
        private System.Windows.Forms.TextBox txtmayo;
        private System.Windows.Forms.TextBox txtjunio;
        private System.Windows.Forms.TextBox txtjulio;
        private System.Windows.Forms.TextBox txtagosto;
        private System.Windows.Forms.TextBox txtsepti;
        private System.Windows.Forms.TextBox txtoctu;
        private System.Windows.Forms.TextBox txtnov;
        private System.Windows.Forms.TextBox txtmarzo;
        private System.Windows.Forms.TextBox txtfebrero;
        private System.Windows.Forms.TextBox txtdici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPresupuesto;
        private System.Windows.Forms.TextBox txt_centro;
        private System.Windows.Forms.TextBox txt_descripcentro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.ToolStripButton btn_generar;
    }
}