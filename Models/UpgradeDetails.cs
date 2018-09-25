using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class UpgradeDetails
    {
        public int OrderNr { get; set; }
        public int IdCustomer { get; set; }
        public int ProductId { get; set; }
        public string UpgradeEmail { get; set; }
        public string LicenseKey { get; set; }
        public string InvoiceId { get; set; }
        public DateTime UpgradeDate { get; set; }
        public decimal? Price { get; set; }
        public string Currency { get; set; }
        public int? LicensesUpgraded { get; set; }
        public short Version { get; set; }
    }
}
