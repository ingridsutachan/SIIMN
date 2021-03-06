﻿namespace App.Forms.Contable.Reportes
{
    partial class Form_ReportePresupuesto
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_informe = new System.Windows.Forms.ToolStripButton();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.fecha_informepres = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.txt_cuenta = new System.Windows.Forms.TextBox();
            this.lbl_cuenta = new System.Windows.Forms.Label();
            this.txt_anio = new System.Windows.Forms.TextBox();
            this.lbl_anio = new System.Windows.Forms.Label();
            this.txt_centro = new System.Windows.Forms.TextBox();
            this.lbl_centro = new System.Windows.Forms.Label();
            this.txt_nombrecuenta = new System.Windows.Forms.TextBox();
            this.txt_descripcentro = new System.Windows.Forms.TextBox();
            this.crystal_Presupuesto = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reportePresupuesto1 = new App.Forms.Contable.Reportes.ReportePresupuesto();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_informe,
            this.btn_salir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(576, 31);
            this.toolStrip1.TabIndex = 243;
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
            this.btn_informe.Click += new System.EventHandler(this.Btn_informe_ButtonClick);
            // 
            // btn_salir
            // 
            this.btn_salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_salir.Image = global::App.Properties.Resources.salir24;
            this.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(28, 28);
            this.btn_salir.Text = "btn_salir";
            this.btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // fecha_informepres
            // 
            this.fecha_informepres.Location = new System.Drawing.Point(160, 173);
            this.fecha_informepres.Name = "fecha_informepres";
            this.fecha_informepres.Size = new System.Drawing.Size(200, 20);
            this.fecha_informepres.TabIndex = 6;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(12, 177);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(47, 13);
            this.lbl_fecha.TabIndex = 242;
            this.lbl_fecha.Text = "FECHA";
            // 
            // txt_cuenta
            // 
            this.txt_cuenta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_cuenta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_cuenta.Location = new System.Drawing.Point(160, 66);
            this.txt_cuenta.MaxLength = 12;
            this.txt_cuenta.Name = "txt_cuenta";
            this.txt_cuenta.Size = new System.Drawing.Size(154, 20);
            this.txt_cuenta.TabIndex = 2;
            this.txt_cuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterValidar_KeyPress);
            this.txt_cuenta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtnumcuent_KeyUp);
            this.txt_cuenta.Leave += new System.EventHandler(this.Txtnumcuent_Leave);
            // 
            // lbl_cuenta
            // 
            this.lbl_cuenta.AutoSize = true;
            this.lbl_cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cuenta.Location = new System.Drawing.Point(12, 70);
            this.lbl_cuenta.Name = "lbl_cuenta";
            this.lbl_cuenta.Size = new System.Drawing.Size(57, 13);
            this.lbl_cuenta.TabIndex = 241;
            this.lbl_cuenta.Text = "CUENTA";
            // 
            // txt_anio
            // 
            this.txt_anio.Location = new System.Drawing.Point(160, 38);
            this.txt_anio.MaxLength = 12;
            this.txt_anio.Name = "txt_anio";
            this.txt_anio.Size = new System.Drawing.Size(110, 20);
            this.txt_anio.TabIndex = 1;
            this.txt_anio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterAnio_KeyPress);
            this.txt_anio.Leave += new System.EventHandler(this.Txtanio_Leave);
            // 
            // lbl_anio
            // 
            this.lbl_anio.AutoSize = true;
            this.lbl_anio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_anio.Location = new System.Drawing.Point(12, 42);
            this.lbl_anio.Name = "lbl_anio";
            this.lbl_anio.Size = new System.Drawing.Size(33, 13);
            this.lbl_anio.TabIndex = 240;
            this.lbl_anio.Text = "AÑO";
            // 
            // txt_centro
            // 
            this.txt_centro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_centro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_centro.Location = new System.Drawing.Point(160, 118);
            this.txt_centro.MaxLength = 12;
            this.txt_centro.Name = "txt_centro";
            this.txt_centro.Size = new System.Drawing.Size(110, 20);
            this.txt_centro.TabIndex = 4;
            this.txt_centro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterValidar_KeyPress);
            this.txt_centro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_centro_KeyUp);
            this.txt_centro.Leave += new System.EventHandler(this.Txt_centro_Leave);
            // 
            // lbl_centro
            // 
            this.lbl_centro.AutoSize = true;
            this.lbl_centro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_centro.Location = new System.Drawing.Point(12, 122);
            this.lbl_centro.Name = "lbl_centro";
            this.lbl_centro.Size = new System.Drawing.Size(133, 13);
            this.lbl_centro.TabIndex = 245;
            this.lbl_centro.Text = "CENTRO DE COSTOS";
            // 
            // txt_nombrecuenta
            // 
            this.txt_nombrecuenta.Enabled = false;
            this.txt_nombrecuenta.Location = new System.Drawing.Point(160, 92);
            this.txt_nombrecuenta.Name = "txt_nombrecuenta";
            this.txt_nombrecuenta.ReadOnly = true;
            this.txt_nombrecuenta.Size = new System.Drawing.Size(299, 20);
            this.txt_nombrecuenta.TabIndex = 3;
            // 
            // txt_descripcentro
            // 
            this.txt_descripcentro.Enabled = false;
            this.txt_descripcentro.Location = new System.Drawing.Point(160, 144);
            this.txt_descripcentro.Name = "txt_descripcentro";
            this.txt_descripcentro.ReadOnly = true;
            this.txt_descripcentro.Size = new System.Drawing.Size(408, 20);
            this.txt_descripcentro.TabIndex = 5;
            // 
            // crystal_Presupuesto
            // 
            this.crystal_Presupuesto.ActiveViewIndex = 0;
            this.crystal_Presupuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystal_Presupuesto.CachedPageNumberPerDoc = 10;
            this.crystal_Presupuesto.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystal_Presupuesto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crystal_Presupuesto.Location = new System.Drawing.Point(0, -331);
            this.crystal_Presupuesto.Name = "crystal_Presupuesto";
            this.crystal_Presupuesto.ReportSource = this.reportePresupuesto1;
            this.crystal_Presupuesto.ShowExportButton = false;
            this.crystal_Presupuesto.ShowGroupTreeButton = false;
            this.crystal_Presupuesto.ShowParameterPanelButton = false;
            this.crystal_Presupuesto.Size = new System.Drawing.Size(576, 532);
            this.crystal_Presupuesto.TabIndex = 0;
            this.crystal_Presupuesto.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystal_Presupuesto.Visible = false;
            // 
            // Form_ReportePresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 201);
            this.Controls.Add(this.txt_nombrecuenta);
            this.Controls.Add(this.txt_descripcentro);
            this.Controls.Add(this.txt_centro);
            this.Controls.Add(this.lbl_centro);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.fecha_informepres);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.txt_cuenta);
            this.Controls.Add(this.lbl_cuenta);
            this.Controls.Add(this.txt_anio);
            this.Controls.Add(this.lbl_anio);
            this.Controls.Add(this.crystal_Presupuesto);
            this.Name = "Form_ReportePresupuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE PRESUPUESTO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_ReportePresupuesto_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReportePresupuesto reportePresupuesto1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystal_Presupuesto;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private System.Windows.Forms.DateTimePicker fecha_informepres;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.TextBox txt_cuenta;
        private System.Windows.Forms.Label lbl_cuenta;
        private System.Windows.Forms.TextBox txt_anio;
        private System.Windows.Forms.Label lbl_anio;
        private System.Windows.Forms.TextBox txt_centro;
        private System.Windows.Forms.Label lbl_centro;
        private System.Windows.Forms.TextBox txt_nombrecuenta;
        private System.Windows.Forms.TextBox txt_descripcentro;
        private System.Windows.Forms.ToolStripButton btn_informe;

    }
}