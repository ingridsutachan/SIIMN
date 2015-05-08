////*********************************************************
//
//    <copyright file="frmcomprobantes.cs" company="Marketing Software de Colombia LTDA">
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
    using System.Text;
    using Entities.Types;
    using Entities;
    using Datos.Contable;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class tributariosn
    {
        private Tributariosc persistencia;

        public tributariosn()
        {
            this.persistencia = new Tributariosc();
        }

        public List<TributarioDataSource> CargarDatos()
        {
            List<TributarioDataSource> tribut = new List<TributarioDataSource>();
            try
            {
                var items = this.persistencia.CargarTributario();
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        TributarioDataSource tri = new TributarioDataSource();
                        tri.Codigo = item.codigotrib;
                        tri.NombreTrib = item.nombre;
                        tri.Tope = item.tope;
                        tri.IdNitTope = item.idnittope;
                        tribut.Add(tri);
                    }
                }
                else
                {
                    tribut = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return tribut;
        }

        public bool GuardarTribut(TributarioDataSource tribut)
        {
            maetribut tri = new maetribut();
            tri.codigotrib = tribut.Codigo;
            tri.nombre = tribut.NombreTrib;
            tri.idnittope = tribut.IdNitTope;
            tri.tope = tribut.Tope;
            try
            {
                return this.persistencia.GuardarTribut(tri);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public TributarioDataSource DevolverDatos(string codigo)
        {
            TributarioDataSource tribut = new TributarioDataSource();
            try
            {
                var item = this.persistencia.DevolverDatos(codigo);
                if (item != null)
                {
                    tribut.Codigo = item.codigotrib;
                    tribut.NombreTrib = item.nombre;
                    tribut.Tope = item.tope;
                    tribut.IdNitTope = item.idnittope;
                }
                else
                {
                    tribut = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return tribut;
        }

        public bool ActualizarTribut(TributarioDataSource tribut)
        {
            maetribut tri = new maetribut();
            tri.codigotrib = tribut.Codigo;
            tri.nombre = tribut.NombreTrib;
            tri.idnittope = tribut.IdNitTope;
            tri.tope = tribut.Tope;

            try
            {
                return this.persistencia.ActualizarTribut(tri);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EliminarTribut(string codigo)
        {
            try
            {
                return this.persistencia.EliminarTributario(codigo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ExisteTributario(string codigtrib)
        {
            try
            {
                return this.persistencia.ExisteTributario(codigtrib);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TributarioDataSourceShow> Busqueda(string tipo, string buscar)
        {
            try
            {
                var items = this.persistencia.Busqueda(tipo, buscar);
                if (items != null)
                {
                    List<TributarioDataSourceShow> tribut = new List<TributarioDataSourceShow>();
                    foreach (var item in items)
                    {
                        TributarioDataSourceShow trib = new TributarioDataSourceShow();
                        trib.Codigo = item.codigotrib;
                        trib.NombreTrib = item.nombre;
                        trib.Tope = item.tope;
                        trib.NitTope = item.idnittope != null ? item.maenits.nit : string.Empty;
                        trib.NombreNit = item.idnittope != null ? item.maenits.nombrenit : string.Empty;
                        tribut.Add(trib);
                    }
                    return tribut;
                }
                else
                {
                    return this.TributarioNull();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<TributarioDataSourceShow> TributarioNull()
        {
            List<TributarioDataSourceShow> tributa = new List<TributarioDataSourceShow>();
            TributarioDataSourceShow ds = new TributarioDataSourceShow();
            ds.Codigo = null;
            ds.NombreTrib = null;
            ds.Tope = null;
            ds.NitTope = null;
            ds.NombreNit = null;
            tributa.Add(ds);
            return tributa;
        }

        public List<TributarioDataSourceShow> CargarInforme()
        {
            try
            {
                var items = this.persistencia.CargarInforme();
                if (items != null)
                {
                    List<TributarioDataSourceShow> tributa = new List<TributarioDataSourceShow>();
                    foreach (var item in items)
                    {
                        TributarioDataSourceShow trib = new TributarioDataSourceShow();
                        trib.Codigo = item.codigotrib;
                        trib.NombreTrib = item.nombre;
                        trib.Tope = item.tope;
                        trib.NitTope = item.idnittope != null ? item.maenits.nit : string.Empty;
                        trib.NombreNit = item.idnittope != null ? item.maenits.nombrenit : string.Empty;
                        tributa.Add(trib);
                    }
                    return tributa;
                }
                else
                {
                    return this.TributarioNull();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
