//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskManagment.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int SeverityId { get; set; }
        public System.DateTime Deadline { get; set; }
        public string Description { get; set; }
    
        public virtual Severity Severity { get; set; }
    }
}