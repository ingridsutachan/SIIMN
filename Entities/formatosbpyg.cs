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
    public partial class formatosbpyg
    {
        public int idformato { get; set; }
        public string tipoformato { get; set; }
        public string clasemayor { get; set; }
        public string linea { get; set; }
        public string nombref { get; set; }
        public Nullable<int> cuentaini { get; set; }
        public Nullable<int> cuentafin { get; set; }
    
        public virtual maeconta maeconta { get; set; }
        public virtual maeconta maeconta1 { get; set; }
    }
    
}
