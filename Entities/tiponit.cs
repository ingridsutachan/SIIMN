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
    public partial class tiponit
    {
        public tiponit()
        {
            this.cliente = new HashSet<cliente>();
            this.maenits = new HashSet<maenits>();
        }
    
        public int idtiponit { get; set; }
        public string codigtiponit { get; set; }
        public string nombretipo { get; set; }
    
        public virtual ICollection<cliente> cliente { get; set; }
        public virtual ICollection<maenits> maenits { get; set; }
    }
    
}