namespace SP1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RewardRank")]
    public partial class RewardRank
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RewardRankId { get; set; }

        [Required]
        [StringLength(50)]
        public string RewardRankName { get; set; }

        public int RewardRankXP { get; set; }
    }
}
