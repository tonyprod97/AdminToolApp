using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class StaticPageImage
    {
        public int StaticPageImageId { get; set; }
        public int? StaticPageId { get; set; }
        public string StaticPageImageTitle { get; set; }
        public byte[] StaticPageImageImage { get; set; }
        public byte[] StaticPageImageThumbnail { get; set; }
    }
}
