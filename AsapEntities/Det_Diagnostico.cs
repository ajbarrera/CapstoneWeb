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
    
    public partial class Det_Diagnostico
    {
        public int Id_Det_Diagnostico { get; set; }
        public string Criticidad { get; set; }
        public Nullable<System.DateTime> fecha_registro { get; set; }
        public Nullable<System.DateTime> fecha_actualizacion { get; set; }
        public string estado_actividad { get; set; }
        public Nullable<int> Id_mant { get; set; }
        public Nullable<int> id_diag_tecnico { get; set; }
        public Nullable<int> Id_Empleado { get; set; }
    
        public virtual Diagnostico_tecnico Diagnostico_tecnico { get; set; }
        public virtual Empleado Empleado { get; set; }
        public virtual Mantenimiento Mantenimiento { get; set; }
    }
}
