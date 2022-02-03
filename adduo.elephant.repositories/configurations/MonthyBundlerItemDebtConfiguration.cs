using adduo.elephant.domain.entities.debts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations
{
    public class MonthyBundlerItemDebtConfiguration : IEntityTypeConfiguration<MonthyBundlerItemDebt>
    {
        public void Configure(EntityTypeBuilder<MonthyBundlerItemDebt> builder)
        {
            builder.ToTable("debt_bundler_recurrence_items");

            builder.HasMany(m => m.BundlerItemDebts)
                .WithOne(o => o.MonthyBundlerItemDebt)
                .HasForeignKey(f => f.MonthyBundlerItemDebtId);
        }
    }
}
