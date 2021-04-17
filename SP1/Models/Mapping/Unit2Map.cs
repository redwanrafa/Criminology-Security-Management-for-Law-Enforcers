using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SP1.Models.Mapping
{
    public class Unit2Map : EntityTypeConfiguration<Unit2>
    {
        public Unit2Map()
        {
            // Primary Key
            this.HasKey(t => t.Unit2Id);

            // Properties
            this.Property(t => t.Unit2Name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Unit2");
            this.Property(t => t.Unit2Id).HasColumnName("Unit2Id");
            this.Property(t => t.Unit2Name).HasColumnName("Unit2Name");
            this.Property(t => t.Unit1Id).HasColumnName("Unit1Id");

            // Relationships
            this.HasOptional(t => t.Unit1)
                .WithMany(t => t.Unit2)
                .HasForeignKey(d => d.Unit1Id);

        }
    }
}
