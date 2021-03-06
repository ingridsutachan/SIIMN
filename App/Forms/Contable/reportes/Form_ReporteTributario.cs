﻿////*********************************************************
//
//    <copyright file="Form_ReporteTributario.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 26 febrero 2015
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
    using Negocios.General;

    public partial class Form_ReporteTributario : Form
    {
        private FrmTributario frmTributario;

        private tributariosn negocioTributario;

        private Empresan negocioEmpresa;

               public Form_ReporteTributario()
        {
            this.InitializeComponent();
        }

        public Form_ReporteTributario(FrmTributario frmTributario)
        {
            // TODO: Complete member initialization
            this.negocioEmpresa = new Empresan();
            this.frmTributario = frmTributario;
            this.InitializeComponent();
            this.negocioTributario = new tributariosn();
            this.GenerarReporte();
            crystal_reporttribut.ShowLogo = false;
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

        private void Form_ReporteTributario_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.frmTributario.BotonesHabit();
        }

        #endregion

        #region REPORTE

        private void GenerarReporte()
        {
            List<TributarioDataSourceShow> tribut = new List<TributarioDataSourceShow>();
            tribut = this.negocioTributario.CargarInforme();
            EmpresaDataSource empresa = new EmpresaDataSource();
            empresa = this.negocioEmpresa.DevolverDatosEmpresa(Program.compa);
            List<TributarioDataSourceReport> tributR = new List<TributarioDataSourceReport>();
            this.Size = new Size(840, 566);
            foreach (TributarioDataSourceShow item in tribut)
            {
                TributarioDataSourceReport tribR = new TributarioDataSourceReport();
                tribR.Codigo = item.Codigo;
                tribR.NombreTrib = item.NombreTrib;
                tribR.Tope = item.Tope ?? default(decimal);
                tribR.NitTope = item.NitTope;
                tribR.NombreNit = item.NombreNit;
                tribR.NombreCia = empresa.Nombrecia;
                tributR.Add(tribR);
            }

            ReporteTributario reporttribut = new ReporteTributario();
            reporttribut.SetDataSource(tributR);
            crystal_reporttribut.ReportSource = reporttribut;
        }
  
        #endregion
    }
}
