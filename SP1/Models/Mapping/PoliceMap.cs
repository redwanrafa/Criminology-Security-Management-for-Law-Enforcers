using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SP1.Models.Mapping
{
    public class PoliceMap : EntityTypeConfiguration<Police>
    {
        public PoliceMap()
        {
            // Primary Key
            this.HasKey(t => t.PoliceId);

            // Properties
            this.Property(t => t.PoliceName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PoliceFathersName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PoliceMothersName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PoliceCurrentAddress)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PolicePermanentAddress)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PoliceDateOfBirth)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PoliceGender)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PoliceBirthCertificateId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PoliceNationalId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PolicePassportId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PoliceDrivingLicenseId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PoliceMaterialStatus)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PoliceEmail)
                .HasMaxLength(50);

            this.Property(t => t.PoliceContactNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PoliceUserName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PolicePassword)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PoliceStatus)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Police");
            this.Property(t => t.PoliceId).HasColumnName("PoliceId");
            this.Property(t => t.PoliceName).HasColumnName("PoliceName");
            this.Property(t => t.PoliceFathersName).HasColumnName("PoliceFathersName");
            this.Property(t => t.PoliceMothersName).HasColumnName("PoliceMothersName");
            this.Property(t => t.PoliceCurrentAddress).HasColumnName("PoliceCurrentAddress");
            this.Property(t => t.PolicePermanentAddress).HasColumnName("PolicePermanentAddress");
            this.Property(t => t.PoliceDateOfBirth).HasColumnName("PoliceDateOfBirth");
            this.Property(t => t.PoliceGender).HasColumnName("PoliceGender");
            this.Property(t => t.PoliceBirthCertificateId).HasColumnName("PoliceBirthCertificateId");
            this.Property(t => t.PoliceNationalId).HasColumnName("PoliceNationalId");
            this.Property(t => t.PolicePassportId).HasColumnName("PolicePassportId");
            this.Property(t => t.PoliceDrivingLicenseId).HasColumnName("PoliceDrivingLicenseId");
            this.Property(t => t.PoliceMaterialStatus).HasColumnName("PoliceMaterialStatus");
            this.Property(t => t.PoliceCurrentRank1).HasColumnName("PoliceCurrentRank1");
            this.Property(t => t.PoliceCurrentRank2).HasColumnName("PoliceCurrentRank2");
            this.Property(t => t.PoliceCurrentUnit1).HasColumnName("PoliceCurrentUnit1");
            this.Property(t => t.PoliceCurrentUnit2).HasColumnName("PoliceCurrentUnit2");
            this.Property(t => t.PoliceDivision).HasColumnName("PoliceDivision");
            this.Property(t => t.PoliceDistrict).HasColumnName("PoliceDistrict");
            this.Property(t => t.PoliceBranch).HasColumnName("PoliceBranch");
            this.Property(t => t.PoliceEmail).HasColumnName("PoliceEmail");
            this.Property(t => t.PoliceContactNo).HasColumnName("PoliceContactNo");
            this.Property(t => t.PoliceUserName).HasColumnName("PoliceUserName");
            this.Property(t => t.PolicePassword).HasColumnName("PolicePassword");
            this.Property(t => t.PoliceJoiningRank).HasColumnName("PoliceJoiningRank");
            this.Property(t => t.PoliceJoiningDate).HasColumnName("PoliceJoiningDate");
            this.Property(t => t.PoliceRewardRankId).HasColumnName("PoliceRewardRankId");
            this.Property(t => t.PoliceXP).HasColumnName("PoliceXP");
            this.Property(t => t.PoliceStatus).HasColumnName("PoliceStatus");
        }
    }
}
