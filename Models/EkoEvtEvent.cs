using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class EkoEvtEvent
    {
        public EkoEvtEvent()
        {
            EkoEvtPerson = new HashSet<EkoEvtPerson>();
            EkoEvtToken = new HashSet<EkoEvtToken>();
        }

        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<EkoEvtPerson> EkoEvtPerson { get; set; }
        public ICollection<EkoEvtToken> EkoEvtToken { get; set; }
    }
}
