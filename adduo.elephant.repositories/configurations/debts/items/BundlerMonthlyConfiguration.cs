using adduo.elephant.domain.entities.debts.items;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations.debts.items
{
    public class BundlerMonthlyConfiguration : IEntityTypeConfiguration<BundlerMonthly>
    {
        public void Configure(EntityTypeBuilder<BundlerMonthly> builder)
        {
            builder.ToTable("debt_monthly_bundlers");
        }
    }
}
