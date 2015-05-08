namespace App.Forms.Cartera
{
    partial class Form_Crucesaldos
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
            this.rb_fecha = new System.Windows.Forms.RadioButton();
            this.rb_cliente = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_2 = new System.Windows.Forms.DateTimePicker();
            this.dt_1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_descuadre = new System.Windows.Forms.Label();
            this.txt_rec1 = new System.Windows.Forms.TextBox();
            this.check_totales = new System.Windows.Forms.CheckBox();
            this.pnl_impre = new System.Windows.Forms.Panel();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.salircuent = new System.Windows.Forms.Button();
            this.pnl_impre.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_fecha
            // 
            this.rb_fecha.AutoSize = true;
            this.rb_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_fecha.Location = new System.Drawing.Point(146, 18);
            this.rb_fecha.Name = "rb_fecha";
            this.rb_fecha.Size = new System.Drawing.Size(46, 17);
            this.rb_fecha.TabIndex = 254;
            this.rb_fecha.TabStop = true;
            this.rb_fecha.Text = "NIT";
            this.rb_fecha.UseVisualStyleBackColor = true;
            // 
            // rb_cliente
            // 
            this.rb_cliente.AutoSize = true;
            this.rb_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_cliente.Location = new System.Drawing.Point(244, 18);
            this.rb_cliente.Name = "rb_cliente";
            this.rb_cliente.Size = new System.Drawing.Size(68, 17);
            this.rb_cliente.TabIndex = 253;
            this.rb_cliente.TabStop = true;
            this.rb_cliente.Text = "Nombre";
            this.rb_cliente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 252;
            this.label1.Text = "Ordenado Por:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 283;
            this.label3.Text = "Al:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 282;
            this.label2.Text = "Del:";
            // 
            // dt_2
            // 
            this.dt_2.Location = new System.Drawing.Point(117, 72);
            this.dt_2.Name = "dt_2";
            this.dt_2.Size = new System.Drawing.Size(200, 20);
            this.dt_2.TabIndex = 281;
            // 
            // dt_1
            // 
            this.dt_1.Location = new System.Drawing.Point(117, 46);
            this.dt_1.Name = "dt_1";
            this.dt_1.Size = new System.Drawing.Size(200, 20);
            this.dt_1.TabIndex = 280;
            // 
            // lbl_descuadre
            // 
            this.lbl_descuadre.AutoSize = true;
            this.lbl_descuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descuadre.Location = new System.Drawing.Point(12, 109);
            this.lbl_descuadre.Name = "lbl_descuadre";
            this.lbl_descuadre.Size = new System.Drawing.Size(162, 13);
            this.lbl_descuadre.TabIndex = 284;
            this.lbl_descuadre.Text = "Cuenta contable a Validar :";
            // 
            // txt_rec1
            // 
            this.txt_rec1.Location = new System.Drawing.Point(197, 106);
            this.txt_rec1.MaxLength = 10;
            this.txt_rec1.Name = "txt_rec1";
            this.txt_rec1.Size = new System.Drawing.Size(120, 20);
            this.txt_rec1.TabIndex = 285;
            // 
            // check_totales
            // 
            this.check_totales.AutoSize = true;
            this.check_totales.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.check_totales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_totales.Location = new System.Drawing.Point(12, 138);
            this.check_totales.Name = "check_totales";
            this.check_totales.Size = new System.Drawing.Size(187, 17);
            this.check_totales.TabIndex = 286;
            this.check_totales.Text = "Imprime solo inconsistencias";
            this.check_totales.UseVisualStyleBackColor = true;
            // 
            // pnl_impre
            // 
            this.pnl_impre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_impre.Controls.Add(this.btn_guardar);
            this.pnl_impre.Controls.Add(this.salircuent);
            this.pnl_impre.Location = new System.Drawing.Point(213, 155);
            this.pnl_impre.Name = "pnl_impre";
            this.pnl_impre.Size = new System.Drawing.Size(104, 46);
            this.pnl_impre.TabIndex = 292;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = global::App.Properties.Resources.ok;
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
            // Form_Crucesaldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 212);
            this.Controls.Add(this.pnl_impre);
            this.Controls.Add(this.check_totales);
            this.Controls.Add(this.lbl_descuadre);
            this.Controls.Add(this.txt_rec1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dt_2);
            this.Controls.Add(this.dt_1);
            this.Controls.Add(this.rb_fecha);
            this.Controls.Add(this.rb_cliente);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form_Crucesaldos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUCE DE SALDOS CON CONTABILIDAD";
            this.pnl_impre.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_fecha;
        private System.Windows.Forms.RadioButton rb_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_2;
        private System.Windows.Forms.DateTimePicker dt_1;
        private System.Windows.Forms.Label lbl_descuadre;
        private System.Windows.Forms.TextBox txt_rec1;
        private System.Windows.Forms.CheckBox check_totales;
        private System.Windows.Forms.Panel pnl_impre;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button salircuent;
    }
}