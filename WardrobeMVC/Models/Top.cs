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
    
    public partial class Top
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Top()
        {
            this.OutfitIDs = new HashSet<OutfitID>();
        }
    
        public int TopID { get; set; }
        public string TopName { get; set; }
        public string TopPhoto { get; set; }
        public int TopTypeID { get; set; }
        public int TopColorID { get; set; }
        public int TopSeasonID { get; set; }
        public int TopOccasionID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OutfitID> OutfitIDs { get; set; }
        public virtual TopColor TopColor { get; set; }
        public virtual TopOccassion TopOccassion { get; set; }
        public virtual TopSeason TopSeason { get; set; }
        public virtual TopType TopType { get; set; }
    }
}
