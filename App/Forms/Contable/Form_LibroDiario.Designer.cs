﻿namespace App.Forms.Contable
{
    partial class Form_LibroDiario
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
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_mesdesde = new System.Windows.Forms.ComboBox();
            this.check_encabe = new System.Windows.Forms.CheckBox();
            this.dtt_fecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_docfin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_docin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_compro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_meshasta = new System.Windows.Forms.ComboBox();
            this.pnl_detallado = new System.Windows.Forms.Panel();
            this.porcentaje = new System.Windows.Forms.Label();
            this.progressbarAct = new System.Windows.Forms.ProgressBar();
            this.pnl_resumido = new System.Windows.Forms.Panel();
            this.check_encabezadores = new System.Windows.Forms.CheckBox();
            this.cbx_resumido = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dt_resumido = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.menu_botones = new System.Windows.Forms.ToolStrip();
            this.btn_imprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_cancelar = new System.Windows.Forms.ToolStripButton();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.pnl_detallado.SuspendLayout();
            this.pnl_resumido.SuspendLayout();
            this.menu_botones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 87;
            this.label6.Text = "MES INICIAL: ";
            // 
            // cbx_mesdesde
            // 
            this.cbx_mesdesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_mesdesde.FormattingEnabled = true;
            this.cbx_mesdesde.Location = new System.Drawing.Point(98, 6);
            this.cbx_mesdesde.Name = "cbx_mesdesde";
            this.cbx_mesdesde.Size = new System.Drawing.Size(133, 21);
            this.cbx_mesdesde.TabIndex = 1;
            this.cbx_mesdesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // check_encabe
            // 
            this.check_encabe.AutoSize = true;
            this.check_encabe.Checked = true;
            this.check_encabe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_encabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_encabe.Location = new System.Drawing.Point(14, 167);
            this.check_encabe.Name = "check_encabe";
            this.check_encabe.Size = new System.Drawing.Size(201, 17);
            this.check_encabe.TabIndex = 7;
            this.check_encabe.Text = "IMPRIMIR CON ENCABEZADO";
            this.check_encabe.UseVisualStyleBackColor = true;
            this.check_encabe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // dtt_fecha
            // 
            this.dtt_fecha.Location = new System.Drawing.Point(94, 137);
            this.dtt_fecha.Name = "dtt_fecha";
            this.dtt_fecha.Size = new System.Drawing.Size(200, 20);
            this.dtt_fecha.TabIndex = 6;
            this.dtt_fecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "FECHA";
            // 
            // txt_docfin
            // 
            this.txt_docfin.Location = new System.Drawing.Point(227, 106);
            this.txt_docfin.MaxLength = 2;
            this.txt_docfin.Name = "txt_docfin";
            this.txt_docfin.Size = new System.Drawing.Size(120, 20);
            this.txt_docfin.TabIndex = 5;
            this.txt_docfin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaNumericoyPor_KeyPress);
            this.txt_docfin.Leave += new System.EventHandler(this.Asterisco_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "DOCUMENTO FINAL [**] TODOS";
            // 
            // txt_docin
            // 
            this.txt_docin.Location = new System.Drawing.Point(227, 75);
            this.txt_docin.MaxLength = 2;
            this.txt_docin.Name = "txt_docin";
            this.txt_docin.Size = new System.Drawing.Size(120, 20);
            this.txt_docin.TabIndex = 4;
            this.txt_docin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaNumericoyPor_KeyPress);
            this.txt_docin.Leave += new System.EventHandler(this.Asteriscodocumento_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "DOCUMENTIO INICIAL [**] TODOS";
            // 
            // txt_compro
            // 
            this.txt_compro.Location = new System.Drawing.Point(227, 47);
            this.txt_compro.MaxLength = 2;
            this.txt_compro.Name = "txt_compro";
            this.txt_compro.Size = new System.Drawing.Size(47, 20);
            this.txt_compro.TabIndex = 3;
            this.txt_compro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaNumericoyPor_KeyPress);
            this.txt_compro.Leave += new System.EventHandler(this.Asterisco_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "COMPROBANTE [**]TODOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "MES  FINAL:";
            // 
            // cbx_meshasta
            // 
            this.cbx_meshasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_meshasta.FormattingEnabled = true;
            this.cbx_meshasta.Location = new System.Drawing.Point(323, 6);
            this.cbx_meshasta.Name = "cbx_meshasta";
            this.cbx_meshasta.Size = new System.Drawing.Size(133, 21);
            this.cbx_meshasta.TabIndex = 2;
            this.cbx_meshasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // pnl_detallado
            // 
            this.pnl_detallado.Controls.Add(this.cbx_mesdesde);
            this.pnl_detallado.Controls.Add(this.label6);
            this.pnl_detallado.Controls.Add(this.check_encabe);
            this.pnl_detallado.Controls.Add(this.cbx_meshasta);
            this.pnl_detallado.Controls.Add(this.dtt_fecha);
            this.pnl_detallado.Controls.Add(this.label4);
            this.pnl_detallado.Controls.Add(this.label5);
            this.pnl_detallado.Controls.Add(this.label1);
            this.pnl_detallado.Controls.Add(this.txt_docfin);
            this.pnl_detallado.Controls.Add(this.txt_compro);
            this.pnl_detallado.Controls.Add(this.label3);
            this.pnl_detallado.Controls.Add(this.label2);
            this.pnl_detallado.Controls.Add(this.txt_docin);
            this.pnl_detallado.Location = new System.Drawing.Point(6, 34);
            this.pnl_detallado.Name = "pnl_detallado";
            this.pnl_detallado.Size = new System.Drawing.Size(467, 190);
            this.pnl_detallado.TabIndex = 88;
            this.pnl_detallado.Visible = false;
            // 
            // porcentaje
            // 
            this.porcentaje.AutoSize = true;
            this.porcentaje.Location = new System.Drawing.Point(438, 254);
            this.porcentaje.Name = "porcentaje";
            this.porcentaje.Size = new System.Drawing.Size(35, 13);
            this.porcentaje.TabIndex = 108;
            this.porcentaje.Text = "label2";
            this.porcentaje.Visible = false;
            // 
            // progressbarAct
            // 
            this.progressbarAct.Location = new System.Drawing.Point(163, 230);
            this.progressbarAct.Name = "progressbarAct";
            this.progressbarAct.Size = new System.Drawing.Size(310, 23);
            this.progressbarAct.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressbarAct.TabIndex = 107;
            this.progressbarAct.Visible = false;
            // 
            // pnl_resumido
            // 
            this.pnl_resumido.Controls.Add(this.check_encabezadores);
            this.pnl_resumido.Controls.Add(this.cbx_resumido);
            this.pnl_resumido.Controls.Add(this.label7);
            this.pnl_resumido.Controls.Add(this.dt_resumido);
            this.pnl_resumido.Controls.Add(this.label8);
            this.pnl_resumido.Location = new System.Drawing.Point(6, 34);
            this.pnl_resumido.Name = "pnl_resumido";
            this.pnl_resumido.Size = new System.Drawing.Size(353, 91);
            this.pnl_resumido.TabIndex = 89;
            this.pnl_resumido.Visible = false;
            // 
            // check_encabezadores
            // 
            this.check_encabezadores.AutoSize = true;
            this.check_encabezadores.Checked = true;
            this.check_encabezadores.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_encabezadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_encabezadores.Location = new System.Drawing.Point(11, 63);
            this.check_encabezadores.Name = "check_encabezadores";
            this.check_encabezadores.Size = new System.Drawing.Size(201, 17);
            this.check_encabezadores.TabIndex = 3;
            this.check_encabezadores.Text = "IMPRIMIR CON ENCABEZADO";
            this.check_encabezadores.UseVisualStyleBackColor = true;
            this.check_encabezadores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // cbx_resumido
            // 
            this.cbx_resumido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_resumido.FormattingEnabled = true;
            this.cbx_resumido.Location = new System.Drawing.Point(84, 9);
            this.cbx_resumido.Name = "cbx_resumido";
            this.cbx_resumido.Size = new System.Drawing.Size(133, 21);
            this.cbx_resumido.TabIndex = 1;
            this.cbx_resumido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 92;
            this.label7.Text = "MES:";
            // 
            // dt_resumido
            // 
            this.dt_resumido.Location = new System.Drawing.Point(84, 37);
            this.dt_resumido.Name = "dt_resumido";
            this.dt_resumido.Size = new System.Drawing.Size(200, 20);
            this.dt_resumido.TabIndex = 2;
            this.dt_resumido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 88;
            this.label8.Text = "FECHA:";
            // 
            // menu_botones
            // 
            this.menu_botones.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu_botones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_imprimir,
            this.toolStripSeparator2,
            this.btn_cancelar,
            this.btn_salir});
            this.menu_botones.Location = new System.Drawing.Point(0, 0);
            this.menu_botones.Name = "menu_botones";
            this.menu_botones.Size = new System.Drawing.Size(479, 31);
            this.menu_botones.TabIndex = 101;
            this.menu_botones.Text = "toolStrip1";
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_imprimir.Image = global::App.Properties.Resources.printer24;
            this.btn_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(28, 28);
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.ToolTipText = "Imprimir(Ctrl+P)";
            this.btn_imprimir.Click += new System.EventHandler(this.Btn_imprimir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_cancelar.Image = global::App.Properties.Resources.cancel24;
            this.btn_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(28, 28);
            this.btn_cancelar.Text = "toolStripButton1";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
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
            // 
            // Form_LibroDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 268);
            this.Controls.Add(this.porcentaje);
            this.Controls.Add(this.menu_botones);
            this.Controls.Add(this.pnl_resumido);
            this.Controls.Add(this.progressbarAct);
            this.Controls.Add(this.pnl_detallado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form_LibroDiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LIBRO DIARIO";
            this.pnl_detallado.ResumeLayout(false);
            this.pnl_detallado.PerformLayout();
            this.pnl_resumido.ResumeLayout(false);
            this.pnl_resumido.PerformLayout();
            this.menu_botones.ResumeLayout(false);
            this.menu_botones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_mesdesde;
        private System.Windows.Forms.CheckBox check_encabe;
        private System.Windows.Forms.DateTimePicker dtt_fecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_docfin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_docin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_compro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_meshasta;
        private System.Windows.Forms.Panel pnl_detallado;
        private System.Windows.Forms.Panel pnl_resumido;
        private System.Windows.Forms.ComboBox cbx_resumido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dt_resumido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStrip menu_botones;
        private System.Windows.Forms.ToolStripButton btn_imprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private System.Windows.Forms.CheckBox check_encabezadores;
        private System.Windows.Forms.Label porcentaje;
        private System.Windows.Forms.ProgressBar progressbarAct;
        private System.Windows.Forms.ToolStripButton btn_cancelar;
    }
}