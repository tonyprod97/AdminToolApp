using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public string UserFullName { get; set; }
        public bool? UserSuperuser { get; set; }
        public string UserEmail { get; set; }
        public string UserTelephone { get; set; }
    }
}
