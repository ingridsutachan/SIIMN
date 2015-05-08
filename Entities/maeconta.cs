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
    public partial class maeconta
    {
        public maeconta()
        {
            this.acucentr = new HashSet<acucentr>();
            this.formatosbpyg = new HashSet<formatosbpyg>();
            this.formatosbpyg1 = new HashSet<formatosbpyg>();
            this.maecli = new HashSet<maecli>();
            this.maeconta1 = new HashSet<maeconta>();
            this.maeconta11 = new HashSet<maeconta>();
            this.maeconta12 = new HashSet<maeconta>();
            this.movimi = new HashSet<movimi>();
            this.maepagos = new HashSet<maepagos>();
            this.presupuesto = new HashSet<presupuesto>();
            this.saldoscuentas = new HashSet<saldoscuentas>();
        }
    
        public int idcuenta { get; set; }
        public string cuenta { get; set; }
        public string tipocta { get; set; }
        public string nombre { get; set; }
        public bool pidenit { get; set; }
        public bool centro { get; set; }
        public bool ajustesinteg { get; set; }
        public Nullable<int> idnitajustes { get; set; }
        public Nullable<int> cueaju { get; set; }
        public Nullable<int> cuencorre { get; set; }
        public string ajudoc { get; set; }
        public bool retencion { get; set; }
        public Nullable<decimal> porete { get; set; }
        public string conceprete { get; set; }
        public bool reteica { get; set; }
        public Nullable<decimal> poreteica { get; set; }
        public string concepreteica { get; set; }
        public Nullable<int> cuentacierre { get; set; }
        public Nullable<int> codformatomedios { get; set; }
    
        public virtual ICollection<acucentr> acucentr { get; set; }
        public virtual formatomedios formatomedios { get; set; }
        public virtual ICollection<formatosbpyg> formatosbpyg { get; set; }
        public virtual ICollection<formatosbpyg> formatosbpyg1 { get; set; }
        public virtual ICollection<maecli> maecli { get; set; }
        public virtual ICollection<maeconta> maeconta1 { get; set; }
        public virtual maeconta maeconta2 { get; set; }
        public virtual ICollection<maeconta> maeconta11 { get; set; }
        public virtual maeconta maeconta3 { get; set; }
        public virtual ICollection<maeconta> maeconta12 { get; set; }
        public virtual maeconta maeconta4 { get; set; }
        public virtual ICollection<movimi> movimi { get; set; }
        public virtual ICollection<maepagos> maepagos { get; set; }
        public virtual ICollection<presupuesto> presupuesto { get; set; }
        public virtual ICollection<saldoscuentas> saldoscuentas { get; set; }
        public virtual maenits maenits { get; set; }
    }
    
}
