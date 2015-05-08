namespace App.Forms.Cartera
{
    partial class Form_Concep_ing
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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_concepto = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.salircuent = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_concepto)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Location = new System.Drawing.Point(67, 251);
            this.txt_nombre.MaxLength = 45;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(214, 20);
            this.txt_nombre.TabIndex = 2;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_nombre_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_guardar);
            this.panel2.Controls.Add(this.salircuent);
            this.panel2.Location = new System.Drawing.Point(177, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(104, 46);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Nombre*";
            // 
            // dgv_concepto
            // 
            this.dgv_concepto.AllowUserToAddRows = false;
            this.dgv_concepto.AllowUserToDeleteRows = false;
            this.dgv_concepto.AllowUserToResizeRows = false;
            this.dgv_concepto.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_concepto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_concepto.Location = new System.Drawing.Point(12, 56);
            this.dgv_concepto.MultiSelect = false;
            this.dgv_concepto.Name = "dgv_concepto";
            this.dgv_concepto.ReadOnly = true;
            this.dgv_concepto.RowHeadersVisible = false;
            this.dgv_concepto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_concepto.Size = new System.Drawing.Size(269, 160);
            this.dgv_concepto.TabIndex = 47;
            this.dgv_concepto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_concepto_CellClick);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_nuevo);
            this.panel3.Controls.Add(this.btn_editar);
            this.panel3.Controls.Add(this.btn_buscar);
            this.panel3.Controls.Add(this.txt_buscar);
            this.panel3.Controls.Add(this.btn_eliminar);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 36);
            this.panel3.TabIndex = 46;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(117, 6);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(113, 20);
            this.txt_buscar.TabIndex = 12;
            this.txt_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_buscar_KeyPress);
            // 
            // txt_codigo
            // 
            this.txt_codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Location = new System.Drawing.Point(66, 225);
            this.txt_codigo.MaxLength = 11;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(62, 20);
            this.txt_codigo.TabIndex = 1;
            this.txt_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_codigo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Código";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Enabled = false;
            this.btn_guardar.Font = new System.Drawing.Font("Adobe Arabic", 0.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Image = global::App.Properties.Resources.Save;
            this.btn_guardar.Location = new System.Drawing.Point(3, 5);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(35, 33);
            this.btn_guardar.TabIndex = 4;
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // salircuent
            // 
            this.salircuent.Image = global::App.Properties.Resources.exit;
            this.salircuent.Location = new System.Drawing.Point(56, 5);
            this.salircuent.Name = "salircuent";
            this.salircuent.Size = new System.Drawing.Size(43, 32);
            this.salircuent.TabIndex = 5;
            this.salircuent.UseVisualStyleBackColor = true;
            this.salircuent.Click += new System.EventHandler(this.Salircuent_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_nuevo.Image = global::App.Properties.Resources.agregar1;
            this.btn_nuevo.Location = new System.Drawing.Point(3, 1);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(25, 28);
            this.btn_nuevo.TabIndex = 9;
            this.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Enabled = false;
            this.btn_editar.Image = global::App.Properties.Resources.editar;
            this.btn_editar.Location = new System.Drawing.Point(34, 2);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(24, 26);
            this.btn_editar.TabIndex = 10;
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = global::App.Properties.Resources.search;
            this.btn_buscar.Location = new System.Drawing.Point(236, 4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(28, 25);
            this.btn_buscar.TabIndex = 13;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Enabled = false;
            this.btn_eliminar.Image = global::App.Properties.Resources.eliminar;
            this.btn_eliminar.Location = new System.Drawing.Point(64, 2);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(28, 26);
            this.btn_eliminar.TabIndex = 11;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Form_Concep_ing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 345);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_concepto);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Concep_ing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Concepto de Ingresos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Concep_ing_FormClosing);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_concepto)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button salircuent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_concepto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label2;
    }
}