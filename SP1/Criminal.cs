namespace SP1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Criminal")]
    public partial class Criminal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Criminal()
        {
            Case_Criminal = new HashSet<Case_Criminal>();
            Charge_Criminal_Case = new HashSet<Charge_Criminal_Case>();
        }

        public int CriminalId { get; set; }

        [Required]
        [StringLength(50)]
        public string CriminalName { get; set; }

        [StringLength(50)]
        public string CriminalAlternateName { get; set; }

        [Required]
        [StringLength(50)]
        public string CriminalFathersName { get; set; }

        [Required]
        [StringLength(50)]
        public string CriminalMothersName { get; set; }

        [Required]
        [StringLength(50)]
        public string CriminalCurrentAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string CriminalPermanentAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string CriminalGender { get; set; }

        [Required]
        [StringLength(50)]
        public string CriminalDateOfBirth { get; set; }

        public int CriminalDivision { get; set; }

        public int CriminalDistrict { get; set; }

        public int CriminalBranch { get; set; }

        [Required]
        [StringLength(50)]
        public string CriminalBirthCertificateId { get; set; }

        [Required]
        [StringLength(50)]
        public string CriminalNationalId { get; set; }

        [StringLength(50)]
        public string CriminalDrivingLicenseId { get; set; }

        [StringLength(50)]
        public string CriminalPassportId { get; set; }

        [Required]
        [StringLength(50)]
        public string CriminalContactNo { get; set; }

        [StringLength(500)]
        public string CriminalRemarkableMarks { get; set; }

        [Required]
        [StringLength(50)]
        public string CriminalMaterialStatus { get; set; }

        [StringLength(50)]
        public string CriminalPartnerName { get; set; }

        public int? CriminalNoOfChild { get; set; }

        [Column(TypeName = "date")]
        public DateTime CriminalAddedOn { get; set; }

        [Required]
        [StringLength(50)]
        public string CriminalStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Case_Criminal> Case_Criminal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Charge_Criminal_Case> Charge_Criminal_Case { get; set; }
    }
}
