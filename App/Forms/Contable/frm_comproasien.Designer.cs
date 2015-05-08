namespace App.Forms.Contable
{
    partial class frm_comproasien
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_generar = new System.Windows.Forms.Button();
            this.pan_boton = new System.Windows.Forms.Panel();
            this.salircuent = new System.Windows.Forms.Button();
            this.pan_boton.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 20);
            this.textBox1.TabIndex = 143;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 142;
            this.label1.Text = "Digite Número";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(157, 16);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(115, 20);
            this.textBox5.TabIndex = 141;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 13);
            this.label11.TabIndex = 140;
            this.label11.Text = "Digite Comprobante";
            // 
            // btn_generar
            // 
            this.btn_generar.Image = global::App.Properties.Resources.ok;
            this.btn_generar.Location = new System.Drawing.Point(5, 6);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(35, 33);
            this.btn_generar.TabIndex = 139;
            this.btn_generar.UseVisualStyleBackColor = true;
            // 
            // pan_boton
            // 
            this.pan_boton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_boton.Controls.Add(this.salircuent);
            this.pan_boton.Controls.Add(this.btn_generar);
            this.pan_boton.Location = new System.Drawing.Point(177, 86);
            this.pan_boton.Name = "pan_boton";
            this.pan_boton.Size = new System.Drawing.Size(95, 46);
            this.pan_boton.TabIndex = 180;
            // 
            // salircuent
            // 
            this.salircuent.Image = global::App.Properties.Resources.exit;
            this.salircuent.Location = new System.Drawing.Point(46, 6);
            this.salircuent.Name = "salircuent";
            this.salircuent.Size = new System.Drawing.Size(43, 32);
            this.salircuent.TabIndex = 40;
            this.salircuent.TabStop = false;
            this.salircuent.UseVisualStyleBackColor = true;
            // 
            // frm_comproasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 147);
            this.Controls.Add(this.pan_boton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label11);
            this.Name = "frm_comproasien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTA DE DOCUMENTOS";
            this.pan_boton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pan_boton;
        private System.Windows.Forms.Button salircuent;
    }
}