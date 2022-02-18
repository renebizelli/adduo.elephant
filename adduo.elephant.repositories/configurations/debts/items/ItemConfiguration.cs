using adduo.elephant.domain.entities.debts.items;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations.debts.items
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("debt_items");

            builder.Property(p => p.DueDay)
                .IsRequired();

            builder.HasOne(o => o.InCome)
                .WithMany(m => m.ItemDebts)
                .HasForeignKey(f => f.InComeId);

            builder.HasMany(m => m.SpreadSheetItems)
                .WithOne(o => o.Item)
                .HasForeignKey(f => f.ItemId);
        }
    }
}
