using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SP1.Models.Mapping
{
    public class Rank1Map : EntityTypeConfiguration<Rank1>
    {
        public Rank1Map()
        {
            // Primary Key
            this.HasKey(t => t.Rank1Id);

            // Properties
            this.Property(t => t.Rank1Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Rank1");
            this.Property(t => t.Rank1Id).HasColumnName("Rank1Id");
            this.Property(t => t.Rank1Name).HasColumnName("Rank1Name");
        }
    }
}
