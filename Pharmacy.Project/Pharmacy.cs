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
    
    public partial class Pharmacy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pharmacy()
        {
            this.DrugManufactruers = new HashSet<DrugManufactruer>();
            this.Drugs = new HashSet<Drug>();
            this.Employees = new HashSet<Employee>();
            this.PharmacyPhoneNumbers = new HashSet<PharmacyPhoneNumber>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public Nullable<int> EmpNo { get; set; }
        public Nullable<int> ManagerID { get; set; }
        public Nullable<int> DoctorID { get; set; }
    
        public virtual Doctor Doctor { get; set; }
        public virtual Doctor Doctor1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DrugManufactruer> DrugManufactruers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Drug> Drugs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PharmacyPhoneNumber> PharmacyPhoneNumbers { get; set; }
    }
}