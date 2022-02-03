using adduo.elephant.domain.entities.debts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations
{
    public class InstallmentsItemDebtConfiguration : IEntityTypeConfiguration<InstallmentsItemDebt>
    {
        public void Configure(EntityTypeBuilder<InstallmentsItemDebt> builder)
        {
            builder.ToTable("debt_installment_items");
        }
    }
}
