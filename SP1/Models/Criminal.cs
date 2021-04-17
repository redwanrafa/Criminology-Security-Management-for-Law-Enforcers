using System;
using System.Collections.Generic;

namespace SP1.Models
{
    public partial class Criminal
    {
        public Criminal()
        {
            this.Case_Criminal = new List<Case_Criminal>();
            this.Charge_Criminal_Case = new List<Charge_Criminal_Case>();
        }

        public int CriminalId { get; set; }
        public string CriminalName { get; set; }
        public string CriminalAlternateName { get; set; }
        public string CriminalFathersName { get; set; }
        public string CriminalMothersName { get; set; }
        public string CriminalCurrentAddress { get; set; }
        public string CriminalPermanentAddress { get; set; }
        public string CriminalGender { get; set; }
        public string CriminalDateOfBirth { get; set; }
        public int CriminalDivision { get; set; }
        public int CriminalDistrict { get; set; }
        public int CriminalBranch { get; set; }
        public string CriminalBirthCertificateId { get; set; }
        public string CriminalNationalId { get; set; }
        public string CriminalDrivingLicenseId { get; set; }
        public string CriminalPassportId { get; set; }
        public string CriminalContactNo { get; set; }
        public string CriminalRemarkableMarks { get; set; }
        public string CriminalMaterialStatus { get; set; }
        public string CriminalPartnerName { get; set; }
        public Nullable<int> CriminalNoOfChild { get; set; }
        public System.DateTime CriminalAddedOn { get; set; }
        public string CriminalStatus { get; set; }
        public virtual ICollection<Case_Criminal> Case_Criminal { get; set; }
        public virtual ICollection<Charge_Criminal_Case> Charge_Criminal_Case { get; set; }
    }
}
