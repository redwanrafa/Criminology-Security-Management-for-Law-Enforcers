using System;
using System.Collections.Generic;

namespace SP1.Models
{
    public partial class Verdict
    {
        public int VerdictId { get; set; }
        public string Verdict1 { get; set; }
        public int CaseId { get; set; }
        public int CourtId { get; set; }
        public System.DateTime VerdictAddedOn { get; set; }
        public virtual Case Case { get; set; }
    }
}
