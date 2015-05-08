namespace App.Forms.Cartera
{
    partial class Form_Docxdia
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
            this.lbl_descuadre = new System.Windows.Forms.Label();
            this.txt_rec1 = new System.Windows.Forms.TextBox();
            this.rb_fecha = new System.Windows.Forms.RadioButton();
            this.rb_cliente = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pnl_visual = new System.Windows.Forms.Panel();
            this.pnl_impre = new System.Windows.Forms.Panel();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.salircuent = new System.Windows.Forms.Button();
            this.combo_papel = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_papel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.check_totales = new System.Windows.Forms.CheckBox();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.txt_valorini = new System.Windows.Forms.TextBox();
            this.txt_valorfin = new System.Windows.Forms.TextBox();
            this.lbl_valorfin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_2 = new System.Windows.Forms.DateTimePicker();
            this.dt_1 = new System.Windows.Forms.DateTimePicker();
            this.lblinicial = new System.Windows.Forms.Label();
            this.txt_clienini = new System.Windows.Forms.TextBox();
            this.txt_clienfin = new System.Windows.Forms.TextBox();
            this.lblfinal = new System.Windows.Forms.Label();
            this.pnl_visual.SuspendLayout();
            this.pnl_impre.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_descuadre
            // 
            this.lbl_descuadre.AutoSize = true;
            this.lbl_descuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descuadre.Location = new System.Drawing.Point(12, 9);
            this.lbl_descuadre.Name = "lbl_descuadre";
            this.lbl_descuadre.Size = new System.Drawing.Size(226, 13);
            this.lbl_descuadre.TabIndex = 244;
            this.lbl_descuadre.Text = "Tipo de transacción inicial [**] Todas :";
            // 
            // txt_rec1
            // 
            this.txt_rec1.Location = new System.Drawing.Point(244, 6);
            this.txt_rec1.MaxLength = 10;
            this.txt_rec1.Name = "txt_rec1";
            this.txt_rec1.Size = new System.Drawing.Size(64, 20);
            this.txt_rec1.TabIndex = 248;
            // 
            // rb_fecha
            // 
            this.rb_fecha.AutoSize = true;
            this.rb_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_fecha.Location = new System.Drawing.Point(146, 65);
            this.rb_fecha.Name = "rb_fecha";
            this.rb_fecha.Size = new System.Drawing.Size(60, 17);
            this.rb_fecha.TabIndex = 251;
            this.rb_fecha.TabStop = true;
            this.rb_fecha.Text = "Fecha";
            this.rb_fecha.UseVisualStyleBackColor = true;
            this.rb_fecha.CheckedChanged += new System.EventHandler(this.rb_fecha_CheckedChanged);
            // 
            // rb_cliente
            // 
            this.rb_cliente.AutoSize = true;
            this.rb_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_cliente.Location = new System.Drawing.Point(244, 65);
            this.rb_cliente.Name = "rb_cliente";
            this.rb_cliente.Size = new System.Drawing.Size(64, 17);
            this.rb_cliente.TabIndex = 250;
            this.rb_cliente.TabStop = true;
            this.rb_cliente.Text = "Cliente";
            this.rb_cliente.UseVisualStyleBackColor = true;
            this.rb_cliente.CheckedChanged += new System.EventHandler(this.rb_cliente_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 249;
            this.label1.Text = "Ordenado Por:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(244, 31);
            this.textBox4.MaxLength = 10;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(64, 20);
            this.textBox4.TabIndex = 273;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 13);
            this.label10.TabIndex = 272;
            this.label10.Text = "Tipo de transacción final :";
            // 
            // pnl_visual
            // 
            this.pnl_visual.Controls.Add(this.combo_papel);
            this.pnl_visual.Controls.Add(this.label9);
            this.pnl_visual.Controls.Add(this.label8);
            this.pnl_visual.Controls.Add(this.lbl_papel);
            this.pnl_visual.Controls.Add(this.label6);
            this.pnl_visual.Controls.Add(this.dateTimePicker1);
            this.pnl_visual.Controls.Add(this.check_totales);
            this.pnl_visual.Controls.Add(this.lbl_valor);
            this.pnl_visual.Controls.Add(this.txt_valorini);
            this.pnl_visual.Controls.Add(this.txt_valorfin);
            this.pnl_visual.Controls.Add(this.lbl_valorfin);
            this.pnl_visual.Controls.Add(this.label3);
            this.pnl_visual.Controls.Add(this.label2);
            this.pnl_visual.Controls.Add(this.dt_2);
            this.pnl_visual.Controls.Add(this.dt_1);
            this.pnl_visual.Controls.Add(this.lblinicial);
            this.pnl_visual.Controls.Add(this.txt_clienini);
            this.pnl_visual.Controls.Add(this.txt_clienfin);
            this.pnl_visual.Controls.Add(this.lblfinal);
            this.pnl_visual.Location = new System.Drawing.Point(15, 88);
            this.pnl_visual.Name = "pnl_visual";
            this.pnl_visual.Size = new System.Drawing.Size(321, 282);
            this.pnl_visual.TabIndex = 274;
            this.pnl_visual.Visible = false;
            // 
            // pnl_impre
            // 
            this.pnl_impre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_impre.Controls.Add(this.btn_guardar);
            this.pnl_impre.Controls.Add(this.salircuent);
            this.pnl_impre.Location = new System.Drawing.Point(232, 376);
            this.pnl_impre.Name = "pnl_impre";
            this.pnl_impre.Size = new System.Drawing.Size(104, 46);
            this.pnl_impre.TabIndex = 291;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = global::App.Properties.Resources.imprimirgrande;
            this.btn_guardar.Location = new System.Drawing.Point(9, 4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(35, 33);
            this.btn_guardar.TabIndex = 18;
            this.btn_guardar.UseVisualStyleBackColor = true;
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
            // combo_papel
            // 
            this.combo_papel.FormattingEnabled = true;
            this.combo_papel.Items.AddRange(new object[] {
            "CARTA 133 COL",
            "CARTA 80 COL"});
            this.combo_papel.Location = new System.Drawing.Point(113, 252);
            this.combo_papel.Name = "combo_papel";
            this.combo_papel.Size = new System.Drawing.Size(121, 21);
            this.combo_papel.TabIndex = 290;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 289;
            this.label9.Text = "Cliente ini";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 288;
            this.label8.Text = "Cliente fin";
            this.label8.Visible = false;
            // 
            // lbl_papel
            // 
            this.lbl_papel.AutoSize = true;
            this.lbl_papel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_papel.Location = new System.Drawing.Point(8, 252);
            this.lbl_papel.Name = "lbl_papel";
            this.lbl_papel.Size = new System.Drawing.Size(47, 13);
            this.lbl_papel.TabIndex = 287;
            this.lbl_papel.Text = "Papel: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 286;
            this.label6.Text = "Fecha Informe:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 222);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 285;
            // 
            // check_totales
            // 
            this.check_totales.AutoSize = true;
            this.check_totales.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.check_totales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_totales.Location = new System.Drawing.Point(8, 199);
            this.check_totales.Name = "check_totales";
            this.check_totales.Size = new System.Drawing.Size(131, 17);
            this.check_totales.TabIndex = 284;
            this.check_totales.Text = "Desea solo totales";
            this.check_totales.UseVisualStyleBackColor = true;
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor.Location = new System.Drawing.Point(8, 153);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(135, 13);
            this.lbl_valor.TabIndex = 280;
            this.lbl_valor.Text = "Valor Inicial[**]Todos: ";
            // 
            // txt_valorini
            // 
            this.txt_valorini.Location = new System.Drawing.Point(167, 147);
            this.txt_valorini.MaxLength = 10;
            this.txt_valorini.Name = "txt_valorini";
            this.txt_valorini.Size = new System.Drawing.Size(74, 20);
            this.txt_valorini.TabIndex = 281;
            // 
            // txt_valorfin
            // 
            this.txt_valorfin.Location = new System.Drawing.Point(167, 173);
            this.txt_valorfin.MaxLength = 10;
            this.txt_valorfin.Name = "txt_valorfin";
            this.txt_valorfin.Size = new System.Drawing.Size(74, 20);
            this.txt_valorfin.TabIndex = 283;
            // 
            // lbl_valorfin
            // 
            this.lbl_valorfin.AutoSize = true;
            this.lbl_valorfin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valorfin.Location = new System.Drawing.Point(8, 176);
            this.lbl_valorfin.Name = "lbl_valorfin";
            this.lbl_valorfin.Size = new System.Drawing.Size(75, 13);
            this.lbl_valorfin.TabIndex = 282;
            this.lbl_valorfin.Text = "Valor Final: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 279;
            this.label3.Text = "Fecha Final:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 278;
            this.label2.Text = "Fecha Inicial:";
            // 
            // dt_2
            // 
            this.dt_2.Location = new System.Drawing.Point(113, 118);
            this.dt_2.Name = "dt_2";
            this.dt_2.Size = new System.Drawing.Size(200, 20);
            this.dt_2.TabIndex = 277;
            // 
            // dt_1
            // 
            this.dt_1.Location = new System.Drawing.Point(113, 92);
            this.dt_1.Name = "dt_1";
            this.dt_1.Size = new System.Drawing.Size(200, 20);
            this.dt_1.TabIndex = 276;
            // 
            // lblinicial
            // 
            this.lblinicial.AutoSize = true;
            this.lblinicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinicial.Location = new System.Drawing.Point(8, 14);
            this.lblinicial.Name = "lblinicial";
            this.lblinicial.Size = new System.Drawing.Size(145, 13);
            this.lblinicial.TabIndex = 272;
            this.lblinicial.Text = "Cliente Inicial[**]Todos: ";
            // 
            // txt_clienini
            // 
            this.txt_clienini.Location = new System.Drawing.Point(166, 7);
            this.txt_clienini.MaxLength = 10;
            this.txt_clienini.Name = "txt_clienini";
            this.txt_clienini.Size = new System.Drawing.Size(74, 20);
            this.txt_clienini.TabIndex = 273;
            // 
            // txt_clienfin
            // 
            this.txt_clienfin.Location = new System.Drawing.Point(166, 50);
            this.txt_clienfin.MaxLength = 10;
            this.txt_clienfin.Name = "txt_clienfin";
            this.txt_clienfin.Size = new System.Drawing.Size(74, 20);
            this.txt_clienfin.TabIndex = 275;
            // 
            // lblfinal
            // 
            this.lblfinal.AutoSize = true;
            this.lblfinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfinal.Location = new System.Drawing.Point(8, 53);
            this.lblfinal.Name = "lblfinal";
            this.lblfinal.Size = new System.Drawing.Size(85, 13);
            this.lblfinal.TabIndex = 274;
            this.lblfinal.Text = "Cliente Final: ";
            // 
            // Form_Docxdia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 429);
            this.Controls.Add(this.pnl_impre);
            this.Controls.Add(this.pnl_visual);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rb_fecha);
            this.Controls.Add(this.rb_cliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_rec1);
            this.Controls.Add(this.lbl_descuadre);
            this.MaximizeBox = false;
            this.Name = "Form_Docxdia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMPRESION RELACION MOVIMIENTOS DE UN DIA";
            this.pnl_visual.ResumeLayout(false);
            this.pnl_visual.PerformLayout();
            this.pnl_impre.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_descuadre;
        private System.Windows.Forms.TextBox txt_rec1;
        private System.Windows.Forms.RadioButton rb_fecha;
        private System.Windows.Forms.RadioButton rb_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnl_visual;
        private System.Windows.Forms.Panel pnl_impre;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button salircuent;
        private System.Windows.Forms.ComboBox combo_papel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_papel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox check_totales;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.TextBox txt_valorini;
        private System.Windows.Forms.TextBox txt_valorfin;
        private System.Windows.Forms.Label lbl_valorfin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_2;
        private System.Windows.Forms.DateTimePicker dt_1;
        private System.Windows.Forms.Label lblinicial;
        private System.Windows.Forms.TextBox txt_clienini;
        private System.Windows.Forms.TextBox txt_clienfin;
        private System.Windows.Forms.Label lblfinal;
    }
}