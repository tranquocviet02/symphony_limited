//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace symphony_limited.Areas.Backend.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int StudentId { get; set; }
        public string NameStudent { get; set; }
        public Nullable<System.DateTime> BirthDay { get; set; }
        public Nullable<bool> Genre { get; set; }
        public string Email { get; set; }
        public Nullable<int> PhoneNumber { get; set; }
        public string CourseId { get; set; }
    }
}
