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
    public partial class Frm_LibroDiario : Form
    {
        public int tipodi;

        private asientosn negocio_Asiento;

        public Frm_LibroDiario(int tipo)
        {
            this.negocio_Asiento = new asientosn();
            InitializeComponent();
            this.tipodi = tipo;
            this.ValidarTipo(tipodi);
            this.CargarMeses();
        }

        private void CargarMeses()
        {
            try
            {
                //combo_mesde.DataSource = this.negocio_Asiento.CargarMeses();
                combo_mesde.ValueMember = "Idmes";
                combo_mesde.DisplayMember = "NombreMes";
               // cbx_meshasta.DataSource = this.negocio_Asiento.CargarMeses();
                cbx_meshasta.ValueMember = "Idmes";
                cbx_meshasta.DisplayMember = "NombreMes";
               // cbx_resumido.DataSource = this.negocio_Asiento.CargarMeses();
                cbx_resumido.ValueMember = "Idmes";
                cbx_resumido.DisplayMember = "NombreMes";
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
                pnl_detallado.Visible = true;
                this.Text = "LIBRO DIARIO RESUMIDO";
            }
            if (tipo == 2)
            {
                pnl_resumido.Visible = true;
                pan_boton.Location = new Point(249, 120);
                this.Size= new Size (387, 216);
                this.Text = "LIBRO DIARIO DETALLADO";
            } 
            this.btn_generar.Visible = true;
        }
    }
}
