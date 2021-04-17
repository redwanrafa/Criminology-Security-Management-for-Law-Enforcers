namespace SP1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Case")]
    public partial class Case
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Case()
        {
            Case_Criminal = new HashSet<Case_Criminal>();
            Case_Plaintiff = new HashSet<Case_Plaintiff>();
            Case_Witness = new HashSet<Case_Witness>();
            Charge_Criminal_Case = new HashSet<Charge_Criminal_Case>();
            Verdicts = new HashSet<Verdict>();
        }

        public int CaseId { get; set; }

        [Required]
        [StringLength(50)]
        public string CaseType { get; set; }

        public string CaseDefendents { get; set; }

        public int? CrimeCategoryId { get; set; }

        [Required]
        public string CaseDetails { get; set; }

        public int CaseDivisionId { get; set; }

        public int CaseDistrictId { get; set; }

        public int CaseBranchId { get; set; }

        [Required]
        public string CaseInventory { get; set; }

        public int CaseInvestigationOfficerId { get; set; }

        public int? CasePlaintiffedOfficerId { get; set; }

        [Required]
        [StringLength(50)]
        public string CaseStatus { get; set; }

        public string CaseInvestigationReport { get; set; }

        [Column(TypeName = "date")]
        public DateTime CaseAddedOn { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CaseInvestigationReportOn { get; set; }

        public int CaseCurrentCourtId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CaseInvOfficerOn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Case_Criminal> Case_Criminal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Case_Plaintiff> Case_Plaintiff { get; set; }

        public virtual Police Police { get; set; }

        public virtual Police Police1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Case_Witness> Case_Witness { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Charge_Criminal_Case> Charge_Criminal_Case { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Verdict> Verdicts { get; set; }
    }
}
