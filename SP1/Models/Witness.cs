using System;
using System.Collections.Generic;

namespace SP1.Models
{
    public partial class Witness
    {
        public Witness()
        {
            this.Case_Witness = new List<Case_Witness>();
        }

        public int WitnessId { get; set; }
        public string WitnessName { get; set; }
        public string WitnessFathersName { get; set; }
        public string WitnessMothersName { get; set; }
        public string WitnessAddress { get; set; }
        public int WitnessDivision { get; set; }
        public int WitnessDistrict { get; set; }
        public int WitnessBranch { get; set; }
        public virtual ICollection<Case_Witness> Case_Witness { get; set; }
    }
}
