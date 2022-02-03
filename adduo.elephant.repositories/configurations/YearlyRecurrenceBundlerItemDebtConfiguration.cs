using adduo.elephant.domain.entities.debts.bundlers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations
{
    public class YearlyRecurrenceBundlerItemDebtConfiguration : IEntityTypeConfiguration<YearlyRecurrenceBundlerItemDebt>
    {
        public void Configure(EntityTypeBuilder<YearlyRecurrenceBundlerItemDebt> builder)
        {
            builder.ToTable("debt_bundler_yearly_recurrence_items");
        }
    }
}
