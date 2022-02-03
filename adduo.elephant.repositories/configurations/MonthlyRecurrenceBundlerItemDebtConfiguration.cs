using adduo.elephant.domain.entities.debts.bundlers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations
{
    public class MonthlyRecurrenceBundlerItemDebtConfiguration : IEntityTypeConfiguration<MonthlyRecurrenceBundlerItemDebt>
    {
        public void Configure(EntityTypeBuilder<MonthlyRecurrenceBundlerItemDebt> builder)
        {
            builder.ToTable("debt_bundler_monthly_recurrence_items");
        }
    }
}
