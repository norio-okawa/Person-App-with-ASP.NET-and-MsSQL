//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class custom_setting
    {
        public string ID { get; set; }
        public string admin_email { get; set; }
        public string smtp_domain { get; set; }
        public Nullable<int> port { get; set; }
        public string notify_email { get; set; }
        public string theme { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
