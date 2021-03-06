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
    public partial class Frm_BalanceGeneral : Form
    {
        private int tipobal;

        private asientosn negocio_Asiento;

        public Frm_BalanceGeneral(int tipo)
        {
            this.negocio_Asiento = new asientosn();
            InitializeComponent();
            this.tipobal = tipo;
            this.CargarMeses();
            this.ValidarTipo(tipobal);
        }

        private void CargarMeses()
        {
            try
            {
                //cbx_mesprede.DataSource = this.negocio_Asiento.CargarMeses();
                cbx_mesprede.ValueMember = "Idmes";
                cbx_mesprede.DisplayMember = "NombreMes";
                //cbx_mespreha.DataSource = this.negocio_Asiento.CargarMeses();
                cbx_mespreha.ValueMember = "Idmes";
                cbx_mespreha.DisplayMember = "NombreMes";
                //cbx_mesuno.DataSource = this.negocio_Asiento.CargarMeses();
                cbx_mesuno.ValueMember = "Idmes";
                cbx_mesuno.DisplayMember = "NombreMes";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un error. " + ex.Message);
            }
        }

        private void ValidarTipo(int tipo)
        {
            if (tipo == 1)
            {
                pan_uno.Visible = true;
                pan_boton.Location = new Point(222, 226);
                this.Size = new Size(355, 317);
            }
            if (tipo == 2)
            {
                pan_dos.Visible = true;
                pan_boton.Location = new Point(163, 140);
                this.Size = new Size(298, 234);
            }

            if (tipo == 3)
            {
                pan_tres.Visible = true;
            }

        }
    }
}
