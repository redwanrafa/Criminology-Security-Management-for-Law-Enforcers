using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SP1.Models.Mapping
{
    public class PlaintiffMap : EntityTypeConfiguration<Plaintiff>
    {
        public PlaintiffMap()
        {
            // Primary Key
            this.HasKey(t => t.PlaintiffId);

            // Properties
            this.Property(t => t.PlaintiffName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PlaintiffFathersName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PlaintiffMothersName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PlaintiffAddress)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Plaintiff");
            this.Property(t => t.PlaintiffId).HasColumnName("PlaintiffId");
            this.Property(t => t.PlaintiffName).HasColumnName("PlaintiffName");
            this.Property(t => t.PlaintiffFathersName).HasColumnName("PlaintiffFathersName");
            this.Property(t => t.PlaintiffMothersName).HasColumnName("PlaintiffMothersName");
            this.Property(t => t.PlaintiffAddress).HasColumnName("PlaintiffAddress");
            this.Property(t => t.PlaintiffDivision).HasColumnName("PlaintiffDivision");
            this.Property(t => t.PlaintiffDistrict).HasColumnName("PlaintiffDistrict");
            this.Property(t => t.PlaintiffBranch).HasColumnName("PlaintiffBranch");
        }
    }
}
