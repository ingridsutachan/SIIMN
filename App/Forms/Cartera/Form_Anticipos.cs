using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App.Forms.Cartera
{
    public partial class Form_Anticipos : Form
    {
        private int menuct;

        public Form_Anticipos(int menu)
        {
            this.menuct = menu;
            InitializeComponent();
            this.Mostrar();
        }

        private void Mostrar()
        {
            if (menuct == 2)
            {
                lbl_inicio.Text = "Tercero";
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txt_clienteanti.Enabled = true;
            btn_enter.Enabled = true;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            txt_clienteanti.Enabled = true;
            btn_enter.Enabled = true;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            txt_clienteanti.Enabled = true;
            btn_enter.Enabled = true;
        }
    }
}
