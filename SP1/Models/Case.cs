using System;
using System.Collections.Generic;

namespace SP1.Models
{
    public partial class Case
    {
        public Case()
        {
            this.Case_Criminal = new List<Case_Criminal>();
            this.Case_Plaintiff = new List<Case_Plaintiff>();
            this.Case_Witness = new List<Case_Witness>();
            this.Charge_Criminal_Case = new List<Charge_Criminal_Case>();
            this.Verdicts = new List<Verdict>();
        }

        public int CaseId { get; set; }
        public string CaseType { get; set; }
        public string CaseDefendents { get; set; }
        public Nullable<int> CrimeCategoryId { get; set; }
        public string CaseDetails { get; set; }
        public int CaseDivisionId { get; set; }
        public int CaseDistrictId { get; set; }
        public int CaseBranchId { get; set; }
        public string CaseInventory { get; set; }
        public int CaseInvestigationOfficerId { get; set; }
        public Nullable<int> CasePlaintiffedOfficerId { get; set; }
        public string CaseStatus { get; set; }
        public string CaseInvestigationReport { get; set; }
        public System.DateTime CaseAddedOn { get; set; }
        public Nullable<System.DateTime> CaseInvestigationReportOn { get; set; }
        public int CaseCurrentCourtId { get; set; }
        public Nullable<System.DateTime> CaseInvOfficerOn { get; set; }
        public virtual ICollection<Case_Criminal> Case_Criminal { get; set; }
        public virtual ICollection<Case_Plaintiff> Case_Plaintiff { get; set; }
        public virtual Police Police { get; set; }
        public virtual Police Police1 { get; set; }
        public virtual ICollection<Case_Witness> Case_Witness { get; set; }
        public virtual ICollection<Charge_Criminal_Case> Charge_Criminal_Case { get; set; }
        public virtual ICollection<Verdict> Verdicts { get; set; }
    }
}
