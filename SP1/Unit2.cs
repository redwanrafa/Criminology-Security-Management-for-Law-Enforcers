namespace SP1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Unit2
    {
        public int Unit2Id { get; set; }

        [StringLength(50)]
        public string Unit2Name { get; set; }

        public int? Unit1Id { get; set; }

        public virtual Unit1 Unit1 { get; set; }
    }
}
