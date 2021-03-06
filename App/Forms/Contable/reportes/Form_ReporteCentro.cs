﻿////*********************************************************
//
//    <copyright file="Form_ReporteCentro.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 24 feb 2015
//    </copyright>
//
////*********************************************************
namespace App.Forms.Contable.Reportes
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using App.Forms.Contable.Reportes.Types;
    using Entities.Types;
    using Negocios.Contable;

    public partial class Form_ReporteCentro : Form
    {
        private Frmcentro frmcentro;

        private Centron negocioCentro;

        public Form_ReporteCentro()
        {
            this.InitializeComponent();
        }

        public Form_ReporteCentro(Frmcentro frmcentro)
        {
            // TODO: Complete member initialization
            this.frmcentro = frmcentro;
            this.InitializeComponent();
            this.negocioCentro = new Centron();
            this.GenerarReporte();
            crystal_reportcentro.ShowLogo = false;
        }
        
        #region METODOS FORMULARIO

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                EventArgs eve = new EventArgs();
                object sender = new object();
                this.Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form_ReporteCentro_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.frmcentro.BotonesHabit();
        }

        #endregion

        #region REPORTE

        private void GenerarReporte()
        {
            List<CentroDataSourceShow> centro = new List<CentroDataSourceShow>();
            centro = this.negocioCentro.CargarInforme();
            List<CentroDataSourceReporte> centroR = new List<CentroDataSourceReporte>();
            this.Size = new Size(840, 566);
            foreach (CentroDataSourceShow item in centro)
            {
                CentroDataSourceReporte centrR = new CentroDataSourceReporte();
                centrR.Codigo = item.Codcentro ?? default(int);
                centrR.NombreCentro = item.Nombrecentro;
                centroR.Add(centrR);
            }

            ReporteCentro reportcentro = new ReporteCentro();
            reportcentro.SetDataSource(centroR);
            crystal_reportcentro.ReportSource = reportcentro;
        }

        #endregion
    }
}
