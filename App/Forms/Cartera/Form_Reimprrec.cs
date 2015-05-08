namespace App.Forms.Cartera
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    public partial class Form_Reimprrec : Form
    {
        public Form_Reimprrec()
        {
            InitializeComponent();
        }

        private void rb_numero_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_numero.Checked == true)
            {
                lblinicial.Text = "Recibo Inicial";
                lblfinal.Text = "Recibo Final";
                txt_rec1.Visible = true;
                txt_rec2.Visible = true;
                dt_1.Visible = false;
                dt_2.Visible = false;
                this.Inhabilitar();
            }
        }

        private void rb_fecha_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_fecha.Checked == true)
            {
                lblinicial.Text = "Fecha Inicial";
                lblfinal.Text = "Fecha Final";
                dt_1.Visible = true;
                dt_2.Visible = true;
            }
        }

        private void Inhabilitar()
        {
            rb_numero.Enabled = false;
            rb_fecha.Enabled = false;
            pnl_visual.Visible = true;
        }
    }
}
