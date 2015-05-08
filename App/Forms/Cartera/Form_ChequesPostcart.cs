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
    public partial class Form_ChequesPostcart : Form
    {
        public Form_ChequesPostcart()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txt_clientecheque.Enabled = true;
            btn_enter.Enabled = true;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            txt_clientecheque.Enabled = true;
            btn_enter.Enabled = true;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            txt_clientecheque.Enabled = true;
            btn_enter.Enabled = true;
        }
    }
}
