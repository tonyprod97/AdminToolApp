using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class AppExceptions
    {
        public int Idexception { get; set; }
        public string Message { get; set; }
        public string Source { get; set; }
        public string StackTrace { get; set; }
        public string TargetSite { get; set; }
        public DateTime? ExceptionTime { get; set; }
    }
}
