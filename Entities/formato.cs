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
    public partial class formato
    {
        public int idformato { get; set; }
        public int idmoduloppal { get; set; }
        public int codigofor { get; set; }
        public int codigotipo { get; set; }
        public bool activo { get; set; }
        public Nullable<int> fila { get; set; }
        public Nullable<int> columna { get; set; }
        public bool condensa { get; set; }
        public string presentacion { get; set; }
        public string titulo { get; set; }
    
        public virtual moduloppal moduloppal { get; set; }
        public virtual tipoformato tipoformato { get; set; }
    }
    
}
