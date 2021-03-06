﻿////*********************************************************
//
//    <copyright file="Form_ReporteComprobante.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 20 feb 2015
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

    public partial class Form_ReporteComprobante : Form
    {
        private Frmcomprobantes frmcomprobantes;

        private Comprobantesn negocioComprobante;

        public Form_ReporteComprobante()
        {
            this.InitializeComponent();

            crystal_reportcompro.ShowLogo = false;
        }

        public Form_ReporteComprobante(Frmcomprobantes frmcomprobantes)
        {
            // TODO: Complete member initialization
            this.frmcomprobantes = frmcomprobantes;
            this.negocioComprobante = new Comprobantesn();
            this.InitializeComponent();
            this.GenerarReporte();
            crystal_reportcompro.ShowLogo = false;
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

        private void Form_ReporteComprobante_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.frmcomprobantes.BotonesHabit();
        }

        #endregion

        #region REPORTE

        private void GenerarReporte()
        {
            List<ComprobantesDataSourceShow> comproban = new List<ComprobantesDataSourceShow>();
            comproban = this.negocioComprobante.CargarInforme();

            List<ComprobantesDataSourceReporte> comprobR = new List<ComprobantesDataSourceReporte>();
            this.Size = new Size(840, 566);
            foreach (ComprobantesDataSourceShow item in comproban)
            {
                ComprobantesDataSourceReporte comproR = new ComprobantesDataSourceReporte();
                comproR.Codigo = item.Codigo ?? default(int);
                comproR.Descricompro = item.Descricompro;
                comproR.Consecutivo = item.Consecutivo == true ? "SI" : "NO";
                comproR.Numerosigui = item.Numerosigui ?? default(int);
                comproR.Codigootra = item.Codigootra;
                comprobR.Add(comproR);
            }

            ReporteComprobante reportcompr = new ReporteComprobante();
            reportcompr.SetDataSource(comprobR);
            crystal_reportcompro.ReportSource = reportcompr;
        }

        #endregion
    }
}
