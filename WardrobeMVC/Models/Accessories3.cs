//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WardrobeMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Accessories3
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Accessories3()
        {
            this.OutfitIDs = new HashSet<OutfitID>();
        }
    
        public int Accessory3ID { get; set; }
        public string Accessory3Name { get; set; }
        public string Accessory3Photo { get; set; }
        public Nullable<int> Accessory3TypeID { get; set; }
        public Nullable<int> Accessory3ColorID { get; set; }
        public Nullable<int> Accessory3SeasonID { get; set; }
        public Nullable<int> Accessory3OccassionID { get; set; }
    
        public virtual Accessory3Types Accessory3Types { get; set; }
        public virtual Accessory3Colors Accessory3Colors { get; set; }
        public virtual Accessory3Occassions Accessory3Occassions { get; set; }
        public virtual Accessory3Seasons Accessory3Seasons { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OutfitID> OutfitIDs { get; set; }
    }
}