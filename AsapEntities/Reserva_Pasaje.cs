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
    
    public partial class Reserva_Pasaje
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reserva_Pasaje()
        {
            this.Venta_Pasajes = new HashSet<Venta_Pasajes>();
        }
    
        public int id_Reserva_Pasaje { get; set; }
        public Nullable<System.DateTime> Fecha_Reserva { get; set; }
        public string Hora_Reserva { get; set; }
        public Nullable<System.DateTime> Fecha_Fin_Reserva { get; set; }
        public string estado { get; set; }
        public Nullable<int> id_Cliente { get; set; }
        public Nullable<int> id_Progra_Vuelo { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Programacion_vuelo Programacion_vuelo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Pasajes> Venta_Pasajes { get; set; }
    }
}
