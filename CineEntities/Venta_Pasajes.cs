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
    
    public partial class Venta_Pasajes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Venta_Pasajes()
        {
            this.Comprobante_Venta = new HashSet<Comprobante_Venta>();
        }
    
        public int id_Venta_Pasajes { get; set; }
        public Nullable<System.DateTime> fecha_venta { get; set; }
        public Nullable<decimal> precio_total { get; set; }
        public string divisa { get; set; }
        public Nullable<int> Cantidad_Pasajes { get; set; }
        public Nullable<int> id_Reserva_Pasaje { get; set; }
        public Nullable<int> id_Cliente { get; set; }
        public Nullable<int> id_Agencia_Viaje { get; set; }
        public Nullable<int> id_Medio_Compra { get; set; }
        public Nullable<int> id_Empleado { get; set; }
        public Nullable<int> id_tipo_pago { get; set; }
        public Nullable<int> Id_asiento { get; set; }
        public Nullable<int> Id_Aerolinea { get; set; }
    
        public virtual Aerolinea Aerolinea { get; set; }
        public virtual Agencia_Viaje Agencia_Viaje { get; set; }
        public virtual Asiento Asiento { get; set; }
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comprobante_Venta> Comprobante_Venta { get; set; }
        public virtual Empleado Empleado { get; set; }
        public virtual Medio_Compra Medio_Compra { get; set; }
        public virtual Reserva_Pasaje Reserva_Pasaje { get; set; }
        public virtual Tipo_Pago Tipo_Pago { get; set; }
    }
}
