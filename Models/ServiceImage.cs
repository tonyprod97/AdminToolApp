using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class ServiceImage
    {
        public int ServiceImageId { get; set; }
        public int? ServiceId { get; set; }
        public string ServiceImageTitle { get; set; }
        public byte[] ServiceImageImage { get; set; }
        public byte[] ServiceImageThumbnail { get; set; }
    }
}
