using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class TcoinstallLog
    {
        public int UpgradeId { get; set; }
        public string MachineName { get; set; }
        public string OldVersion { get; set; }
        public string NewVersion { get; set; }
        public string VersionInfo { get; set; }
        public DateTime InstalledOn { get; set; }
        public string LicenseKey { get; set; }
        public string Email { get; set; }
    }
}
