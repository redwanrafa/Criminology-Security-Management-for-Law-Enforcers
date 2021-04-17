namespace SP1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Report")]
    public partial class Report
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MonthId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MonthName { get; set; }

        public int? NoOfCaseAdded { get; set; }

        public int? NoOfCaseSolved { get; set; }
    }
}
