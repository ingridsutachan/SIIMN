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
    public partial class Form_MovCliente : Form
    {
        public Form_MovCliente()
        {
            InitializeComponent();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (rb_nombre.Checked == true)
            {
                pnl_visual.Visible = true;
                lblinicial.Text = "Cliente Inicial[**]Todos";
                lblfinal.Text = "Cliente Final";
            }
            else if (rb_ciudad.Checked == true)
            {
                pnl_visual.Visible = true;
                lblinicial.Text = "Ciudad Inicial[**]Todos";
                lblfinal.Text = "Ciudad Final";
            }
            else if (rb_vendedor.Checked == true)
            {
                pnl_visual.Visible = true;
                lblinicial.Text = "Vendedor Inicial";
                lblfinal.Text = "Vendedor Final";
            }
        }
    }
}
