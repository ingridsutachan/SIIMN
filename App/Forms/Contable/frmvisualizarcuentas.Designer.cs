namespace App.Forms.Contable
{
    partial class Frmvisualizarcuentas
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
            this.dgvdatoscuenta = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatoscuenta)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvdatoscuenta
            // 
            this.dgvdatoscuenta.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvdatoscuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatoscuenta.Location = new System.Drawing.Point(6, 63);
            this.dgvdatoscuenta.MultiSelect = false;
            this.dgvdatoscuenta.Name = "dgvdatoscuenta";
            this.dgvdatoscuenta.ReadOnly = true;
            this.dgvdatoscuenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdatoscuenta.Size = new System.Drawing.Size(808, 353);
            this.dgvdatoscuenta.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_buscar);
            this.panel3.Controls.Add(this.txt_buscar);
            this.panel3.Location = new System.Drawing.Point(6, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(808, 34);
            this.panel3.TabIndex = 18;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = global::App.Properties.Resources.search;
            this.btn_buscar.Location = new System.Drawing.Point(775, 3);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(28, 25);
            this.btn_buscar.TabIndex = 13;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(483, 6);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(286, 20);
            this.txt_buscar.TabIndex = 12;
            this.txt_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_buscar_KeyPress);
            // 
            // frmvisualizarcuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 428);
            this.Controls.Add(this.dgvdatoscuenta);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.Name = "frmvisualizarcuentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CUENTAS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatoscuenta)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdatoscuenta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;

    }
}