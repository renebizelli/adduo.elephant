using adduo.elephant.domain.entities.debts.items;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations.debts.items
{
    public class ItemAmountConfiguration : IEntityTypeConfiguration<ItemAmount>
    {
        public virtual void Configure(EntityTypeBuilder<ItemAmount> builder)
        {
            builder.ToTable("debt_amount_items");

            builder.Property(p => p.Amount)
                .HasColumnType("Decimal(18,2)")
                .IsRequired();

            //builder.HasDiscriminator<int>("Type")
            //    .HasValue<domain.entities.debts.items.Installment>(1)
            //    .HasValue<domain.entities.debts.items.Monthly>(2)
            //    .HasValue<domain.entities.debts.items.Monthly>(3)
            //    .HasValue<domain.entities.debts.items.Pontual>(4)
            //    .HasValue<domain.entities.debts.items.Yearly>(5);
        }
    }
}
