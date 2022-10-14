﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PharmacyEntities : DbContext
    {
        public PharmacyEntities()
            : base("name=PharmacyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<DoctorPhoneNumber> DoctorPhoneNumbers { get; set; }
        public virtual DbSet<DrugManufactruer> DrugManufactruers { get; set; }
        public virtual DbSet<DrugManufactruerPhoneNumber> DrugManufactruerPhoneNumbers { get; set; }
        public virtual DbSet<Drug> Drugs { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeePhoneNumber> EmployeePhoneNumbers { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<PatientPhoneNumber> PatientPhoneNumbers { get; set; }
        public virtual DbSet<Pharmacy> Pharmacies { get; set; }
        public virtual DbSet<PharmacyPhoneNumber> PharmacyPhoneNumbers { get; set; }
        public virtual DbSet<Prescribe> Prescribes { get; set; }
        public virtual DbSet<PrescribeDrug> PrescribeDrugs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
