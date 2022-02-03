using adduo.elephant.domain.entities.debts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations
{
    public class MonthlyRecurrenceItemDebtConfiguration : IEntityTypeConfiguration<MonthlyRecurrenceItemDebt>
    {
        public void Configure(EntityTypeBuilder<MonthlyRecurrenceItemDebt> builder)
        {
            builder.ToTable("debt_monthly_recurrence_items");
        }
    }
}
