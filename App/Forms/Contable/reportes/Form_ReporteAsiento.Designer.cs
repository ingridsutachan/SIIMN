﻿namespace App.Forms.Contable.Reportes
{
    partial class Form_ReporteAsiento
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
            this.crystal_ReporteResumido = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reporteLibroResumido1 = new App.Forms.Contable.Reportes.ReporteLibroResumido();
            this.crystal_reportasiento = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reporteAsiento1 = new App.Forms.Contable.Reportes.ReporteAsiento();
            this.SuspendLayout();
            // 
            // crystal_ReporteResumido
            // 
            this.crystal_ReporteResumido.ActiveViewIndex = 0;
            this.crystal_ReporteResumido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystal_ReporteResumido.CachedPageNumberPerDoc = 10;
            this.crystal_ReporteResumido.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystal_ReporteResumido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystal_ReporteResumido.Location = new System.Drawing.Point(0, 0);
            this.crystal_ReporteResumido.Name = "crystal_ReporteResumido";
            this.crystal_ReporteResumido.ReportSource = this.reporteLibroResumido1;
            this.crystal_ReporteResumido.ShowExportButton = false;
            this.crystal_ReporteResumido.ShowGroupTreeButton = false;
            this.crystal_ReporteResumido.ShowParameterPanelButton = false;
            this.crystal_ReporteResumido.Size = new System.Drawing.Size(937, 541);
            this.crystal_ReporteResumido.TabIndex = 2;
            this.crystal_ReporteResumido.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystal_ReporteResumido.Visible = false;
            // 
            // crystal_reportasiento
            // 
            this.crystal_reportasiento.ActiveViewIndex = 0;
            this.crystal_reportasiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystal_reportasiento.CachedPageNumberPerDoc = 10;
            this.crystal_reportasiento.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystal_reportasiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystal_reportasiento.Location = new System.Drawing.Point(0, 0);
            this.crystal_reportasiento.Name = "crystal_reportasiento";
            this.crystal_reportasiento.ReportSource = this.reporteAsiento1;
            this.crystal_reportasiento.ShowExportButton = false;
            this.crystal_reportasiento.ShowGroupTreeButton = false;
            this.crystal_reportasiento.ShowParameterPanelButton = false;
            this.crystal_reportasiento.Size = new System.Drawing.Size(937, 541);
            this.crystal_reportasiento.TabIndex = 1;
            this.crystal_reportasiento.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Form_ReporteAsiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 541);
            this.Controls.Add(this.crystal_ReporteResumido);
            this.Controls.Add(this.crystal_reportasiento);
            this.Name = "Form_ReporteAsiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ReporteAsiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_ReporteAsiento_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystal_reportasiento;
        private ReporteAsiento reporteAsiento1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystal_ReporteResumido;
        private ReporteLibroResumido reporteLibroResumido1;
    }
}