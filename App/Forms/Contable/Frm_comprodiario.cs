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
    public partial class Frm_comprodiario : Form
    {
        private asientosn negocio_Asiento;

        private int tipocompr;

        public Frm_comprodiario(int tipo)
        {
            this.negocio_Asiento = new asientosn();
            InitializeComponent();
            this.tipocompr = tipo;
            this.ValidarTipo(tipocompr);
            this.CargarMeses();
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
                pan_boton.Location = new Point(250, 135);
                this.Size = new Size(391, 229);
            }
        }
        private void CargarMeses()
        {
            try
            {
                //cbx_mesprede.DataSource = this.negocio_Asiento.CargarMeses();
                cbx_mesprede.ValueMember = "Idmes";
                cbx_mesprede.DisplayMember = "NombreMes";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un error. " + ex.Message);
            }
        }
    }
}
