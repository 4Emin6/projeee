//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace projeee.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Turnuvalar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Turnuvalar()
        {
            this.Maçlar = new HashSet<Maçlar>();
        }
    
        public int turnuvaID { get; set; }
        public string turnuvaAdı { get; set; }
        public Nullable<System.DateTime> başlangıçTarihi { get; set; }
        public Nullable<System.DateTime> bitişTarihi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Maçlar> Maçlar { get; set; }
    }
}
