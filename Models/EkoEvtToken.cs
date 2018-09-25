using System;
using System.Collections.Generic;

namespace Admin_Tool.Models
{
    public partial class EkoEvtToken
    {
        public Guid TokenId { get; set; }
        public Guid EventId { get; set; }
        public DateTime TokenTime { get; set; }
        public Guid? PersonId { get; set; }

        public EkoEvtEvent Event { get; set; }
        public EkoEvtPerson Person { get; set; }
    }
}
