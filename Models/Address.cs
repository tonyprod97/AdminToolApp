using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class Address
    {
        public Address()
        {
            Customer = new HashSet<Customer>();
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int AddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public ICollection<Customer> Customer { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
