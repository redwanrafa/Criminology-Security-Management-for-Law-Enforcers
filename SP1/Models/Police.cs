using System;
using System.Collections.Generic;

namespace SP1.Models
{
    public partial class Police
    {
        public Police()
        {
            this.Cases = new List<Case>();
            this.Cases1 = new List<Case>();
            this.Police_Achievment = new List<Police_Achievment>();
        }

        public int PoliceId { get; set; }
        public string PoliceName { get; set; }
        public string PoliceFathersName { get; set; }
        public string PoliceMothersName { get; set; }
        public string PoliceCurrentAddress { get; set; }
        public string PolicePermanentAddress { get; set; }
        public string PoliceDateOfBirth { get; set; }
        public string PoliceGender { get; set; }
        public string PoliceBirthCertificateId { get; set; }
        public string PoliceNationalId { get; set; }
        public string PolicePassportId { get; set; }
        public string PoliceDrivingLicenseId { get; set; }
        public string PoliceMaterialStatus { get; set; }
        public int PoliceCurrentRank1 { get; set; }
        public int PoliceCurrentRank2 { get; set; }
        public int PoliceCurrentUnit1 { get; set; }
        public Nullable<int> PoliceCurrentUnit2 { get; set; }
        public Nullable<int> PoliceDivision { get; set; }
        public Nullable<int> PoliceDistrict { get; set; }
        public Nullable<int> PoliceBranch { get; set; }
        public string PoliceEmail { get; set; }
        public string PoliceContactNo { get; set; }
        public string PoliceUserName { get; set; }
        public string PolicePassword { get; set; }
        public int PoliceJoiningRank { get; set; }
        public System.DateTime PoliceJoiningDate { get; set; }
        public int PoliceRewardRankId { get; set; }
        public int PoliceXP { get; set; }
        public string PoliceStatus { get; set; }
        public virtual ICollection<Case> Cases { get; set; }
        public virtual ICollection<Case> Cases1 { get; set; }
        public virtual ICollection<Police_Achievment> Police_Achievment { get; set; }
    }
}
