using adduo.elephant.domain.entities.debts.bundler_items;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations.debts.bundler_items
{
    public class YearlyBundlerConfiguration : IEntityTypeConfiguration<YearlyBundler>
    {
        public void Configure(EntityTypeBuilder<YearlyBundler> builder)
        {
            builder.ToTable("debt_bundler_yearly_items");

            builder.Property(p => p.DueMonth).IsRequired();
        }
    }
}
