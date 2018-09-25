using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class NewsImage
    {
        public int NewsImageId { get; set; }
        public int? NewsId { get; set; }
        public string NewsImageTitle { get; set; }
        public byte[] NewsImageImage { get; set; }
        public byte[] NewsImageThumbnail { get; set; }
    }
}
