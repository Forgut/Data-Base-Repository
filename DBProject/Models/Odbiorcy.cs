//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Odbiorcy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Odbiorcy()
        {
            this.Zamówienia = new HashSet<Zamówienia>();
        }
    
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string Adres { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zamówienia> Zamówienia { get; set; }
    }
}
