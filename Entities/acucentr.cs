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
    public partial class acucentr
    {
        public int idacucentr { get; set; }
        public int idsucursal { get; set; }
        public string anio { get; set; }
        public int mes { get; set; }
        public Nullable<int> idcentro { get; set; }
        public Nullable<int> idnit { get; set; }
        public int idcuenta { get; set; }
        public decimal saldomes { get; set; }
        public decimal debimes { get; set; }
        public decimal credimes { get; set; }
    
        public virtual centrocostos centrocostos { get; set; }
        public virtual sucursal sucursal { get; set; }
        public virtual maeconta maeconta { get; set; }
        public virtual maenits maenits { get; set; }
    }
    
}
