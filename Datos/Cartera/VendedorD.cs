﻿// -----------------------------------------------------------------------
// <copyright file="VendedorC.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Datos.Cartera
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Entities;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class VendedorD
    {
        public VendedorD()
        {
        }

        public string DevolverNombre(int id)
        {
           string nombre;
            using(siimnEntities bd = new siimnEntities())
            {
                var query = bd.vendedor.Where(ve => ve.idvendedor == id).Count();
                nombre = query>0 ? bd.vendedor.Where(ve => ve.idvendedor == id).First().nombrevendedor : "NoExiste";
            }
            return nombre;
        }
    }
}
