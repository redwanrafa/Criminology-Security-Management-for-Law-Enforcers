namespace SP1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Police
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Police()
        {
            Cases = new HashSet<Case>();
            Cases1 = new HashSet<Case>();
            Police_Achievment = new HashSet<Police_Achievment>();
        }

        public int PoliceId { get; set; }

        [Required]
        [StringLength(50)]
        public string PoliceName { get; set; }

        [Required]
        [StringLength(50)]
        public string PoliceFathersName { get; set; }

        [Required]
        [StringLength(50)]
        public string PoliceMothersName { get; set; }

        [Required]
        [StringLength(50)]
        public string PoliceCurrentAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string PolicePermanentAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string PoliceDateOfBirth { get; set; }

        [Required]
        [StringLength(50)]
        public string PoliceGender { get; set; }

        [Required]
        [StringLength(50)]
        public string PoliceBirthCertificateId { get; set; }

        [Required]
        [StringLength(50)]
        public string PoliceNationalId { get; set; }

        [Required]
        [StringLength(50)]
        public string PolicePassportId { get; set; }

        [Required]
        [StringLength(50)]
        public string PoliceDrivingLicenseId { get; set; }

        [Required]
        [StringLength(50)]
        public string PoliceMaterialStatus { get; set; }

        public int PoliceCurrentRank1 { get; set; }

        public int PoliceCurrentRank2 { get; set; }

        public int PoliceCurrentUnit1 { get; set; }

        public int? PoliceCurrentUnit2 { get; set; }

        public int? PoliceDivision { get; set; }

        public int? PoliceDistrict { get; set; }

        public int? PoliceBranch { get; set; }

        [StringLength(50)]
        public string PoliceEmail { get; set; }

        [Required]
        [StringLength(50)]
        public string PoliceContactNo { get; set; }

        [Required]
        [StringLength(50)]
        public string PoliceUserName { get; set; }

        [Required]
        [StringLength(50)]
        public string PolicePassword { get; set; }

        public int PoliceJoiningRank { get; set; }

        [Column(TypeName = "date")]
        public DateTime PoliceJoiningDate { get; set; }

        public int PoliceRewardRankId { get; set; }

        public int PoliceXP { get; set; }

        [Required]
        [StringLength(50)]
        public string PoliceStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Case> Cases { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Case> Cases1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Police_Achievment> Police_Achievment { get; set; }
    }
}
