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
    public partial class Form_Docxdia : Form
    {

        private int menuds;

        public Form_Docxdia(int menu)
        {
            this.menuds = menu;

            InitializeComponent();

            this.Visual();
        }

        private void Visual()
        {
            if (this.menuds == 1)
            {
                lbl_valor.Visible = true;
                lbl_valorfin.Visible = true;
                lbl_papel.Visible = true;
                txt_valorini.Visible = true;
                txt_valorfin.Visible = true;
                combo_papel.Visible = true;
                check_totales.Visible = true;
            }
            if (this.menuds == 2)
            {
                lbl_valor.Visible = false;
                lbl_valorfin.Visible = false;
                lbl_papel.Visible = false;
                txt_valorini.Visible = false;
                txt_valorfin.Visible = false;
                combo_papel.Visible = false;
                check_totales.Visible = false;
            }
        }

        private void rb_fecha_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_fecha.Checked == true)
            {
                lblinicial.Visible = false;
                lblfinal.Visible = false;
                txt_clienfin.Visible = false;
                txt_clienini.Visible = false;
                pnl_visual.Visible = true;
                pnl_impre.Visible = true;
            }
        }

        private void rb_cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_cliente.Checked == true)
            {
                lblinicial.Visible = true;
                lblfinal.Visible = true;
                txt_clienfin.Visible = true;
                txt_clienini.Visible = true;
                pnl_visual.Visible = true;
                pnl_impre.Visible = true;
            }
        }

          }
}
