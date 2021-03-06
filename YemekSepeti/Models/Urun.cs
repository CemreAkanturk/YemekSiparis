//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YemekSepeti.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Urun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Urun()
        {
            this.Siparis = new HashSet<Siparis>();
            this.Urun_Icerik = new HashSet<Urun_Icerik>();
        }
    
        public int Id { get; set; }
        public string Ad { get; set; }
        public int Kalori { get; set; }
        public int Fiyat { get; set; }
        public string Fotograf { get; set; }
        public string Acıklama { get; set; }
        public int RestoranId { get; set; }
        public int StokMiktari { get; set; }
    
        public virtual Restoran Restoran { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Siparis> Siparis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Urun_Icerik> Urun_Icerik { get; set; }
    }
}
