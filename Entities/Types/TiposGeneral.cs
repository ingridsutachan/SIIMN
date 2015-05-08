////*********************************************************
//
//    <copyright file="Tipos.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 01 marzo 2014
//    </copyright>
//
////*********************************************************
namespace Entities.Types
{
    using System;

    /// <summary>
    /// Clase empresa data source
    /// </summary>
    public class EmpresaDataSource
    {
        /// <summary>
        /// Gets or sets the idcompania.
        /// </summary>
        /// <value>
        /// The idcompania.
        /// </value>
        public int Idcompania { get; set; }

        /// <summary>
        /// Gets or sets the nombrecia.
        /// </summary>
        /// <value>
        /// The nombrecia.
        /// </value>
        public string Nombrecia { get; set; }

        public string NombreSucursal { get; set; }

        public string NitCia { get; set; }

        public string DigitoCia { get; set; }

        public string NombreCiudad { get; set; }
    }

    /// <summary>
    /// Clase pais data source
    /// </summary>
    public class PaisDataSource
    {
        /// <summary>
        /// Gets or sets the idpais.
        /// </summary>
        /// <value>
        /// The idpais.
        /// </value>
        public int Idpais { get; set; }

        /// <summary>
        /// Gets or sets the nombrepais.
        /// </summary>
        /// <value>
        /// The nombrepais.
        /// </value>
        public string Nombrepais { get; set; }
    }

    /// <summary>
    /// Clase departamento data source
    /// </summary>
    public class DeptoDataSource
    {
        /// <summary>
        /// Gets or sets the iddpto.
        /// </summary>
        /// <value>
        /// The iddpto.
        /// </value>
        public int Iddpto { get; set; }

        /// <summary>
        /// Gets or sets the idpais.
        /// </summary>
        /// <value>
        /// The idpais.
        /// </value>
        public int Idpais { get; set; }


        public string CodigDedpto { get; set; }

        /// <summary>
        /// Gets or sets the nombredpto.
        /// </summary>
        /// <value>
        /// The nombredpto.
        /// </value>
        public string Nombredpto { get; set; }
    }

    /// <summary>
    /// Claseciudad data source
    /// </summary>
    public class CiudadDataSource
    {
        /// <summary>
        /// Gets or sets the idciudad.
        /// </summary>
        /// <value>
        /// The idciudad.
        /// </value>
        public int Idciudad { get; set; }

        /// <summary>
        /// Gets or sets the iddpto.
        /// </summary>
        /// <value>
        /// The iddpto.
        /// </value>
        public int Iddpto { get; set; }

        public string CodigCiudad { get; set; }

        /// <summary>
        /// Gets or sets the nombreciudad.
        /// </summary>
        /// <value>
        /// The nombreciudad.
        /// </value>
        public string Nombreciudad { get; set; }
    }

    public class MesesDataSource
    {
        public string NumeroMes { get; set; }

        public string NombreMes { get; set; }
    }

    /// <summary>
    /// Clase usuario data source
    /// </summary>
    public class UsuarioDataSource
    {
        /// <summary>
        /// Gets or sets the iduser.
        /// </summary>
        /// <value>
        /// The iduser.
        /// </value>
        public int Iduser { get; set; }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        /// <value>
        /// The user.
        /// </value>
        public string User { get; set; }

        /// <summary>
        /// Gets or sets the contrasena.
        /// </summary>
        /// <value>
        /// The contrasena.
        /// </value>
        public string Contrasena { get; set; }

        /// <summary>
        /// Gets or sets the fechaultimaconex.
        /// </summary>
        /// <value>
        /// The fechaultimaconex.
        /// </value>
        public DateTime? Fechaultimaconex { get; set; }

        /// <summary>
        /// Gets or sets the ultimobloqueo.
        /// </summary>
        /// <value>
        /// The ultimobloqueo.
        /// </value>
        public DateTime? Ultimobloqueo { get; set; }

        /// <summary>
        /// Gets or sets the intentosfallidos.
        /// </summary>
        /// <value>
        /// The intentosfallidos.
        /// </value>
        public int Intentosfallidos { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [bloqueado].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [bloqueado]; otherwise, <c>false</c>.
        /// </value>
        public bool Bloqueado { get; set; }
    }
}