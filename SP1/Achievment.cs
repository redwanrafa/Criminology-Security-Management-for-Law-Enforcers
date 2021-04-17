namespace SP1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Achievment")]
    public partial class Achievment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AchievmentId { get; set; }

        [Required]
        [StringLength(50)]
        public string AchievmentName { get; set; }

        public int AchievmentXP { get; set; }
    }
}
