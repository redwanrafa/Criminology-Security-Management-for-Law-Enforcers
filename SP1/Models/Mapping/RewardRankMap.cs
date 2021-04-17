using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SP1.Models.Mapping
{
    public class RewardRankMap : EntityTypeConfiguration<RewardRank>
    {
        public RewardRankMap()
        {
            // Primary Key
            this.HasKey(t => t.RewardRankId);

            // Properties
            this.Property(t => t.RewardRankId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RewardRankName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RewardRank");
            this.Property(t => t.RewardRankId).HasColumnName("RewardRankId");
            this.Property(t => t.RewardRankName).HasColumnName("RewardRankName");
            this.Property(t => t.RewardRankXP).HasColumnName("RewardRankXP");
        }
    }
}
