using adduo.elephant.domain.entities;
using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.entities.debts.items;
using adduo.elephant.repositories.extensions;
using Microsoft.EntityFrameworkCore;

namespace adduo.elephant.repositories
{
    public class ElephantContext : DbContext
    {
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<InCome> InComes { get; set; }

        //public virtual DbSet<Debt> Debts { get; set; }
        //public virtual DbSet<domain.entities.debts.items.Item> Items { get; set; }
        //public virtual DbSet<domain.entities.debts.items.ItemAmount> ItemAmounts { get; set; }
        public virtual DbSet<domain.entities.debts.items.Pontual> Pontuals { get; set; }
        public virtual DbSet<domain.entities.debts.items.Monthly> Monthlies { get; set; }
        public virtual DbSet<domain.entities.debts.items.Yearly> Yearlies { get; set; }
        public virtual DbSet<domain.entities.debts.items.Installment> Installments { get; set; }

        //public virtual DbSet<domain.entities.debts.bundler_items.Item> ItemBundlers { get; set; }
        public virtual DbSet<domain.entities.debts.bundler_items.Pontual> PontualBundlers { get; set; }
        public virtual DbSet<domain.entities.debts.bundler_items.Monthly> MonthlyBundlers { get; set; }
        public virtual DbSet<domain.entities.debts.bundler_items.Yearly> YearlyBundlers { get; set; }
        public virtual DbSet<domain.entities.debts.bundler_items.Installment> InstallmentBundlers { get; set; }
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
            //modelBuilder.ApplyConfiguration<Debt>(new configurations.debts.DebtConfiguration());
            //modelBuilder.ApplyConfiguration<Item>(new configurations.debts.items.ItemConfiguration());
            //modelBuilder.ApplyConfiguration<ItemAmount>(new configurations.debts.items.ItemAmountConfiguration());
            //modelBuilder.ApplyConfiguration<Pontual>(new configurations.debts.items.PontualConfiguration());
            //modelBuilder.ApplyConfiguration<Monthly>(new configurations.debts.items.MonthlyConfiguration());
            //modelBuilder.ApplyConfiguration<Yearly>(new configurations.debts.items.YearlyConfiguration());
            //modelBuilder.ApplyConfiguration<Installment>(new configurations.debts.items.InstallmentConfiguration());
            //modelBuilder.ApplyConfiguration<domain.entities.debts.bundler_items.Item>(new configurations.debts.bundler_items.ItemConfiguration());

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
