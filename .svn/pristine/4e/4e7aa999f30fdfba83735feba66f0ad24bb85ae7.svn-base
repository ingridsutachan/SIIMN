////*********************************************************
//
//    <copyright file="Form_ReporteAsiento.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 24 de Marzo 2015
//    </copyright>
//
////*********************************************************
namespace App.Forms.Contable.Reportes
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using App.Forms.Contable.Reportes.Types;
    using Entities.Types;
    using Negocios.Contable;
    using Negocios.General;

    public partial class Form_ReporteAsiento : Form
    {
        private Form_Asientos form_Asientos;

        private string cualasiento;

        private List<AsientoDataSource> asientoshow;

        private asientosn negocioAsiento;

        private Empresan negocioEmpresa;

        private Comprobantesn negocioComprobante;

        private Nitsn negocioNits;

        private Form_MovsinAct formMovsinAct;

        private List<AsientoDataSourceShow> asientosllega;

        private string fechareport;

        private bool encabezado;

        private Form_LibroDiario form_LibroDiario;

        public Form_ReporteAsiento()
        {
            InitializeComponent();
        }
        public Form_ReporteAsiento(Form_Asientos form_Asientos, string whatasiento, List<AsientoDataSource> asientos)
        {
            // TODO: Complete member initialization
            this.form_Asientos = form_Asientos;
            this.cualasiento = whatasiento;
            this.asientoshow = asientos;
            this.negocioAsiento = new asientosn();
            this.negocioEmpresa = new Empresan();
            this.negocioComprobante = new Comprobantesn();
            this.negocioNits = new Nitsn();
            this.InitializeComponent();
            this.GenerarReporte(this.cualasiento);
            crystal_reportasiento.ShowLogo = false;
        }

        public Form_ReporteAsiento(Form_Asientos form_Asientos, string whatasiento)
        {
            this.form_Asientos = form_Asientos;
            this.cualasiento = whatasiento;
            this.negocioAsiento = new asientosn();
            this.negocioEmpresa = new Empresan();
            this.negocioComprobante = new Comprobantesn();
            this.negocioNits = new Nitsn();
            this.InitializeComponent();
            this.GenerarReporte(this.cualasiento);
            crystal_reportasiento.ShowLogo = false;
        }

        public Form_ReporteAsiento(Form_MovsinAct form_MovsinAct, string sinact, List<AsientoDataSourceShow> asientos, string fecha, bool encab)
        {
            this.formMovsinAct = form_MovsinAct;
            this.cualasiento = sinact;
            this.fechareport = fecha;
            this.encabezado = encab;
            this.asientosllega = asientos;
            this.negocioAsiento = new asientosn();
            this.negocioEmpresa = new Empresan();
            this.negocioComprobante = new Comprobantesn();
            this.negocioNits = new Nitsn();
            this.InitializeComponent();
            this.GenerarReporte(this.cualasiento);
            crystal_reportasiento.ShowLogo = false;
        }

        public Form_ReporteAsiento(Form_LibroDiario form_LibroDiario, string librodiario, List<AsientoDataSourceShow> asientolibrodiario, string fecha, bool encab)
        {
            // TODO: Complete member initialization
            this.negocioAsiento = new asientosn();
            this.negocioEmpresa = new Empresan();
            this.negocioComprobante = new Comprobantesn();
            this.negocioNits = new Nitsn();
            this.InitializeComponent();
            this.form_LibroDiario = form_LibroDiario;
            this.cualasiento = librodiario;
            this.asientosllega = asientolibrodiario;
            this.fechareport = fecha;
            this.encabezado = encab;
            this.Visibilidad(this.cualasiento);
            this.GenerarReporte(this.cualasiento);

        }

        private void Visibilidad(string cualasiento)
        {
            if (cualasiento.Equals("librodiario"))
            {
                crystal_reportasiento.Visible = true;
            }
            else if (cualasiento.Equals("libroresumido"))
            {
                crystal_ReporteResumido.Visible = true;
                crystal_reportasiento.Visible = false;
            }
        }

        #region EVENTOS FORMULARIO

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form_ReporteAsiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ("borrados".Equals(this.cualasiento) || "fijos".Equals(this.cualasiento))
            {
                this.form_Asientos.SalirReporteBorFij();
            }
            else if ("actual".Equals(this.cualasiento))
            {
                this.form_Asientos.SalirReporteActual();
            }
            else if ("sinact".Equals(this.cualasiento))
            {
                this.formMovsinAct.SalirReporte();
            }
            else if ("librodiario".Equals(this.cualasiento))
            {
                this.form_LibroDiario.SalirReporte(1);
            }
            else if ("libroresumido".Equals(this.cualasiento))
            {
                this.form_LibroDiario.SalirReporte(2);
            }
        }

        #endregion

        private void GenerarReporte(string cualasi)
        {
            EmpresaDataSource empresa = new EmpresaDataSource();
            try
            {
                empresa = this.negocioEmpresa.DevolverDatosEmpresa(Program.compa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE PRESENTO UN ERROR" + ex.Message, "ERROR", MessageBoxButtons.OK);
            }
            List<AsientoDataSource> asiento = new List<AsientoDataSource>();
            switch (cualasi)
            {
                case "actual":
                    asiento = this.asientoshow;
                    string comprob = string.Empty;
                    this.Text = "REPORTE ASIENTO";
                    try
                    {
                        comprob = this.negocioComprobante.DevolverNombre(asiento[0].Codcompr);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR" + ex.Message, "ERROR", MessageBoxButtons.OK);
                    }

                    List<AsientoDataSourceReports> asientoRe = new List<AsientoDataSourceReports>();
                    for (int i = 0; i < asiento.Count(); i++)
                    {
                        AsientoDataSourceReports asientoR = new AsientoDataSourceReports();
                        asientoR.IdAsiento = asiento[i].IdAsiento;
                        asientoR.Compania = empresa.Nombrecia + " - " + empresa.NombreSucursal;
                        asientoR.Comproban = asiento[i].Codcompr + " - " + comprob;
                        asientoR.Documento = asiento[i].Documento;
                        asientoR.Cuenta = asiento[i].Cuenta;
                        asientoR.FechaAct = "FECHA : " + DateTime.Now.ToShortTimeString();
                        asientoR.Fecha = asiento[i].Fecha.ToShortDateString();
                        asientoR.Idcentro = asiento[i].Idcentro ?? default(int);
                        asientoR.IdNit = asiento[i].IdNit != null ? this.negocioNits.DevolverNit(asiento[i].IdNit) : string.Empty;
                        asientoR.Cheque = asiento[i].Cheque;
                        asientoR.Descripcion = asiento[i].Descripcion;
                        asientoR.Valordebito = asiento[i].Valordebito;
                        asientoR.Valorcredito = asiento[i].Valorcredito;
                        asientoRe.Add(asientoR);
                    }

                    ReporteAsiento reportasiento = new ReporteAsiento();
                    reportasiento.SetDataSource(asientoRe);
                    crystal_reportasiento.ReportSource = reportasiento;
                    this.Size = new Size(1003, 583);
                    crystal_reportasiento.Size = new Size(987, 519);
                    break;

                case "borrados":

                    List<AsientoDataSourceShow> asientobor = new List<AsientoDataSourceShow>();
                    this.Text = "REPORTE ASIENTOS BORRADOS";
                    try
                    {
                        asientobor = this.negocioAsiento.CargarInforme("borrados", Program.compa);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR" + ex.Message, "ERROR", MessageBoxButtons.OK);
                    }

                    List<AsientoDataSourceReports> asientoRep = new List<AsientoDataSourceReports>();
                    foreach (AsientoDataSourceShow item in asientobor)
                    {
                        AsientoDataSourceReports asientoR = new AsientoDataSourceReports();
                        asientoR.IdAsiento = item.IdAsiento;
                        asientoR.Compania = empresa.Nombrecia + " - " + empresa.NombreSucursal;
                        asientoR.FechaAct = "FECHA : " + DateTime.Now.ToShortTimeString();
                        asientoR.Comproban = item.Comproban;
                        asientoR.Documento = item.Documento;
                        asientoR.Cuenta = item.Cuenta;
                        asientoR.Fecha = "FECHA : " + item.Fecha;
                        asientoR.Idcentro = item.Idcentro ?? default(int);
                        asientoR.IdNit = item.IdNit;
                        asientoR.Cheque = item.Cheque;
                        asientoR.Descripcion = item.Descripcion;
                        asientoR.Valordebito = item.Valordebito;
                        asientoR.Valorcredito = item.Valorcredito;
                        asientoRep.Add(asientoR);
                    }

                    ReporteAsiento reportasientobor = new ReporteAsiento();
                    reportasientobor.SetDataSource(asientoRep);
                    crystal_reportasiento.ReportSource = reportasientobor;
                    this.Size = new Size(1003, 583);
                    crystal_reportasiento.Size = new Size(987, 519);
                    break;

                case "fijos":
                    List<AsientoDataSourceShow> asientofijo = new List<AsientoDataSourceShow>();
                    this.Text = "REPORTE ASIENTOS FIJOS";
                    try
                    {
                        asientofijo = this.negocioAsiento.CargarInforme("fijos", Program.compa);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SE PRESENTO UN ERROR" + ex.Message, "ERROR", MessageBoxButtons.OK);
                    }

                    List<AsientoDataSourceReports> asientoRepo = new List<AsientoDataSourceReports>();
                    foreach (AsientoDataSourceShow item in asientofijo)
                    {
                        AsientoDataSourceReports asientoR = new AsientoDataSourceReports();
                        asientoR.IdAsiento = item.IdAsiento;
                        asientoR.FechaAct = "FECHA : " + DateTime.Now.ToShortTimeString();
                        asientoR.Compania = empresa.Nombrecia + " - " + empresa.NombreSucursal;
                        asientoR.Comproban = item.Comproban;
                        asientoR.Documento = item.Documento.Replace("FIJO", string.Empty);
                        asientoR.Cuenta = item.Cuenta;
                        asientoR.Fecha = item.Fecha;
                        asientoR.Idcentro = item.Idcentro ?? default(int);
                        asientoR.IdNit = item.IdNit;
                        asientoR.Cheque = item.Cheque;
                        asientoR.Descripcion = item.Descripcion;
                        asientoR.Valordebito = item.Valordebito;
                        asientoR.Valorcredito = item.Valorcredito;
                        asientoRepo.Add(asientoR);
                    }

                    ReporteAsiento reportasientofij = new ReporteAsiento();
                    reportasientofij.SetDataSource(asientoRepo);
                    crystal_reportasiento.ReportSource = reportasientofij;
                    this.Size = new Size(1003, 583);
                    crystal_reportasiento.Size = new Size(987, 519);
                    break;


                case "sinact":
                    List<AsientoDataSourceReports> asientoRsinAct = new List<AsientoDataSourceReports>();
                    this.Text = "REPORTE ASIENTOS SIN ACTUALIZAR";
                    foreach (AsientoDataSourceShow item in this.asientosllega)
                    {
                        AsientoDataSourceReports asientoR = new AsientoDataSourceReports();
                        asientoR.IdAsiento = item.IdAsiento;
                        if (this.encabezado)
                        {
                            asientoR.Compania = empresa.Nombrecia + " - " + empresa.NombreSucursal;
                            asientoR.FechaAct = "FECHA : " + DateTime.Now.ToShortTimeString();
                        }

                        asientoR.Comproban = item.Comproban;
                        asientoR.Documento = item.Documento;
                        asientoR.Cuenta = item.Cuenta;
                        asientoR.Fecha = item.Fecha;
                        asientoR.Idcentro = item.Idcentro ?? default(int);
                        asientoR.IdNit = item.IdNit;
                        asientoR.Cheque = item.Cheque;
                        asientoR.Descripcion = item.Descripcion;
                        asientoR.Valordebito = item.Valordebito;
                        asientoR.Valorcredito = item.Valorcredito;
                        asientoRsinAct.Add(asientoR);
                    }

                    ReporteAsiento reportasientosinact = new ReporteAsiento();
                    reportasientosinact.SetDataSource(asientoRsinAct);
                    crystal_reportasiento.ReportSource = reportasientosinact;
                    this.Size = new Size(1003, 583);
                    crystal_reportasiento.Size = new Size(987, 519);
                    break;

                case "librodiario":
                    List<AsientoDataSourceReports> asientoRlibrodiario = new List<AsientoDataSourceReports>();
                    this.Text = "REPORTE LIBRO DIARIO";
                    foreach (AsientoDataSourceShow item in this.asientosllega)
                    {
                        AsientoDataSourceReports asientoR = new AsientoDataSourceReports();
                        asientoR.IdAsiento = item.IdAsiento;
                        if (this.encabezado)
                        {
                            asientoR.Compania = empresa.Nombrecia + " - " + empresa.NombreSucursal;
                            asientoR.FechaAct = "FECHA : " + DateTime.Now.ToShortTimeString();
                        }
                        asientoR.Comproban = item.Comproban;
                        asientoR.Documento = item.Documento;
                        asientoR.Cuenta = item.Cuenta;
                        asientoR.Fecha = item.Fecha;
                        asientoR.Idcentro = item.Idcentro ?? default(int);
                        asientoR.IdNit = item.IdNit;
                        asientoR.Cheque = item.Cheque;
                        asientoR.Descripcion = item.Descripcion;
                        asientoR.Valordebito = item.Valordebito;
                        asientoR.Valorcredito = item.Valorcredito;
                        asientoRlibrodiario.Add(asientoR);
                    }

                    ReporteAsiento reportasientolibro = new ReporteAsiento();
                    reportasientolibro.SetDataSource(asientoRlibrodiario);
                    crystal_reportasiento.ReportSource = reportasientolibro;
                    this.Size = new Size(1003, 583);
                    crystal_reportasiento.Size = new Size(987, 519);
                    break;

                case "libroresumido":
                    List<AsientoDataSourceReports> asientoRlibroresumido = new List<AsientoDataSourceReports>();
                    this.Text = "REPORTE LIBRO RESUMIDO";
                    foreach (AsientoDataSourceShow item in this.asientosllega)
                    {
                        AsientoDataSourceReports asientoR = new AsientoDataSourceReports();
                        asientoR.IdAsiento = item.IdAsiento;
                        if (this.encabezado)
                        {
                            asientoR.Compania = empresa.Nombrecia + " - " + empresa.NombreSucursal;
                            asientoR.FechaAct = "FECHA : " + DateTime.Now.ToShortTimeString();
                        }
                        asientoR.Comproban = item.Comproban;
                        asientoR.Documento = item.Documento;
                        asientoR.Cuenta = item.Cuenta;
                        asientoR.Fecha = item.Fecha;
                        asientoR.Idcentro = item.Idcentro ?? default(int);
                        asientoR.IdNit = item.IdNit;
                        asientoR.Cheque = item.Cheque;
                        asientoR.Descripcion = item.Descripcion;
                        asientoR.Valordebito = item.Valordebito;
                        asientoR.Valorcredito = item.Valorcredito;
                        asientoRlibroresumido.Add(asientoR);
                    }

                    ReporteLibroResumido reportasientolibrores = new ReporteLibroResumido();
                    reportasientolibrores.SetDataSource(asientoRlibroresumido);
                    crystal_ReporteResumido.ReportSource = reportasientolibrores;
                    this.Size = new Size(1003, 583);
                    crystal_ReporteResumido.Size = new Size(987, 519);
                    break;
            }
        }
    }
}
