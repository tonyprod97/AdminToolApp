using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class Licenses
    {
        public string LicenseKey { get; set; }
        public int IdCustomer { get; set; }
        public int UsedLicenses { get; set; }
        public int? TotalLicenses { get; set; }
        public short Version { get; set; }
        public DateTime? ValidUntil { get; set; }
        public bool? Active { get; set; }
        public int? NumExpired { get; set; }
        public DateTime? CanExtendUntil { get; set; }
        public int UsedLicensesV5 { get; set; }
        public int TotalLicensesV5 { get; set; }

        public Customer IdCustomerNavigation { get; set; }
    }
}
