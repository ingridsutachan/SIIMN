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
    public partial class Frm_Balance : Form
    {
        private int tipoba;

        private asientosn negocio_Asiento;

        public Frm_Balance(int tipo)
        {
            this.negocio_Asiento = new asientosn();
            InitializeComponent();
            this.tipoba = tipo;
            this.ValidarTipo(tipoba);
            this.CargarMeses();
        }

        private void CargarMeses()
        {
             try
            {
                //cbx_mesmes.DataSource = this.negocio_Asiento.CargarMeses();
                cbx_mesmes.ValueMember = "Idmes";
                cbx_mesmes.DisplayMember = "NombreMes";
               // cbx_mesinv.DataSource = this.negocio_Asiento.CargarMeses();
                cbx_mesinv.ValueMember = "Idmes";
                cbx_mesinv.DisplayMember = "NombreMes";
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
                panel_balanmes.Visible = true;
                this.Text = "IMPRESIÓN BALANCE DE PRUEBA DE UN MES";
            }
            if (tipo == 2)
            {
                panel_anual.Visible = true;
                pan_boton.Location = new Point(323, 44);
                this.Size = new Size(451, 147);
                this.Text = "IMPRESIÓN BALANCE DE PRUEBA ANUAL";
            }

            if (tipo == 3)
            {
                panel_invbalance.Visible = true;
                this.Text = "IMPRESIÓN INVENTARIOS Y BALANCES";
            }

        }
    }
}
