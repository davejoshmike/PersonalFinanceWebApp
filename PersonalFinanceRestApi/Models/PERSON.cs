//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonalFinanceRestApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PERSON
    {
        public decimal ID { get; set; }
        public string FIRSTNAME { get; set; }
        public string LASTNAME { get; set; }
        public string CITY { get; set; }
        public string FILINGTYPE { get; set; }
    
        public virtual LOAN LOAN { get; set; }
        public virtual STATE STATE { get; set; }
        public virtual TAX TAX { get; set; }
        public virtual WAGE WAGE { get; set; }
        public virtual SAVINGS SAVINGS { get; set; }
    }
}