using adduo.elephant.domain.entities.debts.bundler_items;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations.debts.bundler_items
{
    public class MonthlyConfiguration : IEntityTypeConfiguration<Monthly>
    {
        public void Configure(EntityTypeBuilder<Monthly> builder)
        {
            builder.ToTable("debt_bundler_monthly_items");
        }
    }
}
