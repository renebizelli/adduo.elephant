using adduo.elephant.domain.entities.debts.items;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations.debts.items
{
    public class YearlyConfiguration : IEntityTypeConfiguration<Yearly>
    {
        public void Configure(EntityTypeBuilder<Yearly> builder)
        {
            builder.ToTable("debt_yearly_items");

            builder.Property(p => p.DueMonth).IsRequired();
        }
    }
}
