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
    public partial class departamento
    {
        public departamento()
        {
            this.ciudad = new HashSet<ciudad>();
        }
    
        public int iddept { get; set; }
        public int idpais { get; set; }
        public string codigodepto { get; set; }
        public string nombredept { get; set; }
    
        public virtual ICollection<ciudad> ciudad { get; set; }
        public virtual pais pais { get; set; }
    }
    
}