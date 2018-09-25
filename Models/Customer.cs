using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Licenses = new HashSet<Licenses>();
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int IdCustomer { get; set; }
        public string Email { get; set; }
        public string CustomerName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public int? AddressId { get; set; }
        public string Phone { get; set; }
        public string PhoneExt { get; set; }
        public string CompanyName { get; set; }
        public string Lang { get; set; }

        public Address Address { get; set; }
        public ICollection<Licenses> Licenses { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
