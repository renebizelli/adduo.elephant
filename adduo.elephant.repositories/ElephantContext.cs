using adduo.elephant.domain.entities;
using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.entities.debts.bundlers;
using adduo.elephant.repositories.extensions;
using Microsoft.EntityFrameworkCore;

namespace adduo.elephant.repositories
{
    public class ElephantContext : DbContext
    {
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<InCome> InComes { get; set; }
        public virtual DbSet<Debt> Debts { get; set; }
        public virtual DbSet<ItemDebt> ItemDebts { get; set; }
        public virtual DbSet<PontualItemDebt> PontualItemDebts { get; set; }
        public virtual DbSet<MonthlyRecurrenceItemDebt> MonthlyRecurrenceItemDebts { get; set; }
        public virtual DbSet<YearlyRecurrenceItemDebt> YearlyRecurrenceItemDebts { get; set; }
        public virtual DbSet<InstallmentsItemDebt> InstallmentstemDebts { get; set; }

        public virtual DbSet<BundlerItemDebt> BundlerItemDebts { get; set; }
        public virtual DbSet<PontualBundlerItemDebt> PontualBundlerItemDebts { get; set; }
        public virtual DbSet<MonthlyRecurrenceBundlerItemDebt> MonthlyRecurrenceBundlerItemDebts { get; set; }
        public virtual DbSet<YearlyRecurrenceBundlerItemDebt> YearlyRecurrenceBundlerItemDebts { get; set; }
        public virtual DbSet<InstallmentsBundlerItemDebt> InstallmentsBundlerItemDebts { get; set; }
        public virtual DbSet<SpreadSheet> SpreadSheets { get; set; }

        public ElephantContext()
        {
        }

        public ElephantContext(DbContextOptions<ElephantContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ElephantContext).Assembly);

            modelBuilder.Seeds();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "server=localhost; port=3306; database=elephant; user=root; password=root; Persist Security Info=False; Connect Timeout=300";
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }

            base.OnConfiguring(optionsBuilder);
        }
    }
}
