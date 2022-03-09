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
                .WithMany()
                .HasForeignKey(f => f.InComeId);

            //builder.HasDiscriminator<int>("Type")
            //    .HasValue<domain.entities.debts.items.ItemAmount>(1)
            //    .HasValue<domain.entities.debts.items.MonthlyBundler>(2);

        }
    }
}
