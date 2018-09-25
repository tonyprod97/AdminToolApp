using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class Resellers
    {
        public int Idreseller { get; set; }
        public int? CountryId { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ContactPerson { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string ResellerData { get; set; }
    }
}
