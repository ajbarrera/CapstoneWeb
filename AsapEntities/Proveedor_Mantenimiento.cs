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
    
    public partial class Proveedor_Mantenimiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proveedor_Mantenimiento()
        {
            this.Mantenimiento = new HashSet<Mantenimiento>();
        }
    
        public int Id_prove_mant { get; set; }
        public string Razon_social { get; set; }
        public Nullable<int> Num_Doc { get; set; }
        public string Direcion { get; set; }
        public string Urbanizacion { get; set; }
        public Nullable<int> telefono { get; set; }
        public string Estado { get; set; }
        public string Representante_Legal { get; set; }
        public Nullable<int> id_Tipo_Documento { get; set; }
        public Nullable<int> id_Ubigeo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mantenimiento> Mantenimiento { get; set; }
        public virtual Tipo_Documento Tipo_Documento { get; set; }
        public virtual Ubigeo Ubigeo { get; set; }
    }
}
