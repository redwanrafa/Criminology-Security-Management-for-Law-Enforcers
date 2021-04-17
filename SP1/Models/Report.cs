using System;
using System.Collections.Generic;

namespace SP1.Models
{
    public partial class Report
    {
        public int MonthId { get; set; }
        public string MonthName { get; set; }
        public Nullable<int> NoOfCaseAdded { get; set; }
        public Nullable<int> NoOfCaseSolved { get; set; }
    }
}
