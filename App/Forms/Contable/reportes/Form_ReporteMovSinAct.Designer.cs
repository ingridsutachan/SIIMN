﻿namespace App.Forms.Contable.Reportes
{
    partial class Form_ReporteMovSinAct
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
            this.crystal_ReporteMovSin = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reporteMovSinAct1 = new App.Forms.Contable.Reportes.ReporteMovSinAct();
            this.SuspendLayout();
            // 
            // crystal_ReporteMovSin
            // 
            this.crystal_ReporteMovSin.ActiveViewIndex = 0;
            this.crystal_ReporteMovSin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystal_ReporteMovSin.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystal_ReporteMovSin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystal_ReporteMovSin.Location = new System.Drawing.Point(0, 0);
            this.crystal_ReporteMovSin.Name = "crystal_ReporteMovSin";
            this.crystal_ReporteMovSin.ReportSource = this.reporteMovSinAct1;
            this.crystal_ReporteMovSin.ShowGroupTreeButton = false;
            this.crystal_ReporteMovSin.ShowParameterPanelButton = false;
            this.crystal_ReporteMovSin.Size = new System.Drawing.Size(942, 567);
            this.crystal_ReporteMovSin.TabIndex = 0;
            this.crystal_ReporteMovSin.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Form_ReporteMovSinAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 567);
            this.Controls.Add(this.crystal_ReporteMovSin);
            this.Name = "Form_ReporteMovSinAct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ReporteMovSinAct";
            this.ResumeLayout(false);

        }

        #endregion

        private ReporteMovSinAct reporteMovSinAct1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystal_ReporteMovSin;
    }
}