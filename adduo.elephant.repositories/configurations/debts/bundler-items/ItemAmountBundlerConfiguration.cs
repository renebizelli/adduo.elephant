using adduo.elephant.domain.entities.debts.bundler_items;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations.debts.bundler_items
{
    public class ItemAmountBundlerConfiguration : IEntityTypeConfiguration<ItemAmountBundler>
    {
        public virtual void Configure(EntityTypeBuilder<ItemAmountBundler> builder)
        {
            builder.ToTable("debt_bundler_amount_items");

            builder.Property(p => p.Amount)
                .HasColumnType("Decimal(18,2)")
                .IsRequired();

            //builder.HasDiscriminator<int>("Type")
            //    .HasValue<domain.entities.debts.bundler_items.Installment>(1)
            //    .HasValue<domain.entities.debts.bundler_items.Monthly>(2)
            //    .HasValue<domain.entities.debts.bundler_items.Monthly>(3)
            //    .HasValue<domain.entities.debts.bundler_items.Pontual>(4)
            //    .HasValue<domain.entities.debts.bundler_items.Yearly>(5);
        }
    }
}
