using adduo.elephant.domain.entities;
using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.entities.debts.bundlers;
using adduo.elephant.repositories.configurations;
using adduo.elephant.repositories.extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection;

namespace adduo.elephant.repositories
{
    public class ElephantContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<InCome> InComes { get; set; }
        public DbSet<ItemDebt> ItemDebts { get; set; }
        public DbSet<PontualItemDebt> PontualItemDebts { get; set; }
        public DbSet<MonthlyRecurrenceItemDebt> MonthlyRecurrenceItemDebts { get; set; }
        public DbSet<YearlyRecurrenceItemDebt> YearlyRecurrenceItemDebts { get; set; }
        public DbSet<InstallmentsItemDebt> InstallmentstemDebts { get; set; }

        public DbSet<BundlerItemDebt> BundlerItemDebts { get; set; }
        public DbSet<PontualBundlerItemDebt> PontualBundlerItemDebts { get; set; }
        public DbSet<MonthlyRecurrenceBundlerItemDebt> MonthlyRecurrenceBundlerItemDebts { get; set; }
        public DbSet<YearlyRecurrenceBundlerItemDebt> YearlyRecurrenceBundlerItemDebts { get; set; }
        public DbSet<InstallmentsBundlerItemDebt> InstallmentsBundlerItemDebts { get; set; }
        

        public ElephantContext()
        {
            //Database.EnsureCreated();
        }

        public ElephantContext(DbContextOptions<ElephantContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ElephantContext).Assembly);

            modelBuilder.Seeds();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost; port=3306; database=elephant; user=root; password=root; Persist Security Info=False; Connect Timeout=300";

            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            base.OnConfiguring(optionsBuilder);
        }
    }
}
