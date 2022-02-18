using adduo.elephant.domain.entities.debts.items;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations.debts.items
{
    public class InstallmentConfiguration : IEntityTypeConfiguration<Installment>
    {
        public void Configure(EntityTypeBuilder<Installment> builder)
        {
            builder.ToTable("debt_installment_items");

            builder.Property(p => p.StartMonth).IsRequired();
            builder.Property(p => p.StartYear).IsRequired();
            builder.Property(p => p.Installments).IsRequired();
        }
    }
}
