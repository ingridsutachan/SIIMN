namespace Negocios.Factura
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Datos.Factura;
    using Entities;
    using Entities.Types;

    public class VendedorN
    {
        private VendedorC persistencia;


        public VendedorN()
        {
            this.persistencia = new VendedorC();
        }

        public List<VendedorDataSource> Busqueda(string tipo, string buscar)
        {
            List<VendedorDataSource> vendbus = new List<VendedorDataSource>();
            try
            {
                var items = persistencia.Busqueda(tipo, buscar).OrderBy(v => v.idvendedor);
                foreach (var item in items)
                {
                    VendedorDataSource vend = new VendedorDataSource();
                    vend.Codigo = item.idvendedor;
                    vend.Tipo = item.tipo == "0" ? "VENDEDOR" : "MESERO";
                    vend.Nombre = item.nombrevendedor;
                    vend.Cedula = item.cedula;
                    vend.Telefono = item.telefono;
                    vend.Email = item.emailvend;
                    vend.Direccion = item.direcvend;
                    vend.Activo = item.activo;
                    vend.ComisionR = item.comisionrango;
                    vend.Comision = item.comision;
                    vendbus.Add(vend);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return vendbus;
        }

        public bool Guardar(VendedorDataSource vend)
        {
            bool val = false;
            vendedor ved = new vendedor();
            ved = this.CambiarTipoE(vend);
            try
            {
                val = this.persistencia.Guardar(ved);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return val;
        }

        private vendedor CambiarTipoE(VendedorDataSource vend)
        {
            vendedor ved = new vendedor();
            
            ved.idvendedor = vend.Codigo;
            ved.tipo = vend.Tipo;
            ved.nombrevendedor = vend.Nombre;
            ved.cedula = vend.Cedula;
            ved.telefono = vend.Telefono;
            ved.emailvend = vend.Email;
            ved.direcvend = vend.Direccion;
            ved.activo = vend.Activo;
            ved.comisionrango = vend.ComisionR;
            ved.comision = vend.Comision;
            return ved;
        }

        public bool CodigoExiste(int codigo)
        {
            bool val = false;
            try
            {
                val = this.persistencia.CodigoExiste(codigo);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return val;
        }

        public VendedorDataSource DevolverVendedor(int codigvend)
        {
            VendedorDataSource vend = new VendedorDataSource();
            vendedor vendda = new vendedor();
            try
            {
                vendda = this.persistencia.DevolverVendedor(codigvend);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            vend = this.CambiarTipoT(vendda);
            return vend;
        }

        private VendedorDataSource CambiarTipoT(vendedor vendda)
        {
            VendedorDataSource vend = new VendedorDataSource();
            vend.Compania = vendda.idcompania;
            vend.Codigo = vendda.idvendedor;
            vend.Tipo = vendda.tipo = vendda.tipo;
            vend.Nombre = vendda.nombrevendedor;
            vend.Cedula = vendda.cedula;
            vend.Telefono = vendda.telefono;
            vend.Email = vendda.emailvend;
            vend.Direccion = vendda.direcvend;
            vend.Activo = vendda.activo;
            vend.ComisionR = vendda.comisionrango;
            vend.Comision = vendda.comision;

            return vend;
        }

        public bool Editar(VendedorDataSource vend)
        {
            bool val = false;
            vendedor ved = new vendedor();
            ved = this.CambiarTipoE(vend);
            try
            {
                val = this.persistencia.Editar(ved);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return val;
        }

        public bool Eliminar(int codig)
        {
            bool val = false;
            try
            {
                val = this.persistencia.Editar(codig);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return val;
        }

        /*public List<MoviVendedorDataSource> CargarVendedorReporte(int compania)
        {
            List<MoviVendedorDataSource> vend = new List<MoviVendedorDataSource>();
            try
            {
                var fecha = DateTime.Now;
                var items = this.persistencia.CargarVendedorReporte(compania);

                var otra = items.Where(v => int.Parse(v.anio) == fecha.Year).GroupBy(mov => mov.vendedor.codigovend)
                                             .Select(res => new { codigo = res.Key, suma = res.Sum(r => r.venta) });


                foreach (var item in items)
                {
                    MoviVendedorDataSource ved = new MoviVendedorDataSource();
                    ved.CodigoVend = item.vendedor.codigovend;
                    ved.TipoVend = item.vendedor.tipo == "0" ? "VENDEDOR" : "MESERO";
                    ved.NombreVend = item.vendedor.nombrevend;
                    ved.Mes = fecha.Month;
                    ved.Comision = items.Where(v => v.idvendedor == item.vendedor.idvendedor && item.idmes == fecha.Month && int.Parse(item.anio) == fecha.Year).Count() > 0
                           ? items.Where(v => v.idvendedor == item.vendedor.idvendedor && item.idmes == fecha.Month && int.Parse(item.anio) == fecha.Year)
                            .First().comision : 0;
                    ved.ValorMensual = items.Where(v => v.idvendedor == item.vendedor.idvendedor && item.idmes == fecha.Month && int.Parse(item.anio) == fecha.Year).Count() > 0
                                             ? items.Where(v => v.idvendedor == item.vendedor.idvendedor && item.idmes == fecha.Month && int.Parse(item.anio) == fecha.Year)
                                            .First().venta : 0;
                    ved.ValorAcumulado = otra.Where(v => int.Parse(v.codigo) == item.vendedor.idvendedor).First().suma;
                    vend.Add(ved);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            var result = vend.GroupBy(v => v.CodigoVend).Select(r => r.First());

            vend = result.ToList();

            return vend;
        }*/
    }
}
