﻿namespace App.Forms.Contable
{
    partial class Form_Comprobantecierre
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
            this.txt_cuentafining = new System.Windows.Forms.TextBox();
            this.txt_cuentainiing = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cuentafincos = new System.Windows.Forms.TextBox();
            this.txt_cuentainicos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cuentauti = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_detalle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_codcomp = new System.Windows.Forms.TextBox();
            this.txt_nominiing = new System.Windows.Forms.TextBox();
            this.txt_nomutili = new System.Windows.Forms.TextBox();
            this.txt_nomfincos = new System.Windows.Forms.TextBox();
            this.txt_nominicos = new System.Windows.Forms.TextBox();
            this.txt_nomfining = new System.Windows.Forms.TextBox();
            this.menu_botones = new System.Windows.Forms.ToolStrip();
            this.btn_nuevo = new System.Windows.Forms.ToolStripButton();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_nomcompro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menu_botones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_cuentafining
            // 
            this.txt_cuentafining.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_cuentafining.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_cuentafining.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_cuentafining.Enabled = false;
            this.txt_cuentafining.Location = new System.Drawing.Point(256, 55);
            this.txt_cuentafining.MaxLength = 45;
            this.txt_cuentafining.Name = "txt_cuentafining";
            this.txt_cuentafining.Size = new System.Drawing.Size(119, 20);
            this.txt_cuentafining.TabIndex = 4;
            this.txt_cuentafining.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtcuenta_KeyDown);
            this.txt_cuentafining.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterValida_KeyPress);
            this.txt_cuentafining.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtnumcuent_KeyUp);
            this.txt_cuentafining.Leave += new System.EventHandler(this.Txtnumcuent_Leave);
            // 
            // txt_cuentainiing
            // 
            this.txt_cuentainiing.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_cuentainiing.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_cuentainiing.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_cuentainiing.Enabled = false;
            this.txt_cuentainiing.Location = new System.Drawing.Point(256, 26);
            this.txt_cuentainiing.MaxLength = 45;
            this.txt_cuentainiing.Name = "txt_cuentainiing";
            this.txt_cuentainiing.Size = new System.Drawing.Size(119, 20);
            this.txt_cuentainiing.TabIndex = 2;
            this.txt_cuentainiing.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtcuenta_KeyDown);
            this.txt_cuentainiing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterValida_KeyPress);
            this.txt_cuentainiing.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtnumcuent_KeyUp);
            this.txt_cuentainiing.Leave += new System.EventHandler(this.Txtnumcuent_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "CUENTA FINAL DE INGRESOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "CUENTA INICIAL DE INGRESOS";
            // 
            // txt_cuentafincos
            // 
            this.txt_cuentafincos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_cuentafincos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_cuentafincos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_cuentafincos.Enabled = false;
            this.txt_cuentafincos.Location = new System.Drawing.Point(256, 110);
            this.txt_cuentafincos.MaxLength = 45;
            this.txt_cuentafincos.Name = "txt_cuentafincos";
            this.txt_cuentafincos.Size = new System.Drawing.Size(119, 20);
            this.txt_cuentafincos.TabIndex = 8;
            this.txt_cuentafincos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtcuenta_KeyDown);
            this.txt_cuentafincos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterValida_KeyPress);
            this.txt_cuentafincos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtnumcuent_KeyUp);
            this.txt_cuentafincos.Leave += new System.EventHandler(this.Txtnumcuent_Leave);
            // 
            // txt_cuentainicos
            // 
            this.txt_cuentainicos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_cuentainicos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_cuentainicos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_cuentainicos.Enabled = false;
            this.txt_cuentainicos.Location = new System.Drawing.Point(256, 83);
            this.txt_cuentainicos.MaxLength = 45;
            this.txt_cuentainicos.Name = "txt_cuentainicos";
            this.txt_cuentainicos.Size = new System.Drawing.Size(119, 20);
            this.txt_cuentainicos.TabIndex = 6;
            this.txt_cuentainicos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtcuenta_KeyDown);
            this.txt_cuentainicos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterValida_KeyPress);
            this.txt_cuentainicos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtnumcuent_KeyUp);
            this.txt_cuentainicos.Leave += new System.EventHandler(this.Txtnumcuent_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "CUENTA INICIAL DE COSTOS Y GASTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "CUENTA FINAL DE COSTOS Y GASTOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "CUENTA INICIAL DE UTILIDADES POR ";
            // 
            // txt_cuentauti
            // 
            this.txt_cuentauti.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_cuentauti.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_cuentauti.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_cuentauti.Enabled = false;
            this.txt_cuentauti.Location = new System.Drawing.Point(256, 137);
            this.txt_cuentauti.MaxLength = 45;
            this.txt_cuentauti.Name = "txt_cuentauti";
            this.txt_cuentauti.Size = new System.Drawing.Size(119, 20);
            this.txt_cuentauti.TabIndex = 10;
            this.txt_cuentauti.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtcuenta_KeyDown);
            this.txt_cuentauti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterValida_KeyPress);
            this.txt_cuentauti.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtnumcuent_KeyUp);
            this.txt_cuentauti.Leave += new System.EventHandler(this.Txtnumcuent_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "DETALLE";
            // 
            // txt_detalle
            // 
            this.txt_detalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_detalle.Enabled = false;
            this.txt_detalle.Location = new System.Drawing.Point(256, 179);
            this.txt_detalle.MaxLength = 45;
            this.txt_detalle.Name = "txt_detalle";
            this.txt_detalle.Size = new System.Drawing.Size(321, 20);
            this.txt_detalle.TabIndex = 12;
            this.txt_detalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "CODIGO DE COMPROBANTE";
            // 
            // txt_codcomp
            // 
            this.txt_codcomp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_codcomp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_codcomp.Enabled = false;
            this.txt_codcomp.Location = new System.Drawing.Point(256, 208);
            this.txt_codcomp.MaxLength = 3;
            this.txt_codcomp.Name = "txt_codcomp";
            this.txt_codcomp.Size = new System.Drawing.Size(119, 20);
            this.txt_codcomp.TabIndex = 13;
            this.txt_codcomp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterVal_KeyPress);
            this.txt_codcomp.Leave += new System.EventHandler(this.Txt_codcomp_Leave);
            // 
            // txt_nominiing
            // 
            this.txt_nominiing.Enabled = false;
            this.txt_nominiing.Location = new System.Drawing.Point(381, 26);
            this.txt_nominiing.Name = "txt_nominiing";
            this.txt_nominiing.ReadOnly = true;
            this.txt_nominiing.Size = new System.Drawing.Size(315, 20);
            this.txt_nominiing.TabIndex = 3;
            // 
            // txt_nomutili
            // 
            this.txt_nomutili.Enabled = false;
            this.txt_nomutili.Location = new System.Drawing.Point(381, 137);
            this.txt_nomutili.Name = "txt_nomutili";
            this.txt_nomutili.ReadOnly = true;
            this.txt_nomutili.Size = new System.Drawing.Size(315, 20);
            this.txt_nomutili.TabIndex = 11;
            // 
            // txt_nomfincos
            // 
            this.txt_nomfincos.Enabled = false;
            this.txt_nomfincos.Location = new System.Drawing.Point(381, 110);
            this.txt_nomfincos.Name = "txt_nomfincos";
            this.txt_nomfincos.ReadOnly = true;
            this.txt_nomfincos.Size = new System.Drawing.Size(315, 20);
            this.txt_nomfincos.TabIndex = 9;
            // 
            // txt_nominicos
            // 
            this.txt_nominicos.Enabled = false;
            this.txt_nominicos.Location = new System.Drawing.Point(381, 83);
            this.txt_nominicos.Name = "txt_nominicos";
            this.txt_nominicos.ReadOnly = true;
            this.txt_nominicos.Size = new System.Drawing.Size(315, 20);
            this.txt_nominicos.TabIndex = 7;
            // 
            // txt_nomfining
            // 
            this.txt_nomfining.Enabled = false;
            this.txt_nomfining.Location = new System.Drawing.Point(381, 54);
            this.txt_nomfining.Name = "txt_nomfining";
            this.txt_nomfining.ReadOnly = true;
            this.txt_nomfining.Size = new System.Drawing.Size(315, 20);
            this.txt_nomfining.TabIndex = 5;
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
            this.menu_botones.Size = new System.Drawing.Size(727, 31);
            this.menu_botones.TabIndex = 128;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_nomcompro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_nomfining);
            this.groupBox1.Controls.Add(this.txt_cuentainiing);
            this.groupBox1.Controls.Add(this.txt_nominicos);
            this.groupBox1.Controls.Add(this.txt_cuentafining);
            this.groupBox1.Controls.Add(this.txt_nomfincos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_nomutili);
            this.groupBox1.Controls.Add(this.txt_cuentainicos);
            this.groupBox1.Controls.Add(this.txt_nominiing);
            this.groupBox1.Controls.Add(this.txt_cuentafincos);
            this.groupBox1.Controls.Add(this.txt_codcomp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_cuentauti);
            this.groupBox1.Controls.Add(this.txt_detalle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 247);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DEFINIR COMPROBANTE PARA CIERRE DE CUENTAS";
            // 
            // txt_nomcompro
            // 
            this.txt_nomcompro.Enabled = false;
            this.txt_nomcompro.Location = new System.Drawing.Point(381, 208);
            this.txt_nomcompro.Name = "txt_nomcompro";
            this.txt_nomcompro.ReadOnly = true;
            this.txt_nomcompro.Size = new System.Drawing.Size(315, 20);
            this.txt_nomcompro.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "DISTRIBUIR";
            // 
            // Form_Comprobantecierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 295);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menu_botones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Comprobantecierre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMPROBANTE CIERRE DE CUENTAS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_comprobantecierre_FormClosing);
            this.menu_botones.ResumeLayout(false);
            this.menu_botones.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cuentafining;
        private System.Windows.Forms.TextBox txt_cuentainiing;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cuentafincos;
        private System.Windows.Forms.TextBox txt_cuentainicos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cuentauti;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_detalle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_codcomp;
        private System.Windows.Forms.TextBox txt_nominiing;
        private System.Windows.Forms.TextBox txt_nomutili;
        private System.Windows.Forms.TextBox txt_nomfincos;
        private System.Windows.Forms.TextBox txt_nominicos;
        private System.Windows.Forms.TextBox txt_nomfining;
        private System.Windows.Forms.ToolStrip menu_botones;
        private System.Windows.Forms.ToolStripButton btn_nuevo;
        private System.Windows.Forms.ToolStripButton btn_guardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nomcompro;
    }
}