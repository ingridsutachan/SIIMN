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
    public partial class cliente
    {
        public cliente()
        {
            this.maecli = new HashSet<maecli>();
        }
    
        public int idcliente { get; set; }
        public int idtipodto { get; set; }
        public string documento { get; set; }
        public string digito { get; set; }
        public string nombre { get; set; }
        public int idciudad { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
    
        public virtual ciudad ciudad { get; set; }
        public virtual ICollection<maecli> maecli { get; set; }
        public virtual tiponit tiponit { get; set; }
    }
    
}
