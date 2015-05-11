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
    public partial class Form_Listcheqnoconsigydev : Form
    {
        private int menudc;

        public Form_Listcheqnoconsigydev(int menu)
        {
            this.menudc = menu;
            InitializeComponent();
            this.Mostrar();
          
        }

        private void Mostrar()
        {
            if (menudc == 1)
            {
                this.Text = "LISTADO DE CHEQUES RECOGIDOS";

            }
            if (menudc == 1)
            {
                this.Text = "LISTADO DE CHEQUES DEVUELTOS";
                lbl_lista.Visible = false;
                rb_fechaacon.Visible = false;
                rb_fechareci.Visible = false;
                rb_fecha.Text = "Fecha devolución";
            }
        }
    }
}
