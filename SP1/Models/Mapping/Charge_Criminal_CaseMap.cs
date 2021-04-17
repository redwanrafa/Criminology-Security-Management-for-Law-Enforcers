using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SP1.Models.Mapping
{
    public class Charge_Criminal_CaseMap : EntityTypeConfiguration<Charge_Criminal_Case>
    {
        public Charge_Criminal_CaseMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Charge_Criminal_Case");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CaseId).HasColumnName("CaseId");
            this.Property(t => t.CriminalId).HasColumnName("CriminalId");
            this.Property(t => t.ChargeId).HasColumnName("ChargeId");
            this.Property(t => t.ChargeAddedOn).HasColumnName("ChargeAddedOn");

            // Relationships
            this.HasRequired(t => t.Case)
                .WithMany(t => t.Charge_Criminal_Case)
                .HasForeignKey(d => d.CaseId);
            this.HasRequired(t => t.Criminal)
                .WithMany(t => t.Charge_Criminal_Case)
                .HasForeignKey(d => d.CriminalId);

        }
    }
}
