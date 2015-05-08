namespace App.Forms.Contable
{
    partial class Frm_LibroDiario
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
            this.combo_mesde = new System.Windows.Forms.ComboBox();
            this.pan_boton = new System.Windows.Forms.Panel();
            this.salircuent = new System.Windows.Forms.Button();
            this.btn_generar = new System.Windows.Forms.Button();
            this.check_encabe = new System.Windows.Forms.CheckBox();
            this.dtt_fecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_docfin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_docin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_compro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_meshasta = new System.Windows.Forms.ComboBox();
            this.pnl_detallado = new System.Windows.Forms.Panel();
            this.pnl_resumido = new System.Windows.Forms.Panel();
            this.cbx_resumido = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.pan_boton.SuspendLayout();
            this.pnl_detallado.SuspendLayout();
            this.pnl_resumido.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 87;
            this.label6.Text = "Mes    De:";
            // 
            // combo_mesde
            // 
            this.combo_mesde.FormattingEnabled = true;
            this.combo_mesde.Location = new System.Drawing.Point(83, 17);
            this.combo_mesde.Name = "combo_mesde";
            this.combo_mesde.Size = new System.Drawing.Size(133, 21);
            this.combo_mesde.TabIndex = 86;
            // 
            // pan_boton
            // 
            this.pan_boton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_boton.Controls.Add(this.salircuent);
            this.pan_boton.Controls.Add(this.btn_generar);
            this.pan_boton.Location = new System.Drawing.Point(339, 230);
            this.pan_boton.Name = "pan_boton";
            this.pan_boton.Size = new System.Drawing.Size(104, 46);
            this.pan_boton.TabIndex = 85;
            // 
            // salircuent
            // 
            this.salircuent.Image = global::App.Properties.Resources.exit;
            this.salircuent.Location = new System.Drawing.Point(56, 4);
            this.salircuent.Name = "salircuent";
            this.salircuent.Size = new System.Drawing.Size(43, 32);
            this.salircuent.TabIndex = 40;
            this.salircuent.TabStop = false;
            this.salircuent.UseVisualStyleBackColor = true;
            // 
            // btn_generar
            // 
            this.btn_generar.Image = global::App.Properties.Resources.ok;
            this.btn_generar.Location = new System.Drawing.Point(9, 4);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(35, 33);
            this.btn_generar.TabIndex = 18;
            this.btn_generar.UseVisualStyleBackColor = true;
            // 
            // check_encabe
            // 
            this.check_encabe.AutoSize = true;
            this.check_encabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_encabe.Location = new System.Drawing.Point(6, 185);
            this.check_encabe.Name = "check_encabe";
            this.check_encabe.Size = new System.Drawing.Size(167, 17);
            this.check_encabe.TabIndex = 84;
            this.check_encabe.Text = "Imprimir con encabezado";
            this.check_encabe.UseVisualStyleBackColor = true;
            // 
            // dtt_fecha
            // 
            this.dtt_fecha.Location = new System.Drawing.Point(99, 157);
            this.dtt_fecha.Name = "dtt_fecha";
            this.dtt_fecha.Size = new System.Drawing.Size(200, 20);
            this.dtt_fecha.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "Fecha";
            // 
            // txt_docfin
            // 
            this.txt_docfin.Location = new System.Drawing.Point(179, 116);
            this.txt_docfin.MaxLength = 2;
            this.txt_docfin.Name = "txt_docfin";
            this.txt_docfin.Size = new System.Drawing.Size(120, 20);
            this.txt_docfin.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Documento Final [**]Todos";
            // 
            // txt_docin
            // 
            this.txt_docin.Location = new System.Drawing.Point(179, 85);
            this.txt_docin.MaxLength = 2;
            this.txt_docin.Name = "txt_docin";
            this.txt_docin.Size = new System.Drawing.Size(120, 20);
            this.txt_docin.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Documento Inicial [**]Todos";
            // 
            // txt_compro
            // 
            this.txt_compro.Location = new System.Drawing.Point(179, 57);
            this.txt_compro.MaxLength = 2;
            this.txt_compro.Name = "txt_compro";
            this.txt_compro.Size = new System.Drawing.Size(47, 20);
            this.txt_compro.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "Comprobante [**]Todos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(230, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "Hasta:";
            // 
            // cbx_meshasta
            // 
            this.cbx_meshasta.FormattingEnabled = true;
            this.cbx_meshasta.Location = new System.Drawing.Point(284, 17);
            this.cbx_meshasta.Name = "cbx_meshasta";
            this.cbx_meshasta.Size = new System.Drawing.Size(133, 21);
            this.cbx_meshasta.TabIndex = 74;
            // 
            // pnl_detallado
            // 
            this.pnl_detallado.Controls.Add(this.combo_mesde);
            this.pnl_detallado.Controls.Add(this.label6);
            this.pnl_detallado.Controls.Add(this.check_encabe);
            this.pnl_detallado.Controls.Add(this.cbx_meshasta);
            this.pnl_detallado.Controls.Add(this.dtt_fecha);
            this.pnl_detallado.Controls.Add(this.label4);
            this.pnl_detallado.Controls.Add(this.label5);
            this.pnl_detallado.Controls.Add(this.label1);
            this.pnl_detallado.Controls.Add(this.txt_docfin);
            this.pnl_detallado.Controls.Add(this.txt_compro);
            this.pnl_detallado.Controls.Add(this.label3);
            this.pnl_detallado.Controls.Add(this.label2);
            this.pnl_detallado.Controls.Add(this.txt_docin);
            this.pnl_detallado.Location = new System.Drawing.Point(8, 6);
            this.pnl_detallado.Name = "pnl_detallado";
            this.pnl_detallado.Size = new System.Drawing.Size(435, 218);
            this.pnl_detallado.TabIndex = 88;
            this.pnl_detallado.Visible = false;
            // 
            // pnl_resumido
            // 
            this.pnl_resumido.Controls.Add(this.cbx_resumido);
            this.pnl_resumido.Controls.Add(this.label7);
            this.pnl_resumido.Controls.Add(this.checkBox1);
            this.pnl_resumido.Controls.Add(this.dateTimePicker1);
            this.pnl_resumido.Controls.Add(this.label8);
            this.pnl_resumido.Location = new System.Drawing.Point(8, 6);
            this.pnl_resumido.Name = "pnl_resumido";
            this.pnl_resumido.Size = new System.Drawing.Size(353, 105);
            this.pnl_resumido.TabIndex = 89;
            this.pnl_resumido.Visible = false;
            // 
            // cbx_resumido
            // 
            this.cbx_resumido.FormattingEnabled = true;
            this.cbx_resumido.Location = new System.Drawing.Point(84, 9);
            this.cbx_resumido.Name = "cbx_resumido";
            this.cbx_resumido.Size = new System.Drawing.Size(133, 21);
            this.cbx_resumido.TabIndex = 91;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 92;
            this.label7.Text = "Mes:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(11, 75);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(167, 17);
            this.checkBox1.TabIndex = 90;
            this.checkBox1.Text = "Imprimir con encabezado";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 89;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 88;
            this.label8.Text = "Fecha";
            // 
            // Frm_LibroDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 283);
            this.Controls.Add(this.pnl_resumido);
            this.Controls.Add(this.pnl_detallado);
            this.Controls.Add(this.pan_boton);
            this.Name = "Frm_LibroDiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LIBRO DIARIO";
            this.pan_boton.ResumeLayout(false);
            this.pnl_detallado.ResumeLayout(false);
            this.pnl_detallado.PerformLayout();
            this.pnl_resumido.ResumeLayout(false);
            this.pnl_resumido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combo_mesde;
        private System.Windows.Forms.Panel pan_boton;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Button salircuent;
        private System.Windows.Forms.CheckBox check_encabe;
        private System.Windows.Forms.DateTimePicker dtt_fecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_docfin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_docin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_compro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_meshasta;
        private System.Windows.Forms.Panel pnl_detallado;
        private System.Windows.Forms.Panel pnl_resumido;
        private System.Windows.Forms.ComboBox cbx_resumido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
    }
}