﻿namespace App.Forms.Contable
{
    partial class Form_Desactualizar
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
            this.menu_botones = new System.Windows.Forms.ToolStrip();
            this.btn_actualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.panel_todos = new System.Windows.Forms.GroupBox();
            this.pan_uno = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_comprobante = new System.Windows.Forms.ComboBox();
            this.txt_numeroasiento = new System.Windows.Forms.TextBox();
            this.cbx_mes2 = new System.Windows.Forms.ComboBox();
            this.cbx_mes1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menu_botones.SuspendLayout();
            this.panel_todos.SuspendLayout();
            this.pan_uno.SuspendLayout();
            this.SuspendLayout();
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
            this.menu_botones.Size = new System.Drawing.Size(643, 31);
            this.menu_botones.TabIndex = 100;
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
            // 
            // panel_todos
            // 
            this.panel_todos.Controls.Add(this.pan_uno);
            this.panel_todos.Controls.Add(this.cbx_mes2);
            this.panel_todos.Controls.Add(this.cbx_mes1);
            this.panel_todos.Controls.Add(this.label3);
            this.panel_todos.Controls.Add(this.label1);
            this.panel_todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_todos.Location = new System.Drawing.Point(12, 34);
            this.panel_todos.Name = "panel_todos";
            this.panel_todos.Size = new System.Drawing.Size(616, 70);
            this.panel_todos.TabIndex = 101;
            this.panel_todos.TabStop = false;
            this.panel_todos.Text = "PERIODO A DESACTUALIZAR:";
            this.panel_todos.Visible = false;
            // 
            // pan_uno
            // 
            this.pan_uno.Controls.Add(this.label2);
            this.pan_uno.Controls.Add(this.label4);
            this.pan_uno.Controls.Add(this.cbx_comprobante);
            this.pan_uno.Controls.Add(this.txt_numeroasiento);
            this.pan_uno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_uno.Location = new System.Drawing.Point(0, 0);
            this.pan_uno.Name = "pan_uno";
            this.pan_uno.Size = new System.Drawing.Size(630, 78);
            this.pan_uno.TabIndex = 105;
            this.pan_uno.TabStop = false;
            this.pan_uno.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 102;
            this.label2.Text = "COMPROBANTE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(376, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 103;
            this.label4.Text = "NUMERO";
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
            // txt_numeroasiento
            // 
            this.txt_numeroasiento.Location = new System.Drawing.Point(472, 30);
            this.txt_numeroasiento.MaxLength = 10;
            this.txt_numeroasiento.Name = "txt_numeroasiento";
            this.txt_numeroasiento.Size = new System.Drawing.Size(139, 20);
            this.txt_numeroasiento.TabIndex = 2;
            this.txt_numeroasiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumerico_KeyPress);
            // 
            // cbx_mes2
            // 
            this.cbx_mes2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_mes2.FormattingEnabled = true;
            this.cbx_mes2.Location = new System.Drawing.Point(363, 27);
            this.cbx_mes2.Name = "cbx_mes2";
            this.cbx_mes2.Size = new System.Drawing.Size(229, 21);
            this.cbx_mes2.TabIndex = 2;
            this.cbx_mes2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // cbx_mes1
            // 
            this.cbx_mes1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_mes1.FormattingEnabled = true;
            this.cbx_mes1.Location = new System.Drawing.Point(47, 27);
            this.cbx_mes1.Name = "cbx_mes1";
            this.cbx_mes1.Size = new System.Drawing.Size(229, 21);
            this.cbx_mes1.TabIndex = 1;
            this.cbx_mes1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
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
            // Form_Desactualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 113);
            this.Controls.Add(this.panel_todos);
            this.Controls.Add(this.menu_botones);
            this.Name = "Form_Desactualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DESACTUALIZAR ASIENTOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Desactualizar_FormClosing);
            this.menu_botones.ResumeLayout(false);
            this.menu_botones.PerformLayout();
            this.panel_todos.ResumeLayout(false);
            this.panel_todos.PerformLayout();
            this.pan_uno.ResumeLayout(false);
            this.pan_uno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menu_botones;
        private System.Windows.Forms.ToolStripButton btn_actualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private System.Windows.Forms.GroupBox panel_todos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox pan_uno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_comprobante;
        private System.Windows.Forms.TextBox txt_numeroasiento;
        private System.Windows.Forms.ComboBox cbx_mes2;
        private System.Windows.Forms.ComboBox cbx_mes1;


    }
}