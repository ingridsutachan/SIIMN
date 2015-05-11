// -----------------------------------------------------------------------
// <copyright file="ClientesD.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Datos.Cartera
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entities;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ClientesD
    {
        public ClientesD()
        {
        }

        public List<cliente> CargarClientes()
        {
            List<cliente> clientes = new List<cliente>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    clientes = bd.cliente.Include("ciudad").Include("maeconta").ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return clientes;
        }

        public int ObtenerCodigo()
        {
            int codigo = 0;
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.maecli.Count();
                    if (query > 0)
                    {
                        var query1 = bd.maecli.ToList().OrderByDescending(m => m.codigocli).First();
                        codigo = query1.codigocli + 1;
                    }
                    else
                    {
                        codigo = 1;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return codigo;
        }

        public bool GuardarCliente(cliente cliente)
        {
            bool guardo = false;
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    bd.cliente.Add(cliente);
                    bd.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                guardo = true;
            }

            return guardo;
        }

        public cliente DevolverCliente(int id)
        {
            cliente cliente = new cliente();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.cliente.Include("pais").Include("ciudad").Include("departamento").Include("maeconta").Include("vendedor").Where(ma => ma.idcliente == id).First();
                    cliente = query;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return cliente;
        }

        public bool ActualizarCliente(cliente clientes)
        {
            bool guardo = false;
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.cliente.Where(ma => ma.idcliente == clientes.idcliente).First();
                    query.idcliente = clientes.idcliente;
                    query.documento = clientes.documento;
                    query.digito = clientes.digito;
                    query.nombre = clientes.nombre;
                    query.idciudad = clientes.idciudad;
                    query.direccion = clientes.direccion;
                    query.telefono = clientes.telefono;
                    query.celular = clientes.celular;
                    query.fax = clientes.fax;
                    query.email = clientes.email;
                    bd.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                guardo = true;
            }

            return guardo;
        }

        public bool EliminarCliente(int idcli)
        {
            bool result = false;
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.cliente.Where(mae => mae.idcliente == idcli).First();
                    bd.cliente.Remove(query);
                    bd.SaveChanges();
                    result = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return result;
        }

        public List<cliente> BuscarCliente(string buscar)
        {
            List<cliente> clientes = new List<cliente>();
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.cliente.Include("pais").Include("ciudad").Include("departamento").Include("maeconta").
                    Include("vendedor").Where(mae => mae.documento.Contains(buscar) || mae.nombre.Contains(buscar));
                if (query.Count() > 0)
                {
                    clientes = query.ToList();
                }
            }

            return clientes;
        }
    }
}
