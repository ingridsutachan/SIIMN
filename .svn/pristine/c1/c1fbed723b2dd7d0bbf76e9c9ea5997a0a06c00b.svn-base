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
    public partial class Form_LoginCajero : Form
    {
        private int tipmenu;
        public Form_LoginCajero(int menu)
        {
            this.tipmenu = menu;
            InitializeComponent();
        }

        private void entrar_Click(object sender, EventArgs e)
        {
            if (tipmenu == 1)
            {
                Form_RegistrarRecCar frm = new Form_RegistrarRecCar();
                frm.Show();
                this.Close();
            }
            if (tipmenu == 2)
            {
                Form_RegistrarRecOtros frm = new Form_RegistrarRecOtros();
                frm.Show();
                this.Close();
            }
        }
    }
}
