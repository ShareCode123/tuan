//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TSP_Covid21.Models.ShopEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class PIC_PRODUCT
    {
        public int PRODUCTID { get; set; }
        public int PICTUREID { get; set; }
        public Nullable<bool> MAINPIC { get; set; }
    
        public virtual PICTURE PICTURE { get; set; }
        public virtual PRODUCT PRODUCT { get; set; }
    }
}