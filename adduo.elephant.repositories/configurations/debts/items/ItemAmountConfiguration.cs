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
        }
    }
}
