﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Forms.Contable.Reportes.Types
{
    class TypesReports
    {
    }

    /// <summary>
    /// Clase cuenta data source
    /// </summary>
    public class CuentaDataSourceReports
    {
        /// <summary>
        /// Gets or sets the cuenta.
        /// </summary>
        /// <value>
        /// The cuenta.
        /// </value>
        public string Cuenta { get; set; }

        /// <summary>
        /// Gets or sets the cia.
        /// </summary>
        /// <value>
        /// The cia.
        /// </value>
        public string NombreCia { get; set; }

        public string NombreSucursal { get; set; }

        public string NitCia { get; set; }

        /// <summary>
        /// Gets or sets the tipocta.
        /// </summary>
        /// <value>
        /// The tipocta.
        /// </value>
        public string Tipocta { get; set; }

        /// <summary>
        /// Gets or sets the nombre.
        /// </summary>
        /// <value>
        /// The nombre.
        /// </value>
        public string Nombre { get; set; }

        /// <summary>
        /// Gets or sets the pidenit.
        /// </summary>
        /// <value>
        /// The pidenit.
        /// </value>
        public string Pidenit { get; set; }

        /// <summary>
        /// Gets or sets the centro.
        /// </summary>
        /// <value>
        /// The centro.
        /// </value>
        public string Centro { get; set; }

        /// <summary>
        /// Gets or sets the ajusteinteg.
        /// </summary>
        /// <value>
        /// The ajusteinteg.
        /// </value>
        public bool Ajusteinteg { get; set; }

        /// <summary>
        /// Gets or sets the nitajustes.
        /// </summary>
        /// <value>
        /// The nitajustes.
        /// </value>
        public string Nitajustes { get; set; }

        /// <summary>
        /// Gets or sets the cueaju.
        /// </summary>
        /// <value>
        /// The cueaju.
        /// </value>
        public string Cueaju { get; set; }

        /// <summary>
        /// Gets or sets the cuencorre.
        /// </summary>
        /// <value>
        /// The cuencorre.
        /// </value>
        public string Cuencorre { get; set; }

        /// <summary>
        /// Gets or sets the ajudoc.
        /// </summary>
        /// <value>
        /// The ajudoc.
        /// </value>
        public string Ajudoc { get; set; }

        /// <summary>
        /// Gets or sets the cuentret.
        /// </summary>
        /// <value>
        /// The cuentret.
        /// </value>
        public bool Cuentret { get; set; }

        /// <summary>
        /// Gets or sets the porete.
        /// </summary>
        /// <value>
        /// The porete.
        /// </value>
        public decimal Porete { get; set; }

        public string Fecha { get; set; }
    }

    /// <summary>
    /// Clase nit data source
    /// </summary>
    public class NitsDataSourceReports
    {

        /// <summary>
        /// Gets or sets the nit.
        /// </summary>
        /// <value>
        /// The nit.
        /// </value>
        public string Nit { get; set; }

        /// <summary>
        /// Gets or sets the digito.
        /// </summary>
        /// <value>
        /// The digito.
        /// </value>
        public string Digito { get; set; }

        /// <summary>
        /// Gets or sets the compania_nits.
        /// </summary>
        /// <value>
        /// The compania_nits.
        /// </value>
        public string Compania_nits { get; set; }

        /// <summary>
        /// Gets or sets the tiponit.
        /// </summary>
        /// <value>
        /// The tiponit.
        /// </value>
        public string Tiponit { get; set; }

        /// <summary>
        /// Gets or sets the nombrenit.
        /// </summary>
        /// <value>
        /// The nombrenit.
        /// </value>
        public string Nombrenit { get; set; }

        /// <summary>
        /// Gets or sets the idpais.
        /// </summary>
        /// <value>
        /// The idpais.
        /// </value>
        public string Idpais { get; set; }

        /// <summary>
        /// Gets or sets the iddepartamento.
        /// </summary>
        /// <value>
        /// The iddepartamento.
        /// </value>
        public string Iddepartamento { get; set; }

        /// <summary>
        /// Gets or sets the idciudad.
        /// </summary>
        /// <value>
        /// The idciudad.
        /// </value>
        public string Idciudad { get; set; }

        /// <summary>
        /// Gets or sets the direccion.
        /// </summary>
        /// <value>
        /// The direccion.
        /// </value>
        public string Direccion { get; set; }

        /// <summary>
        /// Gets or sets the telefono.
        /// </summary>
        /// <value>
        /// The telefono.
        /// </value>
        public string Telefono { get; set; }

        /// <summary>
        /// Gets or sets the celular.
        /// </summary>
        /// <value>
        /// The celular.
        /// </value>
        public string Celular { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email { get; set; }
    }

    /// <summary>
    /// Clase presupuesto data source
    /// </summary>
    public class PresupShowDataSourceReporte
    {
        /// <summary>
        /// Gets or sets the anio.
        /// </summary>
        /// <value>
        /// The anio.
        /// </value>
        public string Anio { get; set; }

        /// <summary>
        /// Gets or sets the mes.
        /// </summary>
        /// <value>
        /// The mes.
        /// </value>
        public string NombreMes { get; set; }

        /// <summary>
        /// Gets or sets the cuenta.
        /// </summary>
        /// <value>
        /// The cuenta.
        /// </value>
        public string Cuenta { get; set; }

        public string IdCentro { get; set; }

        /// <summary>
        /// Gets or sets the presupuesto.
        /// </summary>
        /// <value>
        /// The presupuesto.
        /// </value>
        public decimal Presupuesto { get; set; }

        public string NombreEmpresa { get; set; }

        public string NitEmpresa { get; set; }

        public string Fecha { get; set; }

    }

    public class ComprobantesDataSourceReporte
    {
        /// <summary>
        /// Gets or sets the codigo.
        /// </summary>
        /// <value>
        /// The codigo.
        /// </value>
        public int Codigo { get; set; }

        /// <summary>
        /// Gets or sets the descricompro.
        /// </summary>
        /// <value>
        /// The descricompro.
        /// </value>
        public string Descricompro { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [consecutivo].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [consecutivo]; otherwise, <c>false</c>.
        /// </value>
        public string Consecutivo { get; set; }

        /// <summary>
        /// Gets or sets the numerosigui.
        /// </summary>
        /// <value>
        /// The numerosigui.
        /// </value>
        public int Numerosigui { get; set; }

        /// <summary>
        /// Gets or sets the codigootra.
        /// </summary>
        /// <value>
        /// The codigootra.
        /// </value>
        public string Codigootra { get; set; }
    }

    public class CentroDataSourceReporte
    {
        /// <summary>
        /// Gets or sets the codigo.
        /// </summary>
        /// <value>
        /// The codigo.
        /// </value>
        public int Codigo { get; set; }

        /// <summary>
        /// Gets or sets the descricompro.
        /// </summary>
        /// <value>
        /// The descricompro.
        /// </value>
        public string NombreCentro { get; set; }
    }

    public class FormatoDataSourceReport
    {
        public string TipoFormato { get; set; }

        public string Encabezado { get; set; }

        public string Nombre { get; set; }

        public string ClaseCuenta { get; set; }

        public string NombreClase { get; set; }

        public string Linea { get; set; }

        public string NombreLinea { get; set; }

        public string CuentaInicial { get; set; }

        public string NombreCuentaIni { get; set; }

        public string CuentaFinal { get; set; }

        public string NombreCuentaFin { get; set; }

        public string NombreEmpresa { get; set; }

        public string Fecha { get; set; }
    }

    public class TributarioDataSourceReport
    {
        public string Codigo { get; set; }

        public string NombreTrib { get; set; }

        public decimal Tope { get; set; }

        public string NitTope { get; set; }

        public string NombreNit { get; set; }

        public string NombreCia { get; set; }

    }

    public class AsientoDataSourceReports
    {
        public string IdAsiento { get; set; }

        public string FechaAct { get; set; }

        public string Compania { get; set; }

        public string Fecha { get; set; }

        public string Comproban { get; set; }

        public string Documento { get; set; }

        public string Cuenta { get; set; }

        public int Idcentro { get; set; }

        public string IdNit { get; set; }

        public string Cheque { get; set; }

        public string Descripcion { get; set; }

        public decimal Valorcredito { get; set; }

        public decimal Valordebito { get; set; }
    }

    public class BalanceDataSourceReports
    {
        public string MesyAnio { get; set; }

        public string FechaAct { get; set; }

        public string CompaniayNit { get; set; }

        public string Titulo { get; set; }

        public string CuentaMayor { get; set; }

        public string NombreCuentaMayor { get; set; }

        public string Cuenta { get; set; }

        public decimal SaldoAnterior { get; set; }

        public decimal SaldoActual { get; set; }

        public decimal Valorcredito { get; set; }

        public decimal Valordebito { get; set; }

        public string TituloNit { get; set; }

        public string Nit { get; set; }

        public decimal SaldoAnteriorNit { get; set; }

        public decimal ValorCreditoNit { get; set; }

        public decimal ValorDebitoNit { get; set; }

        public decimal SaldoActualNit { get; set; }
    }

    public class SaldosAnualDataSourceReports
    {
        public string FechaAct { get; set; }

        public string CompaniayNit { get; set; }

        public string Titulo { get; set; }

        public string CuentaMayor { get; set; }

        public string NombreCuentaMayor { get; set; }

        public string Cuenta { get; set; }

        public decimal SaldoEnero { get; set; }

        public decimal SaldoFebrero { get; set; }

        public decimal SaldoMarzo { get; set; }

        public decimal SaldoAbril { get; set; }

        public decimal SaldoMayo { get; set; }

        public decimal SaldoJunio { get; set; }

        public decimal SaldoJulio { get; set; }

        public decimal SaldoAgosto { get; set; }

        public decimal SaldoSeptiembre { get; set; }

        public decimal SaldoOctubre { get; set; }

        public decimal SaldoNoviembre { get; set; }

        public decimal SaldoDiciembre { get; set; }
    }

    public class InventarioDataSourceReports
    {
        public string MesyAnio { get; set; }

        public string FechaAct { get; set; }

        public string Compania { get; set; }

        public string NitCia { get; set; }

        public string Titulo { get; set; }

        public string CuentaMayor { get; set; }

        public string NombreCuentaMayor { get; set; }

        public string Cuenta { get; set; }

        public decimal SaldoActual { get; set; }

        public string TituloNit { get; set; }

        public string Nit { get; set; }

        public decimal SaldoActualNit { get; set; }
    }

    public class LibroDiarioDataSourceReports
    {
        public string MesyAnio { get; set; }

        public string FechaAct { get; set; }

        public string Compania { get; set; }

        public string Titulo { get; set; }

        public string Cuenta { get; set; }

        public decimal SaldoAnteriorDebito { get; set; }

        public decimal SaldoAnteriorCredito { get; set; }

        public decimal SaldoActualDebito { get; set; }

        public decimal SaldoActualCredito { get; set; }

        public decimal Valorcredito { get; set; }

        public decimal Valordebito { get; set; }

    }

    public class LibroAuxiliarDataSourceReports
    {
        public string FechayHoraAct { get; set; }

        public string Compania { get; set; }

        public string NitCia { get; set; }

        public string Titulo { get; set; }

        public string Totales { get; set; }

        public string Cuenta { get; set; }
        
        public string NombreCuenta { get; set; }

        public string FechasEntre { get; set; }

        public string FechaCompr { get; set; }

        public string CentroCosto { get; set; }

        public string Comprobante { get; set; }

        public string CuentaMayor { get; set; }

        public string Asiento { get; set; }

        public string Descriptransa { get; set; }

         public decimal SaldoAnterior { get; set; }

        public decimal SaldoActualAcumu { get; set; }

        public decimal SaldoActual { get; set; }

        public decimal Valorcredito { get; set; }

        public decimal Valordebito { get; set; }

        public string Nit { get; set; }

        public decimal SaldoAnteriorNit { get; set; }

        public decimal ValorDebitoNit { get; set; }

        public decimal ValorCreditoNit { get; set; }

        public decimal SaldoNit { get; set; }

    }
}
