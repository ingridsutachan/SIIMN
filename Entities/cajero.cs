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
    public partial class cajero
    {
        public int idcajero { get; set; }
        public string nombrecaje { get; set; }
        public string usuariocaje { get; set; }
        public string clave { get; set; }
        public int idmodulo { get; set; }
    
        public virtual modulo modulo { get; set; }
    }
    
}
