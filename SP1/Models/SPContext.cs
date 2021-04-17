using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using SP1.Models.Mapping;

namespace SP1.Models
{
    public partial class SPContext : DbContext
    {
        static SPContext()
        {
            Database.SetInitializer<SPContext>(null);
        }

        public SPContext()
            : base("Name=SPContext")
        {
        }

        public DbSet<Achievment> Achievments { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<Case_Criminal> Case_Criminal { get; set; }
        public DbSet<Case_Plaintiff> Case_Plaintiff { get; set; }
        public DbSet<Case_Witness> Case_Witness { get; set; }
        public DbSet<Charge> Charges { get; set; }
        public DbSet<Charge_Criminal_Case> Charge_Criminal_Case { get; set; }
        public DbSet<Court> Courts { get; set; }
        public DbSet<CrimeCategory> CrimeCategories { get; set; }
        public DbSet<Criminal> Criminals { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Notice> Notices { get; set; }
        public DbSet<Plaintiff> Plaintiffs { get; set; }
        public DbSet<Police> Police { get; set; }
        public DbSet<Police_Achievment> Police_Achievment { get; set; }
        public DbSet<Rank1> Rank1 { get; set; }
        public DbSet<Rank2> Rank2 { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<RewardRank> RewardRanks { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Unit1> Unit1 { get; set; }
        public DbSet<Unit2> Unit2 { get; set; }
        public DbSet<Verdict> Verdicts { get; set; }
        public DbSet<Witness> Witnesses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AchievmentMap());
            modelBuilder.Configurations.Add(new BranchMap());
            modelBuilder.Configurations.Add(new CaseMap());
            modelBuilder.Configurations.Add(new Case_CriminalMap());
            modelBuilder.Configurations.Add(new Case_PlaintiffMap());
            modelBuilder.Configurations.Add(new Case_WitnessMap());
            modelBuilder.Configurations.Add(new ChargeMap());
            modelBuilder.Configurations.Add(new Charge_Criminal_CaseMap());
            modelBuilder.Configurations.Add(new CourtMap());
            modelBuilder.Configurations.Add(new CrimeCategoryMap());
            modelBuilder.Configurations.Add(new CriminalMap());
            modelBuilder.Configurations.Add(new DistrictMap());
            modelBuilder.Configurations.Add(new DivisionMap());
            modelBuilder.Configurations.Add(new NoticeMap());
            modelBuilder.Configurations.Add(new PlaintiffMap());
            modelBuilder.Configurations.Add(new PoliceMap());
            modelBuilder.Configurations.Add(new Police_AchievmentMap());
            modelBuilder.Configurations.Add(new Rank1Map());
            modelBuilder.Configurations.Add(new Rank2Map());
            modelBuilder.Configurations.Add(new ReportMap());
            modelBuilder.Configurations.Add(new RewardRankMap());
            modelBuilder.Configurations.Add(new SalaryMap());
            modelBuilder.Configurations.Add(new Unit1Map());
            modelBuilder.Configurations.Add(new Unit2Map());
            modelBuilder.Configurations.Add(new VerdictMap());
            modelBuilder.Configurations.Add(new WitnessMap());
        }
    }
}
