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
    public partial class Form_FormatoFactura : Form
    {

        private string boton;

        private FormatoN negocioFormato;

        public Form_FormatoFactura()
        {
            this.InitializeComponent();
            this.negocioFormato = new FormatoN();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            combo_tipo.Enabled = true;
            combo_tipo.Focus();
            this.boton = "nuevo";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void VisualTablaFactura()
        {
            List<FormatosDataSource> formato = new List<FormatosDataSource>();



        }

        private void dgv_factura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void combo_tipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txt_formato.Enabled = true;
            }
        }

     

        private void txt_formato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (this.boton.Equals("nuevo") && combo_tipo.SelectedIndex.ToString().Equals("0"))
                {
                    bool existe = this.negocioFormato.Existe(int.Parse(txt_formato.Text), 1);
                    if (existe)
                    {
                        MessageBox.Show("EL FORMATO YA EXISTE", "ERROR", MessageBoxButtons.OK);
                    }
                    else
                    {
                        txt_nombre.Enabled = true;
                        txt_ancho.Enabled = true;
                        tabcontrolFactura.Visible = true;
                        List<FormatosDataSource> formatofac = new List<FormatosDataSource>();
                        formatofac = this.negocioFormato.CargarCampos(1);
                        dgv_factura.DataSource = formatofac;
                        dgv_factura.Columns[0].HeaderText = "ITEM";
                        dgv_factura.Columns[1].HeaderText = "FILA";
                        dgv_factura.Columns[2].HeaderText = "COLUMNA";
                        dgv_factura.Columns[3].HeaderText = "CONDENSA";
                        dgv_factura.Columns[4].HeaderText = "PRESENTACION";
                        dgv_factura.Columns[5].HeaderText = "ACTIVO";
                        dgv_factura.Columns[0].Width = 150;
                        dgv_factura.Columns[1].Width = 70;
                        dgv_factura.Columns[2].Width = 70;
                        dgv_factura.Columns[3].Width = 80;
                        dgv_factura.Columns[4].Width = 120;
                        dgv_factura.Columns[5].Width = 60;

                    }
                }
                if (this.boton.Equals("nuevo") && combo_tipo.SelectedIndex.ToString().Equals("1"))
                {
                    bool existe = this.negocioFormato.Existe(int.Parse(txt_formato.Text), 2);
                    if (existe)
                    {
                        MessageBox.Show("EL FORMATO YA EXISTE", "ERROR", MessageBoxButtons.OK);
                    }
                    else
                    {
                        txt_nombre.Enabled = true;
                        txt_ancho.Enabled = true;
                        TabcontrolRemision.Visible = true;
                        List<FormatosDataSource> formatorec= new List<FormatosDataSource>();
                        formatorec = this.negocioFormato.CargarCampos(2);
                        dgv_remisiones.DataSource = formatorec;
                        dgv_remisiones.Columns[0].HeaderText = "ITEM";
                        dgv_remisiones.Columns[1].HeaderText = "FILA";
                        dgv_remisiones.Columns[2].HeaderText = "COLUMNA";
                        dgv_remisiones.Columns[3].HeaderText = "CONDENSA";
                        dgv_remisiones.Columns[4].HeaderText = "PRESENTACION";
                        dgv_remisiones.Columns[5].HeaderText = "ACTIVO";
                        dgv_remisiones.Columns[0].Width = 150;
                        dgv_remisiones.Columns[1].Width = 70;
                        dgv_remisiones.Columns[2].Width = 70;
                        dgv_remisiones.Columns[3].Width = 80;
                        dgv_remisiones.Columns[4].Width = 120;
                        dgv_remisiones.Columns[5].Width = 60;
                    }
                }

                if (this.boton.Equals("nuevo") && combo_tipo.SelectedIndex.ToString().Equals("2"))
                {
                    bool existe = this.negocioFormato.Existe(int.Parse(txt_formato.Text),3);
                    if (existe)
                    {
                        MessageBox.Show("EL FORMATO YA EXISTE", "ERROR", MessageBoxButtons.OK);
                    }
                    else
                    {
                        txt_nombre.Enabled = true;
                        txt_ancho.Enabled = true;
                        tab_cotizacion.Visible = true;
                        List<FormatosDataSource> formatocot = new List<FormatosDataSource>();
                        formatocot = this.negocioFormato.CargarCampos(3);
                        dgv_cotizacion.DataSource = formatocot;
                        dgv_cotizacion.Columns[0].HeaderText = "ITEM";
                        dgv_cotizacion.Columns[1].HeaderText = "FILA";
                        dgv_cotizacion.Columns[2].HeaderText = "COLUMNA";
                        dgv_cotizacion.Columns[3].HeaderText = "CONDENSA";
                        dgv_cotizacion.Columns[4].HeaderText = "PRESENTACION";
                        dgv_cotizacion.Columns[5].HeaderText = "ACTIVO";
                        dgv_cotizacion.Columns[0].Width = 150;
                        dgv_cotizacion.Columns[1].Width = 70;
                        dgv_cotizacion.Columns[2].Width = 70;
                        dgv_cotizacion.Columns[3].Width = 80;
                        dgv_cotizacion.Columns[4].Width = 120;
                        dgv_cotizacion.Columns[5].Width = 60;
                    }
                }
            }
        }
    }
}
