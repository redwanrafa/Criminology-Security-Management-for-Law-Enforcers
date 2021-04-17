using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SP1.Models.Mapping
{
    public class BranchMap : EntityTypeConfiguration<Branch>
    {
        public BranchMap()
        {
            // Primary Key
            this.HasKey(t => t.BranchId);

            // Properties
            this.Property(t => t.BranchName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Branch");
            this.Property(t => t.BranchId).HasColumnName("BranchId");
            this.Property(t => t.BranchName).HasColumnName("BranchName");
            this.Property(t => t.DistrictId).HasColumnName("DistrictId");

            // Relationships
            this.HasOptional(t => t.District)
                .WithMany(t => t.Branches)
                .HasForeignKey(d => d.DistrictId);

        }
    }
}
