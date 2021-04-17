using System;
using System.Collections.Generic;

namespace SP1.Models
{
    public partial class Division
    {
        public Division()
        {
            this.Districts = new List<District>();
        }

        public int DivisionId { get; set; }
        public string DivisionName { get; set; }
        public virtual ICollection<District> Districts { get; set; }
    }
}
