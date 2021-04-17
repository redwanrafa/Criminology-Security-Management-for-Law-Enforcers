using System;
using System.Collections.Generic;

namespace SP1.Models
{
    public partial class Case_Witness
    {
        public int Id { get; set; }
        public int CaseId { get; set; }
        public int WitnessId { get; set; }
        public System.DateTime AddedOn { get; set; }
        public virtual Case Case { get; set; }
        public virtual Witness Witness { get; set; }
    }
}
