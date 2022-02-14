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

            builder.HasOne(o => o.ItemDebt)
                .WithMany(m => m.SpreadSheetItems)
                .HasForeignKey(f => f.ItemDebtId);

            builder.HasOne(o => o.SpreadSheet)
                .WithMany(m => m.Items)
                .HasForeignKey(f => f.SpreadSheetId);

        }
    }
}
