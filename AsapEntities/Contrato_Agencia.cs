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
    
    public partial class Contrato_Agencia
    {
        public int id_Contrato_Agencia { get; set; }
        public Nullable<System.DateTime> Fecha_Ini_Contrato { get; set; }
        public Nullable<System.DateTime> Fecha_Fin_Contrato { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
        public Nullable<decimal> Primer_descuento { get; set; }
        public Nullable<int> Tope1 { get; set; }
        public Nullable<decimal> Segundo_descuento { get; set; }
        public Nullable<int> Tope2 { get; set; }
        public Nullable<int> id_Agencia_Viaje { get; set; }
        public Nullable<int> id_Aerolinea { get; set; }
    
        public virtual Aerolinea Aerolinea { get; set; }
        public virtual Agencia_Viaje Agencia_Viaje { get; set; }
    }
}
