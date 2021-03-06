﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entities.Types;
using Negocios.Factura;

namespace App.Forms.Factura
{
    public partial class Form_VisualFactura : Form
    {

        private string busqueda;

        private string menub;

        private VendedorN negocioVendedor;
        private Form_Vendedores form_Vendedores;
       
        public Form_VisualFactura(string buscar, string menu, Form_Vendedores formvend)
        {
            this.negocioVendedor = new VendedorN();
            this.InitializeComponent();
            this.busqueda = buscar;
            this.menub = menu;
            this.form_Vendedores = formvend;
            this.Visual();

        }

        private void Visual()
        {
            if (busqueda.Equals("vendedor"))
            {
                this.Text = "VENDEDORES";
                ts_buscar1.Text = "Codigo";
                ts_buscar2.Text = "Nombre";
                ts_buscar3.Text = "Cedula";
                ts_buscar4.Text = "Activos";
                List<VendedorDataSource> tablavendedores = new List<VendedorDataSource>();
                try
                {
                    tablavendedores = this.negocioVendedor.Busqueda("todos", "todos");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se presento un error. " + ex.Message);
                }
                dgv_busqueda.DataSource = tablavendedores;
                this.TablaVendedor();
            }
        }

        private void TablaVendedor()
        {
            dgv_busqueda.Columns[0].Visible = false;
            dgv_busqueda.Columns[1].Width = 70;
            dgv_busqueda.Columns[2].Width = 70;
            dgv_busqueda.Columns[3].Width = 150;
            dgv_busqueda.Columns[6].Width = 150;
            dgv_busqueda.Columns[7].Width = 150;
            dgv_busqueda.Columns[8].Width = 70;
            dgv_busqueda.Columns[9].Width = 70;
            dgv_busqueda.Columns[10].Width = 70;

        }

        private void ts_buscar1_Click(object sender, EventArgs e)
        {
            lbl_buscar.Text = ts_buscar1.Text;
        }

        private void ts_buscar2_Click(object sender, EventArgs e)
        {
            lbl_buscar.Text = ts_buscar2.Text;
        }

        private void ts_buscar3_Click(object sender, EventArgs e)
        {
            lbl_buscar.Text = ts_buscar3.Text;
        }

        private void txt_busqueda_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (this.busqueda.Equals("vendedor"))
                {
                    List<VendedorDataSource> busqueda = new List<VendedorDataSource>();
                    try
                    {
                        busqueda = this.negocioVendedor.Busqueda(lbl_buscar.Text.ToLower(), txt_busqueda.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se presento un error. " + ex.Message);
                    }
                    dgv_busqueda.DataSource = busqueda;
                }
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            if (this.busqueda.Equals("vendedor"))
            {
                this.form_Vendedores.HabilitarBot();
            }
        }

        private void ts_buscar4_Click(object sender, EventArgs e)
        {
            lbl_buscar.Text = ts_buscar4.Text;
        }

        private void lbl_buscar_TextChanged(object sender, EventArgs e)
        {
            if (this.busqueda.Equals("vendedor") && lbl_buscar.Text.Equals("Activos"))
            {
                List<VendedorDataSource> busqueda = new List<VendedorDataSource>();
                try
                {
                    busqueda = this.negocioVendedor.Busqueda(lbl_buscar.Text.ToLower(), txt_busqueda.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se presento un error. " + ex.Message);
                }
                dgv_busqueda.DataSource = busqueda;
            }
        }

        private void dgv_busqueda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.busqueda.Equals("vendedor") && this.menub.Equals("editar"))
            {
                int codig = int.Parse(dgv_busqueda.CurrentRow.Cells[2].Value.ToString());
                this.Close();
                this.form_Vendedores.CargarDatos(codig);
                this.form_Vendedores.Show();
            }
            if (this.busqueda.Equals("vendedor") && this.menub.Equals("eliminar"))
            {
                int codig = int.Parse(dgv_busqueda.CurrentRow.Cells[2].Value.ToString());
                DialogResult result = MessageBox.Show("Esta seguro que desea eliminar?", "ELIMINAR", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    bool val = this.negocioVendedor.Eliminar(codig);
                    if (val)
                    {
                        MessageBox.Show("ESTE REGISTRO FUE ELIMINADO", "ELIMINAR", MessageBoxButtons.OK);
                        this.Close();
                        this.form_Vendedores.HabilitarBot();
                    }
                }
            }
        }

        private void Form_VisualFactura_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.busqueda.Equals("vendedor"))
            {
                this.form_Vendedores.HabilitarBot();
            }
        }
    }
}