namespace SP1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Witness")]
    public partial class Witness
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Witness()
        {
            Case_Witness = new HashSet<Case_Witness>();
        }

        public int WitnessId { get; set; }

        [Required]
        [StringLength(50)]
        public string WitnessName { get; set; }

        [Required]
        [StringLength(50)]
        public string WitnessFathersName { get; set; }

        [Required]
        [StringLength(50)]
        public string WitnessMothersName { get; set; }

        [Required]
        [StringLength(50)]
        public string WitnessAddress { get; set; }

        public int WitnessDivision { get; set; }

        public int WitnessDistrict { get; set; }

        public int WitnessBranch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Case_Witness> Case_Witness { get; set; }
    }
}
