namespace SP1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Branch")]
    public partial class Branch
    {
        public int BranchId { get; set; }

        [StringLength(50)]
        public string BranchName { get; set; }

        public int? DistrictId { get; set; }

        public virtual District District { get; set; }
    }
}
