//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_SkiLift.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SkiLiftSchedule
    {
        public int ID { get; set; }
        public int LiftID { get; set; }
        public byte DayOfTheWeek { get; set; }
        public string BeginHour { get; set; }
        public string EndHour { get; set; }
        public System.DateTime BeginDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
    
        public virtual SkiLift SkiLift { get; set; }
    }
}
