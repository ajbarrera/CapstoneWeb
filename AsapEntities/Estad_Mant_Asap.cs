//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AsapEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Estad_Mant_Asap
    {
        public int Id_Estad_Mant_Asap { get; set; }
        public string Tipo_resultado { get; set; }
        public Nullable<System.DateTime> Fecha_Mant { get; set; }
        public string Estado { get; set; }
        public Nullable<int> Id_mant_intern { get; set; }
        public Nullable<int> Id_Aerolinea { get; set; }
    
        public virtual Aerolinea Aerolinea { get; set; }
        public virtual Mantenimiento Mantenimiento { get; set; }
    }
}
