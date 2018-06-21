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
    
    public partial class Det_Ruta_Aerea
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Det_Ruta_Aerea()
        {
            this.Programacion_vuelo = new HashSet<Programacion_vuelo>();
            this.Reg_Cambios_Vuelo = new HashSet<Reg_Cambios_Vuelo>();
        }
    
        public int id_det_ruta_aerea { get; set; }
        public Nullable<int> kilometraje_Recorrido { get; set; }
        public Nullable<int> klometraje_Escala { get; set; }
        public string estado { get; set; }
        public Nullable<System.DateTime> fecha_registro { get; set; }
        public Nullable<System.DateTime> fecha_actualizacion { get; set; }
        public string estado_actividad { get; set; }
        public Nullable<System.TimeSpan> tiempo_vuelo { get; set; }
        public Nullable<int> id_Empleado { get; set; }
        public Nullable<int> id_Ubigeo_Origen { get; set; }
        public Nullable<int> id_Ubigeo_Destino { get; set; }
        public Nullable<int> id_Ruta_Aerea { get; set; }
    
        public virtual Empleado Empleado { get; set; }
        public virtual Ruta_Aerea Ruta_Aerea { get; set; }
        public virtual Ubigeo Ubigeo { get; set; }
        public virtual Ubigeo Ubigeo1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Programacion_vuelo> Programacion_vuelo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reg_Cambios_Vuelo> Reg_Cambios_Vuelo { get; set; }
    }
}