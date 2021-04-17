using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SP1.Models.Mapping
{
    public class VerdictMap : EntityTypeConfiguration<Verdict>
    {
        public VerdictMap()
        {
            // Primary Key
            this.HasKey(t => t.VerdictId);

            // Properties
            this.Property(t => t.Verdict1)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Verdict");
            this.Property(t => t.VerdictId).HasColumnName("VerdictId");
            this.Property(t => t.Verdict1).HasColumnName("Verdict");
            this.Property(t => t.CaseId).HasColumnName("CaseId");
            this.Property(t => t.CourtId).HasColumnName("CourtId");
            this.Property(t => t.VerdictAddedOn).HasColumnName("VerdictAddedOn");

            // Relationships
            this.HasRequired(t => t.Case)
                .WithMany(t => t.Verdicts)
                .HasForeignKey(d => d.CaseId);

        }
    }
}
