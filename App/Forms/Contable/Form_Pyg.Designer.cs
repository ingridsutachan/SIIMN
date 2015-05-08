namespace App.Forms.Contable
{
    partial class Form_Pyg
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
            this.pan_uno = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio_sinajuste = new System.Windows.Forms.RadioButton();
            this.radio_inflacion = new System.Windows.Forms.RadioButton();
            this.cbx_nivel = new System.Windows.Forms.ComboBox();
            this.check_centro = new System.Windows.Forms.CheckBox();
            this.check_impcodig = new System.Windows.Forms.CheckBox();
            this.cbx_mesuno = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.check_porcentual = new System.Windows.Forms.CheckBox();
            this.check_terceros = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pan_tres = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_mespreha = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.cbx_mesprede = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pan_dos = new System.Windows.Forms.GroupBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.menu_botones = new System.Windows.Forms.ToolStrip();
            this.btn_imprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_cancelar = new System.Windows.Forms.ToolStripButton();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.pan_uno.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pan_tres.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pan_dos.SuspendLayout();
            this.menu_botones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_uno
            // 
            this.pan_uno.Controls.Add(this.groupBox2);
            this.pan_uno.Controls.Add(this.cbx_nivel);
            this.pan_uno.Controls.Add(this.check_centro);
            this.pan_uno.Controls.Add(this.check_impcodig);
            this.pan_uno.Controls.Add(this.cbx_mesuno);
            this.pan_uno.Controls.Add(this.label5);
            this.pan_uno.Controls.Add(this.check_porcentual);
            this.pan_uno.Controls.Add(this.check_terceros);
            this.pan_uno.Controls.Add(this.label2);
            this.pan_uno.Location = new System.Drawing.Point(12, 34);
            this.pan_uno.Name = "pan_uno";
            this.pan_uno.Size = new System.Drawing.Size(383, 199);
            this.pan_uno.TabIndex = 29;
            this.pan_uno.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_sinajuste);
            this.groupBox2.Controls.Add(this.radio_inflacion);
            this.groupBox2.Location = new System.Drawing.Point(6, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 29);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // radio_sinajuste
            // 
            this.radio_sinajuste.AutoSize = true;
            this.radio_sinajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_sinajuste.Location = new System.Drawing.Point(233, 10);
            this.radio_sinajuste.Name = "radio_sinajuste";
            this.radio_sinajuste.Size = new System.Drawing.Size(97, 17);
            this.radio_sinajuste.TabIndex = 7;
            this.radio_sinajuste.TabStop = true;
            this.radio_sinajuste.Text = "SIN AJUSTE";
            this.radio_sinajuste.UseVisualStyleBackColor = true;
            this.radio_sinajuste.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // radio_inflacion
            // 
            this.radio_inflacion.AutoSize = true;
            this.radio_inflacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_inflacion.Location = new System.Drawing.Point(6, 10);
            this.radio_inflacion.Name = "radio_inflacion";
            this.radio_inflacion.Size = new System.Drawing.Size(183, 17);
            this.radio_inflacion.TabIndex = 6;
            this.radio_inflacion.TabStop = true;
            this.radio_inflacion.Text = "CON AJUSTE X INFLACION";
            this.radio_inflacion.UseVisualStyleBackColor = true;
            this.radio_inflacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // cbx_nivel
            // 
            this.cbx_nivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_nivel.FormattingEnabled = true;
            this.cbx_nivel.Items.AddRange(new object[] {
            "MAYOR",
            "AUXILIAR"});
            this.cbx_nivel.Location = new System.Drawing.Point(120, 62);
            this.cbx_nivel.Name = "cbx_nivel";
            this.cbx_nivel.Size = new System.Drawing.Size(156, 21);
            this.cbx_nivel.TabIndex = 3;
            this.cbx_nivel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // check_centro
            // 
            this.check_centro.AutoSize = true;
            this.check_centro.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.check_centro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_centro.Location = new System.Drawing.Point(3, 171);
            this.check_centro.Name = "check_centro";
            this.check_centro.Size = new System.Drawing.Size(219, 17);
            this.check_centro.TabIndex = 9;
            this.check_centro.Text = "DESEA POR CENTRO DE COSTO";
            this.check_centro.UseVisualStyleBackColor = true;
            this.check_centro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // check_impcodig
            // 
            this.check_impcodig.AutoSize = true;
            this.check_impcodig.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.check_impcodig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_impcodig.Location = new System.Drawing.Point(3, 40);
            this.check_impcodig.Name = "check_impcodig";
            this.check_impcodig.Size = new System.Drawing.Size(262, 17);
            this.check_impcodig.TabIndex = 2;
            this.check_impcodig.Text = "IMPRIME EL CODIGO DE CADA CUENTA";
            this.check_impcodig.UseVisualStyleBackColor = true;
            this.check_impcodig.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // cbx_mesuno
            // 
            this.cbx_mesuno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_mesuno.FormattingEnabled = true;
            this.cbx_mesuno.Location = new System.Drawing.Point(120, 13);
            this.cbx_mesuno.Name = "cbx_mesuno";
            this.cbx_mesuno.Size = new System.Drawing.Size(156, 21);
            this.cbx_mesuno.TabIndex = 1;
            this.cbx_mesuno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 118;
            this.label5.Text = "MES A IMPRIMIR:";
            // 
            // check_porcentual
            // 
            this.check_porcentual.AutoSize = true;
            this.check_porcentual.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.check_porcentual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_porcentual.Location = new System.Drawing.Point(3, 148);
            this.check_porcentual.Name = "check_porcentual";
            this.check_porcentual.Size = new System.Drawing.Size(371, 17);
            this.check_porcentual.TabIndex = 8;
            this.check_porcentual.Text = "IMPRIME PARTICIPACION PORCENTUAL DE CADA RUBRO";
            this.check_porcentual.UseVisualStyleBackColor = true;
            this.check_porcentual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // check_terceros
            // 
            this.check_terceros.AutoSize = true;
            this.check_terceros.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.check_terceros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_terceros.Location = new System.Drawing.Point(3, 96);
            this.check_terceros.Name = "check_terceros";
            this.check_terceros.Size = new System.Drawing.Size(330, 17);
            this.check_terceros.TabIndex = 4;
            this.check_terceros.Text = "IMPRIME SALDO DE TERCEROS EN LAS CUENTAS ";
            this.check_terceros.UseVisualStyleBackColor = true;
            this.check_terceros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterTab_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 112;
            this.label2.Text = "NIVEL:";
            // 
            // pan_tres
            // 
            this.pan_tres.Controls.Add(this.textBox2);
            this.pan_tres.Controls.Add(this.label6);
            this.pan_tres.Controls.Add(this.cbx_mespreha);
            this.pan_tres.Controls.Add(this.label7);
            this.pan_tres.Controls.Add(this.textBox1);
            this.pan_tres.Controls.Add(this.label4);
            this.pan_tres.Controls.Add(this.checkBox5);
            this.pan_tres.Controls.Add(this.panel6);
            this.pan_tres.Controls.Add(this.checkBox6);
            this.pan_tres.Controls.Add(this.cbx_mesprede);
            this.pan_tres.Controls.Add(this.label1);
            this.pan_tres.Controls.Add(this.checkBox7);
            this.pan_tres.Controls.Add(this.checkBox8);
            this.pan_tres.Controls.Add(this.panel7);
            this.pan_tres.Controls.Add(this.label3);
            this.pan_tres.Location = new System.Drawing.Point(410, 49);
            this.pan_tres.Name = "pan_tres";
            this.pan_tres.Size = new System.Drawing.Size(537, 205);
            this.pan_tres.TabIndex = 31;
            this.pan_tres.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(474, 9);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(56, 20);
            this.textBox2.TabIndex = 128;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 127;
            this.label6.Text = "Año";
            // 
            // cbx_mespreha
            // 
            this.cbx_mespreha.FormattingEnabled = true;
            this.cbx_mespreha.Location = new System.Drawing.Point(328, 9);
            this.cbx_mespreha.Name = "cbx_mespreha";
            this.cbx_mespreha.Size = new System.Drawing.Size(105, 21);
            this.cbx_mespreha.TabIndex = 126;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(273, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 125;
            this.label7.Text = "Al Mes:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 20);
            this.textBox1.TabIndex = 124;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 123;
            this.label4.Text = "Año";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(3, 171);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(183, 17);
            this.checkBox5.TabIndex = 122;
            this.checkBox5.Text = "Desea por centro de costos";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.radioButton9);
            this.panel6.Controls.Add(this.radioButton10);
            this.panel6.Location = new System.Drawing.Point(6, 116);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(272, 26);
            this.panel6.TabIndex = 121;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton9.Location = new System.Drawing.Point(157, 3);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(82, 17);
            this.radioButton9.TabIndex = 92;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Sin Ajuste";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton10.Location = new System.Drawing.Point(3, 4);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(148, 17);
            this.radioButton10.TabIndex = 91;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Con ajuste x Inflación";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(6, 40);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(222, 17);
            this.checkBox6.TabIndex = 120;
            this.checkBox6.Text = "Imprime el código de cada cuenta ";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // cbx_mesprede
            // 
            this.cbx_mesprede.FormattingEnabled = true;
            this.cbx_mesprede.Location = new System.Drawing.Point(65, 9);
            this.cbx_mesprede.Name = "cbx_mesprede";
            this.cbx_mesprede.Size = new System.Drawing.Size(105, 21);
            this.cbx_mesprede.TabIndex = 119;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 118;
            this.label1.Text = "Del Mes:";
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.Location = new System.Drawing.Point(3, 148);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(296, 17);
            this.checkBox7.TabIndex = 115;
            this.checkBox7.Text = "Imprime participación conceptual de cada rubro";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.Location = new System.Drawing.Point(3, 96);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(264, 17);
            this.checkBox8.TabIndex = 114;
            this.checkBox8.Text = "Imprime saldos de terceros en las cuentas";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.radioButton11);
            this.panel7.Controls.Add(this.radioButton12);
            this.panel7.Location = new System.Drawing.Point(98, 64);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(169, 26);
            this.panel7.TabIndex = 113;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton11.Location = new System.Drawing.Point(90, 5);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(66, 17);
            this.radioButton11.TabIndex = 92;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "Auxiliar";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton12.Location = new System.Drawing.Point(2, 5);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(59, 17);
            this.radioButton12.TabIndex = 91;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "Mayor";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 112;
            this.label3.Text = "Nivel:";
            // 
            // pan_dos
            // 
            this.pan_dos.Controls.Add(this.radioButton8);
            this.pan_dos.Controls.Add(this.radioButton7);
            this.pan_dos.Controls.Add(this.radioButton5);
            this.pan_dos.Controls.Add(this.radioButton6);
            this.pan_dos.Location = new System.Drawing.Point(460, 243);
            this.pan_dos.Name = "pan_dos";
            this.pan_dos.Size = new System.Drawing.Size(268, 114);
            this.pan_dos.TabIndex = 32;
            this.pan_dos.TabStop = false;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton8.Location = new System.Drawing.Point(31, 63);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(204, 17);
            this.radioButton8.TabIndex = 102;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Variación Mensual Mes Anterior";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton7.Location = new System.Drawing.Point(31, 86);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(203, 17);
            this.radioButton7.TabIndex = 101;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Variación Mensual Año Anterior";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(31, 40);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(218, 17);
            this.radioButton5.TabIndex = 100;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Variación Acumulada Año Anterior";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.Location = new System.Drawing.Point(31, 17);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(219, 17);
            this.radioButton6.TabIndex = 99;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Variación Acumulada Mes Anterior";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // menu_botones
            // 
            this.menu_botones.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu_botones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_imprimir,
            this.toolStripSeparator2,
            this.btn_cancelar,
            this.btn_salir});
            this.menu_botones.Location = new System.Drawing.Point(0, 0);
            this.menu_botones.Name = "menu_botones";
            this.menu_botones.Size = new System.Drawing.Size(970, 31);
            this.menu_botones.TabIndex = 104;
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
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_cancelar.Image = global::App.Properties.Resources.cancel24;
            this.btn_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(28, 28);
            this.btn_cancelar.Text = "toolStripButton1";
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
            // 
            // Form_Pyg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 385);
            this.Controls.Add(this.menu_botones);
            this.Controls.Add(this.pan_dos);
            this.Controls.Add(this.pan_tres);
            this.Controls.Add(this.pan_uno);
            this.Name = "Form_Pyg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMPRESIÓN DEL ESTADO DE RESULTADOS (P Y G)";
            this.pan_uno.ResumeLayout(false);
            this.pan_uno.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pan_tres.ResumeLayout(false);
            this.pan_tres.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.pan_dos.ResumeLayout(false);
            this.pan_dos.PerformLayout();
            this.menu_botones.ResumeLayout(false);
            this.menu_botones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pan_uno;
        private System.Windows.Forms.RadioButton radio_sinajuste;
        private System.Windows.Forms.RadioButton radio_inflacion;
        private System.Windows.Forms.CheckBox check_impcodig;
        private System.Windows.Forms.ComboBox cbx_mesuno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox check_porcentual;
        private System.Windows.Forms.CheckBox check_terceros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox check_centro;
        private System.Windows.Forms.Panel pan_tres;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_mespreha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.ComboBox cbx_mesprede;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbx_nivel;
        private System.Windows.Forms.GroupBox pan_dos;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.ToolStrip menu_botones;
        private System.Windows.Forms.ToolStripButton btn_imprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_cancelar;
        private System.Windows.Forms.ToolStripButton btn_salir;
    }
}