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
    public partial class Form_Listcheqrecog : Form
    {
        private int menuct;

        public Form_Listcheqrecog(int menu)
        {
            this.menuct = menu;
            InitializeComponent();
            this.Mostrar();
        }

        private void Mostrar()
        {
            if (this.menuct == 2)
            {
                lbl1.Text = "Tercero Inicial";
                lbl2.Text = "Tercero Final";
            }
        }
    }
}
