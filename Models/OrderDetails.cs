using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class OrderDetails
    {
        public int OrderNr { get; set; }
        public int IdCustomer { get; set; }
        public int IdReseller { get; set; }
        public int ProductId { get; set; }
        public string LicenseKey { get; set; }
        public string InvoiceId { get; set; }
        public int? AddressId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal? Price { get; set; }
        public string Currency { get; set; }
        public int? LicensesPurchased { get; set; }
        public bool? CanActivate { get; set; }
        public string Notification { get; set; }
        public short? Version { get; set; }

        public Address Address { get; set; }
        public Customer IdCustomerNavigation { get; set; }
        public Products Product { get; set; }
    }
}
