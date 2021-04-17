using System;
using System.Collections.Generic;

namespace SP1.Models
{
    public partial class CrimeCategory
    {
        public CrimeCategory()
        {
            this.Charges = new List<Charge>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Charge> Charges { get; set; }
    }
}
