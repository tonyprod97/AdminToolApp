using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class ErrorLog
    {
        public int LogId { get; set; }
        public DateTime LogDate { get; set; }
        public string InputData { get; set; }
        public string Error { get; set; }
    }
}
