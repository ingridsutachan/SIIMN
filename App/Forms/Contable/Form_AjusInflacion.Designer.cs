﻿namespace App.Forms.Contable
{
    partial class Form_AjusInflacion
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
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_mes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_detalle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_tasa = new System.Windows.Forms.Label();
            this.cbx_comprobante = new System.Windows.Forms.ComboBox();
            this.menu_botones = new System.Windows.Forms.ToolStrip();
            this.btn_nuevo = new System.Windows.Forms.ToolStripButton();
            this.btn_generar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.menu_botones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 75;
            this.label6.Text = "MES";
            // 
            // cbx_mes
            // 
            this.cbx_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_mes.Enabled = false;
            this.cbx_mes.FormattingEnabled = true;
            this.cbx_mes.Location = new System.Drawing.Point(123, 31);
            this.cbx_mes.Name = "cbx_mes";
            this.cbx_mes.Size = new System.Drawing.Size(169, 21);
            this.cbx_mes.TabIndex = 1;
            this.cbx_mes.SelectionChangeCommitted += new System.EventHandler(this.cbx_mes_SelectionChangeCommitted);
            this.cbx_mes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTabVal_KeyPress);
            this.cbx_mes.Leave += new System.EventHandler(this.Cbx_mes_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "FECHA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "DETALLE";
            // 
            // txt_detalle
            // 
            this.txt_detalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_detalle.Enabled = false;
            this.txt_detalle.Location = new System.Drawing.Point(123, 56);
            this.txt_detalle.MaxLength = 55;
            this.txt_detalle.Name = "txt_detalle";
            this.txt_detalle.Size = new System.Drawing.Size(337, 20);
            this.txt_detalle.TabIndex = 2;
            this.txt_detalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTabVal_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "COMPROBANTE";
            // 
            // txt_numero
            // 
            this.txt_numero.Enabled = false;
            this.txt_numero.Location = new System.Drawing.Point(123, 129);
            this.txt_numero.MaxLength = 15;
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(122, 20);
            this.txt_numero.TabIndex = 4;
            this.txt_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTabVal_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 84;
            this.label5.Text = "NUMERO";
            // 
            // lbl_tasa
            // 
            this.lbl_tasa.AutoSize = true;
            this.lbl_tasa.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lbl_tasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tasa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_tasa.Location = new System.Drawing.Point(12, 109);
            this.lbl_tasa.Name = "lbl_tasa";
            this.lbl_tasa.Size = new System.Drawing.Size(107, 13);
            this.lbl_tasa.TabIndex = 89;
            this.lbl_tasa.Text = "TASA A APLICAR";
            this.lbl_tasa.Visible = false;
            // 
            // cbx_comprobante
            // 
            this.cbx_comprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_comprobante.Enabled = false;
            this.cbx_comprobante.FormattingEnabled = true;
            this.cbx_comprobante.Location = new System.Drawing.Point(123, 81);
            this.cbx_comprobante.Name = "cbx_comprobante";
            this.cbx_comprobante.Size = new System.Drawing.Size(215, 21);
            this.cbx_comprobante.TabIndex = 3;
            this.cbx_comprobante.Enter += new System.EventHandler(this.cbx_comprobante_Enter);
            this.cbx_comprobante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTabVal_KeyPress);
            this.cbx_comprobante.Leave += new System.EventHandler(this.cbx_comprobante_Leave);
            // 
            // menu_botones
            // 
            this.menu_botones.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu_botones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_nuevo,
            this.btn_generar,
            this.toolStripSeparator2,
            this.btn_salir});
            this.menu_botones.Location = new System.Drawing.Point(0, 0);
            this.menu_botones.Name = "menu_botones";
            this.menu_botones.Size = new System.Drawing.Size(468, 31);
            this.menu_botones.TabIndex = 98;
            this.menu_botones.Text = "toolStrip1";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_nuevo.Image = global::App.Properties.Resources.new24;
            this.btn_nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(28, 28);
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.ToolTipText = "Nuevo(Ctrl+N)";
            this.btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // btn_generar
            // 
            this.btn_generar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_generar.Enabled = false;
            this.btn_generar.Image = global::App.Properties.Resources.update;
            this.btn_generar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(28, 28);
            this.btn_generar.Text = "Guardar";
            this.btn_generar.ToolTipText = "Guardar(Ctrl+G)";
            this.btn_generar.Click += new System.EventHandler(this.Btn_generar_Click);
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
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(362, 35);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(42, 13);
            this.lbl_fecha.TabIndex = 99;
            this.lbl_fecha.Text = "FECHA";
            this.lbl_fecha.Visible = false;
            // 
            // Form_AjusInflacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 154);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.menu_botones);
            this.Controls.Add(this.cbx_comprobante);
            this.Controls.Add(this.lbl_tasa);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_detalle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbx_mes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form_AjusInflacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AJUSTES POR INFLACIÓN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_AjusInflacion_FormClosing);
            this.menu_botones.ResumeLayout(false);
            this.menu_botones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_mes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_detalle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_tasa;
        private System.Windows.Forms.ComboBox cbx_comprobante;
        private System.Windows.Forms.ToolStrip menu_botones;
        private System.Windows.Forms.ToolStripButton btn_nuevo;
        private System.Windows.Forms.ToolStripButton btn_generar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private System.Windows.Forms.Label lbl_fecha;
    }
}