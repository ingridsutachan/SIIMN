namespace App.Forms.Cartera
{
    partial class Form_Reimprrec
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
            this.rb_numero = new System.Windows.Forms.RadioButton();
            this.rb_fecha = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblinicial = new System.Windows.Forms.Label();
            this.lblfinal = new System.Windows.Forms.Label();
            this.txt_rec2 = new System.Windows.Forms.TextBox();
            this.txt_rec1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_impre = new System.Windows.Forms.Panel();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.salircuent = new System.Windows.Forms.Button();
            this.pnl_visual = new System.Windows.Forms.Panel();
            this.dt_1 = new System.Windows.Forms.DateTimePicker();
            this.dt_2 = new System.Windows.Forms.DateTimePicker();
            this.pnl_impre.SuspendLayout();
            this.pnl_visual.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_numero
            // 
            this.rb_numero.AutoSize = true;
            this.rb_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_numero.Location = new System.Drawing.Point(111, 7);
            this.rb_numero.Name = "rb_numero";
            this.rb_numero.Size = new System.Drawing.Size(68, 17);
            this.rb_numero.TabIndex = 232;
            this.rb_numero.TabStop = true;
            this.rb_numero.Text = "Número";
            this.rb_numero.UseVisualStyleBackColor = true;
            this.rb_numero.CheckedChanged += new System.EventHandler(this.rb_numero_CheckedChanged);
            // 
            // rb_fecha
            // 
            this.rb_fecha.AutoSize = true;
            this.rb_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_fecha.Location = new System.Drawing.Point(200, 7);
            this.rb_fecha.Name = "rb_fecha";
            this.rb_fecha.Size = new System.Drawing.Size(60, 17);
            this.rb_fecha.TabIndex = 231;
            this.rb_fecha.TabStop = true;
            this.rb_fecha.Text = "Fecha";
            this.rb_fecha.UseVisualStyleBackColor = true;
            this.rb_fecha.CheckedChanged += new System.EventHandler(this.rb_fecha_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 230;
            this.label3.Text = "Ordenado Por:";
            // 
            // lblinicial
            // 
            this.lblinicial.AutoSize = true;
            this.lblinicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinicial.Location = new System.Drawing.Point(3, 15);
            this.lblinicial.Name = "lblinicial";
            this.lblinicial.Size = new System.Drawing.Size(145, 13);
            this.lblinicial.TabIndex = 236;
            this.lblinicial.Text = "Cliente Inicial[**]Todos: ";
            // 
            // lblfinal
            // 
            this.lblfinal.AutoSize = true;
            this.lblfinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfinal.Location = new System.Drawing.Point(3, 43);
            this.lblfinal.Name = "lblfinal";
            this.lblfinal.Size = new System.Drawing.Size(85, 13);
            this.lblfinal.TabIndex = 238;
            this.lblfinal.Text = "Cliente Final: ";
            // 
            // txt_rec2
            // 
            this.txt_rec2.Location = new System.Drawing.Point(152, 39);
            this.txt_rec2.MaxLength = 10;
            this.txt_rec2.Name = "txt_rec2";
            this.txt_rec2.Size = new System.Drawing.Size(74, 20);
            this.txt_rec2.TabIndex = 239;
            // 
            // txt_rec1
            // 
            this.txt_rec1.Location = new System.Drawing.Point(152, 11);
            this.txt_rec1.MaxLength = 10;
            this.txt_rec1.Name = "txt_rec1";
            this.txt_rec1.Size = new System.Drawing.Size(74, 20);
            this.txt_rec1.TabIndex = 237;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PREIMPRESO",
            "NORMAL",
            "COMBINADO"});
            this.comboBox1.Location = new System.Drawing.Point(152, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 240;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 241;
            this.label1.Text = "Imprime:";
            // 
            // pnl_impre
            // 
            this.pnl_impre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_impre.Controls.Add(this.btn_guardar);
            this.pnl_impre.Controls.Add(this.salircuent);
            this.pnl_impre.Location = new System.Drawing.Point(291, 141);
            this.pnl_impre.Name = "pnl_impre";
            this.pnl_impre.Size = new System.Drawing.Size(104, 46);
            this.pnl_impre.TabIndex = 247;
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
            // pnl_visual
            // 
            this.pnl_visual.Controls.Add(this.dt_2);
            this.pnl_visual.Controls.Add(this.dt_1);
            this.pnl_visual.Controls.Add(this.lblinicial);
            this.pnl_visual.Controls.Add(this.txt_rec1);
            this.pnl_visual.Controls.Add(this.label1);
            this.pnl_visual.Controls.Add(this.txt_rec2);
            this.pnl_visual.Controls.Add(this.comboBox1);
            this.pnl_visual.Controls.Add(this.lblfinal);
            this.pnl_visual.Location = new System.Drawing.Point(11, 25);
            this.pnl_visual.Name = "pnl_visual";
            this.pnl_visual.Size = new System.Drawing.Size(380, 105);
            this.pnl_visual.TabIndex = 248;
            this.pnl_visual.Visible = false;
            // 
            // dt_1
            // 
            this.dt_1.Location = new System.Drawing.Point(154, 11);
            this.dt_1.Name = "dt_1";
            this.dt_1.Size = new System.Drawing.Size(200, 20);
            this.dt_1.TabIndex = 242;
            this.dt_1.Visible = false;
            // 
            // dt_2
            // 
            this.dt_2.Location = new System.Drawing.Point(152, 37);
            this.dt_2.Name = "dt_2";
            this.dt_2.Size = new System.Drawing.Size(200, 20);
            this.dt_2.TabIndex = 243;
            this.dt_2.Visible = false;
            // 
            // Form_Reimprrec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 193);
            this.Controls.Add(this.pnl_visual);
            this.Controls.Add(this.pnl_impre);
            this.Controls.Add(this.rb_numero);
            this.Controls.Add(this.rb_fecha);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "Form_Reimprrec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REIMPRESION DE RECIBOS DE CAJA";
            this.pnl_impre.ResumeLayout(false);
            this.pnl_visual.ResumeLayout(false);
            this.pnl_visual.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_numero;
        private System.Windows.Forms.RadioButton rb_fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblinicial;
        private System.Windows.Forms.Label lblfinal;
        private System.Windows.Forms.TextBox txt_rec2;
        private System.Windows.Forms.TextBox txt_rec1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_impre;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button salircuent;
        private System.Windows.Forms.Panel pnl_visual;
        private System.Windows.Forms.DateTimePicker dt_2;
        private System.Windows.Forms.DateTimePicker dt_1;

    }
}