using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App.Forms.Factura
{
    public partial class Form_Formaspago : Form
    {
        private int menufg;

        public Form_Formaspago(int menu)
        {
            this.InitializeComponent();
            this.menufg = menu;
            this.Visual(menufg);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            /*Form_VisualFactura frm = new Form_VisualFactura("formas", "buscar",this);
            frm.MdiParent = this.MdiParent;
            frm.Show();*/
        }

        private void Visual( int menu)
        {
            if (menu == 1)
            {
                pnl_grupo.Visible = true;
                
            }
            else
            {
                pnl_forma.Visible = true;
                this.Size = new Size(725, 613);
            }
        }

    }
}
