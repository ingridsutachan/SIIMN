// -----------------------------------------------------------------------
// <copyright file="ClientesN.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Negocios.Cartera
{
    using System;
    using System.Collections.Generic;
    using Datos.Cartera;
    using Entities;
    using Entities.Types;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ClientesN
    {
        private ClientesD persistencia;

        public ClientesN()
        {
            this.persistencia = new ClientesD();
        }

        public List<ClientesDataSource> CargarClientes()
        {
            List<ClientesDataSource> clientes = new List<ClientesDataSource>();
            var items = this.persistencia.CargarClientes();
            foreach (var item in items)
            {
                ClientesDataSource cliente = new ClientesDataSource();
                cliente.CodigoCliente = item.idcliente;
                cliente.NitCliente = item.documento;
                cliente.DigitoCliente = item.digito;
                cliente.NombreCliente = item.nombre;
                cliente.IdCiudad = item.idciudad;
                cliente.NombreCiudad = item.ciudad.nombreciudad;
                cliente.Direccion = item.direccion;
                cliente.Telefono = item.telefono;
                cliente.Celular = item.celular;
                cliente.Fax = item.fax;
                cliente.Email = item.email;
                clientes.Add(cliente);
            }

            return clientes;
        }

        public int ObtenerCodigo()
        {
            int codigo = 0;
            try
            {
                codigo = this.persistencia.ObtenerCodigo();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return codigo;
        }

        public bool GuardarCliente(ClientesDataSource cliente)
        {
            bool guardo = false;
            cliente clientes = new cliente();
            clientes.idcliente = cliente.CodigoCliente;
            clientes.documento = cliente.NitCliente;
            clientes.digito = cliente.DigitoCliente;
            clientes.nombre = cliente.NombreCliente;
            clientes.idciudad = cliente.IdCiudad;
            clientes.direccion = cliente.Direccion;
            clientes.telefono = cliente.Telefono;
            clientes.celular = cliente.Celular;
            clientes.fax = cliente.Fax;
            clientes.email = cliente.Email;
            try
            {
                guardo = this.persistencia.GuardarCliente(clientes);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return guardo;
        }

        public ClientesDataSource DevolverCliente(int id)
        {
            ClientesDataSource cliente = new ClientesDataSource();
            cliente item = new cliente();
            try
            {
                item = this.persistencia.DevolverCliente(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            cliente.CodigoCliente = item.idcliente;
            cliente.NitCliente = item.documento;
            cliente.DigitoCliente = item.digito;
            cliente.NombreCliente = item.nombre;
            cliente.IdCiudad = item.idciudad;
            cliente.NombreCiudad = item.ciudad.nombreciudad;
            cliente.Direccion = item.direccion;
            cliente.Telefono = item.telefono;
            cliente.Celular = item.celular;
            cliente.Fax = item.fax;
            cliente.Email = item.email;
            /* cliente.Plazo = item.plazo;
             cliente.CupoMes = item.cupomes;
             cliente.Descuento = item.descuento;
             cliente.Regimen = item.regimen;
             cliente.IdVendedor = item.idvendedor;
             //cliente.NombreVendedor = item.vendedor.nombrevend;
             cliente.NombreVendedor = string.Empty;
             cliente.GranContrib = item.grancontrib;
             cliente.CausaReteIca = item.causareteica;
             cliente.AplicaReteIca = item.aplicareteica;
             cliente.CausaReteIva = item.causreteiva;
             cliente.DescReteIva = item.desconreteiva;
             cliente.ReteXComprar = item.retexcomprar;
             cliente.DesconReteVendedor = item.desconretevender;
             cliente.PorRetencion = item.porretencion;
             cliente.JefeCompras = item.jefecompr;
             cliente.Comprador = item.comprador;
             cliente.Cuenta = item.cuenta;
             cliente.NombreCuenta = item.maeconta.nombre;*/
            return cliente;
        }

        public bool ActualizarCliente(ClientesDataSource cliente)
        {
            bool guardo = false;
            cliente clientes = new cliente();
            clientes.idcliente = cliente.CodigoCliente;
            clientes.documento = cliente.NitCliente;
            clientes.digito = cliente.DigitoCliente;
            clientes.nombre = cliente.NombreCliente;
            clientes.idciudad = cliente.IdCiudad;
            clientes.direccion = cliente.Direccion;
                        clientes.telefono = cliente.Telefono;
            clientes.celular = cliente.Celular;
            clientes.fax = cliente.Fax;
            clientes.email = cliente.Email;

            try
            {
                guardo = this.persistencia.ActualizarCliente(clientes);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return guardo;
        }

        public bool EliminarCliente(int idcli_eliminar)
        {
            bool result = false;
            try
            {
                result = this.persistencia.EliminarCliente(idcli_eliminar);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public List<ClientesDataSource> BuscarCliente(string buscar)
        {
            List<ClientesDataSource> clientes = new List<ClientesDataSource>();
            try
            {
                var items = this.persistencia.BuscarCliente(buscar);
                foreach (var item in items)
                {
                    ClientesDataSource cliente = new ClientesDataSource();
                    cliente.CodigoCliente = item.idcliente;
                    cliente.NitCliente = item.documento;
                    cliente.DigitoCliente = item.digito;
                    cliente.NombreCliente = item.nombre;
                    cliente.IdCiudad = item.idciudad;
                    cliente.NombreCiudad = item.ciudad.nombreciudad;
                    cliente.Direccion = item.direccion;
                    cliente.Telefono = item.telefono;
                    cliente.Celular = item.celular;
                    cliente.Fax = item.fax;
                    cliente.Email = item.email;
                    clientes.Add(cliente);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return clientes;
        }
    }
}
