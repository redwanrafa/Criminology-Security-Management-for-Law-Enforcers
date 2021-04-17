using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SP1.Models.Mapping
{
    public class DivisionMap : EntityTypeConfiguration<Division>
    {
        public DivisionMap()
        {
            // Primary Key
            this.HasKey(t => t.DivisionId);

            // Properties
            this.Property(t => t.DivisionName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Division");
            this.Property(t => t.DivisionId).HasColumnName("DivisionId");
            this.Property(t => t.DivisionName).HasColumnName("DivisionName");
        }
    }
}
