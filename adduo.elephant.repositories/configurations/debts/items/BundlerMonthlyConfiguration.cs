using adduo.elephant.domain.entities.debts.items;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations.debts.items
{
    public class BundlerMonthlyConfiguration : IEntityTypeConfiguration<MonthlyBundler>
    {
        public void Configure(EntityTypeBuilder<MonthlyBundler> builder)
        {
            builder.ToTable("debt_monthly_bundlers");
        }
    }
}
