using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class Service
    {
        public int ServiceId { get; set; }
        public DateTime? ServicePublishDate { get; set; }
        public string ServiceTitle { get; set; }
        public string ServiceText { get; set; }
        public string ServiceShortText { get; set; }
        public bool? ServicePublish { get; set; }
        public bool? ServiceMainPagePublish { get; set; }
        public int? ServiceParent { get; set; }
    }
}
