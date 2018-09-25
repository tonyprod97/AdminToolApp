using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class Reseller
    {
        public int IdReseller { get; set; }
        public string Email { get; set; }
        public string ResellerName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public int? AddressId { get; set; }
        public string Phone { get; set; }
        public string PhoneExt { get; set; }
        public string CompanyName { get; set; }
        public string Lang { get; set; }
    }
}
