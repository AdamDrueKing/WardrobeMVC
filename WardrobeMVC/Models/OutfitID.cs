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
    
    public partial class OutfitID
    {
        public int OutfitID1 { get; set; }
        public string OutfitName { get; set; }
        public Nullable<int> TopID { get; set; }
        public Nullable<int> SecondLayerTopID { get; set; }
        public Nullable<int> OuterwearID { get; set; }
        public Nullable<int> BottomID { get; set; }
        public Nullable<int> ShoesID { get; set; }
        public Nullable<int> AccessoryID { get; set; }
        public Nullable<int> Accessory2ID { get; set; }
        public Nullable<int> Accessory3ID { get; set; }
        public Nullable<int> Accessory4ID { get; set; }
        public Nullable<int> Accessory5ID { get; set; }
    
        public virtual Accessory Accessory { get; set; }
        public virtual Accessories2 Accessories2 { get; set; }
        public virtual Accessories3 Accessories3 { get; set; }
        public virtual Accessories4 Accessories4 { get; set; }
        public virtual Accessories5 Accessories5 { get; set; }
        public virtual Bottom Bottom { get; set; }
        public virtual Outerwear Outerwear { get; set; }
        public virtual SecondLayerTop SecondLayerTop { get; set; }
        public virtual Sho Sho { get; set; }
        public virtual Top Top { get; set; }
    }
}
