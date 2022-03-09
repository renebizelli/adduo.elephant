using adduo.elephant.domain.entities.debts.bundler_items;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations.debts.bundler_items
{
    public class MonthlyBundlerConfiguration : IEntityTypeConfiguration<MonthlyBundler>
    {
        public void Configure(EntityTypeBuilder<MonthlyBundler> builder)
        {
            builder.ToTable("debt_bundler_monthly_items");
        }
    }
}
