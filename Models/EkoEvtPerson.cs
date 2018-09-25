using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class EkoEvtPerson
    {
        public EkoEvtPerson()
        {
            EkoEvtToken = new HashSet<EkoEvtToken>();
        }

        public Guid Guid { get; set; }
        public Guid? PerCmpId { get; set; }
        public Guid? PerEvtId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Oib { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Postal { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int OfferNumber { get; set; }
        public string Phone1 { get; set; }
        public string Comment { get; set; }
        public string TshirtSize { get; set; }

        public EkoEvtCompany PerCmp { get; set; }
        public EkoEvtEvent PerEvt { get; set; }
        public ICollection<EkoEvtToken> EkoEvtToken { get; set; }
    }
}
