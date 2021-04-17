namespace SP1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Court")]
    public partial class Court
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourtId { get; set; }

        [Required]
        [StringLength(50)]
        public string CourtName { get; set; }

        [Required]
        [StringLength(50)]
        public string CaseType { get; set; }
    }
}
