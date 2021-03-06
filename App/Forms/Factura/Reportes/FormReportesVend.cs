﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using App.Forms.Factura.Reportes.Types;
using Entities.Types;
using Negocios.Factura;


namespace App.Forms.Factura.Reportes
{
    public partial class FormReportesVend : Form
    {
        private VendedorN negocioVendedor;

        public FormReportesVend()
        {
            this.negocioVendedor = new VendedorN();

            this.InitializeComponent();
        }

        private void FormReportesVend_Load(object sender, EventArgs e)
        {
            List<MoviVendedorDataSource> vendedor = new List<MoviVendedorDataSource>();
           // vendedor = this.negocioVendedor.CargarVendedorReporte(Program.compa);
            List<VendedorDataSourceReports> vendedoR = new List<VendedorDataSourceReports>();
            foreach (MoviVendedorDataSource item in vendedor)
            {
                VendedorDataSourceReports vendeS = new VendedorDataSourceReports();
                vendeS.Codigo = item.CodigoVend;
                vendeS.Nombre = item.NombreVend;
                vendeS.Tipo = item.TipoVend;
                vendeS.Comision = item.Comision;
                vendeS.VentasMensual = item.ValorMensual;
                vendeS.VentasAcum = item.ValorAcumulado;
                vendedoR.Add(vendeS);
            }

          // Create a CrystalReport1 object
            ReporteVendedores reportvend = new ReporteVendedores();
              // Set the DataSource of the report
              reportvend.SetDataSource(vendedoR);
              // Set the Report Source to ReportView 
              report_vendedores.ReportSource = reportvend;
        }
    }
}
