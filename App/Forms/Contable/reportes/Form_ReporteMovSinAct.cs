﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entities.Types;
using App.Forms.Contable.Reportes.Types;

namespace App.Forms.Contable.Reportes
{
    public partial class Form_ReporteMovSinAct : Form
    {

        public Form_ReporteMovSinAct()
        {
            InitializeComponent();
        }

       /* public void CargarReporte(List<AsientoDataSourceReporte> asiento)
        {
            // Create a CrystalReport1 object
            ReporteMovSinAct reportMovSinActu = new ReporteMovSinAct();
            // Set the DataSource of the report
            reportMovSinActu.SetDataSource(asiento);
            // Set the Report Source to ReportView 
            crystal_ReporteMovSin.ReportSource = reportMovSinActu;
        }*/
    }
}
