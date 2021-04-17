namespace SP1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Salary")]
    public partial class Salary
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Rank2Id { get; set; }

        [Column("Salary")]
        public int Salary1 { get; set; }

        public virtual Rank2 Rank2 { get; set; }
    }
}
