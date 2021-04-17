using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SP1.Models.Mapping
{
    public class ChargeMap : EntityTypeConfiguration<Charge>
    {
        public ChargeMap()
        {
            // Primary Key
            this.HasKey(t => t.ChargeId);

            // Properties
            this.Property(t => t.ChargeName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Charge");
            this.Property(t => t.ChargeId).HasColumnName("ChargeId");
            this.Property(t => t.ChargeName).HasColumnName("ChargeName");
            this.Property(t => t.CategoryId).HasColumnName("CategoryId");

            // Relationships
            this.HasRequired(t => t.CrimeCategory)
                .WithMany(t => t.Charges)
                .HasForeignKey(d => d.CategoryId);

        }
    }
}
