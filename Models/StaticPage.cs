using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class StaticPage
    {
        public int StaticPageId { get; set; }
        public string StaticPagePath { get; set; }
        public string StaticPageTitle { get; set; }
        public string StaticPageText { get; set; }
        public byte[] StaticPagePicture { get; set; }
    }
}
