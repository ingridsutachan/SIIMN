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
    public partial class comprobante
    {
        public comprobante()
        {
            this.movimi = new HashSet<movimi>();
            this.maetrac = new HashSet<maetrac>();
        }
    
        public int codigcomprob { get; set; }
        public string descripcomprob { get; set; }
        public bool consecutivo { get; set; }
        public Nullable<int> numsiguiente { get; set; }
        public string codigootra { get; set; }
    
        public virtual ICollection<movimi> movimi { get; set; }
        public virtual ICollection<maetrac> maetrac { get; set; }
    }
    
}
