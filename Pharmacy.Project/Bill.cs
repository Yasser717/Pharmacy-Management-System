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
    
    public partial class Bill
    {
        public int BillID { get; set; }
        public string DrugName { get; set; }
        public int NumberOfUnits { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public string PharmacistName { get; set; }
        public string CustomerName { get; set; }
        public string SellingDate { get; set; }
    }
}
