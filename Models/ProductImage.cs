using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class ProductImage
    {
        public int ProductImageId { get; set; }
        public int? ProductId { get; set; }
        public string ProductImageTitle { get; set; }
        public byte[] ProductImageImage { get; set; }
        public byte[] ProductImageThumbnail { get; set; }
    }
}
