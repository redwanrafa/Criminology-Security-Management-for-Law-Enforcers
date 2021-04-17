using System;
using System.Collections.Generic;

namespace SP1.Models
{
    public partial class Court
    {
        public int CourtId { get; set; }
        public string CourtName { get; set; }
        public string CaseType { get; set; }
    }
}
