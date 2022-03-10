using adduo.elephant.domain.entities.debts.bundler_items;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations.debts.bundler_items
{
    public class InstallmentBundlerConfiguration : IEntityTypeConfiguration<InstallmentBundler>
    {
        public void Configure(EntityTypeBuilder<InstallmentBundler> builder)
        {
            builder.ToTable("debt_bundler_installment_items");

            builder.Property(p => p.StartMonth).IsRequired();
            builder.Property(p => p.StartYear).IsRequired();
            builder.Property(p => p.Installments).IsRequired();
            builder.Property(p => p.StartPeriod).IsRequired();
            builder.Property(p => p.FinishPeriod).IsRequired();
        }
    }
}
