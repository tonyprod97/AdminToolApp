using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public DateTime? ProductPublishDate { get; set; }
        public string ProductTitle { get; set; }
        public string ProductText { get; set; }
        public string ProductShortText { get; set; }
        public bool? ProductPublish { get; set; }
        public byte[] ProductMainPicture { get; set; }
        public int? ProductPrice { get; set; }
        public string ProductType { get; set; }
        public bool? ProductMainPagePublish { get; set; }
        public int? ProductParent { get; set; }
    }
}
