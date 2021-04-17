using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SP1.Models.Mapping
{
    public class CourtMap : EntityTypeConfiguration<Court>
    {
        public CourtMap()
        {
            // Primary Key
            this.HasKey(t => t.CourtId);

            // Properties
            this.Property(t => t.CourtId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CourtName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CaseType)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Court");
            this.Property(t => t.CourtId).HasColumnName("CourtId");
            this.Property(t => t.CourtName).HasColumnName("CourtName");
            this.Property(t => t.CaseType).HasColumnName("CaseType");
        }
    }
}
