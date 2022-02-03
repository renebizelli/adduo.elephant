using adduo.elephant.domain.entities.debts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations
{
    public class PontualItemDebtConfiguration : IEntityTypeConfiguration<PontualItemDebt>
    {
        public void Configure(EntityTypeBuilder<PontualItemDebt> builder)
        {
            builder.ToTable("debt_pontual_items");

            builder.Property(p => p.Month)
                .IsRequired();

            builder.Property(p => p.Year)
                .IsRequired();
        }
    }
}
