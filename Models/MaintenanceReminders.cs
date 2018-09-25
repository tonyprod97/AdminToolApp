using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class MaintenanceReminders
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string LicenseKey { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public int TotalLicenses { get; set; }
        public DateTime ValidUntil { get; set; }
        public short Version { get; set; }
        public int DaysValid { get; set; }
        public bool ReminderSent { get; set; }
    }
}
