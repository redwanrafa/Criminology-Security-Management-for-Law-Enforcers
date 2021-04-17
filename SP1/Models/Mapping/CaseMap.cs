using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SP1.Models.Mapping
{
    public class CaseMap : EntityTypeConfiguration<Case>
    {
        public CaseMap()
        {
            // Primary Key
            this.HasKey(t => t.CaseId);

            // Properties
            this.Property(t => t.CaseType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CaseDetails)
                .IsRequired();

            this.Property(t => t.CaseInventory)
                .IsRequired();

            this.Property(t => t.CaseStatus)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Case");
            this.Property(t => t.CaseId).HasColumnName("CaseId");
            this.Property(t => t.CaseType).HasColumnName("CaseType");
            this.Property(t => t.CaseDefendents).HasColumnName("CaseDefendents");
            this.Property(t => t.CrimeCategoryId).HasColumnName("CrimeCategoryId");
            this.Property(t => t.CaseDetails).HasColumnName("CaseDetails");
            this.Property(t => t.CaseDivisionId).HasColumnName("CaseDivisionId");
            this.Property(t => t.CaseDistrictId).HasColumnName("CaseDistrictId");
            this.Property(t => t.CaseBranchId).HasColumnName("CaseBranchId");
            this.Property(t => t.CaseInventory).HasColumnName("CaseInventory");
            this.Property(t => t.CaseInvestigationOfficerId).HasColumnName("CaseInvestigationOfficerId");
            this.Property(t => t.CasePlaintiffedOfficerId).HasColumnName("CasePlaintiffedOfficerId");
            this.Property(t => t.CaseStatus).HasColumnName("CaseStatus");
            this.Property(t => t.CaseInvestigationReport).HasColumnName("CaseInvestigationReport");
            this.Property(t => t.CaseAddedOn).HasColumnName("CaseAddedOn");
            this.Property(t => t.CaseInvestigationReportOn).HasColumnName("CaseInvestigationReportOn");
            this.Property(t => t.CaseCurrentCourtId).HasColumnName("CaseCurrentCourtId");
            this.Property(t => t.CaseInvOfficerOn).HasColumnName("CaseInvOfficerOn");

            // Relationships
            this.HasOptional(t => t.Police)
                .WithMany(t => t.Cases)
                .HasForeignKey(d => d.CasePlaintiffedOfficerId);
            this.HasRequired(t => t.Police1)
                .WithMany(t => t.Cases1)
                .HasForeignKey(d => d.CaseInvestigationOfficerId);

        }
    }
}
