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
    
    public partial class Reg_Cambios_Vuelo
    {
        public int id_Cambios_Vuelo { get; set; }
        public Nullable<System.DateTime> Fecha_programacion { get; set; }
        public Nullable<System.DateTime> Fecha_Cambio_Vuelo { get; set; }
        public Nullable<System.DateTime> Fecha_vuelo { get; set; }
        public string hora_vuelo { get; set; }
        public Nullable<System.TimeSpan> tiempo_vuelo { get; set; }
        public string estado_vuelo { get; set; }
        public Nullable<System.DateTime> Fecha_Llegada_vuelo { get; set; }
        public string hora_llegada { get; set; }
        public Nullable<decimal> Precio_base { get; set; }
        public Nullable<int> id_det_ruta_aerea { get; set; }
        public Nullable<int> id_Progra_Vuelo { get; set; }
        public Nullable<int> id_Avion { get; set; }
        public Nullable<int> id_Empleado { get; set; }
    
        public virtual Avion Avion { get; set; }
        public virtual Det_Ruta_Aerea Det_Ruta_Aerea { get; set; }
        public virtual Empleado Empleado { get; set; }
        public virtual Programacion_vuelo Programacion_vuelo { get; set; }
    }
}
