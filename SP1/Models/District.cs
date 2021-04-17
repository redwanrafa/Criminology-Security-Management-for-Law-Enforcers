using System;
using System.Collections.Generic;

namespace SP1.Models
{
    public partial class District
    {
        public District()
        {
            this.Branches = new List<Branch>();
        }

        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
        public int DivisionId { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
        public virtual Division Division { get; set; }
    }
}
