using adduo.elephant.domain.entities.debts.bundler_items;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations.debts.bundler_items
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("debt_bundler_items");

            builder.Property(p => p.Amount).IsRequired();

            builder.HasOne(o => o.BundlerMonthly)
                .WithMany(o => o.Items)
                .HasForeignKey(f => f.BundlerMonthlyId);
        }
    }
}
