using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class News
    {
        public int NewsId { get; set; }
        public DateTime? NewsPublishDate { get; set; }
        public string NewsTitle { get; set; }
        public string NewsText { get; set; }
        public string NewsShortText { get; set; }
        public bool? NewsPublish { get; set; }
        public bool? NewsMainPagePublish { get; set; }
        public int? NewsParent { get; set; }
    }
}
