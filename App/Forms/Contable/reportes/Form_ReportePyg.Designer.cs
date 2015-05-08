namespace App.Forms.Contable.Reportes
{
    partial class Form_ReportePyg
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
            this.crystal_ReportAux = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reportePyg1 = new App.Forms.Contable.Reportes.ReportePyg();
            this.SuspendLayout();
            // 
            // crystal_ReportAux
            // 
            this.crystal_ReportAux.ActiveViewIndex = 0;
            this.crystal_ReportAux.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystal_ReportAux.CachedPageNumberPerDoc = 10;
            this.crystal_ReportAux.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystal_ReportAux.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystal_ReportAux.Location = new System.Drawing.Point(0, 0);
            this.crystal_ReportAux.Name = "crystal_ReportAux";
            this.crystal_ReportAux.ReportSource = this.reportePyg1;
            this.crystal_ReportAux.ShowExportButton = false;
            this.crystal_ReportAux.ShowGroupTreeButton = false;
            this.crystal_ReportAux.ShowLogo = false;
            this.crystal_ReportAux.ShowParameterPanelButton = false;
            this.crystal_ReportAux.Size = new System.Drawing.Size(728, 415);
            this.crystal_ReportAux.TabIndex = 6;
            this.crystal_ReportAux.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Form_ReportePyg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 415);
            this.Controls.Add(this.crystal_ReportAux);
            this.Name = "Form_ReportePyg";
            this.Text = "Form_ReportePyg";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystal_ReportAux;
        private ReportePyg reportePyg1;
    }
}