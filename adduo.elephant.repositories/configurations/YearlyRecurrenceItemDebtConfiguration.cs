using adduo.elephant.domain.entities.debts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations
{
    public class YearlyRecurrenceItemDebtConfiguration : IEntityTypeConfiguration<YearlyRecurrenceItemDebt>
    {
        public void Configure(EntityTypeBuilder<YearlyRecurrenceItemDebt> builder)
        {
            builder.ToTable("debt_yearly_recurrence_items");
        }
    }
}
