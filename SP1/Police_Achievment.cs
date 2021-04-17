namespace SP1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Police_Achievment
    {
        public int Id { get; set; }

        public int PoliceId { get; set; }

        public int AchievmentId { get; set; }

        public virtual Police Police { get; set; }
    }
}
