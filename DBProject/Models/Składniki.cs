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
    
    public partial class Składniki
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Składniki()
        {
            this.dostarcza = new HashSet<dostarcza>();
            this.potrzebny_do_produkcji = new HashSet<potrzebny_do_produkcji>();
        }
    
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public int Cena { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dostarcza> dostarcza { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<potrzebny_do_produkcji> potrzebny_do_produkcji { get; set; }
    }
}
