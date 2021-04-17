using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SP1.Models.Mapping
{
    public class WitnessMap : EntityTypeConfiguration<Witness>
    {
        public WitnessMap()
        {
            // Primary Key
            this.HasKey(t => t.WitnessId);

            // Properties
            this.Property(t => t.WitnessName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.WitnessFathersName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.WitnessMothersName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.WitnessAddress)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Witness");
            this.Property(t => t.WitnessId).HasColumnName("WitnessId");
            this.Property(t => t.WitnessName).HasColumnName("WitnessName");
            this.Property(t => t.WitnessFathersName).HasColumnName("WitnessFathersName");
            this.Property(t => t.WitnessMothersName).HasColumnName("WitnessMothersName");
            this.Property(t => t.WitnessAddress).HasColumnName("WitnessAddress");
            this.Property(t => t.WitnessDivision).HasColumnName("WitnessDivision");
            this.Property(t => t.WitnessDistrict).HasColumnName("WitnessDistrict");
            this.Property(t => t.WitnessBranch).HasColumnName("WitnessBranch");
        }
    }
}
