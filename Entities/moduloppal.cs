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
    public partial class moduloppal
    {
        public moduloppal()
        {
            this.formato = new HashSet<formato>();
            this.maetrac = new HashSet<maetrac>();
            this.modulo = new HashSet<modulo>();
            this.movimi = new HashSet<movimi>();
            this.parametro = new HashSet<parametro>();
        }
    
        public int idmodulo { get; set; }
        public string codigmoduloppal { get; set; }
        public string nombremodppal { get; set; }
    
        public virtual ICollection<formato> formato { get; set; }
        public virtual ICollection<maetrac> maetrac { get; set; }
        public virtual ICollection<modulo> modulo { get; set; }
        public virtual ICollection<movimi> movimi { get; set; }
        public virtual ICollection<parametro> parametro { get; set; }
    }
    
}
