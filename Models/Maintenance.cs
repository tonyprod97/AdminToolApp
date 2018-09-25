using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class Maintenance
    {
        public int OrderNr { get; set; }
        public int IdCustomer { get; set; }
        public int ProductId { get; set; }
        public string Email { get; set; }
        public string LicenseKey { get; set; }
        public string InvoiceId { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public decimal? Price { get; set; }
        public string Currency { get; set; }
        public int? LicensesExtended { get; set; }
        public short Version { get; set; }
    }
}
