//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class ciudad
    {
        public ciudad()
        {
            this.cliente = new HashSet<cliente>();
            this.maenits = new HashSet<maenits>();
            this.sucursal = new HashSet<sucursal>();
        }
    
        public int idciudad { get; set; }
        public int codigodepto { get; set; }
        public string codigociudad { get; set; }
        public string nombreciudad { get; set; }
    
        public virtual ICollection<cliente> cliente { get; set; }
        public virtual ICollection<maenits> maenits { get; set; }
        public virtual ICollection<sucursal> sucursal { get; set; }
        public virtual departamento departamento { get; set; }
    }
    
}
