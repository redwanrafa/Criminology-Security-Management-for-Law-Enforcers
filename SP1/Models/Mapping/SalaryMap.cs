using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SP1.Models.Mapping
{
    public class SalaryMap : EntityTypeConfiguration<Salary>
    {
        public SalaryMap()
        {
            // Primary Key
            this.HasKey(t => t.Rank2Id);

            // Properties
            this.Property(t => t.Rank2Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Salary");
            this.Property(t => t.Rank2Id).HasColumnName("Rank2Id");
            this.Property(t => t.Salary1).HasColumnName("Salary");

            // Relationships
            this.HasRequired(t => t.Rank2)
                .WithOptional(t => t.Salary);

        }
    }
}
