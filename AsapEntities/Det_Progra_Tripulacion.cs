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
    
    public partial class Det_Progra_Tripulacion
    {
        public int Id_Det_Progra_Tripulacion { get; set; }
        public Nullable<int> Cantidad_trip { get; set; }
        public string estado { get; set; }
        public Nullable<System.DateTime> fecha_registro { get; set; }
        public Nullable<System.DateTime> fecha_actualizacion { get; set; }
        public string estado_actividad { get; set; }
        public Nullable<int> Id_prog_vuelo { get; set; }
        public Nullable<int> Id_Empleado { get; set; }
        public Nullable<int> Id_rol_trip { get; set; }
    
        public virtual Empleado Empleado { get; set; }
        public virtual Programacion_vuelo Programacion_vuelo { get; set; }
        public virtual Rol_Tripulacion Rol_Tripulacion { get; set; }
    }
}
