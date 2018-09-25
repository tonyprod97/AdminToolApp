using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class Products
    {
        public Products()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int ProductId { get; set; }
        public string ProductFamily { get; set; }
        public string ProductName { get; set; }
        public int? LicensedUsers { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
