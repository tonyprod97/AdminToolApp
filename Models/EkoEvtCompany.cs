using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class EkoEvtCompany
    {
        public EkoEvtCompany()
        {
            EkoEvtPerson = new HashSet<EkoEvtPerson>();
        }

        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Mb { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Postal { get; set; }
        public string Country { get; set; }

        public ICollection<EkoEvtPerson> EkoEvtPerson { get; set; }
    }
}
