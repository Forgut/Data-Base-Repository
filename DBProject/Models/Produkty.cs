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
    
    public partial class Produkty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produkty()
        {
            this.potrzebny_do_produkcji = new HashSet<potrzebny_do_produkcji>();
            this.Zadania = new HashSet<Zadania>();
            this.zawierają = new HashSet<zawierają>();
        }
    
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public int Cena_produkcji { get; set; }
        public int Cena_za_szt_ { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<potrzebny_do_produkcji> potrzebny_do_produkcji { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zadania> Zadania { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zawierają> zawierają { get; set; }
    }
}
