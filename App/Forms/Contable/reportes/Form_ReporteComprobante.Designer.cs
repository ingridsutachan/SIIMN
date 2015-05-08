namespace App.Forms.Contable.Reportes
{
    partial class Form_ReporteComprobante
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
            this.crystal_reportcompro = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reporteComprobante1 = new App.Forms.Contable.Reportes.ReporteComprobante();
            this.SuspendLayout();
            // 
            // crystal_reportcompro
            // 
            this.crystal_reportcompro.ActiveViewIndex = 0;
            this.crystal_reportcompro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystal_reportcompro.CachedPageNumberPerDoc = 10;
            this.crystal_reportcompro.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystal_reportcompro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystal_reportcompro.Location = new System.Drawing.Point(0, 0);
            this.crystal_reportcompro.Name = "crystal_reportcompro";
            this.crystal_reportcompro.ReportSource = this.reporteComprobante1;
            this.crystal_reportcompro.ShowExportButton = false;
            this.crystal_reportcompro.ShowGroupTreeButton = false;
            this.crystal_reportcompro.ShowParameterPanelButton = false;
            this.crystal_reportcompro.Size = new System.Drawing.Size(691, 634);
            this.crystal_reportcompro.TabIndex = 1;
            this.crystal_reportcompro.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Form_ReporteComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 634);
            this.Controls.Add(this.crystal_reportcompro);
            this.Name = "Form_ReporteComprobante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE TIPOS DE COMPROBANTE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_ReporteComprobante_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystal_reportcompro;
        private ReporteComprobante reporteComprobante1;
    }
}