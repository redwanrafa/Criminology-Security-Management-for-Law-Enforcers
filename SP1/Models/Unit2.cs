using System;
using System.Collections.Generic;

namespace SP1.Models
{
    public partial class Unit2
    {
        public int Unit2Id { get; set; }
        public string Unit2Name { get; set; }
        public Nullable<int> Unit1Id { get; set; }
        public virtual Unit1 Unit1 { get; set; }
    }
}
