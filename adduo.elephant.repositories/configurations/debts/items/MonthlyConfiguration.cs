using adduo.elephant.domain.entities.debts.items;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations.debts.items
{
    public class MonthlyConfiguration : IEntityTypeConfiguration<Monthly>
    {
        public void Configure(EntityTypeBuilder<Monthly> builder)
        {
            builder.ToTable("debt_monthly_items");
        }
    }
}
