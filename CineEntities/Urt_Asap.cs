//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CineEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Urt_Asap
    {
        public int Id_Urt_Asap { get; set; }
        public string Tipo_resultado { get; set; }
        public Nullable<System.DateTime> Fecha_resolucion { get; set; }
        public string Estado { get; set; }
        public Nullable<int> Id_avion { get; set; }
    
        public virtual Avion Avion { get; set; }
    }
}
