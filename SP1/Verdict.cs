namespace SP1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Verdict")]
    public partial class Verdict
    {
        public int VerdictId { get; set; }

        [Column("Verdict")]
        [Required]
        public string Verdict1 { get; set; }

        public int CaseId { get; set; }

        public int CourtId { get; set; }

        [Column(TypeName = "date")]
        public DateTime VerdictAddedOn { get; set; }

        public virtual Case Case { get; set; }
    }
}
