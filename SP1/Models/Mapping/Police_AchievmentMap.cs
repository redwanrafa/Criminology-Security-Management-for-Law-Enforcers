using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SP1.Models.Mapping
{
    public class Police_AchievmentMap : EntityTypeConfiguration<Police_Achievment>
    {
        public Police_AchievmentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Police_Achievment");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PoliceId).HasColumnName("PoliceId");
            this.Property(t => t.AchievmentId).HasColumnName("AchievmentId");

            // Relationships
            this.HasRequired(t => t.Police)
                .WithMany(t => t.Police_Achievment)
                .HasForeignKey(d => d.PoliceId);

        }
    }
}
