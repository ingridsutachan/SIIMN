﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.Contable;

namespace App.Forms.Contable
{
    public partial class Frm_LibroMayor : Form
    {

        private asientosn negocio_Asiento;

        public Frm_LibroMayor()
        {
            this.negocio_Asiento = new asientosn();
            InitializeComponent();
            this.CargarMeses();
        }

        private void CargarMeses()
        {
            try
            {
               // cbx_mes.DataSource = this.negocio_Asiento.CargarMeses();
                cbx_mes.ValueMember = "Idmes";
                cbx_mes.DisplayMember = "NombreMes";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un error. " + ex.Message);
            }
        }
    }
}
