using System;
using System.Collections.Generic;

namespace SP1.Models
{
    public partial class Police_Achievment
    {
        public int Id { get; set; }
        public int PoliceId { get; set; }
        public int AchievmentId { get; set; }
        public virtual Police Police { get; set; }
    }
}
