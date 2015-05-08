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
    public partial class Form_EstadoXcliente : Form
    {
        public Form_EstadoXcliente()
        {
            InitializeComponent();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            this.Habilitar();
            if (rb_normal.Checked == true)
            {
                pnl_visual.Size = new Size(621, 158);
                pnl_impre.Location = new Point(491, 191);
                this.Size = new Size(635, 328);
            }
            if (rb_enviar.Checked == true)
            {
                             pnl_visual.Size = new Size(621, 413);
                pnl_impre.Location = new Point(508, 480);
                this.Size = new Size(635, 575);
            }
            if (rb_resumido.Checked == true)
            {
                pnl_visual.Size = new Size(621, 158);
                pnl_impre.Location = new Point(491, 191);
                this.Size = new Size(635, 328);
                check_incons.Visible = false;
            }
            if (rb_circular.Checked == true)
            {
                pnl_visual.Size = new Size(621, 413);
                pnl_impre.Location = new Point(508, 480);
                this.Size = new Size(635, 575);
            }
        }

        private void Habilitar()
        {
            rb_nombre.Enabled = true;
            rb_ciudad.Enabled = true;
            rb_vendedor.Enabled = true;
            rb_normal.Enabled = false;
            rb_enviar.Enabled = false;
            rb_resumido.Enabled = false;
            rb_circular.Enabled = false;
        }

        private void Inhabilitar()
        {
            pnl_impre.Visible = true;
            rb_nombre.Enabled = false;
            rb_ciudad.Enabled = false;
            rb_vendedor.Enabled = false;
        }

        private void rb_nombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_nombre.Checked == true)
            {
                pnl_visual.Visible = true;
                lblinicial.Text = "Cliente Inicial[**]Todos";
                lblfinal.Text = "Cliente Final";
                this.Inhabilitar();
            }
        }

        private void rb_ciudad_CheckedChanged(object sender, EventArgs e)
        {
             if (rb_ciudad.Checked == true)
            {
                pnl_visual.Visible = true;
                lblinicial.Text = "Ciudad Inicial[**]Todos";
                lblfinal.Text = "Ciudad Final";
                this.Inhabilitar();
            }
        }

        private void rb_vendedor_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_vendedor.Checked == true)
            {
                pnl_visual.Visible = true;
                lblinicial.Text = "Vendedor Inicial";
                lblfinal.Text = "Vendedor Final";
                this.Inhabilitar();
            }
        }
    }
}
