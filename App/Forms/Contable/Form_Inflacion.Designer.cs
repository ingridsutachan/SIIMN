﻿namespace App.Forms.Contable
{
    partial class Form_Inflacion
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
            this.txtenero = new System.Windows.Forms.TextBox();
            this.lblenero = new System.Windows.Forms.Label();
            this.lblfebrero = new System.Windows.Forms.Label();
            this.lblabril = new System.Windows.Forms.Label();
            this.lblmarzo = new System.Windows.Forms.Label();
            this.lbljunio = new System.Windows.Forms.Label();
            this.lblmayo = new System.Windows.Forms.Label();
            this.lbljulio = new System.Windows.Forms.Label();
            this.txtdici = new System.Windows.Forms.TextBox();
            this.lbldici = new System.Windows.Forms.Label();
            this.txtfebrero = new System.Windows.Forms.TextBox();
            this.lblnovi = new System.Windows.Forms.Label();
            this.txtmarzo = new System.Windows.Forms.TextBox();
            this.lbloctu = new System.Windows.Forms.Label();
            this.txtnov = new System.Windows.Forms.TextBox();
            this.lblsepti = new System.Windows.Forms.Label();
            this.txtoctu = new System.Windows.Forms.TextBox();
            this.lblagosto = new System.Windows.Forms.Label();
            this.txtsepti = new System.Windows.Forms.TextBox();
            this.txtabril = new System.Windows.Forms.TextBox();
            this.txtagosto = new System.Windows.Forms.TextBox();
            this.txtmayo = new System.Windows.Forms.TextBox();
            this.txtjulio = new System.Windows.Forms.TextBox();
            this.txtjunio = new System.Windows.Forms.TextBox();
            this.txt_acumulado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menu_botones = new System.Windows.Forms.ToolStrip();
            this.btn_nuevo = new System.Windows.Forms.ToolStripButton();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.menu_botones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtenero
            // 
            this.txtenero.AcceptsTab = true;
            this.txtenero.Enabled = false;
            this.txtenero.Location = new System.Drawing.Point(120, 22);
            this.txtenero.MaxLength = 5;
            this.txtenero.Name = "txtenero";
            this.txtenero.Size = new System.Drawing.Size(100, 20);
            this.txtenero.TabIndex = 56;
            this.txtenero.Tag = "";
            this.txtenero.Text = "0,0";
            this.txtenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaDecimal_KeyPress);
            this.txtenero.Leave += new System.EventHandler(this.Decimal_Leave);
            // 
            // lblenero
            // 
            this.lblenero.AutoSize = true;
            this.lblenero.Location = new System.Drawing.Point(15, 29);
            this.lblenero.Name = "lblenero";
            this.lblenero.Size = new System.Drawing.Size(50, 13);
            this.lblenero.TabIndex = 69;
            this.lblenero.Text = "ENERO";
            // 
            // lblfebrero
            // 
            this.lblfebrero.AutoSize = true;
            this.lblfebrero.Location = new System.Drawing.Point(15, 51);
            this.lblfebrero.Name = "lblfebrero";
            this.lblfebrero.Size = new System.Drawing.Size(65, 13);
            this.lblfebrero.TabIndex = 70;
            this.lblfebrero.Text = "FEBRERO";
            // 
            // lblabril
            // 
            this.lblabril.AutoSize = true;
            this.lblabril.Location = new System.Drawing.Point(16, 95);
            this.lblabril.Name = "lblabril";
            this.lblabril.Size = new System.Drawing.Size(43, 13);
            this.lblabril.TabIndex = 71;
            this.lblabril.Text = "ABRIL";
            // 
            // lblmarzo
            // 
            this.lblmarzo.AutoSize = true;
            this.lblmarzo.Location = new System.Drawing.Point(15, 73);
            this.lblmarzo.Name = "lblmarzo";
            this.lblmarzo.Size = new System.Drawing.Size(51, 13);
            this.lblmarzo.TabIndex = 72;
            this.lblmarzo.Text = "MARZO";
            // 
            // lbljunio
            // 
            this.lbljunio.AutoSize = true;
            this.lbljunio.Location = new System.Drawing.Point(15, 142);
            this.lbljunio.Name = "lbljunio";
            this.lbljunio.Size = new System.Drawing.Size(44, 13);
            this.lbljunio.TabIndex = 73;
            this.lbljunio.Text = "JUNIO";
            // 
            // lblmayo
            // 
            this.lblmayo.AutoSize = true;
            this.lblmayo.Location = new System.Drawing.Point(16, 118);
            this.lblmayo.Name = "lblmayo";
            this.lblmayo.Size = new System.Drawing.Size(42, 13);
            this.lblmayo.TabIndex = 74;
            this.lblmayo.Text = "MAYO";
            // 
            // lbljulio
            // 
            this.lbljulio.AutoSize = true;
            this.lbljulio.Location = new System.Drawing.Point(16, 167);
            this.lbljulio.Name = "lbljulio";
            this.lbljulio.Size = new System.Drawing.Size(42, 13);
            this.lbljulio.TabIndex = 75;
            this.lbljulio.Text = "JULIO";
            // 
            // txtdici
            // 
            this.txtdici.Enabled = false;
            this.txtdici.Location = new System.Drawing.Point(120, 287);
            this.txtdici.MaxLength = 5;
            this.txtdici.Name = "txtdici";
            this.txtdici.Size = new System.Drawing.Size(100, 20);
            this.txtdici.TabIndex = 67;
            this.txtdici.Text = "0,0";
            this.txtdici.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaDecimal_KeyPress);
            this.txtdici.Leave += new System.EventHandler(this.Decimal_Leave);
            // 
            // lbldici
            // 
            this.lbldici.AutoSize = true;
            this.lbldici.Location = new System.Drawing.Point(16, 292);
            this.lbldici.Name = "lbldici";
            this.lbldici.Size = new System.Drawing.Size(75, 13);
            this.lbldici.TabIndex = 76;
            this.lbldici.Text = "DICIEMBRE";
            // 
            // txtfebrero
            // 
            this.txtfebrero.Enabled = false;
            this.txtfebrero.Location = new System.Drawing.Point(120, 44);
            this.txtfebrero.MaxLength = 5;
            this.txtfebrero.Name = "txtfebrero";
            this.txtfebrero.Size = new System.Drawing.Size(100, 20);
            this.txtfebrero.TabIndex = 57;
            this.txtfebrero.Text = "0,0";
            this.txtfebrero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaDecimal_KeyPress);
            this.txtfebrero.Leave += new System.EventHandler(this.Decimal_Leave);
            // 
            // lblnovi
            // 
            this.lblnovi.AutoSize = true;
            this.lblnovi.Location = new System.Drawing.Point(15, 269);
            this.lblnovi.Name = "lblnovi";
            this.lblnovi.Size = new System.Drawing.Size(80, 13);
            this.lblnovi.TabIndex = 77;
            this.lblnovi.Text = "NOVIEMBRE";
            // 
            // txtmarzo
            // 
            this.txtmarzo.Enabled = false;
            this.txtmarzo.Location = new System.Drawing.Point(120, 66);
            this.txtmarzo.MaxLength = 5;
            this.txtmarzo.Name = "txtmarzo";
            this.txtmarzo.Size = new System.Drawing.Size(100, 20);
            this.txtmarzo.TabIndex = 58;
            this.txtmarzo.Text = "0,0";
            this.txtmarzo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaDecimal_KeyPress);
            this.txtmarzo.Leave += new System.EventHandler(this.Decimal_Leave);
            // 
            // lbloctu
            // 
            this.lbloctu.AutoSize = true;
            this.lbloctu.Location = new System.Drawing.Point(16, 242);
            this.lbloctu.Name = "lbloctu";
            this.lbloctu.Size = new System.Drawing.Size(66, 13);
            this.lbloctu.TabIndex = 78;
            this.lbloctu.Text = "OCTUBRE";
            // 
            // txtnov
            // 
            this.txtnov.Enabled = false;
            this.txtnov.Location = new System.Drawing.Point(120, 262);
            this.txtnov.MaxLength = 5;
            this.txtnov.Name = "txtnov";
            this.txtnov.Size = new System.Drawing.Size(100, 20);
            this.txtnov.TabIndex = 66;
            this.txtnov.Text = "0,0";
            this.txtnov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaDecimal_KeyPress);
            this.txtnov.Leave += new System.EventHandler(this.Decimal_Leave);
            // 
            // lblsepti
            // 
            this.lblsepti.AutoSize = true;
            this.lblsepti.Location = new System.Drawing.Point(15, 217);
            this.lblsepti.Name = "lblsepti";
            this.lblsepti.Size = new System.Drawing.Size(86, 13);
            this.lblsepti.TabIndex = 79;
            this.lblsepti.Text = "SEPTIEMBRE";
            this.lblsepti.Leave += new System.EventHandler(this.Decimal_Leave);
            // 
            // txtoctu
            // 
            this.txtoctu.Enabled = false;
            this.txtoctu.Location = new System.Drawing.Point(120, 237);
            this.txtoctu.MaxLength = 5;
            this.txtoctu.Name = "txtoctu";
            this.txtoctu.Size = new System.Drawing.Size(100, 20);
            this.txtoctu.TabIndex = 65;
            this.txtoctu.Text = "0,0";
            this.txtoctu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaDecimal_KeyPress);
            this.txtoctu.Leave += new System.EventHandler(this.Decimal_Leave);
            // 
            // lblagosto
            // 
            this.lblagosto.AutoSize = true;
            this.lblagosto.Location = new System.Drawing.Point(16, 192);
            this.lblagosto.Name = "lblagosto";
            this.lblagosto.Size = new System.Drawing.Size(58, 13);
            this.lblagosto.TabIndex = 80;
            this.lblagosto.Text = "AGOSTO";
            // 
            // txtsepti
            // 
            this.txtsepti.Enabled = false;
            this.txtsepti.Location = new System.Drawing.Point(120, 210);
            this.txtsepti.MaxLength = 5;
            this.txtsepti.Name = "txtsepti";
            this.txtsepti.Size = new System.Drawing.Size(100, 20);
            this.txtsepti.TabIndex = 64;
            this.txtsepti.Text = "0,0";
            this.txtsepti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaDecimal_KeyPress);
            this.txtsepti.Leave += new System.EventHandler(this.Decimal_Leave);
            // 
            // txtabril
            // 
            this.txtabril.Enabled = false;
            this.txtabril.Location = new System.Drawing.Point(120, 88);
            this.txtabril.MaxLength = 5;
            this.txtabril.Name = "txtabril";
            this.txtabril.Size = new System.Drawing.Size(100, 20);
            this.txtabril.TabIndex = 59;
            this.txtabril.Text = "0,0";
            this.txtabril.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaDecimal_KeyPress);
            this.txtabril.Leave += new System.EventHandler(this.Decimal_Leave);
            // 
            // txtagosto
            // 
            this.txtagosto.Enabled = false;
            this.txtagosto.Location = new System.Drawing.Point(120, 185);
            this.txtagosto.MaxLength = 5;
            this.txtagosto.Name = "txtagosto";
            this.txtagosto.Size = new System.Drawing.Size(100, 20);
            this.txtagosto.TabIndex = 63;
            this.txtagosto.Text = "0,0";
            this.txtagosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaDecimal_KeyPress);
            this.txtagosto.Leave += new System.EventHandler(this.Decimal_Leave);
            // 
            // txtmayo
            // 
            this.txtmayo.Enabled = false;
            this.txtmayo.Location = new System.Drawing.Point(120, 111);
            this.txtmayo.MaxLength = 5;
            this.txtmayo.Name = "txtmayo";
            this.txtmayo.Size = new System.Drawing.Size(100, 20);
            this.txtmayo.TabIndex = 60;
            this.txtmayo.Text = "0,0";
            this.txtmayo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaDecimal_KeyPress);
            this.txtmayo.Leave += new System.EventHandler(this.Decimal_Leave);
            // 
            // txtjulio
            // 
            this.txtjulio.Enabled = false;
            this.txtjulio.Location = new System.Drawing.Point(120, 160);
            this.txtjulio.MaxLength = 5;
            this.txtjulio.Name = "txtjulio";
            this.txtjulio.Size = new System.Drawing.Size(100, 20);
            this.txtjulio.TabIndex = 62;
            this.txtjulio.Text = "0,0";
            this.txtjulio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaDecimal_KeyPress);
            this.txtjulio.Leave += new System.EventHandler(this.Decimal_Leave);
            // 
            // txtjunio
            // 
            this.txtjunio.Enabled = false;
            this.txtjunio.Location = new System.Drawing.Point(120, 135);
            this.txtjunio.MaxLength = 5;
            this.txtjunio.Name = "txtjunio";
            this.txtjunio.Size = new System.Drawing.Size(100, 20);
            this.txtjunio.TabIndex = 61;
            this.txtjunio.Text = "0,0";
            this.txtjunio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaDecimal_KeyPress);
            this.txtjunio.Leave += new System.EventHandler(this.Decimal_Leave);
            // 
            // txt_acumulado
            // 
            this.txt_acumulado.AcceptsTab = true;
            this.txt_acumulado.Enabled = false;
            this.txt_acumulado.Location = new System.Drawing.Point(120, 322);
            this.txt_acumulado.MaxLength = 5;
            this.txt_acumulado.Name = "txt_acumulado";
            this.txt_acumulado.ReadOnly = true;
            this.txt_acumulado.Size = new System.Drawing.Size(100, 20);
            this.txt_acumulado.TabIndex = 83;
            this.txt_acumulado.Tag = "";
            this.txt_acumulado.Text = "0,0";
            this.txt_acumulado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaDecimal_KeyPress);
            this.txt_acumulado.Leave += new System.EventHandler(this.Decimal_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 95;
            this.label2.Text = "ACUMULADO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblenero);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtjunio);
            this.groupBox1.Controls.Add(this.txt_acumulado);
            this.groupBox1.Controls.Add(this.txtjulio);
            this.groupBox1.Controls.Add(this.txtenero);
            this.groupBox1.Controls.Add(this.txtmayo);
            this.groupBox1.Controls.Add(this.txtagosto);
            this.groupBox1.Controls.Add(this.lblfebrero);
            this.groupBox1.Controls.Add(this.txtabril);
            this.groupBox1.Controls.Add(this.lblabril);
            this.groupBox1.Controls.Add(this.txtsepti);
            this.groupBox1.Controls.Add(this.lblmarzo);
            this.groupBox1.Controls.Add(this.lblagosto);
            this.groupBox1.Controls.Add(this.lbljunio);
            this.groupBox1.Controls.Add(this.txtoctu);
            this.groupBox1.Controls.Add(this.lblmayo);
            this.groupBox1.Controls.Add(this.lblsepti);
            this.groupBox1.Controls.Add(this.lbljulio);
            this.groupBox1.Controls.Add(this.txtnov);
            this.groupBox1.Controls.Add(this.txtdici);
            this.groupBox1.Controls.Add(this.lbloctu);
            this.groupBox1.Controls.Add(this.lbldici);
            this.groupBox1.Controls.Add(this.txtmarzo);
            this.groupBox1.Controls.Add(this.txtfebrero);
            this.groupBox1.Controls.Add(this.lblnovi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 371);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DIGITE TASA DEL PAAG POR MES";
            // 
            // menu_botones
            // 
            this.menu_botones.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu_botones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_nuevo,
            this.btn_guardar,
            this.toolStripSeparator2,
            this.btn_salir});
            this.menu_botones.Location = new System.Drawing.Point(0, 0);
            this.menu_botones.Name = "menu_botones";
            this.menu_botones.Size = new System.Drawing.Size(270, 31);
            this.menu_botones.TabIndex = 97;
            this.menu_botones.Text = "toolStrip1";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_nuevo.Image = global::App.Properties.Resources.folder24;
            this.btn_nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(28, 28);
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.ToolTipText = "Nuevo(Ctrl+N)";
            this.btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
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
            // Form_Inflacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 450);
            this.Controls.Add(this.menu_botones);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Inflacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AJUSTES POR INFLACION";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_inflacion_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menu_botones.ResumeLayout(false);
            this.menu_botones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtenero;
        private System.Windows.Forms.Label lblenero;
        private System.Windows.Forms.Label lblfebrero;
        private System.Windows.Forms.Label lblabril;
        private System.Windows.Forms.Label lblmarzo;
        private System.Windows.Forms.Label lbljunio;
        private System.Windows.Forms.Label lblmayo;
        private System.Windows.Forms.Label lbljulio;
        private System.Windows.Forms.TextBox txtdici;
        private System.Windows.Forms.Label lbldici;
        private System.Windows.Forms.TextBox txtfebrero;
        private System.Windows.Forms.Label lblnovi;
        private System.Windows.Forms.TextBox txtmarzo;
        private System.Windows.Forms.Label lbloctu;
        private System.Windows.Forms.TextBox txtnov;
        private System.Windows.Forms.Label lblsepti;
        private System.Windows.Forms.TextBox txtoctu;
        private System.Windows.Forms.Label lblagosto;
        private System.Windows.Forms.TextBox txtsepti;
        private System.Windows.Forms.TextBox txtabril;
        private System.Windows.Forms.TextBox txtagosto;
        private System.Windows.Forms.TextBox txtmayo;
        private System.Windows.Forms.TextBox txtjulio;
        private System.Windows.Forms.TextBox txtjunio;
        private System.Windows.Forms.TextBox txt_acumulado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip menu_botones;
        private System.Windows.Forms.ToolStripButton btn_guardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private System.Windows.Forms.ToolStripButton btn_nuevo;
    }
}