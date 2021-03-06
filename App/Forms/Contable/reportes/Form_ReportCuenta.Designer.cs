﻿namespace App.Forms.Contable.Reportes
{
    partial class Form_ReportCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ReportCuenta));
            this.crystal_reportecuenta = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reporteCuentas1 = new App.Forms.Contable.Reportes.ReporteCuentas();
            this.fecha_informecuenta = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.txt_cuentafininforme = new System.Windows.Forms.TextBox();
            this.lbl_cuentafinal = new System.Windows.Forms.Label();
            this.txt_cuentainiinforme = new System.Windows.Forms.TextBox();
            this.lbl_cuentainicial = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_informe = new System.Windows.Forms.ToolStripButton();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.txt_nombrecuentaini = new System.Windows.Forms.TextBox();
            this.txt_nombrecuentafin = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystal_reportecuenta
            // 
            this.crystal_reportecuenta.ActiveViewIndex = -1;
            this.crystal_reportecuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystal_reportecuenta.CachedPageNumberPerDoc = 10;
            this.crystal_reportecuenta.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystal_reportecuenta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crystal_reportecuenta.Location = new System.Drawing.Point(0, -334);
            this.crystal_reportecuenta.Name = "crystal_reportecuenta";
            this.crystal_reportecuenta.ShowExportButton = false;
            this.crystal_reportecuenta.ShowGroupTreeButton = false;
            this.crystal_reportecuenta.ShowParameterPanelButton = false;
            this.crystal_reportecuenta.Size = new System.Drawing.Size(431, 519);
            this.crystal_reportecuenta.TabIndex = 0;
            this.crystal_reportecuenta.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystal_reportecuenta.Visible = false;
            // 
            // fecha_informecuenta
            // 
            this.fecha_informecuenta.Location = new System.Drawing.Point(202, 150);
            this.fecha_informecuenta.Name = "fecha_informecuenta";
            this.fecha_informecuenta.Size = new System.Drawing.Size(200, 20);
            this.fecha_informecuenta.TabIndex = 3;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(14, 154);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(47, 13);
            this.lbl_fecha.TabIndex = 231;
            this.lbl_fecha.Text = "FECHA";
            // 
            // txt_cuentafininforme
            // 
            this.txt_cuentafininforme.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_cuentafininforme.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_cuentafininforme.Enabled = false;
            this.txt_cuentafininforme.Location = new System.Drawing.Point(202, 98);
            this.txt_cuentafininforme.MaxLength = 12;
            this.txt_cuentafininforme.Name = "txt_cuentafininforme";
            this.txt_cuentafininforme.Size = new System.Drawing.Size(110, 20);
            this.txt_cuentafininforme.TabIndex = 2;
            this.txt_cuentafininforme.Text = "**";
            this.txt_cuentafininforme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validacion_Keypress);
            this.txt_cuentafininforme.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_cuentafininforme_KeyUp);
            // 
            // lbl_cuentafinal
            // 
            this.lbl_cuentafinal.AutoSize = true;
            this.lbl_cuentafinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cuentafinal.Location = new System.Drawing.Point(14, 102);
            this.lbl_cuentafinal.Name = "lbl_cuentafinal";
            this.lbl_cuentafinal.Size = new System.Drawing.Size(164, 13);
            this.lbl_cuentafinal.TabIndex = 230;
            this.lbl_cuentafinal.Text = "CUENTA FINAL [**] TODAS";
            // 
            // txt_cuentainiinforme
            // 
            this.txt_cuentainiinforme.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_cuentainiinforme.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_cuentainiinforme.Location = new System.Drawing.Point(202, 46);
            this.txt_cuentainiinforme.MaxLength = 12;
            this.txt_cuentainiinforme.Name = "txt_cuentainiinforme";
            this.txt_cuentainiinforme.Size = new System.Drawing.Size(110, 20);
            this.txt_cuentainiinforme.TabIndex = 1;
            this.txt_cuentainiinforme.Text = "**";
            this.txt_cuentainiinforme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validacion_Keypress);
            this.txt_cuentainiinforme.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_cuentainiinforme_KeyUp);
            // 
            // lbl_cuentainicial
            // 
            this.lbl_cuentainicial.AutoSize = true;
            this.lbl_cuentainicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cuentainicial.Location = new System.Drawing.Point(14, 50);
            this.lbl_cuentainicial.Name = "lbl_cuentainicial";
            this.lbl_cuentainicial.Size = new System.Drawing.Size(173, 13);
            this.lbl_cuentainicial.TabIndex = 228;
            this.lbl_cuentainicial.Text = "CUENTA INICIAL [**] TODAS";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_informe,
            this.btn_salir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(431, 31);
            this.toolStrip1.TabIndex = 236;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_informe
            // 
            this.btn_informe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_informe.Image = global::App.Properties.Resources.informe24;
            this.btn_informe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_informe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_informe.Name = "btn_informe";
            this.btn_informe.Size = new System.Drawing.Size(28, 28);
            this.btn_informe.Text = "Informe";
            this.btn_informe.ToolTipText = "Informe(Ctrl+P)";
            this.btn_informe.Click += new System.EventHandler(this.Btn_informe_ButtonClick);
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
            // txt_nombrecuentaini
            // 
            this.txt_nombrecuentaini.Enabled = false;
            this.txt_nombrecuentaini.Location = new System.Drawing.Point(14, 71);
            this.txt_nombrecuentaini.Name = "txt_nombrecuentaini";
            this.txt_nombrecuentaini.ReadOnly = true;
            this.txt_nombrecuentaini.Size = new System.Drawing.Size(408, 20);
            this.txt_nombrecuentaini.TabIndex = 237;
            // 
            // txt_nombrecuentafin
            // 
            this.txt_nombrecuentafin.Enabled = false;
            this.txt_nombrecuentafin.Location = new System.Drawing.Point(15, 123);
            this.txt_nombrecuentafin.Name = "txt_nombrecuentafin";
            this.txt_nombrecuentafin.ReadOnly = true;
            this.txt_nombrecuentafin.Size = new System.Drawing.Size(408, 20);
            this.txt_nombrecuentafin.TabIndex = 238;
            // 
            // Form_ReportCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(431, 185);
            this.Controls.Add(this.txt_nombrecuentaini);
            this.Controls.Add(this.txt_nombrecuentafin);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.fecha_informecuenta);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.txt_cuentafininforme);
            this.Controls.Add(this.lbl_cuentafinal);
            this.Controls.Add(this.txt_cuentainiinforme);
            this.Controls.Add(this.lbl_cuentainicial);
            this.Controls.Add(this.crystal_reportecuenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_ReportCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INFORME CUENTAS O PUC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_ReportCuenta_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystal_reportecuenta;
        private ReporteCuentas reporteCuentas1;
        private System.Windows.Forms.DateTimePicker fecha_informecuenta;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.TextBox txt_cuentafininforme;
        private System.Windows.Forms.Label lbl_cuentafinal;
        private System.Windows.Forms.TextBox txt_cuentainiinforme;
        private System.Windows.Forms.Label lbl_cuentainicial;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private System.Windows.Forms.TextBox txt_nombrecuentaini;
        private System.Windows.Forms.TextBox txt_nombrecuentafin;
        private System.Windows.Forms.ToolStripButton btn_informe;
    }
}