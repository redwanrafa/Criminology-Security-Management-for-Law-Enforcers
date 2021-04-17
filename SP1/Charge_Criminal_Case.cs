namespace SP1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Charge_Criminal_Case
    {
        public int Id { get; set; }

        public int CaseId { get; set; }

        public int CriminalId { get; set; }

        public int ChargeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime ChargeAddedOn { get; set; }

        public virtual Case Case { get; set; }

        public virtual Criminal Criminal { get; set; }
    }
}
