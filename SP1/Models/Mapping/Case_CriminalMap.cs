using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SP1.Models.Mapping
{
    public class Case_CriminalMap : EntityTypeConfiguration<Case_Criminal>
    {
        public Case_CriminalMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Case_Criminal");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CaseId).HasColumnName("CaseId");
            this.Property(t => t.CriminalId).HasColumnName("CriminalId");
            this.Property(t => t.AddedOn).HasColumnName("AddedOn");

            // Relationships
            this.HasRequired(t => t.Case)
                .WithMany(t => t.Case_Criminal)
                .HasForeignKey(d => d.CaseId);
            this.HasRequired(t => t.Criminal)
                .WithMany(t => t.Case_Criminal)
                .HasForeignKey(d => d.CriminalId);

        }
    }
}
