using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class EventImage
    {
        public int EventImageId { get; set; }
        public int? EventId { get; set; }
        public string EventImageTitle { get; set; }
        public byte[] EventImageImage { get; set; }
        public byte[] EventImageThumbnail { get; set; }
    }
}
