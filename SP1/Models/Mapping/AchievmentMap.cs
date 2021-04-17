using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SP1.Models.Mapping
{
    public class AchievmentMap : EntityTypeConfiguration<Achievment>
    {
        public AchievmentMap()
        {
            // Primary Key
            this.HasKey(t => t.AchievmentId);

            // Properties
            this.Property(t => t.AchievmentId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AchievmentName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Achievment");
            this.Property(t => t.AchievmentId).HasColumnName("AchievmentId");
            this.Property(t => t.AchievmentName).HasColumnName("AchievmentName");
            this.Property(t => t.AchievmentXP).HasColumnName("AchievmentXP");
        }
    }
}
