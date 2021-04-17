namespace SP1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Charge")]
    public partial class Charge
    {
        public int ChargeId { get; set; }

        [Required]
        [StringLength(50)]
        public string ChargeName { get; set; }

        public int CategoryId { get; set; }

        public virtual CrimeCategory CrimeCategory { get; set; }
    }
}
