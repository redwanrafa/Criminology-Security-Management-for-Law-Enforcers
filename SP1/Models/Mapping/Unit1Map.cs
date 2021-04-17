using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SP1.Models.Mapping
{
    public class Unit1Map : EntityTypeConfiguration<Unit1>
    {
        public Unit1Map()
        {
            // Primary Key
            this.HasKey(t => t.Unit1Id);

            // Properties
            this.Property(t => t.Unit1Name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Unit1");
            this.Property(t => t.Unit1Id).HasColumnName("Unit1Id");
            this.Property(t => t.Unit1Name).HasColumnName("Unit1Name");
        }
    }
}
