//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Magenic.BadgeApplication.DataAccess.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class ActivityEntryType
    {
        public ActivityEntryType()
        {
            this.Activities = new HashSet<Activity>();
        }
    
        public int ActivityEntryTypeId { get; set; }
        public string EntryTypeName { get; set; }
    
        public virtual ICollection<Activity> Activities { get; set; }
    }
}
