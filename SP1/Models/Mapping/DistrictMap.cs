using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SP1.Models.Mapping
{
    public class DistrictMap : EntityTypeConfiguration<District>
    {
        public DistrictMap()
        {
            // Primary Key
            this.HasKey(t => t.DistrictId);

            // Properties
            this.Property(t => t.DistrictName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("District");
            this.Property(t => t.DistrictId).HasColumnName("DistrictId");
            this.Property(t => t.DistrictName).HasColumnName("DistrictName");
            this.Property(t => t.DivisionId).HasColumnName("DivisionId");

            // Relationships
            this.HasRequired(t => t.Division)
                .WithMany(t => t.Districts)
                .HasForeignKey(d => d.DivisionId);

        }
    }
}
