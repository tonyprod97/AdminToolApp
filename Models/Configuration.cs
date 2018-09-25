using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class Configuration
    {
        public int ConfigurationId { get; set; }
        public string ConfigurationName { get; set; }
        public string ConfigurationValue { get; set; }
    }
}
