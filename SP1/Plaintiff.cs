namespace SP1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Plaintiff")]
    public partial class Plaintiff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Plaintiff()
        {
            Case_Plaintiff = new HashSet<Case_Plaintiff>();
        }

        public int PlaintiffId { get; set; }

        [Required]
        [StringLength(50)]
        public string PlaintiffName { get; set; }

        [Required]
        [StringLength(50)]
        public string PlaintiffFathersName { get; set; }

        [Required]
        [StringLength(50)]
        public string PlaintiffMothersName { get; set; }

        [Required]
        [StringLength(50)]
        public string PlaintiffAddress { get; set; }

        public int PlaintiffDivision { get; set; }

        public int PlaintiffDistrict { get; set; }

        public int PlaintiffBranch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Case_Plaintiff> Case_Plaintiff { get; set; }
    }
}
