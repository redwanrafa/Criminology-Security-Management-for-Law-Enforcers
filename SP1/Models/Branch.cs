using System;
using System.Collections.Generic;

namespace SP1.Models
{
    public partial class Branch
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public Nullable<int> DistrictId { get; set; }
        public virtual District District { get; set; }
    }
}
