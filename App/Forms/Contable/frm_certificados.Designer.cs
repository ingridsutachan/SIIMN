namespace App.Forms.Contable
{
    partial class frm_certificados
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
            this.label1 = new System.Windows.Forms.Label();
            this.grupo_tipo = new System.Windows.Forms.GroupBox();
            this.radio_detalle = new System.Windows.Forms.RadioButton();
            this.radio_general = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_generar = new System.Windows.Forms.Button();
            this.salircuent = new System.Windows.Forms.Button();
            this.grupo_tipo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo";
            // 
            // grupo_tipo
            // 
            this.grupo_tipo.Controls.Add(this.radio_detalle);
            this.grupo_tipo.Controls.Add(this.radio_general);
            this.grupo_tipo.Location = new System.Drawing.Point(69, 12);
            this.grupo_tipo.Name = "grupo_tipo";
            this.grupo_tipo.Size = new System.Drawing.Size(310, 33);
            this.grupo_tipo.TabIndex = 6;
            this.grupo_tipo.TabStop = false;
            // 
            // radio_detalle
            // 
            this.radio_detalle.AutoSize = true;
            this.radio_detalle.Enabled = false;
            this.radio_detalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_detalle.Location = new System.Drawing.Point(187, 11);
            this.radio_detalle.Name = "radio_detalle";
            this.radio_detalle.Size = new System.Drawing.Size(107, 17);
            this.radio_detalle.TabIndex = 7;
            this.radio_detalle.TabStop = true;
            this.radio_detalle.Text = "Retención ICA";
            this.radio_detalle.UseVisualStyleBackColor = true;
            // 
            // radio_general
            // 
            this.radio_general.AutoSize = true;
            this.radio_general.Enabled = false;
            this.radio_general.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_general.Location = new System.Drawing.Point(12, 11);
            this.radio_general.Name = "radio_general";
            this.radio_general.Size = new System.Drawing.Size(155, 17);
            this.radio_general.TabIndex = 6;
            this.radio_general.TabStop = true;
            this.radio_general.Text = "Retención en la fuente";
            this.radio_general.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(69, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 76);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(12, 50);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Imprimir";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(12, 11);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(133, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Diseñar Certificado";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Desea";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_generar);
            this.panel2.Controls.Add(this.salircuent);
            this.panel2.Location = new System.Drawing.Point(275, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(104, 46);
            this.panel2.TabIndex = 72;
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
            // frm_certificados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 140);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grupo_tipo);
            this.Controls.Add(this.label1);
            this.Name = "frm_certificados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORMATOS DE CERTIFICADOS";
            this.grupo_tipo.ResumeLayout(false);
            this.grupo_tipo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grupo_tipo;
        private System.Windows.Forms.RadioButton radio_detalle;
        private System.Windows.Forms.RadioButton radio_general;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Button salircuent;
    }
}