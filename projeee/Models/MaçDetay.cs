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
    
    public partial class MaçDetay
    {
        public int maçDetayID { get; set; }
        public Nullable<int> maçID { get; set; }
        public Nullable<int> oyuncuID { get; set; }
        public string skor { get; set; }
        public Nullable<int> kda { get; set; }
    
        public virtual Maçlar Maçlar { get; set; }
    }
}
