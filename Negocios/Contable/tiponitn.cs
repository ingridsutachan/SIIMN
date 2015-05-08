////*********************************************************
//
//    <copyright file="tiponitn.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 01 marzo 2014
//    </copyright>
//
////*********************************************************
namespace Negocios.Contable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Datos.Contable;
    using Entities.Types;

    /// <summary>
    /// Clase Tipo de nit
    /// </summary>
    public class Tiponitn
    {
        /// <summary>
        /// Instancia de Capa de Datos
        /// </summary>
        private Tiponitc persistencia;

        /// <summary>
        /// Initializes a new instance of the <see cref="Tiponitn"/> class.
        /// </summary>
        public Tiponitn()
        {
            try
            {
                this.persistencia = new Tiponitc();
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }

        /// <summary>
        /// Cargar los tipos
        /// </summary>
        /// <returns>lista de tipos de nit</returns>
        public List<TiposNitsDataSource> CargarTipos()
        {
            List<TiposNitsDataSource> tipos = new List<TiposNitsDataSource>();
            try
            {
                var items = this.persistencia.DevolverTipo().OrderBy(t => t.nombretipo);
                foreach (var item in items)
                {
                    TiposNitsDataSource tips = new TiposNitsDataSource();
                    tips.Idtipo = item.idtiponit;
                    tips.Nombretipo = item.nombretipo;
                    tipos.Add(tips);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return tipos;
        }
    }
}
