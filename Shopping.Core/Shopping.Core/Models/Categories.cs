//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shopping.Core.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Categories
    {
        public long Id { get; set; }
        public Nullable<long> Pid { get; set; }
        public string Name { get; set; }
        public bool HasChild { get; set; }
        public Nullable<bool> Expanded { get; set; }
    }
}