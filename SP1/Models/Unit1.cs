using System;
using System.Collections.Generic;

namespace SP1.Models
{
    public partial class Unit1
    {
        public Unit1()
        {
            this.Unit2 = new List<Unit2>();
        }

        public int Unit1Id { get; set; }
        public string Unit1Name { get; set; }
        public virtual ICollection<Unit2> Unit2 { get; set; }
    }
}
