//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinFormLayihe.ModelsApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rents
    {
        public int Id { get; set; }
        public Nullable<int> CarId { get; set; }
        public Nullable<int> ClientId { get; set; }
        public Nullable<System.DateTime> SellDate { get; set; }
        public Nullable<System.DateTime> PromiseDate { get; set; }
        public Nullable<System.DateTime> ReceiveDate { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> PenaltyPrice { get; set; }
        public Nullable<int> AdminId { get; set; }
        public Nullable<int> ReceiveAdminID { get; set; }
    
        public virtual Admins Admins { get; set; }
        public virtual Cars Cars { get; set; }
        public virtual Clients Clients { get; set; }
        public virtual Admins Admins1 { get; set; }
    }
}
