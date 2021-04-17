namespace SP1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Rank2
    {
        public int Rank2Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Rank2Name { get; set; }

        public int Rank1Id { get; set; }

        public virtual Rank1 Rank1 { get; set; }

        public virtual Salary Salary { get; set; }
    }
}
