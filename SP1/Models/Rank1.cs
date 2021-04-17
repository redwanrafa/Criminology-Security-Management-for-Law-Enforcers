using System;
using System.Collections.Generic;

namespace SP1.Models
{
    public partial class Rank1
    {
        public Rank1()
        {
            this.Rank2 = new List<Rank2>();
        }

        public int Rank1Id { get; set; }
        public string Rank1Name { get; set; }
        public virtual ICollection<Rank2> Rank2 { get; set; }
    }
}
