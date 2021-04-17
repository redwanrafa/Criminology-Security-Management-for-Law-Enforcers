namespace SP1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Notice")]
    public partial class Notice
    {
        public int NoticeId { get; set; }

        [Required]
        [StringLength(200)]
        public string NoticeSubject { get; set; }

        [Column("Notice")]
        [Required]
        public string Notice1 { get; set; }

        public DateTime NoticeDate { get; set; }
    }
}
