using System;
using System.Collections.Generic;

namespace SP1.Models
{
    public partial class Charge_Criminal_Case
    {
        public int Id { get; set; }
        public int CaseId { get; set; }
        public int CriminalId { get; set; }
        public int ChargeId { get; set; }
        public System.DateTime ChargeAddedOn { get; set; }
        public virtual Case Case { get; set; }
        public virtual Criminal Criminal { get; set; }
    }
}
