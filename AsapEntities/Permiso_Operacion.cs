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
    
    public partial class Permiso_Operacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Permiso_Operacion()
        {
            this.Autorizacion_Operar = new HashSet<Autorizacion_Operar>();
        }
    
        public int id_Permiso_Operacion { get; set; }
        public Nullable<System.DateTime> fecha_solicitud_operar { get; set; }
        public Nullable<System.DateTime> fecha_inicio_oper { get; set; }
        public Nullable<System.DateTime> fecha_fin_oper { get; set; }
        public string estado { get; set; }
        public Nullable<int> id_Aerolinea { get; set; }
        public Nullable<int> id_Ruta_Aerea { get; set; }
        public Nullable<int> Id_Empleado { get; set; }
    
        public virtual Aerolinea Aerolinea { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Autorizacion_Operar> Autorizacion_Operar { get; set; }
        public virtual Empleado Empleado { get; set; }
        public virtual Ruta_Aerea Ruta_Aerea { get; set; }
    }
}
