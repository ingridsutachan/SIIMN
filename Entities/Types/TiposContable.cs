﻿namespace Entities.Types
{
    using System;

    /// <summary>
    /// Clase cuenta data source
    /// </summary>
    public class CuentaDataSource
    {
        /// <summary>
        /// Gets or sets the cuenta.
        /// </summary>
        /// <value>
        /// The cuenta.
        /// </value>
        public string Cuenta { get; set; }

        /// <summary>
        /// Gets or sets the nombre.
        /// </summary>
        /// <value>
        /// The nombre.
        /// </value>
        public string Nombre { get; set; }

        /// <summary>
        /// Gets or sets the tipocta.
        /// </summary>
        /// <value>
        /// The tipocta.
        /// </value>
        public string Tipocta { get; set; }

        /// <summary>
        /// Gets or sets the pidenit.
        /// </summary>
        /// <value>
        /// The pidenit.
        /// </value>
        public bool Pidenit { get; set; }

        /// <summary>
        /// Gets or sets the centro.
        /// </summary>
        /// <value>
        /// The centro.
        /// </value>
        public bool Centro { get; set; }

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
        public decimal? Porete { get; set; }

        /// <summary>
        /// Gets or sets the concepret.
        /// </summary>
        /// <value>
        /// The concepret.
        /// </value>
        public string Concepret { get; set; }

        public bool ReteIca { get; set; }

        public decimal? PoreteIca { get; set; }

        public string ConcepReteIca { get; set; }

        /// <summary>
        /// Gets or sets the cuentacierreimp.
        /// </summary>
        /// <value>
        /// The cuentacierreimp.
        /// </value>
        public string Cuentacierreimp { get; set; }

        public string FormatoMedios { get; set; }
    }

    /// <summary>
    /// Clase presupuesto data source
    /// </summary>
    public class PresupDataSource
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
        public int IdMes { get; set; }

        /// <summary>
        /// Gets or sets the cuenta.
        /// </summary>
        /// <value>
        /// The cuenta.
        /// </value>
        public string Cuenta { get; set; }

        public string NombreCuenta { get; set; }

        public string NombreCentro { get; set; }
        /// <summary>
        /// Gets or sets the presupuesto.
        /// </summary>
        /// <value>
        /// The presupuesto.
        /// </value>
        public decimal Presupuesto { get; set; }

        /// <summary>
        /// Gets or sets the nombre mes.
        /// </summary>
        /// <value>
        /// The nombre mes.
        /// </value>
        public string NombreMes { get; set; }

        public int IdCentro { get; set; }

        public int IdSucursal { get; set; }
    }

    /// <summary>
    /// Clase presupuesto data source
    /// </summary>
    public class PresupShowDataSource
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
        public int? IdMes { get; set; }

        /// <summary>
        /// Gets or sets the cuenta.
        /// </summary>
        /// <value>
        /// The cuenta.
        /// </value>
        public string Cuenta { get; set; }

        public int? IdCentro { get; set; }

        /// <summary>
        /// Gets or sets the presupuesto.
        /// </summary>
        /// <value>
        /// The presupuesto.
        /// </value>
        public decimal? Presupuesto { get; set; }

    }


    /// <summary>
    /// Clase nit data source
    /// </summary>
    public class NitsDataSource
    {
        /// <summary>
        /// Gets or sets the idnit.
        /// </summary>
        /// <value>
        /// The idnit.
        /// </value>
        public int Idnit { get; set; }

        /// <summary>
        /// Gets or sets the tiponit.
        /// </summary>
        /// <value>
        /// The tiponit.
        /// </value>
        public string Tiponit { get; set; }

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
        /// Gets or sets the nombrenit.
        /// </summary>
        /// <value>
        /// The nombrenit.
        /// </value>
        public string Nombrenit { get; set; }

        /// <summary>
        /// Gets or sets the idciudad.
        /// </summary>
        /// <value>
        /// The idciudad.
        /// </value>
        public int Idciudad { get; set; }

        /// <summary>
        /// Gets or sets the actividad economica.
        /// </summary>
        /// <value>
        /// The actividad economica.
        /// </value>
        public string ActividadEconomica { get; set; }

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

        public int IdPais { get; set; }

        public int IdDepto { get; set; }
    }

    /// <summary>
    /// Clase nit data source
    /// </summary>
    public class NitsDataSourceShow
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
        /// Gets or sets the actividad economica.
        /// </summary>
        /// <value>
        /// The actividad economica.
        /// </value>
        public string ActividadEconomica { get; set; }

        public string NombrePais { get; set; }

        public string NombreDepto { get; set; }

        /// <summary>
        /// Gets or sets the idciudad.
        /// </summary>
        /// <value>
        /// The idciudad.
        /// </value>
        public string NombreCiudad { get; set; }

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
    /// Clase tipos de nit data source
    /// </summary>
    public class TiposNitsDataSource
    {
        /// <summary>
        /// Gets or sets the idtipo.
        /// </summary>
        /// <value>
        /// The idtipo.
        /// </value>
        public int Idtipo { get; set; }

        /// <summary>
        /// Gets or sets the nombretipo.
        /// </summary>
        /// <value>
        /// The nombretipo.
        /// </value>
        public string Nombretipo { get; set; }
    }

    public class ComprobantesDataSource
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
        public bool Consecutivo { get; set; }

        /// <summary>
        /// Gets or sets the numerosigui.
        /// </summary>
        /// <value>
        /// The numerosigui.
        /// </value>
        public int? Numerosigui { get; set; }

        /// <summary>
        /// Gets or sets the codigootra.
        /// </summary>
        /// <value>
        /// The codigootra.
        /// </value>
        public string Codigootra { get; set; }
    }

    public class ComprobantesDataSourceShow
    {
        /// <summary>
        /// Gets or sets the codigo.
        /// </summary>
        /// <value>
        /// The codigo.
        /// </value>
        public int? Codigo { get; set; }

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
        public bool Consecutivo { get; set; }

        /// <summary>
        /// Gets or sets the numerosigui.
        /// </summary>
        /// <value>
        /// The numerosigui.
        /// </value>
        public int? Numerosigui { get; set; }

        /// <summary>
        /// Gets or sets the codigootra.
        /// </summary>
        /// <value>
        /// The codigootra.
        /// </value>
        public string Codigootra { get; set; }
    }

    public class CentroDataSource
    {
        public int Codcentro { get; set; }

        public string Nombrecentro { get; set; }
    }

    public class CentroDataSourceShow
    {
        public int? Codcentro { get; set; }

        public string Nombrecentro { get; set; }
    }

    public class FormatoDataSource
    {
        public int IdFormato { get; set; }

        public string TipoFormato { get; set; }

        public string Nombre { get; set; }

        public string ClaseCuenta { get; set; }

        public string Linea { get; set; }

        public string CuentaInicial { get; set; }

        public string CuentaFinal { get; set; }
    }

    public class FormatoDataSourceShow
    {
        public string ClaseCuenta { get; set; }

        public string Linea { get; set; }

        public string Nombre { get; set; }

        public string CuentaInicial { get; set; }

        public string CuentaFinal { get; set; }
    }

    public class TributarioDataSource
    {
        public string Codigo { get; set; }

        public string NombreTrib { get; set; }

        public decimal? Tope { get; set; }

        public int? IdNitTope { get; set; }
    }

    public class TributarioDataSourceShow
    {
        public string Codigo { get; set; }

        public string NombreTrib { get; set; }

        public decimal? Tope { get; set; }

        public string NitTope { get; set; }

        public string NombreNit { get; set; }
    }

    public class InflacionDataSource
    {
        public int Mes { get; set; }

        public int IdSucursal { get; set; }

        public decimal inflacion { get; set; }
    }

    public class AsientoDataSource
    {
        public int Idcompania { get; set; }

        public string IdAsiento { get; set; }

        public string Anio { get; set; }

        public int Idmes { get; set; }

        public DateTime Fecha { get; set; }

        public int Codcompr { get; set; }

        public string Documento { get; set; }

        public bool AsiFijo { get; set; }

        public string Cuenta { get; set; }

        public int? Idcentro { get; set; }

        public int? IdNit { get; set; }

        public string Cheque { get; set; }

        public string Descripcion { get; set; }

        public decimal Valorcredito { get; set; }

        public decimal Valordebito { get; set; }

        public decimal BaseImpuesto { get; set; }

        public decimal ValorIca { get; set; }

        public int IdModuloImprime { get; set; }

        public string IdTipoDcto { get; set; }

        public int Usuario { get; set; }

        public DateTime Fechagraba { get; set; }

        public int? Usuarioact { get; set; }

        public DateTime? Fechaactua { get; set; }

        public bool Actualizado { get; set; }

        public string Entrada { get; set; }
    }

    public class AsientoDataSourceDevuelve
    {
        public string Anio { get; set; }

        public int Mes { get; set; }

        public DateTime Fecha { get; set; }

        public int Codcompr { get; set; }

        public string Documento { get; set; }

        public string Cuenta { get; set; }

        public int? Idcentro { get; set; }

        public string Nit { get; set; }

        public string Cheque { get; set; }

        public string Descripcion { get; set; }

        public decimal Valorcredito { get; set; }

        public decimal Valordebito { get; set; }

        public bool Actualizado { get; set; }
    }

    public class AsientoDevolverVal
    {

        public bool Guardo { get; set; }

        public string asientoguard { get; set; }

    }

    public class AsientoDataSourceFijo
    {
        public string NumeroAsiento { get; set; }

        public string Cuenta { get; set; }

        public int? Idcentro { get; set; }

        public string Nit { get; set; }

        public string Cheque { get; set; }

        public string Descripcion { get; set; }

        public decimal ValorDebito { get; set; }

        public decimal ValorCredito { get; set; }
    }

    public class AsientoDataSourceView
    {
        public string Anio { get; set; }

        public string Mes { get; set; }

        public string Fecha { get; set; }

        public string Comprobante { get; set; }

        public string Documento { get; set; }

        public string Detalle { get; set; }
    }

    public class AsientoDataSourceShow
    {
        public string IdAsiento { get; set; }

        public string Fecha { get; set; }

        public string Comproban { get; set; }

        public string Documento { get; set; }

        public string Cuenta { get; set; }

        public int? Idcentro { get; set; }

        public string IdNit { get; set; }

        public string Cheque { get; set; }

        public string Descripcion { get; set; }

        public decimal Valorcredito { get; set; }

        public decimal Valordebito { get; set; }
    }

    public class CuentaDataSourceSaldo
    {
        public string TipoCuenta { get; set; }

        public bool PideNit { get; set; }

        public bool PideCentro { get; set; }

        public bool PideRete { get; set; }

        public decimal Retencion { get; set; }

        public string CuentaAju { get; set; }

        public string Doc { get; set; }

        public decimal saldo { get; set; }

        public int mes { get; set; }

        public decimal credito { get; set; }

        public decimal debito { get; set; }
    }

    public class SaldosCuentasDataSource
    {
        public int Sucursal { get; set; }

        public int IdCuenta { get; set; }

        public string Cuenta { get; set; }

        public string NombreCuenta { get; set; }

        public int Mes { get; set; }

        public string Anio { get; set; }

        public decimal ValorCredito { get; set; }

        public decimal ValorDebito { get; set; }

        public decimal SaldoActual { get; set; }

        public decimal SaldoAnterior { get; set; }
    }

    /// <summary>
    /// Clase nit data source
    /// </summary>
    public class SaldosNitsDataSource
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
        /// Gets or sets the nombrenit.
        /// </summary>
        /// <value>
        /// The nombrenit.
        /// </value>
        public string Nombrenit { get; set; }

        public string Cuenta { get; set; }

        public decimal SaldoAnterioMes { get; set; }
        /// <summary>
        /// Gets or sets the actividad economica.
        /// </summary>
        /// <value>
        /// The actividad economica.
        /// </value>
        public decimal SaldoNit { get; set; }

        public decimal DebitoNit { get; set; }

        public decimal CreditoNit { get; set; }

    }

    public class SaldoAnualDataSource
    {
        public string Cuenta { get; set; }

        public string NombreCuenta { get; set; }

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

    public class LibroAuxiliarDataSource
    {

        public DateTime Fecha { get; set; }

        public string Anio { get; set; }

        public int Mes { get; set; }

        public int Sucursal { get; set; }

        public string Comproban { get; set; }

        public string Documento { get; set; }

        public string Cuenta { get; set; }

        public string NombreCuenta { get; set; }

        public int Idcentro { get; set; }

        public string Descripcion { get; set; }

        public decimal Valorcredito { get; set; }

        public decimal Valordebito { get; set; }
    }

    public class AsientoDataSourceAct
    {
        public string Anio { get; set; }

        public int Mes { get; set; }

        public DateTime Fecha { get; set; }

        public int Codcompr { get; set; }

        public string Documento { get; set; }

        public int Cuenta { get; set; }

        public int? Idcentro { get; set; }

        public int? Nit { get; set; }

        public string Cheque { get; set; }

        public string Descripcion { get; set; }

        public decimal Valorcredito { get; set; }

        public decimal Valordebito { get; set; }

        public int Sucursal { get; set; }

        public string idasiento { get; set; }
    }

    public class CierreCuentasEstadoDataSource
    {
        public string Cuentainiing { get; set; }

        public string Cuentafining { get; set; }

        public string Cuentainicos { get; set; }

        public string Cuentafincos { get; set; }

        public string Cuentauti { get; set; }

        public string Detalle { get; set; }

        public string Codcompro { get; set; }
    }
}
