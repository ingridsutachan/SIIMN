﻿////*********************************************************
//
//    <copyright file="frmvisualizarcuentas.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 01 marzo 2014
//    </copyright>
//
////*********************************************************
namespace App.Forms.Contable
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using Entities.Types;
    using Negocios.Contable;

    public partial class Frmvisualizarcuentas : Form
    {
        /// <summary>
        /// instacia la cuenta de la capa negocios
        /// </summary>
        private Cuentan negocioCuenta;

        public Frmvisualizarcuentas()
        {
            this.InitializeComponent();
            this.negocioCuenta = new Cuentan();
            this.CargarDatosCuenta();
            this.Location = new Point(0, 50);
        }

        /// <summary>
        /// Nombres de las columnas de la tabla cuenta
        /// </summary>
        private void NombresColumna()
        {
            dgvdatoscuenta.Columns[0].HeaderText = "Cuenta";
            dgvdatoscuenta.Columns[1].HeaderText = "Clase";
            dgvdatoscuenta.Columns[2].HeaderText = "Grupo";
            dgvdatoscuenta.Columns[3].HeaderText = "Compañia";
            dgvdatoscuenta.Columns[4].HeaderText = "Tipo de Cuenta";
            dgvdatoscuenta.Columns[5].HeaderText = "Descripción";
            dgvdatoscuenta.Columns[6].HeaderText = "Pide NIT";
            dgvdatoscuenta.Columns[7].HeaderText = "Centro de Costos";
            dgvdatoscuenta.Columns[8].HeaderText = "Ajustes Integrales";
            dgvdatoscuenta.Columns[9].HeaderText = "NIT Ajustes";
            dgvdatoscuenta.Columns[10].HeaderText = "Cuenta Ajustes";
            dgvdatoscuenta.Columns[11].HeaderText = "Cuenta Correción";
            dgvdatoscuenta.Columns[12].HeaderText = "D/C";
            dgvdatoscuenta.Columns[13].HeaderText = "Cuenta Retención";
            dgvdatoscuenta.Columns[14].HeaderText = "% Retención";
            dgvdatoscuenta.Columns[15].HeaderText = "Concepto de Retención";
            dgvdatoscuenta.Columns[16].HeaderText = "Cuenta Cierre Impuestos";
        }

        /// <summary>
        /// Cargar lista de cuentas en datagriedview
        /// </summary>
        private void CargarDatosCuenta()
        {
            List<CuentaDataSource> datasSource = new List<CuentaDataSource>();
            try
            {
                datasSource = this.negocioCuenta.CargarCuenta();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un error. " + ex.Message);
            }

            dgvdatoscuenta.DataSource = datasSource;
            this.NombresColumna();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            /*List<CuentaDataSource> datasSource = new List<CuentaDataSource>();
            datasSource = this.negocioCuenta.BuscarCuenta(txt_buscar.Text);
            if (datasSource.Count() > 0)
            {
                this.NombresColumna();
                dgvdatoscuenta.DataSource = datasSource;
            }
            else
            {
                MessageBox.Show("No se encuentra ningun resultado", "BUSQUEDA", MessageBoxButtons.OK);
            }*/
        }

        private void Txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                EventArgs eve = new EventArgs();
                this.Btn_buscar_Click(sender, eve);
            }
        }
    }
}
