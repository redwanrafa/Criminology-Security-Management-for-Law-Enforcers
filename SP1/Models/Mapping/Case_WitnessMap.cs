using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SP1.Models.Mapping
{
    public class Case_WitnessMap : EntityTypeConfiguration<Case_Witness>
    {
        public Case_WitnessMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Case_Witness");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CaseId).HasColumnName("CaseId");
            this.Property(t => t.WitnessId).HasColumnName("WitnessId");
            this.Property(t => t.AddedOn).HasColumnName("AddedOn");

            // Relationships
            this.HasRequired(t => t.Case)
                .WithMany(t => t.Case_Witness)
                .HasForeignKey(d => d.CaseId);
            this.HasRequired(t => t.Witness)
                .WithMany(t => t.Case_Witness)
                .HasForeignKey(d => d.WitnessId);

        }
    }
}
