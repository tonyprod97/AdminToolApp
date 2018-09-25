using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class OfflineActivations
    {
        public string LicenseKey { get; set; }
        public DateTime ActivationDate { get; set; }
        public string LicensedTo { get; set; }
        public string RequestedBy { get; set; }
        public string MachineName { get; set; }
        public string TcoVersion { get; set; }
    }
}
