﻿////*********************************************************
//
//    <copyright file="Form_ReporteNits.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 20 feb 2015
//    </copyright>
//
////*********************************************************

namespace App.Forms.Contable.Reportes
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using App.Forms.Contable.Reportes.Types;
    using Entities.Types;
    using Negocios.Contable;
    using Negocios.General;
        using System.Drawing;
   
    public partial class Form_ReporteNits : Form
    {
        private Nitsn negocioNits;

        private Frmnits frmnits;

        private Empresan negocioEmpresa;

        public Form_ReporteNits()
        {
            this.negocioNits = new Nitsn();
            this.negocioEmpresa = new Empresan();
            this.InitializeComponent();
        }

        public Form_ReporteNits(Frmnits frmnits, string tipo)
        {
            this.frmnits = frmnits;
            this.negocioNits = new Nitsn();
            this.negocioEmpresa = new Empresan();
            this.InitializeComponent();
            crystal_reportnits.ShowLogo = false;
            this.GenerarReporte(tipo);
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

        private void Form_ReporteNits_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.frmnits.BotonesHabit();
        }

        #endregion

        #region REPORTE

        private void GenerarReporte(string tipo)
        {
            List<NitsDataSourceShow> nits = new List<NitsDataSourceShow>();
            if ("numero".Equals(tipo))
            {
                nits = this.negocioNits.CargarNitsReporteOrdeNumero();
            }
            else
            {
                nits = this.negocioNits.CargarNitsReporteOrdNombre();
            }
            this.Size = new Size(840, 566);
            List<NitsDataSourceReports> nitsR = new List<NitsDataSourceReports>();
            EmpresaDataSource empresa = new EmpresaDataSource();
            empresa = this.negocioEmpresa.DevolverDatosEmpresa(Program.compa);
            foreach (NitsDataSourceShow item in nits)
            {
                NitsDataSourceReports nitR = new NitsDataSourceReports();
                nitR.Nit = item.Nit;
                nitR.Digito = item.Digito;
                nitR.Tiponit = item.Tiponit;
                nitR.Nombrenit = item.Nombrenit;
                nitR.Direccion = item.Direccion;
                nitR.Telefono = item.Telefono;
                nitR.Celular = item.Celular;
                nitR.Idpais = item.NombrePais;
                nitR.Iddepartamento = item.NombreDepto;
                nitR.Idciudad = item.NombreCiudad;
                nitR.Compania_nits = empresa.Nombrecia;
                nitsR.Add(nitR);
            }

            ReporteNits reportnit = new ReporteNits();
            reportnit.SetDataSource(nitsR);
            crystal_reportnits.ReportSource = reportnit;
        }

        #endregion
    }
}
