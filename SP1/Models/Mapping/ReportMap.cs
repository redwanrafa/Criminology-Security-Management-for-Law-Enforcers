using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SP1.Models.Mapping
{
    public class ReportMap : EntityTypeConfiguration<Report>
    {
        public ReportMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MonthId, t.MonthName });

            // Properties
            this.Property(t => t.MonthId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MonthName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Report");
            this.Property(t => t.MonthId).HasColumnName("MonthId");
            this.Property(t => t.MonthName).HasColumnName("MonthName");
            this.Property(t => t.NoOfCaseAdded).HasColumnName("NoOfCaseAdded");
            this.Property(t => t.NoOfCaseSolved).HasColumnName("NoOfCaseSolved");
        }
    }
}
