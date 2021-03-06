﻿namespace App.Forms.Contable
{
    partial class Form_Actualizar
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
            this.dt_hasta = new System.Windows.Forms.DateTimePicker();
            this.dt_desde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_acttodos = new System.Windows.Forms.GroupBox();
            this.menu_botones = new System.Windows.Forms.ToolStrip();
            this.btn_actualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_numeroasiento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_comprobante = new System.Windows.Forms.ComboBox();
            this.panel_actuno = new System.Windows.Forms.GroupBox();
            this.panel_acttodos.SuspendLayout();
            this.menu_botones.SuspendLayout();
            this.panel_actuno.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_hasta
            // 
            this.dt_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_hasta.Location = new System.Drawing.Point(363, 29);
            this.dt_hasta.Name = "dt_hasta";
            this.dt_hasta.Size = new System.Drawing.Size(242, 20);
            this.dt_hasta.TabIndex = 2;
            this.dt_hasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            this.dt_hasta.Leave += new System.EventHandler(this.Datetime_Leave);
            // 
            // dt_desde
            // 
            this.dt_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_desde.Location = new System.Drawing.Point(47, 29);
            this.dt_desde.Name = "dt_desde";
            this.dt_desde.Size = new System.Drawing.Size(232, 20);
            this.dt_desde.TabIndex = 1;
            this.dt_desde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            this.dt_desde.Leave += new System.EventHandler(this.Datetime_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "HASTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "DE";
            // 
            // panel_acttodos
            // 
            this.panel_acttodos.Controls.Add(this.dt_desde);
            this.panel_acttodos.Controls.Add(this.dt_hasta);
            this.panel_acttodos.Controls.Add(this.label3);
            this.panel_acttodos.Controls.Add(this.label1);
            this.panel_acttodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_acttodos.Location = new System.Drawing.Point(12, 48);
            this.panel_acttodos.Name = "panel_acttodos";
            this.panel_acttodos.Size = new System.Drawing.Size(616, 70);
            this.panel_acttodos.TabIndex = 30;
            this.panel_acttodos.TabStop = false;
            this.panel_acttodos.Text = "PERIODO A ACTUALIZAR:";
            this.panel_acttodos.Visible = false;
            // 
            // menu_botones
            // 
            this.menu_botones.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu_botones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_actualizar,
            this.toolStripSeparator2,
            this.btn_salir});
            this.menu_botones.Location = new System.Drawing.Point(0, 0);
            this.menu_botones.Name = "menu_botones";
            this.menu_botones.Size = new System.Drawing.Size(655, 31);
            this.menu_botones.TabIndex = 99;
            this.menu_botones.Text = "toolStrip1";
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_actualizar.Image = global::App.Properties.Resources.update;
            this.btn_actualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(28, 28);
            this.btn_actualizar.Text = "Guardar";
            this.btn_actualizar.ToolTipText = "Actualizar(Ctrl+A)";
            this.btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(376, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 103;
            this.label6.Text = "NUMERO";
            // 
            // txt_numeroasiento
            // 
            this.txt_numeroasiento.Location = new System.Drawing.Point(472, 30);
            this.txt_numeroasiento.MaxLength = 10;
            this.txt_numeroasiento.Name = "txt_numeroasiento";
            this.txt_numeroasiento.Size = new System.Drawing.Size(139, 20);
            this.txt_numeroasiento.TabIndex = 2;
            this.txt_numeroasiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumerico_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 102;
            this.label5.Text = "COMPROBANTE";
            // 
            // cbx_comprobante
            // 
            this.cbx_comprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_comprobante.FormattingEnabled = true;
            this.cbx_comprobante.Location = new System.Drawing.Point(113, 30);
            this.cbx_comprobante.Name = "cbx_comprobante";
            this.cbx_comprobante.Size = new System.Drawing.Size(229, 21);
            this.cbx_comprobante.TabIndex = 1;
            this.cbx_comprobante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // panel_actuno
            // 
            this.panel_actuno.Controls.Add(this.label5);
            this.panel_actuno.Controls.Add(this.label6);
            this.panel_actuno.Controls.Add(this.cbx_comprobante);
            this.panel_actuno.Controls.Add(this.txt_numeroasiento);
            this.panel_actuno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_actuno.Location = new System.Drawing.Point(12, 40);
            this.panel_actuno.Name = "panel_actuno";
            this.panel_actuno.Size = new System.Drawing.Size(630, 78);
            this.panel_actuno.TabIndex = 104;
            this.panel_actuno.TabStop = false;
            this.panel_actuno.Visible = false;
            // 
            // Form_Actualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 126);
            this.Controls.Add(this.panel_actuno);
            this.Controls.Add(this.menu_botones);
            this.Controls.Add(this.panel_acttodos);
            this.MaximizeBox = false;
            this.Name = "Form_Actualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACTUALIZAR ASIENTOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Actualizar_FormClosing);
            this.panel_acttodos.ResumeLayout(false);
            this.panel_acttodos.PerformLayout();
            this.menu_botones.ResumeLayout(false);
            this.menu_botones.PerformLayout();
            this.panel_actuno.ResumeLayout(false);
            this.panel_actuno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt_hasta;
        private System.Windows.Forms.DateTimePicker dt_desde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox panel_acttodos;
        private System.Windows.Forms.ToolStrip menu_botones;
        private System.Windows.Forms.ToolStripButton btn_actualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_numeroasiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_comprobante;
        private System.Windows.Forms.GroupBox panel_actuno;

    }
}