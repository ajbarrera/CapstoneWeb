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
    
    public partial class Tipo_Ruta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tipo_Ruta()
        {
            this.Ruta_Aerea = new HashSet<Ruta_Aerea>();
        }
    
        public int id_Tipo_Ruta { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ruta_Aerea> Ruta_Aerea { get; set; }
    }
}
