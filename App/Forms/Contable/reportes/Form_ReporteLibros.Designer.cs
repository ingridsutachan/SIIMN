namespace App.Forms.Contable.Reportes
{
    partial class Form_ReporteLibros
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
            this.crystal_ReporteInv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reporteLibroMayor1 = new App.Forms.Contable.Reportes.ReporteLibroMayor();
            this.reporteLibroAuxiliar1 = new App.Forms.Contable.Reportes.ReporteLibroAuxiliar();
            this.crystal_ReportAux = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystal_ReporteInv
            // 
            this.crystal_ReporteInv.ActiveViewIndex = 0;
            this.crystal_ReporteInv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystal_ReporteInv.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystal_ReporteInv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystal_ReporteInv.Location = new System.Drawing.Point(0, 0);
            this.crystal_ReporteInv.Name = "crystal_ReporteInv";
            this.crystal_ReporteInv.ReportSource = this.reporteLibroMayor1;
            this.crystal_ReporteInv.ShowExportButton = false;
            this.crystal_ReporteInv.ShowGroupTreeButton = false;
            this.crystal_ReporteInv.ShowLogo = false;
            this.crystal_ReporteInv.ShowParameterPanelButton = false;
            this.crystal_ReporteInv.Size = new System.Drawing.Size(915, 509);
            this.crystal_ReporteInv.TabIndex = 4;
            this.crystal_ReporteInv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // crystal_ReportAux
            // 
            this.crystal_ReportAux.ActiveViewIndex = 0;
            this.crystal_ReportAux.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystal_ReportAux.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystal_ReportAux.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystal_ReportAux.Location = new System.Drawing.Point(0, 0);
            this.crystal_ReportAux.Name = "crystal_ReportAux";
            this.crystal_ReportAux.ReportSource = this.reporteLibroAuxiliar1;
            this.crystal_ReportAux.ShowExportButton = false;
            this.crystal_ReportAux.ShowGroupTreeButton = false;
            this.crystal_ReportAux.ShowLogo = false;
            this.crystal_ReportAux.ShowParameterPanelButton = false;
            this.crystal_ReportAux.Size = new System.Drawing.Size(915, 509);
            this.crystal_ReportAux.TabIndex = 5;
            this.crystal_ReportAux.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Form_ReporteLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 509);
            this.Controls.Add(this.crystal_ReportAux);
            this.Controls.Add(this.crystal_ReporteInv);
            this.Name = "Form_ReporteLibros";
            this.Text = "Form_R";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_ReporteLibros_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystal_ReporteInv;
        private ReporteLibroMayor reporteLibroMayor1;
        private ReporteLibroAuxiliar reporteLibroAuxiliar1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystal_ReportAux;
    }
}