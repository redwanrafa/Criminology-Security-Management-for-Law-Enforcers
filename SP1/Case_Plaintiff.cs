namespace SP1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Case_Plaintiff
    {
        public int Id { get; set; }

        public int CaseId { get; set; }

        public int PlaintiffId { get; set; }

        [Column(TypeName = "date")]
        public DateTime AddedOn { get; set; }

        public virtual Case Case { get; set; }

        public virtual Plaintiff Plaintiff { get; set; }
    }
}
