﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entities.Types;
using Negocios.Contable;


namespace App.Forms.Contable
{
    public partial class Frm_visualAsiFijo : Form
    {
        private asientosn negocioAsiento;

        private Form_Asientos formularioAsiento;

        public Frm_visualAsiFijo(Form_Asientos frmAsientos)
        {
            InitializeComponent();
            this.negocioAsiento = new asientosn();
            this.formularioAsiento = frmAsientos;
           // this.CargarDatosCuenta();
        }

        private void NombresColumna()
        {
            dgv_asifijo.Columns[0].Visible = false;
            dgv_asifijo.Columns[1].Visible = false;
            dgv_asifijo.Columns[2].HeaderText = "DOCUMENTO";
            dgv_asifijo.Columns[2].DisplayIndex = 3;
            dgv_asifijo.Columns[3].HeaderText = "CENTRO";
            dgv_asifijo.Columns[3].DisplayIndex = 6;
            dgv_asifijo.Columns[4].Visible = false;
            dgv_asifijo.Columns[5].Visible = false;
            dgv_asifijo.Columns[6].HeaderText = "COMPROBANTE";
            dgv_asifijo.Columns[6].DisplayIndex = 2;
            dgv_asifijo.Columns[7].HeaderText = "CUENTA";
            dgv_asifijo.Columns[7].DisplayIndex = 4;
            dgv_asifijo.Columns[8].Visible = false;
            dgv_asifijo.Columns[9].HeaderText = "NIT";
            dgv_asifijo.Columns[9].DisplayIndex = 7;
            dgv_asifijo.Columns[10].HeaderText = "CHEQUE";
            dgv_asifijo.Columns[10].DisplayIndex = 8;
            dgv_asifijo.Columns[11].HeaderText = "DETALLE";
            dgv_asifijo.Columns[11].DisplayIndex = 5;
            dgv_asifijo.Columns[12].Visible = false;
            dgv_asifijo.Columns[13].Visible = false;
            dgv_asifijo.Columns[14].Visible = false;
            dgv_asifijo.Columns[15].Visible = false;
            dgv_asifijo.Columns[16].Visible = false;
            dgv_asifijo.Columns[17].Visible = false;
            dgv_asifijo.Columns[18].Visible = false;
            dgv_asifijo.Columns[19].Visible = false;
            dgv_asifijo.Columns[20].Visible = false;
            dgv_asifijo.Columns[21].Visible = false;
            dgv_asifijo.Columns[22].Visible = false;
            dgv_asifijo.Columns[11].Width = 200;
            dgv_asifijo.Columns[6].Width = 110;
        }

        /// <summary>
        /// Cargar lista de cuentas en datagriedview
        /// </summary>
        /*private void CargarDatosCuenta()
        {
            List<AsientoDataSource> datasSource = new List<AsientoDataSource>();
            try
            {
                datasSource = this.negocioAsiento.CargarTodosAsientos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un error. " + ex.Message);
            }

            dgv_asifijo.DataSource = datasSource;
            this.NombresColumna();
        }*/

        private void dgv_asifijo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!dgv_asifijo.CurrentRow.Cells[2].Value.ToString().Equals(string.Empty))
            {
               string documento = dgv_asifijo.CurrentRow.Cells[2].Value.ToString();
                this.Close();
              //  this.formularioAsiento.CargarDatosAsientoFijo(documento);
                this.formularioAsiento.Show();
            }
        }

        /* private void Btn_buscar_Click(object sender, EventArgs e)
         {
            /* List<CuentaDataSource> datasSource = new List<CuentaDataSource>();
             datasSource = this.negocioCuenta.BuscarCuenta(txt_buscar.Text);
             if (datasSource.Count() > 0)
             {
                 this.NombresColumna();
                 dgv_asifijo.DataSource = datasSource;
             }
             else
             {
                 MessageBox.Show("No se encuentra ningun resultado", "BUSQUEDA", MessageBoxButtons.OK);
             }
         }

         private void Txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (e.KeyChar == (char)Keys.Enter)
             {
                 e.Handled = true;
                 EventArgs eve = new EventArgs();
                 this.Btn_buscar_Click(sender, eve);
             }
         }*/
    }
}
