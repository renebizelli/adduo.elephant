using adduo.elephant.domain.entities.debts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations
{
    public class ItemDebtConfiguration : IEntityTypeConfiguration<ItemDebt>
    {
        public void Configure(EntityTypeBuilder<ItemDebt> builder)
        {
            builder.ToTable("debt_items");

            builder.Property(p => p.DueDay)
                .IsRequired();

            builder.HasOne(o => o.InCome)
                .WithMany(m => m.ItemDebts)
                .HasForeignKey(f => f.InComeId);

            builder.HasMany(m => m.SpreadSheetItems)
                .WithOne(o => o.ItemDebt)
                .HasForeignKey(f => f.ItemDebtId);
        }
    }
}
