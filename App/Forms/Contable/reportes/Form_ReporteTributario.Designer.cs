namespace App.Forms.Contable.Reportes
{
    partial class Form_ReporteTributario
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
            this.crystal_reporttribut = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reporteTributario1 = new App.Forms.Contable.Reportes.ReporteTributario();
            this.SuspendLayout();
            // 
            // crystal_reporttribut
            // 
            this.crystal_reporttribut.ActiveViewIndex = 0;
            this.crystal_reporttribut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystal_reporttribut.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystal_reporttribut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystal_reporttribut.Location = new System.Drawing.Point(0, 0);
            this.crystal_reporttribut.Name = "crystal_reporttribut";
            this.crystal_reporttribut.ReportSource = this.reporteTributario1;
            this.crystal_reporttribut.ShowExportButton = false;
            this.crystal_reporttribut.ShowGroupTreeButton = false;
            this.crystal_reporttribut.ShowParameterPanelButton = false;
            this.crystal_reporttribut.Size = new System.Drawing.Size(863, 634);
            this.crystal_reporttribut.TabIndex = 2;
            this.crystal_reporttribut.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Form_ReporteTributario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 634);
            this.Controls.Add(this.crystal_reporttribut);
            this.MaximizeBox = false;
            this.Name = "Form_ReporteTributario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ReporteTributario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_ReporteTributario_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystal_reporttribut;
        private ReporteTributario reporteTributario1;
    }
}