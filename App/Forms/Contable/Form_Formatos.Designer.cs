﻿namespace App.Forms.Contable
{
    partial class Form_Formatos
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
            this.cbx_tipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_encabezado = new System.Windows.Forms.TextBox();
            this.txt_clase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cuentaini = new System.Windows.Forms.TextBox();
            this.txt_cuentafin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menu_botones = new System.Windows.Forms.ToolStrip();
            this.btn_nuevo = new System.Windows.Forms.ToolStripButton();
            this.btn_editar = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_EditarBalance = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Editarpyg = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_eliminar = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_EliminarBalance = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Eliminarpyg = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_buscar = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_buscarbalance = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_buscarpyg = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_imprimir = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_imprimirbalance = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_imprimirpyg = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.btn_cancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.txt_nombrecuentaini = new System.Windows.Forms.TextBox();
            this.txt_linea = new System.Windows.Forms.TextBox();
            this.txt_nombrecuentafin = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menu_botones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_tipo
            // 
            this.cbx_tipo.DisplayMember = "1";
            this.cbx_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tipo.Enabled = false;
            this.cbx_tipo.FormattingEnabled = true;
            this.cbx_tipo.Items.AddRange(new object[] {
            "BALANCE GENERAL",
            "PYG"});
            this.cbx_tipo.Location = new System.Drawing.Point(139, 50);
            this.cbx_tipo.Name = "cbx_tipo";
            this.cbx_tipo.Size = new System.Drawing.Size(252, 21);
            this.cbx_tipo.TabIndex = 1;
            this.cbx_tipo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cbx_tipo_KeyDown);
            this.cbx_tipo.Leave += new System.EventHandler(this.Cbx_tipo_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "TIPO DE FORMATO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "LINEA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "ENCABEZADO";
            // 
            // txt_encabezado
            // 
            this.txt_encabezado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_encabezado.Enabled = false;
            this.txt_encabezado.Location = new System.Drawing.Point(139, 77);
            this.txt_encabezado.MaxLength = 45;
            this.txt_encabezado.Name = "txt_encabezado";
            this.txt_encabezado.Size = new System.Drawing.Size(381, 20);
            this.txt_encabezado.TabIndex = 2;
            this.txt_encabezado.Enter += new System.EventHandler(this.txt_encabezado_Enter);
            this.txt_encabezado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // txt_clase
            // 
            this.txt_clase.Enabled = false;
            this.txt_clase.Location = new System.Drawing.Point(139, 103);
            this.txt_clase.MaxLength = 1;
            this.txt_clase.Name = "txt_clase";
            this.txt_clase.Size = new System.Drawing.Size(69, 20);
            this.txt_clase.TabIndex = 3;
            this.txt_clase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TabVal_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "CUENTA INICIAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "CUENTA FINAL";
            // 
            // txt_cuentaini
            // 
            this.txt_cuentaini.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_cuentaini.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_cuentaini.Enabled = false;
            this.txt_cuentaini.Location = new System.Drawing.Point(139, 54);
            this.txt_cuentaini.MaxLength = 10;
            this.txt_cuentaini.Name = "txt_cuentaini";
            this.txt_cuentaini.Size = new System.Drawing.Size(121, 20);
            this.txt_cuentaini.TabIndex = 6;
            this.txt_cuentaini.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Cuenta_KeyDown);
            this.txt_cuentaini.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterValidacion_KeyPress);
            this.txt_cuentaini.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtcuenta_KeyUp);
            this.txt_cuentaini.Leave += new System.EventHandler(this.Txtcuenta_Leave);
            // 
            // txt_cuentafin
            // 
            this.txt_cuentafin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_cuentafin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_cuentafin.Enabled = false;
            this.txt_cuentafin.Location = new System.Drawing.Point(139, 79);
            this.txt_cuentafin.MaxLength = 10;
            this.txt_cuentafin.Name = "txt_cuentafin";
            this.txt_cuentafin.Size = new System.Drawing.Size(121, 20);
            this.txt_cuentafin.TabIndex = 8;
            this.txt_cuentafin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Cuenta_KeyDown);
            this.txt_cuentafin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterValidacion_KeyPress);
            this.txt_cuentafin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtcuenta_KeyUp);
            this.txt_cuentafin.Leave += new System.EventHandler(this.Txtcuenta_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "NOMBRE";
            // 
            // txt_nombre
            // 
            this.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Location = new System.Drawing.Point(139, 22);
            this.txt_nombre.MaxLength = 45;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(243, 20);
            this.txt_nombre.TabIndex = 5;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "CLASE";
            // 
            // menu_botones
            // 
            this.menu_botones.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu_botones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_nuevo,
            this.btn_editar,
            this.btn_eliminar,
            this.btn_buscar,
            this.btn_imprimir,
            this.toolStripSeparator1,
            this.btn_guardar,
            this.btn_cancelar,
            this.toolStripSeparator2,
            this.btn_salir});
            this.menu_botones.Location = new System.Drawing.Point(0, 0);
            this.menu_botones.Name = "menu_botones";
            this.menu_botones.Size = new System.Drawing.Size(614, 31);
            this.menu_botones.TabIndex = 67;
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
            // btn_editar
            // 
            this.btn_editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_editar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_EditarBalance,
            this.btn_Editarpyg});
            this.btn_editar.Image = global::App.Properties.Resources.edit24;
            this.btn_editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(37, 28);
            this.btn_editar.Text = "toolStripDropDownButton1";
            // 
            // btn_EditarBalance
            // 
            this.btn_EditarBalance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditarBalance.Name = "btn_EditarBalance";
            this.btn_EditarBalance.Size = new System.Drawing.Size(194, 22);
            this.btn_EditarBalance.Text = "1. BALANCE GENERAL";
            this.btn_EditarBalance.Click += new System.EventHandler(this.Btn_EditarBalance_Click);
            // 
            // btn_Editarpyg
            // 
            this.btn_Editarpyg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editarpyg.Name = "btn_Editarpyg";
            this.btn_Editarpyg.Size = new System.Drawing.Size(194, 22);
            this.btn_Editarpyg.Text = "2. P Y G";
            this.btn_Editarpyg.Click += new System.EventHandler(this.Btn_Editarpyg_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_eliminar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_EliminarBalance,
            this.btn_Eliminarpyg});
            this.btn_eliminar.Image = global::App.Properties.Resources.delete24;
            this.btn_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(37, 28);
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.ToolTipText = "Eliminar(Ctrl+D)";
            // 
            // btn_EliminarBalance
            // 
            this.btn_EliminarBalance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarBalance.Name = "btn_EliminarBalance";
            this.btn_EliminarBalance.Size = new System.Drawing.Size(194, 22);
            this.btn_EliminarBalance.Text = "1. BALANCE GENERAL";
            this.btn_EliminarBalance.Click += new System.EventHandler(this.Btn_EliminarBalance_Click);
            // 
            // btn_Eliminarpyg
            // 
            this.btn_Eliminarpyg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminarpyg.Name = "btn_Eliminarpyg";
            this.btn_Eliminarpyg.Size = new System.Drawing.Size(194, 22);
            this.btn_Eliminarpyg.Text = "2. P Y G";
            this.btn_Eliminarpyg.Click += new System.EventHandler(this.Btn_Eliminarpyg_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_buscar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_buscarbalance,
            this.btn_buscarpyg});
            this.btn_buscar.Image = global::App.Properties.Resources.search24;
            this.btn_buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(37, 28);
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.ToolTipText = "Buscar(Ctrl+B)";
            // 
            // btn_buscarbalance
            // 
            this.btn_buscarbalance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarbalance.Name = "btn_buscarbalance";
            this.btn_buscarbalance.Size = new System.Drawing.Size(194, 22);
            this.btn_buscarbalance.Text = "1. BALANCE GENERAL";
            this.btn_buscarbalance.Click += new System.EventHandler(this.Btn_buscarbalance_Click);
            // 
            // btn_buscarpyg
            // 
            this.btn_buscarpyg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarpyg.Name = "btn_buscarpyg";
            this.btn_buscarpyg.Size = new System.Drawing.Size(194, 22);
            this.btn_buscarpyg.Text = "2. P Y G";
            this.btn_buscarpyg.Click += new System.EventHandler(this.Btn_buscarpyg_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_imprimir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_imprimirbalance,
            this.btn_imprimirpyg});
            this.btn_imprimir.Image = global::App.Properties.Resources.printer24;
            this.btn_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(37, 28);
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.ToolTipText = "Imprimir (Ctrl+P)";
            // 
            // btn_imprimirbalance
            // 
            this.btn_imprimirbalance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimirbalance.Name = "btn_imprimirbalance";
            this.btn_imprimirbalance.Size = new System.Drawing.Size(194, 22);
            this.btn_imprimirbalance.Text = "1. BALANCE GENERAL";
            this.btn_imprimirbalance.Click += new System.EventHandler(this.Btn_imprimirbalance_Click);
            // 
            // btn_imprimirpyg
            // 
            this.btn_imprimirpyg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimirpyg.Name = "btn_imprimirpyg";
            this.btn_imprimirpyg.Size = new System.Drawing.Size(194, 22);
            this.btn_imprimirpyg.Text = "2. P Y G";
            this.btn_imprimirpyg.Click += new System.EventHandler(this.Btn_imprimirpyg_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btn_guardar
            // 
            this.btn_guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_guardar.Enabled = false;
            this.btn_guardar.Image = global::App.Properties.Resources.save24;
            this.btn_guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(28, 28);
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.ToolTipText = "Guardar(Ctrl+G)";
            this.btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Image = global::App.Properties.Resources.cancel24;
            this.btn_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(28, 28);
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.ToolTipText = "Cancelar(Ctrl+Z)";
            this.btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
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
            // txt_nombrecuentaini
            // 
            this.txt_nombrecuentaini.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombrecuentaini.Enabled = false;
            this.txt_nombrecuentaini.Location = new System.Drawing.Point(266, 53);
            this.txt_nombrecuentaini.Name = "txt_nombrecuentaini";
            this.txt_nombrecuentaini.ReadOnly = true;
            this.txt_nombrecuentaini.Size = new System.Drawing.Size(325, 20);
            this.txt_nombrecuentaini.TabIndex = 7;
            // 
            // txt_linea
            // 
            this.txt_linea.Enabled = false;
            this.txt_linea.Location = new System.Drawing.Point(139, 129);
            this.txt_linea.MaxLength = 1;
            this.txt_linea.Name = "txt_linea";
            this.txt_linea.Size = new System.Drawing.Size(69, 20);
            this.txt_linea.TabIndex = 4;
            this.txt_linea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TabVal_KeyPress);
            // 
            // txt_nombrecuentafin
            // 
            this.txt_nombrecuentafin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombrecuentafin.Enabled = false;
            this.txt_nombrecuentafin.Location = new System.Drawing.Point(266, 79);
            this.txt_nombrecuentafin.Name = "txt_nombrecuentafin";
            this.txt_nombrecuentafin.ReadOnly = true;
            this.txt_nombrecuentafin.Size = new System.Drawing.Size(325, 20);
            this.txt_nombrecuentafin.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_nombrecuentafin);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.txt_cuentaini);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_nombrecuentaini);
            this.groupBox1.Controls.Add(this.txt_cuentafin);
            this.groupBox1.Location = new System.Drawing.Point(9, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 112);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // Form_Formatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 276);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_linea);
            this.Controls.Add(this.menu_botones);
            this.Controls.Add(this.txt_clase);
            this.Controls.Add(this.txt_encabezado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_tipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Formatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORMATOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_formatos_FormClosing);
            this.menu_botones.ResumeLayout(false);
            this.menu_botones.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_tipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_encabezado;
        private System.Windows.Forms.TextBox txt_clase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cuentaini;
        private System.Windows.Forms.TextBox txt_cuentafin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip menu_botones;
        private System.Windows.Forms.ToolStripButton btn_nuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_guardar;
        private System.Windows.Forms.ToolStripButton btn_cancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private System.Windows.Forms.TextBox txt_nombrecuentaini;
        private System.Windows.Forms.TextBox txt_linea;
        private System.Windows.Forms.TextBox txt_nombrecuentafin;
        private System.Windows.Forms.ToolStripDropDownButton btn_editar;
        private System.Windows.Forms.ToolStripMenuItem btn_EditarBalance;
        private System.Windows.Forms.ToolStripMenuItem btn_Editarpyg;
        private System.Windows.Forms.ToolStripDropDownButton btn_eliminar;
        private System.Windows.Forms.ToolStripMenuItem btn_EliminarBalance;
        private System.Windows.Forms.ToolStripMenuItem btn_Eliminarpyg;
        private System.Windows.Forms.ToolStripDropDownButton btn_buscar;
        private System.Windows.Forms.ToolStripMenuItem btn_buscarbalance;
        private System.Windows.Forms.ToolStripMenuItem btn_buscarpyg;
        private System.Windows.Forms.ToolStripDropDownButton btn_imprimir;
        private System.Windows.Forms.ToolStripMenuItem btn_imprimirbalance;
        private System.Windows.Forms.ToolStripMenuItem btn_imprimirpyg;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}