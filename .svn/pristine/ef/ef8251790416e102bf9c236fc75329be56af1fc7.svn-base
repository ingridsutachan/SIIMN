using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;

namespace Datos.Factura
{
    public class VendedorC
    {
        public VendedorC()
        {
        }

        public List<vendedor> Busqueda(string tipo, string buscar)
        {
            List<vendedor> vend = new List<vendedor>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    if (tipo.Equals("codigo"))
                    {
                       // var query = bd.vendedor.Where(ved => ved.idvendedor.Contains(buscar)).ToList();
                        //vend = query;
                    }
                    if (tipo.Equals("nombre"))
                    {
                        var query = bd.vendedor.Where(ved => ved.nombrevendedor.Contains(buscar)).ToList();
                        vend = query;
                    }
                    if (tipo.Equals("cedula"))
                    {
                        var query = bd.vendedor.Where(ved => ved.cedula.Contains(buscar)).ToList();
                        vend = query;
                    }
                    if (tipo.Equals("busqueda"))
                    {
                       // var query = bd.vendedor.Where(ved => ved.cedula.Contains(buscar) || ved.idvendedor.Contains(buscar) || ved.nombrevend.Contains(buscar)).ToList();
                       // vend = query;
                    }
                    if (tipo.Equals("todos"))
                    {
                        vend = bd.vendedor.ToList();
                    }
                    if (tipo.Equals("activos"))
                    {
                        var query = bd.vendedor.Where(ved => ved.activo == true).ToList();
                        vend = query;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return vend;
        }

        public bool CodigoExiste(int codigo)
        {
            bool val = false;
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.vendedor.Where(ved => ved.idvendedor == codigo).Count();
                    if (query > 0)
                    {
                        val = false;
                    }
                    else
                    {
                        val = true;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return val;
        }

        public bool Guardar(vendedor ved)
        {
            bool val = false;
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    bd.vendedor.Add(ved);
                    bd.SaveChanges();
                    val = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return val;
        }

        public vendedor DevolverVendedor(int codigvend)
        {
            vendedor vend = new vendedor();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.vendedor.Where(ven => ven.idvendedor == codigvend).First();
                    vend = query;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return vend;
        }

        public bool Editar(vendedor ved)
        {
            bool val = false;
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.vendedor.Where(ven => ven.idvendedor == ved.idvendedor).First();
                    query.cedula = ved.cedula;
                    query.nombrevendedor = ved.nombrevendedor;
                    query.tipo = ved.tipo;
                    query.telefono = ved.telefono;
                    query.emailvend = ved.emailvend;
                    query.direcvend = ved.direcvend;
                    query.activo = ved.activo;
                    query.comisionrango = ved.comisionrango;
                    query.comision = ved.comision;
                    query.idcompania = ved.idcompania;
                    bd.SaveChanges();
                    val = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return val;
        }

        public bool Editar(int codig)
        {
            bool val = false;
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.vendedor.Where(ven => ven.idvendedor == codig).First();
                    bd.vendedor.Remove(query);
                    bd.SaveChanges();
                    val = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return val;
        }

       /* public List<movvend> CargarVendedorReporte(int compa)
        {
            List<movvend> vend = new List<movvend>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.movvend.Include("vendedor")
                                          .Where(mov => mov.idcompania == compa);
                    if (query.Count() > 0)
                        vend = query.ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return vend;
        }*/
    }
}