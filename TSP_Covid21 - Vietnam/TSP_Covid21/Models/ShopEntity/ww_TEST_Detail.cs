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
    
    public partial class ww_TEST_Detail
    {
        public string User { get; set; }
        public int SensorId { get; set; }
        public string SensorName { get; set; }
    
        public virtual ww_TEST_Sensor ww_TEST_Sensor { get; set; }
        public virtual ww_TEST_MySensor ww_TEST_MySensor { get; set; }
    }
}