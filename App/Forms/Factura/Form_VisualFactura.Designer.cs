﻿namespace App.Forms.Factura
{
    partial class Form_VisualFactura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ts_buscar = new System.Windows.Forms.ToolStripSplitButton();
            this.ts_buscar1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_buscar2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_buscar3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_buscar4 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.dgv_busqueda = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_buscar,
            this.btn_salir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(911, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ts_buscar
            // 
            this.ts_buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_buscar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_buscar1,
            this.ts_buscar2,
            this.ts_buscar3,
            this.ts_buscar4});
            this.ts_buscar.Image = global::App.Properties.Resources.search24;
            this.ts_buscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_buscar.Name = "ts_buscar";
            this.ts_buscar.Size = new System.Drawing.Size(40, 28);
            this.ts_buscar.Text = "Buscar";
            // 
            // ts_buscar1
            // 
            this.ts_buscar1.Name = "ts_buscar1";
            this.ts_buscar1.Size = new System.Drawing.Size(83, 22);
            this.ts_buscar1.Text = "1.";
            this.ts_buscar1.Click += new System.EventHandler(this.ts_buscar1_Click);
            // 
            // ts_buscar2
            // 
            this.ts_buscar2.Name = "ts_buscar2";
            this.ts_buscar2.Size = new System.Drawing.Size(83, 22);
            this.ts_buscar2.Text = "2.";
            this.ts_buscar2.Click += new System.EventHandler(this.ts_buscar2_Click);
            // 
            // ts_buscar3
            // 
            this.ts_buscar3.Name = "ts_buscar3";
            this.ts_buscar3.Size = new System.Drawing.Size(83, 22);
            this.ts_buscar3.Text = "3.";
            this.ts_buscar3.Click += new System.EventHandler(this.ts_buscar3_Click);
            // 
            // ts_buscar4
            // 
            this.ts_buscar4.Name = "ts_buscar4";
            this.ts_buscar4.Size = new System.Drawing.Size(83, 22);
            this.ts_buscar4.Text = "4.";
            this.ts_buscar4.Click += new System.EventHandler(this.ts_buscar4_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_salir.Image = global::App.Properties.Resources.salir24;
            this.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(28, 28);
            this.btn_salir.Text = "btn_salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.Location = new System.Drawing.Point(12, 49);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(63, 13);
            this.lbl_buscar.TabIndex = 61;
            this.lbl_buscar.Text = "Busqueda";
            this.lbl_buscar.TextChanged += new System.EventHandler(this.lbl_buscar_TextChanged);
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_busqueda.Location = new System.Drawing.Point(89, 46);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(419, 20);
            this.txt_busqueda.TabIndex = 62;
            this.txt_busqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_busqueda_KeyPress_1);
            // 
            // dgv_busqueda
            // 
            this.dgv_busqueda.AllowUserToAddRows = false;
            this.dgv_busqueda.AllowUserToDeleteRows = false;
            this.dgv_busqueda.AllowUserToResizeRows = false;
            this.dgv_busqueda.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_busqueda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_busqueda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_busqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_busqueda.GridColor = System.Drawing.SystemColors.GrayText;
            this.dgv_busqueda.Location = new System.Drawing.Point(12, 86);
            this.dgv_busqueda.MultiSelect = false;
            this.dgv_busqueda.Name = "dgv_busqueda";
            this.dgv_busqueda.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_busqueda.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_busqueda.RowHeadersVisible = false;
            this.dgv_busqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_busqueda.Size = new System.Drawing.Size(878, 510);
            this.dgv_busqueda.TabIndex = 63;
            this.dgv_busqueda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_busqueda_CellDoubleClick);
            // 
            // Form_VisualFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 640);
            this.Controls.Add(this.dgv_busqueda);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "Form_VisualFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSQUEDA";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_VisualFactura_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton ts_buscar;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private System.Windows.Forms.ToolStripMenuItem ts_buscar1;
        private System.Windows.Forms.ToolStripMenuItem ts_buscar2;
        private System.Windows.Forms.ToolStripMenuItem ts_buscar3;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.DataGridView dgv_busqueda;
        private System.Windows.Forms.ToolStripMenuItem ts_buscar4;
    }
}