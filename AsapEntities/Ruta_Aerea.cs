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
    
    public partial class Ruta_Aerea
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ruta_Aerea()
        {
            this.Det_Ruta_Aerea = new HashSet<Det_Ruta_Aerea>();
            this.Permiso_Operacion = new HashSet<Permiso_Operacion>();
            this.Programacion_vuelo = new HashSet<Programacion_vuelo>();
        }
    
        public int id_Ruta_Aerea { get; set; }
        public string estado { get; set; }
        public Nullable<int> id_Tipo_Ruta { get; set; }
        public Nullable<int> id_Ubigeo_Origen { get; set; }
        public Nullable<int> id_Ubigeo_Destino { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Det_Ruta_Aerea> Det_Ruta_Aerea { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Permiso_Operacion> Permiso_Operacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Programacion_vuelo> Programacion_vuelo { get; set; }
        public virtual Tipo_Ruta Tipo_Ruta { get; set; }
        public virtual Ubigeo Ubigeo { get; set; }
        public virtual Ubigeo Ubigeo1 { get; set; }
    }
}
