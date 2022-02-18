using adduo.elephant.domain.entities.debts.bundler_items;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations.debts.bundler_items
{
    public class InstallmentConfiguration : IEntityTypeConfiguration<Installment>
    {
        public void Configure(EntityTypeBuilder<Installment> builder)
        {
            builder.ToTable("debt_bundler_installment_items");

            builder.Property(p => p.StartMonth).IsRequired();
            builder.Property(p => p.StartYear).IsRequired();
            builder.Property(p => p.Installments).IsRequired();
        }
    }
}
