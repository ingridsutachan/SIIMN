// -----------------------------------------------------------------------
// <copyright file="CajeroN.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Negocios.Cartera
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Datos.Cartera;
    using Entities.Types;
    using Entities;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class CajeroN
    {
        private CajeroD persistencia;

        public CajeroN()
        {
            this.persistencia = new CajeroD();
        }

        public List<CajeroDataSource> CargarCajero()
        {
            List<CajeroDataSource> caje = new List<CajeroDataSource>();
            try
            {
                var items = this.persistencia.CargarDatos();
                foreach (var item in items)
                {
                    CajeroDataSource cajer = new CajeroDataSource();
                    cajer.UsuarioCajero = item.usuariocaje;
                    cajer.NombreCajero = item.nombrecaje;
                    caje.Add(cajer);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return caje;
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

        public bool GuardarCajero(CajeroDataSource cajer)
        {
            bool guardo = false;
            cajero cajer1 = new cajero();
            cajer1.usuariocaje = cajer.UsuarioCajero;
            cajer1.nombrecaje = cajer.NombreCajero;
            cajer1.usuariocaje = cajer.UsuarioCajero;
            cajer1.clave = cajer.ClaveCajero;
            try
            {
                guardo = this.persistencia.GuardarCajero(cajer1);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return guardo;
        }

        public bool ExisteCajero(string user)
        {
            bool existe = true;
            try
            {
                existe = this.persistencia.ExisteCajero(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return existe;
        }
    }
}
