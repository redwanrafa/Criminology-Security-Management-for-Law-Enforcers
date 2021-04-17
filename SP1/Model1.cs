namespace SP1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Achievment> Achievments { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Case> Cases { get; set; }
        public virtual DbSet<Case_Criminal> Case_Criminal { get; set; }
        public virtual DbSet<Case_Plaintiff> Case_Plaintiff { get; set; }
        public virtual DbSet<Case_Witness> Case_Witness { get; set; }
        public virtual DbSet<Charge> Charges { get; set; }
        public virtual DbSet<Charge_Criminal_Case> Charge_Criminal_Case { get; set; }
        public virtual DbSet<Court> Courts { get; set; }
        public virtual DbSet<CrimeCategory> CrimeCategories { get; set; }
        public virtual DbSet<Criminal> Criminals { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<Notice> Notices { get; set; }
        public virtual DbSet<Plaintiff> Plaintiffs { get; set; }
        public virtual DbSet<Police> Police { get; set; }
        public virtual DbSet<Police_Achievment> Police_Achievment { get; set; }
        public virtual DbSet<Rank1> Rank1 { get; set; }
        public virtual DbSet<Rank2> Rank2 { get; set; }
        public virtual DbSet<RewardRank> RewardRanks { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
        public virtual DbSet<Unit1> Unit1 { get; set; }
        public virtual DbSet<Unit2> Unit2 { get; set; }
        public virtual DbSet<Verdict> Verdicts { get; set; }
        public virtual DbSet<Witness> Witnesses { get; set; }
        public virtual DbSet<Report> Reports { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Achievment>()
                .Property(e => e.AchievmentName)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.BranchName)
                .IsUnicode(false);

            modelBuilder.Entity<Case>()
                .Property(e => e.CaseType)
                .IsUnicode(false);

            modelBuilder.Entity<Case>()
                .Property(e => e.CaseDefendents)
                .IsUnicode(false);

            modelBuilder.Entity<Case>()
                .Property(e => e.CaseDetails)
                .IsUnicode(false);

            modelBuilder.Entity<Case>()
                .Property(e => e.CaseInventory)
                .IsUnicode(false);

            modelBuilder.Entity<Case>()
                .Property(e => e.CaseStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Case>()
                .Property(e => e.CaseInvestigationReport)
                .IsUnicode(false);

            modelBuilder.Entity<Case>()
                .HasMany(e => e.Case_Criminal)
                .WithRequired(e => e.Case)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Case>()
                .HasMany(e => e.Case_Plaintiff)
                .WithRequired(e => e.Case)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Case>()
                .HasMany(e => e.Case_Witness)
                .WithRequired(e => e.Case)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Case>()
                .HasMany(e => e.Charge_Criminal_Case)
                .WithRequired(e => e.Case)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Case>()
                .HasMany(e => e.Verdicts)
                .WithRequired(e => e.Case)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Charge>()
                .Property(e => e.ChargeName)
                .IsUnicode(false);

            modelBuilder.Entity<Court>()
                .Property(e => e.CourtName)
                .IsUnicode(false);

            modelBuilder.Entity<Court>()
                .Property(e => e.CaseType)
                .IsUnicode(false);

            modelBuilder.Entity<CrimeCategory>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<CrimeCategory>()
                .HasMany(e => e.Charges)
                .WithRequired(e => e.CrimeCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Criminal>()
                .Property(e => e.CriminalName)
                .IsUnicode(false);

            modelBuilder.Entity<Criminal>()
                .Property(e => e.CriminalAlternateName)
                .IsUnicode(false);

            modelBuilder.Entity<Criminal>()
                .Property(e => e.CriminalFathersName)
                .IsUnicode(false);

            modelBuilder.Entity<Criminal>()
                .Property(e => e.CriminalMothersName)
                .IsUnicode(false);

            modelBuilder.Entity<Criminal>()
                .Property(e => e.CriminalCurrentAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Criminal>()
                .Property(e => e.CriminalPermanentAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Criminal>()
                .Property(e => e.CriminalGender)
                .IsUnicode(false);

            modelBuilder.Entity<Criminal>()
                .Property(e => e.CriminalDateOfBirth)
                .IsUnicode(false);

            modelBuilder.Entity<Criminal>()
                .Property(e => e.CriminalBirthCertificateId)
                .IsUnicode(false);

            modelBuilder.Entity<Criminal>()
                .Property(e => e.CriminalNationalId)
                .IsUnicode(false);

            modelBuilder.Entity<Criminal>()
                .Property(e => e.CriminalDrivingLicenseId)
                .IsUnicode(false);

            modelBuilder.Entity<Criminal>()
                .Property(e => e.CriminalPassportId)
                .IsUnicode(false);

            modelBuilder.Entity<Criminal>()
                .Property(e => e.CriminalContactNo)
                .IsUnicode(false);

            modelBuilder.Entity<Criminal>()
                .Property(e => e.CriminalRemarkableMarks)
                .IsUnicode(false);

            modelBuilder.Entity<Criminal>()
                .Property(e => e.CriminalMaterialStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Criminal>()
                .Property(e => e.CriminalPartnerName)
                .IsUnicode(false);

            modelBuilder.Entity<Criminal>()
                .Property(e => e.CriminalStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Criminal>()
                .HasMany(e => e.Case_Criminal)
                .WithRequired(e => e.Criminal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Criminal>()
                .HasMany(e => e.Charge_Criminal_Case)
                .WithRequired(e => e.Criminal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<District>()
                .Property(e => e.DistrictName)
                .IsUnicode(false);

            modelBuilder.Entity<Division>()
                .Property(e => e.DivisionName)
                .IsUnicode(false);

            modelBuilder.Entity<Division>()
                .HasMany(e => e.Districts)
                .WithRequired(e => e.Division)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Notice>()
                .Property(e => e.NoticeSubject)
                .IsUnicode(false);

            modelBuilder.Entity<Notice>()
                .Property(e => e.Notice1)
                .IsUnicode(false);

            modelBuilder.Entity<Plaintiff>()
                .Property(e => e.PlaintiffName)
                .IsUnicode(false);

            modelBuilder.Entity<Plaintiff>()
                .Property(e => e.PlaintiffFathersName)
                .IsUnicode(false);

            modelBuilder.Entity<Plaintiff>()
                .Property(e => e.PlaintiffMothersName)
                .IsUnicode(false);

            modelBuilder.Entity<Plaintiff>()
                .Property(e => e.PlaintiffAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Plaintiff>()
                .HasMany(e => e.Case_Plaintiff)
                .WithRequired(e => e.Plaintiff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Police>()
                .Property(e => e.PoliceName)
                .IsUnicode(false);

            modelBuilder.Entity<Police>()
                .Property(e => e.PoliceFathersName)
                .IsUnicode(false);

            modelBuilder.Entity<Police>()
                .Property(e => e.PoliceMothersName)
                .IsUnicode(false);

            modelBuilder.Entity<Police>()
                .Property(e => e.PoliceCurrentAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Police>()
                .Property(e => e.PolicePermanentAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Police>()
                .Property(e => e.PoliceDateOfBirth)
                .IsUnicode(false);

            modelBuilder.Entity<Police>()
                .Property(e => e.PoliceGender)
                .IsUnicode(false);

            modelBuilder.Entity<Police>()
                .Property(e => e.PoliceBirthCertificateId)
                .IsUnicode(false);

            modelBuilder.Entity<Police>()
                .Property(e => e.PoliceNationalId)
                .IsUnicode(false);

            modelBuilder.Entity<Police>()
                .Property(e => e.PolicePassportId)
                .IsUnicode(false);

            modelBuilder.Entity<Police>()
                .Property(e => e.PoliceDrivingLicenseId)
                .IsUnicode(false);

            modelBuilder.Entity<Police>()
                .Property(e => e.PoliceMaterialStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Police>()
                .Property(e => e.PoliceEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Police>()
                .Property(e => e.PoliceContactNo)
                .IsUnicode(false);

            modelBuilder.Entity<Police>()
                .Property(e => e.PoliceUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Police>()
                .Property(e => e.PolicePassword)
                .IsUnicode(false);

            modelBuilder.Entity<Police>()
                .Property(e => e.PoliceStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Police>()
                .HasMany(e => e.Cases)
                .WithOptional(e => e.Police)
                .HasForeignKey(e => e.CasePlaintiffedOfficerId);

            modelBuilder.Entity<Police>()
                .HasMany(e => e.Cases1)
                .WithRequired(e => e.Police1)
                .HasForeignKey(e => e.CaseInvestigationOfficerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Police>()
                .HasMany(e => e.Police_Achievment)
                .WithRequired(e => e.Police)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rank1>()
                .Property(e => e.Rank1Name)
                .IsUnicode(false);

            modelBuilder.Entity<Rank1>()
                .HasMany(e => e.Rank2)
                .WithRequired(e => e.Rank1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rank2>()
                .Property(e => e.Rank2Name)
                .IsUnicode(false);

            modelBuilder.Entity<Rank2>()
                .HasOptional(e => e.Salary)
                .WithRequired(e => e.Rank2);

            modelBuilder.Entity<RewardRank>()
                .Property(e => e.RewardRankName)
                .IsUnicode(false);

            modelBuilder.Entity<Unit1>()
                .Property(e => e.Unit1Name)
                .IsUnicode(false);

            modelBuilder.Entity<Unit2>()
                .Property(e => e.Unit2Name)
                .IsUnicode(false);

            modelBuilder.Entity<Verdict>()
                .Property(e => e.Verdict1)
                .IsUnicode(false);

            modelBuilder.Entity<Witness>()
                .Property(e => e.WitnessName)
                .IsUnicode(false);

            modelBuilder.Entity<Witness>()
                .Property(e => e.WitnessFathersName)
                .IsUnicode(false);

            modelBuilder.Entity<Witness>()
                .Property(e => e.WitnessMothersName)
                .IsUnicode(false);

            modelBuilder.Entity<Witness>()
                .Property(e => e.WitnessAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Witness>()
                .HasMany(e => e.Case_Witness)
                .WithRequired(e => e.Witness)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Report>()
                .Property(e => e.MonthName)
                .IsUnicode(false);
        }
    }
}
