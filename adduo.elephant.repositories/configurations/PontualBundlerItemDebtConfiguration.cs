using adduo.elephant.domain.entities.debts.bundlers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations
{
    public class PontualBundlerItemDebtConfiguration : IEntityTypeConfiguration<PontualBundlerItemDebt>
    {
        public void Configure(EntityTypeBuilder<PontualBundlerItemDebt> builder)
        {
            builder.ToTable("debt_bundler_pontual_items");

            builder.Property(p => p.Month)
                .IsRequired();

            builder.Property(p => p.Year)
                .IsRequired();
        }
    }
}
