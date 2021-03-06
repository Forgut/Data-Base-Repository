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
    using System.Web.Mvc;
    using System.Linq;

    public partial class Zadania
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zadania()
        {
            this.Wykonują = new HashSet<Wykonują>();
        }

        public IEnumerable<SelectListItem> ProduktyDoWykonania
        {
            get
            {
                DatabaseEntities db = new DatabaseEntities();
                var help = (from p in db.Produkty
                            select p).ToList();
                var list = new List<SelectListItem>();
                foreach (var p in help)
                {
                    list.Add(new SelectListItem()
                    {
                        Value = p.Id.ToString(),
                        Text = p.Nazwa
                    });
                }
                return list;
            }
        }

        public int Id { get; set; }
        public string Nazwa { get; set; }
        public int Czas_wykonania { get; set; }
        public int Faktyczny_czas_wykonania { get; set; }
        public int Produkowany_produkt { get; set; }
        public bool Zakończone { get; set; }
        public int Wykonanych_sztuk_produktu { get; set; }

        public virtual Produkty Produkty { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wykonują> Wykonują { get; set; }
    }
}
