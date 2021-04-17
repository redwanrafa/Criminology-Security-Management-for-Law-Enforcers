using System;
using System.Collections.Generic;

namespace SP1.Models
{
    public partial class Rank2
    {
        public int Rank2Id { get; set; }
        public string Rank2Name { get; set; }
        public int Rank1Id { get; set; }
        public virtual Rank1 Rank1 { get; set; }
        public virtual Salary Salary { get; set; }
    }
}
