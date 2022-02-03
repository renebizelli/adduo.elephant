using adduo.elephant.domain.entities.debts.bundlers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations
{
    public class InstallmentsBundlerItemDebtConfiguration : IEntityTypeConfiguration<InstallmentsBundlerItemDebt>
    {
        public void Configure(EntityTypeBuilder<InstallmentsBundlerItemDebt> builder)
        {
            builder.ToTable("debt_bundler_installment_items");
        }
    }
}
