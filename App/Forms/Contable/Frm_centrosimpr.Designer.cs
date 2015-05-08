namespace App.Forms.Contable
{
    partial class Frm_centrosimpr
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pan_boton = new System.Windows.Forms.Panel();
            this.salircuent = new System.Windows.Forms.Button();
            this.btn_generar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pan_boton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 100);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(70, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 121;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 120;
            this.label7.Text = "Mes:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 43);
            this.textBox1.MaxLength = 2;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 20);
            this.textBox1.TabIndex = 126;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 125;
            this.label6.Text = "Centro Inicial";
            // 
            // pan_boton
            // 
            this.pan_boton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_boton.Controls.Add(this.salircuent);
            this.pan_boton.Controls.Add(this.btn_generar);
            this.pan_boton.Location = new System.Drawing.Point(152, 127);
            this.pan_boton.Name = "pan_boton";
            this.pan_boton.Size = new System.Drawing.Size(104, 46);
            this.pan_boton.TabIndex = 103;
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
            // Frm_centrosimpr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 189);
            this.Controls.Add(this.pan_boton);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_centrosimpr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMPRESIÓN SALDOS POR CENTROS DE COSTOS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pan_boton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pan_boton;
        private System.Windows.Forms.Button salircuent;
        private System.Windows.Forms.Button btn_generar;
    }
}