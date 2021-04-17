using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SP1.Models.Mapping
{
    public class CriminalMap : EntityTypeConfiguration<Criminal>
    {
        public CriminalMap()
        {
            // Primary Key
            this.HasKey(t => t.CriminalId);

            // Properties
            this.Property(t => t.CriminalName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CriminalAlternateName)
                .HasMaxLength(50);

            this.Property(t => t.CriminalFathersName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CriminalMothersName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CriminalCurrentAddress)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CriminalPermanentAddress)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CriminalGender)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CriminalDateOfBirth)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CriminalBirthCertificateId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CriminalNationalId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CriminalDrivingLicenseId)
                .HasMaxLength(50);

            this.Property(t => t.CriminalPassportId)
                .HasMaxLength(50);

            this.Property(t => t.CriminalContactNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CriminalRemarkableMarks)
                .HasMaxLength(500);

            this.Property(t => t.CriminalMaterialStatus)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CriminalPartnerName)
                .HasMaxLength(50);

            this.Property(t => t.CriminalStatus)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Criminal");
            this.Property(t => t.CriminalId).HasColumnName("CriminalId");
            this.Property(t => t.CriminalName).HasColumnName("CriminalName");
            this.Property(t => t.CriminalAlternateName).HasColumnName("CriminalAlternateName");
            this.Property(t => t.CriminalFathersName).HasColumnName("CriminalFathersName");
            this.Property(t => t.CriminalMothersName).HasColumnName("CriminalMothersName");
            this.Property(t => t.CriminalCurrentAddress).HasColumnName("CriminalCurrentAddress");
            this.Property(t => t.CriminalPermanentAddress).HasColumnName("CriminalPermanentAddress");
            this.Property(t => t.CriminalGender).HasColumnName("CriminalGender");
            this.Property(t => t.CriminalDateOfBirth).HasColumnName("CriminalDateOfBirth");
            this.Property(t => t.CriminalDivision).HasColumnName("CriminalDivision");
            this.Property(t => t.CriminalDistrict).HasColumnName("CriminalDistrict");
            this.Property(t => t.CriminalBranch).HasColumnName("CriminalBranch");
            this.Property(t => t.CriminalBirthCertificateId).HasColumnName("CriminalBirthCertificateId");
            this.Property(t => t.CriminalNationalId).HasColumnName("CriminalNationalId");
            this.Property(t => t.CriminalDrivingLicenseId).HasColumnName("CriminalDrivingLicenseId");
            this.Property(t => t.CriminalPassportId).HasColumnName("CriminalPassportId");
            this.Property(t => t.CriminalContactNo).HasColumnName("CriminalContactNo");
            this.Property(t => t.CriminalRemarkableMarks).HasColumnName("CriminalRemarkableMarks");
            this.Property(t => t.CriminalMaterialStatus).HasColumnName("CriminalMaterialStatus");
            this.Property(t => t.CriminalPartnerName).HasColumnName("CriminalPartnerName");
            this.Property(t => t.CriminalNoOfChild).HasColumnName("CriminalNoOfChild");
            this.Property(t => t.CriminalAddedOn).HasColumnName("CriminalAddedOn");
            this.Property(t => t.CriminalStatus).HasColumnName("CriminalStatus");
        }
    }
}
