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
    
    public partial class Ubigeo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ubigeo()
        {
            this.Agencia_Viaje = new HashSet<Agencia_Viaje>();
            this.Cliente = new HashSet<Cliente>();
            this.Det_Ruta_Aerea = new HashSet<Det_Ruta_Aerea>();
            this.Det_Ruta_Aerea1 = new HashSet<Det_Ruta_Aerea>();
            this.Empleado = new HashSet<Empleado>();
            this.Proveedor_Alq_Avion = new HashSet<Proveedor_Alq_Avion>();
            this.Proveedor_Mantenimiento = new HashSet<Proveedor_Mantenimiento>();
            this.Ruta_Aerea = new HashSet<Ruta_Aerea>();
            this.Ruta_Aerea1 = new HashSet<Ruta_Aerea>();
        }
    
        public int id_Ubigeo { get; set; }
        public string pais { get; set; }
        public string region { get; set; }
        public string provincia { get; set; }
        public string distrito { get; set; }
        public string ciudad { get; set; }
        public string aeropuerto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Agencia_Viaje> Agencia_Viaje { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente> Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Det_Ruta_Aerea> Det_Ruta_Aerea { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Det_Ruta_Aerea> Det_Ruta_Aerea1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empleado> Empleado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proveedor_Alq_Avion> Proveedor_Alq_Avion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proveedor_Mantenimiento> Proveedor_Mantenimiento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ruta_Aerea> Ruta_Aerea { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ruta_Aerea> Ruta_Aerea1 { get; set; }
    }
}
