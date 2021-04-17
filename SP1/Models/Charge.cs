using System;
using System.Collections.Generic;

namespace SP1.Models
{
    public partial class Charge
    {
        public int ChargeId { get; set; }
        public string ChargeName { get; set; }
        public int CategoryId { get; set; }
        public virtual CrimeCategory CrimeCategory { get; set; }
    }
}
