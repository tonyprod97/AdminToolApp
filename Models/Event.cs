using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class Event
    {
        public int EventId { get; set; }
        public DateTime? EventPublishDate { get; set; }
        public string EventTitle { get; set; }
        public string EventText { get; set; }
        public string EventShortText { get; set; }
        public bool? EventPublish { get; set; }
        public byte[] EventMainPicture { get; set; }
        public bool? EventMainPagePublish { get; set; }
        public int? EventParent { get; set; }
    }
}
