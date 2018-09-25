using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class Version
    {
        public short Version1 { get; set; }
        public short MaxVersion { get; set; }
        public string LatestVersion { get; set; }
    }
}
