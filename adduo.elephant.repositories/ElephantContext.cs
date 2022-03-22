using adduo.elephant.domain.entities;
using adduo.elephant.repositories.extensions;
using Microsoft.EntityFrameworkCore;

namespace adduo.elephant.repositories
{
    public class ElephantContext : DbContext
    {
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<InCome> InComes { get; set; }

        public virtual DbSet<domain.entities.debts_template.BundlerMonthlyTemplate> BundlerMonthlyTemplates { get; set; }
        public virtual DbSet<domain.entities.debts_template.InstallmentTemplate> InstallmentsTemplates { get; set; }
        public virtual DbSet<domain.entities.debts_template.MonthlyTemplate> MonthliesTemplates { get; set; }
        public virtual DbSet<domain.entities.debts_template.PontualTemplate> PontualsTemplates { get; set; }
        public virtual DbSet<domain.entities.debts_template.RecurrentTemplate> RecurrentsTemplates { get; set; }
        public virtual DbSet<domain.entities.debts_template.YearlyTemplate> YearliesTemplates { get; set; }


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
