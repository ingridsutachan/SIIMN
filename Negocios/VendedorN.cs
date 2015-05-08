// -----------------------------------------------------------------------
// <copyright file="VendedorN.cs" company="">
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

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class VendedorN
    {
        private VendedorD persistencia; 

        public VendedorN()
        {
            this.persistencia = new VendedorD();
        }

        public string DevolverNombre(int id)
        {
            string nombre ;
            try
            {
                nombre = this.persistencia.DevolverNombre(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return nombre;
        }
    }
}
