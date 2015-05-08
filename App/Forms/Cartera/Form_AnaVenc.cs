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
    public partial class Form_AnaVenc : Form
    {
        public Form_AnaVenc()
        {
            InitializeComponent();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (rb_analdeta.Checked == true)
            {
                pnl_detallado.Visible = true;
            }
            if (rb_analedad.Checked == true)
            {
                pnl_edades.Visible = true;
            }
        }
    }
}
