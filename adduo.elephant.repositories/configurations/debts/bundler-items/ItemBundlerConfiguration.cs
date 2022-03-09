using adduo.elephant.domain.entities.debts.bundler_items;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations.debts.bundler_items
{
    public class ItemBundlerConfiguration : IEntityTypeConfiguration<ItemBundler>
    {
        public void Configure(EntityTypeBuilder<ItemBundler> builder)
        {
            builder.ToTable("debt_bundler_items");

            builder.HasOne(o => o.BundlerMonthly)
                .WithMany(o => o.Items)
                .HasForeignKey(f => f.BundlerMonthlyId);

            //builder.HasDiscriminator<int>("Type")
            //.HasValue<domain.entities.debts.bundler_items.Recurrent>(1)
            //.HasValue<domain.entities.debts.bundler_items.ItemAmount>(2);
        }
    }
}
