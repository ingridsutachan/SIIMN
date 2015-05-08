namespace App.Forms.Contable
{
    partial class Form_MovsinAct
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
            this.label10 = new System.Windows.Forms.Label();
            this.txt_anio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_compro = new System.Windows.Forms.TextBox();
            this.txt_docin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_docfin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtt_fecha = new System.Windows.Forms.DateTimePicker();
            this.check_encabe = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_mes = new System.Windows.Forms.ComboBox();
            this.menu_botones = new System.Windows.Forms.ToolStrip();
            this.btn_imprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.menu_botones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(244, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 60;
            this.label10.Text = "AÑO";
            // 
            // txt_anio
            // 
            this.txt_anio.Location = new System.Drawing.Point(291, 37);
            this.txt_anio.MaxLength = 10;
            this.txt_anio.Name = "txt_anio";
            this.txt_anio.Size = new System.Drawing.Size(57, 20);
            this.txt_anio.TabIndex = 2;
            this.txt_anio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaNumerico_KeyPress);
            this.txt_anio.Leave += new System.EventHandler(this.Txt_anio_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "COMPROBANTE[**]TODOS";
            // 
            // txt_compro
            // 
            this.txt_compro.Location = new System.Drawing.Point(228, 72);
            this.txt_compro.MaxLength = 2;
            this.txt_compro.Name = "txt_compro";
            this.txt_compro.Size = new System.Drawing.Size(47, 20);
            this.txt_compro.TabIndex = 3;
            this.txt_compro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaNumericoyPor_KeyPress);
            this.txt_compro.Leave += new System.EventHandler(this.Asterisco_Leave);
            // 
            // txt_docin
            // 
            this.txt_docin.Location = new System.Drawing.Point(228, 100);
            this.txt_docin.MaxLength = 2;
            this.txt_docin.Name = "txt_docin";
            this.txt_docin.Size = new System.Drawing.Size(120, 20);
            this.txt_docin.TabIndex = 4;
            this.txt_docin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            this.txt_docin.Leave += new System.EventHandler(this.Asteriscodocumento_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "DCUMENTO INICIAL [**] TODOS";
            // 
            // txt_docfin
            // 
            this.txt_docfin.Location = new System.Drawing.Point(228, 131);
            this.txt_docfin.MaxLength = 2;
            this.txt_docfin.Name = "txt_docfin";
            this.txt_docfin.Size = new System.Drawing.Size(120, 20);
            this.txt_docfin.TabIndex = 5;
            this.txt_docfin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            this.txt_docfin.Leave += new System.EventHandler(this.Asterisco_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "DOCUMENTO FINAL [**] TODOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "FECHA";
            // 
            // dtt_fecha
            // 
            this.dtt_fecha.Location = new System.Drawing.Point(148, 162);
            this.dtt_fecha.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtt_fecha.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtt_fecha.Name = "dtt_fecha";
            this.dtt_fecha.Size = new System.Drawing.Size(200, 20);
            this.dtt_fecha.TabIndex = 6;
            this.dtt_fecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // check_encabe
            // 
            this.check_encabe.AutoSize = true;
            this.check_encabe.Checked = true;
            this.check_encabe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_encabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_encabe.Location = new System.Drawing.Point(12, 196);
            this.check_encabe.Name = "check_encabe";
            this.check_encabe.Size = new System.Drawing.Size(201, 17);
            this.check_encabe.TabIndex = 7;
            this.check_encabe.Text = "IMPRIMIR CON ENCABEZADO";
            this.check_encabe.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 73;
            this.label6.Text = "MES:";
            // 
            // cbx_mes
            // 
            this.cbx_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_mes.FormattingEnabled = true;
            this.cbx_mes.Location = new System.Drawing.Point(52, 40);
            this.cbx_mes.Name = "cbx_mes";
            this.cbx_mes.Size = new System.Drawing.Size(133, 21);
            this.cbx_mes.TabIndex = 1;
            this.cbx_mes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // menu_botones
            // 
            this.menu_botones.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu_botones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_imprimir,
            this.toolStripSeparator2,
            this.btn_salir});
            this.menu_botones.Location = new System.Drawing.Point(0, 0);
            this.menu_botones.Name = "menu_botones";
            this.menu_botones.Size = new System.Drawing.Size(364, 31);
            this.menu_botones.TabIndex = 100;
            this.menu_botones.Text = "toolStrip1";
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_imprimir.Image = global::App.Properties.Resources.printer24;
            this.btn_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(28, 28);
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.ToolTipText = "Imprimir(Ctrl+P)";
            this.btn_imprimir.Click += new System.EventHandler(this.Btn_imprimir_Click);
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
            // Form_MovsinAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 223);
            this.Controls.Add(this.menu_botones);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbx_mes);
            this.Controls.Add(this.check_encabe);
            this.Controls.Add(this.dtt_fecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_docfin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_docin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_compro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_anio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form_MovsinAct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MOVIMIENTOS SIN ACTUALIZAR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_MovsinAct_FormClosing);
            this.menu_botones.ResumeLayout(false);
            this.menu_botones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_anio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_compro;
        private System.Windows.Forms.TextBox txt_docin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_docfin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtt_fecha;
        private System.Windows.Forms.CheckBox check_encabe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_mes;
        private System.Windows.Forms.ToolStrip menu_botones;
        private System.Windows.Forms.ToolStripButton btn_imprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_salir;
    }
}