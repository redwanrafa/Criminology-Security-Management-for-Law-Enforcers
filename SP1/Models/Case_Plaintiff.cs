using System;
using System.Collections.Generic;

namespace SP1.Models
{
    public partial class Case_Plaintiff
    {
        public int Id { get; set; }
        public int CaseId { get; set; }
        public int PlaintiffId { get; set; }
        public System.DateTime AddedOn { get; set; }
        public virtual Case Case { get; set; }
        public virtual Plaintiff Plaintiff { get; set; }
    }
}
