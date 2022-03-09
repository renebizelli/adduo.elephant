using adduo.elephant.domain.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace adduo.elephant.repositories.configurations
{
    public class SpreadSheetItemConfiguration : IEntityTypeConfiguration<SpreadSheetItem>
    {
        public void Configure(EntityTypeBuilder<SpreadSheetItem> builder)
        {
            builder.ToTable("spreadsheet_items");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.CurrentAmount)
                .HasColumnType("Decimal(18,2)")
                .IsRequired();

            builder.Property(p => p.PayedAmount)
                .HasColumnType("Decimal(18,2)")
                .IsRequired();

            builder.HasOne(o => o.Debt)
                .WithMany(m => m.SpreadSheetItems)
                .HasForeignKey(f => f.DebtId);

            builder.HasOne(o => o.SpreadSheet)
                .WithMany(m => m.Items)
                .HasForeignKey(f => f.SpreadSheetId);

        }
    }
}
