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
    public partial class parametro
    {
        public int idparametro { get; set; }
        public string nombreparametro { get; set; }
        public int idmoduloppal { get; set; }
        public string descriparam { get; set; }
        public string valorparam { get; set; }
    
        public virtual moduloppal moduloppal { get; set; }
    }
    
}
