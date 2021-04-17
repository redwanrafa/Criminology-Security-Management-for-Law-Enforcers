using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SP1.Models.Mapping
{
    public class Rank2Map : EntityTypeConfiguration<Rank2>
    {
        public Rank2Map()
        {
            // Primary Key
            this.HasKey(t => t.Rank2Id);

            // Properties
            this.Property(t => t.Rank2Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Rank2");
            this.Property(t => t.Rank2Id).HasColumnName("Rank2Id");
            this.Property(t => t.Rank2Name).HasColumnName("Rank2Name");
            this.Property(t => t.Rank1Id).HasColumnName("Rank1Id");

            // Relationships
            this.HasRequired(t => t.Rank1)
                .WithMany(t => t.Rank2)
                .HasForeignKey(d => d.Rank1Id);

        }
    }
}
