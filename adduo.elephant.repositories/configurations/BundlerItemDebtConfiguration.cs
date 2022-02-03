using adduo.elephant.domain.entities.debts.bundlers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations
{
    public class BundlerItemDebtConfiguration : IEntityTypeConfiguration<BundlerItemDebt>
    {
        public void Configure(EntityTypeBuilder<BundlerItemDebt> builder)
        {
            builder.ToTable("debt_bundler_items");

            builder.HasOne(o => o.MonthyBundlerItemDebt)
                .WithMany(o => o.BundlerItemDebts)
                .HasForeignKey(f => f.MonthyBundlerItemDebtId);
        }
    }
}
