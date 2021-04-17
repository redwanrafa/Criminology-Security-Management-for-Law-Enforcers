using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SP1.Models.Mapping
{
    public class Case_PlaintiffMap : EntityTypeConfiguration<Case_Plaintiff>
    {
        public Case_PlaintiffMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Case_Plaintiff");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CaseId).HasColumnName("CaseId");
            this.Property(t => t.PlaintiffId).HasColumnName("PlaintiffId");
            this.Property(t => t.AddedOn).HasColumnName("AddedOn");

            // Relationships
            this.HasRequired(t => t.Case)
                .WithMany(t => t.Case_Plaintiff)
                .HasForeignKey(d => d.CaseId);
            this.HasRequired(t => t.Plaintiff)
                .WithMany(t => t.Case_Plaintiff)
                .HasForeignKey(d => d.PlaintiffId);

        }
    }
}
