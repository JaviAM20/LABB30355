//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab14Set.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cuenta
    {
        public int NUMEROCTA { get; set; }
        public string TIPO { get; set; }
        public Nullable<int> Cedula { get; set; }
    
        public virtual CLIENTE CLIENTE { get; set; }
    }
}
