using System;
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
    public partial class Frm_varpresup : Form
    {
        private int tipovar;

        private asientosn negocio_Asiento;

        public Frm_varpresup(int tipo)
        {
            this.negocio_Asiento = new asientosn();
            InitializeComponent();
            this.tipovar = tipo;
            this.CargarMeses();
            this.ValidarTipo(tipovar);
        }

        private void CargarMeses()
        {
            try
            {
                //cbx_mesprede.DataSource = this.negocio_Asiento.CargarMeses();
                cbx_mesprede.ValueMember = "Idmes";
                cbx_mesprede.DisplayMember = "NombreMes";
               // cbx_mespreha.DataSource = this.negocio_Asiento.CargarMeses();
                cbx_mespreha.ValueMember = "Idmes";
                cbx_mespreha.DisplayMember = "NombreMes";
                //cbx_de2.DataSource = this.negocio_Asiento.CargarMeses();
                cbx_de2.ValueMember = "Idmes";
                cbx_de2.DisplayMember = "NombreMes";
               // cbx_ha2.DataSource = this.negocio_Asiento.CargarMeses();
                cbx_ha2.ValueMember = "Idmes";
                cbx_ha2.DisplayMember = "NombreMes";
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
            }
            if (tipo == 2)
            {
                pan_dos.Visible = true;
            }
        }
    }
}