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
    
    public partial class Sancion
    {
        public int Id_sancion { get; set; }
        public string detalle { get; set; }
        public Nullable<int> Id_tip_sancion { get; set; }
        public Nullable<int> Id_Empleado { get; set; }
    
        public virtual Empleado Empleado { get; set; }
        public virtual Tip_Sancion Tip_Sancion { get; set; }
    }
}
