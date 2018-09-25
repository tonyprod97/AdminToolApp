using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class TrialCodes
    {
        public string Code { get; set; }
        public string Email { get; set; }
        public short Activated { get; set; }
    }
}
