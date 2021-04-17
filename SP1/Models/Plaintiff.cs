using System;
using System.Collections.Generic;

namespace SP1.Models
{
    public partial class Plaintiff
    {
        public Plaintiff()
        {
            this.Case_Plaintiff = new List<Case_Plaintiff>();
        }

        public int PlaintiffId { get; set; }
        public string PlaintiffName { get; set; }
        public string PlaintiffFathersName { get; set; }
        public string PlaintiffMothersName { get; set; }
        public string PlaintiffAddress { get; set; }
        public int PlaintiffDivision { get; set; }
        public int PlaintiffDistrict { get; set; }
        public int PlaintiffBranch { get; set; }
        public virtual ICollection<Case_Plaintiff> Case_Plaintiff { get; set; }
    }
}
