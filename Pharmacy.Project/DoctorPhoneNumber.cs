//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pharmacy.Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class DoctorPhoneNumber
    {
        public int ID { get; set; }
        public Nullable<int> DoctorID { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
    
        public virtual Doctor Doctor { get; set; }
    }
}
