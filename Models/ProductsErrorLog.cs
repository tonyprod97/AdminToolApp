using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class ProductsErrorLog
    {
        public int ErrorId { get; set; }
        public string ProductName { get; set; }
        public string Version { get; set; }
        public string ErrorInfo { get; set; }
        public string LicenseKey { get; set; }
        public string UserEmail { get; set; }
        public string UserComment { get; set; }
    }
}
