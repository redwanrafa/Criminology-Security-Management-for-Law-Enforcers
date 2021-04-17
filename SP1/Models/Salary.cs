using System;
using System.Collections.Generic;

namespace SP1.Models
{
    public partial class Salary
    {
        public int Rank2Id { get; set; }
        public int Salary1 { get; set; }
        public virtual Rank2 Rank2 { get; set; }
    }
}
