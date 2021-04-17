namespace SP1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Case_Witness
    {
        public int Id { get; set; }

        public int CaseId { get; set; }

        public int WitnessId { get; set; }

        [Column(TypeName = "date")]
        public DateTime AddedOn { get; set; }

        public virtual Case Case { get; set; }

        public virtual Witness Witness { get; set; }
    }
}
